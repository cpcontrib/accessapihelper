using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="ExecuteWorkflowCommandRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class ExecuteWorkflowCommandRequest : INotifyPropertyChanged
	{
		private int AssetIdField;

		private int CommandIdField;

		private bool SkipDependenciesField;

		[DataMember]
		public int AssetId
		{
			get
			{
				return this.AssetIdField;
			}
			set
			{
				if (!this.AssetIdField.Equals(value))
				{
					this.AssetIdField = value;
					this.RaisePropertyChanged("AssetId");
				}
			}
		}

		[DataMember]
		public int CommandId
		{
			get
			{
				return this.CommandIdField;
			}
			set
			{
				if (!this.CommandIdField.Equals(value))
				{
					this.CommandIdField = value;
					this.RaisePropertyChanged("CommandId");
				}
			}
		}

		[DataMember]
		public bool SkipDependencies
		{
			get
			{
				return this.SkipDependenciesField;
			}
			set
			{
				if (!this.SkipDependenciesField.Equals(value))
				{
					this.SkipDependenciesField = value;
					this.RaisePropertyChanged("SkipDependencies");
				}
			}
		}

		public ExecuteWorkflowCommandRequest()
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