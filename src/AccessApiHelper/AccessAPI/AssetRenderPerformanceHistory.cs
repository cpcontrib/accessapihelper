using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="AssetRenderPerformanceHistory", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class AssetRenderPerformanceHistory : INotifyPropertyChanged
	{
		private ICollection<AssetRenderPerformanceData> RenderPerformanceListField;

		private ICollection<AssetRenderPerformanceHistoryItem> TemplateRenderHistoryField;

		private TemplateProfile TemplateRenderSummaryField;

		[DataMember]
		public ICollection<AssetRenderPerformanceData> RenderPerformanceList
		{
			get
			{
				return this.RenderPerformanceListField;
			}
			set
			{
				if (!object.ReferenceEquals(this.RenderPerformanceListField, value))
				{
					this.RenderPerformanceListField = value;
					this.RaisePropertyChanged("RenderPerformanceList");
				}
			}
		}

		[DataMember]
		public ICollection<AssetRenderPerformanceHistoryItem> TemplateRenderHistory
		{
			get
			{
				return this.TemplateRenderHistoryField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TemplateRenderHistoryField, value))
				{
					this.TemplateRenderHistoryField = value;
					this.RaisePropertyChanged("TemplateRenderHistory");
				}
			}
		}

		[DataMember]
		public TemplateProfile TemplateRenderSummary
		{
			get
			{
				return this.TemplateRenderSummaryField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TemplateRenderSummaryField, value))
				{
					this.TemplateRenderSummaryField = value;
					this.RaisePropertyChanged("TemplateRenderSummary");
				}
			}
		}

		public AssetRenderPerformanceHistory()
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