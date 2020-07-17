using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="WcoSnippetCloneData", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model.UIModel")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class WcoSnippetCloneData : INotifyPropertyChanged
	{
		private string NewNameField;

		private string OriginalNameField;

		private string OriginalSnippetIdField;

		[DataMember]
		public string NewName
		{
			get
			{
				return this.NewNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.NewNameField, value))
				{
					this.NewNameField = value;
					this.RaisePropertyChanged("NewName");
				}
			}
		}

		[DataMember]
		public string OriginalName
		{
			get
			{
				return this.OriginalNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.OriginalNameField, value))
				{
					this.OriginalNameField = value;
					this.RaisePropertyChanged("OriginalName");
				}
			}
		}

		[DataMember]
		public string OriginalSnippetId
		{
			get
			{
				return this.OriginalSnippetIdField;
			}
			set
			{
				if (!object.ReferenceEquals(this.OriginalSnippetIdField, value))
				{
					this.OriginalSnippetIdField = value;
					this.RaisePropertyChanged("OriginalSnippetId");
				}
			}
		}

		public WcoSnippetCloneData()
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