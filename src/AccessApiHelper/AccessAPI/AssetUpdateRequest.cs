using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract]
	public class AssetUpdateRequest
	{
		[DataMember]
		public int assetId;

		[DataMember]
		public Dictionary<string, string> fields;

		[DataMember]
		public List<string> fieldsToDelete;

		[DataMember]
		public bool runPostInput;

		[DataMember]
		public bool runPostSave;

		public AssetUpdateRequest()
		{
		}
	}
}