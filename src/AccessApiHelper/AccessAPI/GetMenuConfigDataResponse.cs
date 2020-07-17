using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetMenuConfigDataResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetMenuConfigDataResponse : WSResultClass
	{
		private ICollection<DeviceLayoutConfigData> defaultDevicesField;

		private ICollection<string> deviceIconsField;

		private ICollection<DeviceLayoutConfigData> devicesField;

		private ICollection<string> layoutIconsField;

		private ICollection<string> templatesField;

		private ICollection<ViewMenuConfigData> viewMenusField;

		[DataMember]
		public ICollection<DeviceLayoutConfigData> defaultDevices
		{
			get
			{
				return this.defaultDevicesField;
			}
			set
			{
				if (!object.ReferenceEquals(this.defaultDevicesField, value))
				{
					this.defaultDevicesField = value;
					base.RaisePropertyChanged("defaultDevices");
				}
			}
		}

		[DataMember]
		public ICollection<string> deviceIcons
		{
			get
			{
				return this.deviceIconsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.deviceIconsField, value))
				{
					this.deviceIconsField = value;
					base.RaisePropertyChanged("deviceIcons");
				}
			}
		}

		[DataMember]
		public ICollection<DeviceLayoutConfigData> devices
		{
			get
			{
				return this.devicesField;
			}
			set
			{
				if (!object.ReferenceEquals(this.devicesField, value))
				{
					this.devicesField = value;
					base.RaisePropertyChanged("devices");
				}
			}
		}

		[DataMember]
		public ICollection<string> layoutIcons
		{
			get
			{
				return this.layoutIconsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.layoutIconsField, value))
				{
					this.layoutIconsField = value;
					base.RaisePropertyChanged("layoutIcons");
				}
			}
		}

		[DataMember]
		public ICollection<string> templates
		{
			get
			{
				return this.templatesField;
			}
			set
			{
				if (!object.ReferenceEquals(this.templatesField, value))
				{
					this.templatesField = value;
					base.RaisePropertyChanged("templates");
				}
			}
		}

		[DataMember]
		public ICollection<ViewMenuConfigData> viewMenus
		{
			get
			{
				return this.viewMenusField;
			}
			set
			{
				if (!object.ReferenceEquals(this.viewMenusField, value))
				{
					this.viewMenusField = value;
					base.RaisePropertyChanged("viewMenus");
				}
			}
		}

		public GetMenuConfigDataResponse()
		{
		}
	}
}