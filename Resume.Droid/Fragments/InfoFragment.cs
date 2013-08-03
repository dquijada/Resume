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
	public class InfoFragment : Fragment
	{
		public override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Create your fragment here
		}

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			base.OnCreateView (inflater, container, savedInstanceState);
			var view = inflater.Inflate (Resource.Layout.InfoLayout, container, false);

			var name = view.FindViewById<TextView> (Resource.Id.name);
			var address = view.FindViewById<TextView> (Resource.Id.address);
			var location = view.FindViewById<TextView> (Resource.Id.location);
			var phoneNumber = view.FindViewById<TextView> (Resource.Id.phone_number);
			var email = view.FindViewById<TextView> (Resource.Id.email);
			var objective = view.FindViewById<TextView> (Resource.Id.objective);

			var info = ResumeViewModel.Current.Info;
			name.SetText (info.Name, TextView.BufferType.Normal);
			address.SetText (info.Address, TextView.BufferType.Normal);
			location.SetText (info.Location, TextView.BufferType.Normal);
			phoneNumber.SetText (info.PhoneNumber, TextView.BufferType.Normal);
			email.SetText (info.Email, TextView.BufferType.Normal);
			objective.SetText (ResumeViewModel.Current.Objective, TextView.BufferType.Normal);

			return view;
		}
	}
}

