using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetPublishingServersResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetPublishingServersResponse : WSResultClass
	{
		private ICollection<PublishingServer> ServersField;

		[DataMember]
		public ICollection<PublishingServer> Servers
		{
			get
			{
				return this.ServersField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ServersField, value))
				{
					this.ServersField = value;
					base.RaisePropertyChanged("Servers");
				}
			}
		}

		public GetPublishingServersResponse()
		{
		}
	}
}