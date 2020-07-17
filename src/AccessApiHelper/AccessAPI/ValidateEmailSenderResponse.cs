using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="ValidateEmailSenderResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class ValidateEmailSenderResponse : WSResultClass
	{
		private ICollection<EmailSender> SendersField;

		[DataMember]
		public ICollection<EmailSender> Senders
		{
			get
			{
				return this.SendersField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SendersField, value))
				{
					this.SendersField = value;
					base.RaisePropertyChanged("Senders");
				}
			}
		}

		public ValidateEmailSenderResponse()
		{
		}
	}
}