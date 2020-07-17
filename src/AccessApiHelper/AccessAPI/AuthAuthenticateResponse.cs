using System;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract]
	public class AuthAuthenticateResponse : ResultClass
	{
		public AuthAuthenticateResponse()
		{
		}

		public AuthAuthenticateResponse(ResultClass result) : base(result)
		{
		}
	}
}