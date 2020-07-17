using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="SetOdbcServerDataRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class SetOdbcServerDataRequest : INotifyPropertyChanged
	{
		private ICollection<OdbcServerData> OdbcServersField;

		[DataMember]
		public ICollection<OdbcServerData> OdbcServers
		{
			get
			{
				return this.OdbcServersField;
			}
			set
			{
				if (!object.ReferenceEquals(this.OdbcServersField, value))
				{
					this.OdbcServersField = value;
					this.RaisePropertyChanged("OdbcServers");
				}
			}
		}

		public SetOdbcServerDataRequest()
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