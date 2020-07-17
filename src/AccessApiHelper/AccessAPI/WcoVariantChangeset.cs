using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="WcoVariantChangeset", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class WcoVariantChangeset : INotifyPropertyChanged
	{
		private string EmbedCodeField;

		private string FieldNameField;

		private string SnippetIdField;

		private string TargetingGroupIdField;

		private string VariantIdField;

		private string VariantNameField;

		private int WeightField;

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
		public string TargetingGroupId
		{
			get
			{
				return this.TargetingGroupIdField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TargetingGroupIdField, value))
				{
					this.TargetingGroupIdField = value;
					this.RaisePropertyChanged("TargetingGroupId");
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
		public string VariantName
		{
			get
			{
				return this.VariantNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.VariantNameField, value))
				{
					this.VariantNameField = value;
					this.RaisePropertyChanged("VariantName");
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

		public WcoVariantChangeset()
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