using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="UnBranchResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class UnBranchResponse : WSResultClass
	{
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

		public UnBranchResponse()
		{
		}
	}
}