using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="PublishingActivityCounts", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class PublishingActivityCounts : INotifyPropertyChanged
	{
		private bool IsPublishingField;

		private int ProcessedCountField;

		private ICollection<PublishingSessionData> SessionsField;

		private int TotalCountField;

		private int dependenciesExplicitField;

		private int dependenciesOtherField;

		private int logIdxField;

		private ICollection<PublishingLog> logsField;

		private ICollection<PublishingLog> logsDependencyField;

		private int priorityField;

		private int processed_dependenciesExplicitField;

		private int processed_dependenciesOtherField;

		private int processed_priorityField;

		private string root_asset_pathField;

		private int session_idField;

		private string user_nameField;

		[DataMember]
		public int dependenciesExplicit
		{
			get
			{
				return this.dependenciesExplicitField;
			}
			set
			{
				if (!this.dependenciesExplicitField.Equals(value))
				{
					this.dependenciesExplicitField = value;
					this.RaisePropertyChanged("dependenciesExplicit");
				}
			}
		}

		[DataMember]
		public int dependenciesOther
		{
			get
			{
				return this.dependenciesOtherField;
			}
			set
			{
				if (!this.dependenciesOtherField.Equals(value))
				{
					this.dependenciesOtherField = value;
					this.RaisePropertyChanged("dependenciesOther");
				}
			}
		}

		[DataMember]
		public bool IsPublishing
		{
			get
			{
				return this.IsPublishingField;
			}
			set
			{
				if (!this.IsPublishingField.Equals(value))
				{
					this.IsPublishingField = value;
					this.RaisePropertyChanged("IsPublishing");
				}
			}
		}

		[DataMember]
		public int logIdx
		{
			get
			{
				return this.logIdxField;
			}
			set
			{
				if (!this.logIdxField.Equals(value))
				{
					this.logIdxField = value;
					this.RaisePropertyChanged("logIdx");
				}
			}
		}

		[DataMember]
		public ICollection<PublishingLog> logs
		{
			get
			{
				return this.logsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.logsField, value))
				{
					this.logsField = value;
					this.RaisePropertyChanged("logs");
				}
			}
		}

		[DataMember]
		public ICollection<PublishingLog> logsDependency
		{
			get
			{
				return this.logsDependencyField;
			}
			set
			{
				if (!object.ReferenceEquals(this.logsDependencyField, value))
				{
					this.logsDependencyField = value;
					this.RaisePropertyChanged("logsDependency");
				}
			}
		}

		[DataMember]
		public int priority
		{
			get
			{
				return this.priorityField;
			}
			set
			{
				if (!this.priorityField.Equals(value))
				{
					this.priorityField = value;
					this.RaisePropertyChanged("priority");
				}
			}
		}

		[DataMember]
		public int processed_dependenciesExplicit
		{
			get
			{
				return this.processed_dependenciesExplicitField;
			}
			set
			{
				if (!this.processed_dependenciesExplicitField.Equals(value))
				{
					this.processed_dependenciesExplicitField = value;
					this.RaisePropertyChanged("processed_dependenciesExplicit");
				}
			}
		}

		[DataMember]
		public int processed_dependenciesOther
		{
			get
			{
				return this.processed_dependenciesOtherField;
			}
			set
			{
				if (!this.processed_dependenciesOtherField.Equals(value))
				{
					this.processed_dependenciesOtherField = value;
					this.RaisePropertyChanged("processed_dependenciesOther");
				}
			}
		}

		[DataMember]
		public int processed_priority
		{
			get
			{
				return this.processed_priorityField;
			}
			set
			{
				if (!this.processed_priorityField.Equals(value))
				{
					this.processed_priorityField = value;
					this.RaisePropertyChanged("processed_priority");
				}
			}
		}

		[DataMember]
		public int ProcessedCount
		{
			get
			{
				return this.ProcessedCountField;
			}
			set
			{
				if (!this.ProcessedCountField.Equals(value))
				{
					this.ProcessedCountField = value;
					this.RaisePropertyChanged("ProcessedCount");
				}
			}
		}

		[DataMember]
		public string root_asset_path
		{
			get
			{
				return this.root_asset_pathField;
			}
			set
			{
				if (!object.ReferenceEquals(this.root_asset_pathField, value))
				{
					this.root_asset_pathField = value;
					this.RaisePropertyChanged("root_asset_path");
				}
			}
		}

		[DataMember]
		public int session_id
		{
			get
			{
				return this.session_idField;
			}
			set
			{
				if (!this.session_idField.Equals(value))
				{
					this.session_idField = value;
					this.RaisePropertyChanged("session_id");
				}
			}
		}

		[DataMember]
		public ICollection<PublishingSessionData> Sessions
		{
			get
			{
				return this.SessionsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SessionsField, value))
				{
					this.SessionsField = value;
					this.RaisePropertyChanged("Sessions");
				}
			}
		}

		[DataMember]
		public int TotalCount
		{
			get
			{
				return this.TotalCountField;
			}
			set
			{
				if (!this.TotalCountField.Equals(value))
				{
					this.TotalCountField = value;
					this.RaisePropertyChanged("TotalCount");
				}
			}
		}

		[DataMember]
		public string user_name
		{
			get
			{
				return this.user_nameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.user_nameField, value))
				{
					this.user_nameField = value;
					this.RaisePropertyChanged("user_name");
				}
			}
		}

		public PublishingActivityCounts()
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