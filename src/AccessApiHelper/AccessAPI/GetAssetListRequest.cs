using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetAssetListRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetAssetListRequest : BaseRequest
	{
		private bool AllDirectoriesField;

		private ICollection<int> BranchIdsLoadedField;

		private ICollection<WorklistPreferenceData> ChangedFilterPreferencesField;

		private bool DoNotSaveFilterField;

		private bool IgnoreFilterField;

		private bool IgnoreSortField;

		private bool IsMountField;

		private int assetIdField;

		private string assetPathField;

		private int currentPageField;

		private OrderType orderTypeField;

		private int pageSizeField;

		private string sortColumnField;

		private bool usePathField;

		private VisibilityType visibilityTypeField;

		[DataMember]
		public bool AllDirectories
		{
			get
			{
				return this.AllDirectoriesField;
			}
			set
			{
				if (!this.AllDirectoriesField.Equals(value))
				{
					this.AllDirectoriesField = value;
					base.RaisePropertyChanged("AllDirectories");
				}
			}
		}

		[DataMember]
		public int assetId
		{
			get
			{
				return this.assetIdField;
			}
			set
			{
				if (!this.assetIdField.Equals(value))
				{
					this.assetIdField = value;
					base.RaisePropertyChanged("assetId");
				}
			}
		}

		[DataMember]
		public string assetPath
		{
			get
			{
				return this.assetPathField;
			}
			set
			{
				if (!object.ReferenceEquals(this.assetPathField, value))
				{
					this.assetPathField = value;
					base.RaisePropertyChanged("assetPath");
				}
			}
		}

		[DataMember]
		public ICollection<int> BranchIdsLoaded
		{
			get
			{
				return this.BranchIdsLoadedField;
			}
			set
			{
				if (!object.ReferenceEquals(this.BranchIdsLoadedField, value))
				{
					this.BranchIdsLoadedField = value;
					base.RaisePropertyChanged("BranchIdsLoaded");
				}
			}
		}

		[DataMember]
		public ICollection<WorklistPreferenceData> ChangedFilterPreferences
		{
			get
			{
				return this.ChangedFilterPreferencesField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ChangedFilterPreferencesField, value))
				{
					this.ChangedFilterPreferencesField = value;
					base.RaisePropertyChanged("ChangedFilterPreferences");
				}
			}
		}

		[DataMember]
		public int currentPage
		{
			get
			{
				return this.currentPageField;
			}
			set
			{
				if (!this.currentPageField.Equals(value))
				{
					this.currentPageField = value;
					base.RaisePropertyChanged("currentPage");
				}
			}
		}

		[DataMember]
		public bool DoNotSaveFilter
		{
			get
			{
				return this.DoNotSaveFilterField;
			}
			set
			{
				if (!this.DoNotSaveFilterField.Equals(value))
				{
					this.DoNotSaveFilterField = value;
					base.RaisePropertyChanged("DoNotSaveFilter");
				}
			}
		}

		[DataMember]
		public bool IgnoreFilter
		{
			get
			{
				return this.IgnoreFilterField;
			}
			set
			{
				if (!this.IgnoreFilterField.Equals(value))
				{
					this.IgnoreFilterField = value;
					base.RaisePropertyChanged("IgnoreFilter");
				}
			}
		}

		[DataMember]
		public bool IgnoreSort
		{
			get
			{
				return this.IgnoreSortField;
			}
			set
			{
				if (!this.IgnoreSortField.Equals(value))
				{
					this.IgnoreSortField = value;
					base.RaisePropertyChanged("IgnoreSort");
				}
			}
		}

		[DataMember]
		public bool IsMount
		{
			get
			{
				return this.IsMountField;
			}
			set
			{
				if (!this.IsMountField.Equals(value))
				{
					this.IsMountField = value;
					base.RaisePropertyChanged("IsMount");
				}
			}
		}

		[DataMember]
		public OrderType orderType
		{
			get
			{
				return this.orderTypeField;
			}
			set
			{
				if (!this.orderTypeField.Equals(value))
				{
					this.orderTypeField = value;
					base.RaisePropertyChanged("orderType");
				}
			}
		}

		[DataMember]
		public int pageSize
		{
			get
			{
				return this.pageSizeField;
			}
			set
			{
				if (!this.pageSizeField.Equals(value))
				{
					this.pageSizeField = value;
					base.RaisePropertyChanged("pageSize");
				}
			}
		}

		[DataMember]
		public string sortColumn
		{
			get
			{
				return this.sortColumnField;
			}
			set
			{
				if (!object.ReferenceEquals(this.sortColumnField, value))
				{
					this.sortColumnField = value;
					base.RaisePropertyChanged("sortColumn");
				}
			}
		}

		[DataMember]
		public bool usePath
		{
			get
			{
				return this.usePathField;
			}
			set
			{
				if (!this.usePathField.Equals(value))
				{
					this.usePathField = value;
					base.RaisePropertyChanged("usePath");
				}
			}
		}

		[DataMember]
		public VisibilityType visibilityType
		{
			get
			{
				return this.visibilityTypeField;
			}
			set
			{
				if (!this.visibilityTypeField.Equals(value))
				{
					this.visibilityTypeField = value;
					base.RaisePropertyChanged("visibilityType");
				}
			}
		}

		public GetAssetListRequest()
		{
		}
	}
}