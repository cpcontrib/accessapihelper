using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="ReportResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class ReportResponse : WSResultClass
	{
		private ICollection<cpListscpKeyValuePair> UIConfigurationField;

		private ReportData reportDataField;

		[DataMember]
		public ReportData reportData
		{
			get
			{
				return this.reportDataField;
			}
			set
			{
				if (!object.ReferenceEquals(this.reportDataField, value))
				{
					this.reportDataField = value;
					base.RaisePropertyChanged("reportData");
				}
			}
		}

		[DataMember]
		public ICollection<cpListscpKeyValuePair> UIConfiguration
		{
			get
			{
				return this.UIConfigurationField;
			}
			set
			{
				if (!object.ReferenceEquals(this.UIConfigurationField, value))
				{
					this.UIConfigurationField = value;
					base.RaisePropertyChanged("UIConfiguration");
				}
			}
		}

		public ReportResponse()
		{
		}
	}
}