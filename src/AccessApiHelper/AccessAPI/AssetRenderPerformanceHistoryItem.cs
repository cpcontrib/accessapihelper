using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="AssetRenderPerformanceHistoryItem", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class AssetRenderPerformanceHistoryItem : INotifyPropertyChanged
	{
		private int AssetIdField;

		private double AverageExecutionTimeField;

		private int CountField;

		private DateTime DateFromField;

		private DateTime DateToField;

		private int TemplateIdField;

		private int TemplateVersionField;

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
		public double AverageExecutionTime
		{
			get
			{
				return this.AverageExecutionTimeField;
			}
			set
			{
				if (!this.AverageExecutionTimeField.Equals(value))
				{
					this.AverageExecutionTimeField = value;
					this.RaisePropertyChanged("AverageExecutionTime");
				}
			}
		}

		[DataMember]
		public int Count
		{
			get
			{
				return this.CountField;
			}
			set
			{
				if (!this.CountField.Equals(value))
				{
					this.CountField = value;
					this.RaisePropertyChanged("Count");
				}
			}
		}

		[DataMember]
		public DateTime DateFrom
		{
			get
			{
				return this.DateFromField;
			}
			set
			{
				if (!this.DateFromField.Equals(value))
				{
					this.DateFromField = value;
					this.RaisePropertyChanged("DateFrom");
				}
			}
		}

		[DataMember]
		public DateTime DateTo
		{
			get
			{
				return this.DateToField;
			}
			set
			{
				if (!this.DateToField.Equals(value))
				{
					this.DateToField = value;
					this.RaisePropertyChanged("DateTo");
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
		public int TemplateVersion
		{
			get
			{
				return this.TemplateVersionField;
			}
			set
			{
				if (!this.TemplateVersionField.Equals(value))
				{
					this.TemplateVersionField = value;
					this.RaisePropertyChanged("TemplateVersion");
				}
			}
		}

		public AssetRenderPerformanceHistoryItem()
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