using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetTasksResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetTasksResponse : WSResultClass
	{
		private ICollection<WorklistAssetAndFields> tasksField;

		[DataMember]
		public ICollection<WorklistAssetAndFields> tasks
		{
			get
			{
				return this.tasksField;
			}
			set
			{
				if (!object.ReferenceEquals(this.tasksField, value))
				{
					this.tasksField = value;
					base.RaisePropertyChanged("tasks");
				}
			}
		}

		public GetTasksResponse()
		{
		}
	}
}