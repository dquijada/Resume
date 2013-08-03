using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using ThemeSample.Model;

namespace ThemeSample.UI.iPhone {
	public class ProfileController : UITableViewController {
		public event Action<Category> CategorySelected;

		public ProfileController () : base (UITableViewStyle.Plain)
		{
			TableView.SeparatorStyle = UITableViewCellSeparatorStyle.None;
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			var source = new ProfileSource ();
			source.CategorySelected += OnCategorySelected;

			TableView.Source = source;
		}

		void OnCategorySelected (Category category)
		{
			if (CategorySelected == null)
				return;

			CategorySelected (category);
		}
	}
}

