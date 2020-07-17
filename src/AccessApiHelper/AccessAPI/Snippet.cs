using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="Snippet", Namespace="http://schemas.datacontract.org/2004/07/CrownPeak.Omm.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class Snippet : INotifyPropertyChanged
	{
		private bool ArchivedField;

		private int CMSAssetIdField;

		private DateTime DateCreatedField;

		private bool DeletedField;

		private string EmbedCodeField;

		private Guid IdField;

		private bool IsCMSManagedField;

		private string NameField;

		private Guid OmmIdField;

		private int OrderField;

		private Guid SnippetIdField;

		private SnippetVariantType SnippetVariantField;

		private Guid TargetGroupIdField;

		private int WeightField;

		[DataMember]
		public bool Archived
		{
			get
			{
				return this.ArchivedField;
			}
			set
			{
				if (!this.ArchivedField.Equals(value))
				{
					this.ArchivedField = value;
					this.RaisePropertyChanged("Archived");
				}
			}
		}

		[DataMember]
		public int CMSAssetId
		{
			get
			{
				return this.CMSAssetIdField;
			}
			set
			{
				if (!this.CMSAssetIdField.Equals(value))
				{
					this.CMSAssetIdField = value;
					this.RaisePropertyChanged("CMSAssetId");
				}
			}
		}

		[DataMember]
		public DateTime DateCreated
		{
			get
			{
				return this.DateCreatedField;
			}
			set
			{
				if (!this.DateCreatedField.Equals(value))
				{
					this.DateCreatedField = value;
					this.RaisePropertyChanged("DateCreated");
				}
			}
		}

		[DataMember]
		public bool Deleted
		{
			get
			{
				return this.DeletedField;
			}
			set
			{
				if (!this.DeletedField.Equals(value))
				{
					this.DeletedField = value;
					this.RaisePropertyChanged("Deleted");
				}
			}
		}

		[DataMember]
		public string EmbedCode
		{
			get
			{
				return this.EmbedCodeField;
			}
			set
			{
				if (!object.ReferenceEquals(this.EmbedCodeField, value))
				{
					this.EmbedCodeField = value;
					this.RaisePropertyChanged("EmbedCode");
				}
			}
		}

		[DataMember]
		public Guid Id
		{
			get
			{
				return this.IdField;
			}
			set
			{
				if (!this.IdField.Equals(value))
				{
					this.IdField = value;
					this.RaisePropertyChanged("Id");
				}
			}
		}

		[DataMember]
		public bool IsCMSManaged
		{
			get
			{
				return this.IsCMSManagedField;
			}
			set
			{
				if (!this.IsCMSManagedField.Equals(value))
				{
					this.IsCMSManagedField = value;
					this.RaisePropertyChanged("IsCMSManaged");
				}
			}
		}

		[DataMember]
		public string Name
		{
			get
			{
				return this.NameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.NameField, value))
				{
					this.NameField = value;
					this.RaisePropertyChanged("Name");
				}
			}
		}

		[DataMember]
		public Guid OmmId
		{
			get
			{
				return this.OmmIdField;
			}
			set
			{
				if (!this.OmmIdField.Equals(value))
				{
					this.OmmIdField = value;
					this.RaisePropertyChanged("OmmId");
				}
			}
		}

		[DataMember]
		public int Order
		{
			get
			{
				return this.OrderField;
			}
			set
			{
				if (!this.OrderField.Equals(value))
				{
					this.OrderField = value;
					this.RaisePropertyChanged("Order");
				}
			}
		}

		[DataMember]
		public Guid SnippetId
		{
			get
			{
				return this.SnippetIdField;
			}
			set
			{
				if (!this.SnippetIdField.Equals(value))
				{
					this.SnippetIdField = value;
					this.RaisePropertyChanged("SnippetId");
				}
			}
		}

		[DataMember]
		public SnippetVariantType SnippetVariant
		{
			get
			{
				return this.SnippetVariantField;
			}
			set
			{
				if (!this.SnippetVariantField.Equals(value))
				{
					this.SnippetVariantField = value;
					this.RaisePropertyChanged("SnippetVariant");
				}
			}
		}

		[DataMember]
		public Guid TargetGroupId
		{
			get
			{
				return this.TargetGroupIdField;
			}
			set
			{
				if (!this.TargetGroupIdField.Equals(value))
				{
					this.TargetGroupIdField = value;
					this.RaisePropertyChanged("TargetGroupId");
				}
			}
		}

		[DataMember]
		public int Weight
		{
			get
			{
				return this.WeightField;
			}
			set
			{
				if (!this.WeightField.Equals(value))
				{
					this.WeightField = value;
					this.RaisePropertyChanged("Weight");
				}
			}
		}

		public Snippet()
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