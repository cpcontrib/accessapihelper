using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="PublishingServerMetaData", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class PublishingServerMetaData : INotifyPropertyChanged
	{
		private byte FedAuthEnabledField;

		private string HostNameField;

		private int IdField;

		private bool IgnoreRosterField;

		private bool IsHostNameModifiedField;

		private bool IsLocalInstallField;

		private bool IsModifiedField;

		private int MetaAssetIdField;

		private string NameField;

		private int SiteFolderIdField;

		private string SiteFolderPathField;

		private string SiteProfileNameField;

		[DataMember]
		public byte FedAuthEnabled
		{
			get
			{
				return this.FedAuthEnabledField;
			}
			set
			{
				if (!this.FedAuthEnabledField.Equals(value))
				{
					this.FedAuthEnabledField = value;
					this.RaisePropertyChanged("FedAuthEnabled");
				}
			}
		}

		[DataMember]
		public string HostName
		{
			get
			{
				return this.HostNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.HostNameField, value))
				{
					this.HostNameField = value;
					this.RaisePropertyChanged("HostName");
				}
			}
		}

		[DataMember]
		public int Id
		{
			get
			{
				return this.IdField;
			}
			set
			{
				if (!this.IdField.Equals(value))
				{
					this.IdField = value;
					this.RaisePropertyChanged("Id");
				}
			}
		}

		[DataMember]
		public bool IgnoreRoster
		{
			get
			{
				return this.IgnoreRosterField;
			}
			set
			{
				if (!this.IgnoreRosterField.Equals(value))
				{
					this.IgnoreRosterField = value;
					this.RaisePropertyChanged("IgnoreRoster");
				}
			}
		}

		[DataMember]
		public bool IsHostNameModified
		{
			get
			{
				return this.IsHostNameModifiedField;
			}
			set
			{
				if (!this.IsHostNameModifiedField.Equals(value))
				{
					this.IsHostNameModifiedField = value;
					this.RaisePropertyChanged("IsHostNameModified");
				}
			}
		}

		[DataMember]
		public bool IsLocalInstall
		{
			get
			{
				return this.IsLocalInstallField;
			}
			set
			{
				if (!this.IsLocalInstallField.Equals(value))
				{
					this.IsLocalInstallField = value;
					this.RaisePropertyChanged("IsLocalInstall");
				}
			}
		}

		[DataMember]
		public bool IsModified
		{
			get
			{
				return this.IsModifiedField;
			}
			set
			{
				if (!this.IsModifiedField.Equals(value))
				{
					this.IsModifiedField = value;
					this.RaisePropertyChanged("IsModified");
				}
			}
		}

		[DataMember]
		public int MetaAssetId
		{
			get
			{
				return this.MetaAssetIdField;
			}
			set
			{
				if (!this.MetaAssetIdField.Equals(value))
				{
					this.MetaAssetIdField = value;
					this.RaisePropertyChanged("MetaAssetId");
				}
			}
		}

		[DataMember]
		public string Name
		{
			get
			{
				return this.NameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.NameField, value))
				{
					this.NameField = value;
					this.RaisePropertyChanged("Name");
				}
			}
		}

		[DataMember]
		public int SiteFolderId
		{
			get
			{
				return this.SiteFolderIdField;
			}
			set
			{
				if (!this.SiteFolderIdField.Equals(value))
				{
					this.SiteFolderIdField = value;
					this.RaisePropertyChanged("SiteFolderId");
				}
			}
		}

		[DataMember]
		public string SiteFolderPath
		{
			get
			{
				return this.SiteFolderPathField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SiteFolderPathField, value))
				{
					this.SiteFolderPathField = value;
					this.RaisePropertyChanged("SiteFolderPath");
				}
			}
		}

		[DataMember]
		public string SiteProfileName
		{
			get
			{
				return this.SiteProfileNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SiteProfileNameField, value))
				{
					this.SiteProfileNameField = value;
					this.RaisePropertyChanged("SiteProfileName");
				}
			}
		}

		public PublishingServerMetaData()
		{
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;
	}
}