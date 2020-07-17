using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="OpenTemplateCDCResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class OpenTemplateCDCResponse : WSResultClass
	{
		private WorklistAsset AssetField;

		private bool IsReadOnlyField;

		private WorklistAsset ParentField;

		private WorklistAsset ProjectAssetField;

		private ICollection<ReferencedLibrary> ReferencedLibrariesField;

		private string TemplateBodyField;

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
		public bool IsReadOnly
		{
			get
			{
				return this.IsReadOnlyField;
			}
			set
			{
				if (!this.IsReadOnlyField.Equals(value))
				{
					this.IsReadOnlyField = value;
					base.RaisePropertyChanged("IsReadOnly");
				}
			}
		}

		[DataMember]
		public WorklistAsset Parent
		{
			get
			{
				return this.ParentField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ParentField, value))
				{
					this.ParentField = value;
					base.RaisePropertyChanged("Parent");
				}
			}
		}

		[DataMember]
		public WorklistAsset ProjectAsset
		{
			get
			{
				return this.ProjectAssetField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ProjectAssetField, value))
				{
					this.ProjectAssetField = value;
					base.RaisePropertyChanged("ProjectAsset");
				}
			}
		}

		[DataMember]
		public ICollection<ReferencedLibrary> ReferencedLibraries
		{
			get
			{
				return this.ReferencedLibrariesField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ReferencedLibrariesField, value))
				{
					this.ReferencedLibrariesField = value;
					base.RaisePropertyChanged("ReferencedLibraries");
				}
			}
		}

		[DataMember]
		public string TemplateBody
		{
			get
			{
				return this.TemplateBodyField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TemplateBodyField, value))
				{
					this.TemplateBodyField = value;
					base.RaisePropertyChanged("TemplateBody");
				}
			}
		}

		public OpenTemplateCDCResponse()
		{
		}
	}
}