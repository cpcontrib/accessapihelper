using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="WorkflowScheduleItem", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class WorkflowScheduleItem : INotifyPropertyChanged
	{
		private int WorkflowIdField;

		private DateTime? WorkflowScheduleDateField;

		private string WorkflowScheduleNameField;

		[DataMember]
		public int WorkflowId
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
		public DateTime? WorkflowScheduleDate
		{
			get
			{
				return this.WorkflowScheduleDateField;
			}
			set
			{
				if (!this.WorkflowScheduleDateField.Equals(value))
				{
					this.WorkflowScheduleDateField = value;
					this.RaisePropertyChanged("WorkflowScheduleDate");
				}
			}
		}

		[DataMember]
		public string WorkflowScheduleName
		{
			get
			{
				return this.WorkflowScheduleNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.WorkflowScheduleNameField, value))
				{
					this.WorkflowScheduleNameField = value;
					this.RaisePropertyChanged("WorkflowScheduleName");
				}
			}
		}

		public WorkflowScheduleItem()
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