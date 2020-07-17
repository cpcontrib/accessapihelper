using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="CreateSiteRootRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class CreateSiteRootRequest : INotifyPropertyChanged
	{
		private int destinationFolderIdField;

		private int? modelIdField;

		private string newNameField;

		[DataMember]
		public int destinationFolderId
		{
			get
			{
				return this.destinationFolderIdField;
			}
			set
			{
				if (!this.destinationFolderIdField.Equals(value))
				{
					this.destinationFolderIdField = value;
					this.RaisePropertyChanged("destinationFolderId");
				}
			}
		}

		[DataMember]
		public int? modelId
		{
			get
			{
				return this.modelIdField;
			}
			set
			{
				if (!this.modelIdField.Equals(value))
				{
					this.modelIdField = value;
					this.RaisePropertyChanged("modelId");
				}
			}
		}

		[DataMember]
		public string newName
		{
			get
			{
				return this.newNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.newNameField, value))
				{
					this.newNameField = value;
					this.RaisePropertyChanged("newName");
				}
			}
		}

		public CreateSiteRootRequest()
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