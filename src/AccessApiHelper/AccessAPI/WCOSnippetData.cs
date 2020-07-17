using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="WCOSnippetData", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class WCOSnippetData : INotifyPropertyChanged
	{
		private Guid IdField;

		private string NameField;

		private Guid SnippetIdField;

		private Guid TargetGroupIdField;

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

		public WCOSnippetData()
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