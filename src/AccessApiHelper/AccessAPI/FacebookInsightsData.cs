using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="FacebookInsightsData", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class FacebookInsightsData : INotifyPropertyChanged
	{
		private string ErrMsgField;

		private string LikesField;

		private string PeopleTalkingField;

		private string ProfileNameField;

		private string RowsField;

		private string TalkingAboutCountField;

		private string TotalReachField;

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
		public string Likes
		{
			get
			{
				return this.LikesField;
			}
			set
			{
				if (!object.ReferenceEquals(this.LikesField, value))
				{
					this.LikesField = value;
					this.RaisePropertyChanged("Likes");
				}
			}
		}

		[DataMember]
		public string PeopleTalking
		{
			get
			{
				return this.PeopleTalkingField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PeopleTalkingField, value))
				{
					this.PeopleTalkingField = value;
					this.RaisePropertyChanged("PeopleTalking");
				}
			}
		}

		[DataMember]
		public string ProfileName
		{
			get
			{
				return this.ProfileNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ProfileNameField, value))
				{
					this.ProfileNameField = value;
					this.RaisePropertyChanged("ProfileName");
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
		public string TalkingAboutCount
		{
			get
			{
				return this.TalkingAboutCountField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TalkingAboutCountField, value))
				{
					this.TalkingAboutCountField = value;
					this.RaisePropertyChanged("TalkingAboutCount");
				}
			}
		}

		[DataMember]
		public string TotalReach
		{
			get
			{
				return this.TotalReachField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TotalReachField, value))
				{
					this.TotalReachField = value;
					this.RaisePropertyChanged("TotalReach");
				}
			}
		}

		public FacebookInsightsData()
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