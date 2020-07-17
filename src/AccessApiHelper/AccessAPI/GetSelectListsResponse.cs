using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetSelectListsResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetSelectListsResponse : WSResultClass
	{
		private string DefaultProviderField;

		private ICollection<string> DescriptionListField;

		private ICollection<string> ProviderListField;

		private string departmentsField;

		private string locationsField;

		private string titlesField;

		[DataMember]
		public string DefaultProvider
		{
			get
			{
				return this.DefaultProviderField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DefaultProviderField, value))
				{
					this.DefaultProviderField = value;
					base.RaisePropertyChanged("DefaultProvider");
				}
			}
		}

		[DataMember]
		public string departments
		{
			get
			{
				return this.departmentsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.departmentsField, value))
				{
					this.departmentsField = value;
					base.RaisePropertyChanged("departments");
				}
			}
		}

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
		public string locations
		{
			get
			{
				return this.locationsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.locationsField, value))
				{
					this.locationsField = value;
					base.RaisePropertyChanged("locations");
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
		public string titles
		{
			get
			{
				return this.titlesField;
			}
			set
			{
				if (!object.ReferenceEquals(this.titlesField, value))
				{
					this.titlesField = value;
					base.RaisePropertyChanged("titles");
				}
			}
		}

		public GetSelectListsResponse()
		{
		}
	}
}