using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetFolderOptionsResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetFolderOptionsResponse : WSResultClass
	{
		private string HeaderField;

		private CrownPeak.AccessAPI.IconType IconTypeField;

		[DataMember]
		public string Header
		{
			get
			{
				return this.HeaderField;
			}
			set
			{
				if (!object.ReferenceEquals(this.HeaderField, value))
				{
					this.HeaderField = value;
					base.RaisePropertyChanged("Header");
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

		public GetFolderOptionsResponse()
		{
		}
	}
}