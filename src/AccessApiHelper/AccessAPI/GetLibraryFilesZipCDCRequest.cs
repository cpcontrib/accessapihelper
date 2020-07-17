using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetLibraryFilesZipCDCRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetLibraryFilesZipCDCRequest : INotifyPropertyChanged
	{
		private int AssetIdField;

		private GetLibraryFilesCDCInfo InfoField;

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
		public GetLibraryFilesCDCInfo Info
		{
			get
			{
				return this.InfoField;
			}
			set
			{
				if (!object.ReferenceEquals(this.InfoField, value))
				{
					this.InfoField = value;
					this.RaisePropertyChanged("Info");
				}
			}
		}

		public GetLibraryFilesZipCDCRequest()
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