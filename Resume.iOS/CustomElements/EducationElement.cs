using System;
using MonoTouch.Dialog;
using MonoTouch.UIKit;
using Resume.Core;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;

namespace Resume
{
	public class EducationElement : Element, IElementSizing
	{
		Education education;

		public EducationElement (Education item) : base(null)
		{
			education = item;
		}

		public override UITableViewCell GetCell (UITableView tv)
		{
			var cell = tv.DequeueReusableCell (EducationCell.Key) as EducationCell;

			if (cell == null) {
				cell = Activator.CreateInstance<EducationCell> ();
				var views = NSBundle.MainBundle.LoadNib ("EducationCell", cell, null);
				cell = Runtime.GetNSObject (views.ValueAt (0)) as EducationCell;
			}

			cell.Accessory = UITableViewCellAccessory.None;
			cell.BindData (education);
			cell.SelectionStyle = UITableViewCellSelectionStyle.None;
			cell.ApplyStyles ();

			return cell;
		}

		public float GetHeight (UITableView tableView, NSIndexPath indexPath)
		{
			return 72;
		}
	}
}

