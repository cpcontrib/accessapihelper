using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetLibraryFilesCDCResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetLibraryFilesCDCResponse : WSResultClass
	{
		private GetLibraryFilesCDCInfo InfoField;

		private ICollection<ProjectLibrary> LibrariesField;

		private WorklistAsset ProjectAssetField;

		[DataMember]
		public GetLibraryFilesCDCInfo Info
		{
			get
			{
				return this.InfoField;
			}
			set
			{
				if (!object.ReferenceEquals(this.InfoField, value))
				{
					this.InfoField = value;
					base.RaisePropertyChanged("Info");
				}
			}
		}

		[DataMember]
		public ICollection<ProjectLibrary> Libraries
		{
			get
			{
				return this.LibrariesField;
			}
			set
			{
				if (!object.ReferenceEquals(this.LibrariesField, value))
				{
					this.LibrariesField = value;
					base.RaisePropertyChanged("Libraries");
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
					base.RaisePropertyChanged("ProjectAsset");
				}
			}
		}

		public GetLibraryFilesCDCResponse()
		{
		}
	}
}