using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="WCOAnalyticsSiteData", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class WCOAnalyticsSiteData : INotifyPropertyChanged
	{
		private string HostNameField;

		private int PackageIdField;

		private string PackageNameField;

		[DataMember]
		public string HostName
		{
			get
			{
				return this.HostNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.HostNameField, value))
				{
					this.HostNameField = value;
					this.RaisePropertyChanged("HostName");
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

		public WCOAnalyticsSiteData()
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