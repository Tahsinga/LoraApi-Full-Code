using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace PointOfSale.QuantumPOSService
{
	// Token: 0x020001C5 RID: 453
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[DataContract(Name = "BillingLog", Namespace = "http://schemas.datacontract.org/2004/07/")]
	[Serializable]
	public class BillingLog : IExtensibleDataObject, INotifyPropertyChanged
	{
		// Token: 0x17001D9A RID: 7578
		// (get) Token: 0x060050AD RID: 20653 RVA: 0x003009A4 File Offset: 0x002FEBA4
		// (set) Token: 0x060050AE RID: 20654 RVA: 0x003009BC File Offset: 0x002FEBBC
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

		// Token: 0x17001D9B RID: 7579
		// (get) Token: 0x060050AF RID: 20655 RVA: 0x003009C8 File Offset: 0x002FEBC8
		// (set) Token: 0x060050B0 RID: 20656 RVA: 0x003009E0 File Offset: 0x002FEBE0
		[DataMember]
		public DataTable Billinglogtb
		{
			get
			{
				return this.BillinglogtbField;
			}
			set
			{
				bool flag = !object.ReferenceEquals(this.BillinglogtbField, value);
				if (flag)
				{
					this.BillinglogtbField = value;
					this.RaisePropertyChanged("Billinglogtb");
				}
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x060050B1 RID: 20657 RVA: 0x00300A18 File Offset: 0x002FEC18
		// (remove) Token: 0x060050B2 RID: 20658 RVA: 0x00300A50 File Offset: 0x002FEC50
		public event PropertyChangedEventHandler PropertyChanged;

		// Token: 0x060050B3 RID: 20659 RVA: 0x00300A88 File Offset: 0x002FEC88
		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEvent = this.PropertyChangedEvent;
			bool flag = propertyChangedEvent != null;
			if (flag)
			{
				propertyChangedEvent(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04002403 RID: 9219
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		// Token: 0x04002404 RID: 9220
		[OptionalField]
		private DataTable BillinglogtbField;
	}
}
