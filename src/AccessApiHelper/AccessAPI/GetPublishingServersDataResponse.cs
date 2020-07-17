using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetPublishingServersDataResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetPublishingServersDataResponse : WSResultClass
	{
		private ICollection<FtpServerData> ftpServersField;

		private ICollection<HttpServerData> httpServersField;

		private ICollection<OdbcServerData> odbcServersField;

		private ICollection<PublishingServerData> packagesField;

		private ICollection<SmtpServerData> smtpServersField;

		private ICollection<SoapServerData> soapServersField;

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

		[DataMember]
		public ICollection<HttpServerData> httpServers
		{
			get
			{
				return this.httpServersField;
			}
			set
			{
				if (!object.ReferenceEquals(this.httpServersField, value))
				{
					this.httpServersField = value;
					base.RaisePropertyChanged("httpServers");
				}
			}
		}

		[DataMember]
		public ICollection<OdbcServerData> odbcServers
		{
			get
			{
				return this.odbcServersField;
			}
			set
			{
				if (!object.ReferenceEquals(this.odbcServersField, value))
				{
					this.odbcServersField = value;
					base.RaisePropertyChanged("odbcServers");
				}
			}
		}

		[DataMember]
		public ICollection<PublishingServerData> packages
		{
			get
			{
				return this.packagesField;
			}
			set
			{
				if (!object.ReferenceEquals(this.packagesField, value))
				{
					this.packagesField = value;
					base.RaisePropertyChanged("packages");
				}
			}
		}

		[DataMember]
		public ICollection<SmtpServerData> smtpServers
		{
			get
			{
				return this.smtpServersField;
			}
			set
			{
				if (!object.ReferenceEquals(this.smtpServersField, value))
				{
					this.smtpServersField = value;
					base.RaisePropertyChanged("smtpServers");
				}
			}
		}

		[DataMember]
		public ICollection<SoapServerData> soapServers
		{
			get
			{
				return this.soapServersField;
			}
			set
			{
				if (!object.ReferenceEquals(this.soapServersField, value))
				{
					this.soapServersField = value;
					base.RaisePropertyChanged("soapServers");
				}
			}
		}

		public GetPublishingServersDataResponse()
		{
		}
	}
}