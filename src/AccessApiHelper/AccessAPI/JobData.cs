using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="JobData", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class JobData : JobItem
	{
		private ICollection<JobQueue> QueueItemsField;

		private string UsernameField;

		[DataMember]
		public ICollection<JobQueue> QueueItems
		{
			get
			{
				return this.QueueItemsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.QueueItemsField, value))
				{
					this.QueueItemsField = value;
					base.RaisePropertyChanged("QueueItems");
				}
			}
		}

		[DataMember]
		public string Username
		{
			get
			{
				return this.UsernameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.UsernameField, value))
				{
					this.UsernameField = value;
					base.RaisePropertyChanged("Username");
				}
			}
		}

		public JobData()
		{
		}
	}
}