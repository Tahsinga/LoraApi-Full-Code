using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace PointOfSale.QuantumPOSService
{
	// Token: 0x020001CA RID: 458
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[DataContract(Name = "PricesData", Namespace = "http://schemas.datacontract.org/2004/07/")]
	[Serializable]
	public class PricesData : IExtensibleDataObject, INotifyPropertyChanged
	{
		// Token: 0x17001DA5 RID: 7589
		// (get) Token: 0x060050D7 RID: 20695 RVA: 0x00300F58 File Offset: 0x002FF158
		// (set) Token: 0x060050D8 RID: 20696 RVA: 0x00300F70 File Offset: 0x002FF170
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

		// Token: 0x17001DA6 RID: 7590
		// (get) Token: 0x060050D9 RID: 20697 RVA: 0x00300F7C File Offset: 0x002FF17C
		// (set) Token: 0x060050DA RID: 20698 RVA: 0x00300F94 File Offset: 0x002FF194
		[DataMember]
		public DataTable PricesTable
		{
			get
			{
				return this.PricesTableField;
			}
			set
			{
				bool flag = !object.ReferenceEquals(this.PricesTableField, value);
				if (flag)
				{
					this.PricesTableField = value;
					this.RaisePropertyChanged("PricesTable");
				}
			}
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x060050DB RID: 20699 RVA: 0x00300FCC File Offset: 0x002FF1CC
		// (remove) Token: 0x060050DC RID: 20700 RVA: 0x00301004 File Offset: 0x002FF204
		public event PropertyChangedEventHandler PropertyChanged;

		// Token: 0x060050DD RID: 20701 RVA: 0x0030103C File Offset: 0x002FF23C
		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEvent = this.PropertyChangedEvent;
			bool flag = propertyChangedEvent != null;
			if (flag)
			{
				propertyChangedEvent(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04002413 RID: 9235
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		// Token: 0x04002414 RID: 9236
		[OptionalField]
		private DataTable PricesTableField;
	}
}
