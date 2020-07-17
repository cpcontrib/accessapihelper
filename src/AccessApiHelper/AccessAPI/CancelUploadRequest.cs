using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="CancelUploadRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class CancelUploadRequest : INotifyPropertyChanged
	{
		private string UploadTicketField;

		[DataMember]
		public string UploadTicket
		{
			get
			{
				return this.UploadTicketField;
			}
			set
			{
				if (!object.ReferenceEquals(this.UploadTicketField, value))
				{
					this.UploadTicketField = value;
					this.RaisePropertyChanged("UploadTicket");
				}
			}
		}

		public CancelUploadRequest()
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