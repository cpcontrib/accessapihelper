using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="WCOGetProfilesByAssetIdResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class WCOGetProfilesByAssetIdResponse : WSResultClass
	{
		private ICollection<TargetGroup> ProfilesField;

		private ICollection<SnippetAssociation> SnippetAssociationsField;

		private Dictionary<string, string> VariantValuesField;

		[DataMember]
		public ICollection<TargetGroup> Profiles
		{
			get
			{
				return this.ProfilesField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ProfilesField, value))
				{
					this.ProfilesField = value;
					base.RaisePropertyChanged("Profiles");
				}
			}
		}

		[DataMember]
		public ICollection<SnippetAssociation> SnippetAssociations
		{
			get
			{
				return this.SnippetAssociationsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SnippetAssociationsField, value))
				{
					this.SnippetAssociationsField = value;
					base.RaisePropertyChanged("SnippetAssociations");
				}
			}
		}

		[DataMember]
		public Dictionary<string, string> VariantValues
		{
			get
			{
				return this.VariantValuesField;
			}
			set
			{
				if (!object.ReferenceEquals(this.VariantValuesField, value))
				{
					this.VariantValuesField = value;
					base.RaisePropertyChanged("VariantValues");
				}
			}
		}

		public WCOGetProfilesByAssetIdResponse()
		{
		}
	}
}