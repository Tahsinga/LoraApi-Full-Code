using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace PointOfSale.QuantumPOSService
{
	// Token: 0x020001C7 RID: 455
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[DataContract(Name = "ManuIng", Namespace = "http://schemas.datacontract.org/2004/07/")]
	[Serializable]
	public class ManuIng : IExtensibleDataObject, INotifyPropertyChanged
	{
		// Token: 0x17001D9E RID: 7582
		// (get) Token: 0x060050BD RID: 20669 RVA: 0x00300BCC File Offset: 0x002FEDCC
		// (set) Token: 0x060050BE RID: 20670 RVA: 0x00300BE4 File Offset: 0x002FEDE4
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

		// Token: 0x17001D9F RID: 7583
		// (get) Token: 0x060050BF RID: 20671 RVA: 0x00300BF0 File Offset: 0x002FEDF0
		// (set) Token: 0x060050C0 RID: 20672 RVA: 0x00300C08 File Offset: 0x002FEE08
		[DataMember]
		public DataTable ManuIngtb
		{
			get
			{
				return this.ManuIngtbField;
			}
			set
			{
				bool flag = !object.ReferenceEquals(this.ManuIngtbField, value);
				if (flag)
				{
					this.ManuIngtbField = value;
					this.RaisePropertyChanged("ManuIngtb");
				}
			}
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x060050C1 RID: 20673 RVA: 0x00300C40 File Offset: 0x002FEE40
		// (remove) Token: 0x060050C2 RID: 20674 RVA: 0x00300C78 File Offset: 0x002FEE78
		public event PropertyChangedEventHandler PropertyChanged;

		// Token: 0x060050C3 RID: 20675 RVA: 0x00300CB0 File Offset: 0x002FEEB0
		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEvent = this.PropertyChangedEvent;
			bool flag = propertyChangedEvent != null;
			if (flag)
			{
				propertyChangedEvent(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04002409 RID: 9225
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		// Token: 0x0400240A RID: 9226
		[OptionalField]
		private DataTable ManuIngtbField;
	}
}
