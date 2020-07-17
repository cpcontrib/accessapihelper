using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="LightAsset", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class LightAsset : INotifyPropertyChanged
	{
		private int FolderIdField;

		private int IdField;

		private string LabelField;

		private string ParentPathField;

		private int StatusIdField;

		private int TypeField;

		private int WorkflowIdField;

		[DataMember]
		public int FolderId
		{
			get
			{
				return this.FolderIdField;
			}
			set
			{
				if (!this.FolderIdField.Equals(value))
				{
					this.FolderIdField = value;
					this.RaisePropertyChanged("FolderId");
				}
			}
		}

		[DataMember]
		public int Id
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
		public string ParentPath
		{
			get
			{
				return this.ParentPathField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ParentPathField, value))
				{
					this.ParentPathField = value;
					this.RaisePropertyChanged("ParentPath");
				}
			}
		}

		[DataMember]
		public int StatusId
		{
			get
			{
				return this.StatusIdField;
			}
			set
			{
				if (!this.StatusIdField.Equals(value))
				{
					this.StatusIdField = value;
					this.RaisePropertyChanged("StatusId");
				}
			}
		}

		[DataMember]
		public int Type
		{
			get
			{
				return this.TypeField;
			}
			set
			{
				if (!this.TypeField.Equals(value))
				{
					this.TypeField = value;
					this.RaisePropertyChanged("Type");
				}
			}
		}

		[DataMember]
		public int WorkflowId
		{
			get
			{
				return this.WorkflowIdField;
			}
			set
			{
				if (!this.WorkflowIdField.Equals(value))
				{
					this.WorkflowIdField = value;
					this.RaisePropertyChanged("WorkflowId");
				}
			}
		}

		public LightAsset()
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