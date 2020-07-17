using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="PublishPath", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class PublishPath : PublishInfo
	{
		private string AssetPathField;

		private string ErrorMessageField;

		private string IdPathField;

		[DataMember]
		public string AssetPath
		{
			get
			{
				return this.AssetPathField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AssetPathField, value))
				{
					this.AssetPathField = value;
					base.RaisePropertyChanged("AssetPath");
				}
			}
		}

		[DataMember]
		public string ErrorMessage
		{
			get
			{
				return this.ErrorMessageField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ErrorMessageField, value))
				{
					this.ErrorMessageField = value;
					base.RaisePropertyChanged("ErrorMessage");
				}
			}
		}

		[DataMember]
		public string IdPath
		{
			get
			{
				return this.IdPathField;
			}
			set
			{
				if (!object.ReferenceEquals(this.IdPathField, value))
				{
					this.IdPathField = value;
					base.RaisePropertyChanged("IdPath");
				}
			}
		}

		public PublishPath()
		{
		}
	}
}