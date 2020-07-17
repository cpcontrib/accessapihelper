using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetUrlFilenameFiltersResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetUrlFilenameFiltersResponse : WSResultClass
	{
		private string default_extField;

		private ICollection<FilenameFilterData> filenameFiltersField;

		private bool lowercaseField;

		private ICollection<UrlFilterData> urlFiltersField;

		[DataMember]
		public string default_ext
		{
			get
			{
				return this.default_extField;
			}
			set
			{
				if (!object.ReferenceEquals(this.default_extField, value))
				{
					this.default_extField = value;
					base.RaisePropertyChanged("default_ext");
				}
			}
		}

		[DataMember]
		public ICollection<FilenameFilterData> filenameFilters
		{
			get
			{
				return this.filenameFiltersField;
			}
			set
			{
				if (!object.ReferenceEquals(this.filenameFiltersField, value))
				{
					this.filenameFiltersField = value;
					base.RaisePropertyChanged("filenameFilters");
				}
			}
		}

		[DataMember]
		public bool lowercase
		{
			get
			{
				return this.lowercaseField;
			}
			set
			{
				if (!this.lowercaseField.Equals(value))
				{
					this.lowercaseField = value;
					base.RaisePropertyChanged("lowercase");
				}
			}
		}

		[DataMember]
		public ICollection<UrlFilterData> urlFilters
		{
			get
			{
				return this.urlFiltersField;
			}
			set
			{
				if (!object.ReferenceEquals(this.urlFiltersField, value))
				{
					this.urlFiltersField = value;
					base.RaisePropertyChanged("urlFilters");
				}
			}
		}

		public GetUrlFilenameFiltersResponse()
		{
		}
	}
}