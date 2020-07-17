using System;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract]
	public class AssetUpdateResponse : ResultClass
	{
		[DataMember]
		public WorklistAsset asset;

		public AssetUpdateResponse()
		{
		}

		public AssetUpdateResponse(ResultClass result, WorklistAsset asset) : base(result)
		{
			this.asset = asset;
		}
	}
}