using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="PasswordPolicyConfig", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Login")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class PasswordPolicyConfig : INotifyPropertyChanged
	{
		private int DaysNotAbleToReusePasswordField;

		private int DaysToExpirationField;

		private int DaysToWarningField;

		private int NumberOfPasswordsNotAbleReuseField;

		private bool PasswordExpirationEnabledField;

		[DataMember]
		public int DaysNotAbleToReusePassword
		{
			get
			{
				return this.DaysNotAbleToReusePasswordField;
			}
			set
			{
				if (!this.DaysNotAbleToReusePasswordField.Equals(value))
				{
					this.DaysNotAbleToReusePasswordField = value;
					this.RaisePropertyChanged("DaysNotAbleToReusePassword");
				}
			}
		}

		[DataMember]
		public int DaysToExpiration
		{
			get
			{
				return this.DaysToExpirationField;
			}
			set
			{
				if (!this.DaysToExpirationField.Equals(value))
				{
					this.DaysToExpirationField = value;
					this.RaisePropertyChanged("DaysToExpiration");
				}
			}
		}

		[DataMember]
		public int DaysToWarning
		{
			get
			{
				return this.DaysToWarningField;
			}
			set
			{
				if (!this.DaysToWarningField.Equals(value))
				{
					this.DaysToWarningField = value;
					this.RaisePropertyChanged("DaysToWarning");
				}
			}
		}

		[DataMember]
		public int NumberOfPasswordsNotAbleReuse
		{
			get
			{
				return this.NumberOfPasswordsNotAbleReuseField;
			}
			set
			{
				if (!this.NumberOfPasswordsNotAbleReuseField.Equals(value))
				{
					this.NumberOfPasswordsNotAbleReuseField = value;
					this.RaisePropertyChanged("NumberOfPasswordsNotAbleReuse");
				}
			}
		}

		[DataMember]
		public bool PasswordExpirationEnabled
		{
			get
			{
				return this.PasswordExpirationEnabledField;
			}
			set
			{
				if (!this.PasswordExpirationEnabledField.Equals(value))
				{
					this.PasswordExpirationEnabledField = value;
					this.RaisePropertyChanged("PasswordExpirationEnabled");
				}
			}
		}

		public PasswordPolicyConfig()
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