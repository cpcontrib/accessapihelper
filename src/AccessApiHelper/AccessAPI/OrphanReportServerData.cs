using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="OrphanReportServerData", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class OrphanReportServerData : INotifyPropertyChanged
	{
		private string ConfiguredHostNameField;

		private int IdField;

		private string NameField;

		private int RepositoryIdField;

		private bool UseAuthField;

		[DataMember]
		public string ConfiguredHostName
		{
			get
			{
				return this.ConfiguredHostNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ConfiguredHostNameField, value))
				{
					this.ConfiguredHostNameField = value;
					this.RaisePropertyChanged("ConfiguredHostName");
				}
			}
		}

		[DataMember]
		public int Id
		{
			get
			{
				return this.IdField;
			}
			set
			{
				if (!this.IdField.Equals(value))
				{
					this.IdField = value;
					this.RaisePropertyChanged("Id");
				}
			}
		}

		[DataMember]
		public string Name
		{
			get
			{
				return this.NameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.NameField, value))
				{
					this.NameField = value;
					this.RaisePropertyChanged("Name");
				}
			}
		}

		[DataMember]
		public int RepositoryId
		{
			get
			{
				return this.RepositoryIdField;
			}
			set
			{
				if (!this.RepositoryIdField.Equals(value))
				{
					this.RepositoryIdField = value;
					this.RaisePropertyChanged("RepositoryId");
				}
			}
		}

		[DataMember]
		public bool UseAuth
		{
			get
			{
				return this.UseAuthField;
			}
			set
			{
				if (!this.UseAuthField.Equals(value))
				{
					this.UseAuthField = value;
					this.RaisePropertyChanged("UseAuth");
				}
			}
		}

		public OrphanReportServerData()
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