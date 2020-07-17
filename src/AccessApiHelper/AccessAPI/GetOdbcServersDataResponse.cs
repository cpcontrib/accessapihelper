using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetOdbcServersDataResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetOdbcServersDataResponse : WSResultClass
	{
		private ICollection<OdbcServerData> odbcServersField;

		[DataMember]
		public ICollection<OdbcServerData> odbcServers
		{
			get
			{
				return this.odbcServersField;
			}
			set
			{
				if (!object.ReferenceEquals(this.odbcServersField, value))
				{
					this.odbcServersField = value;
					base.RaisePropertyChanged("odbcServers");
				}
			}
		}

		public GetOdbcServersDataResponse()
		{
		}
	}
}