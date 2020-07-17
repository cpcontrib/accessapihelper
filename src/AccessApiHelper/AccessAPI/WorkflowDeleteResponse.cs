using System;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract]
	[KnownType(typeof(WorkflowData))]
	public class WorkflowDeleteResponse : ResultClass
	{
		public WorkflowDeleteResponse()
		{
		}

		public WorkflowDeleteResponse(ResultClass result) : base(result)
		{
		}
	}
}