using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetAdvancedSearchOptionsResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetAdvancedSearchOptionsResponse : WSResultClass
	{
		private CrownPeak.AccessAPI.SearchFields SearchFieldsField;

		private ICollection<cpKVPOfSearchFieldTypeArrayOfComparisonv_SQRvoIg> TypeToSupportedComparisonField;

		[DataMember]
		public CrownPeak.AccessAPI.SearchFields SearchFields
		{
			get
			{
				return this.SearchFieldsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SearchFieldsField, value))
				{
					this.SearchFieldsField = value;
					base.RaisePropertyChanged("SearchFields");
				}
			}
		}

		[DataMember]
		public ICollection<cpKVPOfSearchFieldTypeArrayOfComparisonv_SQRvoIg> TypeToSupportedComparison
		{
			get
			{
				return this.TypeToSupportedComparisonField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TypeToSupportedComparisonField, value))
				{
					this.TypeToSupportedComparisonField = value;
					base.RaisePropertyChanged("TypeToSupportedComparison");
				}
			}
		}

		public GetAdvancedSearchOptionsResponse()
		{
		}
	}
}