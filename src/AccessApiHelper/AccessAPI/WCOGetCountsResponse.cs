using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="WCOGetCountsResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class WCOGetCountsResponse : WSResultClass
	{
		private ICollection<CountStatSummary> CountsField;

		[DataMember]
		public ICollection<CountStatSummary> Counts
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

		public WCOGetCountsResponse()
		{
		}
	}
}