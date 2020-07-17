using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetSoapServersDataResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetSoapServersDataResponse : WSResultClass
	{
		private ICollection<SoapServerData> soapServersField;

		[DataMember]
		public ICollection<SoapServerData> soapServers
		{
			get
			{
				return this.soapServersField;
			}
			set
			{
				if (!object.ReferenceEquals(this.soapServersField, value))
				{
					this.soapServersField = value;
					base.RaisePropertyChanged("soapServers");
				}
			}
		}

		public GetSoapServersDataResponse()
		{
		}
	}
}