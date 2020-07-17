using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="ViewMenuConfigData", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model.UIModel")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class ViewMenuConfigData : INotifyPropertyChanged
	{
		private string IconField;

		private int IdField;

		private bool IsDeletedField;

		private bool IsModifiedField;

		private bool IsNewField;

		private string LabelField;

		private string LayoutField;

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
		public bool IsNew
		{
			get
			{
				return this.IsNewField;
			}
			set
			{
				if (!this.IsNewField.Equals(value))
				{
					this.IsNewField = value;
					this.RaisePropertyChanged("IsNew");
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

		[DataMember]
		public string Layout
		{
			get
			{
				return this.LayoutField;
			}
			set
			{
				if (!object.ReferenceEquals(this.LayoutField, value))
				{
					this.LayoutField = value;
					this.RaisePropertyChanged("Layout");
				}
			}
		}

		public ViewMenuConfigData()
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