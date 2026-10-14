using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace PointOfSale.QuantumPOSService
{
	// Token: 0x020001D4 RID: 468
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[DataContract(Name = "PayMethz", Namespace = "http://schemas.datacontract.org/2004/07/")]
	[Serializable]
	public class PayMethz : IExtensibleDataObject, INotifyPropertyChanged
	{
		// Token: 0x17001DB9 RID: 7609
		// (get) Token: 0x06005127 RID: 20775 RVA: 0x00301A20 File Offset: 0x002FFC20
		// (set) Token: 0x06005128 RID: 20776 RVA: 0x00301A38 File Offset: 0x002FFC38
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

		// Token: 0x17001DBA RID: 7610
		// (get) Token: 0x06005129 RID: 20777 RVA: 0x00301A44 File Offset: 0x002FFC44
		// (set) Token: 0x0600512A RID: 20778 RVA: 0x00301A5C File Offset: 0x002FFC5C
		[DataMember]
		public DataTable Paymethztb
		{
			get
			{
				return this.PaymethztbField;
			}
			set
			{
				bool flag = !object.ReferenceEquals(this.PaymethztbField, value);
				if (flag)
				{
					this.PaymethztbField = value;
					this.RaisePropertyChanged("Paymethztb");
				}
			}
		}

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x0600512B RID: 20779 RVA: 0x00301A94 File Offset: 0x002FFC94
		// (remove) Token: 0x0600512C RID: 20780 RVA: 0x00301ACC File Offset: 0x002FFCCC
		public event PropertyChangedEventHandler PropertyChanged;

		// Token: 0x0600512D RID: 20781 RVA: 0x00301B04 File Offset: 0x002FFD04
		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEvent = this.PropertyChangedEvent;
			bool flag = propertyChangedEvent != null;
			if (flag)
			{
				propertyChangedEvent(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04002431 RID: 9265
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		// Token: 0x04002432 RID: 9266
		[OptionalField]
		private DataTable PaymethztbField;
	}
}
