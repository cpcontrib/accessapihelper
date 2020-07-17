using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="WCOAddVariantResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class WCOAddVariantResponse : WSResultClass
	{
		private string NewVariantIdField;

		[DataMember]
		public string NewVariantId
		{
			get
			{
				return this.NewVariantIdField;
			}
			set
			{
				if (!object.ReferenceEquals(this.NewVariantIdField, value))
				{
					this.NewVariantIdField = value;
					base.RaisePropertyChanged("NewVariantId");
				}
			}
		}

		public WCOAddVariantResponse()
		{
		}
	}
}