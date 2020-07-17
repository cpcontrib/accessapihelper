using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="IsOutputWebCaptureCompleteResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class IsOutputWebCaptureCompleteResponse : WSResultClass
	{
		private string quickDownloadUrlField;

		private bool valueField;

		[DataMember]
		public string quickDownloadUrl
		{
			get
			{
				return this.quickDownloadUrlField;
			}
			set
			{
				if (!object.ReferenceEquals(this.quickDownloadUrlField, value))
				{
					this.quickDownloadUrlField = value;
					base.RaisePropertyChanged("quickDownloadUrl");
				}
			}
		}

		[DataMember]
		public bool @value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				if (!this.valueField.Equals(value))
				{
					this.valueField = value;
					base.RaisePropertyChanged("value");
				}
			}
		}

		public IsOutputWebCaptureCompleteResponse()
		{
		}
	}
}