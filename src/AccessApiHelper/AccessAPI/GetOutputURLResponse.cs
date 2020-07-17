using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetOutputURLResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetOutputURLResponse : WSResultClass
	{
		private AssetRenderPerformanceSummary RenderPerformanceSummaryField;

		private string urlField;

		[DataMember]
		public AssetRenderPerformanceSummary RenderPerformanceSummary
		{
			get
			{
				return this.RenderPerformanceSummaryField;
			}
			set
			{
				if (!object.ReferenceEquals(this.RenderPerformanceSummaryField, value))
				{
					this.RenderPerformanceSummaryField = value;
					base.RaisePropertyChanged("RenderPerformanceSummary");
				}
			}
		}

		[DataMember]
		public string url
		{
			get
			{
				return this.urlField;
			}
			set
			{
				if (!object.ReferenceEquals(this.urlField, value))
				{
					this.urlField = value;
					base.RaisePropertyChanged("url");
				}
			}
		}

		public GetOutputURLResponse()
		{
		}
	}
}