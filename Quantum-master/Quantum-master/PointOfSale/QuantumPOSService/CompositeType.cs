using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace PointOfSale.QuantumPOSService
{
	// Token: 0x020001C8 RID: 456
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[DataContract(Name = "CompositeType", Namespace = "http://schemas.datacontract.org/2004/07/")]
	[Serializable]
	public class CompositeType : IExtensibleDataObject, INotifyPropertyChanged
	{
		// Token: 0x17001DA0 RID: 7584
		// (get) Token: 0x060050C5 RID: 20677 RVA: 0x00300CE0 File Offset: 0x002FEEE0
		// (set) Token: 0x060050C6 RID: 20678 RVA: 0x00300CF8 File Offset: 0x002FEEF8
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

		// Token: 0x17001DA1 RID: 7585
		// (get) Token: 0x060050C7 RID: 20679 RVA: 0x00300D04 File Offset: 0x002FEF04
		// (set) Token: 0x060050C8 RID: 20680 RVA: 0x00300D1C File Offset: 0x002FEF1C
		[DataMember]
		public bool BoolValue
		{
			get
			{
				return this.BoolValueField;
			}
			set
			{
				bool flag = !this.BoolValueField.Equals(value);
				if (flag)
				{
					this.BoolValueField = value;
					this.RaisePropertyChanged("BoolValue");
				}
			}
		}

		// Token: 0x17001DA2 RID: 7586
		// (get) Token: 0x060050C9 RID: 20681 RVA: 0x00300D54 File Offset: 0x002FEF54
		// (set) Token: 0x060050CA RID: 20682 RVA: 0x00300D6C File Offset: 0x002FEF6C
		[DataMember]
		public string StringValue
		{
			get
			{
				return this.StringValueField;
			}
			set
			{
				bool flag = !object.ReferenceEquals(this.StringValueField, value);
				if (flag)
				{
					this.StringValueField = value;
					this.RaisePropertyChanged("StringValue");
				}
			}
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x060050CB RID: 20683 RVA: 0x00300DA4 File Offset: 0x002FEFA4
		// (remove) Token: 0x060050CC RID: 20684 RVA: 0x00300DDC File Offset: 0x002FEFDC
		public event PropertyChangedEventHandler PropertyChanged;

		// Token: 0x060050CD RID: 20685 RVA: 0x00300E14 File Offset: 0x002FF014
		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEvent = this.PropertyChangedEvent;
			bool flag = propertyChangedEvent != null;
			if (flag)
			{
				propertyChangedEvent(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x0400240C RID: 9228
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		// Token: 0x0400240D RID: 9229
		[OptionalField]
		private bool BoolValueField;

		// Token: 0x0400240E RID: 9230
		[OptionalField]
		private string StringValueField;
	}
}
