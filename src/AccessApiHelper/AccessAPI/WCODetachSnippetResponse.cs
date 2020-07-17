using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="WCODetachSnippetResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class WCODetachSnippetResponse : WSResultClass
	{
		private bool WasDetachedFromOmmField;

		[DataMember]
		public bool WasDetachedFromOmm
		{
			get
			{
				return this.WasDetachedFromOmmField;
			}
			set
			{
				if (!this.WasDetachedFromOmmField.Equals(value))
				{
					this.WasDetachedFromOmmField = value;
					base.RaisePropertyChanged("WasDetachedFromOmm");
				}
			}
		}

		public WCODetachSnippetResponse()
		{
		}
	}
}