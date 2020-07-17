using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="SnippetAssociation", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model.UIModel")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class SnippetAssociation : INotifyPropertyChanged
	{
		private string FieldNameField;

		private string SnippetIdField;

		private ICollection<VariantAsset> VariantsField;

		[DataMember]
		public string FieldName
		{
			get
			{
				return this.FieldNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.FieldNameField, value))
				{
					this.FieldNameField = value;
					this.RaisePropertyChanged("FieldName");
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
		public ICollection<VariantAsset> Variants
		{
			get
			{
				return this.VariantsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.VariantsField, value))
				{
					this.VariantsField = value;
					this.RaisePropertyChanged("Variants");
				}
			}
		}

		public SnippetAssociation()
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