using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="DiagnosticsErrorData", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class DiagnosticsErrorData : INotifyPropertyChanged
	{
		private int? AssetIdField;

		private int ColumnNumberField;

		private cpDiagnosticsErrorerrorCodes ErrorCodeField;

		private int ErrorStateField;

		private int LineNumberField;

		private string PathField;

		[DataMember]
		public int? AssetId
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
		public int ColumnNumber
		{
			get
			{
				return this.ColumnNumberField;
			}
			set
			{
				if (!this.ColumnNumberField.Equals(value))
				{
					this.ColumnNumberField = value;
					this.RaisePropertyChanged("ColumnNumber");
				}
			}
		}

		[DataMember]
		public cpDiagnosticsErrorerrorCodes ErrorCode
		{
			get
			{
				return this.ErrorCodeField;
			}
			set
			{
				if (!this.ErrorCodeField.Equals(value))
				{
					this.ErrorCodeField = value;
					this.RaisePropertyChanged("ErrorCode");
				}
			}
		}

		[DataMember]
		public int ErrorState
		{
			get
			{
				return this.ErrorStateField;
			}
			set
			{
				if (!this.ErrorStateField.Equals(value))
				{
					this.ErrorStateField = value;
					this.RaisePropertyChanged("ErrorState");
				}
			}
		}

		[DataMember]
		public int LineNumber
		{
			get
			{
				return this.LineNumberField;
			}
			set
			{
				if (!this.LineNumberField.Equals(value))
				{
					this.LineNumberField = value;
					this.RaisePropertyChanged("LineNumber");
				}
			}
		}

		[DataMember]
		public string Path
		{
			get
			{
				return this.PathField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PathField, value))
				{
					this.PathField = value;
					this.RaisePropertyChanged("Path");
				}
			}
		}

		public DiagnosticsErrorData()
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