using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="WCOGetVariantCount", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class WCOGetVariantCount : INotifyPropertyChanged
	{
		private ICollection<CountStatSummary> CountsField;

		private Guid VariantIdField;

		private string VariantNameField;

		[DataMember]
		public ICollection<CountStatSummary> Counts
		{
			get
			{
				return this.CountsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.CountsField, value))
				{
					this.CountsField = value;
					this.RaisePropertyChanged("Counts");
				}
			}
		}

		[DataMember]
		public Guid VariantId
		{
			get
			{
				return this.VariantIdField;
			}
			set
			{
				if (!this.VariantIdField.Equals(value))
				{
					this.VariantIdField = value;
					this.RaisePropertyChanged("VariantId");
				}
			}
		}

		[DataMember]
		public string VariantName
		{
			get
			{
				return this.VariantNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.VariantNameField, value))
				{
					this.VariantNameField = value;
					this.RaisePropertyChanged("VariantName");
				}
			}
		}

		public WCOGetVariantCount()
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