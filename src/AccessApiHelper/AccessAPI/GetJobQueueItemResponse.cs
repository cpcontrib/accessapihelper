using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetJobQueueItemResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetJobQueueItemResponse : WSResultClass
	{
		private JobItem jobQueueItemField;

		[DataMember]
		public JobItem jobQueueItem
		{
			get
			{
				return this.jobQueueItemField;
			}
			set
			{
				if (!object.ReferenceEquals(this.jobQueueItemField, value))
				{
					this.jobQueueItemField = value;
					base.RaisePropertyChanged("jobQueueItem");
				}
			}
		}

		public GetJobQueueItemResponse()
		{
		}
	}
}