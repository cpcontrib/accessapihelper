using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="CreateFileByModelIdResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class CreateFileByModelIdResponse : WSResultClass
	{
		private WorklistAsset assetField;

		private bool runInputField;

		[DataMember]
		public WorklistAsset asset
		{
			get
			{
				return this.assetField;
			}
			set
			{
				if (!object.ReferenceEquals(this.assetField, value))
				{
					this.assetField = value;
					base.RaisePropertyChanged("asset");
				}
			}
		}

		[DataMember]
		public bool runInput
		{
			get
			{
				return this.runInputField;
			}
			set
			{
				if (!this.runInputField.Equals(value))
				{
					this.runInputField = value;
					base.RaisePropertyChanged("runInput");
				}
			}
		}

		public CreateFileByModelIdResponse()
		{
		}
	}
}