using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="CreateFileRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class CreateFileRequest : INotifyPropertyChanged
	{
		private int aclAssetIdField;

		private int destinationFolderIdField;

		private int devTemplateLanguageField;

		private string newNameField;

		private int templateIdField;

		private bool updateAllUsersPreferencesField;

		private int workflowIdField;

		[DataMember]
		public int aclAssetId
		{
			get
			{
				return this.aclAssetIdField;
			}
			set
			{
				if (!this.aclAssetIdField.Equals(value))
				{
					this.aclAssetIdField = value;
					this.RaisePropertyChanged("aclAssetId");
				}
			}
		}

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
		public int devTemplateLanguage
		{
			get
			{
				return this.devTemplateLanguageField;
			}
			set
			{
				if (!this.devTemplateLanguageField.Equals(value))
				{
					this.devTemplateLanguageField = value;
					this.RaisePropertyChanged("devTemplateLanguage");
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

		[DataMember]
		public int templateId
		{
			get
			{
				return this.templateIdField;
			}
			set
			{
				if (!this.templateIdField.Equals(value))
				{
					this.templateIdField = value;
					this.RaisePropertyChanged("templateId");
				}
			}
		}

		[DataMember]
		public bool updateAllUsersPreferences
		{
			get
			{
				return this.updateAllUsersPreferencesField;
			}
			set
			{
				if (!this.updateAllUsersPreferencesField.Equals(value))
				{
					this.updateAllUsersPreferencesField = value;
					this.RaisePropertyChanged("updateAllUsersPreferences");
				}
			}
		}

		[DataMember]
		public int workflowId
		{
			get
			{
				return this.workflowIdField;
			}
			set
			{
				if (!this.workflowIdField.Equals(value))
				{
					this.workflowIdField = value;
					this.RaisePropertyChanged("workflowId");
				}
			}
		}

		public CreateFileRequest()
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