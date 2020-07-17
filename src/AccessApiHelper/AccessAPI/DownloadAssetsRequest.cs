using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="DownloadAssetsRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class DownloadAssetsRequest : INotifyPropertyChanged
	{
		private ICollection<int> AssetListField;

		[DataMember]
		public ICollection<int> AssetList
		{
			get
			{
				return this.AssetListField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AssetListField, value))
				{
					this.AssetListField = value;
					this.RaisePropertyChanged("AssetList");
				}
			}
		}

		public DownloadAssetsRequest()
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