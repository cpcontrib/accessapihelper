using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="PrepareDownloadAuditCSVResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class PrepareDownloadAuditCSVResponse : WSResultClass
	{
		private string FilenameField;

		private int MaxUploadLimitField;

		private string TicketField;

		private int TotalBytesField;

		[DataMember]
		public string Filename
		{
			get
			{
				return this.FilenameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.FilenameField, value))
				{
					this.FilenameField = value;
					base.RaisePropertyChanged("Filename");
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
		public string Ticket
		{
			get
			{
				return this.TicketField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TicketField, value))
				{
					this.TicketField = value;
					base.RaisePropertyChanged("Ticket");
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

		public PrepareDownloadAuditCSVResponse()
		{
		}
	}
}