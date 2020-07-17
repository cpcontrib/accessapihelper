using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="RenameAssetsRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class RenameAssetsRequest : INotifyPropertyChanged
	{
		private ICollection<RenameAssetRequest> RenameListField;

		[DataMember]
		public ICollection<RenameAssetRequest> RenameList
		{
			get
			{
				return this.RenameListField;
			}
			set
			{
				if (!object.ReferenceEquals(this.RenameListField, value))
				{
					this.RenameListField = value;
					this.RaisePropertyChanged("RenameList");
				}
			}
		}

		public RenameAssetsRequest()
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