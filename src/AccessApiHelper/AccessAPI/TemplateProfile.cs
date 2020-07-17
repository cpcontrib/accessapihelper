using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="TemplateProfile", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Instrumentation")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class TemplateProfile : INotifyPropertyChanged
	{
		private int AssetIdField;

		private int BatchField;

		private DateTime ExecutionDateField;

		private string ExecutionTimeField;

		private int ParentTemplateIdField;

		private string PluginNameField;

		private int PublishingSessionIdField;

		private double RateLimitBucketSizeField;

		private double RateLimitLeakRateField;

		private double RateLimitThrottleField;

		private int RenderTimeoutField;

		private ICollection<int> TemplateExecutionListField;

		private int TemplateIdField;

		private string TemplateNameField;

		private int TemplateVersionIdField;

		private string ThrottledTimeField;

		private int UserIdField;

		private ICollection<CallEntity> calltraceField;

		private ICollection<InstrumentEntity> instrumentListField;

		private bool isClientRateLimitingEnabledField;

		private bool isPublishingField;

		private int maxCallStackReachedField;

		private double maxCapacityUsedField;

		private InstrumentSettings settingsField;

		private bool wasRateLimitedField;

		private bool wasStackLimitReachedField;

		[DataMember(IsRequired=true)]
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

		[DataMember(IsRequired=true)]
		public int Batch
		{
			get
			{
				return this.BatchField;
			}
			set
			{
				if (!this.BatchField.Equals(value))
				{
					this.BatchField = value;
					this.RaisePropertyChanged("Batch");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public ICollection<CallEntity> calltrace
		{
			get
			{
				return this.calltraceField;
			}
			set
			{
				if (!object.ReferenceEquals(this.calltraceField, value))
				{
					this.calltraceField = value;
					this.RaisePropertyChanged("calltrace");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public DateTime ExecutionDate
		{
			get
			{
				return this.ExecutionDateField;
			}
			set
			{
				if (!this.ExecutionDateField.Equals(value))
				{
					this.ExecutionDateField = value;
					this.RaisePropertyChanged("ExecutionDate");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string ExecutionTime
		{
			get
			{
				return this.ExecutionTimeField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ExecutionTimeField, value))
				{
					this.ExecutionTimeField = value;
					this.RaisePropertyChanged("ExecutionTime");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public ICollection<InstrumentEntity> instrumentList
		{
			get
			{
				return this.instrumentListField;
			}
			set
			{
				if (!object.ReferenceEquals(this.instrumentListField, value))
				{
					this.instrumentListField = value;
					this.RaisePropertyChanged("instrumentList");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public bool isClientRateLimitingEnabled
		{
			get
			{
				return this.isClientRateLimitingEnabledField;
			}
			set
			{
				if (!this.isClientRateLimitingEnabledField.Equals(value))
				{
					this.isClientRateLimitingEnabledField = value;
					this.RaisePropertyChanged("isClientRateLimitingEnabled");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public bool isPublishing
		{
			get
			{
				return this.isPublishingField;
			}
			set
			{
				if (!this.isPublishingField.Equals(value))
				{
					this.isPublishingField = value;
					this.RaisePropertyChanged("isPublishing");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public int maxCallStackReached
		{
			get
			{
				return this.maxCallStackReachedField;
			}
			set
			{
				if (!this.maxCallStackReachedField.Equals(value))
				{
					this.maxCallStackReachedField = value;
					this.RaisePropertyChanged("maxCallStackReached");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public double maxCapacityUsed
		{
			get
			{
				return this.maxCapacityUsedField;
			}
			set
			{
				if (!this.maxCapacityUsedField.Equals(value))
				{
					this.maxCapacityUsedField = value;
					this.RaisePropertyChanged("maxCapacityUsed");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public int ParentTemplateId
		{
			get
			{
				return this.ParentTemplateIdField;
			}
			set
			{
				if (!this.ParentTemplateIdField.Equals(value))
				{
					this.ParentTemplateIdField = value;
					this.RaisePropertyChanged("ParentTemplateId");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string PluginName
		{
			get
			{
				return this.PluginNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PluginNameField, value))
				{
					this.PluginNameField = value;
					this.RaisePropertyChanged("PluginName");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public int PublishingSessionId
		{
			get
			{
				return this.PublishingSessionIdField;
			}
			set
			{
				if (!this.PublishingSessionIdField.Equals(value))
				{
					this.PublishingSessionIdField = value;
					this.RaisePropertyChanged("PublishingSessionId");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public double RateLimitBucketSize
		{
			get
			{
				return this.RateLimitBucketSizeField;
			}
			set
			{
				if (!this.RateLimitBucketSizeField.Equals(value))
				{
					this.RateLimitBucketSizeField = value;
					this.RaisePropertyChanged("RateLimitBucketSize");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public double RateLimitLeakRate
		{
			get
			{
				return this.RateLimitLeakRateField;
			}
			set
			{
				if (!this.RateLimitLeakRateField.Equals(value))
				{
					this.RateLimitLeakRateField = value;
					this.RaisePropertyChanged("RateLimitLeakRate");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public double RateLimitThrottle
		{
			get
			{
				return this.RateLimitThrottleField;
			}
			set
			{
				if (!this.RateLimitThrottleField.Equals(value))
				{
					this.RateLimitThrottleField = value;
					this.RaisePropertyChanged("RateLimitThrottle");
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
		public InstrumentSettings settings
		{
			get
			{
				return this.settingsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.settingsField, value))
				{
					this.settingsField = value;
					this.RaisePropertyChanged("settings");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public ICollection<int> TemplateExecutionList
		{
			get
			{
				return this.TemplateExecutionListField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TemplateExecutionListField, value))
				{
					this.TemplateExecutionListField = value;
					this.RaisePropertyChanged("TemplateExecutionList");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public int TemplateId
		{
			get
			{
				return this.TemplateIdField;
			}
			set
			{
				if (!this.TemplateIdField.Equals(value))
				{
					this.TemplateIdField = value;
					this.RaisePropertyChanged("TemplateId");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string TemplateName
		{
			get
			{
				return this.TemplateNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TemplateNameField, value))
				{
					this.TemplateNameField = value;
					this.RaisePropertyChanged("TemplateName");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public int TemplateVersionId
		{
			get
			{
				return this.TemplateVersionIdField;
			}
			set
			{
				if (!this.TemplateVersionIdField.Equals(value))
				{
					this.TemplateVersionIdField = value;
					this.RaisePropertyChanged("TemplateVersionId");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string ThrottledTime
		{
			get
			{
				return this.ThrottledTimeField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ThrottledTimeField, value))
				{
					this.ThrottledTimeField = value;
					this.RaisePropertyChanged("ThrottledTime");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public int UserId
		{
			get
			{
				return this.UserIdField;
			}
			set
			{
				if (!this.UserIdField.Equals(value))
				{
					this.UserIdField = value;
					this.RaisePropertyChanged("UserId");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public bool wasRateLimited
		{
			get
			{
				return this.wasRateLimitedField;
			}
			set
			{
				if (!this.wasRateLimitedField.Equals(value))
				{
					this.wasRateLimitedField = value;
					this.RaisePropertyChanged("wasRateLimited");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public bool wasStackLimitReached
		{
			get
			{
				return this.wasStackLimitReachedField;
			}
			set
			{
				if (!this.wasStackLimitReachedField.Equals(value))
				{
					this.wasStackLimitReachedField = value;
					this.RaisePropertyChanged("wasStackLimitReached");
				}
			}
		}

		public TemplateProfile()
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