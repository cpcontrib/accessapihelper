using System;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract]
	public class AssetPagedRequest
	{
		[DataMember]
		public int assetId;

		[DataMember]
		public int currentPage;

		[DataMember]
		public int pageSize;

		[DataMember]
		public string sortColumn;

		[DataMember]
		public OrderType orderType;

		[DataMember]
		public VisibilityType visibilityType;

		[DataMember]
		public bool ignoreFilter;

		[DataMember]
		public bool ignoreSort;

		public AssetPagedRequest()
		{
		}
	}
}