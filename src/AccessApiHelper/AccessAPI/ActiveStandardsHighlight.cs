using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="ActiveStandardsHighlight", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class ActiveStandardsHighlight : INotifyPropertyChanged
	{
		private bool pageField;

		private bool sourceField;

		[DataMember]
		public bool page
		{
			get
			{
				return this.pageField;
			}
			set
			{
				if (!this.pageField.Equals(value))
				{
					this.pageField = value;
					this.RaisePropertyChanged("page");
				}
			}
		}

		[DataMember]
		public bool source
		{
			get
			{
				return this.sourceField;
			}
			set
			{
				if (!this.sourceField.Equals(value))
				{
					this.sourceField = value;
					this.RaisePropertyChanged("source");
				}
			}
		}

		public ActiveStandardsHighlight()
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