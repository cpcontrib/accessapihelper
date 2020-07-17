using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GeneralConfigData", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model.UIModel")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GeneralConfigData : INotifyPropertyChanged
	{
		private string AccountAlertEmailField;

		private string ClickShowField;

		private string DefaultEmailField;

		private string DoctypeTagField;

		private string DocumentStateSelectorField;

		private string DowntimeEmailField;

		private string EnableActiveDirectoryAuthField;

		private string EnableWYSIWYGField;

		private string EnableWYSIWYGDebugField;

		private string ErrorEmailField;

		private string GWOAccountIdField;

		private string GWOHostField;

		private string GWOPasswordField;

		private string GWOPublishStateField;

		private string GWOUsernameField;

		private string HelpAssetIdField;

		private string HelpAssetPathField;

		private string HtmlTagField;

		private string InstanceStatusField;

		private string InstanceTypeField;

		private string MaxUploadField;

		private string SupportEmailField;

		private string SupportTelephoneField;

		private string WCOHostField;

		private string WCOPasswordField;

		private string WCOPublishStateField;

		private string WCOUsernameField;

		[DataMember]
		public string AccountAlertEmail
		{
			get
			{
				return this.AccountAlertEmailField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AccountAlertEmailField, value))
				{
					this.AccountAlertEmailField = value;
					this.RaisePropertyChanged("AccountAlertEmail");
				}
			}
		}

		[DataMember]
		public string ClickShow
		{
			get
			{
				return this.ClickShowField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ClickShowField, value))
				{
					this.ClickShowField = value;
					this.RaisePropertyChanged("ClickShow");
				}
			}
		}

		[DataMember]
		public string DefaultEmail
		{
			get
			{
				return this.DefaultEmailField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DefaultEmailField, value))
				{
					this.DefaultEmailField = value;
					this.RaisePropertyChanged("DefaultEmail");
				}
			}
		}

		[DataMember]
		public string DoctypeTag
		{
			get
			{
				return this.DoctypeTagField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DoctypeTagField, value))
				{
					this.DoctypeTagField = value;
					this.RaisePropertyChanged("DoctypeTag");
				}
			}
		}

		[DataMember]
		public string DocumentStateSelector
		{
			get
			{
				return this.DocumentStateSelectorField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DocumentStateSelectorField, value))
				{
					this.DocumentStateSelectorField = value;
					this.RaisePropertyChanged("DocumentStateSelector");
				}
			}
		}

		[DataMember]
		public string DowntimeEmail
		{
			get
			{
				return this.DowntimeEmailField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DowntimeEmailField, value))
				{
					this.DowntimeEmailField = value;
					this.RaisePropertyChanged("DowntimeEmail");
				}
			}
		}

		[DataMember]
		public string EnableActiveDirectoryAuth
		{
			get
			{
				return this.EnableActiveDirectoryAuthField;
			}
			set
			{
				if (!object.ReferenceEquals(this.EnableActiveDirectoryAuthField, value))
				{
					this.EnableActiveDirectoryAuthField = value;
					this.RaisePropertyChanged("EnableActiveDirectoryAuth");
				}
			}
		}

		[DataMember]
		public string EnableWYSIWYG
		{
			get
			{
				return this.EnableWYSIWYGField;
			}
			set
			{
				if (!object.ReferenceEquals(this.EnableWYSIWYGField, value))
				{
					this.EnableWYSIWYGField = value;
					this.RaisePropertyChanged("EnableWYSIWYG");
				}
			}
		}

		[DataMember]
		public string EnableWYSIWYGDebug
		{
			get
			{
				return this.EnableWYSIWYGDebugField;
			}
			set
			{
				if (!object.ReferenceEquals(this.EnableWYSIWYGDebugField, value))
				{
					this.EnableWYSIWYGDebugField = value;
					this.RaisePropertyChanged("EnableWYSIWYGDebug");
				}
			}
		}

		[DataMember]
		public string ErrorEmail
		{
			get
			{
				return this.ErrorEmailField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ErrorEmailField, value))
				{
					this.ErrorEmailField = value;
					this.RaisePropertyChanged("ErrorEmail");
				}
			}
		}

		[DataMember]
		public string GWOAccountId
		{
			get
			{
				return this.GWOAccountIdField;
			}
			set
			{
				if (!object.ReferenceEquals(this.GWOAccountIdField, value))
				{
					this.GWOAccountIdField = value;
					this.RaisePropertyChanged("GWOAccountId");
				}
			}
		}

		[DataMember]
		public string GWOHost
		{
			get
			{
				return this.GWOHostField;
			}
			set
			{
				if (!object.ReferenceEquals(this.GWOHostField, value))
				{
					this.GWOHostField = value;
					this.RaisePropertyChanged("GWOHost");
				}
			}
		}

		[DataMember]
		public string GWOPassword
		{
			get
			{
				return this.GWOPasswordField;
			}
			set
			{
				if (!object.ReferenceEquals(this.GWOPasswordField, value))
				{
					this.GWOPasswordField = value;
					this.RaisePropertyChanged("GWOPassword");
				}
			}
		}

		[DataMember]
		public string GWOPublishState
		{
			get
			{
				return this.GWOPublishStateField;
			}
			set
			{
				if (!object.ReferenceEquals(this.GWOPublishStateField, value))
				{
					this.GWOPublishStateField = value;
					this.RaisePropertyChanged("GWOPublishState");
				}
			}
		}

		[DataMember]
		public string GWOUsername
		{
			get
			{
				return this.GWOUsernameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.GWOUsernameField, value))
				{
					this.GWOUsernameField = value;
					this.RaisePropertyChanged("GWOUsername");
				}
			}
		}

		[DataMember]
		public string HelpAssetId
		{
			get
			{
				return this.HelpAssetIdField;
			}
			set
			{
				if (!object.ReferenceEquals(this.HelpAssetIdField, value))
				{
					this.HelpAssetIdField = value;
					this.RaisePropertyChanged("HelpAssetId");
				}
			}
		}

		[DataMember]
		public string HelpAssetPath
		{
			get
			{
				return this.HelpAssetPathField;
			}
			set
			{
				if (!object.ReferenceEquals(this.HelpAssetPathField, value))
				{
					this.HelpAssetPathField = value;
					this.RaisePropertyChanged("HelpAssetPath");
				}
			}
		}

		[DataMember]
		public string HtmlTag
		{
			get
			{
				return this.HtmlTagField;
			}
			set
			{
				if (!object.ReferenceEquals(this.HtmlTagField, value))
				{
					this.HtmlTagField = value;
					this.RaisePropertyChanged("HtmlTag");
				}
			}
		}

		[DataMember]
		public string InstanceStatus
		{
			get
			{
				return this.InstanceStatusField;
			}
			set
			{
				if (!object.ReferenceEquals(this.InstanceStatusField, value))
				{
					this.InstanceStatusField = value;
					this.RaisePropertyChanged("InstanceStatus");
				}
			}
		}

		[DataMember]
		public string InstanceType
		{
			get
			{
				return this.InstanceTypeField;
			}
			set
			{
				if (!object.ReferenceEquals(this.InstanceTypeField, value))
				{
					this.InstanceTypeField = value;
					this.RaisePropertyChanged("InstanceType");
				}
			}
		}

		[DataMember]
		public string MaxUpload
		{
			get
			{
				return this.MaxUploadField;
			}
			set
			{
				if (!object.ReferenceEquals(this.MaxUploadField, value))
				{
					this.MaxUploadField = value;
					this.RaisePropertyChanged("MaxUpload");
				}
			}
		}

		[DataMember]
		public string SupportEmail
		{
			get
			{
				return this.SupportEmailField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SupportEmailField, value))
				{
					this.SupportEmailField = value;
					this.RaisePropertyChanged("SupportEmail");
				}
			}
		}

		[DataMember]
		public string SupportTelephone
		{
			get
			{
				return this.SupportTelephoneField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SupportTelephoneField, value))
				{
					this.SupportTelephoneField = value;
					this.RaisePropertyChanged("SupportTelephone");
				}
			}
		}

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

		public GeneralConfigData()
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