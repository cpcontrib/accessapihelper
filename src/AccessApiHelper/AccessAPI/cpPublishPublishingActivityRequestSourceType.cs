using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="cpPublish.PublishingActivityRequestSourceType", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public enum cpPublishPublishingActivityRequestSourceType
	{
		[EnumMember]
		MY_SESSIONS,
		[EnumMember]
		OTHER_SESSIONS,
		[EnumMember]
		SYSTEM_SESSIONS,
		[EnumMember]
		MY_SESSIONS_DEPENDENCY_ONLY
	}
}