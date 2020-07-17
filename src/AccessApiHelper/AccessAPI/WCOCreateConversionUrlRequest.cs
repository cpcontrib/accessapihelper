using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="WCOCreateConversionUrlRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class WCOCreateConversionUrlRequest : INotifyPropertyChanged
	{
		private int AssetIdField;

		private ICollection<string> EmailField;

		private string SnippetIdField;

		private string UrlField;

		private string VariantIdField;

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
					this.RaisePropertyChanged("AssetId");
				}
			}
		}

		[DataMember]
		public ICollection<string> Email
		{
			get
			{
				return this.EmailField;
			}
			set
			{
				if (!object.ReferenceEquals(this.EmailField, value))
				{
					this.EmailField = value;
					this.RaisePropertyChanged("Email");
				}
			}
		}

		[DataMember]
		public string SnippetId
		{
			get
			{
				return this.SnippetIdField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SnippetIdField, value))
				{
					this.SnippetIdField = value;
					this.RaisePropertyChanged("SnippetId");
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
					this.RaisePropertyChanged("Url");
				}
			}
		}

		[DataMember]
		public string VariantId
		{
			get
			{
				return this.VariantIdField;
			}
			set
			{
				if (!object.ReferenceEquals(this.VariantIdField, value))
				{
					this.VariantIdField = value;
					this.RaisePropertyChanged("VariantId");
				}
			}
		}

		public WCOCreateConversionUrlRequest()
		{
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;
	}
}