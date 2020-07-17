using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="SystemSummaryReportResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class SystemSummaryReportResponse : WSResultClass
	{
		private SystemSummaryReportData reportField;

		[DataMember]
		public SystemSummaryReportData report
		{
			get
			{
				return this.reportField;
			}
			set
			{
				if (!object.ReferenceEquals(this.reportField, value))
				{
					this.reportField = value;
					base.RaisePropertyChanged("report");
				}
			}
		}

		public SystemSummaryReportResponse()
		{
		}
	}
}