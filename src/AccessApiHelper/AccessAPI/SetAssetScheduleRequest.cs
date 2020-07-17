using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="SetAssetScheduleRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class SetAssetScheduleRequest : INotifyPropertyChanged
	{
		private int AssetIdField;

		private bool ConvertFromPrefferedField;

		private CrownPeak.AccessAPI.ScheduleData ScheduleDataField;

		private ICollection<WorkflowScheduleItem> WorkflowSchedulesField;

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
		public bool ConvertFromPreffered
		{
			get
			{
				return this.ConvertFromPrefferedField;
			}
			set
			{
				if (!this.ConvertFromPrefferedField.Equals(value))
				{
					this.ConvertFromPrefferedField = value;
					this.RaisePropertyChanged("ConvertFromPreffered");
				}
			}
		}

		[DataMember]
		public CrownPeak.AccessAPI.ScheduleData ScheduleData
		{
			get
			{
				return this.ScheduleDataField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ScheduleDataField, value))
				{
					this.ScheduleDataField = value;
					this.RaisePropertyChanged("ScheduleData");
				}
			}
		}

		[DataMember]
		public ICollection<WorkflowScheduleItem> WorkflowSchedules
		{
			get
			{
				return this.WorkflowSchedulesField;
			}
			set
			{
				if (!object.ReferenceEquals(this.WorkflowSchedulesField, value))
				{
					this.WorkflowSchedulesField = value;
					this.RaisePropertyChanged("WorkflowSchedules");
				}
			}
		}

		public SetAssetScheduleRequest()
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