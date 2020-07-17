using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="DownloadResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class DownloadResponse : WSResultClass
	{
		private byte[] BufferField;

		private byte[] CheckSumField;

		private bool IsDoneField;

		private double ProgressField;

		[DataMember]
		public byte[] Buffer
		{
			get
			{
				return this.BufferField;
			}
			set
			{
				if (!object.ReferenceEquals(this.BufferField, value))
				{
					this.BufferField = value;
					base.RaisePropertyChanged("Buffer");
				}
			}
		}

		[DataMember]
		public byte[] CheckSum
		{
			get
			{
				return this.CheckSumField;
			}
			set
			{
				if (!object.ReferenceEquals(this.CheckSumField, value))
				{
					this.CheckSumField = value;
					base.RaisePropertyChanged("CheckSum");
				}
			}
		}

		[DataMember]
		public bool IsDone
		{
			get
			{
				return this.IsDoneField;
			}
			set
			{
				if (!this.IsDoneField.Equals(value))
				{
					this.IsDoneField = value;
					base.RaisePropertyChanged("IsDone");
				}
			}
		}

		[DataMember]
		public double Progress
		{
			get
			{
				return this.ProgressField;
			}
			set
			{
				if (!this.ProgressField.Equals(value))
				{
					this.ProgressField = value;
					base.RaisePropertyChanged("Progress");
				}
			}
		}

		public DownloadResponse()
		{
		}
	}
}