using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="PrepareUploadResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class PrepareUploadResponse : WSResultClass
	{
		private int MaxUploadLimitField;

		private string TokenField;

		private string UploadTicketField;

		[DataMember]
		public int MaxUploadLimit
		{
			get
			{
				return this.MaxUploadLimitField;
			}
			set
			{
				if (!this.MaxUploadLimitField.Equals(value))
				{
					this.MaxUploadLimitField = value;
					base.RaisePropertyChanged("MaxUploadLimit");
				}
			}
		}

		[DataMember]
		public string Token
		{
			get
			{
				return this.TokenField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TokenField, value))
				{
					this.TokenField = value;
					base.RaisePropertyChanged("Token");
				}
			}
		}

		[DataMember]
		public string UploadTicket
		{
			get
			{
				return this.UploadTicketField;
			}
			set
			{
				if (!object.ReferenceEquals(this.UploadTicketField, value))
				{
					this.UploadTicketField = value;
					base.RaisePropertyChanged("UploadTicket");
				}
			}
		}

		public PrepareUploadResponse()
		{
		}
	}
}