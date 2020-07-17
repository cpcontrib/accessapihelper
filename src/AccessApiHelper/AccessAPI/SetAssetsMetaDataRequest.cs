using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="SetAssetsMetaDataRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class SetAssetsMetaDataRequest : INotifyPropertyChanged
	{
		private ICollection<SetAssetMetaDataRequest> MetaDataField;

		[DataMember]
		public ICollection<SetAssetMetaDataRequest> MetaData
		{
			get
			{
				return this.MetaDataField;
			}
			set
			{
				if (!object.ReferenceEquals(this.MetaDataField, value))
				{
					this.MetaDataField = value;
					this.RaisePropertyChanged("MetaData");
				}
			}
		}

		public SetAssetsMetaDataRequest()
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