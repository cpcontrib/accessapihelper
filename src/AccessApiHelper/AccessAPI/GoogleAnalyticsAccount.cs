using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GoogleAnalyticsAccount", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GoogleAnalyticsAccount : INotifyPropertyChanged
	{
		private string AccountIdField;

		private string AccountNameField;

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
		public string AccountName
		{
			get
			{
				return this.AccountNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AccountNameField, value))
				{
					this.AccountNameField = value;
					this.RaisePropertyChanged("AccountName");
				}
			}
		}

		public GoogleAnalyticsAccount()
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