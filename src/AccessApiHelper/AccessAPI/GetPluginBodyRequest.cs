using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetPluginBodyRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetPluginBodyRequest : INotifyPropertyChanged
	{
		private int assetIdField;

		private bool checkoutField;

		private int fieldField;

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

		[DataMember]
		public bool checkout
		{
			get
			{
				return this.checkoutField;
			}
			set
			{
				if (!this.checkoutField.Equals(value))
				{
					this.checkoutField = value;
					this.RaisePropertyChanged("checkout");
				}
			}
		}

		[DataMember]
		public int field
		{
			get
			{
				return this.fieldField;
			}
			set
			{
				if (!this.fieldField.Equals(value))
				{
					this.fieldField = value;
					this.RaisePropertyChanged("field");
				}
			}
		}

		public GetPluginBodyRequest()
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