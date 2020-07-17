using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="cpKVPOfintstring", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Filters")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class cpKVPOfintstring : INotifyPropertyChanged
	{
		private int KeyField;

		private string ValueField;

		[DataMember]
		public int Key
		{
			get
			{
				return this.KeyField;
			}
			set
			{
				if (!this.KeyField.Equals(value))
				{
					this.KeyField = value;
					this.RaisePropertyChanged("Key");
				}
			}
		}

		[DataMember]
		public string Value
		{
			get
			{
				return this.ValueField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ValueField, value))
				{
					this.ValueField = value;
					this.RaisePropertyChanged("Value");
				}
			}
		}

		public cpKVPOfintstring()
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