using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract]
	[KnownType(typeof(AssetsField))]
	public class AssetFieldsResponse : ResultClass
	{
		[DataMember]
		public List<AssetsField> fields
		{
			get;
			set;
		}

		public AssetFieldsResponse()
		{
		}

		public AssetFieldsResponse(ResultClass result, List<AssetsField> fields) : base(result)
		{
			this.fields = fields;
		}
	}
}