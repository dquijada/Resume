using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Resume.Core;

namespace Resume
{
	public partial class ExperienceCell : UITableViewCell
	{
		public static readonly UINib Nib = UINib.FromName ("ExperienceCell", NSBundle.MainBundle);
		public static readonly NSString Key = new NSString ("ExperienceCell");

		public ExperienceCell (IntPtr handle) : base (handle)
		{
		}

		public ExperienceCell() :base()
		{
		}

		public static ExperienceCell Create ()
		{
			return (ExperienceCell)Nib.Instantiate (null, null) [0];
		}

		public void ApplyStyles ()
		{
			SelectionStyle = UITableViewCellSelectionStyle.Gray;

			jobLabel.BackgroundColor = 
					locationLabel.BackgroundColor =
					dateLabel.BackgroundColor = UIColor.Clear;

			locationLabel.Font =
				dateLabel.Font = UIFont.FromName ("HelveticaNeue", 12);

			locationLabel.TextColor =
				dateLabel.TextColor = UIColor.FromRGB (151, 157, 155);

			locationLabel.HighlightedTextColor =
				dateLabel.HighlightedTextColor = UIColor.White;

			jobLabel.Font = UIFont.FromName ("HelveticaNeue-Bold", 12);
		}

		public void BindData(Job item)
		{
			jobLabel.Text = item.Name;
			locationLabel.Text = item.Location;
			dateLabel.Text = item.Date;
			image.Image = UIImage.FromFile ("ico_work.png");
		}

		public override void SetSelected (bool selected, bool animated)
		{
			base.SetSelected (selected, animated);

			jobLabel.TextColor = UIColor.FromRGBA (0.29f, 0.29f, 0.29f, 1);

			var yOffset = selected ? 0 : 1;

			var offset = new SizeF (0, yOffset);

			jobLabel.ShadowOffset = locationLabel.ShadowOffset = offset;
		}
	}
}

