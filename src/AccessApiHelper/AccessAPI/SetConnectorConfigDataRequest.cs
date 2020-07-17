using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="SetConnectorConfigDataRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class SetConnectorConfigDataRequest : INotifyPropertyChanged
	{
		private ICollection<ConnectorConfigData> ConnectorsField;

		[DataMember]
		public ICollection<ConnectorConfigData> Connectors
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
					this.RaisePropertyChanged("Connectors");
				}
			}
		}

		public SetConnectorConfigDataRequest()
		{
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;
	}
}