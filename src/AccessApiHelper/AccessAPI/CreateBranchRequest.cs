using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="CreateBranchRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class CreateBranchRequest : INotifyPropertyChanged
	{
		private ICollection<WcoSnippetCloneData> WcoSnippetsToBranchField;

		private int assetIdField;

		[DataMember]
		public int assetId
		{
			get
			{
				return this.assetIdField;
			}
			set
			{
				if (!this.assetIdField.Equals(value))
				{
					this.assetIdField = value;
					this.RaisePropertyChanged("assetId");
				}
			}
		}

		[DataMember]
		public ICollection<WcoSnippetCloneData> WcoSnippetsToBranch
		{
			get
			{
				return this.WcoSnippetsToBranchField;
			}
			set
			{
				if (!object.ReferenceEquals(this.WcoSnippetsToBranchField, value))
				{
					this.WcoSnippetsToBranchField = value;
					this.RaisePropertyChanged("WcoSnippetsToBranch");
				}
			}
		}

		public CreateBranchRequest()
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