using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace CrownPeak.AccessAPI
{
	[DataContract(Name="LogoutRequest", Namespace="http://schemas.datacontract.org/2004/07/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public class LogoutRequest : INotifyPropertyChanged
	{
		private ICollection<int> AssetIdsToUnlockField;

		private LogoutReason logoutReasonField;

		[DataMember]
		public ICollection<int> AssetIdsToUnlock
		{
			get
			{
				return this.AssetIdsToUnlockField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AssetIdsToUnlockField, value))
				{
					this.AssetIdsToUnlockField = value;
					this.RaisePropertyChanged("AssetIdsToUnlock");
				}
			}
		}

		[DataMember]
		public LogoutReason logoutReason
		{
			get
			{
				return this.logoutReasonField;
			}
			set
			{
				if (!this.logoutReasonField.Equals(value))
				{
					this.logoutReasonField = value;
					this.RaisePropertyChanged("logoutReason");
				}
			}
		}

		public LogoutRequest()
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