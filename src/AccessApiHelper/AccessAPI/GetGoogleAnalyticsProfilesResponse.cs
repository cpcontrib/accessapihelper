using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetGoogleAnalyticsProfilesResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetGoogleAnalyticsProfilesResponse : WSResultClass
	{
		private ICollection<GoogleAnalyticsAccount> ProfilesField;

		[DataMember]
		public ICollection<GoogleAnalyticsAccount> Profiles
		{
			get
			{
				return this.ProfilesField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ProfilesField, value))
				{
					this.ProfilesField = value;
					base.RaisePropertyChanged("Profiles");
				}
			}
		}

		public GetGoogleAnalyticsProfilesResponse()
		{
		}
	}
}