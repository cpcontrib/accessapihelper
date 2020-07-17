using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="ResultClass", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[KnownType(typeof(AddConnectorResponse))]
	[KnownType(typeof(AddPackageConfigDataResponse))]
	[KnownType(typeof(AdvancedSearchResponse))]
	[KnownType(typeof(AssetReportResponse))]
	[KnownType(typeof(AssetResult))]
	[KnownType(typeof(AuthenticateResponseWCF))]
	[KnownType(typeof(CancelUploadResponse))]
	[KnownType(typeof(CancelUploadsResponse))]
	[KnownType(typeof(ClearCacheLinkResponse))]
	[KnownType(typeof(ClearErrorsResponse))]
	[KnownType(typeof(ClearQueuedAssetsResponse))]
	[KnownType(typeof(CloneAssetResponse))]
	[KnownType(typeof(CloneCustomCSharpAssetResponse))]
	[KnownType(typeof(CloneGroupResponse))]
	[KnownType(typeof(ClonePublishingPackageResponse))]
	[KnownType(typeof(CloneWorkflowResponse))]
	[KnownType(typeof(ConfirmEmailSenderResponse))]
	[KnownType(typeof(CopyAssetResponse))]
	[KnownType(typeof(CopyAssetsResponse))]
	[KnownType(typeof(CreateAssetShortcutResponse))]
	[KnownType(typeof(CreateAssetsShortcutResponse))]
	[KnownType(typeof(CreateBranchResponse))]
	[KnownType(typeof(CreateCollectionResponse))]
	[KnownType(typeof(CreateCustomClassResponse))]
	[KnownType(typeof(CreateDashboardResponse))]
	[KnownType(typeof(CreateExternalLibraryResponse))]
	[KnownType(typeof(CreateFileByModelIdResponse))]
	[KnownType(typeof(CreateFileResponse))]
	[KnownType(typeof(CreateFolderByModelIdResponse))]
	[KnownType(typeof(CreateFolderResponse))]
	[KnownType(typeof(CreateLibraryResponse))]
	[KnownType(typeof(CreateProfileResponse))]
	[KnownType(typeof(CreateProjectResponse))]
	[KnownType(typeof(CreateSiteRootResponse))]
	[KnownType(typeof(CreateTemplateFileResponse))]
	[KnownType(typeof(CreateTemplateFolderResponse))]
	[KnownType(typeof(CreateTemplateResponse))]
	[KnownType(typeof(CreateUserResponse))]
	[KnownType(typeof(DeleteConnectorResponse))]
	[KnownType(typeof(DeleteEmailSenderResponse))]
	[KnownType(typeof(DeleteGroupResponse))]
	[KnownType(typeof(DeletePackageConfigDataResponse))]
	[KnownType(typeof(DeleteUserResponse))]
	[KnownType(typeof(DeleteUsersResponse))]
	[KnownType(typeof(DeleteWorkflowResponse))]
	[KnownType(typeof(DeleteWorkflowsResponse))]
	[KnownType(typeof(DownloadAssetResponse))]
	[KnownType(typeof(DownloadAssetsResponse))]
	[KnownType(typeof(DownloadResponse))]
	[KnownType(typeof(ExecuteWorkflowCommandResponse))]
	[KnownType(typeof(FinishDownloadAssetResponse))]
	[KnownType(typeof(FinishSelectImageResponse))]
	[KnownType(typeof(FinishUploadAssetResponse))]
	[KnownType(typeof(FinishUploadAttachmentResponse))]
	[KnownType(typeof(FinishUploadAvatarResponse))]
	[KnownType(typeof(ForgotPasswordResponse))]
	[KnownType(typeof(GeneralPropertiesResponse))]
	[KnownType(typeof(GetActiveStandardsReportResponse))]
	[KnownType(typeof(GetAdvancedSearchOptionsResponse))]
	[KnownType(typeof(GetAlertConfigDataResponse))]
	[KnownType(typeof(GetAssetAndChildrenByIdResponse))]
	[KnownType(typeof(GetAssetByGoToQueryResponse))]
	[KnownType(typeof(GetAssetByPathResponse))]
	[KnownType(typeof(GetAssetFieldsResponse))]
	[KnownType(typeof(GetAssetListResponse))]
	[KnownType(typeof(GetAssetMetaDataResponse))]
	[KnownType(typeof(GetAssetPathByIdResponse))]
	[KnownType(typeof(GetAssetPublishHistoryResponse))]
	[KnownType(typeof(GetAssetRefreshReportResponse))]
	[KnownType(typeof(GetAssetResponse))]
	[KnownType(typeof(GetAssetScheduleResponse))]
	[KnownType(typeof(GetAssetVersionsResponse))]
	[KnownType(typeof(GetBoxAccountsResponse))]
	[KnownType(typeof(GetChildStatesResponse))]
	[KnownType(typeof(GetCollectionsAssetListResponse))]
	[KnownType(typeof(GetCollectionsResponse))]
	[KnownType(typeof(GetConnectorConfigDataResponse))]
	[KnownType(typeof(GetConnectorResponse))]
	[KnownType(typeof(GetCPAvatarsResponse))]
	[KnownType(typeof(GetDashboardAssetsResponse))]
	[KnownType(typeof(GetDebugMessagesResponse))]
	[KnownType(typeof(GetDemandbaseDataResponse))]
	[KnownType(typeof(GetDepartmentsResponse))]
	[KnownType(typeof(GetDiagnosticsReportDataResponse))]
	[KnownType(typeof(GetDropBoxAccountsResponse))]
	[KnownType(typeof(GetEmailSendersResponse))]
	[KnownType(typeof(GetFacebookInsightsDataResponse))]
	[KnownType(typeof(GetFileOptionsResponse))]
	[KnownType(typeof(GetFolderAssetFieldsResponse))]
	[KnownType(typeof(GetFolderOptionsResponse))]
	[KnownType(typeof(GetFtpServersDataResponse))]
	[KnownType(typeof(GetGeneralConfigDataResponse))]
	[KnownType(typeof(GetGeneralWCOConfigDataResponse))]
	[KnownType(typeof(GetGoogleAnalyticsAccountsResponse))]
	[KnownType(typeof(GetGoogleAnalyticsDataResponse))]
	[KnownType(typeof(GetGoogleAnalyticsProfilesResponse))]
	[KnownType(typeof(GetGoogleAnalyticsPropertiesResponse))]
	[KnownType(typeof(GetGoogleDriveResponse))]
	[KnownType(typeof(GetGroupsConfigDataResponse))]
	[KnownType(typeof(GetGroupsDataResponse))]
	[KnownType(typeof(GetHelpAssetsResponse))]
	[KnownType(typeof(GetHttpServersDataResponse))]
	[KnownType(typeof(GetJobActivityResponse))]
	[KnownType(typeof(GetJobQueueItemResponse))]
	[KnownType(typeof(GetJobQueueItemsResponse))]
	[KnownType(typeof(GetLayoutNamesResponse))]
	[KnownType(typeof(GetLayoutsResponse))]
	[KnownType(typeof(GetLibraryFilesCDCResponse))]
	[KnownType(typeof(GetLibraryFilesZipCDCResponse))]
	[KnownType(typeof(GetLocationsResponse))]
	[KnownType(typeof(GetMaintenanceMessageResult))]
	[KnownType(typeof(GetManagedFacebookAccountsResponse))]
	[KnownType(typeof(GetMenuConfigDataResponse))]
	[KnownType(typeof(GetModelPropertiesResponse))]
	[KnownType(typeof(GetOdbcServersDataResponse))]
	[KnownType(typeof(GetOrphanReportResponse))]
	[KnownType(typeof(GetOrphanReportServerDataResponse))]
	[KnownType(typeof(GetOutputURLResponse))]
	[KnownType(typeof(GetPasswordPolicyResponse))]
	[KnownType(typeof(GetPerformanceDataResponse))]
	[KnownType(typeof(GetPluginBodyResponse))]
	[KnownType(typeof(GetPreAuthDataResponse))]
	[KnownType(typeof(GetProviderInfoResponse))]
	[KnownType(typeof(GetProviderSettingsConfigDataResponse))]
	[KnownType(typeof(GetProvidersResponse))]
	[KnownType(typeof(GetPublishHistoryResponse))]
	[KnownType(typeof(GetPublishingActivity2Response))]
	[KnownType(typeof(GetPublishingPackageSummaryResponse))]
	[KnownType(typeof(GetPublishingServersDataResponse))]
	[KnownType(typeof(GetPublishingServersMetaDataResponse))]
	[KnownType(typeof(GetPublishingServersResponse))]
	[KnownType(typeof(GetRelatedAssetsResponse))]
	[KnownType(typeof(GetSecurityConfigDataResponse))]
	[KnownType(typeof(GetSelectListsResponse))]
	[KnownType(typeof(GetSite24x7Response))]
	[KnownType(typeof(GetSiteRootPropertiesResponse))]
	[KnownType(typeof(GetSmtpServersDataResponse))]
	[KnownType(typeof(GetSoapServersDataResponse))]
	[KnownType(typeof(GetStatusFromActiveStandardsResponse))]
	[KnownType(typeof(GetSystemHistoryResponse))]
	[KnownType(typeof(GetSystemVariablesDataResponse))]
	[KnownType(typeof(GetTasksResponse))]
	[KnownType(typeof(GetTemplatesFolderResponse))]
	[KnownType(typeof(GetTitlesResponse))]
	[KnownType(typeof(GetTwitterAuthLinkResponse))]
	[KnownType(typeof(GetUrlFilenameFiltersResponse))]
	[KnownType(typeof(GetUserDataResponse))]
	[KnownType(typeof(GetUserHelpResponse))]
	[KnownType(typeof(GetUserPreferencesDataResponse))]
	[KnownType(typeof(GetUsersConfigDataResponse))]
	[KnownType(typeof(GetWorkflowListByFolderResponse))]
	[KnownType(typeof(GetWorkflowPropertiesResponse))]
	[KnownType(typeof(GetWorkflowsResponse))]
	[KnownType(typeof(HeartbeatResponse))]
	[KnownType(typeof(IsOutputWebCaptureCompleteResponse))]
	[KnownType(typeof(LogoutResponse))]
	[KnownType(typeof(MoveAssetResponse))]
	[KnownType(typeof(MoveAssetsResponse))]
	[KnownType(typeof(OpenTemplateCDCResponse))]
	[KnownType(typeof(PreCreateJobResponse))]
	[KnownType(typeof(PrepareDownloadAuditCSVResponse))]
	[KnownType(typeof(PrepareDownloadResponse))]
	[KnownType(typeof(PrepareUploadResponse))]
	[KnownType(typeof(PublishingActivityListResponse))]
	[KnownType(typeof(PublishingPropertiesResponse))]
	[KnownType(typeof(PublishListResponse))]
	[KnownType(typeof(PublishRefreshListResponse))]
	[KnownType(typeof(PublishRefreshResponse))]
	[KnownType(typeof(PublishResponse))]
	[KnownType(typeof(QuickSearchResponse))]
	[KnownType(typeof(RecompileTemplatesResponse))]
	[KnownType(typeof(RefreshPublishingPackageResponse))]
	[KnownType(typeof(RenameAssetResponse))]
	[KnownType(typeof(RenameAssetsResponse))]
	[KnownType(typeof(RenderInputTemplateResponse))]
	[KnownType(typeof(ReportResponse))]
	[KnownType(typeof(RevertAssetVersionResponse))]
	[KnownType(typeof(RouteAssetResponse))]
	[KnownType(typeof(RouteAssetsResponse))]
	[KnownType(typeof(SendCDCLogResponse))]
	[KnownType(typeof(SendToActiveStandardsResponse))]
	[KnownType(typeof(SetAlertConfigDataResponse))]
	[KnownType(typeof(SetAssetDeletedResponse))]
	[KnownType(typeof(SetAssetFlaggedResponse))]
	[KnownType(typeof(SetAssetHiddenResponse))]
	[KnownType(typeof(SetAssetMetaDataResponse))]
	[KnownType(typeof(SetAssetScheduleResponse))]
	[KnownType(typeof(SetAssetsDeletedResponse))]
	[KnownType(typeof(SetAssetsFlaggedResponse))]
	[KnownType(typeof(SetAssetsHiddenResponse))]
	[KnownType(typeof(SetAssetsMetaDataResponse))]
	[KnownType(typeof(SetAsSiteRootResponse))]
	[KnownType(typeof(SetConnectorConfigDataResponse))]
	[KnownType(typeof(SetFileOptionsResponse))]
	[KnownType(typeof(SetFolderOptionsResponse))]
	[KnownType(typeof(SetGeneralConfigDataResponse))]
	[KnownType(typeof(SetGeneralWCOConfigDataResponse))]
	[KnownType(typeof(SetHttpServerDataResponse))]
	[KnownType(typeof(SetMenuConfigDataResponse))]
	[KnownType(typeof(SetMenuShortcutResponse))]
	[KnownType(typeof(SetModelPropertiesResponse))]
	[KnownType(typeof(SetOdbcServerDataResponse))]
	[KnownType(typeof(SetPasswordPolicyResponse))]
	[KnownType(typeof(SetPasswordResponse))]
	[KnownType(typeof(SetProviderSettingsConfigDataResponse))]
	[KnownType(typeof(SetPublishingServerDataResponse))]
	[KnownType(typeof(SetPublishingServerMetaDataResponse))]
	[KnownType(typeof(SetRepositoryServerDataResponse))]
	[KnownType(typeof(SetSecurityConfigDataResponse))]
	[KnownType(typeof(SetSelectListResponse))]
	[KnownType(typeof(SetSiteRootPropertiesResponse))]
	[KnownType(typeof(SetSmtpServerDataResponse))]
	[KnownType(typeof(SetSystemVariablesDataResponse))]
	[KnownType(typeof(SetUrlFilenameFiltersResponse))]
	[KnownType(typeof(SetUserDataResponse))]
	[KnownType(typeof(SetUserPreferenceDataResponse))]
	[KnownType(typeof(SetWorkflowPropertiesResponse))]
	[KnownType(typeof(SetWorklistPreferenceResponse))]
	[KnownType(typeof(StartFindOrphanReportResponse))]
	[KnownType(typeof(StopPublishingSessionResponse))]
	[KnownType(typeof(StopTemplateDebuggingResponse))]
	[KnownType(typeof(SystemSummaryReportResponse))]
	[KnownType(typeof(TemplatePropertiesResponse))]
	[KnownType(typeof(TemplateReportResponse))]
	[KnownType(typeof(TestConnectorResponse))]
	[KnownType(typeof(UnBranchResponse))]
	[KnownType(typeof(UnlockAssetResponse))]
	[KnownType(typeof(UpdateConnectorResponse))]
	[KnownType(typeof(UpdatePackageConfigDataResponse))]
	[KnownType(typeof(UpdateServerMetaConfigResponse))]
	[KnownType(typeof(UploadResponse))]
	[KnownType(typeof(UserLoginReportResponse))]
	[KnownType(typeof(ValidateEmailSenderResponse))]
	[KnownType(typeof(VerifyBuildResponse))]
	[KnownType(typeof(WCOAddAndDeleteVariantsResponse))]
	[KnownType(typeof(WCOAddSnippetResponse))]
	[KnownType(typeof(WCOAddVariantResponse))]
	[KnownType(typeof(WCOCreateConversionUrlResponse))]
	[KnownType(typeof(WCODeleteVariantFromCmsResponse))]
	[KnownType(typeof(WCODetachSnippetResponse))]
	[KnownType(typeof(WCOGetCollectionsAndSnippetsResponse))]
	[KnownType(typeof(WCOGetCountsResponse))]
	[KnownType(typeof(WCOGetFormBuilderUrlResponse))]
	[KnownType(typeof(WCOGetOutputUrlResponse))]
	[KnownType(typeof(WCOGetProfilesByAssetIdResponse))]
	[KnownType(typeof(WCOGetSnippetsResponse))]
	[KnownType(typeof(WCOGetSnippetVariantTestsDataResponse))]
	[KnownType(typeof(WCOGetStatsCountsResponse))]
	[KnownType(typeof(WCOGetTargetingGroupsResponse))]
	[KnownType(typeof(WCOGetVariantCountsResponse))]
	[KnownType(typeof(WCOGetVariantOverviewResponse))]
	[KnownType(typeof(WCOGetVariantsResponse))]
	[KnownType(typeof(WCOSaveSelectionResponse))]
	[KnownType(typeof(WCOUpdateVariantResponse))]
	[KnownType(typeof(WSResultClass))]
	public class ResultClass : INotifyPropertyChanged
	{
		private string ErrorMessageField;

		private int InternalCodeField;

		private eResultCodes ResultCodeField;

		[DataMember]
		public string ErrorMessage
		{
			get
			{
				return this.ErrorMessageField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ErrorMessageField, value))
				{
					this.ErrorMessageField = value;
					this.RaisePropertyChanged("ErrorMessage");
				}
			}
		}

		[DataMember]
		public int InternalCode
		{
			get
			{
				return this.InternalCodeField;
			}
			set
			{
				if (!this.InternalCodeField.Equals(value))
				{
					this.InternalCodeField = value;
					this.RaisePropertyChanged("InternalCode");
				}
			}
		}

		public bool IsSuccessful
		{
			get
			{
				return this.ResultCode == eResultCodes.conWS_Success;
			}
		}

		[DataMember]
		public eResultCodes ResultCode
		{
			get
			{
				return this.ResultCodeField;
			}
			set
			{
				if (!this.ResultCodeField.Equals(value))
				{
					this.ResultCodeField = value;
					this.RaisePropertyChanged("ResultCode");
				}
			}
		}

		public ResultClass(ResultClass resultClass)
		{
			this.ErrorMessage = resultClass.ErrorMessage;
			this.ResultCode = resultClass.ResultCode;
			this.InternalCode = resultClass.InternalCode;
		}

		public ResultClass()
		{
			this.ErrorMessage = string.Empty;
			this.ResultCode = eResultCodes.conWS_NotSet;
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;
	}
}