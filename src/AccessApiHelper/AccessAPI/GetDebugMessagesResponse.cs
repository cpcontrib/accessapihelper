using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetDebugMessagesResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetDebugMessagesResponse : WSResultClass
	{
		private ICollection<DebugMessage> DebugMessagesField;

		[DataMember]
		public ICollection<DebugMessage> DebugMessages
		{
			get
			{
				return this.DebugMessagesField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DebugMessagesField, value))
				{
					this.DebugMessagesField = value;
					base.RaisePropertyChanged("DebugMessages");
				}
			}
		}

		public GetDebugMessagesResponse()
		{
		}
	}
}