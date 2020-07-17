using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="DownloadBytesRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class DownloadBytesRequest : INotifyPropertyChanged
	{
		private int BytesWrittenField;

		private string DownloadTicketField;

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
					this.RaisePropertyChanged("BytesWritten");
				}
			}
		}

		[DataMember]
		public string DownloadTicket
		{
			get
			{
				return this.DownloadTicketField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DownloadTicketField, value))
				{
					this.DownloadTicketField = value;
					this.RaisePropertyChanged("DownloadTicket");
				}
			}
		}

		public DownloadBytesRequest()
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