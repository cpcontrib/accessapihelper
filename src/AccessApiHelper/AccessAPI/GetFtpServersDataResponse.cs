using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetFtpServersDataResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetFtpServersDataResponse : WSResultClass
	{
		private ICollection<FtpServerData> ftpServersField;

		[DataMember]
		public ICollection<FtpServerData> ftpServers
		{
			get
			{
				return this.ftpServersField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ftpServersField, value))
				{
					this.ftpServersField = value;
					base.RaisePropertyChanged("ftpServers");
				}
			}
		}

		public GetFtpServersDataResponse()
		{
		}
	}
}