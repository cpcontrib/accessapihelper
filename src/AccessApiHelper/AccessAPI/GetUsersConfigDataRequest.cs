using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetUsersConfigDataRequest", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetUsersConfigDataRequest : INotifyPropertyChanged
	{
		private int CurrentPageField;

		private int? DepartmentIdField;

		private int? GroupIdField;

		private int? LocationIdField;

		private string NameField;

		private string PhoneField;

		private SortHeaderOptionData SortOptionsField;

		private int? TitleIdField;

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
		public int? DepartmentId
		{
			get
			{
				return this.DepartmentIdField;
			}
			set
			{
				if (!this.DepartmentIdField.Equals(value))
				{
					this.DepartmentIdField = value;
					this.RaisePropertyChanged("DepartmentId");
				}
			}
		}

		[DataMember]
		public int? GroupId
		{
			get
			{
				return this.GroupIdField;
			}
			set
			{
				if (!this.GroupIdField.Equals(value))
				{
					this.GroupIdField = value;
					this.RaisePropertyChanged("GroupId");
				}
			}
		}

		[DataMember]
		public int? LocationId
		{
			get
			{
				return this.LocationIdField;
			}
			set
			{
				if (!this.LocationIdField.Equals(value))
				{
					this.LocationIdField = value;
					this.RaisePropertyChanged("LocationId");
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
		public string Phone
		{
			get
			{
				return this.PhoneField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PhoneField, value))
				{
					this.PhoneField = value;
					this.RaisePropertyChanged("Phone");
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
		public int? TitleId
		{
			get
			{
				return this.TitleIdField;
			}
			set
			{
				if (!this.TitleIdField.Equals(value))
				{
					this.TitleIdField = value;
					this.RaisePropertyChanged("TitleId");
				}
			}
		}

		public GetUsersConfigDataRequest()
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