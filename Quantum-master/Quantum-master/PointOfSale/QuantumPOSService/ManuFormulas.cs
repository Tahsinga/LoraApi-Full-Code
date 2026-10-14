using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace PointOfSale.QuantumPOSService
{
	// Token: 0x020001C6 RID: 454
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[DataContract(Name = "ManuFormulas", Namespace = "http://schemas.datacontract.org/2004/07/")]
	[Serializable]
	public class ManuFormulas : IExtensibleDataObject, INotifyPropertyChanged
	{
		// Token: 0x17001D9C RID: 7580
		// (get) Token: 0x060050B5 RID: 20661 RVA: 0x00300AB8 File Offset: 0x002FECB8
		// (set) Token: 0x060050B6 RID: 20662 RVA: 0x00300AD0 File Offset: 0x002FECD0
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

		// Token: 0x17001D9D RID: 7581
		// (get) Token: 0x060050B7 RID: 20663 RVA: 0x00300ADC File Offset: 0x002FECDC
		// (set) Token: 0x060050B8 RID: 20664 RVA: 0x00300AF4 File Offset: 0x002FECF4
		[DataMember]
		public DataTable ManuFormulastb
		{
			get
			{
				return this.ManuFormulastbField;
			}
			set
			{
				bool flag = !object.ReferenceEquals(this.ManuFormulastbField, value);
				if (flag)
				{
					this.ManuFormulastbField = value;
					this.RaisePropertyChanged("ManuFormulastb");
				}
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x060050B9 RID: 20665 RVA: 0x00300B2C File Offset: 0x002FED2C
		// (remove) Token: 0x060050BA RID: 20666 RVA: 0x00300B64 File Offset: 0x002FED64
		public event PropertyChangedEventHandler PropertyChanged;

		// Token: 0x060050BB RID: 20667 RVA: 0x00300B9C File Offset: 0x002FED9C
		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEvent = this.PropertyChangedEvent;
			bool flag = propertyChangedEvent != null;
			if (flag)
			{
				propertyChangedEvent(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04002406 RID: 9222
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		// Token: 0x04002407 RID: 9223
		[OptionalField]
		private DataTable ManuFormulastbField;
	}
}
