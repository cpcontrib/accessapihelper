using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetAssetPublishHistoryResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetAssetPublishHistoryResponse : WSResultClass
	{
		private ICollection<AssetPublishAuditData> AuditEntriesField;

		private int TotalField;

		[DataMember]
		public ICollection<AssetPublishAuditData> AuditEntries
		{
			get
			{
				return this.AuditEntriesField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AuditEntriesField, value))
				{
					this.AuditEntriesField = value;
					base.RaisePropertyChanged("AuditEntries");
				}
			}
		}

		[DataMember]
		public int Total
		{
			get
			{
				return this.TotalField;
			}
			set
			{
				if (!this.TotalField.Equals(value))
				{
					this.TotalField = value;
					base.RaisePropertyChanged("Total");
				}
			}
		}

		public GetAssetPublishHistoryResponse()
		{
		}
	}
}