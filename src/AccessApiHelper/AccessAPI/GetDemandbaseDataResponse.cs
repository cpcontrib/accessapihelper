using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetDemandbaseDataResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetDemandbaseDataResponse : WSResultClass
	{
		private ICollection<DemandBaseDataRow> DataField;

		[DataMember]
		public ICollection<DemandBaseDataRow> Data
		{
			get
			{
				return this.DataField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DataField, value))
				{
					this.DataField = value;
					base.RaisePropertyChanged("Data");
				}
			}
		}

		public GetDemandbaseDataResponse()
		{
		}
	}
}