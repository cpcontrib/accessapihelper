using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="SetPasswordPolicyRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class SetPasswordPolicyRequest : INotifyPropertyChanged
	{
		private int DaysNotAbleToReusePasswordField;

		private int DaysToExpirationField;

		private int DaysToWarningField;

		private int NumberOfPasswordsNotAbleReuseField;

		private bool PasswordExpirationEnabledField;

		private bool ResetLastPasswordDateField;

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

		[DataMember]
		public bool ResetLastPasswordDate
		{
			get
			{
				return this.ResetLastPasswordDateField;
			}
			set
			{
				if (!this.ResetLastPasswordDateField.Equals(value))
				{
					this.ResetLastPasswordDateField = value;
					this.RaisePropertyChanged("ResetLastPasswordDate");
				}
			}
		}

		public SetPasswordPolicyRequest()
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