using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="FinishUploadAssetRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class FinishUploadAssetRequest : INotifyPropertyChanged
	{
		private string DesiredFilenameField;

		private int DestinationIdField;

		private int? ModelIdField;

		private string UploadTicketField;

		private string VersionCommentField;

		private int? WorkflowIdField;

		[DataMember]
		public string DesiredFilename
		{
			get
			{
				return this.DesiredFilenameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DesiredFilenameField, value))
				{
					this.DesiredFilenameField = value;
					this.RaisePropertyChanged("DesiredFilename");
				}
			}
		}

		[DataMember]
		public int DestinationId
		{
			get
			{
				return this.DestinationIdField;
			}
			set
			{
				if (!this.DestinationIdField.Equals(value))
				{
					this.DestinationIdField = value;
					this.RaisePropertyChanged("DestinationId");
				}
			}
		}

		[DataMember]
		public int? ModelId
		{
			get
			{
				return this.ModelIdField;
			}
			set
			{
				if (!this.ModelIdField.Equals(value))
				{
					this.ModelIdField = value;
					this.RaisePropertyChanged("ModelId");
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

		[DataMember]
		public string VersionComment
		{
			get
			{
				return this.VersionCommentField;
			}
			set
			{
				if (!object.ReferenceEquals(this.VersionCommentField, value))
				{
					this.VersionCommentField = value;
					this.RaisePropertyChanged("VersionComment");
				}
			}
		}

		[DataMember]
		public int? WorkflowId
		{
			get
			{
				return this.WorkflowIdField;
			}
			set
			{
				if (!this.WorkflowIdField.Equals(value))
				{
					this.WorkflowIdField = value;
					this.RaisePropertyChanged("WorkflowId");
				}
			}
		}

		public FinishUploadAssetRequest()
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