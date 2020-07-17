using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="ReferencedLibrary", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class ReferencedLibrary : INotifyPropertyChanged
	{
		private string LabelField;

		private int LibraryIdField;

		private string VSLabelField;

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

		public ReferencedLibrary()
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