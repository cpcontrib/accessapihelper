using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="WorkflowStepCommandsData", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class WorkflowStepCommandsData : INotifyPropertyChanged
	{
		private ICollection<WorkflowCommandData> CommandsField;

		private string DescriptionField;

		private int StateIdField;

		private string SubjectField;

		[DataMember]
		public ICollection<WorkflowCommandData> Commands
		{
			get
			{
				return this.CommandsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.CommandsField, value))
				{
					this.CommandsField = value;
					this.RaisePropertyChanged("Commands");
				}
			}
		}

		[DataMember]
		public string Description
		{
			get
			{
				return this.DescriptionField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DescriptionField, value))
				{
					this.DescriptionField = value;
					this.RaisePropertyChanged("Description");
				}
			}
		}

		[DataMember]
		public int StateId
		{
			get
			{
				return this.StateIdField;
			}
			set
			{
				if (!this.StateIdField.Equals(value))
				{
					this.StateIdField = value;
					this.RaisePropertyChanged("StateId");
				}
			}
		}

		[DataMember]
		public string Subject
		{
			get
			{
				return this.SubjectField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SubjectField, value))
				{
					this.SubjectField = value;
					this.RaisePropertyChanged("Subject");
				}
			}
		}

		public WorkflowStepCommandsData()
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