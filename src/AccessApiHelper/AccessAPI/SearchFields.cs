using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="SearchFields", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Filters")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class SearchFields : INotifyPropertyChanged
	{
		private ICollection<cpKVPOfintstring> BaseModelsField;

		private ICollection<SearchField> FieldsField;

		private ICollection<cpKVPOfintstring> FileTypesField;

		private ICollection<cpKVPOfintstring> ModelsField;

		private ICollection<cpKVPOfintstring> TemplatesField;

		[DataMember]
		public ICollection<cpKVPOfintstring> BaseModels
		{
			get
			{
				return this.BaseModelsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.BaseModelsField, value))
				{
					this.BaseModelsField = value;
					this.RaisePropertyChanged("BaseModels");
				}
			}
		}

		[DataMember]
		public ICollection<SearchField> Fields
		{
			get
			{
				return this.FieldsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.FieldsField, value))
				{
					this.FieldsField = value;
					this.RaisePropertyChanged("Fields");
				}
			}
		}

		[DataMember]
		public ICollection<cpKVPOfintstring> FileTypes
		{
			get
			{
				return this.FileTypesField;
			}
			set
			{
				if (!object.ReferenceEquals(this.FileTypesField, value))
				{
					this.FileTypesField = value;
					this.RaisePropertyChanged("FileTypes");
				}
			}
		}

		[DataMember]
		public ICollection<cpKVPOfintstring> Models
		{
			get
			{
				return this.ModelsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ModelsField, value))
				{
					this.ModelsField = value;
					this.RaisePropertyChanged("Models");
				}
			}
		}

		[DataMember]
		public ICollection<cpKVPOfintstring> Templates
		{
			get
			{
				return this.TemplatesField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TemplatesField, value))
				{
					this.TemplatesField = value;
					this.RaisePropertyChanged("Templates");
				}
			}
		}

		public SearchFields()
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