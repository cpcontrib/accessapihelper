using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="ClonePublishingPackageRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class ClonePublishingPackageRequest : INotifyPropertyChanged
	{
		private PublishingServerData dataField;

		private int sourceIdField;

		[DataMember]
		public PublishingServerData data
		{
			get
			{
				return this.dataField;
			}
			set
			{
				if (!object.ReferenceEquals(this.dataField, value))
				{
					this.dataField = value;
					this.RaisePropertyChanged("data");
				}
			}
		}

		[DataMember]
		public int sourceId
		{
			get
			{
				return this.sourceIdField;
			}
			set
			{
				if (!this.sourceIdField.Equals(value))
				{
					this.sourceIdField = value;
					this.RaisePropertyChanged("sourceId");
				}
			}
		}

		public ClonePublishingPackageRequest()
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