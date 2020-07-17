using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="StatusTransition", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class StatusTransition : INotifyPropertyChanged
	{
		private StatusData FromField;

		private StatusData ToField;

		[DataMember]
		public StatusData From
		{
			get
			{
				return this.FromField;
			}
			set
			{
				if (!object.ReferenceEquals(this.FromField, value))
				{
					this.FromField = value;
					this.RaisePropertyChanged("From");
				}
			}
		}

		[DataMember]
		public StatusData To
		{
			get
			{
				return this.ToField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ToField, value))
				{
					this.ToField = value;
					this.RaisePropertyChanged("To");
				}
			}
		}

		public StatusTransition()
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