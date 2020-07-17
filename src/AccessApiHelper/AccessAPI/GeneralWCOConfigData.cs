using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GeneralWCOConfigData", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model.UIModel")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GeneralWCOConfigData : INotifyPropertyChanged
	{
		private string WCOHostField;

		private string WCOPasswordField;

		private string WCOPublishStateField;

		private string WCOUsernameField;

		[DataMember]
		public string WCOHost
		{
			get
			{
				return this.WCOHostField;
			}
			set
			{
				if (!object.ReferenceEquals(this.WCOHostField, value))
				{
					this.WCOHostField = value;
					this.RaisePropertyChanged("WCOHost");
				}
			}
		}

		[DataMember]
		public string WCOPassword
		{
			get
			{
				return this.WCOPasswordField;
			}
			set
			{
				if (!object.ReferenceEquals(this.WCOPasswordField, value))
				{
					this.WCOPasswordField = value;
					this.RaisePropertyChanged("WCOPassword");
				}
			}
		}

		[DataMember]
		public string WCOPublishState
		{
			get
			{
				return this.WCOPublishStateField;
			}
			set
			{
				if (!object.ReferenceEquals(this.WCOPublishStateField, value))
				{
					this.WCOPublishStateField = value;
					this.RaisePropertyChanged("WCOPublishState");
				}
			}
		}

		[DataMember]
		public string WCOUsername
		{
			get
			{
				return this.WCOUsernameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.WCOUsernameField, value))
				{
					this.WCOUsernameField = value;
					this.RaisePropertyChanged("WCOUsername");
				}
			}
		}

		public GeneralWCOConfigData()
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