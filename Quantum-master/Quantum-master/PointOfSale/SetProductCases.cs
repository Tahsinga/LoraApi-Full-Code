using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace PointOfSale
{
	// Token: 0x020001DE RID: 478
	[DesignerGenerated]
	public partial class SetProductCases : UserControl
	{
		// Token: 0x060053D5 RID: 21461 RVA: 0x0030A675 File Offset: 0x00308875
		public SetProductCases()
		{
			this.InitializeComponent();
		}

		// Token: 0x17001E07 RID: 7687
		// (get) Token: 0x060053D8 RID: 21464 RVA: 0x0030B56A File Offset: 0x0030976A
		// (set) Token: 0x060053D9 RID: 21465 RVA: 0x0030B574 File Offset: 0x00309774
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E08 RID: 7688
		// (get) Token: 0x060053DA RID: 21466 RVA: 0x0030B57D File Offset: 0x0030977D
		// (set) Token: 0x060053DB RID: 21467 RVA: 0x0030B588 File Offset: 0x00309788
		internal virtual Label Label1
		{
			[CompilerGenerated]
			get
			{
				return this._Label1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label1_Click);
				Label label = this._Label1;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label1 = value;
				label = this._Label1;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x17001E09 RID: 7689
		// (get) Token: 0x060053DC RID: 21468 RVA: 0x0030B5CB File Offset: 0x003097CB
		// (set) Token: 0x060053DD RID: 21469 RVA: 0x0030B5D5 File Offset: 0x003097D5
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E0A RID: 7690
		// (get) Token: 0x060053DE RID: 21470 RVA: 0x0030B5DE File Offset: 0x003097DE
		// (set) Token: 0x060053DF RID: 21471 RVA: 0x0030B5E8 File Offset: 0x003097E8
		internal virtual DataGridView DGVSearch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E0B RID: 7691
		// (get) Token: 0x060053E0 RID: 21472 RVA: 0x0030B5F1 File Offset: 0x003097F1
		// (set) Token: 0x060053E1 RID: 21473 RVA: 0x0030B5FB File Offset: 0x003097FB
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E0C RID: 7692
		// (get) Token: 0x060053E2 RID: 21474 RVA: 0x0030B604 File Offset: 0x00309804
		// (set) Token: 0x060053E3 RID: 21475 RVA: 0x0030B60E File Offset: 0x0030980E
		internal virtual Label Label34
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E0D RID: 7693
		// (get) Token: 0x060053E4 RID: 21476 RVA: 0x0030B617 File Offset: 0x00309817
		// (set) Token: 0x060053E5 RID: 21477 RVA: 0x0030B621 File Offset: 0x00309821
		internal virtual Button Button3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E0E RID: 7694
		// (get) Token: 0x060053E6 RID: 21478 RVA: 0x0030B62A File Offset: 0x0030982A
		// (set) Token: 0x060053E7 RID: 21479 RVA: 0x0030B634 File Offset: 0x00309834
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E0F RID: 7695
		// (get) Token: 0x060053E8 RID: 21480 RVA: 0x0030B63D File Offset: 0x0030983D
		// (set) Token: 0x060053E9 RID: 21481 RVA: 0x0030B647 File Offset: 0x00309847
		internal virtual TextBox txtsearch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E10 RID: 7696
		// (get) Token: 0x060053EA RID: 21482 RVA: 0x0030B650 File Offset: 0x00309850
		// (set) Token: 0x060053EB RID: 21483 RVA: 0x0030B65A File Offset: 0x0030985A
		internal virtual Panel Panel3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E11 RID: 7697
		// (get) Token: 0x060053EC RID: 21484 RVA: 0x0030B663 File Offset: 0x00309863
		// (set) Token: 0x060053ED RID: 21485 RVA: 0x0030B66D File Offset: 0x0030986D
		internal virtual Label Label20
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E12 RID: 7698
		// (get) Token: 0x060053EE RID: 21486 RVA: 0x0030B676 File Offset: 0x00309876
		// (set) Token: 0x060053EF RID: 21487 RVA: 0x0030B680 File Offset: 0x00309880
		internal virtual TextBox txtBarCode
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E13 RID: 7699
		// (get) Token: 0x060053F0 RID: 21488 RVA: 0x0030B689 File Offset: 0x00309889
		// (set) Token: 0x060053F1 RID: 21489 RVA: 0x0030B693 File Offset: 0x00309893
		internal virtual Label Label24
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E14 RID: 7700
		// (get) Token: 0x060053F2 RID: 21490 RVA: 0x0030B69C File Offset: 0x0030989C
		// (set) Token: 0x060053F3 RID: 21491 RVA: 0x0030B6A6 File Offset: 0x003098A6
		internal virtual TextBox txtSearchProductCode
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E15 RID: 7701
		// (get) Token: 0x060053F4 RID: 21492 RVA: 0x0030B6AF File Offset: 0x003098AF
		// (set) Token: 0x060053F5 RID: 21493 RVA: 0x0030B6B9 File Offset: 0x003098B9
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E16 RID: 7702
		// (get) Token: 0x060053F6 RID: 21494 RVA: 0x0030B6C2 File Offset: 0x003098C2
		// (set) Token: 0x060053F7 RID: 21495 RVA: 0x0030B6CC File Offset: 0x003098CC
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E17 RID: 7703
		// (get) Token: 0x060053F8 RID: 21496 RVA: 0x0030B6D5 File Offset: 0x003098D5
		// (set) Token: 0x060053F9 RID: 21497 RVA: 0x0030B6DF File Offset: 0x003098DF
		internal virtual TextBox txtCaseQty
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E18 RID: 7704
		// (get) Token: 0x060053FA RID: 21498 RVA: 0x0030B6E8 File Offset: 0x003098E8
		// (set) Token: 0x060053FB RID: 21499 RVA: 0x0030B6F2 File Offset: 0x003098F2
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E19 RID: 7705
		// (get) Token: 0x060053FC RID: 21500 RVA: 0x0030B6FB File Offset: 0x003098FB
		// (set) Token: 0x060053FD RID: 21501 RVA: 0x0030B705 File Offset: 0x00309905
		internal virtual CheckBox CheckBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E1A RID: 7706
		// (get) Token: 0x060053FE RID: 21502 RVA: 0x0030B70E File Offset: 0x0030990E
		// (set) Token: 0x060053FF RID: 21503 RVA: 0x0030B718 File Offset: 0x00309918
		internal virtual TextBox txtDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06005400 RID: 21504 RVA: 0x0030B724 File Offset: 0x00309924
		private void Label1_Click(object sender, EventArgs e)
		{
			try
			{
				base.Dispose();
			}
			catch (Exception ex)
			{
			}
		}
	}
}
