using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="PublishingPropertiesResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class PublishingPropertiesResponse : WSResultClass
	{
		private int BasedOnAssetIdField;

		private string BasedOnAssetPathField;

		private string CmsPathField;

		private ICollection<PackageInfo> CurrentFileNamesField;

		private ICollection<PackageInfo> CurrentUrlsField;

		private int DeployIdField;

		private ICollection<DeploymentRecord> DeploymentRecordsField;

		private ICollection<string> LayoutNamesField;

		private ICollection<Package> PackagesField;

		private ICollection<cpListscpKeyValuePair> UIConfigurationField;

		private ICollection<PackageInfo> UploadedMediaField;

		[DataMember]
		public int BasedOnAssetId
		{
			get
			{
				return this.BasedOnAssetIdField;
			}
			set
			{
				if (!this.BasedOnAssetIdField.Equals(value))
				{
					this.BasedOnAssetIdField = value;
					base.RaisePropertyChanged("BasedOnAssetId");
				}
			}
		}

		[DataMember]
		public string BasedOnAssetPath
		{
			get
			{
				return this.BasedOnAssetPathField;
			}
			set
			{
				if (!object.ReferenceEquals(this.BasedOnAssetPathField, value))
				{
					this.BasedOnAssetPathField = value;
					base.RaisePropertyChanged("BasedOnAssetPath");
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
		public int DeployId
		{
			get
			{
				return this.DeployIdField;
			}
			set
			{
				if (!this.DeployIdField.Equals(value))
				{
					this.DeployIdField = value;
					base.RaisePropertyChanged("DeployId");
				}
			}
		}

		[DataMember]
		public ICollection<DeploymentRecord> DeploymentRecords
		{
			get
			{
				return this.DeploymentRecordsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DeploymentRecordsField, value))
				{
					this.DeploymentRecordsField = value;
					base.RaisePropertyChanged("DeploymentRecords");
				}
			}
		}

		[DataMember]
		public ICollection<string> LayoutNames
		{
			get
			{
				return this.LayoutNamesField;
			}
			set
			{
				if (!object.ReferenceEquals(this.LayoutNamesField, value))
				{
					this.LayoutNamesField = value;
					base.RaisePropertyChanged("LayoutNames");
				}
			}
		}

		[DataMember]
		public ICollection<Package> Packages
		{
			get
			{
				return this.PackagesField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PackagesField, value))
				{
					this.PackagesField = value;
					base.RaisePropertyChanged("Packages");
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

		public PublishingPropertiesResponse()
		{
		}
	}
}