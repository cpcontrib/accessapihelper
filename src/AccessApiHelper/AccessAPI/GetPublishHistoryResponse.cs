using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetPublishHistoryResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetPublishHistoryResponse : WSResultClass
	{
		private ICollection<PublishAuditData> AuditEntriesField;

		private int TotalField;

		private Dictionary<int, string> UsersField;

		[DataMember]
		public ICollection<PublishAuditData> AuditEntries
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

		[DataMember]
		public Dictionary<int, string> Users
		{
			get
			{
				return this.UsersField;
			}
			set
			{
				if (!object.ReferenceEquals(this.UsersField, value))
				{
					this.UsersField = value;
					base.RaisePropertyChanged("Users");
				}
			}
		}

		public GetPublishHistoryResponse()
		{
		}
	}
}