using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="PublishingActivity", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class PublishingActivity : INotifyPropertyChanged
	{
		private PublishingActivityCounts mySessionsField;

		private PublishingActivityCounts otherSessionsField;

		private ICollection<PublishingActivityCounts> sessionDetailsField;

		private ICollection<PublishingSession> sessionsField;

		private PublishingActivityCounts sysSessionsField;

		[DataMember]
		public PublishingActivityCounts mySessions
		{
			get
			{
				return this.mySessionsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.mySessionsField, value))
				{
					this.mySessionsField = value;
					this.RaisePropertyChanged("mySessions");
				}
			}
		}

		[DataMember]
		public PublishingActivityCounts otherSessions
		{
			get
			{
				return this.otherSessionsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.otherSessionsField, value))
				{
					this.otherSessionsField = value;
					this.RaisePropertyChanged("otherSessions");
				}
			}
		}

		[DataMember]
		public ICollection<PublishingActivityCounts> sessionDetails
		{
			get
			{
				return this.sessionDetailsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.sessionDetailsField, value))
				{
					this.sessionDetailsField = value;
					this.RaisePropertyChanged("sessionDetails");
				}
			}
		}

		[DataMember]
		public ICollection<PublishingSession> sessions
		{
			get
			{
				return this.sessionsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.sessionsField, value))
				{
					this.sessionsField = value;
					this.RaisePropertyChanged("sessions");
				}
			}
		}

		[DataMember]
		public PublishingActivityCounts sysSessions
		{
			get
			{
				return this.sysSessionsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.sysSessionsField, value))
				{
					this.sysSessionsField = value;
					this.RaisePropertyChanged("sysSessions");
				}
			}
		}

		public PublishingActivity()
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