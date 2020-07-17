using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetSystemHistoryResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetSystemHistoryResponse : WSResultClass
	{
		private ICollection<SystemAuditData> AuditEntriesField;

		private int TotalField;

		private Dictionary<int, string> UsersField;

		[DataMember]
		public ICollection<SystemAuditData> AuditEntries
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

		public GetSystemHistoryResponse()
		{
		}
	}
}