using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="WCOGetStatsCountsResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class WCOGetStatsCountsResponse : WSResultClass
	{
		private Dictionary<CountType, ICollection<CountStatSummary>> CountsField;

		[DataMember]
		public Dictionary<CountType, ICollection<CountStatSummary>> Counts
		{
			get
			{
				return this.CountsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.CountsField, value))
				{
					this.CountsField = value;
					base.RaisePropertyChanged("Counts");
				}
			}
		}

		public WCOGetStatsCountsResponse()
		{
		}
	}
}