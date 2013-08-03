using System;

namespace Resume.Core
{
	public partial class DeviceContext
	{
		static DeviceContext _instance;

		public static DeviceContext Current {
			get{
				if (_instance == null) {
					_instance = new DeviceContext ();
					_instance.InitializeDeviceSpecific ();
				}

				return _instance;
			}
		}

		partial void InitializeDeviceSpecific();

		partial void InternalShowNetworkIndicator();
		public void ShowNetworkIndicator()
		{
			InternalShowNetworkIndicator ();
		}

		partial void InternalHideNetworkIndicator();
		public void HideNetworkIndicator()
		{
			InternalHideNetworkIndicator ();
		}
	}
}

