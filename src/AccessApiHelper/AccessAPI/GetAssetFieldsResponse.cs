using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetAssetFieldsResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetAssetFieldsResponse : WSResultClass
	{
		private ICollection<AssetsField> FieldsField;

		[DataMember]
		public ICollection<AssetsField> Fields
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

		public GetAssetFieldsResponse()
		{
		}
	}
}