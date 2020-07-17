using System;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract]
	public class AssetRenameRequest
	{
		[DataMember]
		public int assetId;

		[DataMember]
		public string newName;

		public AssetRenameRequest()
		{
		}
	}
}