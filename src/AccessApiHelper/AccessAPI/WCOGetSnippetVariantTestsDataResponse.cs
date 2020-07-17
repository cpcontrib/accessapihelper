using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="WCOGetSnippetVariantTestsDataResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class WCOGetSnippetVariantTestsDataResponse : WSResultClass
	{
		private ICollection<SnippetVariantTestsData> VariantStatsField;

		[DataMember]
		public ICollection<SnippetVariantTestsData> VariantStats
		{
			get
			{
				return this.VariantStatsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.VariantStatsField, value))
				{
					this.VariantStatsField = value;
					base.RaisePropertyChanged("VariantStats");
				}
			}
		}

		public WCOGetSnippetVariantTestsDataResponse()
		{
		}
	}
}