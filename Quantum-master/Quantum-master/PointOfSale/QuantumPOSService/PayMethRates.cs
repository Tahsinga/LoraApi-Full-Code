using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace PointOfSale.QuantumPOSService
{
	// Token: 0x020001CF RID: 463
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[DataContract(Name = "PayMethRates", Namespace = "http://schemas.datacontract.org/2004/07/")]
	[Serializable]
	public class PayMethRates : IExtensibleDataObject, INotifyPropertyChanged
	{
		// Token: 0x17001DAF RID: 7599
		// (get) Token: 0x060050FF RID: 20735 RVA: 0x003014BC File Offset: 0x002FF6BC
		// (set) Token: 0x06005100 RID: 20736 RVA: 0x003014D4 File Offset: 0x002FF6D4
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

		// Token: 0x17001DB0 RID: 7600
		// (get) Token: 0x06005101 RID: 20737 RVA: 0x003014E0 File Offset: 0x002FF6E0
		// (set) Token: 0x06005102 RID: 20738 RVA: 0x003014F8 File Offset: 0x002FF6F8
		[DataMember]
		public DataTable PayMethRatestb
		{
			get
			{
				return this.PayMethRatestbField;
			}
			set
			{
				bool flag = !object.ReferenceEquals(this.PayMethRatestbField, value);
				if (flag)
				{
					this.PayMethRatestbField = value;
					this.RaisePropertyChanged("PayMethRatestb");
				}
			}
		}

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x06005103 RID: 20739 RVA: 0x00301530 File Offset: 0x002FF730
		// (remove) Token: 0x06005104 RID: 20740 RVA: 0x00301568 File Offset: 0x002FF768
		public event PropertyChangedEventHandler PropertyChanged;

		// Token: 0x06005105 RID: 20741 RVA: 0x003015A0 File Offset: 0x002FF7A0
		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEvent = this.PropertyChangedEvent;
			bool flag = propertyChangedEvent != null;
			if (flag)
			{
				propertyChangedEvent(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04002422 RID: 9250
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		// Token: 0x04002423 RID: 9251
		[OptionalField]
		private DataTable PayMethRatestbField;
	}
}
