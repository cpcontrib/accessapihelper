using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="UserLoginReportResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class UserLoginReportResponse : WSResultClass
	{
		private ICollection<cpListscpKeyValuePair> UIConfigurationField;

		private ICollection<UserLoginReportData> userLoginsField;

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

		[DataMember]
		public ICollection<UserLoginReportData> userLogins
		{
			get
			{
				return this.userLoginsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.userLoginsField, value))
				{
					this.userLoginsField = value;
					base.RaisePropertyChanged("userLogins");
				}
			}
		}

		public UserLoginReportResponse()
		{
		}
	}
}