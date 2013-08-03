using System;
using Android.Views;
using Android.Widget;
using System.Linq;

namespace Resume.Droid
{
	public class NavigationDrawerAdapter : BaseAdapter
	{
		string[] names;
		LayoutInflater context;

		public NavigationDrawerAdapter(string[] itemNames, LayoutInflater inflater) :base()
		{
			names = itemNames;
			context = inflater;
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
			var name = names [position];

			var view = (convertView ??
			            context.Inflate(
				Resource.Layout.MenuListItem,
				parent,
				false)) as LinearLayout;
			var textView = view.FindViewById<TextView> (Resource.Id.navName);
			textView.SetText (name, TextView.BufferType.Normal);

			return view;

		}

		public override int Count {
			get {
				return names.Count();
			}
		}
	}
}