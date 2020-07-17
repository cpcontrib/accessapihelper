using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="DeletePackageConfigDataRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class DeletePackageConfigDataRequest : INotifyPropertyChanged
	{
		private int PackageIdField;

		[DataMember]
		public int PackageId
		{
			get
			{
				return this.PackageIdField;
			}
			set
			{
				if (!this.PackageIdField.Equals(value))
				{
					this.PackageIdField = value;
					this.RaisePropertyChanged("PackageId");
				}
			}
		}

		public DeletePackageConfigDataRequest()
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