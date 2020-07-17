using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="SetRepositoryServerDataRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class SetRepositoryServerDataRequest : INotifyPropertyChanged
	{
		private ICollection<FtpServerData> FtpServersField;

		[DataMember]
		public ICollection<FtpServerData> FtpServers
		{
			get
			{
				return this.FtpServersField;
			}
			set
			{
				if (!object.ReferenceEquals(this.FtpServersField, value))
				{
					this.FtpServersField = value;
					this.RaisePropertyChanged("FtpServers");
				}
			}
		}

		public SetRepositoryServerDataRequest()
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