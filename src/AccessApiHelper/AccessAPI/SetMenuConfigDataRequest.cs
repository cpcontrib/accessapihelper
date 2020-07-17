using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="SetMenuConfigDataRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class SetMenuConfigDataRequest : INotifyPropertyChanged
	{
		private ICollection<DeviceLayoutConfigData> DevicesField;

		private ICollection<ViewMenuConfigData> ViewMenusField;

		[DataMember]
		public ICollection<DeviceLayoutConfigData> Devices
		{
			get
			{
				return this.DevicesField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DevicesField, value))
				{
					this.DevicesField = value;
					this.RaisePropertyChanged("Devices");
				}
			}
		}

		[DataMember]
		public ICollection<ViewMenuConfigData> ViewMenus
		{
			get
			{
				return this.ViewMenusField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ViewMenusField, value))
				{
					this.ViewMenusField = value;
					this.RaisePropertyChanged("ViewMenus");
				}
			}
		}

		public SetMenuConfigDataRequest()
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