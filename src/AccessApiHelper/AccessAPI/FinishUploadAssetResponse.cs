using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="FinishUploadAssetResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class FinishUploadAssetResponse : WSResultClass
	{
		private WorklistAsset AssetField;

		private string DisplayUrlField;

		[DataMember]
		public WorklistAsset Asset
		{
			get
			{
				return this.AssetField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AssetField, value))
				{
					this.AssetField = value;
					base.RaisePropertyChanged("Asset");
				}
			}
		}

		[DataMember]
		public string DisplayUrl
		{
			get
			{
				return this.DisplayUrlField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DisplayUrlField, value))
				{
					this.DisplayUrlField = value;
					base.RaisePropertyChanged("DisplayUrl");
				}
			}
		}

		public FinishUploadAssetResponse()
		{
		}
	}
}