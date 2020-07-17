using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="SetSystemVariablesDataRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class SetSystemVariablesDataRequest : INotifyPropertyChanged
	{
		private ICollection<SystemVariableData> SystemVariablesField;

		[DataMember]
		public ICollection<SystemVariableData> SystemVariables
		{
			get
			{
				return this.SystemVariablesField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SystemVariablesField, value))
				{
					this.SystemVariablesField = value;
					this.RaisePropertyChanged("SystemVariables");
				}
			}
		}

		public SetSystemVariablesDataRequest()
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