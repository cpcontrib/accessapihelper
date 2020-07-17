using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetGroupsConfigDataRequest", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetGroupsConfigDataRequest : INotifyPropertyChanged
	{
		private int CurrentPageField;

		private string DescriptionField;

		private string NameField;

		private SortHeaderOptionData SortOptionsField;

		private int? UserIdField;

		[DataMember]
		public int CurrentPage
		{
			get
			{
				return this.CurrentPageField;
			}
			set
			{
				if (!this.CurrentPageField.Equals(value))
				{
					this.CurrentPageField = value;
					this.RaisePropertyChanged("CurrentPage");
				}
			}
		}

		[DataMember]
		public string Description
		{
			get
			{
				return this.DescriptionField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DescriptionField, value))
				{
					this.DescriptionField = value;
					this.RaisePropertyChanged("Description");
				}
			}
		}

		[DataMember]
		public string Name
		{
			get
			{
				return this.NameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.NameField, value))
				{
					this.NameField = value;
					this.RaisePropertyChanged("Name");
				}
			}
		}

		[DataMember]
		public SortHeaderOptionData SortOptions
		{
			get
			{
				return this.SortOptionsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SortOptionsField, value))
				{
					this.SortOptionsField = value;
					this.RaisePropertyChanged("SortOptions");
				}
			}
		}

		[DataMember]
		public int? UserId
		{
			get
			{
				return this.UserIdField;
			}
			set
			{
				if (!this.UserIdField.Equals(value))
				{
					this.UserIdField = value;
					this.RaisePropertyChanged("UserId");
				}
			}
		}

		public GetGroupsConfigDataRequest()
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