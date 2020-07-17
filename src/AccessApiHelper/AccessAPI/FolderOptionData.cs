using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="FolderOptionData", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class FolderOptionData : INotifyPropertyChanged
	{
		private int AssetIdField;

		private string HeaderField;

		private int LimitField;

		private string OrderByField;

		private OrderType OrderDirectionField;

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
		public string Header
		{
			get
			{
				return this.HeaderField;
			}
			set
			{
				if (!object.ReferenceEquals(this.HeaderField, value))
				{
					this.HeaderField = value;
					this.RaisePropertyChanged("Header");
				}
			}
		}

		[DataMember]
		public int Limit
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
		public string OrderBy
		{
			get
			{
				return this.OrderByField;
			}
			set
			{
				if (!object.ReferenceEquals(this.OrderByField, value))
				{
					this.OrderByField = value;
					this.RaisePropertyChanged("OrderBy");
				}
			}
		}

		[DataMember]
		public OrderType OrderDirection
		{
			get
			{
				return this.OrderDirectionField;
			}
			set
			{
				if (!this.OrderDirectionField.Equals(value))
				{
					this.OrderDirectionField = value;
					this.RaisePropertyChanged("OrderDirection");
				}
			}
		}

		public FolderOptionData()
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