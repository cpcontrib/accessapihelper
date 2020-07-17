using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetCPAvatarsResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetCPAvatarsResponse : WSResultClass
	{
		private string avatarUrlField;

		private ICollection<string> avatarsField;

		[DataMember]
		public ICollection<string> avatars
		{
			get
			{
				return this.avatarsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.avatarsField, value))
				{
					this.avatarsField = value;
					base.RaisePropertyChanged("avatars");
				}
			}
		}

		[DataMember]
		public string avatarUrl
		{
			get
			{
				return this.avatarUrlField;
			}
			set
			{
				if (!object.ReferenceEquals(this.avatarUrlField, value))
				{
					this.avatarUrlField = value;
					base.RaisePropertyChanged("avatarUrl");
				}
			}
		}

		public GetCPAvatarsResponse()
		{
		}
	}
}