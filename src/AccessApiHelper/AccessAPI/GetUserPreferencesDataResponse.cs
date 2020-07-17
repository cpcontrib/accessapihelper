using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetUserPreferencesDataResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetUserPreferencesDataResponse : WSResultClass
	{
		private ICollection<string> TimezonesField;

		private CrownPeak.AccessAPI.PreferenceData preferencesField;

		[DataMember]
		public CrownPeak.AccessAPI.PreferenceData preferences
		{
			get
			{
				return this.preferencesField;
			}
			set
			{
				if (!object.ReferenceEquals(this.preferencesField, value))
				{
					this.preferencesField = value;
					base.RaisePropertyChanged("preferences");
				}
			}
		}

		[DataMember]
		public ICollection<string> Timezones
		{
			get
			{
				return this.TimezonesField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TimezonesField, value))
				{
					this.TimezonesField = value;
					base.RaisePropertyChanged("Timezones");
				}
			}
		}

		public GetUserPreferencesDataResponse()
		{
		}
	}
}