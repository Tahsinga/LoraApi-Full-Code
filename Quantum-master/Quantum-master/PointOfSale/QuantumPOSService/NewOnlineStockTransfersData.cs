using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace PointOfSale.QuantumPOSService
{
	// Token: 0x020001CD RID: 461
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[DataContract(Name = "NewOnlineStockTransfersData", Namespace = "http://schemas.datacontract.org/2004/07/")]
	[Serializable]
	public class NewOnlineStockTransfersData : IExtensibleDataObject, INotifyPropertyChanged
	{
		// Token: 0x17001DAB RID: 7595
		// (get) Token: 0x060050EF RID: 20719 RVA: 0x00301294 File Offset: 0x002FF494
		// (set) Token: 0x060050F0 RID: 20720 RVA: 0x003012AC File Offset: 0x002FF4AC
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

		// Token: 0x17001DAC RID: 7596
		// (get) Token: 0x060050F1 RID: 20721 RVA: 0x003012B8 File Offset: 0x002FF4B8
		// (set) Token: 0x060050F2 RID: 20722 RVA: 0x003012D0 File Offset: 0x002FF4D0
		[DataMember]
		public DataTable NewStockTransferstb
		{
			get
			{
				return this.NewStockTransferstbField;
			}
			set
			{
				bool flag = !object.ReferenceEquals(this.NewStockTransferstbField, value);
				if (flag)
				{
					this.NewStockTransferstbField = value;
					this.RaisePropertyChanged("NewStockTransferstb");
				}
			}
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x060050F3 RID: 20723 RVA: 0x00301308 File Offset: 0x002FF508
		// (remove) Token: 0x060050F4 RID: 20724 RVA: 0x00301340 File Offset: 0x002FF540
		public event PropertyChangedEventHandler PropertyChanged;

		// Token: 0x060050F5 RID: 20725 RVA: 0x00301378 File Offset: 0x002FF578
		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEvent = this.PropertyChangedEvent;
			bool flag = propertyChangedEvent != null;
			if (flag)
			{
				propertyChangedEvent(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x0400241C RID: 9244
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		// Token: 0x0400241D RID: 9245
		[OptionalField]
		private DataTable NewStockTransferstbField;
	}
}
