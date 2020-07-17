using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="BaseRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[KnownType(typeof(GetAssetListRequest))]
	[KnownType(typeof(GetOutputURLRequest))]
	[KnownType(typeof(GetPerformanceDataRequest))]
	[KnownType(typeof(SetMenuShortcutRequest))]
	[KnownType(typeof(StartFindOrphanReportRequest))]
	public class BaseRequest : INotifyPropertyChanged
	{
		private MenuShortCutData MenuShortcutField;

		[DataMember]
		public MenuShortCutData MenuShortcut
		{
			get
			{
				return this.MenuShortcutField;
			}
			set
			{
				if (!object.ReferenceEquals(this.MenuShortcutField, value))
				{
					this.MenuShortcutField = value;
					this.RaisePropertyChanged("MenuShortcut");
				}
			}
		}

		public BaseRequest()
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