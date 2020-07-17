using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="AssetRenderPerformanceSummary", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class AssetRenderPerformanceSummary : INotifyPropertyChanged
	{
		private ICollection<AssetRenderPerformanceData> RenderPerformanceListField;

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

		public AssetRenderPerformanceSummary()
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