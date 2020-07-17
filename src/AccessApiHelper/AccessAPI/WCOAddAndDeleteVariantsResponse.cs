using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="WCOAddAndDeleteVariantsResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class WCOAddAndDeleteVariantsResponse : WSResultClass
	{
		private ICollection<string> DeletedVariantIdsField;

		private Dictionary<string, string> SnippetIdsField;

		private Dictionary<string, Dictionary<string, string>> VariantIdsField;

		[DataMember]
		public ICollection<string> DeletedVariantIds
		{
			get
			{
				return this.DeletedVariantIdsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DeletedVariantIdsField, value))
				{
					this.DeletedVariantIdsField = value;
					base.RaisePropertyChanged("DeletedVariantIds");
				}
			}
		}

		[DataMember]
		public Dictionary<string, string> SnippetIds
		{
			get
			{
				return this.SnippetIdsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SnippetIdsField, value))
				{
					this.SnippetIdsField = value;
					base.RaisePropertyChanged("SnippetIds");
				}
			}
		}

		[DataMember]
		public Dictionary<string, Dictionary<string, string>> VariantIds
		{
			get
			{
				return this.VariantIdsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.VariantIdsField, value))
				{
					this.VariantIdsField = value;
					base.RaisePropertyChanged("VariantIds");
				}
			}
		}

		public WCOAddAndDeleteVariantsResponse()
		{
		}
	}
}