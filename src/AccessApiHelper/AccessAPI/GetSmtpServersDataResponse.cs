using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetSmtpServersDataResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetSmtpServersDataResponse : WSResultClass
	{
		private ICollection<SmtpServerData> smtpServersField;

		[DataMember]
		public ICollection<SmtpServerData> smtpServers
		{
			get
			{
				return this.smtpServersField;
			}
			set
			{
				if (!object.ReferenceEquals(this.smtpServersField, value))
				{
					this.smtpServersField = value;
					base.RaisePropertyChanged("smtpServers");
				}
			}
		}

		public GetSmtpServersDataResponse()
		{
		}
	}
}