using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="PreCreateJobRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class PreCreateJobRequest : INotifyPropertyChanged
	{
		private int TotalField;

		[DataMember]
		public int Total
		{
			get
			{
				return this.TotalField;
			}
			set
			{
				if (!this.TotalField.Equals(value))
				{
					this.TotalField = value;
					this.RaisePropertyChanged("Total");
				}
			}
		}

		public PreCreateJobRequest()
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