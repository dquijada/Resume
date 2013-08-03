using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Resume.Core;

namespace Resume.Droid
{
	public class ExperienceFragment : Fragment
	{
		public override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Create your fragment here
		}

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			base.OnCreateView (inflater, container, savedInstanceState);

			var view = inflater.Inflate (Resource.Layout.Experience, container, false);

			var list = view.FindViewById<ListView> (Resource.Id.experience_list);
			var adapter = new ExperienceAdapter (inflater, ResumeViewModel.Current.Experience);
			list.SetAdapter (adapter);

			list.ItemClick += HandleItemClick;

			return view;
		}

		void HandleItemClick (object sender, AdapterView.ItemClickEventArgs e)
		{
			var intent = new Intent(Activity,typeof(CustomListActivity));
			intent.PutExtra ("position", e.Position);
			StartActivity (intent);
		}
	}
}

