using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="ActiveStandardsCheckpoint", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class ActiveStandardsCheckpoint : INotifyPropertyChanged
	{
		private ActiveStandardsHighlight canHighlightField;

		private string categoryField;

		private string categoryNumberField;

		private string createdField;

		private string descriptionField;

		private string failedField;

		private string idField;

		private string modifiedField;

		private string nameField;

		private string numberField;

		private string priorityField;

		private string referenceField;

		[DataMember]
		public ActiveStandardsHighlight canHighlight
		{
			get
			{
				return this.canHighlightField;
			}
			set
			{
				if (!object.ReferenceEquals(this.canHighlightField, value))
				{
					this.canHighlightField = value;
					this.RaisePropertyChanged("canHighlight");
				}
			}
		}

		[DataMember]
		public string category
		{
			get
			{
				return this.categoryField;
			}
			set
			{
				if (!object.ReferenceEquals(this.categoryField, value))
				{
					this.categoryField = value;
					this.RaisePropertyChanged("category");
				}
			}
		}

		[DataMember]
		public string categoryNumber
		{
			get
			{
				return this.categoryNumberField;
			}
			set
			{
				if (!object.ReferenceEquals(this.categoryNumberField, value))
				{
					this.categoryNumberField = value;
					this.RaisePropertyChanged("categoryNumber");
				}
			}
		}

		[DataMember]
		public string created
		{
			get
			{
				return this.createdField;
			}
			set
			{
				if (!object.ReferenceEquals(this.createdField, value))
				{
					this.createdField = value;
					this.RaisePropertyChanged("created");
				}
			}
		}

		[DataMember]
		public string description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				if (!object.ReferenceEquals(this.descriptionField, value))
				{
					this.descriptionField = value;
					this.RaisePropertyChanged("description");
				}
			}
		}

		[DataMember]
		public string failed
		{
			get
			{
				return this.failedField;
			}
			set
			{
				if (!object.ReferenceEquals(this.failedField, value))
				{
					this.failedField = value;
					this.RaisePropertyChanged("failed");
				}
			}
		}

		[DataMember]
		public string id
		{
			get
			{
				return this.idField;
			}
			set
			{
				if (!object.ReferenceEquals(this.idField, value))
				{
					this.idField = value;
					this.RaisePropertyChanged("id");
				}
			}
		}

		[DataMember]
		public string modified
		{
			get
			{
				return this.modifiedField;
			}
			set
			{
				if (!object.ReferenceEquals(this.modifiedField, value))
				{
					this.modifiedField = value;
					this.RaisePropertyChanged("modified");
				}
			}
		}

		[DataMember]
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.nameField, value))
				{
					this.nameField = value;
					this.RaisePropertyChanged("name");
				}
			}
		}

		[DataMember]
		public string number
		{
			get
			{
				return this.numberField;
			}
			set
			{
				if (!object.ReferenceEquals(this.numberField, value))
				{
					this.numberField = value;
					this.RaisePropertyChanged("number");
				}
			}
		}

		[DataMember]
		public string priority
		{
			get
			{
				return this.priorityField;
			}
			set
			{
				if (!object.ReferenceEquals(this.priorityField, value))
				{
					this.priorityField = value;
					this.RaisePropertyChanged("priority");
				}
			}
		}

		[DataMember]
		public string reference
		{
			get
			{
				return this.referenceField;
			}
			set
			{
				if (!object.ReferenceEquals(this.referenceField, value))
				{
					this.referenceField = value;
					this.RaisePropertyChanged("reference");
				}
			}
		}

		public ActiveStandardsCheckpoint()
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