using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="Site24x7MonitorData", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class Site24x7MonitorData : INotifyPropertyChanged
	{
		private string monitoridField;

		private string mtypeField;

		private string nameField;

		private string rspvalueField;

		private string statusField;

		[DataMember]
		public string monitorid
		{
			get
			{
				return this.monitoridField;
			}
			set
			{
				if (!object.ReferenceEquals(this.monitoridField, value))
				{
					this.monitoridField = value;
					this.RaisePropertyChanged("monitorid");
				}
			}
		}

		[DataMember]
		public string mtype
		{
			get
			{
				return this.mtypeField;
			}
			set
			{
				if (!object.ReferenceEquals(this.mtypeField, value))
				{
					this.mtypeField = value;
					this.RaisePropertyChanged("mtype");
				}
			}
		}

		[DataMember]
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.nameField, value))
				{
					this.nameField = value;
					this.RaisePropertyChanged("name");
				}
			}
		}

		[DataMember]
		public string rspvalue
		{
			get
			{
				return this.rspvalueField;
			}
			set
			{
				if (!object.ReferenceEquals(this.rspvalueField, value))
				{
					this.rspvalueField = value;
					this.RaisePropertyChanged("rspvalue");
				}
			}
		}

		[DataMember]
		public string status
		{
			get
			{
				return this.statusField;
			}
			set
			{
				if (!object.ReferenceEquals(this.statusField, value))
				{
					this.statusField = value;
					this.RaisePropertyChanged("status");
				}
			}
		}

		public Site24x7MonitorData()
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