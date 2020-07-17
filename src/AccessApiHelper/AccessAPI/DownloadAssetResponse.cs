using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="DownloadAssetResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class DownloadAssetResponse : WSResultClass
	{
		private string ExtensionField;

		private string FileNameField;

		private string MimeTypeField;

		private byte[] bufferField;

		[DataMember]
		public byte[] buffer
		{
			get
			{
				return this.bufferField;
			}
			set
			{
				if (!object.ReferenceEquals(this.bufferField, value))
				{
					this.bufferField = value;
					base.RaisePropertyChanged("buffer");
				}
			}
		}

		[DataMember]
		public string Extension
		{
			get
			{
				return this.ExtensionField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ExtensionField, value))
				{
					this.ExtensionField = value;
					base.RaisePropertyChanged("Extension");
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
		public string MimeType
		{
			get
			{
				return this.MimeTypeField;
			}
			set
			{
				if (!object.ReferenceEquals(this.MimeTypeField, value))
				{
					this.MimeTypeField = value;
					base.RaisePropertyChanged("MimeType");
				}
			}
		}

		public DownloadAssetResponse()
		{
		}
	}
}