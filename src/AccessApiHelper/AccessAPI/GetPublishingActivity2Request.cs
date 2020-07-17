using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetPublishingActivity2Request", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetPublishingActivity2Request : INotifyPropertyChanged
	{
		private int HideBelowSessionIdField;

		private int SessionIdField;

		private cpPublishPublishingActivityDetailRequest SessionIdDetailField;

		[DataMember]
		public int HideBelowSessionId
		{
			get
			{
				return this.HideBelowSessionIdField;
			}
			set
			{
				if (!this.HideBelowSessionIdField.Equals(value))
				{
					this.HideBelowSessionIdField = value;
					this.RaisePropertyChanged("HideBelowSessionId");
				}
			}
		}

		[DataMember]
		public int SessionId
		{
			get
			{
				return this.SessionIdField;
			}
			set
			{
				if (!this.SessionIdField.Equals(value))
				{
					this.SessionIdField = value;
					this.RaisePropertyChanged("SessionId");
				}
			}
		}

		[DataMember]
		public cpPublishPublishingActivityDetailRequest SessionIdDetail
		{
			get
			{
				return this.SessionIdDetailField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SessionIdDetailField, value))
				{
					this.SessionIdDetailField = value;
					this.RaisePropertyChanged("SessionIdDetail");
				}
			}
		}

		public GetPublishingActivity2Request()
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