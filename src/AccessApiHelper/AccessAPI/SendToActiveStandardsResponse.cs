using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="SendToActiveStandardsResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class SendToActiveStandardsResponse : WSResultClass
	{
		private bool sentField;

		[DataMember]
		public bool sent
		{
			get
			{
				return this.sentField;
			}
			set
			{
				if (!this.sentField.Equals(value))
				{
					this.sentField = value;
					base.RaisePropertyChanged("sent");
				}
			}
		}

		public SendToActiveStandardsResponse()
		{
		}
	}
}