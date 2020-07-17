using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="AdvancedSearchRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class AdvancedSearchRequest : INotifyPropertyChanged
	{
		private ICollection<AssetPropertyNames> AdditionalBuiltInFieldsField;

		private int BaseAssetIdField;

		private ICollection<FilterExpression> FilterExpressionsField;

		private int? LimitField;

		private AssetObjectType ResponseTypeField;

		private ICollection<SortCriterion> SortOrderField;

		[DataMember]
		public ICollection<AssetPropertyNames> AdditionalBuiltInFields
		{
			get
			{
				return this.AdditionalBuiltInFieldsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AdditionalBuiltInFieldsField, value))
				{
					this.AdditionalBuiltInFieldsField = value;
					this.RaisePropertyChanged("AdditionalBuiltInFields");
				}
			}
		}

		[DataMember]
		public int BaseAssetId
		{
			get
			{
				return this.BaseAssetIdField;
			}
			set
			{
				if (!this.BaseAssetIdField.Equals(value))
				{
					this.BaseAssetIdField = value;
					this.RaisePropertyChanged("BaseAssetId");
				}
			}
		}

		[DataMember]
		public ICollection<FilterExpression> FilterExpressions
		{
			get
			{
				return this.FilterExpressionsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.FilterExpressionsField, value))
				{
					this.FilterExpressionsField = value;
					this.RaisePropertyChanged("FilterExpressions");
				}
			}
		}

		[DataMember]
		public int? Limit
		{
			get
			{
				return this.LimitField;
			}
			set
			{
				if (!this.LimitField.Equals(value))
				{
					this.LimitField = value;
					this.RaisePropertyChanged("Limit");
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

		[DataMember]
		public ICollection<SortCriterion> SortOrder
		{
			get
			{
				return this.SortOrderField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SortOrderField, value))
				{
					this.SortOrderField = value;
					this.RaisePropertyChanged("SortOrder");
				}
			}
		}

		public AdvancedSearchRequest()
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