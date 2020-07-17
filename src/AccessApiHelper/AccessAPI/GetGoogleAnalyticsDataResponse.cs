using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetGoogleAnalyticsDataResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetGoogleAnalyticsDataResponse : WSResultClass
	{
		private GoogleAnalyticsData DataField;

		[DataMember]
		public GoogleAnalyticsData Data
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

		public GetGoogleAnalyticsDataResponse()
		{
		}
	}
}