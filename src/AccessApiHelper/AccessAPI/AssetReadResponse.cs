using System;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract]
	public class AssetReadResponse : ResultClass
	{
		public AssetReadResponse()
		{
		}

		public AssetReadResponse(ResultClass result) : base(result)
		{
		}
	}
}