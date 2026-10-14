using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace PointOfSale.QuantumPOSService
{
	// Token: 0x020001D0 RID: 464
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[DataContract(Name = "CatsData", Namespace = "http://schemas.datacontract.org/2004/07/")]
	[Serializable]
	public class CatsData : IExtensibleDataObject, INotifyPropertyChanged
	{
		// Token: 0x17001DB1 RID: 7601
		// (get) Token: 0x06005107 RID: 20743 RVA: 0x003015D0 File Offset: 0x002FF7D0
		// (set) Token: 0x06005108 RID: 20744 RVA: 0x003015E8 File Offset: 0x002FF7E8
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

		// Token: 0x17001DB2 RID: 7602
		// (get) Token: 0x06005109 RID: 20745 RVA: 0x003015F4 File Offset: 0x002FF7F4
		// (set) Token: 0x0600510A RID: 20746 RVA: 0x0030160C File Offset: 0x002FF80C
		[DataMember]
		public DataTable Cattb
		{
			get
			{
				return this.CattbField;
			}
			set
			{
				bool flag = !object.ReferenceEquals(this.CattbField, value);
				if (flag)
				{
					this.CattbField = value;
					this.RaisePropertyChanged("Cattb");
				}
			}
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x0600510B RID: 20747 RVA: 0x00301644 File Offset: 0x002FF844
		// (remove) Token: 0x0600510C RID: 20748 RVA: 0x0030167C File Offset: 0x002FF87C
		public event PropertyChangedEventHandler PropertyChanged;

		// Token: 0x0600510D RID: 20749 RVA: 0x003016B4 File Offset: 0x002FF8B4
		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEvent = this.PropertyChangedEvent;
			bool flag = propertyChangedEvent != null;
			if (flag)
			{
				propertyChangedEvent(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04002425 RID: 9253
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		// Token: 0x04002426 RID: 9254
		[OptionalField]
		private DataTable CattbField;
	}
}
