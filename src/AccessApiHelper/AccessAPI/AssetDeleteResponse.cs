using System;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract]
	public class AssetDeleteResponse : ResultClass
	{
		public AssetDeleteResponse()
		{
		}

		public AssetDeleteResponse(ResultClass result) : base(result)
		{
		}
	}
}