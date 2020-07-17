using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetConnectorConfigDataResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetConnectorConfigDataResponse : WSResultClass
	{
		private ICollection<ConnectorConfigData> connectorsField;

		[DataMember]
		public ICollection<ConnectorConfigData> connectors
		{
			get
			{
				return this.connectorsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.connectorsField, value))
				{
					this.connectorsField = value;
					base.RaisePropertyChanged("connectors");
				}
			}
		}

		public GetConnectorConfigDataResponse()
		{
		}
	}
}