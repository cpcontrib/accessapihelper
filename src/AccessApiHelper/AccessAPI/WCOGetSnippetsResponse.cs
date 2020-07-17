using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="WCOGetSnippetsResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class WCOGetSnippetsResponse : WSResultClass
	{
		private SnippetList ListField;

		[DataMember]
		public SnippetList List
		{
			get
			{
				return this.ListField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ListField, value))
				{
					this.ListField = value;
					base.RaisePropertyChanged("List");
				}
			}
		}

		public WCOGetSnippetsResponse()
		{
		}
	}
}