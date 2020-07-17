using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetGoogleAnalyticsAccountsResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetGoogleAnalyticsAccountsResponse : WSResultClass
	{
		private string AccessTokenField;

		private ICollection<GoogleAnalyticsAccount> AccountsField;

		private string RefreshTokenField;

		[DataMember]
		public string AccessToken
		{
			get
			{
				return this.AccessTokenField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AccessTokenField, value))
				{
					this.AccessTokenField = value;
					base.RaisePropertyChanged("AccessToken");
				}
			}
		}

		[DataMember]
		public ICollection<GoogleAnalyticsAccount> Accounts
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

		[DataMember]
		public string RefreshToken
		{
			get
			{
				return this.RefreshTokenField;
			}
			set
			{
				if (!object.ReferenceEquals(this.RefreshTokenField, value))
				{
					this.RefreshTokenField = value;
					base.RaisePropertyChanged("RefreshToken");
				}
			}
		}

		public GetGoogleAnalyticsAccountsResponse()
		{
		}
	}
}