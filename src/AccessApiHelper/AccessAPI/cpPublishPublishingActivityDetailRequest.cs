using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="cpPublish.PublishingActivityDetailRequest", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class cpPublishPublishingActivityDetailRequest : INotifyPropertyChanged
	{
		private bool DisplayErrorsOnlyField;

		private cpPublishPublishingActivityRequestSourceType requestSourceTypeField;

		private cpPublishPublishingActivityDetailRequestType requestTypeField;

		private int row_idField;

		[DataMember]
		public bool DisplayErrorsOnly
		{
			get
			{
				return this.DisplayErrorsOnlyField;
			}
			set
			{
				if (!this.DisplayErrorsOnlyField.Equals(value))
				{
					this.DisplayErrorsOnlyField = value;
					this.RaisePropertyChanged("DisplayErrorsOnly");
				}
			}
		}

		[DataMember]
		public cpPublishPublishingActivityRequestSourceType requestSourceType
		{
			get
			{
				return this.requestSourceTypeField;
			}
			set
			{
				if (!this.requestSourceTypeField.Equals(value))
				{
					this.requestSourceTypeField = value;
					this.RaisePropertyChanged("requestSourceType");
				}
			}
		}

		[DataMember]
		public cpPublishPublishingActivityDetailRequestType requestType
		{
			get
			{
				return this.requestTypeField;
			}
			set
			{
				if (!this.requestTypeField.Equals(value))
				{
					this.requestTypeField = value;
					this.RaisePropertyChanged("requestType");
				}
			}
		}

		[DataMember]
		public int row_id
		{
			get
			{
				return this.row_idField;
			}
			set
			{
				if (!this.row_idField.Equals(value))
				{
					this.row_idField = value;
					this.RaisePropertyChanged("row_id");
				}
			}
		}

		public cpPublishPublishingActivityDetailRequest()
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