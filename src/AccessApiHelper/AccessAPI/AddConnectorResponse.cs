using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="AddConnectorResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class AddConnectorResponse : WSResultClass
	{
		private int ConnectorIdField;

		[DataMember]
		public int ConnectorId
		{
			get
			{
				return this.ConnectorIdField;
			}
			set
			{
				if (!this.ConnectorIdField.Equals(value))
				{
					this.ConnectorIdField = value;
					base.RaisePropertyChanged("ConnectorId");
				}
			}
		}

		public AddConnectorResponse()
		{
		}
	}
}