using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="ProjectLibrary", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class ProjectLibrary : INotifyPropertyChanged
	{
		private string AssemblyNameField;

		private ICollection<ProjectLibraryFile> FilesField;

		private bool IsLocalLibraryField;

		private string LabelField;

		private DateTime LastModifiedField;

		private int LibraryIdField;

		private string NamespaceField;

		private WorklistAsset ProjectAssetField;

		private ICollection<ReferencedLibrary> ReferencedLibrariesField;

		private string VSLabelField;

		[DataMember]
		public string AssemblyName
		{
			get
			{
				return this.AssemblyNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AssemblyNameField, value))
				{
					this.AssemblyNameField = value;
					this.RaisePropertyChanged("AssemblyName");
				}
			}
		}

		[DataMember]
		public ICollection<ProjectLibraryFile> Files
		{
			get
			{
				return this.FilesField;
			}
			set
			{
				if (!object.ReferenceEquals(this.FilesField, value))
				{
					this.FilesField = value;
					this.RaisePropertyChanged("Files");
				}
			}
		}

		[DataMember]
		public bool IsLocalLibrary
		{
			get
			{
				return this.IsLocalLibraryField;
			}
			set
			{
				if (!this.IsLocalLibraryField.Equals(value))
				{
					this.IsLocalLibraryField = value;
					this.RaisePropertyChanged("IsLocalLibrary");
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
		public DateTime LastModified
		{
			get
			{
				return this.LastModifiedField;
			}
			set
			{
				if (!this.LastModifiedField.Equals(value))
				{
					this.LastModifiedField = value;
					this.RaisePropertyChanged("LastModified");
				}
			}
		}

		[DataMember]
		public int LibraryId
		{
			get
			{
				return this.LibraryIdField;
			}
			set
			{
				if (!this.LibraryIdField.Equals(value))
				{
					this.LibraryIdField = value;
					this.RaisePropertyChanged("LibraryId");
				}
			}
		}

		[DataMember]
		public string Namespace
		{
			get
			{
				return this.NamespaceField;
			}
			set
			{
				if (!object.ReferenceEquals(this.NamespaceField, value))
				{
					this.NamespaceField = value;
					this.RaisePropertyChanged("Namespace");
				}
			}
		}

		[DataMember]
		public WorklistAsset ProjectAsset
		{
			get
			{
				return this.ProjectAssetField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ProjectAssetField, value))
				{
					this.ProjectAssetField = value;
					this.RaisePropertyChanged("ProjectAsset");
				}
			}
		}

		[DataMember]
		public ICollection<ReferencedLibrary> ReferencedLibraries
		{
			get
			{
				return this.ReferencedLibrariesField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ReferencedLibrariesField, value))
				{
					this.ReferencedLibrariesField = value;
					this.RaisePropertyChanged("ReferencedLibraries");
				}
			}
		}

		[DataMember]
		public string VSLabel
		{
			get
			{
				return this.VSLabelField;
			}
			set
			{
				if (!object.ReferenceEquals(this.VSLabelField, value))
				{
					this.VSLabelField = value;
					this.RaisePropertyChanged("VSLabel");
				}
			}
		}

		public ProjectLibrary()
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