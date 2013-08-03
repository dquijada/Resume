using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.Dialog;
using MonoTouch.ObjCRuntime;

namespace Resume
{
	public partial class CommonElement : Element, IElementSizing
	{
		string responsability;
		ResponsabilityCell cell;
		public CommonElement(string item) : base(null)
		{
			responsability = item;
		}

		public override UITableViewCell GetCell (UITableView tv)
		{
			cell = tv.DequeueReusableCell (ResponsabilityCell.Key) as ResponsabilityCell;

			if (cell == null) {
				cell = Activator.CreateInstance<ResponsabilityCell> ();
				var views = NSBundle.MainBundle.LoadNib ("ResponsabilityCell", cell, null);
				cell = Runtime.GetNSObject (views.ValueAt (0)) as ResponsabilityCell;
			}

			cell.Accessory = UITableViewCellAccessory.None;
			cell.BindData (responsability);
			cell.SelectionStyle = UITableViewCellSelectionStyle.None;
			cell.ApplyStyles ();

			return cell;
		}

		#region IElementSizing implementation

		public float GetHeight (UITableView tableView, NSIndexPath indexPath)
		{
			var count = responsability.Count ();
//			var factor = count <= 10 ? 5 :count > 20 && count <= 50 ? 1 : count > 50 && count <= 90 ? 0.7f : 0.55f;
//			return count * factor;
			return 88f;

		}

		#endregion
	}
}
