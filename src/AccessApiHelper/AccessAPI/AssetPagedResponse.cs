using System;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract]
	public class AssetPagedResponse : ResultClass
	{
		[DataMember]
		public WorklistAsset[] assets;

		[DataMember]
		public int normalCount;

		[DataMember]
		public int hiddenCount;

		[DataMember]
		public int deletedCount;

		public AssetPagedResponse()
		{
		}

		public AssetPagedResponse(ResultClass result, WorklistAsset[] assets, int normalCount, int hiddenCount, int deletedCount) : base(result)
		{
			this.assets = assets;
			this.normalCount = normalCount;
			this.hiddenCount = hiddenCount;
			this.deletedCount = deletedCount;
		}
	}
}