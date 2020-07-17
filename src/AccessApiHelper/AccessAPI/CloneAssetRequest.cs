using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="CloneAssetRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class CloneAssetRequest : INotifyPropertyChanged
	{
		private int AssetIdField;

		private bool ClearPublishingPropertiesField;

		private int DestinationFolderIdField;

		private string NewNameField;

		private JobType RequestTypeField;

		private bool SpecialIncludeHiddenAssetsField;

		private ICollection<int> SpecialSelectedStatesField;

		[DataMember]
		public int AssetId
		{
			get
			{
				return this.AssetIdField;
			}
			set
			{
				if (!this.AssetIdField.Equals(value))
				{
					this.AssetIdField = value;
					this.RaisePropertyChanged("AssetId");
				}
			}
		}

		[DataMember]
		public bool ClearPublishingProperties
		{
			get
			{
				return this.ClearPublishingPropertiesField;
			}
			set
			{
				if (!this.ClearPublishingPropertiesField.Equals(value))
				{
					this.ClearPublishingPropertiesField = value;
					this.RaisePropertyChanged("ClearPublishingProperties");
				}
			}
		}

		[DataMember]
		public int DestinationFolderId
		{
			get
			{
				return this.DestinationFolderIdField;
			}
			set
			{
				if (!this.DestinationFolderIdField.Equals(value))
				{
					this.DestinationFolderIdField = value;
					this.RaisePropertyChanged("DestinationFolderId");
				}
			}
		}

		[DataMember]
		public string NewName
		{
			get
			{
				return this.NewNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.NewNameField, value))
				{
					this.NewNameField = value;
					this.RaisePropertyChanged("NewName");
				}
			}
		}

		[DataMember]
		public JobType RequestType
		{
			get
			{
				return this.RequestTypeField;
			}
			set
			{
				if (!this.RequestTypeField.Equals(value))
				{
					this.RequestTypeField = value;
					this.RaisePropertyChanged("RequestType");
				}
			}
		}

		[DataMember]
		public bool SpecialIncludeHiddenAssets
		{
			get
			{
				return this.SpecialIncludeHiddenAssetsField;
			}
			set
			{
				if (!this.SpecialIncludeHiddenAssetsField.Equals(value))
				{
					this.SpecialIncludeHiddenAssetsField = value;
					this.RaisePropertyChanged("SpecialIncludeHiddenAssets");
				}
			}
		}

		[DataMember]
		public ICollection<int> SpecialSelectedStates
		{
			get
			{
				return this.SpecialSelectedStatesField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SpecialSelectedStatesField, value))
				{
					this.SpecialSelectedStatesField = value;
					this.RaisePropertyChanged("SpecialSelectedStates");
				}
			}
		}

		public CloneAssetRequest()
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