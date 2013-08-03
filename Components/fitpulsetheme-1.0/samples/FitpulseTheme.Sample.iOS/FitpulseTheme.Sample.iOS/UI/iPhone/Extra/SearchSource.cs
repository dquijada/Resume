using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace ThemeSample.UI.iPhone {
	public class SearchSource : UITableViewSource {
		List<List<string>> items;
		List<string> filteredItems;

		public SearchSource ()
		{
			items = new List<List<string>> ();

			items.Add (new List<string> (5) {
				"Code Geass",
				"Asura Cryin'",
				"Voltes V",
				"Mazinger Z",
				"Daimos"
			});

			items.Add (new List<string> (6) {
				"Second scope 1",
				"Chest scope",
				"Useless record",
				"Pull",
				"Push",
				"Pizza"
			});

			items.Add (new List<string> (4) {
				"Third scope",
				"Second record",
				"Shoulders",
				"Hello from search"
			});

			items.Add (new List<string> (7) {
				"Fourth scope",
				"Biceps",
				"Triangularis",
				"Calves",
				"Prelum Abdominale",
				"Anpther record",
				"One more"
			});



			filteredItems = new List<string> (items[0]);
		}

		public override int NumberOfSections (UITableView tableView)
		{
			return 1;
		}

		public override int RowsInSection (UITableView tableview, int section)
		{
			return filteredItems.Count;
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			var cell = tableView.DequeueReusableCell ("SearchCell") as WorkoutCell;

			if (cell == null)
				cell = new WorkoutCell ();

			cell.BackgroundView = new UIImageView (UIImage.FromFile ("list-element.png"));
			cell.Accessory = UITableViewCellAccessory.None;

			cell.TitleLabel.Text = filteredItems [indexPath.Row];
			cell.CallsDescription.Text = 
			cell.DurationDescription.Text = 
			cell.ExercisesDescription.Text = 
			cell.SetsDescription.Text = 
			cell.Sets.Text =
			cell.Calls.Text =
			cell.Duration.Text =
			cell.Exercises.Text = string.Empty;					

			cell.Icon.Image = UIImage.FromFile ("list-item-icon1.png");
			
			return cell;
		}

		public override float GetHeightForRow (UITableView tableView, NSIndexPath indexPath)
		{
			return 71;
		}

		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			tableView.DeselectRow (indexPath, true);
		}

		public void Filter (string searchText, int scope)
		{
			if (scope < 0)
				scope = 0;
			else if (scope >= items.Count)
				scope = items.Count - 1;
			searchText = searchText.ToLower ();

			filteredItems = items [scope].Where (itm => itm.ToLower ().Contains (searchText)).ToList ();
		}
	}
}