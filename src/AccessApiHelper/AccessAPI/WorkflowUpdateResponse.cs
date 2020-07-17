using System;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract]
	[KnownType(typeof(WorkflowData))]
	public class WorkflowUpdateResponse : ResultClass
	{
		public WorkflowUpdateResponse()
		{
		}

		public WorkflowUpdateResponse(ResultClass result) : base(result)
		{
		}
	}
}