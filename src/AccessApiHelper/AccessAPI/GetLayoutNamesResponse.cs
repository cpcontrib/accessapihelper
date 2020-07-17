using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetLayoutNamesResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetLayoutNamesResponse : WSResultClass
	{
		private ICollection<string> LayoutNamesField;

		[DataMember]
		public ICollection<string> LayoutNames
		{
			get
			{
				return this.LayoutNamesField;
			}
			set
			{
				if (!object.ReferenceEquals(this.LayoutNamesField, value))
				{
					this.LayoutNamesField = value;
					base.RaisePropertyChanged("LayoutNames");
				}
			}
		}

		public GetLayoutNamesResponse()
		{
		}
	}
}