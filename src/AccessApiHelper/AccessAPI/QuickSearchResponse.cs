using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="QuickSearchResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class QuickSearchResponse : WSResultClass
	{
		private ICollection<WorklistAsset> AssetsField;

		private ICollection<LightAsset> LightAssetsField;

		[DataMember]
		public ICollection<WorklistAsset> Assets
		{
			get
			{
				return this.AssetsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AssetsField, value))
				{
					this.AssetsField = value;
					base.RaisePropertyChanged("Assets");
				}
			}
		}

		[DataMember]
		public ICollection<LightAsset> LightAssets
		{
			get
			{
				return this.LightAssetsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.LightAssetsField, value))
				{
					this.LightAssetsField = value;
					base.RaisePropertyChanged("LightAssets");
				}
			}
		}

		public QuickSearchResponse()
		{
		}
	}
}