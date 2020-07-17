using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="WCOGetOutputUrlResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class WCOGetOutputUrlResponse : WSResultClass
	{
		private int AssetIdField;

		private bool IsOutputWebCaptureCompleteField;

		private string UrlField;

		[DataMember]
		public int AssetId
		{
			get
			{
				return this.AssetIdField;
			}
			set
			{
				if (!this.AssetIdField.Equals(value))
				{
					this.AssetIdField = value;
					base.RaisePropertyChanged("AssetId");
				}
			}
		}

		[DataMember]
		public bool IsOutputWebCaptureComplete
		{
			get
			{
				return this.IsOutputWebCaptureCompleteField;
			}
			set
			{
				if (!this.IsOutputWebCaptureCompleteField.Equals(value))
				{
					this.IsOutputWebCaptureCompleteField = value;
					base.RaisePropertyChanged("IsOutputWebCaptureComplete");
				}
			}
		}

		[DataMember]
		public string Url
		{
			get
			{
				return this.UrlField;
			}
			set
			{
				if (!object.ReferenceEquals(this.UrlField, value))
				{
					this.UrlField = value;
					base.RaisePropertyChanged("Url");
				}
			}
		}

		public WCOGetOutputUrlResponse()
		{
		}
	}
}