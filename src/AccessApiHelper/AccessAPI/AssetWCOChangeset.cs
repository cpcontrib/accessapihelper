using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="AssetWCOChangeset", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class AssetWCOChangeset : INotifyPropertyChanged
	{
		private ICollection<WcoSnippetAddition> AddedSnippetsField;

		private ICollection<WcoVariantAddition> AddedVariantsField;

		private int AssetIdField;

		private ICollection<WcoSnippetClone> ClonedSnippetsField;

		private ICollection<WcoVariantDeletion> DeletedVariantsField;

		[DataMember]
		public ICollection<WcoSnippetAddition> AddedSnippets
		{
			get
			{
				return this.AddedSnippetsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AddedSnippetsField, value))
				{
					this.AddedSnippetsField = value;
					this.RaisePropertyChanged("AddedSnippets");
				}
			}
		}

		[DataMember]
		public ICollection<WcoVariantAddition> AddedVariants
		{
			get
			{
				return this.AddedVariantsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AddedVariantsField, value))
				{
					this.AddedVariantsField = value;
					this.RaisePropertyChanged("AddedVariants");
				}
			}
		}

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
		public ICollection<WcoSnippetClone> ClonedSnippets
		{
			get
			{
				return this.ClonedSnippetsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ClonedSnippetsField, value))
				{
					this.ClonedSnippetsField = value;
					this.RaisePropertyChanged("ClonedSnippets");
				}
			}
		}

		[DataMember]
		public ICollection<WcoVariantDeletion> DeletedVariants
		{
			get
			{
				return this.DeletedVariantsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DeletedVariantsField, value))
				{
					this.DeletedVariantsField = value;
					this.RaisePropertyChanged("DeletedVariants");
				}
			}
		}

		public AssetWCOChangeset()
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