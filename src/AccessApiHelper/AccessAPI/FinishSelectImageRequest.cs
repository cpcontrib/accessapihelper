using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="FinishSelectImageRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class FinishSelectImageRequest : INotifyPropertyChanged
	{
		private int AssetIdField;

		private string SelectedAssetLinkField;

		private ICollection<Thumbnail> ThumbnailsToCreateField;

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
		public string SelectedAssetLink
		{
			get
			{
				return this.SelectedAssetLinkField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SelectedAssetLinkField, value))
				{
					this.SelectedAssetLinkField = value;
					this.RaisePropertyChanged("SelectedAssetLink");
				}
			}
		}

		[DataMember]
		public ICollection<Thumbnail> ThumbnailsToCreate
		{
			get
			{
				return this.ThumbnailsToCreateField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ThumbnailsToCreateField, value))
				{
					this.ThumbnailsToCreateField = value;
					this.RaisePropertyChanged("ThumbnailsToCreate");
				}
			}
		}

		public FinishSelectImageRequest()
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