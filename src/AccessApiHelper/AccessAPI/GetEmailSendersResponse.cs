using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetEmailSendersResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetEmailSendersResponse : WSResultClass
	{
		private ICollection<EmailSender> sendersField;

		[DataMember]
		public ICollection<EmailSender> senders
		{
			get
			{
				return this.sendersField;
			}
			set
			{
				if (!object.ReferenceEquals(this.sendersField, value))
				{
					this.sendersField = value;
					base.RaisePropertyChanged("senders");
				}
			}
		}

		public GetEmailSendersResponse()
		{
		}
	}
}