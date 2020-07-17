using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetFolderAssetFieldsResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetFolderAssetFieldsResponse : WSResultClass
	{
		private ICollection<LightAssetFieldList> FieldsField;

		[DataMember]
		public ICollection<LightAssetFieldList> Fields
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

		public GetFolderAssetFieldsResponse()
		{
		}
	}
}