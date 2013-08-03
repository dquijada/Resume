using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Resume.Core;

namespace Resume.Droid
{
	[Activity (Label = "CustomListActivity", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]			
	public class CustomListActivity : ListActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			ActionBar.SetDisplayHomeAsUpEnabled (true);

			var position = Intent.GetIntExtra ("position",0);
			Title = ResumeViewModel.Current.Experience [position].Name;

			SetContentView (Resource.Layout.CustomList);

			var adapter = new CustomListAdapter (LayoutInflater, ResumeViewModel.Current.Experience[position].Responsabilities);

			ListAdapter = adapter;
		}

		public override bool OnOptionsItemSelected (IMenuItem item)
		{
			switch (item.ItemId) {
				case Android.Resource.Id.Home:
				Finish ();
				return true;
				default:
				return base.OnOptionsItemSelected (item);
			}
		}
	}
}

