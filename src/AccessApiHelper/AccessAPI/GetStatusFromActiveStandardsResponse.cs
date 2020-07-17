using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetStatusFromActiveStandardsResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetStatusFromActiveStandardsResponse : WSResultClass
	{
		private string modeField;

		private ActiveStandardsStatus statusField;

		[DataMember]
		public string mode
		{
			get
			{
				return this.modeField;
			}
			set
			{
				if (!object.ReferenceEquals(this.modeField, value))
				{
					this.modeField = value;
					base.RaisePropertyChanged("mode");
				}
			}
		}

		[DataMember]
		public ActiveStandardsStatus status
		{
			get
			{
				return this.statusField;
			}
			set
			{
				if (!object.ReferenceEquals(this.statusField, value))
				{
					this.statusField = value;
					base.RaisePropertyChanged("status");
				}
			}
		}

		public GetStatusFromActiveStandardsResponse()
		{
		}
	}
}