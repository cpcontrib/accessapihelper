using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetProviderInfoResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetProviderInfoResponse : WSResultClass
	{
		private Provider providerField;

		[DataMember]
		public Provider provider
		{
			get
			{
				return this.providerField;
			}
			set
			{
				if (!object.ReferenceEquals(this.providerField, value))
				{
					this.providerField = value;
					base.RaisePropertyChanged("provider");
				}
			}
		}

		public GetProviderInfoResponse()
		{
		}
	}
}