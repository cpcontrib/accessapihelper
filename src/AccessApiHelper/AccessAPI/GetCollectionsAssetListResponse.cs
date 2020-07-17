using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetCollectionsAssetListResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetCollectionsAssetListResponse : WSResultClass
	{
		private ICollection<LightAssetFieldList> AssetListField;

		[DataMember]
		public ICollection<LightAssetFieldList> AssetList
		{
			get
			{
				return this.AssetListField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AssetListField, value))
				{
					this.AssetListField = value;
					base.RaisePropertyChanged("AssetList");
				}
			}
		}

		public GetCollectionsAssetListResponse()
		{
		}
	}
}