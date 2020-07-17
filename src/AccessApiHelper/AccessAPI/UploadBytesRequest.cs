using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="UploadBytesRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class UploadBytesRequest : INotifyPropertyChanged
	{
		private byte[] BytesField;

		private byte[] ChecksumField;

		private string UploadTicketField;

		[DataMember]
		public byte[] Bytes
		{
			get
			{
				return this.BytesField;
			}
			set
			{
				if (!object.ReferenceEquals(this.BytesField, value))
				{
					this.BytesField = value;
					this.RaisePropertyChanged("Bytes");
				}
			}
		}

		[DataMember]
		public byte[] Checksum
		{
			get
			{
				return this.ChecksumField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ChecksumField, value))
				{
					this.ChecksumField = value;
					this.RaisePropertyChanged("Checksum");
				}
			}
		}

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

		public UploadBytesRequest()
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