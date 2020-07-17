using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="UnlockAssetsRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class UnlockAssetsRequest : INotifyPropertyChanged
	{
		private ICollection<int> AssetIdsField;

		private bool ForcedField;

		[DataMember]
		public ICollection<int> AssetIds
		{
			get
			{
				return this.AssetIdsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AssetIdsField, value))
				{
					this.AssetIdsField = value;
					this.RaisePropertyChanged("AssetIds");
				}
			}
		}

		[DataMember]
		public bool Forced
		{
			get
			{
				return this.ForcedField;
			}
			set
			{
				if (!this.ForcedField.Equals(value))
				{
					this.ForcedField = value;
					this.RaisePropertyChanged("Forced");
				}
			}
		}

		public UnlockAssetsRequest()
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