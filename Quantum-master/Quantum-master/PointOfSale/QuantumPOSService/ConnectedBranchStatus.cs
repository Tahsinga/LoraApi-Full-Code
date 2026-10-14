using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace PointOfSale.QuantumPOSService
{
	// Token: 0x020001CE RID: 462
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[DataContract(Name = "ConnectedBranchStatus", Namespace = "http://schemas.datacontract.org/2004/07/")]
	[Serializable]
	public class ConnectedBranchStatus : IExtensibleDataObject, INotifyPropertyChanged
	{
		// Token: 0x17001DAD RID: 7597
		// (get) Token: 0x060050F7 RID: 20727 RVA: 0x003013A8 File Offset: 0x002FF5A8
		// (set) Token: 0x060050F8 RID: 20728 RVA: 0x003013C0 File Offset: 0x002FF5C0
		[Browsable(false)]
		public ExtensionDataObject ExtensionData
		{
			get
			{
				return this.extensionDataField;
			}
			set
			{
				this.extensionDataField = value;
			}
		}

		// Token: 0x17001DAE RID: 7598
		// (get) Token: 0x060050F9 RID: 20729 RVA: 0x003013CC File Offset: 0x002FF5CC
		// (set) Token: 0x060050FA RID: 20730 RVA: 0x003013E4 File Offset: 0x002FF5E4
		[DataMember]
		public DataTable connectedbranchstatustb
		{
			get
			{
				return this.connectedbranchstatustbField;
			}
			set
			{
				bool flag = !object.ReferenceEquals(this.connectedbranchstatustbField, value);
				if (flag)
				{
					this.connectedbranchstatustbField = value;
					this.RaisePropertyChanged("connectedbranchstatustb");
				}
			}
		}

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x060050FB RID: 20731 RVA: 0x0030141C File Offset: 0x002FF61C
		// (remove) Token: 0x060050FC RID: 20732 RVA: 0x00301454 File Offset: 0x002FF654
		public event PropertyChangedEventHandler PropertyChanged;

		// Token: 0x060050FD RID: 20733 RVA: 0x0030148C File Offset: 0x002FF68C
		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEvent = this.PropertyChangedEvent;
			bool flag = propertyChangedEvent != null;
			if (flag)
			{
				propertyChangedEvent(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x0400241F RID: 9247
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		// Token: 0x04002420 RID: 9248
		[OptionalField]
		private DataTable connectedbranchstatustbField;
	}
}
