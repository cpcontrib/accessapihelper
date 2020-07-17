using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetSystemVariablesDataResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetSystemVariablesDataResponse : WSResultClass
	{
		private ICollection<SystemVariableData> varsField;

		[DataMember]
		public ICollection<SystemVariableData> vars
		{
			get
			{
				return this.varsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.varsField, value))
				{
					this.varsField = value;
					base.RaisePropertyChanged("vars");
				}
			}
		}

		public GetSystemVariablesDataResponse()
		{
		}
	}
}