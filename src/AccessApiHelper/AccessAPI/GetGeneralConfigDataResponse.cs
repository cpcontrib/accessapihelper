using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetGeneralConfigDataResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetGeneralConfigDataResponse : WSResultClass
	{
		private GeneralConfigData fieldsField;

		[DataMember]
		public GeneralConfigData fields
		{
			get
			{
				return this.fieldsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.fieldsField, value))
				{
					this.fieldsField = value;
					base.RaisePropertyChanged("fields");
				}
			}
		}

		public GetGeneralConfigDataResponse()
		{
		}
	}
}