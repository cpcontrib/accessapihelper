using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetAssetByGoToQueryRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetAssetByGoToQueryRequest : INotifyPropertyChanged
	{
		private string PathURLorIdField;

		[DataMember]
		public string PathURLorId
		{
			get
			{
				return this.PathURLorIdField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PathURLorIdField, value))
				{
					this.PathURLorIdField = value;
					this.RaisePropertyChanged("PathURLorId");
				}
			}
		}

		public GetAssetByGoToQueryRequest()
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