using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace PointOfSale.QuantumPOSService
{
	// Token: 0x020001C0 RID: 448
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[DataContract(Name = "ManuIngridients", Namespace = "http://schemas.datacontract.org/2004/07/")]
	[Serializable]
	public class ManuIngridients : IExtensibleDataObject, INotifyPropertyChanged
	{
		// Token: 0x17001D90 RID: 7568
		// (get) Token: 0x06005085 RID: 20613 RVA: 0x00300440 File Offset: 0x002FE640
		// (set) Token: 0x06005086 RID: 20614 RVA: 0x00300458 File Offset: 0x002FE658
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

		// Token: 0x17001D91 RID: 7569
		// (get) Token: 0x06005087 RID: 20615 RVA: 0x00300464 File Offset: 0x002FE664
		// (set) Token: 0x06005088 RID: 20616 RVA: 0x0030047C File Offset: 0x002FE67C
		[DataMember]
		public DataTable Manuingtb
		{
			get
			{
				return this.ManuingtbField;
			}
			set
			{
				bool flag = !object.ReferenceEquals(this.ManuingtbField, value);
				if (flag)
				{
					this.ManuingtbField = value;
					this.RaisePropertyChanged("Manuingtb");
				}
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06005089 RID: 20617 RVA: 0x003004B4 File Offset: 0x002FE6B4
		// (remove) Token: 0x0600508A RID: 20618 RVA: 0x003004EC File Offset: 0x002FE6EC
		public event PropertyChangedEventHandler PropertyChanged;

		// Token: 0x0600508B RID: 20619 RVA: 0x00300524 File Offset: 0x002FE724
		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEvent = this.PropertyChangedEvent;
			bool flag = propertyChangedEvent != null;
			if (flag)
			{
				propertyChangedEvent(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x040023F4 RID: 9204
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		// Token: 0x040023F5 RID: 9205
		[OptionalField]
		private DataTable ManuingtbField;
	}
}
