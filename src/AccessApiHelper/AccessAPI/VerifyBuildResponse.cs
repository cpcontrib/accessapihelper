using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="VerifyBuildResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class VerifyBuildResponse : WSResultClass
	{
		private bool StatusField;

		[DataMember]
		public bool Status
		{
			get
			{
				return this.StatusField;
			}
			set
			{
				if (!this.StatusField.Equals(value))
				{
					this.StatusField = value;
					base.RaisePropertyChanged("Status");
				}
			}
		}

		public VerifyBuildResponse()
		{
		}
	}
}