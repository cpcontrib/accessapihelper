using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetProvidersResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetProvidersResponse : WSResultClass
	{
		private ICollection<Provider> providersField;

		[DataMember]
		public ICollection<Provider> providers
		{
			get
			{
				return this.providersField;
			}
			set
			{
				if (!object.ReferenceEquals(this.providersField, value))
				{
					this.providersField = value;
					base.RaisePropertyChanged("providers");
				}
			}
		}

		public GetProvidersResponse()
		{
		}
	}
}