using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetConnectorRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetConnectorRequest : INotifyPropertyChanged
	{
		private int ConnectorTypeField;

		[DataMember]
		public int ConnectorType
		{
			get
			{
				return this.ConnectorTypeField;
			}
			set
			{
				if (!this.ConnectorTypeField.Equals(value))
				{
					this.ConnectorTypeField = value;
					this.RaisePropertyChanged("ConnectorType");
				}
			}
		}

		public GetConnectorRequest()
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