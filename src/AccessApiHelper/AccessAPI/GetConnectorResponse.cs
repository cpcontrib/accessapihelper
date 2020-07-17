using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetConnectorResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetConnectorResponse : WSResultClass
	{
		private ICollection<ConnectorSelectorData> ConnectorsField;

		[DataMember]
		public ICollection<ConnectorSelectorData> Connectors
		{
			get
			{
				return this.ConnectorsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ConnectorsField, value))
				{
					this.ConnectorsField = value;
					base.RaisePropertyChanged("Connectors");
				}
			}
		}

		public GetConnectorResponse()
		{
		}
	}
}