using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GoogleAnalyticsData", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GoogleAnalyticsData : INotifyPropertyChanged
	{
		private string AvgTimeOnPageField;

		private string BounceRateField;

		private string ErrMsgField;

		private string PageViewsField;

		private string RowsField;

		private string TimeField;

		private string VisitsField;

		[DataMember]
		public string AvgTimeOnPage
		{
			get
			{
				return this.AvgTimeOnPageField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AvgTimeOnPageField, value))
				{
					this.AvgTimeOnPageField = value;
					this.RaisePropertyChanged("AvgTimeOnPage");
				}
			}
		}

		[DataMember]
		public string BounceRate
		{
			get
			{
				return this.BounceRateField;
			}
			set
			{
				if (!object.ReferenceEquals(this.BounceRateField, value))
				{
					this.BounceRateField = value;
					this.RaisePropertyChanged("BounceRate");
				}
			}
		}

		[DataMember]
		public string ErrMsg
		{
			get
			{
				return this.ErrMsgField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ErrMsgField, value))
				{
					this.ErrMsgField = value;
					this.RaisePropertyChanged("ErrMsg");
				}
			}
		}

		[DataMember]
		public string PageViews
		{
			get
			{
				return this.PageViewsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PageViewsField, value))
				{
					this.PageViewsField = value;
					this.RaisePropertyChanged("PageViews");
				}
			}
		}

		[DataMember]
		public string Rows
		{
			get
			{
				return this.RowsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.RowsField, value))
				{
					this.RowsField = value;
					this.RaisePropertyChanged("Rows");
				}
			}
		}

		[DataMember]
		public string Time
		{
			get
			{
				return this.TimeField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TimeField, value))
				{
					this.TimeField = value;
					this.RaisePropertyChanged("Time");
				}
			}
		}

		[DataMember]
		public string Visits
		{
			get
			{
				return this.VisitsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.VisitsField, value))
				{
					this.VisitsField = value;
					this.RaisePropertyChanged("Visits");
				}
			}
		}

		public GoogleAnalyticsData()
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