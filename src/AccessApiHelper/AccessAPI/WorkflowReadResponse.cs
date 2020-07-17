using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract]
	[KnownType(typeof(WorkflowData))]
	public class WorkflowReadResponse : ResultClass
	{
		[DataMember]
		public Dictionary<int, WorkflowData> workflows;

		public WorkflowReadResponse()
		{
		}

		public WorkflowReadResponse(ResultClass result, Dictionary<int, WorkflowData> workflows) : base(result)
		{
			this.workflows = workflows;
		}
	}
}