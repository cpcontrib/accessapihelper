using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="TemplateReportResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class TemplateReportResponse : WSResultClass
	{
		private ICollection<cpListscpKeyValuePair> UIConfigurationField;

		private ICollection<ReportDataTemplate> templatesField;

		[DataMember]
		public ICollection<ReportDataTemplate> templates
		{
			get
			{
				return this.templatesField;
			}
			set
			{
				if (!object.ReferenceEquals(this.templatesField, value))
				{
					this.templatesField = value;
					base.RaisePropertyChanged("templates");
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

		public TemplateReportResponse()
		{
		}
	}
}