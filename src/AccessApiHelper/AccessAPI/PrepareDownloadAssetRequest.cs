using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="PrepareDownloadAssetRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class PrepareDownloadAssetRequest : INotifyPropertyChanged
	{
		private ICollection<int> AssetIdsField;

		private int DestinationIdField;

		private int? ModelIdField;

		private string TokenField;

		private int TotalSizeField;

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
		public int DestinationId
		{
			get
			{
				return this.DestinationIdField;
			}
			set
			{
				if (!this.DestinationIdField.Equals(value))
				{
					this.DestinationIdField = value;
					this.RaisePropertyChanged("DestinationId");
				}
			}
		}

		[DataMember]
		public int? ModelId
		{
			get
			{
				return this.ModelIdField;
			}
			set
			{
				if (!this.ModelIdField.Equals(value))
				{
					this.ModelIdField = value;
					this.RaisePropertyChanged("ModelId");
				}
			}
		}

		[DataMember]
		public string Token
		{
			get
			{
				return this.TokenField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TokenField, value))
				{
					this.TokenField = value;
					this.RaisePropertyChanged("Token");
				}
			}
		}

		[DataMember]
		public int TotalSize
		{
			get
			{
				return this.TotalSizeField;
			}
			set
			{
				if (!this.TotalSizeField.Equals(value))
				{
					this.TotalSizeField = value;
					this.RaisePropertyChanged("TotalSize");
				}
			}
		}

		public PrepareDownloadAssetRequest()
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