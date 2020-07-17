using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="LayoutData", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class LayoutData : INotifyPropertyChanged
	{
		private string DisplayNameField;

		private string FileNameField;

		private string IconField;

		[DataMember]
		public string DisplayName
		{
			get
			{
				return this.DisplayNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DisplayNameField, value))
				{
					this.DisplayNameField = value;
					this.RaisePropertyChanged("DisplayName");
				}
			}
		}

		[DataMember]
		public string FileName
		{
			get
			{
				return this.FileNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.FileNameField, value))
				{
					this.FileNameField = value;
					this.RaisePropertyChanged("FileName");
				}
			}
		}

		[DataMember]
		public string Icon
		{
			get
			{
				return this.IconField;
			}
			set
			{
				if (!object.ReferenceEquals(this.IconField, value))
				{
					this.IconField = value;
					this.RaisePropertyChanged("Icon");
				}
			}
		}

		public LayoutData()
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