using System;
using Android.Content;
using Android.App;
using Android.OS;

namespace Resume.Core
{
	public partial class DeviceContext
	{
		public Context Context {
			get;
			set;
		}

		Context applicationContext;

		Handler uiHandler;

		ProgressDialog dialog;

		partial void InitializeDeviceSpecific()
		{
			applicationContext = Application.Context;
			uiHandler = new Handler(applicationContext.MainLooper);
		}

		partial void InternalShowNetworkIndicator()
		{
			uiHandler.Post(() => {
				dialog = new ProgressDialog(Context);
				dialog.SetProgressStyle(ProgressDialogStyle.Spinner);
				dialog.SetCancelable(false);
				dialog.Show();
			});
		}

		partial void InternalHideNetworkIndicator()
		{
			uiHandler.Post(() => {
				if(dialog != null)
				{
					dialog.Dismiss();
					dialog = null;
				}
			});
		}
	}
}

