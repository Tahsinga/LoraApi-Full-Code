using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace PointOfSale.QuantumPOSService
{
	// Token: 0x020001C3 RID: 451
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[DataContract(Name = "CusDetails", Namespace = "http://schemas.datacontract.org/2004/07/")]
	[Serializable]
	public class CusDetails : IExtensibleDataObject, INotifyPropertyChanged
	{
		// Token: 0x17001D96 RID: 7574
		// (get) Token: 0x0600509D RID: 20637 RVA: 0x0030077C File Offset: 0x002FE97C
		// (set) Token: 0x0600509E RID: 20638 RVA: 0x00300794 File Offset: 0x002FE994
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

		// Token: 0x17001D97 RID: 7575
		// (get) Token: 0x0600509F RID: 20639 RVA: 0x003007A0 File Offset: 0x002FE9A0
		// (set) Token: 0x060050A0 RID: 20640 RVA: 0x003007B8 File Offset: 0x002FE9B8
		[DataMember]
		public DataTable Cusdetailstb
		{
			get
			{
				return this.CusdetailstbField;
			}
			set
			{
				bool flag = !object.ReferenceEquals(this.CusdetailstbField, value);
				if (flag)
				{
					this.CusdetailstbField = value;
					this.RaisePropertyChanged("Cusdetailstb");
				}
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x060050A1 RID: 20641 RVA: 0x003007F0 File Offset: 0x002FE9F0
		// (remove) Token: 0x060050A2 RID: 20642 RVA: 0x00300828 File Offset: 0x002FEA28
		public event PropertyChangedEventHandler PropertyChanged;

		// Token: 0x060050A3 RID: 20643 RVA: 0x00300860 File Offset: 0x002FEA60
		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEvent = this.PropertyChangedEvent;
			bool flag = propertyChangedEvent != null;
			if (flag)
			{
				propertyChangedEvent(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x040023FD RID: 9213
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		// Token: 0x040023FE RID: 9214
		[OptionalField]
		private DataTable CusdetailstbField;
	}
}
