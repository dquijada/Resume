using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Resume.Core
{
	public class ResumeSharedController
	{
		private static ResumeSharedController _instance;
		public string Address {
			get;
			set;
		}
		HttpClient client = new HttpClient();

		public static ResumeSharedController Current
		{
			get
			{
				if (_instance == null)
					_instance = new ResumeSharedController ();
				return _instance;
			}
		}

		public async Task GetResumeAsync(Action OnSuccess, Action<Exception> OnFailed)
		{			
			DeviceContext.Current.ShowNetworkIndicator();
			try
			{
				var response = await client.GetAsync (Address);
				var content = await response.Content.ReadAsStringAsync();
				var resume = JsonConvert.DeserializeObject<MyResume>(content);

				ResumeViewModel.Current.Resume = resume;

				if(OnSuccess != null)
				{
					OnSuccess();
				}
			}
			catch (Exception e){
				OnFailed (e);
			}
			DeviceContext.Current.HideNetworkIndicator ();
		}
	}
}

