using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="WCOGetFormBuilderUrlResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class WCOGetFormBuilderUrlResponse : WSResultClass
	{
		private string UrlField;

		[DataMember]
		public string Url
		{
			get
			{
				return this.UrlField;
			}
			set
			{
				if (!object.ReferenceEquals(this.UrlField, value))
				{
					this.UrlField = value;
					base.RaisePropertyChanged("Url");
				}
			}
		}

		public WCOGetFormBuilderUrlResponse()
		{
		}
	}
}