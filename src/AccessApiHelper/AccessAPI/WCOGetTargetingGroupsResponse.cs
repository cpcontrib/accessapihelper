using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="WCOGetTargetingGroupsResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class WCOGetTargetingGroupsResponse : WSResultClass
	{
		private ICollection<TargetGroup> TargetGroupsField;

		[DataMember]
		public ICollection<TargetGroup> TargetGroups
		{
			get
			{
				return this.TargetGroupsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TargetGroupsField, value))
				{
					this.TargetGroupsField = value;
					base.RaisePropertyChanged("TargetGroups");
				}
			}
		}

		public WCOGetTargetingGroupsResponse()
		{
		}
	}
}