using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="CpSnippet", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.App")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class CpSnippet : INotifyPropertyChanged
	{
		private bool ArchivedField;

		private ICollection<SnippetInfo> CmsSnippetInfoField;

		private bool DeletedField;

		private string EmbedCodeField;

		private string IdField;

		private bool IsCMSManagedField;

		private string NameField;

		private string OmmIdField;

		private string SnippetIdField;

		private int SnippetVariantField;

		private string TargetGroupIdField;

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
		public ICollection<SnippetInfo> CmsSnippetInfo
		{
			get
			{
				return this.CmsSnippetInfoField;
			}
			set
			{
				if (!object.ReferenceEquals(this.CmsSnippetInfoField, value))
				{
					this.CmsSnippetInfoField = value;
					this.RaisePropertyChanged("CmsSnippetInfo");
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
		public string Id
		{
			get
			{
				return this.IdField;
			}
			set
			{
				if (!object.ReferenceEquals(this.IdField, value))
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
		public string OmmId
		{
			get
			{
				return this.OmmIdField;
			}
			set
			{
				if (!object.ReferenceEquals(this.OmmIdField, value))
				{
					this.OmmIdField = value;
					this.RaisePropertyChanged("OmmId");
				}
			}
		}

		[DataMember]
		public string SnippetId
		{
			get
			{
				return this.SnippetIdField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SnippetIdField, value))
				{
					this.SnippetIdField = value;
					this.RaisePropertyChanged("SnippetId");
				}
			}
		}

		[DataMember]
		public int SnippetVariant
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
		public string TargetGroupId
		{
			get
			{
				return this.TargetGroupIdField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TargetGroupIdField, value))
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

		public CpSnippet()
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