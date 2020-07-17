using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="InstrumentEntity", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Instrumentation")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class InstrumentEntity : INotifyPropertyChanged
	{
		private string AccumulatedTimeTakenField;

		private string AccumulatedTimeThrottledField;

		private string ImpactModifierField;

		private string NameField;

		private long UsageCountField;

		private int cpuDeltaField;

		private int cpuPrivilegedDeltaField;

		private int cpuUserDeltaField;

		private long memPeakPagedMemorySize64Field;

		private long memPeakVirtualMemorySize64Field;

		private long memPeakWorkingSetField;

		[DataMember]
		public string AccumulatedTimeTaken
		{
			get
			{
				return this.AccumulatedTimeTakenField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AccumulatedTimeTakenField, value))
				{
					this.AccumulatedTimeTakenField = value;
					this.RaisePropertyChanged("AccumulatedTimeTaken");
				}
			}
		}

		[DataMember]
		public string AccumulatedTimeThrottled
		{
			get
			{
				return this.AccumulatedTimeThrottledField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AccumulatedTimeThrottledField, value))
				{
					this.AccumulatedTimeThrottledField = value;
					this.RaisePropertyChanged("AccumulatedTimeThrottled");
				}
			}
		}

		[DataMember]
		public int cpuDelta
		{
			get
			{
				return this.cpuDeltaField;
			}
			set
			{
				if (!this.cpuDeltaField.Equals(value))
				{
					this.cpuDeltaField = value;
					this.RaisePropertyChanged("cpuDelta");
				}
			}
		}

		[DataMember]
		public int cpuPrivilegedDelta
		{
			get
			{
				return this.cpuPrivilegedDeltaField;
			}
			set
			{
				if (!this.cpuPrivilegedDeltaField.Equals(value))
				{
					this.cpuPrivilegedDeltaField = value;
					this.RaisePropertyChanged("cpuPrivilegedDelta");
				}
			}
		}

		[DataMember]
		public int cpuUserDelta
		{
			get
			{
				return this.cpuUserDeltaField;
			}
			set
			{
				if (!this.cpuUserDeltaField.Equals(value))
				{
					this.cpuUserDeltaField = value;
					this.RaisePropertyChanged("cpuUserDelta");
				}
			}
		}

		[DataMember]
		public string ImpactModifier
		{
			get
			{
				return this.ImpactModifierField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ImpactModifierField, value))
				{
					this.ImpactModifierField = value;
					this.RaisePropertyChanged("ImpactModifier");
				}
			}
		}

		[DataMember]
		public long memPeakPagedMemorySize64
		{
			get
			{
				return this.memPeakPagedMemorySize64Field;
			}
			set
			{
				if (!this.memPeakPagedMemorySize64Field.Equals(value))
				{
					this.memPeakPagedMemorySize64Field = value;
					this.RaisePropertyChanged("memPeakPagedMemorySize64");
				}
			}
		}

		[DataMember]
		public long memPeakVirtualMemorySize64
		{
			get
			{
				return this.memPeakVirtualMemorySize64Field;
			}
			set
			{
				if (!this.memPeakVirtualMemorySize64Field.Equals(value))
				{
					this.memPeakVirtualMemorySize64Field = value;
					this.RaisePropertyChanged("memPeakVirtualMemorySize64");
				}
			}
		}

		[DataMember]
		public long memPeakWorkingSet
		{
			get
			{
				return this.memPeakWorkingSetField;
			}
			set
			{
				if (!this.memPeakWorkingSetField.Equals(value))
				{
					this.memPeakWorkingSetField = value;
					this.RaisePropertyChanged("memPeakWorkingSet");
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
		public long UsageCount
		{
			get
			{
				return this.UsageCountField;
			}
			set
			{
				if (!this.UsageCountField.Equals(value))
				{
					this.UsageCountField = value;
					this.RaisePropertyChanged("UsageCount");
				}
			}
		}

		public InstrumentEntity()
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