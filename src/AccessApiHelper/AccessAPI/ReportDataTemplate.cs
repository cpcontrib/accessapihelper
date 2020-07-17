using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="ReportDataTemplate", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class ReportDataTemplate : INotifyPropertyChanged
	{
		private int asset_idField;

		private int costField;

		private int countField;

		private int idField;

		private int inuseField;

		private ICollection<int> linesField;

		private string nameField;

		private ICollection<int> sizeField;

		private int speedField;

		private ICollection<string> template_fileField;

		private int template_idField;

		[DataMember]
		public int asset_id
		{
			get
			{
				return this.asset_idField;
			}
			set
			{
				if (!this.asset_idField.Equals(value))
				{
					this.asset_idField = value;
					this.RaisePropertyChanged("asset_id");
				}
			}
		}

		[DataMember]
		public int cost
		{
			get
			{
				return this.costField;
			}
			set
			{
				if (!this.costField.Equals(value))
				{
					this.costField = value;
					this.RaisePropertyChanged("cost");
				}
			}
		}

		[DataMember]
		public int count
		{
			get
			{
				return this.countField;
			}
			set
			{
				if (!this.countField.Equals(value))
				{
					this.countField = value;
					this.RaisePropertyChanged("count");
				}
			}
		}

		[DataMember]
		public int id
		{
			get
			{
				return this.idField;
			}
			set
			{
				if (!this.idField.Equals(value))
				{
					this.idField = value;
					this.RaisePropertyChanged("id");
				}
			}
		}

		[DataMember]
		public int inuse
		{
			get
			{
				return this.inuseField;
			}
			set
			{
				if (!this.inuseField.Equals(value))
				{
					this.inuseField = value;
					this.RaisePropertyChanged("inuse");
				}
			}
		}

		[DataMember]
		public ICollection<int> lines
		{
			get
			{
				return this.linesField;
			}
			set
			{
				if (!object.ReferenceEquals(this.linesField, value))
				{
					this.linesField = value;
					this.RaisePropertyChanged("lines");
				}
			}
		}

		[DataMember]
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.nameField, value))
				{
					this.nameField = value;
					this.RaisePropertyChanged("name");
				}
			}
		}

		[DataMember]
		public ICollection<int> size
		{
			get
			{
				return this.sizeField;
			}
			set
			{
				if (!object.ReferenceEquals(this.sizeField, value))
				{
					this.sizeField = value;
					this.RaisePropertyChanged("size");
				}
			}
		}

		[DataMember]
		public int speed
		{
			get
			{
				return this.speedField;
			}
			set
			{
				if (!this.speedField.Equals(value))
				{
					this.speedField = value;
					this.RaisePropertyChanged("speed");
				}
			}
		}

		[DataMember]
		public ICollection<string> template_file
		{
			get
			{
				return this.template_fileField;
			}
			set
			{
				if (!object.ReferenceEquals(this.template_fileField, value))
				{
					this.template_fileField = value;
					this.RaisePropertyChanged("template_file");
				}
			}
		}

		[DataMember]
		public int template_id
		{
			get
			{
				return this.template_idField;
			}
			set
			{
				if (!this.template_idField.Equals(value))
				{
					this.template_idField = value;
					this.RaisePropertyChanged("template_id");
				}
			}
		}

		public ReportDataTemplate()
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