using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetAssetMetaDataResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetAssetMetaDataResponse : WSResultClass
	{
		private ICollection<AssetsMeta> FieldsField;

		private string UIStringField;

		[DataMember]
		public ICollection<AssetsMeta> Fields
		{
			get
			{
				return this.FieldsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.FieldsField, value))
				{
					this.FieldsField = value;
					base.RaisePropertyChanged("Fields");
				}
			}
		}

		[DataMember]
		public string UIString
		{
			get
			{
				return this.UIStringField;
			}
			set
			{
				if (!object.ReferenceEquals(this.UIStringField, value))
				{
					this.UIStringField = value;
					base.RaisePropertyChanged("UIString");
				}
			}
		}

		public GetAssetMetaDataResponse()
		{
		}
	}
}