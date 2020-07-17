using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetUserHelpResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetUserHelpResponse : WSResultClass
	{
		private ICollection<WorklistAsset> UserHelpResultsField;

		[DataMember]
		public ICollection<WorklistAsset> UserHelpResults
		{
			get
			{
				return this.UserHelpResultsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.UserHelpResultsField, value))
				{
					this.UserHelpResultsField = value;
					base.RaisePropertyChanged("UserHelpResults");
				}
			}
		}

		public GetUserHelpResponse()
		{
		}
	}
}