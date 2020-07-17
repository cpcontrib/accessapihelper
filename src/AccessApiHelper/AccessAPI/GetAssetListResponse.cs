using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetAssetListResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetAssetListResponse : WSResultClass
	{
		private ICollection<WorklistAsset> assetsField;

		private int deletedCountField;

		private int folderCountField;

		private CrownPeak.AccessAPI.FolderOptionData folderOptionField;

		private int hiddenCountField;

		private int normalCountField;

		private VisibilityType visibilityTypeField;

		private ICollection<WorklistPreferenceData> worklistPreferenceField;

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
		public int deletedCount
		{
			get
			{
				return this.deletedCountField;
			}
			set
			{
				if (!this.deletedCountField.Equals(value))
				{
					this.deletedCountField = value;
					base.RaisePropertyChanged("deletedCount");
				}
			}
		}

		[DataMember]
		public int folderCount
		{
			get
			{
				return this.folderCountField;
			}
			set
			{
				if (!this.folderCountField.Equals(value))
				{
					this.folderCountField = value;
					base.RaisePropertyChanged("folderCount");
				}
			}
		}

		[DataMember]
		public CrownPeak.AccessAPI.FolderOptionData folderOption
		{
			get
			{
				return this.folderOptionField;
			}
			set
			{
				if (!object.ReferenceEquals(this.folderOptionField, value))
				{
					this.folderOptionField = value;
					base.RaisePropertyChanged("folderOption");
				}
			}
		}

		[DataMember]
		public int hiddenCount
		{
			get
			{
				return this.hiddenCountField;
			}
			set
			{
				if (!this.hiddenCountField.Equals(value))
				{
					this.hiddenCountField = value;
					base.RaisePropertyChanged("hiddenCount");
				}
			}
		}

		[DataMember]
		public int normalCount
		{
			get
			{
				return this.normalCountField;
			}
			set
			{
				if (!this.normalCountField.Equals(value))
				{
					this.normalCountField = value;
					base.RaisePropertyChanged("normalCount");
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

		[DataMember]
		public ICollection<WorklistPreferenceData> worklistPreference
		{
			get
			{
				return this.worklistPreferenceField;
			}
			set
			{
				if (!object.ReferenceEquals(this.worklistPreferenceField, value))
				{
					this.worklistPreferenceField = value;
					base.RaisePropertyChanged("worklistPreference");
				}
			}
		}

		public GetAssetListResponse()
		{
		}
	}
}