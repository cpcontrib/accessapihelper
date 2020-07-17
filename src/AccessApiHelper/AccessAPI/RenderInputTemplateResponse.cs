using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="RenderInputTemplateResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class RenderInputTemplateResponse : WSResultClass
	{
		private Dictionary<string, string> FieldsField;

		private byte[] UIField;

		private byte[] UIWyswiwygConfigField;

		private string UncompressedUIField;

		private bool UseCompressionField;

		[DataMember]
		public Dictionary<string, string> Fields
		{
			get
			{
				return this.FieldsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.FieldsField, value))
				{
					this.FieldsField = value;
					base.RaisePropertyChanged("Fields");
				}
			}
		}

		[DataMember]
		public byte[] UI
		{
			get
			{
				return this.UIField;
			}
			set
			{
				if (!object.ReferenceEquals(this.UIField, value))
				{
					this.UIField = value;
					base.RaisePropertyChanged("UI");
				}
			}
		}

		[DataMember]
		public byte[] UIWyswiwygConfig
		{
			get
			{
				return this.UIWyswiwygConfigField;
			}
			set
			{
				if (!object.ReferenceEquals(this.UIWyswiwygConfigField, value))
				{
					this.UIWyswiwygConfigField = value;
					base.RaisePropertyChanged("UIWyswiwygConfig");
				}
			}
		}

		[DataMember]
		public string UncompressedUI
		{
			get
			{
				return this.UncompressedUIField;
			}
			set
			{
				if (!object.ReferenceEquals(this.UncompressedUIField, value))
				{
					this.UncompressedUIField = value;
					base.RaisePropertyChanged("UncompressedUI");
				}
			}
		}

		[DataMember]
		public bool UseCompression
		{
			get
			{
				return this.UseCompressionField;
			}
			set
			{
				if (!this.UseCompressionField.Equals(value))
				{
					this.UseCompressionField = value;
					base.RaisePropertyChanged("UseCompression");
				}
			}
		}

		public RenderInputTemplateResponse()
		{
		}
	}
}