using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetRelatedAssetsResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetRelatedAssetsResponse : WSResultClass
	{
		private ICollection<LightAsset> LightRelatedAssetsField;

		private ICollection<WorklistAsset> RelatedAssetsField;

		[DataMember]
		public ICollection<LightAsset> LightRelatedAssets
		{
			get
			{
				return this.LightRelatedAssetsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.LightRelatedAssetsField, value))
				{
					this.LightRelatedAssetsField = value;
					base.RaisePropertyChanged("LightRelatedAssets");
				}
			}
		}

		[DataMember]
		public ICollection<WorklistAsset> RelatedAssets
		{
			get
			{
				return this.RelatedAssetsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.RelatedAssetsField, value))
				{
					this.RelatedAssetsField = value;
					base.RaisePropertyChanged("RelatedAssets");
				}
			}
		}

		public GetRelatedAssetsResponse()
		{
		}
	}
}