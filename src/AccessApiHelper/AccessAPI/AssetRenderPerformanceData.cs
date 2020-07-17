using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="AssetRenderPerformanceData", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class AssetRenderPerformanceData : INotifyPropertyChanged
	{
		private int BatchIdField;

		private int CapacityUsedField;

		private DateTime CreatedField;

		private double ExecutionTimeField;

		private int MaxStackSizeField;

		private int ParentTemplateIdField;

		private bool RateLimitHitField;

		private bool StackLimitHitField;

		private int TemplateIdField;

		private string TemplatePathField;

		private double ThrottledTimeField;

		private bool WasPublishingField;

		[DataMember]
		public int BatchId
		{
			get
			{
				return this.BatchIdField;
			}
			set
			{
				if (!this.BatchIdField.Equals(value))
				{
					this.BatchIdField = value;
					this.RaisePropertyChanged("BatchId");
				}
			}
		}

		[DataMember]
		public int CapacityUsed
		{
			get
			{
				return this.CapacityUsedField;
			}
			set
			{
				if (!this.CapacityUsedField.Equals(value))
				{
					this.CapacityUsedField = value;
					this.RaisePropertyChanged("CapacityUsed");
				}
			}
		}

		[DataMember]
		public DateTime Created
		{
			get
			{
				return this.CreatedField;
			}
			set
			{
				if (!this.CreatedField.Equals(value))
				{
					this.CreatedField = value;
					this.RaisePropertyChanged("Created");
				}
			}
		}

		[DataMember]
		public double ExecutionTime
		{
			get
			{
				return this.ExecutionTimeField;
			}
			set
			{
				if (!this.ExecutionTimeField.Equals(value))
				{
					this.ExecutionTimeField = value;
					this.RaisePropertyChanged("ExecutionTime");
				}
			}
		}

		[DataMember]
		public int MaxStackSize
		{
			get
			{
				return this.MaxStackSizeField;
			}
			set
			{
				if (!this.MaxStackSizeField.Equals(value))
				{
					this.MaxStackSizeField = value;
					this.RaisePropertyChanged("MaxStackSize");
				}
			}
		}

		[DataMember]
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

		[DataMember]
		public bool RateLimitHit
		{
			get
			{
				return this.RateLimitHitField;
			}
			set
			{
				if (!this.RateLimitHitField.Equals(value))
				{
					this.RateLimitHitField = value;
					this.RaisePropertyChanged("RateLimitHit");
				}
			}
		}

		[DataMember]
		public bool StackLimitHit
		{
			get
			{
				return this.StackLimitHitField;
			}
			set
			{
				if (!this.StackLimitHitField.Equals(value))
				{
					this.StackLimitHitField = value;
					this.RaisePropertyChanged("StackLimitHit");
				}
			}
		}

		[DataMember]
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

		[DataMember]
		public string TemplatePath
		{
			get
			{
				return this.TemplatePathField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TemplatePathField, value))
				{
					this.TemplatePathField = value;
					this.RaisePropertyChanged("TemplatePath");
				}
			}
		}

		[DataMember]
		public double ThrottledTime
		{
			get
			{
				return this.ThrottledTimeField;
			}
			set
			{
				if (!this.ThrottledTimeField.Equals(value))
				{
					this.ThrottledTimeField = value;
					this.RaisePropertyChanged("ThrottledTime");
				}
			}
		}

		[DataMember]
		public bool WasPublishing
		{
			get
			{
				return this.WasPublishingField;
			}
			set
			{
				if (!this.WasPublishingField.Equals(value))
				{
					this.WasPublishingField = value;
					this.RaisePropertyChanged("WasPublishing");
				}
			}
		}

		public AssetRenderPerformanceData()
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