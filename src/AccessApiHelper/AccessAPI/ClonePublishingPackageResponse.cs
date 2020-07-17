using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="ClonePublishingPackageResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class ClonePublishingPackageResponse : WSResultClass
	{
		private PublishingServerData newPackageField;

		[DataMember]
		public PublishingServerData newPackage
		{
			get
			{
				return this.newPackageField;
			}
			set
			{
				if (!object.ReferenceEquals(this.newPackageField, value))
				{
					this.newPackageField = value;
					base.RaisePropertyChanged("newPackage");
				}
			}
		}

		public ClonePublishingPackageResponse()
		{
		}
	}
}