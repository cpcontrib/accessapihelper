using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="ApprovedHostname", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model.UIModel")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class ApprovedHostname : INotifyPropertyChanged
	{
		private string HostnameField;

		private bool IsDeletedField;

		private bool IsInsertedField;

		private bool IsModifiedField;

		private string MaskField;

		[DataMember]
		public string Hostname
		{
			get
			{
				return this.HostnameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.HostnameField, value))
				{
					this.HostnameField = value;
					this.RaisePropertyChanged("Hostname");
				}
			}
		}

		[DataMember]
		public bool IsDeleted
		{
			get
			{
				return this.IsDeletedField;
			}
			set
			{
				if (!this.IsDeletedField.Equals(value))
				{
					this.IsDeletedField = value;
					this.RaisePropertyChanged("IsDeleted");
				}
			}
		}

		[DataMember]
		public bool IsInserted
		{
			get
			{
				return this.IsInsertedField;
			}
			set
			{
				if (!this.IsInsertedField.Equals(value))
				{
					this.IsInsertedField = value;
					this.RaisePropertyChanged("IsInserted");
				}
			}
		}

		[DataMember]
		public bool IsModified
		{
			get
			{
				return this.IsModifiedField;
			}
			set
			{
				if (!this.IsModifiedField.Equals(value))
				{
					this.IsModifiedField = value;
					this.RaisePropertyChanged("IsModified");
				}
			}
		}

		[DataMember]
		public string Mask
		{
			get
			{
				return this.MaskField;
			}
			set
			{
				if (!object.ReferenceEquals(this.MaskField, value))
				{
					this.MaskField = value;
					this.RaisePropertyChanged("Mask");
				}
			}
		}

		public ApprovedHostname()
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