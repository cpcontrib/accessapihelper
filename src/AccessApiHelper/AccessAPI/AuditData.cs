using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="AuditData", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[KnownType(typeof(AssetPublishAuditData))]
	[KnownType(typeof(OrphanAuditData))]
	[KnownType(typeof(PublishAuditData))]
	[KnownType(typeof(SystemAuditData))]
	public class AuditData : INotifyPropertyChanged
	{
		private int? AssetIdField;

		private DateTime DateField;

		private string LabelField;

		private string UserField;

		private int UserIdField;

		[DataMember]
		public int? AssetId
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
		public DateTime Date
		{
			get
			{
				return this.DateField;
			}
			set
			{
				if (!this.DateField.Equals(value))
				{
					this.DateField = value;
					this.RaisePropertyChanged("Date");
				}
			}
		}

		[DataMember]
		public string Label
		{
			get
			{
				return this.LabelField;
			}
			set
			{
				if (!object.ReferenceEquals(this.LabelField, value))
				{
					this.LabelField = value;
					this.RaisePropertyChanged("Label");
				}
			}
		}

		[DataMember]
		public string User
		{
			get
			{
				return this.UserField;
			}
			set
			{
				if (!object.ReferenceEquals(this.UserField, value))
				{
					this.UserField = value;
					this.RaisePropertyChanged("User");
				}
			}
		}

		[DataMember]
		public int UserId
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

		public AuditData()
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