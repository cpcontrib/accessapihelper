using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="UnBranchRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class UnBranchRequest : INotifyPropertyChanged
	{
		private int assetIdField;

		[DataMember]
		public int assetId
		{
			get
			{
				return this.assetIdField;
			}
			set
			{
				if (!this.assetIdField.Equals(value))
				{
					this.assetIdField = value;
					this.RaisePropertyChanged("assetId");
				}
			}
		}

		public UnBranchRequest()
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