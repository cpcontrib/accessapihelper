using System;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract]
	public class AssetExistsResponse : ResultClass
	{
		[DataMember]
		public bool exists;

		[DataMember]
		public int assetId;

		public AssetExistsResponse()
		{
		}

		public AssetExistsResponse(ResultClass result, bool assetExists, int assetId) : base(result)
		{
			this.exists = assetExists;
			this.assetId = assetId;
		}
	}
}