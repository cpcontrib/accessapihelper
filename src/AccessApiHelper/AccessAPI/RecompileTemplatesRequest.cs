using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="RecompileTemplatesRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class RecompileTemplatesRequest : INotifyPropertyChanged
	{
		private int AssetIdField;

		private CrownPeak.AccessAPI.RecompileType RecompileTypeField;

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
		public CrownPeak.AccessAPI.RecompileType RecompileType
		{
			get
			{
				return this.RecompileTypeField;
			}
			set
			{
				if (!this.RecompileTypeField.Equals(value))
				{
					this.RecompileTypeField = value;
					this.RaisePropertyChanged("RecompileType");
				}
			}
		}

		public RecompileTemplatesRequest()
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