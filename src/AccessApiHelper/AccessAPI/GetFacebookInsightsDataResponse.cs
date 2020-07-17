using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetFacebookInsightsDataResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetFacebookInsightsDataResponse : WSResultClass
	{
		private FacebookInsightsData DataField;

		[DataMember]
		public FacebookInsightsData Data
		{
			get
			{
				return this.DataField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DataField, value))
				{
					this.DataField = value;
					base.RaisePropertyChanged("Data");
				}
			}
		}

		public GetFacebookInsightsDataResponse()
		{
		}
	}
}