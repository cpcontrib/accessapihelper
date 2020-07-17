using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="WCOGetCollectionsAndSnippetsResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class WCOGetCollectionsAndSnippetsResponse : WSResultClass
	{
		private ICollection<WCOCollectionData> CollectionsField;

		private ICollection<WCOPageData> PagesField;

		private ICollection<WCOAnalyticsSiteData> SitesField;

		private Dictionary<Guid, ICollection<WCOSnippetData>> SnippetsField;

		private Dictionary<Guid, WCOTargetGroupData> TargetGroupsField;

		[DataMember]
		public ICollection<WCOCollectionData> Collections
		{
			get
			{
				return this.CollectionsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.CollectionsField, value))
				{
					this.CollectionsField = value;
					base.RaisePropertyChanged("Collections");
				}
			}
		}

		[DataMember]
		public ICollection<WCOPageData> Pages
		{
			get
			{
				return this.PagesField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PagesField, value))
				{
					this.PagesField = value;
					base.RaisePropertyChanged("Pages");
				}
			}
		}

		[DataMember]
		public ICollection<WCOAnalyticsSiteData> Sites
		{
			get
			{
				return this.SitesField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SitesField, value))
				{
					this.SitesField = value;
					base.RaisePropertyChanged("Sites");
				}
			}
		}

		[DataMember]
		public Dictionary<Guid, ICollection<WCOSnippetData>> Snippets
		{
			get
			{
				return this.SnippetsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SnippetsField, value))
				{
					this.SnippetsField = value;
					base.RaisePropertyChanged("Snippets");
				}
			}
		}

		[DataMember]
		public Dictionary<Guid, WCOTargetGroupData> TargetGroups
		{
			get
			{
				return this.TargetGroupsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TargetGroupsField, value))
				{
					this.TargetGroupsField = value;
					base.RaisePropertyChanged("TargetGroups");
				}
			}
		}

		public WCOGetCollectionsAndSnippetsResponse()
		{
		}
	}
}