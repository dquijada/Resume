using System;
using MonoTouch.UIKit;

namespace ThemeSample.UI.iPhone {
	public class SearchDisplayDelegate : UISearchDisplayDelegate {
		public override bool ShouldReloadForSearchScope (UISearchDisplayController controller, int scope)
		{
			 ((SearchSource)controller.SearchResultsSource).Filter (controller.SearchBar.Text, scope);

			return true;
		}

		public override bool ShouldReloadForSearchString (UISearchDisplayController controller, string searchString)
		{
			 ((SearchSource)controller.SearchResultsSource).Filter (searchString, controller.SearchBar.SelectedScopeButtonIndex);

			return true;
		}
	}
}

