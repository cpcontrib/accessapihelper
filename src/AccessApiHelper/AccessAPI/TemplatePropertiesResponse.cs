using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="TemplatePropertiesResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class TemplatePropertiesResponse : WSResultClass
	{
		private string AssetPathField;

		private bool IsDeveloperTemplateField;

		private int TemplateIdField;

		private int TemplateLanguageField;

		private string TemplatePathField;

		private ICollection<cpListscpKeyValuePair> UIConfigurationField;

		[DataMember]
		public string AssetPath
		{
			get
			{
				return this.AssetPathField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AssetPathField, value))
				{
					this.AssetPathField = value;
					base.RaisePropertyChanged("AssetPath");
				}
			}
		}

		[DataMember]
		public bool IsDeveloperTemplate
		{
			get
			{
				return this.IsDeveloperTemplateField;
			}
			set
			{
				if (!this.IsDeveloperTemplateField.Equals(value))
				{
					this.IsDeveloperTemplateField = value;
					base.RaisePropertyChanged("IsDeveloperTemplate");
				}
			}
		}

		[DataMember]
		public int TemplateId
		{
			get
			{
				return this.TemplateIdField;
			}
			set
			{
				if (!this.TemplateIdField.Equals(value))
				{
					this.TemplateIdField = value;
					base.RaisePropertyChanged("TemplateId");
				}
			}
		}

		[DataMember]
		public int TemplateLanguage
		{
			get
			{
				return this.TemplateLanguageField;
			}
			set
			{
				if (!this.TemplateLanguageField.Equals(value))
				{
					this.TemplateLanguageField = value;
					base.RaisePropertyChanged("TemplateLanguage");
				}
			}
		}

		[DataMember]
		public string TemplatePath
		{
			get
			{
				return this.TemplatePathField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TemplatePathField, value))
				{
					this.TemplatePathField = value;
					base.RaisePropertyChanged("TemplatePath");
				}
			}
		}

		[DataMember]
		public ICollection<cpListscpKeyValuePair> UIConfiguration
		{
			get
			{
				return this.UIConfigurationField;
			}
			set
			{
				if (!object.ReferenceEquals(this.UIConfigurationField, value))
				{
					this.UIConfigurationField = value;
					base.RaisePropertyChanged("UIConfiguration");
				}
			}
		}

		public TemplatePropertiesResponse()
		{
		}
	}
}