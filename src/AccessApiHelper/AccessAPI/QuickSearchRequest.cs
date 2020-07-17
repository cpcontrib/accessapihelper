using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="QuickSearchRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class QuickSearchRequest : INotifyPropertyChanged
	{
		private AssetObjectType ResponseTypeField;

		private string SearchTermField;

		[DataMember]
		public AssetObjectType ResponseType
		{
			get
			{
				return this.ResponseTypeField;
			}
			set
			{
				if (!this.ResponseTypeField.Equals(value))
				{
					this.ResponseTypeField = value;
					this.RaisePropertyChanged("ResponseType");
				}
			}
		}

		[DataMember]
		public string SearchTerm
		{
			get
			{
				return this.SearchTermField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SearchTermField, value))
				{
					this.SearchTermField = value;
					this.RaisePropertyChanged("SearchTerm");
				}
			}
		}

		public QuickSearchRequest()
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