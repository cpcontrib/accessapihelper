using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="FinishUploadAvatarRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class FinishUploadAvatarRequest : INotifyPropertyChanged
	{
		private string UploadTicketField;

		private string UsernameField;

		[DataMember]
		public string UploadTicket
		{
			get
			{
				return this.UploadTicketField;
			}
			set
			{
				if (!object.ReferenceEquals(this.UploadTicketField, value))
				{
					this.UploadTicketField = value;
					this.RaisePropertyChanged("UploadTicket");
				}
			}
		}

		[DataMember]
		public string Username
		{
			get
			{
				return this.UsernameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.UsernameField, value))
				{
					this.UsernameField = value;
					this.RaisePropertyChanged("Username");
				}
			}
		}

		public FinishUploadAvatarRequest()
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