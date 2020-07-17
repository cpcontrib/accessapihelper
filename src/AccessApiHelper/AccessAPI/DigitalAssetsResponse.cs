using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract]
	[Serializable]
	public class DigitalAssetsResponse : ResultClass
	{
		[DataMember]
		public Dictionary<int, string> assets;

		[DataMember]
		public int count;

		public DigitalAssetsResponse()
		{
		}

		public DigitalAssetsResponse(ResultClass result, Dictionary<int, string> assets, int count) : base(result)
		{
			this.assets = assets;
			this.count = count;
		}
	}
}