using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="SystemAuditData", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class SystemAuditData : AuditData
	{
		private string ActionField;

		private int ActionIdField;

		private bool AssetIsDeletedField;

		private string DescriptionField;

		[DataMember]
		public string Action
		{
			get
			{
				return this.ActionField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ActionField, value))
				{
					this.ActionField = value;
					base.RaisePropertyChanged("Action");
				}
			}
		}

		[DataMember]
		public int ActionId
		{
			get
			{
				return this.ActionIdField;
			}
			set
			{
				if (!this.ActionIdField.Equals(value))
				{
					this.ActionIdField = value;
					base.RaisePropertyChanged("ActionId");
				}
			}
		}

		[DataMember]
		public bool AssetIsDeleted
		{
			get
			{
				return this.AssetIsDeletedField;
			}
			set
			{
				if (!this.AssetIsDeletedField.Equals(value))
				{
					this.AssetIsDeletedField = value;
					base.RaisePropertyChanged("AssetIsDeleted");
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
					base.RaisePropertyChanged("Description");
				}
			}
		}

		public SystemAuditData()
		{
		}
	}
}