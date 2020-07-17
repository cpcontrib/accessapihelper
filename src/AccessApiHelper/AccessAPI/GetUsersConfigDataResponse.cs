using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetUsersConfigDataResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetUsersConfigDataResponse : WSResultClass
	{
		private ICollection<AssetStatus> assetStatesField;

		private Dictionary<int, string> departmentsField;

		private Dictionary<int, string> groupsField;

		private Dictionary<int, string> locationsField;

		private Dictionary<int, string> titlesField;

		private ICollection<UserData> usersField;

		[DataMember]
		public ICollection<AssetStatus> assetStates
		{
			get
			{
				return this.assetStatesField;
			}
			set
			{
				if (!object.ReferenceEquals(this.assetStatesField, value))
				{
					this.assetStatesField = value;
					base.RaisePropertyChanged("assetStates");
				}
			}
		}

		[DataMember]
		public Dictionary<int, string> departments
		{
			get
			{
				return this.departmentsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.departmentsField, value))
				{
					this.departmentsField = value;
					base.RaisePropertyChanged("departments");
				}
			}
		}

		[DataMember]
		public Dictionary<int, string> groups
		{
			get
			{
				return this.groupsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.groupsField, value))
				{
					this.groupsField = value;
					base.RaisePropertyChanged("groups");
				}
			}
		}

		[DataMember]
		public Dictionary<int, string> locations
		{
			get
			{
				return this.locationsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.locationsField, value))
				{
					this.locationsField = value;
					base.RaisePropertyChanged("locations");
				}
			}
		}

		[DataMember]
		public Dictionary<int, string> titles
		{
			get
			{
				return this.titlesField;
			}
			set
			{
				if (!object.ReferenceEquals(this.titlesField, value))
				{
					this.titlesField = value;
					base.RaisePropertyChanged("titles");
				}
			}
		}

		[DataMember]
		public ICollection<UserData> users
		{
			get
			{
				return this.usersField;
			}
			set
			{
				if (!object.ReferenceEquals(this.usersField, value))
				{
					this.usersField = value;
					base.RaisePropertyChanged("users");
				}
			}
		}

		public GetUsersConfigDataResponse()
		{
		}
	}
}