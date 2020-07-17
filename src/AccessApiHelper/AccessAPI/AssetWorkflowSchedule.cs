using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="AssetWorkflowSchedule", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class AssetWorkflowSchedule : INotifyPropertyChanged
	{
		private DateTime? DateOnlyField;

		private DateTime? HoursAndMinutesOnlyField;

		private string NameField;

		private ICollection<StatusTransition> StatusTransitionsField;

		private DateTime? TimeField;

		[DataMember]
		public DateTime? DateOnly
		{
			get
			{
				return this.DateOnlyField;
			}
			set
			{
				if (!this.DateOnlyField.Equals(value))
				{
					this.DateOnlyField = value;
					this.RaisePropertyChanged("DateOnly");
				}
			}
		}

		[DataMember]
		public DateTime? HoursAndMinutesOnly
		{
			get
			{
				return this.HoursAndMinutesOnlyField;
			}
			set
			{
				if (!this.HoursAndMinutesOnlyField.Equals(value))
				{
					this.HoursAndMinutesOnlyField = value;
					this.RaisePropertyChanged("HoursAndMinutesOnly");
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
		public ICollection<StatusTransition> StatusTransitions
		{
			get
			{
				return this.StatusTransitionsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.StatusTransitionsField, value))
				{
					this.StatusTransitionsField = value;
					this.RaisePropertyChanged("StatusTransitions");
				}
			}
		}

		[DataMember]
		public DateTime? Time
		{
			get
			{
				return this.TimeField;
			}
			set
			{
				if (!this.TimeField.Equals(value))
				{
					this.TimeField = value;
					this.RaisePropertyChanged("Time");
				}
			}
		}

		public AssetWorkflowSchedule()
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