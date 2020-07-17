using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetActiveStandardsReportResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetActiveStandardsReportResponse : WSResultClass
	{
		private ICollection<WorklistAsset> assetsField;

		private Dictionary<int, ActiveStandardsData> dataField;

		[DataMember]
		public ICollection<WorklistAsset> assets
		{
			get
			{
				return this.assetsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.assetsField, value))
				{
					this.assetsField = value;
					base.RaisePropertyChanged("assets");
				}
			}
		}

		[DataMember]
		public Dictionary<int, ActiveStandardsData> data
		{
			get
			{
				return this.dataField;
			}
			set
			{
				if (!object.ReferenceEquals(this.dataField, value))
				{
					this.dataField = value;
					base.RaisePropertyChanged("data");
				}
			}
		}

		public GetActiveStandardsReportResponse()
		{
		}
	}
}