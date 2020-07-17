using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetLibraryFilesCDCInfo", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetLibraryFilesCDCInfo : INotifyPropertyChanged
	{
		private int CurrentLibraryFileIdField;

		private int CurrentLibraryIdField;

		private bool IsCompleteField;

		private ICollection<LibraryModificationTimes> LibraryModificationsField;

		[DataMember]
		public int CurrentLibraryFileId
		{
			get
			{
				return this.CurrentLibraryFileIdField;
			}
			set
			{
				if (!this.CurrentLibraryFileIdField.Equals(value))
				{
					this.CurrentLibraryFileIdField = value;
					this.RaisePropertyChanged("CurrentLibraryFileId");
				}
			}
		}

		[DataMember]
		public int CurrentLibraryId
		{
			get
			{
				return this.CurrentLibraryIdField;
			}
			set
			{
				if (!this.CurrentLibraryIdField.Equals(value))
				{
					this.CurrentLibraryIdField = value;
					this.RaisePropertyChanged("CurrentLibraryId");
				}
			}
		}

		[DataMember]
		public bool IsComplete
		{
			get
			{
				return this.IsCompleteField;
			}
			set
			{
				if (!this.IsCompleteField.Equals(value))
				{
					this.IsCompleteField = value;
					this.RaisePropertyChanged("IsComplete");
				}
			}
		}

		[DataMember]
		public ICollection<LibraryModificationTimes> LibraryModifications
		{
			get
			{
				return this.LibraryModificationsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.LibraryModificationsField, value))
				{
					this.LibraryModificationsField = value;
					this.RaisePropertyChanged("LibraryModifications");
				}
			}
		}

		public GetLibraryFilesCDCInfo()
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