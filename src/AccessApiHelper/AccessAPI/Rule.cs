using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="Rule", Namespace="http://schemas.datacontract.org/2004/07/CrownPeak.Omm.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class Rule : INotifyPropertyChanged
	{
		private Guid FieldIdField;

		private RuleType OpField;

		private int OrderField;

		private string ValueField;

		[DataMember]
		public Guid FieldId
		{
			get
			{
				return this.FieldIdField;
			}
			set
			{
				if (!this.FieldIdField.Equals(value))
				{
					this.FieldIdField = value;
					this.RaisePropertyChanged("FieldId");
				}
			}
		}

		[DataMember]
		public RuleType Op
		{
			get
			{
				return this.OpField;
			}
			set
			{
				if (!this.OpField.Equals(value))
				{
					this.OpField = value;
					this.RaisePropertyChanged("Op");
				}
			}
		}

		[DataMember]
		public int Order
		{
			get
			{
				return this.OrderField;
			}
			set
			{
				if (!this.OrderField.Equals(value))
				{
					this.OrderField = value;
					this.RaisePropertyChanged("Order");
				}
			}
		}

		[DataMember]
		public string Value
		{
			get
			{
				return this.ValueField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ValueField, value))
				{
					this.ValueField = value;
					this.RaisePropertyChanged("Value");
				}
			}
		}

		public Rule()
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