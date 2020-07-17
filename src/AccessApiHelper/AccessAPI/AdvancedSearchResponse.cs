using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="AdvancedSearchResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class AdvancedSearchResponse : WSResultClass
	{
		private ICollection<LightAsset> LightSearchResultsField;

		private ICollection<WorklistAsset> SearchResultsField;

		[DataMember]
		public ICollection<LightAsset> LightSearchResults
		{
			get
			{
				return this.LightSearchResultsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.LightSearchResultsField, value))
				{
					this.LightSearchResultsField = value;
					base.RaisePropertyChanged("LightSearchResults");
				}
			}
		}

		[DataMember]
		public ICollection<WorklistAsset> SearchResults
		{
			get
			{
				return this.SearchResultsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SearchResultsField, value))
				{
					this.SearchResultsField = value;
					base.RaisePropertyChanged("SearchResults");
				}
			}
		}

		public AdvancedSearchResponse()
		{
		}
	}
}