using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract]
	[KnownType(typeof(KeyValuePair<int, ActionData>))]
	[KnownType(typeof(KeyValuePair<string, string>))]
	public class AuthAuthenticateWithCacheResponse : WSResultClass
	{
		[DataMember]
		public UserData user;

		[DataMember]
		public int systemTemplatesPathId;

		[DataMember]
		public int systemModelsPathId;

		[DataMember]
		public int daysToExpire;

		[DataMember]
		public bool needsExpirationWarning;

		[DataMember]
		public int idleTimeoutMinutes;

		[DataMember]
		public int taskCount;

		[DataMember]
		public int workflowTaskCount;

		[DataMember]
		public int tasksFolderId;

		[DataMember]
		public int taskBaseModelId;

		[DataMember]
		public Dictionary<int, ActionData> actions;

		[DataMember]
		public WysiwygEditorType instanceWysiwygEditor;

		[DataMember]
		public List<cpListscpKeyValuePair> uiConfiguration;

		[DataMember]
		public Dictionary<int, WorkflowData> workflowData;

		[DataMember]
		public Dictionary<int, StatusData> statusData;

		[DataMember]
		public List<WCOBeaconSiteData> wcoBeaconSites;

		public AuthAuthenticateWithCacheResponse()
		{
		}

		public AuthAuthenticateWithCacheResponse(AuthenticateResponseWCF result) : base(result)
		{
			this.user = result.user;
			this.systemTemplatesPathId = result.SystemTemplatesPathId;
			this.systemModelsPathId = result.SystemModelsPathId;
			this.daysToExpire = result.DaysToExpire;
			this.needsExpirationWarning = result.NeedsExpirationWarning;
			this.idleTimeoutMinutes = result.IdleTimeoutMinutes;
			this.taskCount = result.TaskCount;
			this.workflowTaskCount = result.WorkflowTaskCount;
			this.tasksFolderId = result.TasksFolderId;
			this.taskBaseModelId = result.TaskBaseModelId;
			this.actions = result.Actions;
			this.instanceWysiwygEditor = result.InstanceWysiwygEditor;
			this.uiConfiguration = result.UIConfiguration.ToList<cpListscpKeyValuePair>();
			this.workflowData = result.WorkflowData;
			this.statusData = result.StatusData;
			this.wcoBeaconSites = result.WCOBeaconSites.ToList<WCOBeaconSiteData>();
		}
	}
}