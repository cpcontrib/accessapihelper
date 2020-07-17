using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="DeploymentRecord", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class DeploymentRecord : INotifyPropertyChanged
	{
		private int DeployIdField;

		private string ExtensionField;

		private string FilenameField;

		private string FilepathField;

		private int IdField;

		private bool IsDeletedField;

		private bool IsEnabledField;

		private string LayoutField;

		private int PackageIdField;

		private DeploymentType TypeField;

		[DataMember]
		public int DeployId
		{
			get
			{
				return this.DeployIdField;
			}
			set
			{
				if (!this.DeployIdField.Equals(value))
				{
					this.DeployIdField = value;
					this.RaisePropertyChanged("DeployId");
				}
			}
		}

		[DataMember]
		public string Extension
		{
			get
			{
				return this.ExtensionField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ExtensionField, value))
				{
					this.ExtensionField = value;
					this.RaisePropertyChanged("Extension");
				}
			}
		}

		[DataMember]
		public string Filename
		{
			get
			{
				return this.FilenameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.FilenameField, value))
				{
					this.FilenameField = value;
					this.RaisePropertyChanged("Filename");
				}
			}
		}

		[DataMember]
		public string Filepath
		{
			get
			{
				return this.FilepathField;
			}
			set
			{
				if (!object.ReferenceEquals(this.FilepathField, value))
				{
					this.FilepathField = value;
					this.RaisePropertyChanged("Filepath");
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
		public bool IsEnabled
		{
			get
			{
				return this.IsEnabledField;
			}
			set
			{
				if (!this.IsEnabledField.Equals(value))
				{
					this.IsEnabledField = value;
					this.RaisePropertyChanged("IsEnabled");
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
		public DeploymentType Type
		{
			get
			{
				return this.TypeField;
			}
			set
			{
				if (!this.TypeField.Equals(value))
				{
					this.TypeField = value;
					this.RaisePropertyChanged("Type");
				}
			}
		}

		public DeploymentRecord()
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