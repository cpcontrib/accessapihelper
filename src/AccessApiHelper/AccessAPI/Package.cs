using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="Package", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class Package : INotifyPropertyChanged
	{
		private bool IsEnabledField;

		private int PackageIdField;

		private string PackageNameField;

		[DataMember]
		public bool IsEnabled
		{
			get
			{
				return this.IsEnabledField;
			}
			set
			{
				if (!this.IsEnabledField.Equals(value))
				{
					this.IsEnabledField = value;
					this.RaisePropertyChanged("IsEnabled");
				}
			}
		}

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

		[DataMember]
		public string PackageName
		{
			get
			{
				return this.PackageNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PackageNameField, value))
				{
					this.PackageNameField = value;
					this.RaisePropertyChanged("PackageName");
				}
			}
		}

		public Package()
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