using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="RenameAssetResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class RenameAssetResponse : WSResultClass
	{
		private string FilteredNameField;

		[DataMember]
		public string FilteredName
		{
			get
			{
				return this.FilteredNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.FilteredNameField, value))
				{
					this.FilteredNameField = value;
					base.RaisePropertyChanged("FilteredName");
				}
			}
		}

		public RenameAssetResponse()
		{
		}
	}
}