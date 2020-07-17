using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="SiteRootProperties", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Render")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class SiteRootProperties : INotifyPropertyChanged
	{
		private string DefaultExtensionField;

		private int ProjectIdField;

		private string ProjectPathField;

		[DataMember]
		public string DefaultExtension
		{
			get
			{
				return this.DefaultExtensionField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DefaultExtensionField, value))
				{
					this.DefaultExtensionField = value;
					this.RaisePropertyChanged("DefaultExtension");
				}
			}
		}

		[DataMember]
		public int ProjectId
		{
			get
			{
				return this.ProjectIdField;
			}
			set
			{
				if (!this.ProjectIdField.Equals(value))
				{
					this.ProjectIdField = value;
					this.RaisePropertyChanged("ProjectId");
				}
			}
		}

		[DataMember]
		public string ProjectPath
		{
			get
			{
				return this.ProjectPathField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ProjectPathField, value))
				{
					this.ProjectPathField = value;
					this.RaisePropertyChanged("ProjectPath");
				}
			}
		}

		public SiteRootProperties()
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