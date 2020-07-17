using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="CloneWorkflowResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class CloneWorkflowResponse : WSResultClass
	{
		private int NewWorkflowIdField;

		[DataMember]
		public int NewWorkflowId
		{
			get
			{
				return this.NewWorkflowIdField;
			}
			set
			{
				if (!this.NewWorkflowIdField.Equals(value))
				{
					this.NewWorkflowIdField = value;
					base.RaisePropertyChanged("NewWorkflowId");
				}
			}
		}

		public CloneWorkflowResponse()
		{
		}
	}
}