using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="AssetPublishAuditData", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class AssetPublishAuditData : AuditData
	{
		private string ActionField;

		private int DurationField;

		private string ErrorTextField;

		private string FilenameField;

		private string PackageNameField;

		private string PubHostNameField;

		private string ReasonField;

		private int SessionIdField;

		private string SubReasonField;

		private long TransferSizeField;

		[DataMember]
		public string Action
		{
			get
			{
				return this.ActionField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ActionField, value))
				{
					this.ActionField = value;
					base.RaisePropertyChanged("Action");
				}
			}
		}

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
		public string ErrorText
		{
			get
			{
				return this.ErrorTextField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ErrorTextField, value))
				{
					this.ErrorTextField = value;
					base.RaisePropertyChanged("ErrorText");
				}
			}
		}

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
		public string PackageName
		{
			get
			{
				return this.PackageNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PackageNameField, value))
				{
					this.PackageNameField = value;
					base.RaisePropertyChanged("PackageName");
				}
			}
		}

		[DataMember]
		public string PubHostName
		{
			get
			{
				return this.PubHostNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PubHostNameField, value))
				{
					this.PubHostNameField = value;
					base.RaisePropertyChanged("PubHostName");
				}
			}
		}

		[DataMember]
		public string Reason
		{
			get
			{
				return this.ReasonField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ReasonField, value))
				{
					this.ReasonField = value;
					base.RaisePropertyChanged("Reason");
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
		public string SubReason
		{
			get
			{
				return this.SubReasonField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SubReasonField, value))
				{
					this.SubReasonField = value;
					base.RaisePropertyChanged("SubReason");
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

		public AssetPublishAuditData()
		{
		}
	}
}