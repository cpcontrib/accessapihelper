using System;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract]
	public class LogRequest
	{
		[DataMember]
		public string message;

		[DataMember]
		public int? assetId;

		public LogRequest()
		{
		}
	}
}