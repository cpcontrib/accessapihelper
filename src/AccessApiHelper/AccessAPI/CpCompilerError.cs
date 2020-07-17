using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="CpCompilerError", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class CpCompilerError : INotifyPropertyChanged
	{
		private int AssetIdField;

		private string AssetPathField;

		private string ErrorMessageField;

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
					this.RaisePropertyChanged("AssetPath");
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
					this.RaisePropertyChanged("ErrorMessage");
				}
			}
		}

		public CpCompilerError()
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