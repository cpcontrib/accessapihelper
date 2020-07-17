using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="SetPublishingServerMetaDataRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class SetPublishingServerMetaDataRequest : INotifyPropertyChanged
	{
		private ICollection<PublishingServerMetaData> PublishingServersField;

		[DataMember]
		public ICollection<PublishingServerMetaData> PublishingServers
		{
			get
			{
				return this.PublishingServersField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PublishingServersField, value))
				{
					this.PublishingServersField = value;
					this.RaisePropertyChanged("PublishingServers");
				}
			}
		}

		public SetPublishingServerMetaDataRequest()
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