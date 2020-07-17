using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="AuthenticateResponseWCF", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class AuthenticateResponseWCF : WSResultClass
	{
		private string AccessTokenField;

		private cpAclType AclTypeHolderField;

		private Dictionary<int, ActionData> ActionsField;

		private AssetType AssetTypeHolderField;

		private string DashboardXmlUrlField;

		private int DaysToExpireField;

		private int IdleTimeoutMinutesField;

		private WysiwygEditorType InstanceWysiwygEditorField;

		private bool NeedsExpirationWarningField;

		private Dictionary<int, CrownPeak.AccessAPI.StatusData> StatusDataField;

		private int SystemModelsPathIdField;

		private int SystemTemplatesPathIdField;

		private int TaskBaseModelIdField;

		private int TaskCountField;

		private int TasksFolderIdField;

		private ICollection<cpListscpKeyValuePair> UIConfigurationField;

		private ICollection<WCOBeaconSiteData> WCOBeaconSitesField;

		private Dictionary<int, CrownPeak.AccessAPI.WorkflowData> WorkflowDataField;

		private int WorkflowTaskCountField;

		private UserData userField;

		[DataMember]
		public string AccessToken
		{
			get
			{
				return this.AccessTokenField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AccessTokenField, value))
				{
					this.AccessTokenField = value;
					base.RaisePropertyChanged("AccessToken");
				}
			}
		}

		[DataMember]
		public cpAclType AclTypeHolder
		{
			get
			{
				return this.AclTypeHolderField;
			}
			set
			{
				if (!this.AclTypeHolderField.Equals(value))
				{
					this.AclTypeHolderField = value;
					base.RaisePropertyChanged("AclTypeHolder");
				}
			}
		}

		[DataMember]
		public Dictionary<int, ActionData> Actions
		{
			get
			{
				return this.ActionsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ActionsField, value))
				{
					this.ActionsField = value;
					base.RaisePropertyChanged("Actions");
				}
			}
		}

		[DataMember]
		public AssetType AssetTypeHolder
		{
			get
			{
				return this.AssetTypeHolderField;
			}
			set
			{
				if (!this.AssetTypeHolderField.Equals(value))
				{
					this.AssetTypeHolderField = value;
					base.RaisePropertyChanged("AssetTypeHolder");
				}
			}
		}

		[DataMember]
		public string DashboardXmlUrl
		{
			get
			{
				return this.DashboardXmlUrlField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DashboardXmlUrlField, value))
				{
					this.DashboardXmlUrlField = value;
					base.RaisePropertyChanged("DashboardXmlUrl");
				}
			}
		}

		[DataMember]
		public int DaysToExpire
		{
			get
			{
				return this.DaysToExpireField;
			}
			set
			{
				if (!this.DaysToExpireField.Equals(value))
				{
					this.DaysToExpireField = value;
					base.RaisePropertyChanged("DaysToExpire");
				}
			}
		}

		[DataMember]
		public int IdleTimeoutMinutes
		{
			get
			{
				return this.IdleTimeoutMinutesField;
			}
			set
			{
				if (!this.IdleTimeoutMinutesField.Equals(value))
				{
					this.IdleTimeoutMinutesField = value;
					base.RaisePropertyChanged("IdleTimeoutMinutes");
				}
			}
		}

		[DataMember]
		public WysiwygEditorType InstanceWysiwygEditor
		{
			get
			{
				return this.InstanceWysiwygEditorField;
			}
			set
			{
				if (!this.InstanceWysiwygEditorField.Equals(value))
				{
					this.InstanceWysiwygEditorField = value;
					base.RaisePropertyChanged("InstanceWysiwygEditor");
				}
			}
		}

		[DataMember]
		public bool NeedsExpirationWarning
		{
			get
			{
				return this.NeedsExpirationWarningField;
			}
			set
			{
				if (!this.NeedsExpirationWarningField.Equals(value))
				{
					this.NeedsExpirationWarningField = value;
					base.RaisePropertyChanged("NeedsExpirationWarning");
				}
			}
		}

		[DataMember]
		public Dictionary<int, CrownPeak.AccessAPI.StatusData> StatusData
		{
			get
			{
				return this.StatusDataField;
			}
			set
			{
				if (!object.ReferenceEquals(this.StatusDataField, value))
				{
					this.StatusDataField = value;
					base.RaisePropertyChanged("StatusData");
				}
			}
		}

		[DataMember]
		public int SystemModelsPathId
		{
			get
			{
				return this.SystemModelsPathIdField;
			}
			set
			{
				if (!this.SystemModelsPathIdField.Equals(value))
				{
					this.SystemModelsPathIdField = value;
					base.RaisePropertyChanged("SystemModelsPathId");
				}
			}
		}

		[DataMember]
		public int SystemTemplatesPathId
		{
			get
			{
				return this.SystemTemplatesPathIdField;
			}
			set
			{
				if (!this.SystemTemplatesPathIdField.Equals(value))
				{
					this.SystemTemplatesPathIdField = value;
					base.RaisePropertyChanged("SystemTemplatesPathId");
				}
			}
		}

		[DataMember]
		public int TaskBaseModelId
		{
			get
			{
				return this.TaskBaseModelIdField;
			}
			set
			{
				if (!this.TaskBaseModelIdField.Equals(value))
				{
					this.TaskBaseModelIdField = value;
					base.RaisePropertyChanged("TaskBaseModelId");
				}
			}
		}

		[DataMember]
		public int TaskCount
		{
			get
			{
				return this.TaskCountField;
			}
			set
			{
				if (!this.TaskCountField.Equals(value))
				{
					this.TaskCountField = value;
					base.RaisePropertyChanged("TaskCount");
				}
			}
		}

		[DataMember]
		public int TasksFolderId
		{
			get
			{
				return this.TasksFolderIdField;
			}
			set
			{
				if (!this.TasksFolderIdField.Equals(value))
				{
					this.TasksFolderIdField = value;
					base.RaisePropertyChanged("TasksFolderId");
				}
			}
		}

		[DataMember]
		public ICollection<cpListscpKeyValuePair> UIConfiguration
		{
			get
			{
				return this.UIConfigurationField;
			}
			set
			{
				if (!object.ReferenceEquals(this.UIConfigurationField, value))
				{
					this.UIConfigurationField = value;
					base.RaisePropertyChanged("UIConfiguration");
				}
			}
		}

		[DataMember]
		public UserData user
		{
			get
			{
				return this.userField;
			}
			set
			{
				if (!object.ReferenceEquals(this.userField, value))
				{
					this.userField = value;
					base.RaisePropertyChanged("user");
				}
			}
		}

		[DataMember]
		public ICollection<WCOBeaconSiteData> WCOBeaconSites
		{
			get
			{
				return this.WCOBeaconSitesField;
			}
			set
			{
				if (!object.ReferenceEquals(this.WCOBeaconSitesField, value))
				{
					this.WCOBeaconSitesField = value;
					base.RaisePropertyChanged("WCOBeaconSites");
				}
			}
		}

		[DataMember]
		public Dictionary<int, CrownPeak.AccessAPI.WorkflowData> WorkflowData
		{
			get
			{
				return this.WorkflowDataField;
			}
			set
			{
				if (!object.ReferenceEquals(this.WorkflowDataField, value))
				{
					this.WorkflowDataField = value;
					base.RaisePropertyChanged("WorkflowData");
				}
			}
		}

		[DataMember]
		public int WorkflowTaskCount
		{
			get
			{
				return this.WorkflowTaskCountField;
			}
			set
			{
				if (!this.WorkflowTaskCountField.Equals(value))
				{
					this.WorkflowTaskCountField = value;
					base.RaisePropertyChanged("WorkflowTaskCount");
				}
			}
		}

		public AuthenticateResponseWCF()
		{
		}
	}
}