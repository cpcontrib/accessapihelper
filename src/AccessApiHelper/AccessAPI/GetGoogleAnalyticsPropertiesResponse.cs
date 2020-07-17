using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetGoogleAnalyticsPropertiesResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetGoogleAnalyticsPropertiesResponse : WSResultClass
	{
		private ICollection<GoogleAnalyticsAccount> PropertiesField;

		[DataMember]
		public ICollection<GoogleAnalyticsAccount> Properties
		{
			get
			{
				return this.PropertiesField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PropertiesField, value))
				{
					this.PropertiesField = value;
					base.RaisePropertyChanged("Properties");
				}
			}
		}

		public GetGoogleAnalyticsPropertiesResponse()
		{
		}
	}
}