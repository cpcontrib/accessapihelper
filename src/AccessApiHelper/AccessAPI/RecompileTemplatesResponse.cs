using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="RecompileTemplatesResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class RecompileTemplatesResponse : WSResultClass
	{
		private ICollection<CpCompilerError> errorsByIdField;

		[DataMember]
		public ICollection<CpCompilerError> errorsById
		{
			get
			{
				return this.errorsByIdField;
			}
			set
			{
				if (!object.ReferenceEquals(this.errorsByIdField, value))
				{
					this.errorsByIdField = value;
					base.RaisePropertyChanged("errorsById");
				}
			}
		}

		public RecompileTemplatesResponse()
		{
		}
	}
}