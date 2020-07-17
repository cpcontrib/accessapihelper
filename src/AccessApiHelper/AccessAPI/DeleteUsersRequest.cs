using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="DeleteUsersRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class DeleteUsersRequest : INotifyPropertyChanged
	{
		private ICollection<int> IdsField;

		[DataMember]
		public ICollection<int> Ids
		{
			get
			{
				return this.IdsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.IdsField, value))
				{
					this.IdsField = value;
					this.RaisePropertyChanged("Ids");
				}
			}
		}

		public DeleteUsersRequest()
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