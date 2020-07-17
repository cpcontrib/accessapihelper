using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetChildStatesResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetChildStatesResponse : WSResultClass
	{
		private ICollection<int> ChildStatesField;

		[DataMember]
		public ICollection<int> ChildStates
		{
			get
			{
				return this.ChildStatesField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ChildStatesField, value))
				{
					this.ChildStatesField = value;
					base.RaisePropertyChanged("ChildStates");
				}
			}
		}

		public GetChildStatesResponse()
		{
		}
	}
}