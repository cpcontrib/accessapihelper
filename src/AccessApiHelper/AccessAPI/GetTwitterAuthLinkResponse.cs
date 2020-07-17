using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetTwitterAuthLinkResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetTwitterAuthLinkResponse : WSResultClass
	{
		private string oauthTokenField;

		private string urlField;

		[DataMember]
		public string oauthToken
		{
			get
			{
				return this.oauthTokenField;
			}
			set
			{
				if (!object.ReferenceEquals(this.oauthTokenField, value))
				{
					this.oauthTokenField = value;
					base.RaisePropertyChanged("oauthToken");
				}
			}
		}

		[DataMember]
		public string url
		{
			get
			{
				return this.urlField;
			}
			set
			{
				if (!object.ReferenceEquals(this.urlField, value))
				{
					this.urlField = value;
					base.RaisePropertyChanged("url");
				}
			}
		}

		public GetTwitterAuthLinkResponse()
		{
		}
	}
}