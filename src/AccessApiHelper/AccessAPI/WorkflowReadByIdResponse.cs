using System;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract]
	[KnownType(typeof(WorkflowData))]
	public class WorkflowReadByIdResponse : ResultClass
	{
		[DataMember]
		public WorkflowData workflow;

		public WorkflowReadByIdResponse()
		{
		}

		public WorkflowReadByIdResponse(ResultClass result, WorkflowData workflow) : base(result)
		{
			this.workflow = workflow;
		}
	}
}