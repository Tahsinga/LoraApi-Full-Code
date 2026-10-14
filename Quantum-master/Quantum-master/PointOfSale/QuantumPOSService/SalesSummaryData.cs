using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace PointOfSale.QuantumPOSService
{
	// Token: 0x020001C9 RID: 457
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[DataContract(Name = "SalesSummaryData", Namespace = "http://schemas.datacontract.org/2004/07/")]
	[Serializable]
	public class SalesSummaryData : IExtensibleDataObject, INotifyPropertyChanged
	{
		// Token: 0x17001DA3 RID: 7587
		// (get) Token: 0x060050CF RID: 20687 RVA: 0x00300E44 File Offset: 0x002FF044
		// (set) Token: 0x060050D0 RID: 20688 RVA: 0x00300E5C File Offset: 0x002FF05C
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

		// Token: 0x17001DA4 RID: 7588
		// (get) Token: 0x060050D1 RID: 20689 RVA: 0x00300E68 File Offset: 0x002FF068
		// (set) Token: 0x060050D2 RID: 20690 RVA: 0x00300E80 File Offset: 0x002FF080
		[DataMember]
		public DataTable SalesSummarytb
		{
			get
			{
				return this.SalesSummarytbField;
			}
			set
			{
				bool flag = !object.ReferenceEquals(this.SalesSummarytbField, value);
				if (flag)
				{
					this.SalesSummarytbField = value;
					this.RaisePropertyChanged("SalesSummarytb");
				}
			}
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x060050D3 RID: 20691 RVA: 0x00300EB8 File Offset: 0x002FF0B8
		// (remove) Token: 0x060050D4 RID: 20692 RVA: 0x00300EF0 File Offset: 0x002FF0F0
		public event PropertyChangedEventHandler PropertyChanged;

		// Token: 0x060050D5 RID: 20693 RVA: 0x00300F28 File Offset: 0x002FF128
		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEvent = this.PropertyChangedEvent;
			bool flag = propertyChangedEvent != null;
			if (flag)
			{
				propertyChangedEvent(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04002410 RID: 9232
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		// Token: 0x04002411 RID: 9233
		[OptionalField]
		private DataTable SalesSummarytbField;
	}
}
