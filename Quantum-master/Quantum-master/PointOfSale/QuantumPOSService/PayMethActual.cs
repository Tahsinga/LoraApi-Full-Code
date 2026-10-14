using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace PointOfSale.QuantumPOSService
{
	// Token: 0x020001D3 RID: 467
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[DataContract(Name = "PayMethActual", Namespace = "http://schemas.datacontract.org/2004/07/")]
	[Serializable]
	public class PayMethActual : IExtensibleDataObject, INotifyPropertyChanged
	{
		// Token: 0x17001DB7 RID: 7607
		// (get) Token: 0x0600511F RID: 20767 RVA: 0x0030190C File Offset: 0x002FFB0C
		// (set) Token: 0x06005120 RID: 20768 RVA: 0x00301924 File Offset: 0x002FFB24
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

		// Token: 0x17001DB8 RID: 7608
		// (get) Token: 0x06005121 RID: 20769 RVA: 0x00301930 File Offset: 0x002FFB30
		// (set) Token: 0x06005122 RID: 20770 RVA: 0x00301948 File Offset: 0x002FFB48
		[DataMember]
		public DataTable Paymethactualtb
		{
			get
			{
				return this.PaymethactualtbField;
			}
			set
			{
				bool flag = !object.ReferenceEquals(this.PaymethactualtbField, value);
				if (flag)
				{
					this.PaymethactualtbField = value;
					this.RaisePropertyChanged("Paymethactualtb");
				}
			}
		}

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x06005123 RID: 20771 RVA: 0x00301980 File Offset: 0x002FFB80
		// (remove) Token: 0x06005124 RID: 20772 RVA: 0x003019B8 File Offset: 0x002FFBB8
		public event PropertyChangedEventHandler PropertyChanged;

		// Token: 0x06005125 RID: 20773 RVA: 0x003019F0 File Offset: 0x002FFBF0
		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEvent = this.PropertyChangedEvent;
			bool flag = propertyChangedEvent != null;
			if (flag)
			{
				propertyChangedEvent(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x0400242E RID: 9262
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		// Token: 0x0400242F RID: 9263
		[OptionalField]
		private DataTable PaymethactualtbField;
	}
}
