using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="JobItem", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[KnownType(typeof(JobData))]
	public class JobItem : INotifyPropertyChanged
	{
		private int CountField;

		private DateTime DateField;

		private int ErrorsField;

		private int IdField;

		private bool IsActiveField;

		private bool IsCancelledField;

		private bool IsSuccessfulField;

		private CrownPeak.AccessAPI.JobType JobTypeField;

		private string PayloadField;

		private int? ResultCodeField;

		private JobState StateField;

		private DateTime StateChangedField;

		private int TotalField;

		[DataMember]
		public int Count
		{
			get
			{
				return this.CountField;
			}
			set
			{
				if (!this.CountField.Equals(value))
				{
					this.CountField = value;
					this.RaisePropertyChanged("Count");
				}
			}
		}

		[DataMember]
		public DateTime Date
		{
			get
			{
				return this.DateField;
			}
			set
			{
				if (!this.DateField.Equals(value))
				{
					this.DateField = value;
					this.RaisePropertyChanged("Date");
				}
			}
		}

		[DataMember]
		public int Errors
		{
			get
			{
				return this.ErrorsField;
			}
			set
			{
				if (!this.ErrorsField.Equals(value))
				{
					this.ErrorsField = value;
					this.RaisePropertyChanged("Errors");
				}
			}
		}

		[DataMember]
		public int Id
		{
			get
			{
				return this.IdField;
			}
			set
			{
				if (!this.IdField.Equals(value))
				{
					this.IdField = value;
					this.RaisePropertyChanged("Id");
				}
			}
		}

		[DataMember]
		public bool IsActive
		{
			get
			{
				return this.IsActiveField;
			}
			set
			{
				if (!this.IsActiveField.Equals(value))
				{
					this.IsActiveField = value;
					this.RaisePropertyChanged("IsActive");
				}
			}
		}

		[DataMember]
		public bool IsCancelled
		{
			get
			{
				return this.IsCancelledField;
			}
			set
			{
				if (!this.IsCancelledField.Equals(value))
				{
					this.IsCancelledField = value;
					this.RaisePropertyChanged("IsCancelled");
				}
			}
		}

		[DataMember]
		public bool IsSuccessful
		{
			get
			{
				return this.IsSuccessfulField;
			}
			set
			{
				if (!this.IsSuccessfulField.Equals(value))
				{
					this.IsSuccessfulField = value;
					this.RaisePropertyChanged("IsSuccessful");
				}
			}
		}

		[DataMember]
		public CrownPeak.AccessAPI.JobType JobType
		{
			get
			{
				return this.JobTypeField;
			}
			set
			{
				if (!this.JobTypeField.Equals(value))
				{
					this.JobTypeField = value;
					this.RaisePropertyChanged("JobType");
				}
			}
		}

		[DataMember]
		public string Payload
		{
			get
			{
				return this.PayloadField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PayloadField, value))
				{
					this.PayloadField = value;
					this.RaisePropertyChanged("Payload");
				}
			}
		}

		[DataMember]
		public int? ResultCode
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

		[DataMember]
		public JobState State
		{
			get
			{
				return this.StateField;
			}
			set
			{
				if (!this.StateField.Equals(value))
				{
					this.StateField = value;
					this.RaisePropertyChanged("State");
				}
			}
		}

		[DataMember]
		public DateTime StateChanged
		{
			get
			{
				return this.StateChangedField;
			}
			set
			{
				if (!this.StateChangedField.Equals(value))
				{
					this.StateChangedField = value;
					this.RaisePropertyChanged("StateChanged");
				}
			}
		}

		[DataMember]
		public int Total
		{
			get
			{
				return this.TotalField;
			}
			set
			{
				if (!this.TotalField.Equals(value))
				{
					this.TotalField = value;
					this.RaisePropertyChanged("Total");
				}
			}
		}

		public JobItem()
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