using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace PointOfSale.QuantumPOSService
{
	// Token: 0x020001C1 RID: 449
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[DataContract(Name = "Users", Namespace = "http://schemas.datacontract.org/2004/07/")]
	[Serializable]
	public class Users : IExtensibleDataObject, INotifyPropertyChanged
	{
		// Token: 0x17001D92 RID: 7570
		// (get) Token: 0x0600508D RID: 20621 RVA: 0x00300554 File Offset: 0x002FE754
		// (set) Token: 0x0600508E RID: 20622 RVA: 0x0030056C File Offset: 0x002FE76C
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

		// Token: 0x17001D93 RID: 7571
		// (get) Token: 0x0600508F RID: 20623 RVA: 0x00300578 File Offset: 0x002FE778
		// (set) Token: 0x06005090 RID: 20624 RVA: 0x00300590 File Offset: 0x002FE790
		[DataMember]
		public DataTable Userstb
		{
			get
			{
				return this.UserstbField;
			}
			set
			{
				bool flag = !object.ReferenceEquals(this.UserstbField, value);
				if (flag)
				{
					this.UserstbField = value;
					this.RaisePropertyChanged("Userstb");
				}
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06005091 RID: 20625 RVA: 0x003005C8 File Offset: 0x002FE7C8
		// (remove) Token: 0x06005092 RID: 20626 RVA: 0x00300600 File Offset: 0x002FE800
		public event PropertyChangedEventHandler PropertyChanged;

		// Token: 0x06005093 RID: 20627 RVA: 0x00300638 File Offset: 0x002FE838
		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEvent = this.PropertyChangedEvent;
			bool flag = propertyChangedEvent != null;
			if (flag)
			{
				propertyChangedEvent(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x040023F7 RID: 9207
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		// Token: 0x040023F8 RID: 9208
		[OptionalField]
		private DataTable UserstbField;
	}
}
