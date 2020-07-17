using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="AssetChangeset", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class AssetChangeset : INotifyPropertyChanged
	{
		private int AssetIdField;

		private Dictionary<string, string> FieldsField;

		private ICollection<string> FormFieldNamesField;

		private ICollection<WcoSnippetDetachment> WcoDetachmentsField;

		private WcoVariantSelection WcoSelectedVariantField;

		private ICollection<WcoVariantChangeset> WcoVariantsField;

		[DataMember]
		public int AssetId
		{
			get
			{
				return this.AssetIdField;
			}
			set
			{
				if (!this.AssetIdField.Equals(value))
				{
					this.AssetIdField = value;
					this.RaisePropertyChanged("AssetId");
				}
			}
		}

		[DataMember]
		public Dictionary<string, string> Fields
		{
			get
			{
				return this.FieldsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.FieldsField, value))
				{
					this.FieldsField = value;
					this.RaisePropertyChanged("Fields");
				}
			}
		}

		[DataMember]
		public ICollection<string> FormFieldNames
		{
			get
			{
				return this.FormFieldNamesField;
			}
			set
			{
				if (!object.ReferenceEquals(this.FormFieldNamesField, value))
				{
					this.FormFieldNamesField = value;
					this.RaisePropertyChanged("FormFieldNames");
				}
			}
		}

		[DataMember]
		public ICollection<WcoSnippetDetachment> WcoDetachments
		{
			get
			{
				return this.WcoDetachmentsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.WcoDetachmentsField, value))
				{
					this.WcoDetachmentsField = value;
					this.RaisePropertyChanged("WcoDetachments");
				}
			}
		}

		[DataMember]
		public WcoVariantSelection WcoSelectedVariant
		{
			get
			{
				return this.WcoSelectedVariantField;
			}
			set
			{
				if (!object.ReferenceEquals(this.WcoSelectedVariantField, value))
				{
					this.WcoSelectedVariantField = value;
					this.RaisePropertyChanged("WcoSelectedVariant");
				}
			}
		}

		[DataMember]
		public ICollection<WcoVariantChangeset> WcoVariants
		{
			get
			{
				return this.WcoVariantsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.WcoVariantsField, value))
				{
					this.WcoVariantsField = value;
					this.RaisePropertyChanged("WcoVariants");
				}
			}
		}

		public AssetChangeset()
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