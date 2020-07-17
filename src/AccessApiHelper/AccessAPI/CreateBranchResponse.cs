using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="CreateBranchResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class CreateBranchResponse : WSResultClass
	{
		private ICollection<WcoSnippetCloneData> WcoSnippetsField;

		private WorklistAsset assetField;

		[DataMember]
		public WorklistAsset asset
		{
			get
			{
				return this.assetField;
			}
			set
			{
				if (!object.ReferenceEquals(this.assetField, value))
				{
					this.assetField = value;
					base.RaisePropertyChanged("asset");
				}
			}
		}

		[DataMember]
		public ICollection<WcoSnippetCloneData> WcoSnippets
		{
			get
			{
				return this.WcoSnippetsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.WcoSnippetsField, value))
				{
					this.WcoSnippetsField = value;
					base.RaisePropertyChanged("WcoSnippets");
				}
			}
		}

		public CreateBranchResponse()
		{
		}
	}
}