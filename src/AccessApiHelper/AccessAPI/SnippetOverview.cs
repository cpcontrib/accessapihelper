using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="SnippetOverview", Namespace="http://schemas.datacontract.org/2004/07/CrownPeak.Omm.Model.Response")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class SnippetOverview : INotifyPropertyChanged
	{
		private string ConversionRateField;

		private int ConversionsField;

		private bool HasTargetingVariantField;

		private bool HasTestingVariantField;

		private Guid IdField;

		private string NameField;

		private int ViewsField;

		[DataMember]
		public string ConversionRate
		{
			get
			{
				return this.ConversionRateField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ConversionRateField, value))
				{
					this.ConversionRateField = value;
					this.RaisePropertyChanged("ConversionRate");
				}
			}
		}

		[DataMember]
		public int Conversions
		{
			get
			{
				return this.ConversionsField;
			}
			set
			{
				if (!this.ConversionsField.Equals(value))
				{
					this.ConversionsField = value;
					this.RaisePropertyChanged("Conversions");
				}
			}
		}

		[DataMember]
		public bool HasTargetingVariant
		{
			get
			{
				return this.HasTargetingVariantField;
			}
			set
			{
				if (!this.HasTargetingVariantField.Equals(value))
				{
					this.HasTargetingVariantField = value;
					this.RaisePropertyChanged("HasTargetingVariant");
				}
			}
		}

		[DataMember]
		public bool HasTestingVariant
		{
			get
			{
				return this.HasTestingVariantField;
			}
			set
			{
				if (!this.HasTestingVariantField.Equals(value))
				{
					this.HasTestingVariantField = value;
					this.RaisePropertyChanged("HasTestingVariant");
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
		public int Views
		{
			get
			{
				return this.ViewsField;
			}
			set
			{
				if (!this.ViewsField.Equals(value))
				{
					this.ViewsField = value;
					this.RaisePropertyChanged("Views");
				}
			}
		}

		public SnippetOverview()
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