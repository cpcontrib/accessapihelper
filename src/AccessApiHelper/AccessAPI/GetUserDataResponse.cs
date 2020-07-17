using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetUserDataResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetUserDataResponse : WSResultClass
	{
		private ICollection<AssetStatus> assetStatesField;

		private UserData userField;

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
		public UserData user
		{
			get
			{
				return this.userField;
			}
			set
			{
				if (!object.ReferenceEquals(this.userField, value))
				{
					this.userField = value;
					base.RaisePropertyChanged("user");
				}
			}
		}

		public GetUserDataResponse()
		{
		}
	}
}