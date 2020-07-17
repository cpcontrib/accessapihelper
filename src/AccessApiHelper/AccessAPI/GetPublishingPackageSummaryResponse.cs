using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetPublishingPackageSummaryResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetPublishingPackageSummaryResponse : WSResultClass
	{
		private PublishingPackageSummary SummaryField;

		[DataMember]
		public PublishingPackageSummary Summary
		{
			get
			{
				return this.SummaryField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SummaryField, value))
				{
					this.SummaryField = value;
					base.RaisePropertyChanged("Summary");
				}
			}
		}

		public GetPublishingPackageSummaryResponse()
		{
		}
	}
}