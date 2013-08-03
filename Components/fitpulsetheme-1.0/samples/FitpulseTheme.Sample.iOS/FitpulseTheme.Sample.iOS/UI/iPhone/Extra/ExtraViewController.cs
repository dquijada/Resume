using System;
using System.Collections.Generic;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Xamarin.Controls.iOS.ProgressBar;
using Xamarin.Themes;

namespace ThemeSample.UI.iPhone {
	public partial class ExtraViewController : UIViewController {
		UISlider slider;
		UIView viewElements;
		SearchBar searchBar;
		UITableView tableView;
		UISearchDisplayController searchDisplayController;

		RoundProgress smallProgress;
		RoundProgress mediumProgress;
		RoundProgress largeProgress;


		public ExtraViewController ()
		{
			Title = "Extra";
			View.ContentScaleFactor = UIScreen.MainScreen.Scale;
		}
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			InitSubviews ();
		}

		private void InitSubviews ()
		{
			viewElements = new UIView (new RectangleF (0, 88, 320, UIScreen.MainScreen.Bounds.Height));

			viewElements.ContentScaleFactor = UIScreen.MainScreen.Scale;

			FitpulseTheme.Apply (viewElements);

			tableView = new UITableView ();
			tableView.ScrollEnabled = true;

			tableView.ReloadData ();
			tableView.Hidden = true;

			viewElements.Add (tableView);

			searchBar = new SearchBar (new RectangleF (0, 0, 320, 88));
			searchBar.ShowsScopeBar = true;
			searchBar.ScopeButtonTitles = new string[] { "Back", "Chest", "Shoulders", "Biceps" };

			searchDisplayController = new UISearchDisplayController (searchBar, this);

			searchDisplayController.SearchResultsSource = new SearchSource ();
			searchDisplayController.Delegate = new SearchDisplayDelegate ();
			searchDisplayController.SearchResultsTableView.TableFooterView = new UIImageView (FitpulseTheme.SharedTheme.TableFooterBackground);
			searchDisplayController.SearchResultsTableView.SeparatorStyle = UITableViewCellSeparatorStyle.None;

			Add (searchBar);

			var tintColor = UIColor.FromRGBA (0.03f, 0.64f, 0.83f, 1);

			smallProgress = new RoundProgress (RoundProgressType.Small, new RectangleF (23, 22, 50, 51));
			smallProgress.TintColor = tintColor;
			smallProgress.Progress = 0.3f;
			smallProgress.FontSize = 20;

			viewElements.Add (smallProgress);						

			mediumProgress = new RoundProgress (RoundProgressType.Medium, new RectangleF (58, 66, 100, 99));
			mediumProgress.TintColor = tintColor;
			mediumProgress.Progress = 0.5f;			
			mediumProgress.FontSize = 40;

			viewElements.Add (mediumProgress);

			largeProgress = new RoundProgress (RoundProgressType.Large, new RectangleF (137, 140, 161, 161));
			largeProgress.TintColor = tintColor;
			largeProgress.Progress = 0.7f;

			viewElements.Add (largeProgress);

			slider = new UISlider (new RectangleF (5, 281, 134, 23));
			slider.MinValue = 0;
			slider.MaxValue = 1;			
			slider.Value = 0.7f;

			viewElements.Add (slider);

			Add (viewElements);

			slider.ValueChanged += (sender, e) => { largeProgress.Progress = slider.Value; };			
		}
	}
}

