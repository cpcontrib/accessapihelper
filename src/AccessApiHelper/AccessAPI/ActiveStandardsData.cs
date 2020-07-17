using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="ActiveStandardsData", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class ActiveStandardsData : INotifyPropertyChanged
	{
		private string failField;

		private string modifiedField;

		private string passField;

		[DataMember]
		public string fail
		{
			get
			{
				return this.failField;
			}
			set
			{
				if (!object.ReferenceEquals(this.failField, value))
				{
					this.failField = value;
					this.RaisePropertyChanged("fail");
				}
			}
		}

		[DataMember]
		public string modified
		{
			get
			{
				return this.modifiedField;
			}
			set
			{
				if (!object.ReferenceEquals(this.modifiedField, value))
				{
					this.modifiedField = value;
					this.RaisePropertyChanged("modified");
				}
			}
		}

		[DataMember]
		public string pass
		{
			get
			{
				return this.passField;
			}
			set
			{
				if (!object.ReferenceEquals(this.passField, value))
				{
					this.passField = value;
					this.RaisePropertyChanged("pass");
				}
			}
		}

		public ActiveStandardsData()
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