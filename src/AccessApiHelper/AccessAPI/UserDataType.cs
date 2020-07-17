using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="UserDataType", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public enum UserDataType
	{
		[EnumMember]
		Id,
		[EnumMember]
		Username,
		[EnumMember]
		FirstName,
		[EnumMember]
		LastName,
		[EnumMember]
		Status,
		[EnumMember]
		Email,
		[EnumMember]
		OfficePhoneNumber,
		[EnumMember]
		Fax,
		[EnumMember]
		Cell,
		[EnumMember]
		Pager,
		[EnumMember]
		Signature,
		[EnumMember]
		Expiration,
		[EnumMember]
		Avatar,
		[EnumMember]
		TitleId,
		[EnumMember]
		DepartmentId,
		[EnumMember]
		LocationId,
		[EnumMember]
		Extension,
		[EnumMember]
		Password,
		[EnumMember]
		CurrentPassword,
		[EnumMember]
		IdpName
	}
}