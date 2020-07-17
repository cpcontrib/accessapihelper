using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetJobActivityRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetJobActivityRequest : INotifyPropertyChanged
	{
		private int HideBelowJobIdField;

		[DataMember]
		public int HideBelowJobId
		{
			get
			{
				return this.HideBelowJobIdField;
			}
			set
			{
				if (!this.HideBelowJobIdField.Equals(value))
				{
					this.HideBelowJobIdField = value;
					this.RaisePropertyChanged("HideBelowJobId");
				}
			}
		}

		public GetJobActivityRequest()
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