using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="UpdateServerMetaConfigRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class UpdateServerMetaConfigRequest : INotifyPropertyChanged
	{
		private CrownPeak.AccessAPI.PublishingServerMetaData PublishingServerMetaDataField;

		[DataMember]
		public CrownPeak.AccessAPI.PublishingServerMetaData PublishingServerMetaData
		{
			get
			{
				return this.PublishingServerMetaDataField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PublishingServerMetaDataField, value))
				{
					this.PublishingServerMetaDataField = value;
					this.RaisePropertyChanged("PublishingServerMetaData");
				}
			}
		}

		public UpdateServerMetaConfigRequest()
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