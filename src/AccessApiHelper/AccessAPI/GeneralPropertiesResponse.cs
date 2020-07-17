using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GeneralPropertiesResponse", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model.UIModel")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GeneralPropertiesResponse : WSResultClass
	{
		private string CmsPathField;

		private ICollection<PackageInfo> CurrentFileNamesField;

		private ICollection<PackageInfo> CurrentUrlsField;

		private int LastPublishedDurationField;

		private ICollection<PackageInfo> LastPublishedFilesField;

		private int LastPublishedSizeField;

		private ICollection<PackageInfo> LastPublishedUrlsField;

		private string TemplateNameField;

		private ICollection<cpListscpKeyValuePair> UIConfigurationField;

		private ICollection<PackageInfo> UploadedMediaField;

		private WorkflowData WorkflowField;

		private int WorkflowAssetIdField;

		private string WorkflowAssetPathField;

		private string WorkflowNameField;

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
		public string CmsPath
		{
			get
			{
				return this.CmsPathField;
			}
			set
			{
				if (!object.ReferenceEquals(this.CmsPathField, value))
				{
					this.CmsPathField = value;
					base.RaisePropertyChanged("CmsPath");
				}
			}
		}

		[DataMember]
		public ICollection<PackageInfo> CurrentFileNames
		{
			get
			{
				return this.CurrentFileNamesField;
			}
			set
			{
				if (!object.ReferenceEquals(this.CurrentFileNamesField, value))
				{
					this.CurrentFileNamesField = value;
					base.RaisePropertyChanged("CurrentFileNames");
				}
			}
		}

		[DataMember]
		public ICollection<PackageInfo> CurrentUrls
		{
			get
			{
				return this.CurrentUrlsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.CurrentUrlsField, value))
				{
					this.CurrentUrlsField = value;
					base.RaisePropertyChanged("CurrentUrls");
				}
			}
		}

		[DataMember]
		public int LastPublishedDuration
		{
			get
			{
				return this.LastPublishedDurationField;
			}
			set
			{
				if (!this.LastPublishedDurationField.Equals(value))
				{
					this.LastPublishedDurationField = value;
					base.RaisePropertyChanged("LastPublishedDuration");
				}
			}
		}

		[DataMember]
		public ICollection<PackageInfo> LastPublishedFiles
		{
			get
			{
				return this.LastPublishedFilesField;
			}
			set
			{
				if (!object.ReferenceEquals(this.LastPublishedFilesField, value))
				{
					this.LastPublishedFilesField = value;
					base.RaisePropertyChanged("LastPublishedFiles");
				}
			}
		}

		[DataMember]
		public int LastPublishedSize
		{
			get
			{
				return this.LastPublishedSizeField;
			}
			set
			{
				if (!this.LastPublishedSizeField.Equals(value))
				{
					this.LastPublishedSizeField = value;
					base.RaisePropertyChanged("LastPublishedSize");
				}
			}
		}

		[DataMember]
		public ICollection<PackageInfo> LastPublishedUrls
		{
			get
			{
				return this.LastPublishedUrlsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.LastPublishedUrlsField, value))
				{
					this.LastPublishedUrlsField = value;
					base.RaisePropertyChanged("LastPublishedUrls");
				}
			}
		}

		[DataMember]
		public string TemplateName
		{
			get
			{
				return this.TemplateNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TemplateNameField, value))
				{
					this.TemplateNameField = value;
					base.RaisePropertyChanged("TemplateName");
				}
			}
		}

		[DataMember]
		public ICollection<cpListscpKeyValuePair> UIConfiguration
		{
			get
			{
				return this.UIConfigurationField;
			}
			set
			{
				if (!object.ReferenceEquals(this.UIConfigurationField, value))
				{
					this.UIConfigurationField = value;
					base.RaisePropertyChanged("UIConfiguration");
				}
			}
		}

		[DataMember]
		public ICollection<PackageInfo> UploadedMedia
		{
			get
			{
				return this.UploadedMediaField;
			}
			set
			{
				if (!object.ReferenceEquals(this.UploadedMediaField, value))
				{
					this.UploadedMediaField = value;
					base.RaisePropertyChanged("UploadedMedia");
				}
			}
		}

		[DataMember]
		public WorkflowData Workflow
		{
			get
			{
				return this.WorkflowField;
			}
			set
			{
				if (!object.ReferenceEquals(this.WorkflowField, value))
				{
					this.WorkflowField = value;
					base.RaisePropertyChanged("Workflow");
				}
			}
		}

		[DataMember]
		public int WorkflowAssetId
		{
			get
			{
				return this.WorkflowAssetIdField;
			}
			set
			{
				if (!this.WorkflowAssetIdField.Equals(value))
				{
					this.WorkflowAssetIdField = value;
					base.RaisePropertyChanged("WorkflowAssetId");
				}
			}
		}

		[DataMember]
		public string WorkflowAssetPath
		{
			get
			{
				return this.WorkflowAssetPathField;
			}
			set
			{
				if (!object.ReferenceEquals(this.WorkflowAssetPathField, value))
				{
					this.WorkflowAssetPathField = value;
					base.RaisePropertyChanged("WorkflowAssetPath");
				}
			}
		}

		[DataMember]
		public string WorkflowName
		{
			get
			{
				return this.WorkflowNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.WorkflowNameField, value))
				{
					this.WorkflowNameField = value;
					base.RaisePropertyChanged("WorkflowName");
				}
			}
		}

		public GeneralPropertiesResponse()
		{
		}
	}
}