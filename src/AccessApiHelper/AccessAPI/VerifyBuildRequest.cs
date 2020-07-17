using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="VerifyBuildRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class VerifyBuildRequest : INotifyPropertyChanged
	{
		private string BuildVersionField;

		[DataMember]
		public string BuildVersion
		{
			get
			{
				return this.BuildVersionField;
			}
			set
			{
				if (!object.ReferenceEquals(this.BuildVersionField, value))
				{
					this.BuildVersionField = value;
					this.RaisePropertyChanged("BuildVersion");
				}
			}
		}

		public VerifyBuildRequest()
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