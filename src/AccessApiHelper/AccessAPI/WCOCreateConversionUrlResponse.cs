using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="WCOCreateConversionUrlResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class WCOCreateConversionUrlResponse : WSResultClass
	{
		private string ConversionUrlField;

		[DataMember]
		public string ConversionUrl
		{
			get
			{
				return this.ConversionUrlField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ConversionUrlField, value))
				{
					this.ConversionUrlField = value;
					base.RaisePropertyChanged("ConversionUrl");
				}
			}
		}

		public WCOCreateConversionUrlResponse()
		{
		}
	}
}