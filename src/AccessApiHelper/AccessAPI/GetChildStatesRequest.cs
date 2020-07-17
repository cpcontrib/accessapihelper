using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetChildStatesRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetChildStatesRequest : INotifyPropertyChanged
	{
		private ICollection<int> AssetIdsField;

		private CrownPeak.AccessAPI.RelatedAssetType RelatedAssetTypeField;

		[DataMember]
		public ICollection<int> AssetIds
		{
			get
			{
				return this.AssetIdsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AssetIdsField, value))
				{
					this.AssetIdsField = value;
					this.RaisePropertyChanged("AssetIds");
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

		public GetChildStatesRequest()
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