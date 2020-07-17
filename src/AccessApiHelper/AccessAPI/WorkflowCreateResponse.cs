using System;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract]
	[KnownType(typeof(WorkflowData))]
	public class WorkflowCreateResponse : ResultClass
	{
		public WorkflowCreateResponse()
		{
		}

		public WorkflowCreateResponse(ResultClass result) : base(result)
		{
		}
	}
}