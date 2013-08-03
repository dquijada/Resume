using System;
using Android.Widget;
using Android.Views;
using System.Collections.Generic;
using Resume.Core;

namespace Resume.Droid
{
	public class EducationAdapter : BaseAdapter
	{
		LayoutInflater myInflater;
		List<Education> education;

		public EducationAdapter (LayoutInflater inflater, List<Education> items)
		{
			myInflater = inflater;
			education = items;
		}

		public override Java.Lang.Object GetItem (int position)
		{
			return position;
		}

		public override long GetItemId (int position)
		{
			return position;
		}

		public override View GetView (int position, View convertView, ViewGroup parent)
		{
			var item = education[position];

			var view = (convertView ??
			            myInflater.Inflate(
				Resource.Layout.EducationRow,
				parent,
				false)) as LinearLayout;

			var title = view.FindViewById<TextView> (Resource.Id.title);
			var university = view.FindViewById<TextView> (Resource.Id.university);
			var location = view.FindViewById<TextView> (Resource.Id.university_location);
			var duration = view.FindViewById<TextView> (Resource.Id.university_duration);

			title.SetText (item.Title,TextView.BufferType.Normal);
			university.SetText (item.Where,TextView.BufferType.Normal);
			duration.SetText (item.Date,TextView.BufferType.Normal);
			location.SetText (item.Location,TextView.BufferType.Normal);

			return view;
		}

		public override int Count {
			get {
				return education.Count;
			}
		}
	}
}

