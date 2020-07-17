using System;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract]
	public class AssetExistsRequest
	{
		[DataMember]
		public string assetIdOrPath;

		public AssetExistsRequest()
		{
			this.assetIdOrPath = string.Empty;
		}

		public AssetExistsRequest(int assetId)
		{
			this.assetIdOrPath = assetId.ToString();
		}

		public AssetExistsRequest(string path)
		{
			this.assetIdOrPath = path;
		}
	}
}