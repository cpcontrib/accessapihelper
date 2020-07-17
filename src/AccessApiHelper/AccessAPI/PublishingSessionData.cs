using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="PublishingSessionData", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class PublishingSessionData : INotifyPropertyChanged
	{
		private string ActiveActionField;

		private string ActiveMessageField;

		private string ActiveNameField;

		private string ActiveStageField;

		private int CurrentAssetIdField;

		private string DisplayStatusField;

		private int DocumentsField;

		private DateTime EndDateField;

		private int ErrorsField;

		private int FilesField;

		private int IdField;

		private bool IsActiveField;

		private bool IsCancelledField;

		private bool IsInitializingField;

		private bool IsStarvingField;

		private bool IsSuccessfulField;

		private long KBytesField;

		private int OriginalAssetIdField;

		private string OriginalAssetPathField;

		private int ProcessedDependenciesField;

		private int ProcessedPriorityField;

		private DateTime StartDateField;

		private int TotalDependenciesField;

		private int TotalPriorityField;

		private string UserFullNameField;

		private int UserIdField;

		[DataMember]
		public string ActiveAction
		{
			get
			{
				return this.ActiveActionField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ActiveActionField, value))
				{
					this.ActiveActionField = value;
					this.RaisePropertyChanged("ActiveAction");
				}
			}
		}

		[DataMember]
		public string ActiveMessage
		{
			get
			{
				return this.ActiveMessageField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ActiveMessageField, value))
				{
					this.ActiveMessageField = value;
					this.RaisePropertyChanged("ActiveMessage");
				}
			}
		}

		[DataMember]
		public string ActiveName
		{
			get
			{
				return this.ActiveNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ActiveNameField, value))
				{
					this.ActiveNameField = value;
					this.RaisePropertyChanged("ActiveName");
				}
			}
		}

		[DataMember]
		public string ActiveStage
		{
			get
			{
				return this.ActiveStageField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ActiveStageField, value))
				{
					this.ActiveStageField = value;
					this.RaisePropertyChanged("ActiveStage");
				}
			}
		}

		[DataMember]
		public int CurrentAssetId
		{
			get
			{
				return this.CurrentAssetIdField;
			}
			set
			{
				if (!this.CurrentAssetIdField.Equals(value))
				{
					this.CurrentAssetIdField = value;
					this.RaisePropertyChanged("CurrentAssetId");
				}
			}
		}

		[DataMember]
		public string DisplayStatus
		{
			get
			{
				return this.DisplayStatusField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DisplayStatusField, value))
				{
					this.DisplayStatusField = value;
					this.RaisePropertyChanged("DisplayStatus");
				}
			}
		}

		[DataMember]
		public int Documents
		{
			get
			{
				return this.DocumentsField;
			}
			set
			{
				if (!this.DocumentsField.Equals(value))
				{
					this.DocumentsField = value;
					this.RaisePropertyChanged("Documents");
				}
			}
		}

		[DataMember]
		public DateTime EndDate
		{
			get
			{
				return this.EndDateField;
			}
			set
			{
				if (!this.EndDateField.Equals(value))
				{
					this.EndDateField = value;
					this.RaisePropertyChanged("EndDate");
				}
			}
		}

		[DataMember]
		public int Errors
		{
			get
			{
				return this.ErrorsField;
			}
			set
			{
				if (!this.ErrorsField.Equals(value))
				{
					this.ErrorsField = value;
					this.RaisePropertyChanged("Errors");
				}
			}
		}

		[DataMember]
		public int Files
		{
			get
			{
				return this.FilesField;
			}
			set
			{
				if (!this.FilesField.Equals(value))
				{
					this.FilesField = value;
					this.RaisePropertyChanged("Files");
				}
			}
		}

		[DataMember]
		public int Id
		{
			get
			{
				return this.IdField;
			}
			set
			{
				if (!this.IdField.Equals(value))
				{
					this.IdField = value;
					this.RaisePropertyChanged("Id");
				}
			}
		}

		[DataMember]
		public bool IsActive
		{
			get
			{
				return this.IsActiveField;
			}
			set
			{
				if (!this.IsActiveField.Equals(value))
				{
					this.IsActiveField = value;
					this.RaisePropertyChanged("IsActive");
				}
			}
		}

		[DataMember]
		public bool IsCancelled
		{
			get
			{
				return this.IsCancelledField;
			}
			set
			{
				if (!this.IsCancelledField.Equals(value))
				{
					this.IsCancelledField = value;
					this.RaisePropertyChanged("IsCancelled");
				}
			}
		}

		[DataMember]
		public bool IsInitializing
		{
			get
			{
				return this.IsInitializingField;
			}
			set
			{
				if (!this.IsInitializingField.Equals(value))
				{
					this.IsInitializingField = value;
					this.RaisePropertyChanged("IsInitializing");
				}
			}
		}

		[DataMember]
		public bool IsStarving
		{
			get
			{
				return this.IsStarvingField;
			}
			set
			{
				if (!this.IsStarvingField.Equals(value))
				{
					this.IsStarvingField = value;
					this.RaisePropertyChanged("IsStarving");
				}
			}
		}

		[DataMember]
		public bool IsSuccessful
		{
			get
			{
				return this.IsSuccessfulField;
			}
			set
			{
				if (!this.IsSuccessfulField.Equals(value))
				{
					this.IsSuccessfulField = value;
					this.RaisePropertyChanged("IsSuccessful");
				}
			}
		}

		[DataMember]
		public long KBytes
		{
			get
			{
				return this.KBytesField;
			}
			set
			{
				if (!this.KBytesField.Equals(value))
				{
					this.KBytesField = value;
					this.RaisePropertyChanged("KBytes");
				}
			}
		}

		[DataMember]
		public int OriginalAssetId
		{
			get
			{
				return this.OriginalAssetIdField;
			}
			set
			{
				if (!this.OriginalAssetIdField.Equals(value))
				{
					this.OriginalAssetIdField = value;
					this.RaisePropertyChanged("OriginalAssetId");
				}
			}
		}

		[DataMember]
		public string OriginalAssetPath
		{
			get
			{
				return this.OriginalAssetPathField;
			}
			set
			{
				if (!object.ReferenceEquals(this.OriginalAssetPathField, value))
				{
					this.OriginalAssetPathField = value;
					this.RaisePropertyChanged("OriginalAssetPath");
				}
			}
		}

		[DataMember]
		public int ProcessedDependencies
		{
			get
			{
				return this.ProcessedDependenciesField;
			}
			set
			{
				if (!this.ProcessedDependenciesField.Equals(value))
				{
					this.ProcessedDependenciesField = value;
					this.RaisePropertyChanged("ProcessedDependencies");
				}
			}
		}

		[DataMember]
		public int ProcessedPriority
		{
			get
			{
				return this.ProcessedPriorityField;
			}
			set
			{
				if (!this.ProcessedPriorityField.Equals(value))
				{
					this.ProcessedPriorityField = value;
					this.RaisePropertyChanged("ProcessedPriority");
				}
			}
		}

		[DataMember]
		public DateTime StartDate
		{
			get
			{
				return this.StartDateField;
			}
			set
			{
				if (!this.StartDateField.Equals(value))
				{
					this.StartDateField = value;
					this.RaisePropertyChanged("StartDate");
				}
			}
		}

		[DataMember]
		public int TotalDependencies
		{
			get
			{
				return this.TotalDependenciesField;
			}
			set
			{
				if (!this.TotalDependenciesField.Equals(value))
				{
					this.TotalDependenciesField = value;
					this.RaisePropertyChanged("TotalDependencies");
				}
			}
		}

		[DataMember]
		public int TotalPriority
		{
			get
			{
				return this.TotalPriorityField;
			}
			set
			{
				if (!this.TotalPriorityField.Equals(value))
				{
					this.TotalPriorityField = value;
					this.RaisePropertyChanged("TotalPriority");
				}
			}
		}

		[DataMember]
		public string UserFullName
		{
			get
			{
				return this.UserFullNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.UserFullNameField, value))
				{
					this.UserFullNameField = value;
					this.RaisePropertyChanged("UserFullName");
				}
			}
		}

		[DataMember]
		public int UserId
		{
			get
			{
				return this.UserIdField;
			}
			set
			{
				if (!this.UserIdField.Equals(value))
				{
					this.UserIdField = value;
					this.RaisePropertyChanged("UserId");
				}
			}
		}

		public PublishingSessionData()
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