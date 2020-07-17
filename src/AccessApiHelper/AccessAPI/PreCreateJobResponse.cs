using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="PreCreateJobResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class PreCreateJobResponse : WSResultClass
	{
		private int JobIdField;

		[DataMember]
		public int JobId
		{
			get
			{
				return this.JobIdField;
			}
			set
			{
				if (!this.JobIdField.Equals(value))
				{
					this.JobIdField = value;
					base.RaisePropertyChanged("JobId");
				}
			}
		}

		public PreCreateJobResponse()
		{
		}
	}
}