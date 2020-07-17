using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="PublishingActivity2", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class PublishingActivity2 : INotifyPropertyChanged
	{
		private bool IsStarvingField;

		private PublishingActivityCounts MySessionsField;

		private PublishingActivityCounts OtherUserSessionsField;

		private ICollection<PublishingActivityCounts> SessionDetailsField;

		private ICollection<PublishingDetailData> SessionPublishingDetailsField;

		private PublishingActivityCounts SystemSessionsField;

		[DataMember]
		public bool IsStarving
		{
			get
			{
				return this.IsStarvingField;
			}
			set
			{
				if (!this.IsStarvingField.Equals(value))
				{
					this.IsStarvingField = value;
					this.RaisePropertyChanged("IsStarving");
				}
			}
		}

		[DataMember]
		public PublishingActivityCounts MySessions
		{
			get
			{
				return this.MySessionsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.MySessionsField, value))
				{
					this.MySessionsField = value;
					this.RaisePropertyChanged("MySessions");
				}
			}
		}

		[DataMember]
		public PublishingActivityCounts OtherUserSessions
		{
			get
			{
				return this.OtherUserSessionsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.OtherUserSessionsField, value))
				{
					this.OtherUserSessionsField = value;
					this.RaisePropertyChanged("OtherUserSessions");
				}
			}
		}

		[DataMember]
		public ICollection<PublishingActivityCounts> SessionDetails
		{
			get
			{
				return this.SessionDetailsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SessionDetailsField, value))
				{
					this.SessionDetailsField = value;
					this.RaisePropertyChanged("SessionDetails");
				}
			}
		}

		[DataMember]
		public ICollection<PublishingDetailData> SessionPublishingDetails
		{
			get
			{
				return this.SessionPublishingDetailsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SessionPublishingDetailsField, value))
				{
					this.SessionPublishingDetailsField = value;
					this.RaisePropertyChanged("SessionPublishingDetails");
				}
			}
		}

		[DataMember]
		public PublishingActivityCounts SystemSessions
		{
			get
			{
				return this.SystemSessionsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SystemSessionsField, value))
				{
					this.SystemSessionsField = value;
					this.RaisePropertyChanged("SystemSessions");
				}
			}
		}

		public PublishingActivity2()
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