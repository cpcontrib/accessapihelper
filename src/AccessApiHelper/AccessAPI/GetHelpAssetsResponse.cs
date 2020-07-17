using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetHelpAssetsResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetHelpAssetsResponse : WSResultClass
	{
		private ICollection<WorklistAsset> assetsField;

		private ICollection<AssetsField> fieldsField;

		private WorklistAsset helpAssetField;

		private bool isFolderField;

		[DataMember]
		public ICollection<WorklistAsset> assets
		{
			get
			{
				return this.assetsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.assetsField, value))
				{
					this.assetsField = value;
					base.RaisePropertyChanged("assets");
				}
			}
		}

		[DataMember]
		public ICollection<AssetsField> fields
		{
			get
			{
				return this.fieldsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.fieldsField, value))
				{
					this.fieldsField = value;
					base.RaisePropertyChanged("fields");
				}
			}
		}

		[DataMember]
		public WorklistAsset helpAsset
		{
			get
			{
				return this.helpAssetField;
			}
			set
			{
				if (!object.ReferenceEquals(this.helpAssetField, value))
				{
					this.helpAssetField = value;
					base.RaisePropertyChanged("helpAsset");
				}
			}
		}

		[DataMember]
		public bool isFolder
		{
			get
			{
				return this.isFolderField;
			}
			set
			{
				if (!this.isFolderField.Equals(value))
				{
					this.isFolderField = value;
					base.RaisePropertyChanged("isFolder");
				}
			}
		}

		public GetHelpAssetsResponse()
		{
		}
	}
}