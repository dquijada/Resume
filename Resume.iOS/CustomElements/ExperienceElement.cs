using System;
using MonoTouch.Dialog;
using Resume.Core;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;
using MonoTouch.UIKit;

namespace Resume
{
	public class ExperienceElement : Element, IElementSizing
	{
		Job job;

		public ExperienceElement (Job item) : base(null)
		{
			job = item;
		}

		public override MonoTouch.UIKit.UITableViewCell GetCell (MonoTouch.UIKit.UITableView tv)
		{
			var cell = tv.DequeueReusableCell (ExperienceCell.Key) as ExperienceCell;

			if (cell == null) {
				cell = Activator.CreateInstance<ExperienceCell> ();
				var views = NSBundle.MainBundle.LoadNib ("ExperienceCell", cell, null);
				cell = Runtime.GetNSObject (views.ValueAt (0)) as ExperienceCell;
			}

			cell.Accessory = UITableViewCellAccessory.None;
			cell.BindData (job);
			cell.ApplyStyles ();

			return cell;
		}

		public float GetHeight (UITableView tableView, NSIndexPath indexPath)
		{
			return 72;
		}		

		public override void Selected (DialogViewController dvc, UITableView tableView, NSIndexPath path)
		{
			base.Selected (dvc, tableView, path);
			var responsabilityController = new ResponsabilityController (job.Responsabilities);
			dvc.ActivateController (responsabilityController);
		}
	}
}

