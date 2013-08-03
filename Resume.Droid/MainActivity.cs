using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using Android.Support.V4.Widget;
using Resume.Core;

namespace Resume.Droid
{
	[Activity (Label = "Resume", MainLauncher = true)]
	public class MainActivity : Activity
	{
		string[] optionNames;
		List<Fragment> fragments;
		InfoFragment infoFragment;
		EducationFragment educationFragment;
		ExperienceFragment experienceFragment;
		KnowledgeFragment knowledgeFragment;
		DrawerLayout drawer;
		ListView list;
		MyActionBarDrawerToggle toggle;
		string title;

		protected async override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			ActionBar.SetDisplayHomeAsUpEnabled(true);
			ActionBar.SetHomeButtonEnabled (true);

			SetContentView (Resource.Layout.Main);

			optionNames = new string[] 
			{ 
				Resource.String.MenuItem1.Localize(this), 
				Resource.String.MenuItem2.Localize(this), 
				Resource.String.MenuItem3.Localize(this), 
				Resource.String.MenuItem4.Localize(this)
			};

			infoFragment = new InfoFragment ();
			educationFragment = new EducationFragment ();
			experienceFragment = new ExperienceFragment ();
			knowledgeFragment = new KnowledgeFragment ();

			fragments = new List<Fragment> { 
				infoFragment,
				educationFragment,
				experienceFragment,
				knowledgeFragment
			};

			drawer = FindViewById<DrawerLayout> (Resource.Id.drawer_layout);
			list = FindViewById<ListView> (Resource.Id.left_drawer);

			drawer.SetDrawerShadow (Resource.Drawable.drawer_shadow_light, (int)GravityFlags.Start);

			list.Adapter = new NavigationDrawerAdapter (optionNames, LayoutInflater);

			list.ItemClick += (sender, args) => SelectItem(args.Position);

			toggle = new MyActionBarDrawerToggle (this, drawer,
			                                      Resource.Drawable.ic_drawer_light,
			                                      Resource.String.DrawerOpen,
			                                      Resource.String.DrawerClose);

			toggle.DrawerIndicatorEnabled = true;
			toggle.DrawerClosed += delegate
			{
				ActionBar.Title = title;
				InvalidateOptionsMenu();
			};

			toggle.DrawerOpened += delegate
			{
				ActionBar.Title = Resource.String.SelectOption.Localize(this);
				InvalidateOptionsMenu();
			};

			drawer.SetDrawerListener (toggle);
			
			DeviceContext.Current.Context = this;
			ResumeSharedController.Current.Address = Resource.String.ResumeUrl.Localize (this);
			await ResumeSharedController.Current.GetResumeAsync (Success, SomethingWentWrong);
		}

		void Success()
		{
			SelectItem (0);
		}

		void SomethingWentWrong(Exception e)
		{
			Toast.MakeText (this, Resource.String.SomethingWrong.Localize(this), ToastLength.Long).Show ();
		}

		public override bool OnOptionsItemSelected (IMenuItem item)
		{
			if(toggle != null && toggle.OnOptionsItemSelected(item))
				return true;

			return base.OnOptionsItemSelected (item);
		}

		protected override void OnPostCreate (Bundle savedInstanceState)
		{
			base.OnPostCreate (savedInstanceState);
			if(toggle != null)
				toggle.SyncState ();
		}

		public override void OnConfigurationChanged (Android.Content.Res.Configuration newConfig)
		{
			base.OnConfigurationChanged (newConfig);
			toggle.OnConfigurationChanged (newConfig);
		}

		private void SelectItem(int position)
		{
			FragmentManager.BeginTransaction()
				.Replace(Resource.Id.main, fragments [position])
					.Commit();

			list.SetItemChecked(position, true);
			ActionBar.Title = title = optionNames[position];
			drawer.CloseDrawer(list);
		}
	}
}


