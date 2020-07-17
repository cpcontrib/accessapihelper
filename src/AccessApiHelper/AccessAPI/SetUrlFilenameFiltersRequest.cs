using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="SetUrlFilenameFiltersRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class SetUrlFilenameFiltersRequest : INotifyPropertyChanged
	{
		private string Default_extField;

		private ICollection<FilenameFilterData> FilenameFiltersField;

		private bool LowercaseField;

		private ICollection<UrlFilterData> UrlFiltersField;

		[DataMember]
		public string Default_ext
		{
			get
			{
				return this.Default_extField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Default_extField, value))
				{
					this.Default_extField = value;
					this.RaisePropertyChanged("Default_ext");
				}
			}
		}

		[DataMember]
		public ICollection<FilenameFilterData> FilenameFilters
		{
			get
			{
				return this.FilenameFiltersField;
			}
			set
			{
				if (!object.ReferenceEquals(this.FilenameFiltersField, value))
				{
					this.FilenameFiltersField = value;
					this.RaisePropertyChanged("FilenameFilters");
				}
			}
		}

		[DataMember]
		public bool Lowercase
		{
			get
			{
				return this.LowercaseField;
			}
			set
			{
				if (!this.LowercaseField.Equals(value))
				{
					this.LowercaseField = value;
					this.RaisePropertyChanged("Lowercase");
				}
			}
		}

		[DataMember]
		public ICollection<UrlFilterData> UrlFilters
		{
			get
			{
				return this.UrlFiltersField;
			}
			set
			{
				if (!object.ReferenceEquals(this.UrlFiltersField, value))
				{
					this.UrlFiltersField = value;
					this.RaisePropertyChanged("UrlFilters");
				}
			}
		}

		public SetUrlFilenameFiltersRequest()
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