using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="WorkflowData", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class WorkflowData : INotifyPropertyChanged
	{
		private int AssetIdField;

		private string DescriptionField;

		private int IdField;

		private string ModifiedByField;

		private DateTime ModifiedDateField;

		private string NameField;

		private ICollection<WorkflowStepCommandsData> StepCommandsField;

		private int UsageField;

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
		public string ModifiedBy
		{
			get
			{
				return this.ModifiedByField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ModifiedByField, value))
				{
					this.ModifiedByField = value;
					this.RaisePropertyChanged("ModifiedBy");
				}
			}
		}

		[DataMember]
		public DateTime ModifiedDate
		{
			get
			{
				return this.ModifiedDateField;
			}
			set
			{
				if (!this.ModifiedDateField.Equals(value))
				{
					this.ModifiedDateField = value;
					this.RaisePropertyChanged("ModifiedDate");
				}
			}
		}

		[DataMember]
		public string Name
		{
			get
			{
				return this.NameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.NameField, value))
				{
					this.NameField = value;
					this.RaisePropertyChanged("Name");
				}
			}
		}

		[DataMember]
		public ICollection<WorkflowStepCommandsData> StepCommands
		{
			get
			{
				return this.StepCommandsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.StepCommandsField, value))
				{
					this.StepCommandsField = value;
					this.RaisePropertyChanged("StepCommands");
				}
			}
		}

		[DataMember]
		public int Usage
		{
			get
			{
				return this.UsageField;
			}
			set
			{
				if (!this.UsageField.Equals(value))
				{
					this.UsageField = value;
					this.RaisePropertyChanged("Usage");
				}
			}
		}

		public WorkflowData()
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