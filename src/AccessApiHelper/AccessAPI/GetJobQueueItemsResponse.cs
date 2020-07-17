using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetJobQueueItemsResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetJobQueueItemsResponse : WSResultClass
	{
		private ICollection<JobItem> jobQueueItemsField;

		[DataMember]
		public ICollection<JobItem> jobQueueItems
		{
			get
			{
				return this.jobQueueItemsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.jobQueueItemsField, value))
				{
					this.jobQueueItemsField = value;
					base.RaisePropertyChanged("jobQueueItems");
				}
			}
		}

		public GetJobQueueItemsResponse()
		{
		}
	}
}