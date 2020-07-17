using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="WCOGetVariantCountsResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class WCOGetVariantCountsResponse : WSResultClass
	{
		private ICollection<WCOGetVariantCount> VariantCountsField;

		[DataMember]
		public ICollection<WCOGetVariantCount> VariantCounts
		{
			get
			{
				return this.VariantCountsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.VariantCountsField, value))
				{
					this.VariantCountsField = value;
					base.RaisePropertyChanged("VariantCounts");
				}
			}
		}

		public WCOGetVariantCountsResponse()
		{
		}
	}
}