using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="LibraryModificationTimes", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class LibraryModificationTimes : INotifyPropertyChanged
	{
		private DateTime LastModifiedField;

		private int LibraryIdField;

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

		public LibraryModificationTimes()
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