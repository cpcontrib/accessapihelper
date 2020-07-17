using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetMaintenanceMessageResult", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetMaintenanceMessageResult : WSResultClass
	{
		private string MessageField;

		[DataMember]
		public string Message
		{
			get
			{
				return this.MessageField;
			}
			set
			{
				if (!object.ReferenceEquals(this.MessageField, value))
				{
					this.MessageField = value;
					base.RaisePropertyChanged("Message");
				}
			}
		}

		public GetMaintenanceMessageResult()
		{
		}
	}
}