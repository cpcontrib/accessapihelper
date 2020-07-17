using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="GetOutputURLRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class GetOutputURLRequest : BaseRequest
	{
		private int AssetIdField;

		private bool ForceRenderField;

		private bool IsThumbnailRequestField;

		private string LayoutField;

		private int PageNumField;

		private cpAssetRenderType RenderTypeField;

		private ICollection<string> StatesField;

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
					base.RaisePropertyChanged("AssetId");
				}
			}
		}

		[DataMember]
		public bool ForceRender
		{
			get
			{
				return this.ForceRenderField;
			}
			set
			{
				if (!this.ForceRenderField.Equals(value))
				{
					this.ForceRenderField = value;
					base.RaisePropertyChanged("ForceRender");
				}
			}
		}

		[DataMember]
		public bool IsThumbnailRequest
		{
			get
			{
				return this.IsThumbnailRequestField;
			}
			set
			{
				if (!this.IsThumbnailRequestField.Equals(value))
				{
					this.IsThumbnailRequestField = value;
					base.RaisePropertyChanged("IsThumbnailRequest");
				}
			}
		}

		[DataMember]
		public string Layout
		{
			get
			{
				return this.LayoutField;
			}
			set
			{
				if (!object.ReferenceEquals(this.LayoutField, value))
				{
					this.LayoutField = value;
					base.RaisePropertyChanged("Layout");
				}
			}
		}

		[DataMember]
		public int PageNum
		{
			get
			{
				return this.PageNumField;
			}
			set
			{
				if (!this.PageNumField.Equals(value))
				{
					this.PageNumField = value;
					base.RaisePropertyChanged("PageNum");
				}
			}
		}

		[DataMember]
		public cpAssetRenderType RenderType
		{
			get
			{
				return this.RenderTypeField;
			}
			set
			{
				if (!this.RenderTypeField.Equals(value))
				{
					this.RenderTypeField = value;
					base.RaisePropertyChanged("RenderType");
				}
			}
		}

		[DataMember]
		public ICollection<string> States
		{
			get
			{
				return this.StatesField;
			}
			set
			{
				if (!object.ReferenceEquals(this.StatesField, value))
				{
					this.StatesField = value;
					base.RaisePropertyChanged("States");
				}
			}
		}

		public GetOutputURLRequest()
		{
		}
	}
}