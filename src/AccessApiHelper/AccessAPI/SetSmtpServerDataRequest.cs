using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="SetSmtpServerDataRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class SetSmtpServerDataRequest : INotifyPropertyChanged
	{
		private ICollection<SmtpServerData> SmtpServersField;

		[DataMember]
		public ICollection<SmtpServerData> SmtpServers
		{
			get
			{
				return this.SmtpServersField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SmtpServersField, value))
				{
					this.SmtpServersField = value;
					this.RaisePropertyChanged("SmtpServers");
				}
			}
		}

		public SetSmtpServerDataRequest()
		{
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;
	}
}