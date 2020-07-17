using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetWorkflowsResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetWorkflowsResponse : WSResultClass
	{
		private Dictionary<int, WorkflowData> workflowsField;

		[DataMember]
		public Dictionary<int, WorkflowData> workflows
		{
			get
			{
				return this.workflowsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.workflowsField, value))
				{
					this.workflowsField = value;
					base.RaisePropertyChanged("workflows");
				}
			}
		}

		public GetWorkflowsResponse()
		{
		}
	}
}