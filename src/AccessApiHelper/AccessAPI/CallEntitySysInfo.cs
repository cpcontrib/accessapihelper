using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="CallEntitySysInfo", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Instrumentation")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class CallEntitySysInfo : INotifyPropertyChanged
	{
		private long PeakPagedMemorySize64Field;

		private long PeakVirtualMemorySize64Field;

		private long PeakWorkingSet64Field;

		private TimeSpan PrivilegedProcessorTimeField;

		private TimeSpan TotalProcessorTimeField;

		private TimeSpan UserProcessorTimeField;

		private int curThreadCountField;

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
		public long PeakPagedMemorySize64
		{
			get
			{
				return this.PeakPagedMemorySize64Field;
			}
			set
			{
				if (!this.PeakPagedMemorySize64Field.Equals(value))
				{
					this.PeakPagedMemorySize64Field = value;
					this.RaisePropertyChanged("PeakPagedMemorySize64");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public long PeakVirtualMemorySize64
		{
			get
			{
				return this.PeakVirtualMemorySize64Field;
			}
			set
			{
				if (!this.PeakVirtualMemorySize64Field.Equals(value))
				{
					this.PeakVirtualMemorySize64Field = value;
					this.RaisePropertyChanged("PeakVirtualMemorySize64");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public long PeakWorkingSet64
		{
			get
			{
				return this.PeakWorkingSet64Field;
			}
			set
			{
				if (!this.PeakWorkingSet64Field.Equals(value))
				{
					this.PeakWorkingSet64Field = value;
					this.RaisePropertyChanged("PeakWorkingSet64");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public TimeSpan PrivilegedProcessorTime
		{
			get
			{
				return this.PrivilegedProcessorTimeField;
			}
			set
			{
				if (!this.PrivilegedProcessorTimeField.Equals(value))
				{
					this.PrivilegedProcessorTimeField = value;
					this.RaisePropertyChanged("PrivilegedProcessorTime");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public TimeSpan TotalProcessorTime
		{
			get
			{
				return this.TotalProcessorTimeField;
			}
			set
			{
				if (!this.TotalProcessorTimeField.Equals(value))
				{
					this.TotalProcessorTimeField = value;
					this.RaisePropertyChanged("TotalProcessorTime");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public TimeSpan UserProcessorTime
		{
			get
			{
				return this.UserProcessorTimeField;
			}
			set
			{
				if (!this.UserProcessorTimeField.Equals(value))
				{
					this.UserProcessorTimeField = value;
					this.RaisePropertyChanged("UserProcessorTime");
				}
			}
		}

		public CallEntitySysInfo()
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