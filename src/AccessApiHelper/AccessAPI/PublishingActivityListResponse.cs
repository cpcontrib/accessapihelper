using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="PublishingActivityListResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class PublishingActivityListResponse : WSResultClass
	{
		private PublishingActivity activityField;

		[DataMember]
		public PublishingActivity activity
		{
			get
			{
				return this.activityField;
			}
			set
			{
				if (!object.ReferenceEquals(this.activityField, value))
				{
					this.activityField = value;
					base.RaisePropertyChanged("activity");
				}
			}
		}

		public PublishingActivityListResponse()
		{
		}
	}
}