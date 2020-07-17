using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetGroupsDataResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetGroupsDataResponse : WSResultClass
	{
		private ICollection<GroupData> groupsField;

		[DataMember]
		public ICollection<GroupData> groups
		{
			get
			{
				return this.groupsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.groupsField, value))
				{
					this.groupsField = value;
					base.RaisePropertyChanged("groups");
				}
			}
		}

		public GetGroupsDataResponse()
		{
		}
	}
}