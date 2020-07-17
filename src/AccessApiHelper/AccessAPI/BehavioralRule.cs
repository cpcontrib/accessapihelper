using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="BehavioralRule", Namespace="http://schemas.datacontract.org/2004/07/CrownPeak.Omm.Model.Behavioral")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class BehavioralRule : INotifyPropertyChanged
	{
		private string DataField;

		private DateTime DateCreatedField;

		private DateTime DateModifiedField;

		private Guid IdField;

		private string ReferrerField;

		private BehavioralRuleType RuleTypeField;

		private int ThresholdField;

		[DataMember]
		public string Data
		{
			get
			{
				return this.DataField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DataField, value))
				{
					this.DataField = value;
					this.RaisePropertyChanged("Data");
				}
			}
		}

		[DataMember]
		public DateTime DateCreated
		{
			get
			{
				return this.DateCreatedField;
			}
			set
			{
				if (!this.DateCreatedField.Equals(value))
				{
					this.DateCreatedField = value;
					this.RaisePropertyChanged("DateCreated");
				}
			}
		}

		[DataMember]
		public DateTime DateModified
		{
			get
			{
				return this.DateModifiedField;
			}
			set
			{
				if (!this.DateModifiedField.Equals(value))
				{
					this.DateModifiedField = value;
					this.RaisePropertyChanged("DateModified");
				}
			}
		}

		[DataMember]
		public Guid Id
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
		public string Referrer
		{
			get
			{
				return this.ReferrerField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ReferrerField, value))
				{
					this.ReferrerField = value;
					this.RaisePropertyChanged("Referrer");
				}
			}
		}

		[DataMember]
		public BehavioralRuleType RuleType
		{
			get
			{
				return this.RuleTypeField;
			}
			set
			{
				if (!this.RuleTypeField.Equals(value))
				{
					this.RuleTypeField = value;
					this.RaisePropertyChanged("RuleType");
				}
			}
		}

		[DataMember]
		public int Threshold
		{
			get
			{
				return this.ThresholdField;
			}
			set
			{
				if (!this.ThresholdField.Equals(value))
				{
					this.ThresholdField = value;
					this.RaisePropertyChanged("Threshold");
				}
			}
		}

		public BehavioralRule()
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