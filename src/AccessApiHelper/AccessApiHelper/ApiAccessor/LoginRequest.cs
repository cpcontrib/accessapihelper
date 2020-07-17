using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace CrownPeak.AccessApiHelper.ApiAccessor
{
	[DataContract]
	[Serializable]
	public class LoginRequest
	{
		[DataMember]
		public string instance
		{
			get;
			set;
		}

		[DataMember]
		public string password
		{
			get;
			set;
		}

		[DataMember]
		public bool remember_me
		{
			get;
			set;
		}

		[DataMember]
		public int timeZoneOffsetMinutes
		{
			get;
			set;
		}

		[DataMember]
		public string username
		{
			get;
			set;
		}

		public LoginRequest()
		{
		}
	}
}