using System;
using MonoTouch.Dialog;
using MonoTouch.UIKit;
using MonoTouch.Foundation;

namespace Resume
{
	public class FlyoutMenuElement : Element
	{
		static NSString key = new NSString ("menuCell");

		public FlyoutMenuElement (string item) : base(item)
		{
		}

		public override MonoTouch.UIKit.UITableViewCell GetCell (MonoTouch.UIKit.UITableView tv)
		{
			var cell = tv.DequeueReusableCell (key);
			if (cell == null) {
				cell = new UITableViewCell (UITableViewCellStyle.Default, key);
				cell.TextLabel.BackgroundColor= UIColor.Clear;
				cell.AccessoryView = new UIImageView(UIImage.FromFile("ico_menu_arrow.png"));
				cell.TextLabel.TextColor = UIColor.White;
				cell.TextLabel.Font = UIFont.FromName ("HelveticaNeue-Bold", 16);
				cell.SelectionStyle = UITableViewCellSelectionStyle.None;
			}
			cell.TextLabel.Text = Caption;
			return cell;
		}
	}
}

