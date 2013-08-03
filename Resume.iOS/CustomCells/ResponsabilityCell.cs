using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Linq;

namespace Resume
{
	public partial class ResponsabilityCell : UITableViewCell
	{
		public static readonly UINib Nib = UINib.FromName ("ResponsabilityCell", NSBundle.MainBundle);
		public static readonly NSString Key = new NSString ("ResponsabilityCell");

		public ResponsabilityCell (IntPtr handle) : base (handle)
		{
		}

		public ResponsabilityCell() : base()
		{
		}

		public static ResponsabilityCell Create ()
		{
			return (ResponsabilityCell)Nib.Instantiate (null, null) [0];
		}

		public void ApplyStyles()
		{
			responsabilityLabel.BackgroundColor = UIColor.Clear;

			responsabilityLabel.Font = UIFont.FromName ("HelveticaNeue", 13);

			responsabilityLabel.TextColor = UIColor.FromRGB (151, 157, 155);
		}

		public void BindData(string responsability)
		{
			responsabilityLabel.Text = responsability;
			var frame = responsabilityLabel.Frame;
			frame.Size = new SizeF (responsabilityLabel.Frame.Size.Width, responsabilityLabel.ContentSize.Height);
			responsabilityLabel.Frame = frame;
		}
	}
}

