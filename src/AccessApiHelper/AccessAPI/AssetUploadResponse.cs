using System;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract]
	public class AssetUploadResponse : ResultClass
	{
		[DataMember]
		public WorklistAsset asset;

		[DataMember]
		public string displayUrl;

		public AssetUploadResponse()
		{
		}

		public AssetUploadResponse(ResultClass result, WorklistAsset asset, string displayUrl) : base(result)
		{
			this.asset = asset;
			this.displayUrl = displayUrl;
		}
	}
}