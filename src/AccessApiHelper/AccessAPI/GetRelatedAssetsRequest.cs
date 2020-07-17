using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetRelatedAssetsRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetRelatedAssetsRequest : INotifyPropertyChanged
	{
		private CrownPeak.AccessAPI.ActionType ActionTypeField;

		private int AssetIdField;

		private CrownPeak.AccessAPI.RelatedAssetType RelatedAssetTypeField;

		private AssetObjectType ResponseTypeField;

		[DataMember]
		public CrownPeak.AccessAPI.ActionType ActionType
		{
			get
			{
				return this.ActionTypeField;
			}
			set
			{
				if (!this.ActionTypeField.Equals(value))
				{
					this.ActionTypeField = value;
					this.RaisePropertyChanged("ActionType");
				}
			}
		}

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
		public CrownPeak.AccessAPI.RelatedAssetType RelatedAssetType
		{
			get
			{
				return this.RelatedAssetTypeField;
			}
			set
			{
				if (!this.RelatedAssetTypeField.Equals(value))
				{
					this.RelatedAssetTypeField = value;
					this.RaisePropertyChanged("RelatedAssetType");
				}
			}
		}

		[DataMember]
		public AssetObjectType ResponseType
		{
			get
			{
				return this.ResponseTypeField;
			}
			set
			{
				if (!this.ResponseTypeField.Equals(value))
				{
					this.ResponseTypeField = value;
					this.RaisePropertyChanged("ResponseType");
				}
			}
		}

		public GetRelatedAssetsRequest()
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