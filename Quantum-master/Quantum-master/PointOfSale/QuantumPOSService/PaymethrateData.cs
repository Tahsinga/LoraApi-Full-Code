using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace PointOfSale.QuantumPOSService
{
	// Token: 0x020001CB RID: 459
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[DataContract(Name = "PaymethrateData", Namespace = "http://schemas.datacontract.org/2004/07/")]
	[Serializable]
	public class PaymethrateData : IExtensibleDataObject, INotifyPropertyChanged
	{
		// Token: 0x17001DA7 RID: 7591
		// (get) Token: 0x060050DF RID: 20703 RVA: 0x0030106C File Offset: 0x002FF26C
		// (set) Token: 0x060050E0 RID: 20704 RVA: 0x00301084 File Offset: 0x002FF284
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

		// Token: 0x17001DA8 RID: 7592
		// (get) Token: 0x060050E1 RID: 20705 RVA: 0x00301090 File Offset: 0x002FF290
		// (set) Token: 0x060050E2 RID: 20706 RVA: 0x003010A8 File Offset: 0x002FF2A8
		[DataMember]
		public DataTable paymethratesTable
		{
			get
			{
				return this.paymethratesTableField;
			}
			set
			{
				bool flag = !object.ReferenceEquals(this.paymethratesTableField, value);
				if (flag)
				{
					this.paymethratesTableField = value;
					this.RaisePropertyChanged("paymethratesTable");
				}
			}
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x060050E3 RID: 20707 RVA: 0x003010E0 File Offset: 0x002FF2E0
		// (remove) Token: 0x060050E4 RID: 20708 RVA: 0x00301118 File Offset: 0x002FF318
		public event PropertyChangedEventHandler PropertyChanged;

		// Token: 0x060050E5 RID: 20709 RVA: 0x00301150 File Offset: 0x002FF350
		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEvent = this.PropertyChangedEvent;
			bool flag = propertyChangedEvent != null;
			if (flag)
			{
				propertyChangedEvent(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04002416 RID: 9238
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		// Token: 0x04002417 RID: 9239
		[OptionalField]
		private DataTable paymethratesTableField;
	}
}
