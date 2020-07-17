using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="SnippetVariantTestsData", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.App")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class SnippetVariantTestsData : INotifyPropertyChanged
	{
		private int AssetIdField;

		private string AssetLabelField;

		private int ConversionCountField;

		private DateTime DateCreatedField;

		private ICollection<string> LiveUrlsField;

		private string PackageNameField;

		private string SnippetIdField;

		private int TrendField;

		private Dictionary<string, int> VariantConversionsField;

		private Dictionary<string, int> VariantViewsField;

		private ICollection<Snippet> VariantsField;

		private int ViewCountField;

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
		public string AssetLabel
		{
			get
			{
				return this.AssetLabelField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AssetLabelField, value))
				{
					this.AssetLabelField = value;
					this.RaisePropertyChanged("AssetLabel");
				}
			}
		}

		[DataMember]
		public int ConversionCount
		{
			get
			{
				return this.ConversionCountField;
			}
			set
			{
				if (!this.ConversionCountField.Equals(value))
				{
					this.ConversionCountField = value;
					this.RaisePropertyChanged("ConversionCount");
				}
			}
		}

		[DataMember]
		public DateTime DateCreated
		{
			get
			{
				return this.DateCreatedField;
			}
			set
			{
				if (!this.DateCreatedField.Equals(value))
				{
					this.DateCreatedField = value;
					this.RaisePropertyChanged("DateCreated");
				}
			}
		}

		[DataMember]
		public ICollection<string> LiveUrls
		{
			get
			{
				return this.LiveUrlsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.LiveUrlsField, value))
				{
					this.LiveUrlsField = value;
					this.RaisePropertyChanged("LiveUrls");
				}
			}
		}

		[DataMember]
		public string PackageName
		{
			get
			{
				return this.PackageNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PackageNameField, value))
				{
					this.PackageNameField = value;
					this.RaisePropertyChanged("PackageName");
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
		public int Trend
		{
			get
			{
				return this.TrendField;
			}
			set
			{
				if (!this.TrendField.Equals(value))
				{
					this.TrendField = value;
					this.RaisePropertyChanged("Trend");
				}
			}
		}

		[DataMember]
		public Dictionary<string, int> VariantConversions
		{
			get
			{
				return this.VariantConversionsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.VariantConversionsField, value))
				{
					this.VariantConversionsField = value;
					this.RaisePropertyChanged("VariantConversions");
				}
			}
		}

		[DataMember]
		public ICollection<Snippet> Variants
		{
			get
			{
				return this.VariantsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.VariantsField, value))
				{
					this.VariantsField = value;
					this.RaisePropertyChanged("Variants");
				}
			}
		}

		[DataMember]
		public Dictionary<string, int> VariantViews
		{
			get
			{
				return this.VariantViewsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.VariantViewsField, value))
				{
					this.VariantViewsField = value;
					this.RaisePropertyChanged("VariantViews");
				}
			}
		}

		[DataMember]
		public int ViewCount
		{
			get
			{
				return this.ViewCountField;
			}
			set
			{
				if (!this.ViewCountField.Equals(value))
				{
					this.ViewCountField = value;
					this.RaisePropertyChanged("ViewCount");
				}
			}
		}

		public SnippetVariantTestsData()
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