using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="CloneGroupResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class CloneGroupResponse : WSResultClass
	{
		private GroupData newGroupField;

		[DataMember]
		public GroupData newGroup
		{
			get
			{
				return this.newGroupField;
			}
			set
			{
				if (!object.ReferenceEquals(this.newGroupField, value))
				{
					this.newGroupField = value;
					base.RaisePropertyChanged("newGroup");
				}
			}
		}

		public CloneGroupResponse()
		{
		}
	}
}