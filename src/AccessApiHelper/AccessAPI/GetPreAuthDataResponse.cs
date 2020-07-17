using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetPreAuthDataResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetPreAuthDataResponse : WSResultClass
	{
		private bool EnableRememberMeField;

		private bool FedAuthEnabledField;

		private string MessageField;

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
					base.RaisePropertyChanged("EnableRememberMe");
				}
			}
		}

		[DataMember]
		public bool FedAuthEnabled
		{
			get
			{
				return this.FedAuthEnabledField;
			}
			set
			{
				if (!this.FedAuthEnabledField.Equals(value))
				{
					this.FedAuthEnabledField = value;
					base.RaisePropertyChanged("FedAuthEnabled");
				}
			}
		}

		[DataMember]
		public string Message
		{
			get
			{
				return this.MessageField;
			}
			set
			{
				if (!object.ReferenceEquals(this.MessageField, value))
				{
					this.MessageField = value;
					base.RaisePropertyChanged("Message");
				}
			}
		}

		public GetPreAuthDataResponse()
		{
		}
	}
}