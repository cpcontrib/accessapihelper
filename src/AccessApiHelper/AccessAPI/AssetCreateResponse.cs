using System;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract]
	public class AssetCreateResponse : ResultClass
	{
		[DataMember]
		public WorklistAsset asset;

		public AssetCreateResponse()
		{
		}

		public AssetCreateResponse(ResultClass result, WorklistAsset asset) : base(result)
		{
			this.asset = asset;
		}
	}
}