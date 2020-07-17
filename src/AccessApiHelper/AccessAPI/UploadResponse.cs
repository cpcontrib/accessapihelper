using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="UploadResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class UploadResponse : WSResultClass
	{
		private int BytesWrittenField;

		[DataMember]
		public int BytesWritten
		{
			get
			{
				return this.BytesWrittenField;
			}
			set
			{
				if (!this.BytesWrittenField.Equals(value))
				{
					this.BytesWrittenField = value;
					base.RaisePropertyChanged("BytesWritten");
				}
			}
		}

		public UploadResponse()
		{
		}
	}
}