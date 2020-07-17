using System;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract]
	public class AuthLogoutResponse : ResultClass
	{
		public AuthLogoutResponse()
		{
		}

		public AuthLogoutResponse(ResultClass result) : base(result)
		{
		}
	}
}