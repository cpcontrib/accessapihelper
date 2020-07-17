using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="Thumbnail", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class Thumbnail : INotifyPropertyChanged
	{
		private string DisplayUrlField;

		private string ErrorMessageField;

		private int HeightField;

		private bool? PreserveAspectRatioField;

		private int QualityPercentField;

		private string ThumbNameField;

		private int WidthField;

		[DataMember]
		public string DisplayUrl
		{
			get
			{
				return this.DisplayUrlField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DisplayUrlField, value))
				{
					this.DisplayUrlField = value;
					this.RaisePropertyChanged("DisplayUrl");
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

		[DataMember]
		public int Height
		{
			get
			{
				return this.HeightField;
			}
			set
			{
				if (!this.HeightField.Equals(value))
				{
					this.HeightField = value;
					this.RaisePropertyChanged("Height");
				}
			}
		}

		[DataMember]
		public bool? PreserveAspectRatio
		{
			get
			{
				return this.PreserveAspectRatioField;
			}
			set
			{
				if (!this.PreserveAspectRatioField.Equals(value))
				{
					this.PreserveAspectRatioField = value;
					this.RaisePropertyChanged("PreserveAspectRatio");
				}
			}
		}

		[DataMember]
		public int QualityPercent
		{
			get
			{
				return this.QualityPercentField;
			}
			set
			{
				if (!this.QualityPercentField.Equals(value))
				{
					this.QualityPercentField = value;
					this.RaisePropertyChanged("QualityPercent");
				}
			}
		}

		[DataMember]
		public string ThumbName
		{
			get
			{
				return this.ThumbNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ThumbNameField, value))
				{
					this.ThumbNameField = value;
					this.RaisePropertyChanged("ThumbName");
				}
			}
		}

		[DataMember]
		public int Width
		{
			get
			{
				return this.WidthField;
			}
			set
			{
				if (!this.WidthField.Equals(value))
				{
					this.WidthField = value;
					this.RaisePropertyChanged("Width");
				}
			}
		}

		public Thumbnail()
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