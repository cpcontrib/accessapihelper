using System;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract]
	public class AssetReadByIdResponse : ResultClass
	{
		[DataMember]
		public WorklistAsset asset;

		public AssetReadByIdResponse()
		{
		}

		public AssetReadByIdResponse(ResultClass result, WorklistAsset asset) : base(result)
		{
			this.asset = asset;
		}
	}
}