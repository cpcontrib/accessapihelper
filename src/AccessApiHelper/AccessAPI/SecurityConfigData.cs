using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="SecurityConfigData", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model.UIModel")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class SecurityConfigData : INotifyPropertyChanged
	{
		private DateTime? AllowLoginEndTimeField;

		private DateTime? AllowLoginStartTimeField;

		private bool EnableRememberMeField;

		private ICollection<ApprovedHostname> HostnameWhitelistField;

		private int? LockoutAttemptsField;

		private int? MinutesUntilTimeoutField;

		private DateTime? PublishBlackoutEndTimeField;

		private DateTime? PublishBlackoutStartTimeField;

		private ICollection<string> TimeZoneOptionsField;

		private string TimezoneField;

		private bool UseCertificationImageField;

		[DataMember]
		public DateTime? AllowLoginEndTime
		{
			get
			{
				return this.AllowLoginEndTimeField;
			}
			set
			{
				if (!this.AllowLoginEndTimeField.Equals(value))
				{
					this.AllowLoginEndTimeField = value;
					this.RaisePropertyChanged("AllowLoginEndTime");
				}
			}
		}

		[DataMember]
		public DateTime? AllowLoginStartTime
		{
			get
			{
				return this.AllowLoginStartTimeField;
			}
			set
			{
				if (!this.AllowLoginStartTimeField.Equals(value))
				{
					this.AllowLoginStartTimeField = value;
					this.RaisePropertyChanged("AllowLoginStartTime");
				}
			}
		}

		[DataMember]
		public bool EnableRememberMe
		{
			get
			{
				return this.EnableRememberMeField;
			}
			set
			{
				if (!this.EnableRememberMeField.Equals(value))
				{
					this.EnableRememberMeField = value;
					this.RaisePropertyChanged("EnableRememberMe");
				}
			}
		}

		[DataMember]
		public ICollection<ApprovedHostname> HostnameWhitelist
		{
			get
			{
				return this.HostnameWhitelistField;
			}
			set
			{
				if (!object.ReferenceEquals(this.HostnameWhitelistField, value))
				{
					this.HostnameWhitelistField = value;
					this.RaisePropertyChanged("HostnameWhitelist");
				}
			}
		}

		[DataMember]
		public int? LockoutAttempts
		{
			get
			{
				return this.LockoutAttemptsField;
			}
			set
			{
				if (!this.LockoutAttemptsField.Equals(value))
				{
					this.LockoutAttemptsField = value;
					this.RaisePropertyChanged("LockoutAttempts");
				}
			}
		}

		[DataMember]
		public int? MinutesUntilTimeout
		{
			get
			{
				return this.MinutesUntilTimeoutField;
			}
			set
			{
				if (!this.MinutesUntilTimeoutField.Equals(value))
				{
					this.MinutesUntilTimeoutField = value;
					this.RaisePropertyChanged("MinutesUntilTimeout");
				}
			}
		}

		[DataMember]
		public DateTime? PublishBlackoutEndTime
		{
			get
			{
				return this.PublishBlackoutEndTimeField;
			}
			set
			{
				if (!this.PublishBlackoutEndTimeField.Equals(value))
				{
					this.PublishBlackoutEndTimeField = value;
					this.RaisePropertyChanged("PublishBlackoutEndTime");
				}
			}
		}

		[DataMember]
		public DateTime? PublishBlackoutStartTime
		{
			get
			{
				return this.PublishBlackoutStartTimeField;
			}
			set
			{
				if (!this.PublishBlackoutStartTimeField.Equals(value))
				{
					this.PublishBlackoutStartTimeField = value;
					this.RaisePropertyChanged("PublishBlackoutStartTime");
				}
			}
		}

		[DataMember]
		public string Timezone
		{
			get
			{
				return this.TimezoneField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TimezoneField, value))
				{
					this.TimezoneField = value;
					this.RaisePropertyChanged("Timezone");
				}
			}
		}

		[DataMember]
		public ICollection<string> TimeZoneOptions
		{
			get
			{
				return this.TimeZoneOptionsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TimeZoneOptionsField, value))
				{
					this.TimeZoneOptionsField = value;
					this.RaisePropertyChanged("TimeZoneOptions");
				}
			}
		}

		[DataMember]
		public bool UseCertificationImage
		{
			get
			{
				return this.UseCertificationImageField;
			}
			set
			{
				if (!this.UseCertificationImageField.Equals(value))
				{
					this.UseCertificationImageField = value;
					this.RaisePropertyChanged("UseCertificationImage");
				}
			}
		}

		public SecurityConfigData()
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