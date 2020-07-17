using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="DownloadAssetsResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class DownloadAssetsResponse : WSResultClass
	{
		private string ExtensionField;

		private string FileNameField;

		private string MimeTypeField;

		private Dictionary<int, ResultClass> ResponseListField;

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

		[DataMember]
		public Dictionary<int, ResultClass> ResponseList
		{
			get
			{
				return this.ResponseListField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ResponseListField, value))
				{
					this.ResponseListField = value;
					base.RaisePropertyChanged("ResponseList");
				}
			}
		}

		public DownloadAssetsResponse()
		{
		}
	}
}