using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="PublishingSession", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class PublishingSession : INotifyPropertyChanged
	{
		private int ProcessedDependenciesField;

		private int ProcessedPriorityField;

		private int TotalDependenciesField;

		private int TotalPriorityField;

		private string active_actionField;

		private int? active_countField;

		private string active_messageField;

		private string active_nameField;

		private string active_stageField;

		private int? active_totalField;

		private int? current_asset_idField;

		private int? documentsField;

		private DateTime? end_dateField;

		private int? errorsField;

		private int? filesField;

		private int idField;

		private bool? is_activeField;

		private long? kbytesField;

		private int? log_idField;

		private int? original_asset_idField;

		private string original_asset_pathField;

		private short? phase_countField;

		private short? phase_totalField;

		private string propertiesField;

		private DateTime? start_dateField;

		private int? user_idField;

		[DataMember]
		public string active_action
		{
			get
			{
				return this.active_actionField;
			}
			set
			{
				if (!object.ReferenceEquals(this.active_actionField, value))
				{
					this.active_actionField = value;
					this.RaisePropertyChanged("active_action");
				}
			}
		}

		[DataMember]
		public int? active_count
		{
			get
			{
				return this.active_countField;
			}
			set
			{
				if (!this.active_countField.Equals(value))
				{
					this.active_countField = value;
					this.RaisePropertyChanged("active_count");
				}
			}
		}

		[DataMember]
		public string active_message
		{
			get
			{
				return this.active_messageField;
			}
			set
			{
				if (!object.ReferenceEquals(this.active_messageField, value))
				{
					this.active_messageField = value;
					this.RaisePropertyChanged("active_message");
				}
			}
		}

		[DataMember]
		public string active_name
		{
			get
			{
				return this.active_nameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.active_nameField, value))
				{
					this.active_nameField = value;
					this.RaisePropertyChanged("active_name");
				}
			}
		}

		[DataMember]
		public string active_stage
		{
			get
			{
				return this.active_stageField;
			}
			set
			{
				if (!object.ReferenceEquals(this.active_stageField, value))
				{
					this.active_stageField = value;
					this.RaisePropertyChanged("active_stage");
				}
			}
		}

		[DataMember]
		public int? active_total
		{
			get
			{
				return this.active_totalField;
			}
			set
			{
				if (!this.active_totalField.Equals(value))
				{
					this.active_totalField = value;
					this.RaisePropertyChanged("active_total");
				}
			}
		}

		[DataMember]
		public int? current_asset_id
		{
			get
			{
				return this.current_asset_idField;
			}
			set
			{
				if (!this.current_asset_idField.Equals(value))
				{
					this.current_asset_idField = value;
					this.RaisePropertyChanged("current_asset_id");
				}
			}
		}

		[DataMember]
		public int? documents
		{
			get
			{
				return this.documentsField;
			}
			set
			{
				if (!this.documentsField.Equals(value))
				{
					this.documentsField = value;
					this.RaisePropertyChanged("documents");
				}
			}
		}

		[DataMember]
		public DateTime? end_date
		{
			get
			{
				return this.end_dateField;
			}
			set
			{
				if (!this.end_dateField.Equals(value))
				{
					this.end_dateField = value;
					this.RaisePropertyChanged("end_date");
				}
			}
		}

		[DataMember]
		public int? errors
		{
			get
			{
				return this.errorsField;
			}
			set
			{
				if (!this.errorsField.Equals(value))
				{
					this.errorsField = value;
					this.RaisePropertyChanged("errors");
				}
			}
		}

		[DataMember]
		public int? files
		{
			get
			{
				return this.filesField;
			}
			set
			{
				if (!this.filesField.Equals(value))
				{
					this.filesField = value;
					this.RaisePropertyChanged("files");
				}
			}
		}

		[DataMember]
		public int id
		{
			get
			{
				return this.idField;
			}
			set
			{
				if (!this.idField.Equals(value))
				{
					this.idField = value;
					this.RaisePropertyChanged("id");
				}
			}
		}

		[DataMember]
		public bool? is_active
		{
			get
			{
				return this.is_activeField;
			}
			set
			{
				if (!this.is_activeField.Equals(value))
				{
					this.is_activeField = value;
					this.RaisePropertyChanged("is_active");
				}
			}
		}

		[DataMember]
		public long? kbytes
		{
			get
			{
				return this.kbytesField;
			}
			set
			{
				if (!this.kbytesField.Equals(value))
				{
					this.kbytesField = value;
					this.RaisePropertyChanged("kbytes");
				}
			}
		}

		[DataMember]
		public int? log_id
		{
			get
			{
				return this.log_idField;
			}
			set
			{
				if (!this.log_idField.Equals(value))
				{
					this.log_idField = value;
					this.RaisePropertyChanged("log_id");
				}
			}
		}

		[DataMember]
		public int? original_asset_id
		{
			get
			{
				return this.original_asset_idField;
			}
			set
			{
				if (!this.original_asset_idField.Equals(value))
				{
					this.original_asset_idField = value;
					this.RaisePropertyChanged("original_asset_id");
				}
			}
		}

		[DataMember]
		public string original_asset_path
		{
			get
			{
				return this.original_asset_pathField;
			}
			set
			{
				if (!object.ReferenceEquals(this.original_asset_pathField, value))
				{
					this.original_asset_pathField = value;
					this.RaisePropertyChanged("original_asset_path");
				}
			}
		}

		[DataMember]
		public short? phase_count
		{
			get
			{
				return this.phase_countField;
			}
			set
			{
				if (!this.phase_countField.Equals(value))
				{
					this.phase_countField = value;
					this.RaisePropertyChanged("phase_count");
				}
			}
		}

		[DataMember]
		public short? phase_total
		{
			get
			{
				return this.phase_totalField;
			}
			set
			{
				if (!this.phase_totalField.Equals(value))
				{
					this.phase_totalField = value;
					this.RaisePropertyChanged("phase_total");
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
		public string properties
		{
			get
			{
				return this.propertiesField;
			}
			set
			{
				if (!object.ReferenceEquals(this.propertiesField, value))
				{
					this.propertiesField = value;
					this.RaisePropertyChanged("properties");
				}
			}
		}

		[DataMember]
		public DateTime? start_date
		{
			get
			{
				return this.start_dateField;
			}
			set
			{
				if (!this.start_dateField.Equals(value))
				{
					this.start_dateField = value;
					this.RaisePropertyChanged("start_date");
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
		public int? user_id
		{
			get
			{
				return this.user_idField;
			}
			set
			{
				if (!this.user_idField.Equals(value))
				{
					this.user_idField = value;
					this.RaisePropertyChanged("user_id");
				}
			}
		}

		public PublishingSession()
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