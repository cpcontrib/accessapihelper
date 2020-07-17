using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetSiteRootPropertiesResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetSiteRootPropertiesResponse : WSResultClass
	{
		private SiteRootProperties PropertiesField;

		[DataMember]
		public SiteRootProperties Properties
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

		public GetSiteRootPropertiesResponse()
		{
		}
	}
}