using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="PreferenceData", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class PreferenceData : INotifyPropertyChanged
	{
		private string CultureField;

		private int DefaultFolderSortField;

		private EditModeType EditModeField;

		private int FolderPageSizeField;

		private MenuShortCutData LastFileOrFolderShortCutField;

		private LoginModeType LoginModeField;

		private ICollection<MenuShortCutData> MenuShortCutsField;

		private bool NotificationErrorDetailField;

		private int NotificationModeField;

		private bool NotifyOnScheduledDowntimeField;

		private bool NotifyOnWorkflowAlertsField;

		private ICollection<int> PreviewStatesField;

		private bool ShowDebugConsoleField;

		private bool ShowRuntimeErrorDetailField;

		private int SkipDependenciesModeField;

		private int StartupFileOrFolderIdField;

		private string StartupFileOrFolderPathField;

		private string TimezoneDaylightOrStandardNameField;

		private string TimezoneDisplayNameField;

		private int TimezoneOffsetMinutesField;

		private WysiwygEditorType WysiwygEditorField;

		[DataMember]
		public string Culture
		{
			get
			{
				return this.CultureField;
			}
			set
			{
				if (!object.ReferenceEquals(this.CultureField, value))
				{
					this.CultureField = value;
					this.RaisePropertyChanged("Culture");
				}
			}
		}

		[DataMember]
		public int DefaultFolderSort
		{
			get
			{
				return this.DefaultFolderSortField;
			}
			set
			{
				if (!this.DefaultFolderSortField.Equals(value))
				{
					this.DefaultFolderSortField = value;
					this.RaisePropertyChanged("DefaultFolderSort");
				}
			}
		}

		[DataMember]
		public EditModeType EditMode
		{
			get
			{
				return this.EditModeField;
			}
			set
			{
				if (!this.EditModeField.Equals(value))
				{
					this.EditModeField = value;
					this.RaisePropertyChanged("EditMode");
				}
			}
		}

		[DataMember]
		public int FolderPageSize
		{
			get
			{
				return this.FolderPageSizeField;
			}
			set
			{
				if (!this.FolderPageSizeField.Equals(value))
				{
					this.FolderPageSizeField = value;
					this.RaisePropertyChanged("FolderPageSize");
				}
			}
		}

		[DataMember]
		public MenuShortCutData LastFileOrFolderShortCut
		{
			get
			{
				return this.LastFileOrFolderShortCutField;
			}
			set
			{
				if (!object.ReferenceEquals(this.LastFileOrFolderShortCutField, value))
				{
					this.LastFileOrFolderShortCutField = value;
					this.RaisePropertyChanged("LastFileOrFolderShortCut");
				}
			}
		}

		[DataMember]
		public LoginModeType LoginMode
		{
			get
			{
				return this.LoginModeField;
			}
			set
			{
				if (!this.LoginModeField.Equals(value))
				{
					this.LoginModeField = value;
					this.RaisePropertyChanged("LoginMode");
				}
			}
		}

		[DataMember]
		public ICollection<MenuShortCutData> MenuShortCuts
		{
			get
			{
				return this.MenuShortCutsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.MenuShortCutsField, value))
				{
					this.MenuShortCutsField = value;
					this.RaisePropertyChanged("MenuShortCuts");
				}
			}
		}

		[DataMember]
		public bool NotificationErrorDetail
		{
			get
			{
				return this.NotificationErrorDetailField;
			}
			set
			{
				if (!this.NotificationErrorDetailField.Equals(value))
				{
					this.NotificationErrorDetailField = value;
					this.RaisePropertyChanged("NotificationErrorDetail");
				}
			}
		}

		[DataMember]
		public int NotificationMode
		{
			get
			{
				return this.NotificationModeField;
			}
			set
			{
				if (!this.NotificationModeField.Equals(value))
				{
					this.NotificationModeField = value;
					this.RaisePropertyChanged("NotificationMode");
				}
			}
		}

		[DataMember]
		public bool NotifyOnScheduledDowntime
		{
			get
			{
				return this.NotifyOnScheduledDowntimeField;
			}
			set
			{
				if (!this.NotifyOnScheduledDowntimeField.Equals(value))
				{
					this.NotifyOnScheduledDowntimeField = value;
					this.RaisePropertyChanged("NotifyOnScheduledDowntime");
				}
			}
		}

		[DataMember]
		public bool NotifyOnWorkflowAlerts
		{
			get
			{
				return this.NotifyOnWorkflowAlertsField;
			}
			set
			{
				if (!this.NotifyOnWorkflowAlertsField.Equals(value))
				{
					this.NotifyOnWorkflowAlertsField = value;
					this.RaisePropertyChanged("NotifyOnWorkflowAlerts");
				}
			}
		}

		[DataMember]
		public ICollection<int> PreviewStates
		{
			get
			{
				return this.PreviewStatesField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PreviewStatesField, value))
				{
					this.PreviewStatesField = value;
					this.RaisePropertyChanged("PreviewStates");
				}
			}
		}

		[DataMember]
		public bool ShowDebugConsole
		{
			get
			{
				return this.ShowDebugConsoleField;
			}
			set
			{
				if (!this.ShowDebugConsoleField.Equals(value))
				{
					this.ShowDebugConsoleField = value;
					this.RaisePropertyChanged("ShowDebugConsole");
				}
			}
		}

		[DataMember]
		public bool ShowRuntimeErrorDetail
		{
			get
			{
				return this.ShowRuntimeErrorDetailField;
			}
			set
			{
				if (!this.ShowRuntimeErrorDetailField.Equals(value))
				{
					this.ShowRuntimeErrorDetailField = value;
					this.RaisePropertyChanged("ShowRuntimeErrorDetail");
				}
			}
		}

		[DataMember]
		public int SkipDependenciesMode
		{
			get
			{
				return this.SkipDependenciesModeField;
			}
			set
			{
				if (!this.SkipDependenciesModeField.Equals(value))
				{
					this.SkipDependenciesModeField = value;
					this.RaisePropertyChanged("SkipDependenciesMode");
				}
			}
		}

		[DataMember]
		public int StartupFileOrFolderId
		{
			get
			{
				return this.StartupFileOrFolderIdField;
			}
			set
			{
				if (!this.StartupFileOrFolderIdField.Equals(value))
				{
					this.StartupFileOrFolderIdField = value;
					this.RaisePropertyChanged("StartupFileOrFolderId");
				}
			}
		}

		[DataMember]
		public string StartupFileOrFolderPath
		{
			get
			{
				return this.StartupFileOrFolderPathField;
			}
			set
			{
				if (!object.ReferenceEquals(this.StartupFileOrFolderPathField, value))
				{
					this.StartupFileOrFolderPathField = value;
					this.RaisePropertyChanged("StartupFileOrFolderPath");
				}
			}
		}

		[DataMember]
		public string TimezoneDaylightOrStandardName
		{
			get
			{
				return this.TimezoneDaylightOrStandardNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TimezoneDaylightOrStandardNameField, value))
				{
					this.TimezoneDaylightOrStandardNameField = value;
					this.RaisePropertyChanged("TimezoneDaylightOrStandardName");
				}
			}
		}

		[DataMember]
		public string TimezoneDisplayName
		{
			get
			{
				return this.TimezoneDisplayNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TimezoneDisplayNameField, value))
				{
					this.TimezoneDisplayNameField = value;
					this.RaisePropertyChanged("TimezoneDisplayName");
				}
			}
		}

		[DataMember]
		public int TimezoneOffsetMinutes
		{
			get
			{
				return this.TimezoneOffsetMinutesField;
			}
			set
			{
				if (!this.TimezoneOffsetMinutesField.Equals(value))
				{
					this.TimezoneOffsetMinutesField = value;
					this.RaisePropertyChanged("TimezoneOffsetMinutes");
				}
			}
		}

		[DataMember]
		public WysiwygEditorType WysiwygEditor
		{
			get
			{
				return this.WysiwygEditorField;
			}
			set
			{
				if (!this.WysiwygEditorField.Equals(value))
				{
					this.WysiwygEditorField = value;
					this.RaisePropertyChanged("WysiwygEditor");
				}
			}
		}

		public PreferenceData()
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