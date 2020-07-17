using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="CloneAssetResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class CloneAssetResponse : WSResultClass
	{
		private bool IsLongRunningField;

		private int JobIdField;

		[DataMember]
		public bool IsLongRunning
		{
			get
			{
				return this.IsLongRunningField;
			}
			set
			{
				if (!this.IsLongRunningField.Equals(value))
				{
					this.IsLongRunningField = value;
					base.RaisePropertyChanged("IsLongRunning");
				}
			}
		}

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

		public CloneAssetResponse()
		{
		}
	}
}