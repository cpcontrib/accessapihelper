using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetDiagnosticsReportDataResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetDiagnosticsReportDataResponse : WSResultClass
	{
		private ICollection<DiagnosticsReportData> dailyReportField;

		private ICollection<DiagnosticsErrorData> errorReportField;

		private ICollection<DiagnosticsReportData> runtimeReportField;

		[DataMember]
		public ICollection<DiagnosticsReportData> dailyReport
		{
			get
			{
				return this.dailyReportField;
			}
			set
			{
				if (!object.ReferenceEquals(this.dailyReportField, value))
				{
					this.dailyReportField = value;
					base.RaisePropertyChanged("dailyReport");
				}
			}
		}

		[DataMember]
		public ICollection<DiagnosticsErrorData> errorReport
		{
			get
			{
				return this.errorReportField;
			}
			set
			{
				if (!object.ReferenceEquals(this.errorReportField, value))
				{
					this.errorReportField = value;
					base.RaisePropertyChanged("errorReport");
				}
			}
		}

		[DataMember]
		public ICollection<DiagnosticsReportData> runtimeReport
		{
			get
			{
				return this.runtimeReportField;
			}
			set
			{
				if (!object.ReferenceEquals(this.runtimeReportField, value))
				{
					this.runtimeReportField = value;
					base.RaisePropertyChanged("runtimeReport");
				}
			}
		}

		public GetDiagnosticsReportDataResponse()
		{
		}
	}
}