using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Collections.Generic;
using Xamarin.Themes;
using ThemeSample.Model;

namespace ThemeSample.UI.iPhone {
	public class WorkoutSource : UITableViewSource {
		public event Action<Workout> WorkoutSelected;

		List<Workout> items;
		WorkoutController controller;


		public WorkoutSource (WorkoutController controller)
		{
			this.controller = controller;

			items = new List<Workout> {
				new Workout ("Back workout", "list-item-icon4.png"),
				new Workout ("Chest workout", "list-item-icon3.png"),
				new Workout ("Shoulders workout", "list-item-icon2.png"),
				new Workout ("Biceps workout", "list-item-icon1.png")
			};
		}
		
		public override int NumberOfSections (UITableView tableView)
		{
			return 1;
		}
		
		public override int RowsInSection (UITableView tableview, int section)
		{
			return items.Count;
		}
		
		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			var cell = tableView.DequeueReusableCell (WorkoutCell.Key) as WorkoutCell;

			if (cell == null)
				cell = new WorkoutCell ();

			cell.BackgroundView = new UIImageView (UIImage.FromFile ("list-element.png"));
			cell.Accessory = UITableViewCellAccessory.None;

			var data = items[indexPath.Row];
			cell.TitleLabel.Text = data.Title;
			cell.Icon.Image = UIImage.FromFile (data.IconFile);
			cell.IconFrame.Image = UIImage.FromFile ("list-item-frame.png");

			cell.Sets.Text = data.Sets;
			cell.Calls.Text = data.Calls;
			cell.Exercises.Text = data.Exercises;
			cell.Duration.Text = data.Duration;

			return cell;
		}

		public override UIView GetViewForHeader (UITableView tableView, int section)
		{
			var sectionTitleLabel = new UILabel (new RectangleF (10, 3, 300, 22));
			sectionTitleLabel.Text = "Resistence Workouts";
			sectionTitleLabel.BackgroundColor = UIColor.Clear;
			sectionTitleLabel.TextColor = UIColor.FromRGBA (0.43f, 0.43f, 0.43f, 1);
			sectionTitleLabel.Font = UIFont.FromName ("HelveticaNeue", 15);

			var backgroundView = new UIImageView (FitpulseTheme.SharedTheme.TableSectionHeaderBackground);
			backgroundView.Add (sectionTitleLabel);

			return backgroundView;
		}

		public override float GetHeightForHeader (UITableView tableView, int section)
		{
			return 32;
		}

		public override float GetHeightForRow (UITableView tableView, NSIndexPath indexPath)
		{
			return 71;
		}

		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			if (UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Pad) {
				tableView.DeselectRow (indexPath, true);

				if (controller.Popover != null)
					controller.Popover.Dismiss (true);
			} else {
				tableView.DeselectRow (indexPath, true);

				if(WorkoutSelected != null)
					WorkoutSelected(items[indexPath.Row]);
			}
		}
	}
}

