using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetGoogleDriveRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetGoogleDriveRequest : INotifyPropertyChanged
	{
		private string AccessTokenField;

		private int ConnectorIdField;

		[DataMember]
		public string AccessToken
		{
			get
			{
				return this.AccessTokenField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AccessTokenField, value))
				{
					this.AccessTokenField = value;
					this.RaisePropertyChanged("AccessToken");
				}
			}
		}

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
					this.RaisePropertyChanged("ConnectorId");
				}
			}
		}

		public GetGoogleDriveRequest()
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