using System;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract]
	public class AssetRouteResponse : ResultClass
	{
		public AssetRouteResponse()
		{
		}

		public AssetRouteResponse(ResultClass result) : base(result)
		{
		}
	}
}