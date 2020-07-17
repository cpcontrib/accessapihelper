using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="DebugMessage", Namespace="http://schemas.datacontract.org/2004/07/CrownPeak.Common.MemoryMap.TemplateDebug")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class DebugMessage : INotifyPropertyChanged
	{
		private string BodyField;

		private DateTime DateField;

		private int PluginIdField;

		private string PluginLangField;

		private string PluginPathField;

		private string TokenField;

		[DataMember]
		public string Body
		{
			get
			{
				return this.BodyField;
			}
			set
			{
				if (!object.ReferenceEquals(this.BodyField, value))
				{
					this.BodyField = value;
					this.RaisePropertyChanged("Body");
				}
			}
		}

		[DataMember]
		public DateTime Date
		{
			get
			{
				return this.DateField;
			}
			set
			{
				if (!this.DateField.Equals(value))
				{
					this.DateField = value;
					this.RaisePropertyChanged("Date");
				}
			}
		}

		[DataMember]
		public int PluginId
		{
			get
			{
				return this.PluginIdField;
			}
			set
			{
				if (!this.PluginIdField.Equals(value))
				{
					this.PluginIdField = value;
					this.RaisePropertyChanged("PluginId");
				}
			}
		}

		[DataMember]
		public string PluginLang
		{
			get
			{
				return this.PluginLangField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PluginLangField, value))
				{
					this.PluginLangField = value;
					this.RaisePropertyChanged("PluginLang");
				}
			}
		}

		[DataMember]
		public string PluginPath
		{
			get
			{
				return this.PluginPathField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PluginPathField, value))
				{
					this.PluginPathField = value;
					this.RaisePropertyChanged("PluginPath");
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
					this.RaisePropertyChanged("Token");
				}
			}
		}

		public DebugMessage()
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