using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="OrphanAuditData", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class OrphanAuditData : AuditData
	{
		private string ErrorField;

		private string FileField;

		private int JobIdField;

		private string SizeField;

		private DateTime TimestampField;

		private string TypeField;

		private string UrlField;

		private string User1Field;

		[DataMember]
		public string Error
		{
			get
			{
				return this.ErrorField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ErrorField, value))
				{
					this.ErrorField = value;
					base.RaisePropertyChanged("Error");
				}
			}
		}

		[DataMember]
		public string File
		{
			get
			{
				return this.FileField;
			}
			set
			{
				if (!object.ReferenceEquals(this.FileField, value))
				{
					this.FileField = value;
					base.RaisePropertyChanged("File");
				}
			}
		}

		[DataMember]
		public int JobId
		{
			get
			{
				return this.JobIdField;
			}
			set
			{
				if (!this.JobIdField.Equals(value))
				{
					this.JobIdField = value;
					base.RaisePropertyChanged("JobId");
				}
			}
		}

		[DataMember]
		public string Size
		{
			get
			{
				return this.SizeField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SizeField, value))
				{
					this.SizeField = value;
					base.RaisePropertyChanged("Size");
				}
			}
		}

		[DataMember]
		public DateTime Timestamp
		{
			get
			{
				return this.TimestampField;
			}
			set
			{
				if (!this.TimestampField.Equals(value))
				{
					this.TimestampField = value;
					base.RaisePropertyChanged("Timestamp");
				}
			}
		}

		[DataMember]
		public string Type
		{
			get
			{
				return this.TypeField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TypeField, value))
				{
					this.TypeField = value;
					base.RaisePropertyChanged("Type");
				}
			}
		}

		[DataMember]
		public string Url
		{
			get
			{
				return this.UrlField;
			}
			set
			{
				if (!object.ReferenceEquals(this.UrlField, value))
				{
					this.UrlField = value;
					base.RaisePropertyChanged("Url");
				}
			}
		}

		[DataMember(Name="User")]
		public string User1
		{
			get
			{
				return this.User1Field;
			}
			set
			{
				if (!object.ReferenceEquals(this.User1Field, value))
				{
					this.User1Field = value;
					base.RaisePropertyChanged("User1");
				}
			}
		}

		public OrphanAuditData()
		{
		}
	}
}