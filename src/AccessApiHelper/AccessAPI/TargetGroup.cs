using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="TargetGroup", Namespace="http://schemas.datacontract.org/2004/07/CrownPeak.Omm.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class TargetGroup : INotifyPropertyChanged
	{
		private ICollection<BehavioralRule> BehavioralRulesField;

		private DateTime DateCreatedField;

		private Guid IdField;

		private string NameField;

		private Guid OmmIdField;

		private ICollection<Rule> RulesField;

		[DataMember]
		public ICollection<BehavioralRule> BehavioralRules
		{
			get
			{
				return this.BehavioralRulesField;
			}
			set
			{
				if (!object.ReferenceEquals(this.BehavioralRulesField, value))
				{
					this.BehavioralRulesField = value;
					this.RaisePropertyChanged("BehavioralRules");
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
		public string Name
		{
			get
			{
				return this.NameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.NameField, value))
				{
					this.NameField = value;
					this.RaisePropertyChanged("Name");
				}
			}
		}

		[DataMember]
		public Guid OmmId
		{
			get
			{
				return this.OmmIdField;
			}
			set
			{
				if (!this.OmmIdField.Equals(value))
				{
					this.OmmIdField = value;
					this.RaisePropertyChanged("OmmId");
				}
			}
		}

		[DataMember]
		public ICollection<Rule> Rules
		{
			get
			{
				return this.RulesField;
			}
			set
			{
				if (!object.ReferenceEquals(this.RulesField, value))
				{
					this.RulesField = value;
					this.RaisePropertyChanged("Rules");
				}
			}
		}

		public TargetGroup()
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