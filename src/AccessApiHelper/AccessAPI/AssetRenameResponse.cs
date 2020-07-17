using System;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract]
	public class AssetRenameResponse : ResultClass
	{
		[DataMember]
		public WorklistAsset asset;

		public AssetRenameResponse()
		{
		}

		public AssetRenameResponse(ResultClass result, WorklistAsset asset) : base(result)
		{
			this.asset = asset;
		}
	}
}