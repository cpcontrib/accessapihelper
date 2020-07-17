using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="WorkflowCommandData", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class WorkflowCommandData : INotifyPropertyChanged
	{
		private string CommandField;

		private int? CommandIdField;

		private int? DestinationStatusField;

		private int? FilterIdField;

		private bool HasRequestCommentField;

		private bool HasVerifyCommandField;

		private int? IdField;

		private bool IsPublishingStepField;

		private int? WorkflowIdField;

		private int? WorkflowStepField;

		[DataMember]
		public string Command
		{
			get
			{
				return this.CommandField;
			}
			set
			{
				if (!object.ReferenceEquals(this.CommandField, value))
				{
					this.CommandField = value;
					this.RaisePropertyChanged("Command");
				}
			}
		}

		[DataMember]
		public int? CommandId
		{
			get
			{
				return this.CommandIdField;
			}
			set
			{
				if (!this.CommandIdField.Equals(value))
				{
					this.CommandIdField = value;
					this.RaisePropertyChanged("CommandId");
				}
			}
		}

		[DataMember]
		public int? DestinationStatus
		{
			get
			{
				return this.DestinationStatusField;
			}
			set
			{
				if (!this.DestinationStatusField.Equals(value))
				{
					this.DestinationStatusField = value;
					this.RaisePropertyChanged("DestinationStatus");
				}
			}
		}

		[DataMember]
		public int? FilterId
		{
			get
			{
				return this.FilterIdField;
			}
			set
			{
				if (!this.FilterIdField.Equals(value))
				{
					this.FilterIdField = value;
					this.RaisePropertyChanged("FilterId");
				}
			}
		}

		[DataMember]
		public bool HasRequestComment
		{
			get
			{
				return this.HasRequestCommentField;
			}
			set
			{
				if (!this.HasRequestCommentField.Equals(value))
				{
					this.HasRequestCommentField = value;
					this.RaisePropertyChanged("HasRequestComment");
				}
			}
		}

		[DataMember]
		public bool HasVerifyCommand
		{
			get
			{
				return this.HasVerifyCommandField;
			}
			set
			{
				if (!this.HasVerifyCommandField.Equals(value))
				{
					this.HasVerifyCommandField = value;
					this.RaisePropertyChanged("HasVerifyCommand");
				}
			}
		}

		[DataMember]
		public int? Id
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
		public bool IsPublishingStep
		{
			get
			{
				return this.IsPublishingStepField;
			}
			set
			{
				if (!this.IsPublishingStepField.Equals(value))
				{
					this.IsPublishingStepField = value;
					this.RaisePropertyChanged("IsPublishingStep");
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

		[DataMember]
		public int? WorkflowStep
		{
			get
			{
				return this.WorkflowStepField;
			}
			set
			{
				if (!this.WorkflowStepField.Equals(value))
				{
					this.WorkflowStepField = value;
					this.RaisePropertyChanged("WorkflowStep");
				}
			}
		}

		public WorkflowCommandData()
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