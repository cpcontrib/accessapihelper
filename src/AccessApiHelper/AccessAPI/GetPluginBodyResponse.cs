using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetPluginBodyResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetPluginBodyResponse : WSResultClass
	{
		private string bodyField;

		[DataMember]
		public string body
		{
			get
			{
				return this.bodyField;
			}
			set
			{
				if (!object.ReferenceEquals(this.bodyField, value))
				{
					this.bodyField = value;
					base.RaisePropertyChanged("body");
				}
			}
		}

		public GetPluginBodyResponse()
		{
		}
	}
}