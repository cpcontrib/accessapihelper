using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="CloneCustomCSharpAssetRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class CloneCustomCSharpAssetRequest : INotifyPropertyChanged
	{
		private int AssetIdField;

		private bool ClearPublishingPropertiesField;

		private int DestinationFolderIdField;

		private string NewNameField;

		private JobType RequestTypeField;

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

		public CloneCustomCSharpAssetRequest()
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