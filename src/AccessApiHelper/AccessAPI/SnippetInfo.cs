using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="SnippetInfo", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.App")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class SnippetInfo : INotifyPropertyChanged
	{
		private bool IsAssetDeletedField;

		private bool IsDetachedField;

		private bool IsPublishedField;

		private string LabelField;

		private int OwnerAssetIdField;

		private string SnippetIdField;

		private string StatusColorField;

		private string StatusLabelField;

		[DataMember]
		public bool IsAssetDeleted
		{
			get
			{
				return this.IsAssetDeletedField;
			}
			set
			{
				if (!this.IsAssetDeletedField.Equals(value))
				{
					this.IsAssetDeletedField = value;
					this.RaisePropertyChanged("IsAssetDeleted");
				}
			}
		}

		[DataMember]
		public bool IsDetached
		{
			get
			{
				return this.IsDetachedField;
			}
			set
			{
				if (!this.IsDetachedField.Equals(value))
				{
					this.IsDetachedField = value;
					this.RaisePropertyChanged("IsDetached");
				}
			}
		}

		[DataMember]
		public bool IsPublished
		{
			get
			{
				return this.IsPublishedField;
			}
			set
			{
				if (!this.IsPublishedField.Equals(value))
				{
					this.IsPublishedField = value;
					this.RaisePropertyChanged("IsPublished");
				}
			}
		}

		[DataMember]
		public string Label
		{
			get
			{
				return this.LabelField;
			}
			set
			{
				if (!object.ReferenceEquals(this.LabelField, value))
				{
					this.LabelField = value;
					this.RaisePropertyChanged("Label");
				}
			}
		}

		[DataMember]
		public int OwnerAssetId
		{
			get
			{
				return this.OwnerAssetIdField;
			}
			set
			{
				if (!this.OwnerAssetIdField.Equals(value))
				{
					this.OwnerAssetIdField = value;
					this.RaisePropertyChanged("OwnerAssetId");
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
		public string StatusColor
		{
			get
			{
				return this.StatusColorField;
			}
			set
			{
				if (!object.ReferenceEquals(this.StatusColorField, value))
				{
					this.StatusColorField = value;
					this.RaisePropertyChanged("StatusColor");
				}
			}
		}

		[DataMember]
		public string StatusLabel
		{
			get
			{
				return this.StatusLabelField;
			}
			set
			{
				if (!object.ReferenceEquals(this.StatusLabelField, value))
				{
					this.StatusLabelField = value;
					this.RaisePropertyChanged("StatusLabel");
				}
			}
		}

		public SnippetInfo()
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