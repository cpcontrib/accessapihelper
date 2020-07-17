using System;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract]
	public class AssetAttachResponse : ResultClass
	{
		[DataMember]
		public string displayUrl;

		public AssetAttachResponse()
		{
		}

		public AssetAttachResponse(ResultClass result, string displayUrl) : base(result)
		{
			this.displayUrl = displayUrl;
		}
	}
}