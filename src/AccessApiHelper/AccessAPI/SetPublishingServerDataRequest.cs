using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="SetPublishingServerDataRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class SetPublishingServerDataRequest : INotifyPropertyChanged
	{
		private ICollection<PublishingServerData> PublishingServersField;

		[DataMember]
		public ICollection<PublishingServerData> PublishingServers
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

		public SetPublishingServerDataRequest()
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