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

namespace Resume.Droid
{
	public class CustomListAdapter : BaseAdapter
	{
		LayoutInflater inflater;
		List<string> responsabilities;

		public CustomListAdapter(LayoutInflater linflater, List<string> items)
		{
			responsabilities = items;
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
			var item = responsabilities [position];
			var view = (convertView ??
			            inflater.Inflate(
				Resource.Layout.CustomListRow,
				parent,
				false)) as LinearLayout;

			var responsability = view.FindViewById<TextView> (Resource.Id.responsability);
			responsability.SetText (item,TextView.BufferType.Normal);

			return view;
		}

		public override int Count {
			get {
				return responsabilities.Count;
			}
		}
	}
}

