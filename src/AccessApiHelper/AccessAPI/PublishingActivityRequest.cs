using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="PublishingActivityRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class PublishingActivityRequest : INotifyPropertyChanged
	{
		private Dictionary<int, cpPublishPublishingActivityDetailRequest> sessionDetailDependencyLogListField;

		private ICollection<int> sessionDetailListField;

		private Dictionary<int, cpPublishPublishingActivityDetailRequest> sessionDetailLogListField;

		[DataMember]
		public Dictionary<int, cpPublishPublishingActivityDetailRequest> sessionDetailDependencyLogList
		{
			get
			{
				return this.sessionDetailDependencyLogListField;
			}
			set
			{
				if (!object.ReferenceEquals(this.sessionDetailDependencyLogListField, value))
				{
					this.sessionDetailDependencyLogListField = value;
					this.RaisePropertyChanged("sessionDetailDependencyLogList");
				}
			}
		}

		[DataMember]
		public ICollection<int> sessionDetailList
		{
			get
			{
				return this.sessionDetailListField;
			}
			set
			{
				if (!object.ReferenceEquals(this.sessionDetailListField, value))
				{
					this.sessionDetailListField = value;
					this.RaisePropertyChanged("sessionDetailList");
				}
			}
		}

		[DataMember]
		public Dictionary<int, cpPublishPublishingActivityDetailRequest> sessionDetailLogList
		{
			get
			{
				return this.sessionDetailLogListField;
			}
			set
			{
				if (!object.ReferenceEquals(this.sessionDetailLogListField, value))
				{
					this.sessionDetailLogListField = value;
					this.RaisePropertyChanged("sessionDetailLogList");
				}
			}
		}

		public PublishingActivityRequest()
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