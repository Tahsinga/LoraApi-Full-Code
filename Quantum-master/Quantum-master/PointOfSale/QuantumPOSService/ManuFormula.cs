using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace PointOfSale.QuantumPOSService
{
	// Token: 0x020001BF RID: 447
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[DataContract(Name = "ManuFormula", Namespace = "http://schemas.datacontract.org/2004/07/")]
	[Serializable]
	public class ManuFormula : IExtensibleDataObject, INotifyPropertyChanged
	{
		// Token: 0x17001D8E RID: 7566
		// (get) Token: 0x0600507D RID: 20605 RVA: 0x0030032C File Offset: 0x002FE52C
		// (set) Token: 0x0600507E RID: 20606 RVA: 0x00300344 File Offset: 0x002FE544
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

		// Token: 0x17001D8F RID: 7567
		// (get) Token: 0x0600507F RID: 20607 RVA: 0x00300350 File Offset: 0x002FE550
		// (set) Token: 0x06005080 RID: 20608 RVA: 0x00300368 File Offset: 0x002FE568
		[DataMember]
		public DataTable Manuformulatb
		{
			get
			{
				return this.ManuformulatbField;
			}
			set
			{
				bool flag = !object.ReferenceEquals(this.ManuformulatbField, value);
				if (flag)
				{
					this.ManuformulatbField = value;
					this.RaisePropertyChanged("Manuformulatb");
				}
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06005081 RID: 20609 RVA: 0x003003A0 File Offset: 0x002FE5A0
		// (remove) Token: 0x06005082 RID: 20610 RVA: 0x003003D8 File Offset: 0x002FE5D8
		public event PropertyChangedEventHandler PropertyChanged;

		// Token: 0x06005083 RID: 20611 RVA: 0x00300410 File Offset: 0x002FE610
		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEvent = this.PropertyChangedEvent;
			bool flag = propertyChangedEvent != null;
			if (flag)
			{
				propertyChangedEvent(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x040023F1 RID: 9201
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		// Token: 0x040023F2 RID: 9202
		[OptionalField]
		private DataTable ManuformulatbField;
	}
}
