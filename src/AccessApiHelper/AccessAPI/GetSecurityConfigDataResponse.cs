using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetSecurityConfigDataResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetSecurityConfigDataResponse : WSResultClass
	{
		private SecurityConfigData dataField;

		[DataMember]
		public SecurityConfigData data
		{
			get
			{
				return this.dataField;
			}
			set
			{
				if (!object.ReferenceEquals(this.dataField, value))
				{
					this.dataField = value;
					base.RaisePropertyChanged("data");
				}
			}
		}

		public GetSecurityConfigDataResponse()
		{
		}
	}
}