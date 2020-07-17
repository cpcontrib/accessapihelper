using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="PublishResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class PublishResponse : WSResultClass
	{
		private int SessionIdField;

		[DataMember]
		public int SessionId
		{
			get
			{
				return this.SessionIdField;
			}
			set
			{
				if (!this.SessionIdField.Equals(value))
				{
					this.SessionIdField = value;
					base.RaisePropertyChanged("SessionId");
				}
			}
		}

		public PublishResponse()
		{
		}
	}
}