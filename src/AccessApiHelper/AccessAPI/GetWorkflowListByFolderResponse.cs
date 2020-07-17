using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetWorkflowListByFolderResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetWorkflowListByFolderResponse : WSResultClass
	{
		private ICollection<WorkflowListItem> WorkflowListField;

		[DataMember]
		public ICollection<WorkflowListItem> WorkflowList
		{
			get
			{
				return this.WorkflowListField;
			}
			set
			{
				if (!object.ReferenceEquals(this.WorkflowListField, value))
				{
					this.WorkflowListField = value;
					base.RaisePropertyChanged("WorkflowList");
				}
			}
		}

		public GetWorkflowListByFolderResponse()
		{
		}
	}
}