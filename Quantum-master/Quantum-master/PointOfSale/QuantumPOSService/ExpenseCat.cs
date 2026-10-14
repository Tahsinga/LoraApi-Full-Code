using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace PointOfSale.QuantumPOSService
{
	// Token: 0x020001C2 RID: 450
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[DataContract(Name = "ExpenseCat", Namespace = "http://schemas.datacontract.org/2004/07/")]
	[Serializable]
	public class ExpenseCat : IExtensibleDataObject, INotifyPropertyChanged
	{
		// Token: 0x17001D94 RID: 7572
		// (get) Token: 0x06005095 RID: 20629 RVA: 0x00300668 File Offset: 0x002FE868
		// (set) Token: 0x06005096 RID: 20630 RVA: 0x00300680 File Offset: 0x002FE880
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

		// Token: 0x17001D95 RID: 7573
		// (get) Token: 0x06005097 RID: 20631 RVA: 0x0030068C File Offset: 0x002FE88C
		// (set) Token: 0x06005098 RID: 20632 RVA: 0x003006A4 File Offset: 0x002FE8A4
		[DataMember]
		public DataTable Expensecattb
		{
			get
			{
				return this.ExpensecattbField;
			}
			set
			{
				bool flag = !object.ReferenceEquals(this.ExpensecattbField, value);
				if (flag)
				{
					this.ExpensecattbField = value;
					this.RaisePropertyChanged("Expensecattb");
				}
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06005099 RID: 20633 RVA: 0x003006DC File Offset: 0x002FE8DC
		// (remove) Token: 0x0600509A RID: 20634 RVA: 0x00300714 File Offset: 0x002FE914
		public event PropertyChangedEventHandler PropertyChanged;

		// Token: 0x0600509B RID: 20635 RVA: 0x0030074C File Offset: 0x002FE94C
		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEvent = this.PropertyChangedEvent;
			bool flag = propertyChangedEvent != null;
			if (flag)
			{
				propertyChangedEvent(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x040023FA RID: 9210
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		// Token: 0x040023FB RID: 9211
		[OptionalField]
		private DataTable ExpensecattbField;
	}
}
