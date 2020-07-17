using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetOrphanReportResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetOrphanReportResponse : WSResultClass
	{
		private ICollection<OrphanAuditData> OrphansField;

		private DateTime? ReportTimestampField;

		private string ReportUserField;

		[DataMember]
		public ICollection<OrphanAuditData> Orphans
		{
			get
			{
				return this.OrphansField;
			}
			set
			{
				if (!object.ReferenceEquals(this.OrphansField, value))
				{
					this.OrphansField = value;
					base.RaisePropertyChanged("Orphans");
				}
			}
		}

		[DataMember]
		public DateTime? ReportTimestamp
		{
			get
			{
				return this.ReportTimestampField;
			}
			set
			{
				if (!this.ReportTimestampField.Equals(value))
				{
					this.ReportTimestampField = value;
					base.RaisePropertyChanged("ReportTimestamp");
				}
			}
		}

		[DataMember]
		public string ReportUser
		{
			get
			{
				return this.ReportUserField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ReportUserField, value))
				{
					this.ReportUserField = value;
					base.RaisePropertyChanged("ReportUser");
				}
			}
		}

		public GetOrphanReportResponse()
		{
		}
	}
}