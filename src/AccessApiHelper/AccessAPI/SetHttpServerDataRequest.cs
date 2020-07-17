using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="SetHttpServerDataRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class SetHttpServerDataRequest : INotifyPropertyChanged
	{
		private ICollection<HttpServerData> HttpServersField;

		[DataMember]
		public ICollection<HttpServerData> HttpServers
		{
			get
			{
				return this.HttpServersField;
			}
			set
			{
				if (!object.ReferenceEquals(this.HttpServersField, value))
				{
					this.HttpServersField = value;
					this.RaisePropertyChanged("HttpServers");
				}
			}
		}

		public SetHttpServerDataRequest()
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