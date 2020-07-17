using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="InstrumentSettings", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Instrumentation")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class InstrumentSettings : INotifyPropertyChanged
	{
		private bool DebugInstrumentationField;

		private double DefaultMasterBucketRateField;

		private double DefaultMasterBucketSizeField;

		private double DefaultMethodBucketRateField;

		private double DefaultMethodBucketSizeField;

		private int DefaultRateLimitThrottleInMillisecondsField;

		private bool EnableInstrumentationField;

		private int RenderTimeoutField;

		private int StackTraceLimitField;

		[DataMember(IsRequired=true)]
		public bool DebugInstrumentation
		{
			get
			{
				return this.DebugInstrumentationField;
			}
			set
			{
				if (!this.DebugInstrumentationField.Equals(value))
				{
					this.DebugInstrumentationField = value;
					this.RaisePropertyChanged("DebugInstrumentation");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public double DefaultMasterBucketRate
		{
			get
			{
				return this.DefaultMasterBucketRateField;
			}
			set
			{
				if (!this.DefaultMasterBucketRateField.Equals(value))
				{
					this.DefaultMasterBucketRateField = value;
					this.RaisePropertyChanged("DefaultMasterBucketRate");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public double DefaultMasterBucketSize
		{
			get
			{
				return this.DefaultMasterBucketSizeField;
			}
			set
			{
				if (!this.DefaultMasterBucketSizeField.Equals(value))
				{
					this.DefaultMasterBucketSizeField = value;
					this.RaisePropertyChanged("DefaultMasterBucketSize");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public double DefaultMethodBucketRate
		{
			get
			{
				return this.DefaultMethodBucketRateField;
			}
			set
			{
				if (!this.DefaultMethodBucketRateField.Equals(value))
				{
					this.DefaultMethodBucketRateField = value;
					this.RaisePropertyChanged("DefaultMethodBucketRate");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public double DefaultMethodBucketSize
		{
			get
			{
				return this.DefaultMethodBucketSizeField;
			}
			set
			{
				if (!this.DefaultMethodBucketSizeField.Equals(value))
				{
					this.DefaultMethodBucketSizeField = value;
					this.RaisePropertyChanged("DefaultMethodBucketSize");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public int DefaultRateLimitThrottleInMilliseconds
		{
			get
			{
				return this.DefaultRateLimitThrottleInMillisecondsField;
			}
			set
			{
				if (!this.DefaultRateLimitThrottleInMillisecondsField.Equals(value))
				{
					this.DefaultRateLimitThrottleInMillisecondsField = value;
					this.RaisePropertyChanged("DefaultRateLimitThrottleInMilliseconds");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public bool EnableInstrumentation
		{
			get
			{
				return this.EnableInstrumentationField;
			}
			set
			{
				if (!this.EnableInstrumentationField.Equals(value))
				{
					this.EnableInstrumentationField = value;
					this.RaisePropertyChanged("EnableInstrumentation");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public int RenderTimeout
		{
			get
			{
				return this.RenderTimeoutField;
			}
			set
			{
				if (!this.RenderTimeoutField.Equals(value))
				{
					this.RenderTimeoutField = value;
					this.RaisePropertyChanged("RenderTimeout");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public int StackTraceLimit
		{
			get
			{
				return this.StackTraceLimitField;
			}
			set
			{
				if (!this.StackTraceLimitField.Equals(value))
				{
					this.StackTraceLimitField = value;
					this.RaisePropertyChanged("StackTraceLimit");
				}
			}
		}

		public InstrumentSettings()
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