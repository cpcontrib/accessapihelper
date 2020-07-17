using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="AssetsMeta", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class AssetsMeta : INotifyPropertyChanged
	{
		private int asset_idField;

		private string cvalueField;

		private DateTime? dvalueField;

		private double? fvalueField;

		private int idField;

		private int? ivalueField;

		private string nameField;

		private string valueField;

		[DataMember]
		public int asset_id
		{
			get
			{
				return this.asset_idField;
			}
			set
			{
				if (!this.asset_idField.Equals(value))
				{
					this.asset_idField = value;
					this.RaisePropertyChanged("asset_id");
				}
			}
		}

		[DataMember]
		public string cvalue
		{
			get
			{
				return this.cvalueField;
			}
			set
			{
				if (!object.ReferenceEquals(this.cvalueField, value))
				{
					this.cvalueField = value;
					this.RaisePropertyChanged("cvalue");
				}
			}
		}

		[DataMember]
		public DateTime? dvalue
		{
			get
			{
				return this.dvalueField;
			}
			set
			{
				if (!this.dvalueField.Equals(value))
				{
					this.dvalueField = value;
					this.RaisePropertyChanged("dvalue");
				}
			}
		}

		[DataMember]
		public double? fvalue
		{
			get
			{
				return this.fvalueField;
			}
			set
			{
				if (!this.fvalueField.Equals(value))
				{
					this.fvalueField = value;
					this.RaisePropertyChanged("fvalue");
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
		public int? ivalue
		{
			get
			{
				return this.ivalueField;
			}
			set
			{
				if (!this.ivalueField.Equals(value))
				{
					this.ivalueField = value;
					this.RaisePropertyChanged("ivalue");
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
		public string @value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				if (!object.ReferenceEquals(this.valueField, value))
				{
					this.valueField = value;
					this.RaisePropertyChanged("value");
				}
			}
		}

		public AssetsMeta()
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