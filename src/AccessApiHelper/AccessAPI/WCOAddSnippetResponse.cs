using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="WCOAddSnippetResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class WCOAddSnippetResponse : WSResultClass
	{
		private string NewSnippetIdField;

		private string NewVariantIdField;

		private string SuggestedNewNameField;

		[DataMember]
		public string NewSnippetId
		{
			get
			{
				return this.NewSnippetIdField;
			}
			set
			{
				if (!object.ReferenceEquals(this.NewSnippetIdField, value))
				{
					this.NewSnippetIdField = value;
					base.RaisePropertyChanged("NewSnippetId");
				}
			}
		}

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

		[DataMember]
		public string SuggestedNewName
		{
			get
			{
				return this.SuggestedNewNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SuggestedNewNameField, value))
				{
					this.SuggestedNewNameField = value;
					base.RaisePropertyChanged("SuggestedNewName");
				}
			}
		}

		public WCOAddSnippetResponse()
		{
		}
	}
}