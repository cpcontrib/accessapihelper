using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="FinishUploadAttachmentRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class FinishUploadAttachmentRequest : INotifyPropertyChanged
	{
		private int AssetIdField;

		private string AttachmentNameField;

		private string OriginalFilenameField;

		private ICollection<Thumbnail> ThumbnailsToCreateField;

		private string UploadTicketField;

		[DataMember]
		public int AssetId
		{
			get
			{
				return this.AssetIdField;
			}
			set
			{
				if (!this.AssetIdField.Equals(value))
				{
					this.AssetIdField = value;
					this.RaisePropertyChanged("AssetId");
				}
			}
		}

		[DataMember]
		public string AttachmentName
		{
			get
			{
				return this.AttachmentNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AttachmentNameField, value))
				{
					this.AttachmentNameField = value;
					this.RaisePropertyChanged("AttachmentName");
				}
			}
		}

		[DataMember]
		public string OriginalFilename
		{
			get
			{
				return this.OriginalFilenameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.OriginalFilenameField, value))
				{
					this.OriginalFilenameField = value;
					this.RaisePropertyChanged("OriginalFilename");
				}
			}
		}

		[DataMember]
		public ICollection<Thumbnail> ThumbnailsToCreate
		{
			get
			{
				return this.ThumbnailsToCreateField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ThumbnailsToCreateField, value))
				{
					this.ThumbnailsToCreateField = value;
					this.RaisePropertyChanged("ThumbnailsToCreate");
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

		public FinishUploadAttachmentRequest()
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