using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="PrepareUploadAssetRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class PrepareUploadAssetRequest : INotifyPropertyChanged
	{
		private string DesiredFilenameField;

		private int DestinationIdField;

		private int? ModelIdField;

		private int TotalSizeField;

		[DataMember]
		public string DesiredFilename
		{
			get
			{
				return this.DesiredFilenameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DesiredFilenameField, value))
				{
					this.DesiredFilenameField = value;
					this.RaisePropertyChanged("DesiredFilename");
				}
			}
		}

		[DataMember]
		public int DestinationId
		{
			get
			{
				return this.DestinationIdField;
			}
			set
			{
				if (!this.DestinationIdField.Equals(value))
				{
					this.DestinationIdField = value;
					this.RaisePropertyChanged("DestinationId");
				}
			}
		}

		[DataMember]
		public int? ModelId
		{
			get
			{
				return this.ModelIdField;
			}
			set
			{
				if (!this.ModelIdField.Equals(value))
				{
					this.ModelIdField = value;
					this.RaisePropertyChanged("ModelId");
				}
			}
		}

		[DataMember]
		public int TotalSize
		{
			get
			{
				return this.TotalSizeField;
			}
			set
			{
				if (!this.TotalSizeField.Equals(value))
				{
					this.TotalSizeField = value;
					this.RaisePropertyChanged("TotalSize");
				}
			}
		}

		public PrepareUploadAssetRequest()
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