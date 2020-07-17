using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetGoogleAnalyticsAccountsRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetGoogleAnalyticsAccountsRequest : INotifyPropertyChanged
	{
		private string AccessTokenField;

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

		public GetGoogleAnalyticsAccountsRequest()
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