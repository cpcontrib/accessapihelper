using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetFileOptionsResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetFileOptionsResponse : WSResultClass
	{
		private string BinaryFieldField;

		private CrownPeak.AccessAPI.IconType IconTypeField;

		private ICollection<string> UploadFieldsField;

		[DataMember]
		public string BinaryField
		{
			get
			{
				return this.BinaryFieldField;
			}
			set
			{
				if (!object.ReferenceEquals(this.BinaryFieldField, value))
				{
					this.BinaryFieldField = value;
					base.RaisePropertyChanged("BinaryField");
				}
			}
		}

		[DataMember]
		public CrownPeak.AccessAPI.IconType IconType
		{
			get
			{
				return this.IconTypeField;
			}
			set
			{
				if (!this.IconTypeField.Equals(value))
				{
					this.IconTypeField = value;
					base.RaisePropertyChanged("IconType");
				}
			}
		}

		[DataMember]
		public ICollection<string> UploadFields
		{
			get
			{
				return this.UploadFieldsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.UploadFieldsField, value))
				{
					this.UploadFieldsField = value;
					base.RaisePropertyChanged("UploadFields");
				}
			}
		}

		public GetFileOptionsResponse()
		{
		}
	}
}