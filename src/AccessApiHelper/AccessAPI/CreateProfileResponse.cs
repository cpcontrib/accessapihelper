using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="CreateProfileResponse", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class CreateProfileResponse : WSResultClass
	{
		private int FolderIdField;

		[DataMember]
		public int FolderId
		{
			get
			{
				return this.FolderIdField;
			}
			set
			{
				if (!this.FolderIdField.Equals(value))
				{
					this.FolderIdField = value;
					base.RaisePropertyChanged("FolderId");
				}
			}
		}

		public CreateProfileResponse()
		{
		}
	}
}