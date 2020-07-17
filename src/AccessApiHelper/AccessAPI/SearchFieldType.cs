using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="SearchFieldType", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Filters")]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public enum SearchFieldType
	{
		[EnumMember]
		String,
		[EnumMember]
		Numeric,
		[EnumMember]
		Date,
		[EnumMember]
		Bool,
		[EnumMember]
		Custom,
		[EnumMember]
		User,
		[EnumMember]
		Model,
		[EnumMember]
		BaseModel,
		[EnumMember]
		Status,
		[EnumMember]
		Template,
		[EnumMember]
		Workflow,
		[EnumMember]
		FileType
	}
}