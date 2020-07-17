using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetOrphanReportServerDataResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetOrphanReportServerDataResponse : WSResultClass
	{
		private ICollection<OrphanReportServerData> packagesField;

		[DataMember]
		public ICollection<OrphanReportServerData> packages
		{
			get
			{
				return this.packagesField;
			}
			set
			{
				if (!object.ReferenceEquals(this.packagesField, value))
				{
					this.packagesField = value;
					base.RaisePropertyChanged("packages");
				}
			}
		}

		public GetOrphanReportServerDataResponse()
		{
		}
	}
}