using System;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract]
	public class AssetUndeleteResponse : ResultClass
	{
		public AssetUndeleteResponse()
		{
		}

		public AssetUndeleteResponse(ResultClass result) : base(result)
		{
		}
	}
}