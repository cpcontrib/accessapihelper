using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetSite24x7Response", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetSite24x7Response : WSResultClass
	{
		private ICollection<Site24x7MonitorData> MonitorsField;

		[DataMember]
		public ICollection<Site24x7MonitorData> Monitors
		{
			get
			{
				return this.MonitorsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.MonitorsField, value))
				{
					this.MonitorsField = value;
					base.RaisePropertyChanged("Monitors");
				}
			}
		}

		public GetSite24x7Response()
		{
		}
	}
}