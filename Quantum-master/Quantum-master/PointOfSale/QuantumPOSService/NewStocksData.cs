using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace PointOfSale.QuantumPOSService
{
	// Token: 0x020001CC RID: 460
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[DataContract(Name = "NewStocksData", Namespace = "http://schemas.datacontract.org/2004/07/")]
	[Serializable]
	public class NewStocksData : IExtensibleDataObject, INotifyPropertyChanged
	{
		// Token: 0x17001DA9 RID: 7593
		// (get) Token: 0x060050E7 RID: 20711 RVA: 0x00301180 File Offset: 0x002FF380
		// (set) Token: 0x060050E8 RID: 20712 RVA: 0x00301198 File Offset: 0x002FF398
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

		// Token: 0x17001DAA RID: 7594
		// (get) Token: 0x060050E9 RID: 20713 RVA: 0x003011A4 File Offset: 0x002FF3A4
		// (set) Token: 0x060050EA RID: 20714 RVA: 0x003011BC File Offset: 0x002FF3BC
		[DataMember]
		public DataTable NewStockstb
		{
			get
			{
				return this.NewStockstbField;
			}
			set
			{
				bool flag = !object.ReferenceEquals(this.NewStockstbField, value);
				if (flag)
				{
					this.NewStockstbField = value;
					this.RaisePropertyChanged("NewStockstb");
				}
			}
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x060050EB RID: 20715 RVA: 0x003011F4 File Offset: 0x002FF3F4
		// (remove) Token: 0x060050EC RID: 20716 RVA: 0x0030122C File Offset: 0x002FF42C
		public event PropertyChangedEventHandler PropertyChanged;

		// Token: 0x060050ED RID: 20717 RVA: 0x00301264 File Offset: 0x002FF464
		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEvent = this.PropertyChangedEvent;
			bool flag = propertyChangedEvent != null;
			if (flag)
			{
				propertyChangedEvent(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04002419 RID: 9241
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		// Token: 0x0400241A RID: 9242
		[OptionalField]
		private DataTable NewStockstbField;
	}
}
