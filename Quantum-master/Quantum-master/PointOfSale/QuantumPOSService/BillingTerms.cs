using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace PointOfSale.QuantumPOSService
{
	// Token: 0x020001C4 RID: 452
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[DataContract(Name = "BillingTerms", Namespace = "http://schemas.datacontract.org/2004/07/")]
	[Serializable]
	public class BillingTerms : IExtensibleDataObject, INotifyPropertyChanged
	{
		// Token: 0x17001D98 RID: 7576
		// (get) Token: 0x060050A5 RID: 20645 RVA: 0x00300890 File Offset: 0x002FEA90
		// (set) Token: 0x060050A6 RID: 20646 RVA: 0x003008A8 File Offset: 0x002FEAA8
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

		// Token: 0x17001D99 RID: 7577
		// (get) Token: 0x060050A7 RID: 20647 RVA: 0x003008B4 File Offset: 0x002FEAB4
		// (set) Token: 0x060050A8 RID: 20648 RVA: 0x003008CC File Offset: 0x002FEACC
		[DataMember]
		public DataTable Billingtermstb
		{
			get
			{
				return this.BillingtermstbField;
			}
			set
			{
				bool flag = !object.ReferenceEquals(this.BillingtermstbField, value);
				if (flag)
				{
					this.BillingtermstbField = value;
					this.RaisePropertyChanged("Billingtermstb");
				}
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x060050A9 RID: 20649 RVA: 0x00300904 File Offset: 0x002FEB04
		// (remove) Token: 0x060050AA RID: 20650 RVA: 0x0030093C File Offset: 0x002FEB3C
		public event PropertyChangedEventHandler PropertyChanged;

		// Token: 0x060050AB RID: 20651 RVA: 0x00300974 File Offset: 0x002FEB74
		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEvent = this.PropertyChangedEvent;
			bool flag = propertyChangedEvent != null;
			if (flag)
			{
				propertyChangedEvent(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04002400 RID: 9216
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		// Token: 0x04002401 RID: 9217
		[OptionalField]
		private DataTable BillingtermstbField;
	}
}
