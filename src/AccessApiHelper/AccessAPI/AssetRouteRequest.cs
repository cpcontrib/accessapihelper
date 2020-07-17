using System;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract]
	public class AssetRouteRequest
	{
		[DataMember]
		public int assetId;

		[DataMember]
		public int stateId;

		public AssetRouteRequest()
		{
		}
	}
}