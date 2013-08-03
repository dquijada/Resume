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
	public class ExperienceAdapter : BaseAdapter
	{
		LayoutInflater inflater;
		List<Job> jobs;
		public ExperienceAdapter(LayoutInflater linflater, List<Job> items)
		{
			jobs = items;
			inflater = linflater;
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
			var job = jobs [position];
			var view = (convertView ??
			            inflater.Inflate(
				Resource.Layout.ExperienceRow,
				parent,
				false)) as LinearLayout;

			var name = view.FindViewById<TextView> (Resource.Id.job_name);
			var duration = view.FindViewById<TextView> (Resource.Id.job_duration);
			var location = view.FindViewById<TextView> (Resource.Id.job_location);

			name.SetText (job.Name,TextView.BufferType.Normal);
			duration.SetText (job.Date,TextView.BufferType.Normal);
			location.SetText (job.Location,TextView.BufferType.Normal);

//			var responsabilities = view.FindViewById<ListView> (Resource.Id.responsability_list);
//			var adapter = new ResponsabilityAdapter (inflater, job.Responsabilities);
//			responsabilities.SetAdapter (adapter);
//
//			if (job.Responsabilities.Count > 1)
//				responsabilities.LayoutParameters.Height = 100 * job.Responsabilities.Count;

			return view;
		}

		public override int Count {
			get {
				return jobs.Count;
			}
		}
	}
}

