using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="ScheduleData", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class ScheduleData : INotifyPropertyChanged
	{
		private ScheduleFrequency FrequencyField;

		private int HourField;

		private int MinuteField;

		private int MonthWeekField;

		private DateTime? NextRefreshField;

		private DateTime ServerDateTimeField;

		private string TimezoneField;

		private string TimezoneDisplayField;

		private DayOfWeek WeekdayField;

		[DataMember]
		public ScheduleFrequency Frequency
		{
			get
			{
				return this.FrequencyField;
			}
			set
			{
				if (!this.FrequencyField.Equals(value))
				{
					this.FrequencyField = value;
					this.RaisePropertyChanged("Frequency");
				}
			}
		}

		[DataMember]
		public int Hour
		{
			get
			{
				return this.HourField;
			}
			set
			{
				if (!this.HourField.Equals(value))
				{
					this.HourField = value;
					this.RaisePropertyChanged("Hour");
				}
			}
		}

		[DataMember]
		public int Minute
		{
			get
			{
				return this.MinuteField;
			}
			set
			{
				if (!this.MinuteField.Equals(value))
				{
					this.MinuteField = value;
					this.RaisePropertyChanged("Minute");
				}
			}
		}

		[DataMember]
		public int MonthWeek
		{
			get
			{
				return this.MonthWeekField;
			}
			set
			{
				if (!this.MonthWeekField.Equals(value))
				{
					this.MonthWeekField = value;
					this.RaisePropertyChanged("MonthWeek");
				}
			}
		}

		[DataMember]
		public DateTime? NextRefresh
		{
			get
			{
				return this.NextRefreshField;
			}
			set
			{
				if (!this.NextRefreshField.Equals(value))
				{
					this.NextRefreshField = value;
					this.RaisePropertyChanged("NextRefresh");
				}
			}
		}

		[DataMember]
		public DateTime ServerDateTime
		{
			get
			{
				return this.ServerDateTimeField;
			}
			set
			{
				if (!this.ServerDateTimeField.Equals(value))
				{
					this.ServerDateTimeField = value;
					this.RaisePropertyChanged("ServerDateTime");
				}
			}
		}

		[DataMember]
		public string Timezone
		{
			get
			{
				return this.TimezoneField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TimezoneField, value))
				{
					this.TimezoneField = value;
					this.RaisePropertyChanged("Timezone");
				}
			}
		}

		[DataMember]
		public string TimezoneDisplay
		{
			get
			{
				return this.TimezoneDisplayField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TimezoneDisplayField, value))
				{
					this.TimezoneDisplayField = value;
					this.RaisePropertyChanged("TimezoneDisplay");
				}
			}
		}

		[DataMember]
		public DayOfWeek Weekday
		{
			get
			{
				return this.WeekdayField;
			}
			set
			{
				if (!this.WeekdayField.Equals(value))
				{
					this.WeekdayField = value;
					this.RaisePropertyChanged("Weekday");
				}
			}
		}

		public ScheduleData()
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