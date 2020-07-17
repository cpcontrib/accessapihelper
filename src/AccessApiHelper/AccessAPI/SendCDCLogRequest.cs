using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="SendCDCLogRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class SendCDCLogRequest : INotifyPropertyChanged
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
					this.RaisePropertyChanged("Message");
				}
			}
		}

		public SendCDCLogRequest()
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