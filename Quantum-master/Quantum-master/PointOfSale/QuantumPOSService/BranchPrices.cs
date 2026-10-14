using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace PointOfSale.QuantumPOSService
{
	// Token: 0x020001D5 RID: 469
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[DataContract(Name = "BranchPrices", Namespace = "http://schemas.datacontract.org/2004/07/")]
	[Serializable]
	public class BranchPrices : IExtensibleDataObject, INotifyPropertyChanged
	{
		// Token: 0x17001DBB RID: 7611
		// (get) Token: 0x0600512F RID: 20783 RVA: 0x00301B34 File Offset: 0x002FFD34
		// (set) Token: 0x06005130 RID: 20784 RVA: 0x00301B4C File Offset: 0x002FFD4C
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

		// Token: 0x17001DBC RID: 7612
		// (get) Token: 0x06005131 RID: 20785 RVA: 0x00301B58 File Offset: 0x002FFD58
		// (set) Token: 0x06005132 RID: 20786 RVA: 0x00301B70 File Offset: 0x002FFD70
		[DataMember]
		public DataTable Branchpricestb
		{
			get
			{
				return this.BranchpricestbField;
			}
			set
			{
				bool flag = !object.ReferenceEquals(this.BranchpricestbField, value);
				if (flag)
				{
					this.BranchpricestbField = value;
					this.RaisePropertyChanged("Branchpricestb");
				}
			}
		}

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x06005133 RID: 20787 RVA: 0x00301BA8 File Offset: 0x002FFDA8
		// (remove) Token: 0x06005134 RID: 20788 RVA: 0x00301BE0 File Offset: 0x002FFDE0
		public event PropertyChangedEventHandler PropertyChanged;

		// Token: 0x06005135 RID: 20789 RVA: 0x00301C18 File Offset: 0x002FFE18
		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEvent = this.PropertyChangedEvent;
			bool flag = propertyChangedEvent != null;
			if (flag)
			{
				propertyChangedEvent(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04002434 RID: 9268
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		// Token: 0x04002435 RID: 9269
		[OptionalField]
		private DataTable BranchpricestbField;
	}
}
