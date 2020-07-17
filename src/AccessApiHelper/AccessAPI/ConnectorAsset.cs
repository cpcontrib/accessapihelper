using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="ConnectorAsset", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model.UIModel")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class ConnectorAsset : INotifyPropertyChanged
	{
		private int AssetIdField;

		private int AssetSubTypeField;

		private int AssetTypeField;

		private int ConnectorIdField;

		private int ConnectorTypeField;

		private string NameField;

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
		public int AssetSubType
		{
			get
			{
				return this.AssetSubTypeField;
			}
			set
			{
				if (!this.AssetSubTypeField.Equals(value))
				{
					this.AssetSubTypeField = value;
					this.RaisePropertyChanged("AssetSubType");
				}
			}
		}

		[DataMember]
		public int AssetType
		{
			get
			{
				return this.AssetTypeField;
			}
			set
			{
				if (!this.AssetTypeField.Equals(value))
				{
					this.AssetTypeField = value;
					this.RaisePropertyChanged("AssetType");
				}
			}
		}

		[DataMember]
		public int ConnectorId
		{
			get
			{
				return this.ConnectorIdField;
			}
			set
			{
				if (!this.ConnectorIdField.Equals(value))
				{
					this.ConnectorIdField = value;
					this.RaisePropertyChanged("ConnectorId");
				}
			}
		}

		[DataMember]
		public int ConnectorType
		{
			get
			{
				return this.ConnectorTypeField;
			}
			set
			{
				if (!this.ConnectorTypeField.Equals(value))
				{
					this.ConnectorTypeField = value;
					this.RaisePropertyChanged("ConnectorType");
				}
			}
		}

		[DataMember]
		public string Name
		{
			get
			{
				return this.NameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.NameField, value))
				{
					this.NameField = value;
					this.RaisePropertyChanged("Name");
				}
			}
		}

		public ConnectorAsset()
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