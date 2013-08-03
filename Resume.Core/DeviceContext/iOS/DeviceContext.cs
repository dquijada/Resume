using System;
using MonoTouch.UIKit;

namespace Resume.Core
{
	public partial class DeviceContext
	{
		partial void InternalShowNetworkIndicator ()
		{
			UIApplication.SharedApplication.NetworkActivityIndicatorVisible = true;
		}

		partial void InternalHideNetworkIndicator()
		{
			UIApplication.SharedApplication.NetworkActivityIndicatorVisible = false;
		}
	}
}

