using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="UpdatePackageConfigDataRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class UpdatePackageConfigDataRequest : INotifyPropertyChanged
	{
		private PublishingServerData PackageField;

		[DataMember]
		public PublishingServerData Package
		{
			get
			{
				return this.PackageField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PackageField, value))
				{
					this.PackageField = value;
					this.RaisePropertyChanged("Package");
				}
			}
		}

		public UpdatePackageConfigDataRequest()
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