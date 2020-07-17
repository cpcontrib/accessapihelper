using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetGoogleAnalyticsDataRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetGoogleAnalyticsDataRequest : INotifyPropertyChanged
	{
		private string ConnectorIdField;

		[DataMember]
		public string ConnectorId
		{
			get
			{
				return this.ConnectorIdField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ConnectorIdField, value))
				{
					this.ConnectorIdField = value;
					this.RaisePropertyChanged("ConnectorId");
				}
			}
		}

		public GetGoogleAnalyticsDataRequest()
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