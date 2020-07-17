using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetPerformanceDataResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetPerformanceDataResponse : WSResultClass
	{
		private AssetRenderPerformanceHistory RenderPerformanceHistoryField;

		[DataMember]
		public AssetRenderPerformanceHistory RenderPerformanceHistory
		{
			get
			{
				return this.RenderPerformanceHistoryField;
			}
			set
			{
				if (!object.ReferenceEquals(this.RenderPerformanceHistoryField, value))
				{
					this.RenderPerformanceHistoryField = value;
					base.RaisePropertyChanged("RenderPerformanceHistory");
				}
			}
		}

		public GetPerformanceDataResponse()
		{
		}
	}
}