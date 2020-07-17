using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetModelPropertiesResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetModelPropertiesResponse : WSResultClass
	{
		private int ModelIdField;

		private string ModelPathField;

		private ICollection<cpListscpKeyValuePair> UIConfigurationField;

		[DataMember]
		public int ModelId
		{
			get
			{
				return this.ModelIdField;
			}
			set
			{
				if (!this.ModelIdField.Equals(value))
				{
					this.ModelIdField = value;
					base.RaisePropertyChanged("ModelId");
				}
			}
		}

		[DataMember]
		public string ModelPath
		{
			get
			{
				return this.ModelPathField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ModelPathField, value))
				{
					this.ModelPathField = value;
					base.RaisePropertyChanged("ModelPath");
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

		public GetModelPropertiesResponse()
		{
		}
	}
}