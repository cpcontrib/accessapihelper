using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="cpTimeZoneInfo", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class cpTimeZoneInfo : INotifyPropertyChanged
	{
		private string DisplayNameField;

		private string IdField;

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
		public string Id
		{
			get
			{
				return this.IdField;
			}
			set
			{
				if (!object.ReferenceEquals(this.IdField, value))
				{
					this.IdField = value;
					this.RaisePropertyChanged("Id");
				}
			}
		}

		public cpTimeZoneInfo()
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