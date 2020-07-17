using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="WcoVariantSelection", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class WcoVariantSelection : INotifyPropertyChanged
	{
		private string FieldNameField;

		private string SnippetIdField;

		private string VariantIdField;

		private int VariantTypeField;

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
		public string VariantId
		{
			get
			{
				return this.VariantIdField;
			}
			set
			{
				if (!object.ReferenceEquals(this.VariantIdField, value))
				{
					this.VariantIdField = value;
					this.RaisePropertyChanged("VariantId");
				}
			}
		}

		[DataMember]
		public int VariantType
		{
			get
			{
				return this.VariantTypeField;
			}
			set
			{
				if (!this.VariantTypeField.Equals(value))
				{
					this.VariantTypeField = value;
					this.RaisePropertyChanged("VariantType");
				}
			}
		}

		public WcoVariantSelection()
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