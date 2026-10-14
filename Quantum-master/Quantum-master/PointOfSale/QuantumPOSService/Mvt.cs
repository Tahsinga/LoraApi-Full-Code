using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace PointOfSale.QuantumPOSService
{
	// Token: 0x020001D2 RID: 466
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[DataContract(Name = "Mvt", Namespace = "http://schemas.datacontract.org/2004/07/")]
	[Serializable]
	public class Mvt : IExtensibleDataObject, INotifyPropertyChanged
	{
		// Token: 0x17001DB5 RID: 7605
		// (get) Token: 0x06005117 RID: 20759 RVA: 0x003017F8 File Offset: 0x002FF9F8
		// (set) Token: 0x06005118 RID: 20760 RVA: 0x00301810 File Offset: 0x002FFA10
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

		// Token: 0x17001DB6 RID: 7606
		// (get) Token: 0x06005119 RID: 20761 RVA: 0x0030181C File Offset: 0x002FFA1C
		// (set) Token: 0x0600511A RID: 20762 RVA: 0x00301834 File Offset: 0x002FFA34
		[DataMember]
		public DataTable Mvttb
		{
			get
			{
				return this.MvttbField;
			}
			set
			{
				bool flag = !object.ReferenceEquals(this.MvttbField, value);
				if (flag)
				{
					this.MvttbField = value;
					this.RaisePropertyChanged("Mvttb");
				}
			}
		}

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x0600511B RID: 20763 RVA: 0x0030186C File Offset: 0x002FFA6C
		// (remove) Token: 0x0600511C RID: 20764 RVA: 0x003018A4 File Offset: 0x002FFAA4
		public event PropertyChangedEventHandler PropertyChanged;

		// Token: 0x0600511D RID: 20765 RVA: 0x003018DC File Offset: 0x002FFADC
		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEvent = this.PropertyChangedEvent;
			bool flag = propertyChangedEvent != null;
			if (flag)
			{
				propertyChangedEvent(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x0400242B RID: 9259
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		// Token: 0x0400242C RID: 9260
		[OptionalField]
		private DataTable MvttbField;
	}
}
