using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="PublishedFile", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class PublishedFile : PublishInfo
	{
		private string ArgsField;

		private string FilenameField;

		private string FtpRootField;

		private int SessionIdField;

		[DataMember]
		public string Args
		{
			get
			{
				return this.ArgsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ArgsField, value))
				{
					this.ArgsField = value;
					base.RaisePropertyChanged("Args");
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
		public string FtpRoot
		{
			get
			{
				return this.FtpRootField;
			}
			set
			{
				if (!object.ReferenceEquals(this.FtpRootField, value))
				{
					this.FtpRootField = value;
					base.RaisePropertyChanged("FtpRoot");
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

		public PublishedFile()
		{
		}
	}
}