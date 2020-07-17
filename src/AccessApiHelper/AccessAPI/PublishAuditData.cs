using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="PublishAuditData", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class PublishAuditData : AuditData
	{
		private int DurationField;

		private int FilesAffectedField;

		private int NumErrorsField;

		private int SessionIdField;

		private long TransferSizeField;

		[DataMember]
		public int Duration
		{
			get
			{
				return this.DurationField;
			}
			set
			{
				if (!this.DurationField.Equals(value))
				{
					this.DurationField = value;
					base.RaisePropertyChanged("Duration");
				}
			}
		}

		[DataMember]
		public int FilesAffected
		{
			get
			{
				return this.FilesAffectedField;
			}
			set
			{
				if (!this.FilesAffectedField.Equals(value))
				{
					this.FilesAffectedField = value;
					base.RaisePropertyChanged("FilesAffected");
				}
			}
		}

		[DataMember]
		public int NumErrors
		{
			get
			{
				return this.NumErrorsField;
			}
			set
			{
				if (!this.NumErrorsField.Equals(value))
				{
					this.NumErrorsField = value;
					base.RaisePropertyChanged("NumErrors");
				}
			}
		}

		[DataMember]
		public int SessionId
		{
			get
			{
				return this.SessionIdField;
			}
			set
			{
				if (!this.SessionIdField.Equals(value))
				{
					this.SessionIdField = value;
					base.RaisePropertyChanged("SessionId");
				}
			}
		}

		[DataMember]
		public long TransferSize
		{
			get
			{
				return this.TransferSizeField;
			}
			set
			{
				if (!this.TransferSizeField.Equals(value))
				{
					this.TransferSizeField = value;
					base.RaisePropertyChanged("TransferSize");
				}
			}
		}

		public PublishAuditData()
		{
		}
	}
}