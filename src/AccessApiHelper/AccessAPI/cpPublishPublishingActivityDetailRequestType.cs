using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="cpPublish.PublishingActivityDetailRequestType", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public enum cpPublishPublishingActivityDetailRequestType
	{
		[EnumMember]
		MOSTRECENT,
		[EnumMember]
		OLDEST,
		[EnumMember]
		NEXT,
		[EnumMember]
		PREV
	}
}