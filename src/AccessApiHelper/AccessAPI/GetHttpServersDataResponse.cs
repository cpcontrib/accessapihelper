using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetHttpServersDataResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetHttpServersDataResponse : WSResultClass
	{
		private ICollection<HttpServerData> httpServersField;

		[DataMember]
		public ICollection<HttpServerData> httpServers
		{
			get
			{
				return this.httpServersField;
			}
			set
			{
				if (!object.ReferenceEquals(this.httpServersField, value))
				{
					this.httpServersField = value;
					base.RaisePropertyChanged("httpServers");
				}
			}
		}

		public GetHttpServersDataResponse()
		{
		}
	}
}