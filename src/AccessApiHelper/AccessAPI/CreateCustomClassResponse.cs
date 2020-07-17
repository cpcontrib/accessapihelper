using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="CreateCustomClassResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class CreateCustomClassResponse : WSResultClass
	{
		private int AssetIdField;

		private string AssetLabelField;

		[DataMember]
		public int AssetId
		{
			get
			{
				return this.AssetIdField;
			}
			set
			{
				if (!this.AssetIdField.Equals(value))
				{
					this.AssetIdField = value;
					base.RaisePropertyChanged("AssetId");
				}
			}
		}

		[DataMember]
		public string AssetLabel
		{
			get
			{
				return this.AssetLabelField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AssetLabelField, value))
				{
					this.AssetLabelField = value;
					base.RaisePropertyChanged("AssetLabel");
				}
			}
		}

		public CreateCustomClassResponse()
		{
		}
	}
}