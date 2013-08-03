using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Resume.Core;

namespace Resume
{
	public partial class EducationCell : UITableViewCell
	{
		public static readonly UINib Nib = UINib.FromName ("EducationCell", NSBundle.MainBundle);
		public static readonly NSString Key = new NSString ("EducationCell");

		public EducationCell (IntPtr handle) : base (handle)
		{			
		}

		public EducationCell() : base()
		{
		}

		public static EducationCell Create ()
		{
			return (EducationCell)Nib.Instantiate (null, null) [0];
		}

		public void ApplyStyles ()
		{
			titleLabel.BackgroundColor = 
				whereLabel.BackgroundColor = 
					locationLabel.BackgroundColor =
					dateLabel.BackgroundColor = UIColor.Clear;

			whereLabel.Font = 
				locationLabel.Font =
					dateLabel.Font = UIFont.FromName ("HelveticaNeue", 13);

			whereLabel.TextColor = 
				locationLabel.TextColor =
					dateLabel.TextColor = UIColor.FromRGB (151, 157, 155);

			whereLabel.HighlightedTextColor = 
				locationLabel.HighlightedTextColor =
					dateLabel.HighlightedTextColor = UIColor.White;

			titleLabel.Font = UIFont.FromName ("HelveticaNeue-Bold", 17);
		}

		public void BindData(Education item)
		{
			titleLabel.Text = item.Title;
			whereLabel.Text = item.Where;
			locationLabel.Text = item.Location;
			dateLabel.Text = item.Date;
			image.Image = UIImage.FromFile ("ico_education.png");
		}

	}
}

