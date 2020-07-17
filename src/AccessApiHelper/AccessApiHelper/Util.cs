using CrownPeak.AccessAPI;
using CrownPeak.AccessApiHelper.ApiAccessor;
using Newtonsoft.Json;
using System;

namespace CrownPeak.AccessApiHelper
{
	public class Util
	{
		private IApiAccessor _api;

		internal Util(IApiAccessor api)
		{
			this._api = api;
		}

		public bool Log(int assetId, string message)
		{
			LogRequest logRequest = new LogRequest()
			{
				message = message,
				assetId = new int?(assetId)
			};
			string str = JsonConvert.SerializeObject(logRequest);
			string str1 = this._api.SendRequest("POST", string.Format("/Util/Log", new object[0]), str);
			return JsonConvert.DeserializeObject<LogResponse>(str1).IsSuccessful;
		}

		public bool Log(string message)
		{
			LogRequest logRequest = new LogRequest()
			{
				message = message
			};
			string str = JsonConvert.SerializeObject(logRequest);
			string str1 = this._api.SendRequest("POST", string.Format("/Util/Log", new object[0]), str);
			return JsonConvert.DeserializeObject<LogResponse>(str1).IsSuccessful;
		}
	}
}