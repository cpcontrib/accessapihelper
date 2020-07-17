using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="WcoSnippetAddition", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class WcoSnippetAddition : INotifyPropertyChanged
	{
		private string EmbedCodeField;

		private string FieldNameField;

		private string SnippetNameField;

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
		public string SnippetName
		{
			get
			{
				return this.SnippetNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SnippetNameField, value))
				{
					this.SnippetNameField = value;
					this.RaisePropertyChanged("SnippetName");
				}
			}
		}

		public WcoSnippetAddition()
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