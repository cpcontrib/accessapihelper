using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="ProjectLibraryZip", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class ProjectLibraryZip : INotifyPropertyChanged
	{
		private string AssemblyNameField;

		private bool IsLocalLibraryField;

		private string LabelField;

		private Dictionary<string, int> LabelToAssetIdDictField;

		private DateTime LastModifiedField;

		private byte[] LibraryFilesZipField;

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
		public Dictionary<string, int> LabelToAssetIdDict
		{
			get
			{
				return this.LabelToAssetIdDictField;
			}
			set
			{
				if (!object.ReferenceEquals(this.LabelToAssetIdDictField, value))
				{
					this.LabelToAssetIdDictField = value;
					this.RaisePropertyChanged("LabelToAssetIdDict");
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
		public byte[] LibraryFilesZip
		{
			get
			{
				return this.LibraryFilesZipField;
			}
			set
			{
				if (!object.ReferenceEquals(this.LibraryFilesZipField, value))
				{
					this.LibraryFilesZipField = value;
					this.RaisePropertyChanged("LibraryFilesZip");
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

		public ProjectLibraryZip()
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