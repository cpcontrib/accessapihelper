using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="ProviderSettingsConfigData", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model.UIModel")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class ProviderSettingsConfigData : INotifyPropertyChanged
	{
		private string DefaultProviderField;

		private bool FedAuthOnField;

		private bool StandardOnField;

		[DataMember]
		public string DefaultProvider
		{
			get
			{
				return this.DefaultProviderField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DefaultProviderField, value))
				{
					this.DefaultProviderField = value;
					this.RaisePropertyChanged("DefaultProvider");
				}
			}
		}

		[DataMember]
		public bool FedAuthOn
		{
			get
			{
				return this.FedAuthOnField;
			}
			set
			{
				if (!this.FedAuthOnField.Equals(value))
				{
					this.FedAuthOnField = value;
					this.RaisePropertyChanged("FedAuthOn");
				}
			}
		}

		[DataMember]
		public bool StandardOn
		{
			get
			{
				return this.StandardOnField;
			}
			set
			{
				if (!this.StandardOnField.Equals(value))
				{
					this.StandardOnField = value;
					this.RaisePropertyChanged("StandardOn");
				}
			}
		}

		public ProviderSettingsConfigData()
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