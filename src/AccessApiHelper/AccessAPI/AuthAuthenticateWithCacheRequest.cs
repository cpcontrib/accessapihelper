using System;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract]
	public class AuthAuthenticateWithCacheRequest
	{
		[DataMember]
		public string instance;

		[DataMember]
		public string username;

		[DataMember]
		public string password;

		[DataMember]
		public bool remember_me;

		[DataMember]
		public int timeZoneOffsetMinutes;

		public AuthAuthenticateWithCacheRequest()
		{
		}
	}
}