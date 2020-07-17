using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="SnippetList", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.App")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class SnippetList : INotifyPropertyChanged
	{
		private ICollection<CpSnippet> _snippet_listField;

		private string statusField;

		[DataMember]
		public ICollection<CpSnippet> _snippet_list
		{
			get
			{
				return this._snippet_listField;
			}
			set
			{
				if (!object.ReferenceEquals(this._snippet_listField, value))
				{
					this._snippet_listField = value;
					this.RaisePropertyChanged("_snippet_list");
				}
			}
		}

		[DataMember]
		public string status
		{
			get
			{
				return this.statusField;
			}
			set
			{
				if (!object.ReferenceEquals(this.statusField, value))
				{
					this.statusField = value;
					this.RaisePropertyChanged("status");
				}
			}
		}

		public SnippetList()
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