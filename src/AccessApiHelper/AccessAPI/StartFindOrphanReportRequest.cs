using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="StartFindOrphanReportRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class StartFindOrphanReportRequest : BaseRequest
	{
		private OrphanReportServerData PackageField;

		[DataMember]
		public OrphanReportServerData Package
		{
			get
			{
				return this.PackageField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PackageField, value))
				{
					this.PackageField = value;
					base.RaisePropertyChanged("Package");
				}
			}
		}

		public StartFindOrphanReportRequest()
		{
		}
	}
}