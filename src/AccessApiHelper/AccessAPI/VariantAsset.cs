using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="VariantAsset", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class VariantAsset : INotifyPropertyChanged
	{
		private DateTime? dateField;

		private int idField;

		private bool? is_deletedField;

		private bool? is_detachedField;

		private DateTime? modification_dateField;

		private int? modified_user_idField;

		private string nameField;

		private int owner_asset_idField;

		private DateTime? publish_dateField;

		private int? publish_user_idField;

		private string snippet_idField;

		private string targeting_group_idField;

		private int? var_typeField;

		private string variant_idField;

		private int? weightField;

		[DataMember]
		public DateTime? date
		{
			get
			{
				return this.dateField;
			}
			set
			{
				if (!this.dateField.Equals(value))
				{
					this.dateField = value;
					this.RaisePropertyChanged("date");
				}
			}
		}

		[DataMember]
		public int id
		{
			get
			{
				return this.idField;
			}
			set
			{
				if (!this.idField.Equals(value))
				{
					this.idField = value;
					this.RaisePropertyChanged("id");
				}
			}
		}

		[DataMember]
		public bool? is_deleted
		{
			get
			{
				return this.is_deletedField;
			}
			set
			{
				if (!this.is_deletedField.Equals(value))
				{
					this.is_deletedField = value;
					this.RaisePropertyChanged("is_deleted");
				}
			}
		}

		[DataMember]
		public bool? is_detached
		{
			get
			{
				return this.is_detachedField;
			}
			set
			{
				if (!this.is_detachedField.Equals(value))
				{
					this.is_detachedField = value;
					this.RaisePropertyChanged("is_detached");
				}
			}
		}

		[DataMember]
		public DateTime? modification_date
		{
			get
			{
				return this.modification_dateField;
			}
			set
			{
				if (!this.modification_dateField.Equals(value))
				{
					this.modification_dateField = value;
					this.RaisePropertyChanged("modification_date");
				}
			}
		}

		[DataMember]
		public int? modified_user_id
		{
			get
			{
				return this.modified_user_idField;
			}
			set
			{
				if (!this.modified_user_idField.Equals(value))
				{
					this.modified_user_idField = value;
					this.RaisePropertyChanged("modified_user_id");
				}
			}
		}

		[DataMember]
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.nameField, value))
				{
					this.nameField = value;
					this.RaisePropertyChanged("name");
				}
			}
		}

		[DataMember]
		public int owner_asset_id
		{
			get
			{
				return this.owner_asset_idField;
			}
			set
			{
				if (!this.owner_asset_idField.Equals(value))
				{
					this.owner_asset_idField = value;
					this.RaisePropertyChanged("owner_asset_id");
				}
			}
		}

		[DataMember]
		public DateTime? publish_date
		{
			get
			{
				return this.publish_dateField;
			}
			set
			{
				if (!this.publish_dateField.Equals(value))
				{
					this.publish_dateField = value;
					this.RaisePropertyChanged("publish_date");
				}
			}
		}

		[DataMember]
		public int? publish_user_id
		{
			get
			{
				return this.publish_user_idField;
			}
			set
			{
				if (!this.publish_user_idField.Equals(value))
				{
					this.publish_user_idField = value;
					this.RaisePropertyChanged("publish_user_id");
				}
			}
		}

		[DataMember]
		public string snippet_id
		{
			get
			{
				return this.snippet_idField;
			}
			set
			{
				if (!object.ReferenceEquals(this.snippet_idField, value))
				{
					this.snippet_idField = value;
					this.RaisePropertyChanged("snippet_id");
				}
			}
		}

		[DataMember]
		public string targeting_group_id
		{
			get
			{
				return this.targeting_group_idField;
			}
			set
			{
				if (!object.ReferenceEquals(this.targeting_group_idField, value))
				{
					this.targeting_group_idField = value;
					this.RaisePropertyChanged("targeting_group_id");
				}
			}
		}

		[DataMember]
		public int? var_type
		{
			get
			{
				return this.var_typeField;
			}
			set
			{
				if (!this.var_typeField.Equals(value))
				{
					this.var_typeField = value;
					this.RaisePropertyChanged("var_type");
				}
			}
		}

		[DataMember]
		public string variant_id
		{
			get
			{
				return this.variant_idField;
			}
			set
			{
				if (!object.ReferenceEquals(this.variant_idField, value))
				{
					this.variant_idField = value;
					this.RaisePropertyChanged("variant_id");
				}
			}
		}

		[DataMember]
		public int? weight
		{
			get
			{
				return this.weightField;
			}
			set
			{
				if (!this.weightField.Equals(value))
				{
					this.weightField = value;
					this.RaisePropertyChanged("weight");
				}
			}
		}

		public VariantAsset()
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