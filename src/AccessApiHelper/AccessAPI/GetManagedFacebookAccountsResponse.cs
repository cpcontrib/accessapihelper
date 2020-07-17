using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetManagedFacebookAccountsResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetManagedFacebookAccountsResponse : WSResultClass
	{
		private ICollection<FacebookInsightsAccount> AccountsField;

		[DataMember]
		public ICollection<FacebookInsightsAccount> Accounts
		{
			get
			{
				return this.AccountsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AccountsField, value))
				{
					this.AccountsField = value;
					base.RaisePropertyChanged("Accounts");
				}
			}
		}

		public GetManagedFacebookAccountsResponse()
		{
		}
	}
}