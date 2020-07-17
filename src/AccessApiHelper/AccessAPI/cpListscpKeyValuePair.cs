using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="cpLists.cpKeyValuePair", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class cpListscpKeyValuePair : INotifyPropertyChanged
	{
		private string keyField;

		private string valueField;

		[DataMember]
		public string key
		{
			get
			{
				return this.keyField;
			}
			set
			{
				if (!object.ReferenceEquals(this.keyField, value))
				{
					this.keyField = value;
					this.RaisePropertyChanged("key");
				}
			}
		}

		[DataMember]
		public string @value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				if (!object.ReferenceEquals(this.valueField, value))
				{
					this.valueField = value;
					this.RaisePropertyChanged("value");
				}
			}
		}

		public cpListscpKeyValuePair()
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