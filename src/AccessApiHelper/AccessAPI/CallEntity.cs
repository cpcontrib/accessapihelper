using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="CallEntity", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Instrumentation")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class CallEntity : INotifyPropertyChanged
	{
		private Guid GUIDField;

		private bool LimitReachedField;

		private bool MasterLimitReachedField;

		private string MethodNameField;

		private long StartingTickField;

		private int cpuDeltaField;

		private int cpuPrivilegedDeltaField;

		private int cpuUserDeltaField;

		private int curThreadCountField;

		private CallEntitySysInfo endingSysInfoField;

		private long memPeakPagedMemorySize64Field;

		private long memPeakVirtualMemorySize64Field;

		private long memPeakWorkingSetField;

		private int sqlDeleteCountField;

		private int sqlInsertCountField;

		private int sqlQueryCountField;

		private int sqlUpdateCountField;

		private CallEntitySysInfo startSysInfoField;

		private CrownPeak.AccessAPI.Stopwatch stopWatchField;

		private double timeTakenField;

		private double timeThrottledField;

		[DataMember(IsRequired=true)]
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

		[DataMember(IsRequired=true)]
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

		[DataMember(IsRequired=true)]
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

		[DataMember(IsRequired=true)]
		public int curThreadCount
		{
			get
			{
				return this.curThreadCountField;
			}
			set
			{
				if (!this.curThreadCountField.Equals(value))
				{
					this.curThreadCountField = value;
					this.RaisePropertyChanged("curThreadCount");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public CallEntitySysInfo endingSysInfo
		{
			get
			{
				return this.endingSysInfoField;
			}
			set
			{
				if (!object.ReferenceEquals(this.endingSysInfoField, value))
				{
					this.endingSysInfoField = value;
					this.RaisePropertyChanged("endingSysInfo");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public Guid GUID
		{
			get
			{
				return this.GUIDField;
			}
			set
			{
				if (!this.GUIDField.Equals(value))
				{
					this.GUIDField = value;
					this.RaisePropertyChanged("GUID");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public bool LimitReached
		{
			get
			{
				return this.LimitReachedField;
			}
			set
			{
				if (!this.LimitReachedField.Equals(value))
				{
					this.LimitReachedField = value;
					this.RaisePropertyChanged("LimitReached");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public bool MasterLimitReached
		{
			get
			{
				return this.MasterLimitReachedField;
			}
			set
			{
				if (!this.MasterLimitReachedField.Equals(value))
				{
					this.MasterLimitReachedField = value;
					this.RaisePropertyChanged("MasterLimitReached");
				}
			}
		}

		[DataMember(IsRequired=true)]
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

		[DataMember(IsRequired=true)]
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

		[DataMember(IsRequired=true)]
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

		[DataMember(IsRequired=true)]
		public string MethodName
		{
			get
			{
				return this.MethodNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.MethodNameField, value))
				{
					this.MethodNameField = value;
					this.RaisePropertyChanged("MethodName");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public int sqlDeleteCount
		{
			get
			{
				return this.sqlDeleteCountField;
			}
			set
			{
				if (!this.sqlDeleteCountField.Equals(value))
				{
					this.sqlDeleteCountField = value;
					this.RaisePropertyChanged("sqlDeleteCount");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public int sqlInsertCount
		{
			get
			{
				return this.sqlInsertCountField;
			}
			set
			{
				if (!this.sqlInsertCountField.Equals(value))
				{
					this.sqlInsertCountField = value;
					this.RaisePropertyChanged("sqlInsertCount");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public int sqlQueryCount
		{
			get
			{
				return this.sqlQueryCountField;
			}
			set
			{
				if (!this.sqlQueryCountField.Equals(value))
				{
					this.sqlQueryCountField = value;
					this.RaisePropertyChanged("sqlQueryCount");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public int sqlUpdateCount
		{
			get
			{
				return this.sqlUpdateCountField;
			}
			set
			{
				if (!this.sqlUpdateCountField.Equals(value))
				{
					this.sqlUpdateCountField = value;
					this.RaisePropertyChanged("sqlUpdateCount");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public long StartingTick
		{
			get
			{
				return this.StartingTickField;
			}
			set
			{
				if (!this.StartingTickField.Equals(value))
				{
					this.StartingTickField = value;
					this.RaisePropertyChanged("StartingTick");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public CallEntitySysInfo startSysInfo
		{
			get
			{
				return this.startSysInfoField;
			}
			set
			{
				if (!object.ReferenceEquals(this.startSysInfoField, value))
				{
					this.startSysInfoField = value;
					this.RaisePropertyChanged("startSysInfo");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public CrownPeak.AccessAPI.Stopwatch stopWatch
		{
			get
			{
				return this.stopWatchField;
			}
			set
			{
				if (!object.ReferenceEquals(this.stopWatchField, value))
				{
					this.stopWatchField = value;
					this.RaisePropertyChanged("stopWatch");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public double timeTaken
		{
			get
			{
				return this.timeTakenField;
			}
			set
			{
				if (!this.timeTakenField.Equals(value))
				{
					this.timeTakenField = value;
					this.RaisePropertyChanged("timeTaken");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public double timeThrottled
		{
			get
			{
				return this.timeThrottledField;
			}
			set
			{
				if (!this.timeThrottledField.Equals(value))
				{
					this.timeThrottledField = value;
					this.RaisePropertyChanged("timeThrottled");
				}
			}
		}

		public CallEntity()
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