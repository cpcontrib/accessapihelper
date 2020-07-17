using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="SystemSummaryReportData", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class SystemSummaryReportData : INotifyPropertyChanged
	{
		private int CDNMonthlyDistributionField;

		private int ContractedCDNMonthlyDistributionField;

		private int ContractedSitesInProductionField;

		private int ContractedTotalActiveTemplatesField;

		private string ContractedTotalContentDataSizeField;

		private int ContractedTotalFilesField;

		private int ContractedTotalFoldersField;

		private int ContractedTotalGroupsField;

		private int ContractedTotalNumberOfPagesField;

		private int ContractedTotalNumberOfProductionPagesField;

		private int ContractedTotalPublishedFilesField;

		private int ContractedTotalPublishedPagesField;

		private int ContractedTotalPublishedTemplatedFilesField;

		private int ContractedTotalSitesField;

		private string ContractedTotalStorageField;

		private int ContractedTotalTemplatedFilesField;

		private int ContractedTotalUsersField;

		private int ContractedWCOPageViewsField;

		private string LastUpdatedField;

		private ICollection<PublishedPageData> PublishedPagesField;

		private int SitesInProductionField;

		private int TotalActiveTemplatesField;

		private string TotalContentDataSizeField;

		private int TotalFilesField;

		private int TotalFoldersField;

		private int TotalGroupsField;

		private int TotalNumberOfPagesField;

		private int TotalNumberOfProductionPagesField;

		private int TotalPublishedFilesField;

		private int TotalPublishedPagesField;

		private int TotalPublishedTemplatedFilesField;

		private int TotalSitesField;

		private string TotalStorageField;

		private int TotalTemplatedFilesField;

		private int TotalUsersField;

		private int WCOPageViewsField;

		[DataMember]
		public int CDNMonthlyDistribution
		{
			get
			{
				return this.CDNMonthlyDistributionField;
			}
			set
			{
				if (!this.CDNMonthlyDistributionField.Equals(value))
				{
					this.CDNMonthlyDistributionField = value;
					this.RaisePropertyChanged("CDNMonthlyDistribution");
				}
			}
		}

		[DataMember]
		public int ContractedCDNMonthlyDistribution
		{
			get
			{
				return this.ContractedCDNMonthlyDistributionField;
			}
			set
			{
				if (!this.ContractedCDNMonthlyDistributionField.Equals(value))
				{
					this.ContractedCDNMonthlyDistributionField = value;
					this.RaisePropertyChanged("ContractedCDNMonthlyDistribution");
				}
			}
		}

		[DataMember]
		public int ContractedSitesInProduction
		{
			get
			{
				return this.ContractedSitesInProductionField;
			}
			set
			{
				if (!this.ContractedSitesInProductionField.Equals(value))
				{
					this.ContractedSitesInProductionField = value;
					this.RaisePropertyChanged("ContractedSitesInProduction");
				}
			}
		}

		[DataMember]
		public int ContractedTotalActiveTemplates
		{
			get
			{
				return this.ContractedTotalActiveTemplatesField;
			}
			set
			{
				if (!this.ContractedTotalActiveTemplatesField.Equals(value))
				{
					this.ContractedTotalActiveTemplatesField = value;
					this.RaisePropertyChanged("ContractedTotalActiveTemplates");
				}
			}
		}

		[DataMember]
		public string ContractedTotalContentDataSize
		{
			get
			{
				return this.ContractedTotalContentDataSizeField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ContractedTotalContentDataSizeField, value))
				{
					this.ContractedTotalContentDataSizeField = value;
					this.RaisePropertyChanged("ContractedTotalContentDataSize");
				}
			}
		}

		[DataMember]
		public int ContractedTotalFiles
		{
			get
			{
				return this.ContractedTotalFilesField;
			}
			set
			{
				if (!this.ContractedTotalFilesField.Equals(value))
				{
					this.ContractedTotalFilesField = value;
					this.RaisePropertyChanged("ContractedTotalFiles");
				}
			}
		}

		[DataMember]
		public int ContractedTotalFolders
		{
			get
			{
				return this.ContractedTotalFoldersField;
			}
			set
			{
				if (!this.ContractedTotalFoldersField.Equals(value))
				{
					this.ContractedTotalFoldersField = value;
					this.RaisePropertyChanged("ContractedTotalFolders");
				}
			}
		}

		[DataMember]
		public int ContractedTotalGroups
		{
			get
			{
				return this.ContractedTotalGroupsField;
			}
			set
			{
				if (!this.ContractedTotalGroupsField.Equals(value))
				{
					this.ContractedTotalGroupsField = value;
					this.RaisePropertyChanged("ContractedTotalGroups");
				}
			}
		}

		[DataMember]
		public int ContractedTotalNumberOfPages
		{
			get
			{
				return this.ContractedTotalNumberOfPagesField;
			}
			set
			{
				if (!this.ContractedTotalNumberOfPagesField.Equals(value))
				{
					this.ContractedTotalNumberOfPagesField = value;
					this.RaisePropertyChanged("ContractedTotalNumberOfPages");
				}
			}
		}

		[DataMember]
		public int ContractedTotalNumberOfProductionPages
		{
			get
			{
				return this.ContractedTotalNumberOfProductionPagesField;
			}
			set
			{
				if (!this.ContractedTotalNumberOfProductionPagesField.Equals(value))
				{
					this.ContractedTotalNumberOfProductionPagesField = value;
					this.RaisePropertyChanged("ContractedTotalNumberOfProductionPages");
				}
			}
		}

		[DataMember]
		public int ContractedTotalPublishedFiles
		{
			get
			{
				return this.ContractedTotalPublishedFilesField;
			}
			set
			{
				if (!this.ContractedTotalPublishedFilesField.Equals(value))
				{
					this.ContractedTotalPublishedFilesField = value;
					this.RaisePropertyChanged("ContractedTotalPublishedFiles");
				}
			}
		}

		[DataMember]
		public int ContractedTotalPublishedPages
		{
			get
			{
				return this.ContractedTotalPublishedPagesField;
			}
			set
			{
				if (!this.ContractedTotalPublishedPagesField.Equals(value))
				{
					this.ContractedTotalPublishedPagesField = value;
					this.RaisePropertyChanged("ContractedTotalPublishedPages");
				}
			}
		}

		[DataMember]
		public int ContractedTotalPublishedTemplatedFiles
		{
			get
			{
				return this.ContractedTotalPublishedTemplatedFilesField;
			}
			set
			{
				if (!this.ContractedTotalPublishedTemplatedFilesField.Equals(value))
				{
					this.ContractedTotalPublishedTemplatedFilesField = value;
					this.RaisePropertyChanged("ContractedTotalPublishedTemplatedFiles");
				}
			}
		}

		[DataMember]
		public int ContractedTotalSites
		{
			get
			{
				return this.ContractedTotalSitesField;
			}
			set
			{
				if (!this.ContractedTotalSitesField.Equals(value))
				{
					this.ContractedTotalSitesField = value;
					this.RaisePropertyChanged("ContractedTotalSites");
				}
			}
		}

		[DataMember]
		public string ContractedTotalStorage
		{
			get
			{
				return this.ContractedTotalStorageField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ContractedTotalStorageField, value))
				{
					this.ContractedTotalStorageField = value;
					this.RaisePropertyChanged("ContractedTotalStorage");
				}
			}
		}

		[DataMember]
		public int ContractedTotalTemplatedFiles
		{
			get
			{
				return this.ContractedTotalTemplatedFilesField;
			}
			set
			{
				if (!this.ContractedTotalTemplatedFilesField.Equals(value))
				{
					this.ContractedTotalTemplatedFilesField = value;
					this.RaisePropertyChanged("ContractedTotalTemplatedFiles");
				}
			}
		}

		[DataMember]
		public int ContractedTotalUsers
		{
			get
			{
				return this.ContractedTotalUsersField;
			}
			set
			{
				if (!this.ContractedTotalUsersField.Equals(value))
				{
					this.ContractedTotalUsersField = value;
					this.RaisePropertyChanged("ContractedTotalUsers");
				}
			}
		}

		[DataMember]
		public int ContractedWCOPageViews
		{
			get
			{
				return this.ContractedWCOPageViewsField;
			}
			set
			{
				if (!this.ContractedWCOPageViewsField.Equals(value))
				{
					this.ContractedWCOPageViewsField = value;
					this.RaisePropertyChanged("ContractedWCOPageViews");
				}
			}
		}

		[DataMember]
		public string LastUpdated
		{
			get
			{
				return this.LastUpdatedField;
			}
			set
			{
				if (!object.ReferenceEquals(this.LastUpdatedField, value))
				{
					this.LastUpdatedField = value;
					this.RaisePropertyChanged("LastUpdated");
				}
			}
		}

		[DataMember]
		public ICollection<PublishedPageData> PublishedPages
		{
			get
			{
				return this.PublishedPagesField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PublishedPagesField, value))
				{
					this.PublishedPagesField = value;
					this.RaisePropertyChanged("PublishedPages");
				}
			}
		}

		[DataMember]
		public int SitesInProduction
		{
			get
			{
				return this.SitesInProductionField;
			}
			set
			{
				if (!this.SitesInProductionField.Equals(value))
				{
					this.SitesInProductionField = value;
					this.RaisePropertyChanged("SitesInProduction");
				}
			}
		}

		[DataMember]
		public int TotalActiveTemplates
		{
			get
			{
				return this.TotalActiveTemplatesField;
			}
			set
			{
				if (!this.TotalActiveTemplatesField.Equals(value))
				{
					this.TotalActiveTemplatesField = value;
					this.RaisePropertyChanged("TotalActiveTemplates");
				}
			}
		}

		[DataMember]
		public string TotalContentDataSize
		{
			get
			{
				return this.TotalContentDataSizeField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TotalContentDataSizeField, value))
				{
					this.TotalContentDataSizeField = value;
					this.RaisePropertyChanged("TotalContentDataSize");
				}
			}
		}

		[DataMember]
		public int TotalFiles
		{
			get
			{
				return this.TotalFilesField;
			}
			set
			{
				if (!this.TotalFilesField.Equals(value))
				{
					this.TotalFilesField = value;
					this.RaisePropertyChanged("TotalFiles");
				}
			}
		}

		[DataMember]
		public int TotalFolders
		{
			get
			{
				return this.TotalFoldersField;
			}
			set
			{
				if (!this.TotalFoldersField.Equals(value))
				{
					this.TotalFoldersField = value;
					this.RaisePropertyChanged("TotalFolders");
				}
			}
		}

		[DataMember]
		public int TotalGroups
		{
			get
			{
				return this.TotalGroupsField;
			}
			set
			{
				if (!this.TotalGroupsField.Equals(value))
				{
					this.TotalGroupsField = value;
					this.RaisePropertyChanged("TotalGroups");
				}
			}
		}

		[DataMember]
		public int TotalNumberOfPages
		{
			get
			{
				return this.TotalNumberOfPagesField;
			}
			set
			{
				if (!this.TotalNumberOfPagesField.Equals(value))
				{
					this.TotalNumberOfPagesField = value;
					this.RaisePropertyChanged("TotalNumberOfPages");
				}
			}
		}

		[DataMember]
		public int TotalNumberOfProductionPages
		{
			get
			{
				return this.TotalNumberOfProductionPagesField;
			}
			set
			{
				if (!this.TotalNumberOfProductionPagesField.Equals(value))
				{
					this.TotalNumberOfProductionPagesField = value;
					this.RaisePropertyChanged("TotalNumberOfProductionPages");
				}
			}
		}

		[DataMember]
		public int TotalPublishedFiles
		{
			get
			{
				return this.TotalPublishedFilesField;
			}
			set
			{
				if (!this.TotalPublishedFilesField.Equals(value))
				{
					this.TotalPublishedFilesField = value;
					this.RaisePropertyChanged("TotalPublishedFiles");
				}
			}
		}

		[DataMember]
		public int TotalPublishedPages
		{
			get
			{
				return this.TotalPublishedPagesField;
			}
			set
			{
				if (!this.TotalPublishedPagesField.Equals(value))
				{
					this.TotalPublishedPagesField = value;
					this.RaisePropertyChanged("TotalPublishedPages");
				}
			}
		}

		[DataMember]
		public int TotalPublishedTemplatedFiles
		{
			get
			{
				return this.TotalPublishedTemplatedFilesField;
			}
			set
			{
				if (!this.TotalPublishedTemplatedFilesField.Equals(value))
				{
					this.TotalPublishedTemplatedFilesField = value;
					this.RaisePropertyChanged("TotalPublishedTemplatedFiles");
				}
			}
		}

		[DataMember]
		public int TotalSites
		{
			get
			{
				return this.TotalSitesField;
			}
			set
			{
				if (!this.TotalSitesField.Equals(value))
				{
					this.TotalSitesField = value;
					this.RaisePropertyChanged("TotalSites");
				}
			}
		}

		[DataMember]
		public string TotalStorage
		{
			get
			{
				return this.TotalStorageField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TotalStorageField, value))
				{
					this.TotalStorageField = value;
					this.RaisePropertyChanged("TotalStorage");
				}
			}
		}

		[DataMember]
		public int TotalTemplatedFiles
		{
			get
			{
				return this.TotalTemplatedFilesField;
			}
			set
			{
				if (!this.TotalTemplatedFilesField.Equals(value))
				{
					this.TotalTemplatedFilesField = value;
					this.RaisePropertyChanged("TotalTemplatedFiles");
				}
			}
		}

		[DataMember]
		public int TotalUsers
		{
			get
			{
				return this.TotalUsersField;
			}
			set
			{
				if (!this.TotalUsersField.Equals(value))
				{
					this.TotalUsersField = value;
					this.RaisePropertyChanged("TotalUsers");
				}
			}
		}

		[DataMember]
		public int WCOPageViews
		{
			get
			{
				return this.WCOPageViewsField;
			}
			set
			{
				if (!this.WCOPageViewsField.Equals(value))
				{
					this.WCOPageViewsField = value;
					this.RaisePropertyChanged("WCOPageViews");
				}
			}
		}

		public SystemSummaryReportData()
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