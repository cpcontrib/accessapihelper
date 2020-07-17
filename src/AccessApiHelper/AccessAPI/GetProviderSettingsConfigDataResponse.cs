using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetProviderSettingsConfigDataResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetProviderSettingsConfigDataResponse : WSResultClass
	{
		private ICollection<string> DescriptionListField;

		private ICollection<string> ProviderListField;

		private CrownPeak.AccessAPI.ProviderSettings ProviderSettingsField;

		[DataMember]
		public ICollection<string> DescriptionList
		{
			get
			{
				return this.DescriptionListField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DescriptionListField, value))
				{
					this.DescriptionListField = value;
					base.RaisePropertyChanged("DescriptionList");
				}
			}
		}

		[DataMember]
		public ICollection<string> ProviderList
		{
			get
			{
				return this.ProviderListField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ProviderListField, value))
				{
					this.ProviderListField = value;
					base.RaisePropertyChanged("ProviderList");
				}
			}
		}

		[DataMember]
		public CrownPeak.AccessAPI.ProviderSettings ProviderSettings
		{
			get
			{
				return this.ProviderSettingsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ProviderSettingsField, value))
				{
					this.ProviderSettingsField = value;
					base.RaisePropertyChanged("ProviderSettings");
				}
			}
		}

		public GetProviderSettingsConfigDataResponse()
		{
		}
	}
}