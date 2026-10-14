using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace PointOfSale.QuantumPOSService
{
	// Token: 0x020001D6 RID: 470
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[DataContract(Name = "BranchProductDetails", Namespace = "http://schemas.datacontract.org/2004/07/")]
	[Serializable]
	public class BranchProductDetails : IExtensibleDataObject, INotifyPropertyChanged
	{
		// Token: 0x17001DBD RID: 7613
		// (get) Token: 0x06005137 RID: 20791 RVA: 0x00301C48 File Offset: 0x002FFE48
		// (set) Token: 0x06005138 RID: 20792 RVA: 0x00301C60 File Offset: 0x002FFE60
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

		// Token: 0x17001DBE RID: 7614
		// (get) Token: 0x06005139 RID: 20793 RVA: 0x00301C6C File Offset: 0x002FFE6C
		// (set) Token: 0x0600513A RID: 20794 RVA: 0x00301C84 File Offset: 0x002FFE84
		[DataMember]
		public DataTable Branchproductdetailstb
		{
			get
			{
				return this.BranchproductdetailstbField;
			}
			set
			{
				bool flag = !object.ReferenceEquals(this.BranchproductdetailstbField, value);
				if (flag)
				{
					this.BranchproductdetailstbField = value;
					this.RaisePropertyChanged("Branchproductdetailstb");
				}
			}
		}

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x0600513B RID: 20795 RVA: 0x00301CBC File Offset: 0x002FFEBC
		// (remove) Token: 0x0600513C RID: 20796 RVA: 0x00301CF4 File Offset: 0x002FFEF4
		public event PropertyChangedEventHandler PropertyChanged;

		// Token: 0x0600513D RID: 20797 RVA: 0x00301D2C File Offset: 0x002FFF2C
		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEvent = this.PropertyChangedEvent;
			bool flag = propertyChangedEvent != null;
			if (flag)
			{
				propertyChangedEvent(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04002437 RID: 9271
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		// Token: 0x04002438 RID: 9272
		[OptionalField]
		private DataTable BranchproductdetailstbField;
	}
}
