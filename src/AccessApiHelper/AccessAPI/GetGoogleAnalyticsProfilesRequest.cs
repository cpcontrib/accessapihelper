using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetGoogleAnalyticsProfilesRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetGoogleAnalyticsProfilesRequest : INotifyPropertyChanged
	{
		private string AccessTokenField;

		private string AccountIdField;

		private string PropertyIdField;

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
		public string AccountId
		{
			get
			{
				return this.AccountIdField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AccountIdField, value))
				{
					this.AccountIdField = value;
					this.RaisePropertyChanged("AccountId");
				}
			}
		}

		[DataMember]
		public string PropertyId
		{
			get
			{
				return this.PropertyIdField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PropertyIdField, value))
				{
					this.PropertyIdField = value;
					this.RaisePropertyChanged("PropertyId");
				}
			}
		}

		public GetGoogleAnalyticsProfilesRequest()
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