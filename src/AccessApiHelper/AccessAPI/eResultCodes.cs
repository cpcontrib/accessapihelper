using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="eResultCodes", Namespace="http://schemas.datacontract.org/2004/07/")]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public enum eResultCodes
	{
		[EnumMember]
		conWS_NotSet,
		[EnumMember]
		conWS_Success,
		[EnumMember]
		conWS_GeneralError,
		[EnumMember]
		conWS_DBConnectFailure,
		[EnumMember]
		conWS_SessionUnauthorizedOrTimedOut,
		[EnumMember]
		conWS_DBError,
		[EnumMember]
		conWS_APIError,
		[EnumMember]
		conWS_APIUnknownError,
		[EnumMember]
		conWS_InvalidUserNameOrPassword,
		[EnumMember]
		conWS_NotFound,
		[EnumMember]
		conWS_InitError,
		[EnumMember]
		conWS_ConfigurationError,
		[EnumMember]
		conWS_ConfigurationGlobalError,
		[EnumMember]
		conWS_ActionNotAllowed,
		[EnumMember]
		conWS_NotImplemented,
		[EnumMember]
		conWS_NotCheckedOutByThisUser,
		[EnumMember]
		conWS_LoginDisabled,
		[EnumMember]
		conWS_LoginExpired,
		[EnumMember]
		conWS_CompilerError,
		[EnumMember]
		conWS_WorkflowFailure,
		[EnumMember]
		conWS_PluginError,
		[EnumMember]
		conWS_UploadTooLarge,
		[EnumMember]
		conWS_PasswordExpired,
		[EnumMember]
		conWS_ValidationError,
		[EnumMember]
		conWS_HasFailures,
		[EnumMember]
		conWS_IoError,
		[EnumMember]
		conWS_LayoutNotFound,
		[EnumMember]
		conWS_PasswordTemporary,
		[EnumMember]
		conWS_RestrictedHours,
		[EnumMember]
		conWS_RestrictedLocation,
		[EnumMember]
		conWS_ExceededLoginAttempts,
		[EnumMember]
		conWS_LockedByAnotherUser,
		[EnumMember]
		conWS_MovedPermanently
	}
}