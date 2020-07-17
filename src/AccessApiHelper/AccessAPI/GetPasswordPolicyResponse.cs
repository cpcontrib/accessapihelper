using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetPasswordPolicyResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetPasswordPolicyResponse : WSResultClass
	{
		private PasswordPolicyConfig passwordPolicyConfigField;

		[DataMember]
		public PasswordPolicyConfig passwordPolicyConfig
		{
			get
			{
				return this.passwordPolicyConfigField;
			}
			set
			{
				if (!object.ReferenceEquals(this.passwordPolicyConfigField, value))
				{
					this.passwordPolicyConfigField = value;
					base.RaisePropertyChanged("passwordPolicyConfig");
				}
			}
		}

		public GetPasswordPolicyResponse()
		{
		}
	}
}