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
	public class EducationFragment : Fragment
	{
		public override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Create your fragment here
		}

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			base.OnCreateView (inflater, container, savedInstanceState);
			var view = inflater.Inflate (Resource.Layout.Education, container, false);

			var listView = view.FindViewById<ListView> (Resource.Id.education_list);
			var adapter = new EducationAdapter (inflater, ResumeViewModel.Current.Education);
			listView.SetAdapter (adapter);

			return view;
		}
	}
}

