using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetLocationsResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetLocationsResponse : WSResultClass
	{
		private string itemsField;

		[DataMember]
		public string items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.itemsField, value))
				{
					this.itemsField = value;
					base.RaisePropertyChanged("items");
				}
			}
		}

		public GetLocationsResponse()
		{
		}
	}
}