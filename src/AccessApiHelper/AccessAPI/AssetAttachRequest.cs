using System;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract]
	public class AssetAttachRequest
	{
		[DataMember]
		public int assetId;

		[DataMember]
		public string originalFilename;

		[DataMember]
		public byte[] bytes;

		public AssetAttachRequest()
		{
		}
	}
}