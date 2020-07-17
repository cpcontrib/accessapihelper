using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="JobActivity", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class JobActivity : INotifyPropertyChanged
	{
		private ICollection<JobData> MyJobsField;

		private ICollection<JobData> OtherUserJobsField;

		private ICollection<JobData> SystemJobsField;

		[DataMember]
		public ICollection<JobData> MyJobs
		{
			get
			{
				return this.MyJobsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.MyJobsField, value))
				{
					this.MyJobsField = value;
					this.RaisePropertyChanged("MyJobs");
				}
			}
		}

		[DataMember]
		public ICollection<JobData> OtherUserJobs
		{
			get
			{
				return this.OtherUserJobsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.OtherUserJobsField, value))
				{
					this.OtherUserJobsField = value;
					this.RaisePropertyChanged("OtherUserJobs");
				}
			}
		}

		[DataMember]
		public ICollection<JobData> SystemJobs
		{
			get
			{
				return this.SystemJobsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SystemJobsField, value))
				{
					this.SystemJobsField = value;
					this.RaisePropertyChanged("SystemJobs");
				}
			}
		}

		public JobActivity()
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