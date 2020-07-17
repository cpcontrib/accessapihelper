using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="WcoSnippetClone", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class WcoSnippetClone : INotifyPropertyChanged
	{
		private string SnippetIdField;

		private string SnippetNameField;

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

		public WcoSnippetClone()
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