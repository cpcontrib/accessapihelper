using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="RouteAssetsRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class RouteAssetsRequest : INotifyPropertyChanged
	{
		private ICollection<int> ListField;

		private int StateIdField;

		[DataMember]
		public ICollection<int> List
		{
			get
			{
				return this.ListField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ListField, value))
				{
					this.ListField = value;
					this.RaisePropertyChanged("List");
				}
			}
		}

		[DataMember]
		public int StateId
		{
			get
			{
				return this.StateIdField;
			}
			set
			{
				if (!this.StateIdField.Equals(value))
				{
					this.StateIdField = value;
					this.RaisePropertyChanged("StateId");
				}
			}
		}

		public RouteAssetsRequest()
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