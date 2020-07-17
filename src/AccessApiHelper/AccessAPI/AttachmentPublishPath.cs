using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="AttachmentPublishPath", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class AttachmentPublishPath : PublishInfo
	{
		private string CmsPathField;

		private string ErrorMessageField;

		private long SizeField;

		private string UploadKeyField;

		[DataMember]
		public string CmsPath
		{
			get
			{
				return this.CmsPathField;
			}
			set
			{
				if (!object.ReferenceEquals(this.CmsPathField, value))
				{
					this.CmsPathField = value;
					base.RaisePropertyChanged("CmsPath");
				}
			}
		}

		[DataMember]
		public string ErrorMessage
		{
			get
			{
				return this.ErrorMessageField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ErrorMessageField, value))
				{
					this.ErrorMessageField = value;
					base.RaisePropertyChanged("ErrorMessage");
				}
			}
		}

		[DataMember]
		public long Size
		{
			get
			{
				return this.SizeField;
			}
			set
			{
				if (!this.SizeField.Equals(value))
				{
					this.SizeField = value;
					base.RaisePropertyChanged("Size");
				}
			}
		}

		[DataMember]
		public string UploadKey
		{
			get
			{
				return this.UploadKeyField;
			}
			set
			{
				if (!object.ReferenceEquals(this.UploadKeyField, value))
				{
					this.UploadKeyField = value;
					base.RaisePropertyChanged("UploadKey");
				}
			}
		}

		public AttachmentPublishPath()
		{
		}
	}
}