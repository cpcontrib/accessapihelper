using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="WorklistAsset", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class WorklistAsset : INotifyPropertyChanged
	{
		private ICollection<int> ApprovedWorkflowFiltersField;

		private string ChangedByField;

		private string CheckedOutByField;

		private string FullPathField;

		private bool HasCSharpInputField;

		private bool HasPeriodicScheduleField;

		private bool HasWorkflowScheduleField;

		private CrownPeak.AccessAPI.IconType IconTypeField;

		private bool IsFlaggedField;

		private bool IsWcoIntegratedField;

		private string PermissionListField;

		private int? TemplateSubTypeField;

		private int? acl_idField;

		private int? base_model_idField;

		private int branchIdField;

		private DateTime? change_dateField;

		private int? change_user_idField;

		private DateTime? checkout_dateField;

		private int? checkout_user_idField;

		private int? child_idField;

		private DateTime? create_dateField;

		private string createdByField;

		private int? creator_user_idField;

		private int? deploy_idField;

		private int error_codeField;

		private string error_msgField;

		private string extensionField;

		private int? folder_idField;

		private int idField;

		private bool isQueuedField;

		private bool? is_deletedField;

		private bool? is_hiddenField;

		private string labelField;

		private string lastPublishedByField;

		private int? model_idField;

		private string modifiedByField;

		private DateTime? modified_dateField;

		private int? modified_user_idField;

		private string ownedByField;

		private int owner_user_idField;

		private DateTime? publish_dateField;

		private int? publish_user_idField;

		private int? sizeField;

		private int? statusField;

		private string statusChangedByField;

		private string statusColorField;

		private string statusNameField;

		private DateTime? status_dateField;

		private int? status_user_idField;

		private int? storage_idField;

		private int? subtypeField;

		private int taskCountField;

		private int? template_idField;

		private string template_labelField;

		private byte template_languageField;

		private byte? typeField;

		private int? version_idField;

		private int? workflow_idField;

		private int? workflow_stepField;

		[DataMember]
		public int? acl_id
		{
			get
			{
				return this.acl_idField;
			}
			set
			{
				if (!this.acl_idField.Equals(value))
				{
					this.acl_idField = value;
					this.RaisePropertyChanged("acl_id");
				}
			}
		}

		[DataMember]
		public ICollection<int> ApprovedWorkflowFilters
		{
			get
			{
				return this.ApprovedWorkflowFiltersField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ApprovedWorkflowFiltersField, value))
				{
					this.ApprovedWorkflowFiltersField = value;
					this.RaisePropertyChanged("ApprovedWorkflowFilters");
				}
			}
		}

		[DataMember]
		public int? base_model_id
		{
			get
			{
				return this.base_model_idField;
			}
			set
			{
				if (!this.base_model_idField.Equals(value))
				{
					this.base_model_idField = value;
					this.RaisePropertyChanged("base_model_id");
				}
			}
		}

		[DataMember]
		public int branchId
		{
			get
			{
				return this.branchIdField;
			}
			set
			{
				if (!this.branchIdField.Equals(value))
				{
					this.branchIdField = value;
					this.RaisePropertyChanged("branchId");
				}
			}
		}

		[DataMember]
		public DateTime? change_date
		{
			get
			{
				return this.change_dateField;
			}
			set
			{
				if (!this.change_dateField.Equals(value))
				{
					this.change_dateField = value;
					this.RaisePropertyChanged("change_date");
				}
			}
		}

		[DataMember]
		public int? change_user_id
		{
			get
			{
				return this.change_user_idField;
			}
			set
			{
				if (!this.change_user_idField.Equals(value))
				{
					this.change_user_idField = value;
					this.RaisePropertyChanged("change_user_id");
				}
			}
		}

		[DataMember]
		public string ChangedBy
		{
			get
			{
				return this.ChangedByField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ChangedByField, value))
				{
					this.ChangedByField = value;
					this.RaisePropertyChanged("ChangedBy");
				}
			}
		}

		[DataMember]
		public string CheckedOutBy
		{
			get
			{
				return this.CheckedOutByField;
			}
			set
			{
				if (!object.ReferenceEquals(this.CheckedOutByField, value))
				{
					this.CheckedOutByField = value;
					this.RaisePropertyChanged("CheckedOutBy");
				}
			}
		}

		[DataMember]
		public DateTime? checkout_date
		{
			get
			{
				return this.checkout_dateField;
			}
			set
			{
				if (!this.checkout_dateField.Equals(value))
				{
					this.checkout_dateField = value;
					this.RaisePropertyChanged("checkout_date");
				}
			}
		}

		[DataMember]
		public int? checkout_user_id
		{
			get
			{
				return this.checkout_user_idField;
			}
			set
			{
				if (!this.checkout_user_idField.Equals(value))
				{
					this.checkout_user_idField = value;
					this.RaisePropertyChanged("checkout_user_id");
				}
			}
		}

		[DataMember]
		public int? child_id
		{
			get
			{
				return this.child_idField;
			}
			set
			{
				if (!this.child_idField.Equals(value))
				{
					this.child_idField = value;
					this.RaisePropertyChanged("child_id");
				}
			}
		}

		[DataMember]
		public DateTime? create_date
		{
			get
			{
				return this.create_dateField;
			}
			set
			{
				if (!this.create_dateField.Equals(value))
				{
					this.create_dateField = value;
					this.RaisePropertyChanged("create_date");
				}
			}
		}

		[DataMember]
		public string createdBy
		{
			get
			{
				return this.createdByField;
			}
			set
			{
				if (!object.ReferenceEquals(this.createdByField, value))
				{
					this.createdByField = value;
					this.RaisePropertyChanged("createdBy");
				}
			}
		}

		[DataMember]
		public int? creator_user_id
		{
			get
			{
				return this.creator_user_idField;
			}
			set
			{
				if (!this.creator_user_idField.Equals(value))
				{
					this.creator_user_idField = value;
					this.RaisePropertyChanged("creator_user_id");
				}
			}
		}

		[DataMember]
		public int? deploy_id
		{
			get
			{
				return this.deploy_idField;
			}
			set
			{
				if (!this.deploy_idField.Equals(value))
				{
					this.deploy_idField = value;
					this.RaisePropertyChanged("deploy_id");
				}
			}
		}

		[DataMember]
		public int error_code
		{
			get
			{
				return this.error_codeField;
			}
			set
			{
				if (!this.error_codeField.Equals(value))
				{
					this.error_codeField = value;
					this.RaisePropertyChanged("error_code");
				}
			}
		}

		[DataMember]
		public string error_msg
		{
			get
			{
				return this.error_msgField;
			}
			set
			{
				if (!object.ReferenceEquals(this.error_msgField, value))
				{
					this.error_msgField = value;
					this.RaisePropertyChanged("error_msg");
				}
			}
		}

		[DataMember]
		public string extension
		{
			get
			{
				return this.extensionField;
			}
			set
			{
				if (!object.ReferenceEquals(this.extensionField, value))
				{
					this.extensionField = value;
					this.RaisePropertyChanged("extension");
				}
			}
		}

		[DataMember]
		public int? folder_id
		{
			get
			{
				return this.folder_idField;
			}
			set
			{
				if (!this.folder_idField.Equals(value))
				{
					this.folder_idField = value;
					this.RaisePropertyChanged("folder_id");
				}
			}
		}

		[DataMember]
		public string FullPath
		{
			get
			{
				return this.FullPathField;
			}
			set
			{
				if (!object.ReferenceEquals(this.FullPathField, value))
				{
					this.FullPathField = value;
					this.RaisePropertyChanged("FullPath");
				}
			}
		}

		[DataMember]
		public bool HasCSharpInput
		{
			get
			{
				return this.HasCSharpInputField;
			}
			set
			{
				if (!this.HasCSharpInputField.Equals(value))
				{
					this.HasCSharpInputField = value;
					this.RaisePropertyChanged("HasCSharpInput");
				}
			}
		}

		[DataMember]
		public bool HasPeriodicSchedule
		{
			get
			{
				return this.HasPeriodicScheduleField;
			}
			set
			{
				if (!this.HasPeriodicScheduleField.Equals(value))
				{
					this.HasPeriodicScheduleField = value;
					this.RaisePropertyChanged("HasPeriodicSchedule");
				}
			}
		}

		[DataMember]
		public bool HasWorkflowSchedule
		{
			get
			{
				return this.HasWorkflowScheduleField;
			}
			set
			{
				if (!this.HasWorkflowScheduleField.Equals(value))
				{
					this.HasWorkflowScheduleField = value;
					this.RaisePropertyChanged("HasWorkflowSchedule");
				}
			}
		}

		[DataMember]
		public CrownPeak.AccessAPI.IconType IconType
		{
			get
			{
				return this.IconTypeField;
			}
			set
			{
				if (!this.IconTypeField.Equals(value))
				{
					this.IconTypeField = value;
					this.RaisePropertyChanged("IconType");
				}
			}
		}

		[DataMember]
		public int id
		{
			get
			{
				return this.idField;
			}
			set
			{
				if (!this.idField.Equals(value))
				{
					this.idField = value;
					this.RaisePropertyChanged("id");
				}
			}
		}

		[DataMember]
		public bool? is_deleted
		{
			get
			{
				return this.is_deletedField;
			}
			set
			{
				if (!this.is_deletedField.Equals(value))
				{
					this.is_deletedField = value;
					this.RaisePropertyChanged("is_deleted");
				}
			}
		}

		[DataMember]
		public bool? is_hidden
		{
			get
			{
				return this.is_hiddenField;
			}
			set
			{
				if (!this.is_hiddenField.Equals(value))
				{
					this.is_hiddenField = value;
					this.RaisePropertyChanged("is_hidden");
				}
			}
		}

		[DataMember]
		public bool IsFlagged
		{
			get
			{
				return this.IsFlaggedField;
			}
			set
			{
				if (!this.IsFlaggedField.Equals(value))
				{
					this.IsFlaggedField = value;
					this.RaisePropertyChanged("IsFlagged");
				}
			}
		}

		[DataMember]
		public bool isQueued
		{
			get
			{
				return this.isQueuedField;
			}
			set
			{
				if (!this.isQueuedField.Equals(value))
				{
					this.isQueuedField = value;
					this.RaisePropertyChanged("isQueued");
				}
			}
		}

		[DataMember]
		public bool IsWcoIntegrated
		{
			get
			{
				return this.IsWcoIntegratedField;
			}
			set
			{
				if (!this.IsWcoIntegratedField.Equals(value))
				{
					this.IsWcoIntegratedField = value;
					this.RaisePropertyChanged("IsWcoIntegrated");
				}
			}
		}

		[DataMember]
		public string label
		{
			get
			{
				return this.labelField;
			}
			set
			{
				if (!object.ReferenceEquals(this.labelField, value))
				{
					this.labelField = value;
					this.RaisePropertyChanged("label");
				}
			}
		}

		[DataMember]
		public string lastPublishedBy
		{
			get
			{
				return this.lastPublishedByField;
			}
			set
			{
				if (!object.ReferenceEquals(this.lastPublishedByField, value))
				{
					this.lastPublishedByField = value;
					this.RaisePropertyChanged("lastPublishedBy");
				}
			}
		}

		[DataMember]
		public int? model_id
		{
			get
			{
				return this.model_idField;
			}
			set
			{
				if (!this.model_idField.Equals(value))
				{
					this.model_idField = value;
					this.RaisePropertyChanged("model_id");
				}
			}
		}

		[DataMember]
		public DateTime? modified_date
		{
			get
			{
				return this.modified_dateField;
			}
			set
			{
				if (!this.modified_dateField.Equals(value))
				{
					this.modified_dateField = value;
					this.RaisePropertyChanged("modified_date");
				}
			}
		}

		[DataMember]
		public int? modified_user_id
		{
			get
			{
				return this.modified_user_idField;
			}
			set
			{
				if (!this.modified_user_idField.Equals(value))
				{
					this.modified_user_idField = value;
					this.RaisePropertyChanged("modified_user_id");
				}
			}
		}

		[DataMember]
		public string modifiedBy
		{
			get
			{
				return this.modifiedByField;
			}
			set
			{
				if (!object.ReferenceEquals(this.modifiedByField, value))
				{
					this.modifiedByField = value;
					this.RaisePropertyChanged("modifiedBy");
				}
			}
		}

		[DataMember]
		public string ownedBy
		{
			get
			{
				return this.ownedByField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ownedByField, value))
				{
					this.ownedByField = value;
					this.RaisePropertyChanged("ownedBy");
				}
			}
		}

		[DataMember]
		public int owner_user_id
		{
			get
			{
				return this.owner_user_idField;
			}
			set
			{
				if (!this.owner_user_idField.Equals(value))
				{
					this.owner_user_idField = value;
					this.RaisePropertyChanged("owner_user_id");
				}
			}
		}

		[DataMember]
		public string PermissionList
		{
			get
			{
				return this.PermissionListField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PermissionListField, value))
				{
					this.PermissionListField = value;
					this.RaisePropertyChanged("PermissionList");
				}
			}
		}

		[DataMember]
		public DateTime? publish_date
		{
			get
			{
				return this.publish_dateField;
			}
			set
			{
				if (!this.publish_dateField.Equals(value))
				{
					this.publish_dateField = value;
					this.RaisePropertyChanged("publish_date");
				}
			}
		}

		[DataMember]
		public int? publish_user_id
		{
			get
			{
				return this.publish_user_idField;
			}
			set
			{
				if (!this.publish_user_idField.Equals(value))
				{
					this.publish_user_idField = value;
					this.RaisePropertyChanged("publish_user_id");
				}
			}
		}

		[DataMember]
		public int? size
		{
			get
			{
				return this.sizeField;
			}
			set
			{
				if (!this.sizeField.Equals(value))
				{
					this.sizeField = value;
					this.RaisePropertyChanged("size");
				}
			}
		}

		[DataMember]
		public int? status
		{
			get
			{
				return this.statusField;
			}
			set
			{
				if (!this.statusField.Equals(value))
				{
					this.statusField = value;
					this.RaisePropertyChanged("status");
				}
			}
		}

		[DataMember]
		public DateTime? status_date
		{
			get
			{
				return this.status_dateField;
			}
			set
			{
				if (!this.status_dateField.Equals(value))
				{
					this.status_dateField = value;
					this.RaisePropertyChanged("status_date");
				}
			}
		}

		[DataMember]
		public int? status_user_id
		{
			get
			{
				return this.status_user_idField;
			}
			set
			{
				if (!this.status_user_idField.Equals(value))
				{
					this.status_user_idField = value;
					this.RaisePropertyChanged("status_user_id");
				}
			}
		}

		[DataMember]
		public string statusChangedBy
		{
			get
			{
				return this.statusChangedByField;
			}
			set
			{
				if (!object.ReferenceEquals(this.statusChangedByField, value))
				{
					this.statusChangedByField = value;
					this.RaisePropertyChanged("statusChangedBy");
				}
			}
		}

		[DataMember]
		public string statusColor
		{
			get
			{
				return this.statusColorField;
			}
			set
			{
				if (!object.ReferenceEquals(this.statusColorField, value))
				{
					this.statusColorField = value;
					this.RaisePropertyChanged("statusColor");
				}
			}
		}

		[DataMember]
		public string statusName
		{
			get
			{
				return this.statusNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.statusNameField, value))
				{
					this.statusNameField = value;
					this.RaisePropertyChanged("statusName");
				}
			}
		}

		[DataMember]
		public int? storage_id
		{
			get
			{
				return this.storage_idField;
			}
			set
			{
				if (!this.storage_idField.Equals(value))
				{
					this.storage_idField = value;
					this.RaisePropertyChanged("storage_id");
				}
			}
		}

		[DataMember]
		public int? subtype
		{
			get
			{
				return this.subtypeField;
			}
			set
			{
				if (!this.subtypeField.Equals(value))
				{
					this.subtypeField = value;
					this.RaisePropertyChanged("subtype");
				}
			}
		}

		[DataMember]
		public int taskCount
		{
			get
			{
				return this.taskCountField;
			}
			set
			{
				if (!this.taskCountField.Equals(value))
				{
					this.taskCountField = value;
					this.RaisePropertyChanged("taskCount");
				}
			}
		}

		[DataMember]
		public int? template_id
		{
			get
			{
				return this.template_idField;
			}
			set
			{
				if (!this.template_idField.Equals(value))
				{
					this.template_idField = value;
					this.RaisePropertyChanged("template_id");
				}
			}
		}

		[DataMember]
		public string template_label
		{
			get
			{
				return this.template_labelField;
			}
			set
			{
				if (!object.ReferenceEquals(this.template_labelField, value))
				{
					this.template_labelField = value;
					this.RaisePropertyChanged("template_label");
				}
			}
		}

		[DataMember]
		public byte template_language
		{
			get
			{
				return this.template_languageField;
			}
			set
			{
				if (!this.template_languageField.Equals(value))
				{
					this.template_languageField = value;
					this.RaisePropertyChanged("template_language");
				}
			}
		}

		[DataMember]
		public int? TemplateSubType
		{
			get
			{
				return this.TemplateSubTypeField;
			}
			set
			{
				if (!this.TemplateSubTypeField.Equals(value))
				{
					this.TemplateSubTypeField = value;
					this.RaisePropertyChanged("TemplateSubType");
				}
			}
		}

		[DataMember]
		public byte? type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				if (!this.typeField.Equals(value))
				{
					this.typeField = value;
					this.RaisePropertyChanged("type");
				}
			}
		}

		[DataMember]
		public int? version_id
		{
			get
			{
				return this.version_idField;
			}
			set
			{
				if (!this.version_idField.Equals(value))
				{
					this.version_idField = value;
					this.RaisePropertyChanged("version_id");
				}
			}
		}

		[DataMember]
		public int? workflow_id
		{
			get
			{
				return this.workflow_idField;
			}
			set
			{
				if (!this.workflow_idField.Equals(value))
				{
					this.workflow_idField = value;
					this.RaisePropertyChanged("workflow_id");
				}
			}
		}

		[DataMember]
		public int? workflow_step
		{
			get
			{
				return this.workflow_stepField;
			}
			set
			{
				if (!this.workflow_stepField.Equals(value))
				{
					this.workflow_stepField = value;
					this.RaisePropertyChanged("workflow_step");
				}
			}
		}

		public WorklistAsset()
		{
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