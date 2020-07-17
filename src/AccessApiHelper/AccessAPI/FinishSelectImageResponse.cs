using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="FinishSelectImageResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class FinishSelectImageResponse : WSResultClass
	{
		private Dictionary<string, string> ContentFieldsField;

		private ICollection<Thumbnail> CreatedThumbnailsField;

		[DataMember]
		public Dictionary<string, string> ContentFields
		{
			get
			{
				return this.ContentFieldsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ContentFieldsField, value))
				{
					this.ContentFieldsField = value;
					base.RaisePropertyChanged("ContentFields");
				}
			}
		}

		[DataMember]
		public ICollection<Thumbnail> CreatedThumbnails
		{
			get
			{
				return this.CreatedThumbnailsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.CreatedThumbnailsField, value))
				{
					this.CreatedThumbnailsField = value;
					base.RaisePropertyChanged("CreatedThumbnails");
				}
			}
		}

		public FinishSelectImageResponse()
		{
		}
	}
}