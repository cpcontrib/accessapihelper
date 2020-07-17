using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="MenuShortCutData", Namespace="http://schemas.datacontract.org/2004/07/CrownPeakApp.Model")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class MenuShortCutData : INotifyPropertyChanged
	{
		private int AssetIdField;

		private string DisplayLabelField;

		private string MenuCategoryField;

		private string NavigationPathField;

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
		public string DisplayLabel
		{
			get
			{
				return this.DisplayLabelField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DisplayLabelField, value))
				{
					this.DisplayLabelField = value;
					this.RaisePropertyChanged("DisplayLabel");
				}
			}
		}

		[DataMember]
		public string MenuCategory
		{
			get
			{
				return this.MenuCategoryField;
			}
			set
			{
				if (!object.ReferenceEquals(this.MenuCategoryField, value))
				{
					this.MenuCategoryField = value;
					this.RaisePropertyChanged("MenuCategory");
				}
			}
		}

		[DataMember]
		public string NavigationPath
		{
			get
			{
				return this.NavigationPathField;
			}
			set
			{
				if (!object.ReferenceEquals(this.NavigationPathField, value))
				{
					this.NavigationPathField = value;
					this.RaisePropertyChanged("NavigationPath");
				}
			}
		}

		public MenuShortCutData()
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