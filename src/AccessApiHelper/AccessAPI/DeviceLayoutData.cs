using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="DeviceLayoutData", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model.UIModel")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class DeviceLayoutData : INotifyPropertyChanged
	{
		private int DeviceWidthField;

		private string IconField;

		private string LabelField;

		[DataMember]
		public int DeviceWidth
		{
			get
			{
				return this.DeviceWidthField;
			}
			set
			{
				if (!this.DeviceWidthField.Equals(value))
				{
					this.DeviceWidthField = value;
					this.RaisePropertyChanged("DeviceWidth");
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

		[DataMember]
		public string Label
		{
			get
			{
				return this.LabelField;
			}
			set
			{
				if (!object.ReferenceEquals(this.LabelField, value))
				{
					this.LabelField = value;
					this.RaisePropertyChanged("Label");
				}
			}
		}

		public DeviceLayoutData()
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