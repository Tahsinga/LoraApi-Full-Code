using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace PointOfSale.QuantumPOSService
{
	// Token: 0x020001D1 RID: 465
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[DataContract(Name = "Prodts", Namespace = "http://schemas.datacontract.org/2004/07/")]
	[Serializable]
	public class Prodts : IExtensibleDataObject, INotifyPropertyChanged
	{
		// Token: 0x17001DB3 RID: 7603
		// (get) Token: 0x0600510F RID: 20751 RVA: 0x003016E4 File Offset: 0x002FF8E4
		// (set) Token: 0x06005110 RID: 20752 RVA: 0x003016FC File Offset: 0x002FF8FC
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

		// Token: 0x17001DB4 RID: 7604
		// (get) Token: 0x06005111 RID: 20753 RVA: 0x00301708 File Offset: 0x002FF908
		// (set) Token: 0x06005112 RID: 20754 RVA: 0x00301720 File Offset: 0x002FF920
		[DataMember]
		public DataTable Prodtstb
		{
			get
			{
				return this.ProdtstbField;
			}
			set
			{
				bool flag = !object.ReferenceEquals(this.ProdtstbField, value);
				if (flag)
				{
					this.ProdtstbField = value;
					this.RaisePropertyChanged("Prodtstb");
				}
			}
		}

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x06005113 RID: 20755 RVA: 0x00301758 File Offset: 0x002FF958
		// (remove) Token: 0x06005114 RID: 20756 RVA: 0x00301790 File Offset: 0x002FF990
		public event PropertyChangedEventHandler PropertyChanged;

		// Token: 0x06005115 RID: 20757 RVA: 0x003017C8 File Offset: 0x002FF9C8
		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEvent = this.PropertyChangedEvent;
			bool flag = propertyChangedEvent != null;
			if (flag)
			{
				propertyChangedEvent(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04002428 RID: 9256
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		// Token: 0x04002429 RID: 9257
		[OptionalField]
		private DataTable ProdtstbField;
	}
}
