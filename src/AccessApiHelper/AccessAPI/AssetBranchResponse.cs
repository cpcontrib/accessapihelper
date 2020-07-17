using System;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract]
	public class AssetBranchResponse : ResultClass
	{
		[DataMember]
		public WorklistAsset asset;

		public AssetBranchResponse()
		{
		}

		public AssetBranchResponse(ResultClass result, WorklistAsset asset) : base(result)
		{
			this.asset = asset;
		}
	}
}