using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="WorklistAssetAndFields", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class WorklistAssetAndFields : INotifyPropertyChanged
	{
		private WorklistAsset AssetField;

		private ICollection<AssetsField> FieldsField;

		[DataMember]
		public WorklistAsset Asset
		{
			get
			{
				return this.AssetField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AssetField, value))
				{
					this.AssetField = value;
					this.RaisePropertyChanged("Asset");
				}
			}
		}

		[DataMember]
		public ICollection<AssetsField> Fields
		{
			get
			{
				return this.FieldsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.FieldsField, value))
				{
					this.FieldsField = value;
					this.RaisePropertyChanged("Fields");
				}
			}
		}

		public WorklistAssetAndFields()
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