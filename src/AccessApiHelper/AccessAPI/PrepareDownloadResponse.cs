using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="PrepareDownloadResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class PrepareDownloadResponse : WSResultClass
	{
		private string DownloadTicketField;

		private string FileNameField;

		private int MaxUploadLimitField;

		private int TotalBytesField;

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
					base.RaisePropertyChanged("DownloadTicket");
				}
			}
		}

		[DataMember]
		public string FileName
		{
			get
			{
				return this.FileNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.FileNameField, value))
				{
					this.FileNameField = value;
					base.RaisePropertyChanged("FileName");
				}
			}
		}

		[DataMember]
		public int MaxUploadLimit
		{
			get
			{
				return this.MaxUploadLimitField;
			}
			set
			{
				if (!this.MaxUploadLimitField.Equals(value))
				{
					this.MaxUploadLimitField = value;
					base.RaisePropertyChanged("MaxUploadLimit");
				}
			}
		}

		[DataMember]
		public int TotalBytes
		{
			get
			{
				return this.TotalBytesField;
			}
			set
			{
				if (!this.TotalBytesField.Equals(value))
				{
					this.TotalBytesField = value;
					base.RaisePropertyChanged("TotalBytes");
				}
			}
		}

		public PrepareDownloadResponse()
		{
		}
	}
}