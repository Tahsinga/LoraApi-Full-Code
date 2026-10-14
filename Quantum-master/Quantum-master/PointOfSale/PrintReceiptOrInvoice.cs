using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace PointOfSale
{
	// Token: 0x0200016D RID: 365
	[DesignerGenerated]
	public partial class PrintReceiptOrInvoice : Form
	{
		// Token: 0x06003344 RID: 13124 RVA: 0x001BC13A File Offset: 0x001BA33A
		public PrintReceiptOrInvoice()
		{
			base.Load += this.PrintReceiptOrInvoice_Load;
			this.InitializeComponent();
		}

		// Token: 0x17001306 RID: 4870
		// (get) Token: 0x06003347 RID: 13127 RVA: 0x001BC49B File Offset: 0x001BA69B
		// (set) Token: 0x06003348 RID: 13128 RVA: 0x001BC4A8 File Offset: 0x001BA6A8
		internal virtual Button Button1
		{
			[CompilerGenerated]
			get
			{
				return this._Button1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button1_Click);
				Button button = this._Button1;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button1 = value;
				button = this._Button1;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17001307 RID: 4871
		// (get) Token: 0x06003349 RID: 13129 RVA: 0x001BC4EB File Offset: 0x001BA6EB
		// (set) Token: 0x0600334A RID: 13130 RVA: 0x001BC4F8 File Offset: 0x001BA6F8
		internal virtual Button Button2
		{
			[CompilerGenerated]
			get
			{
				return this._Button2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button2_Click);
				Button button = this._Button2;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button2 = value;
				button = this._Button2;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17001308 RID: 4872
		// (get) Token: 0x0600334B RID: 13131 RVA: 0x001BC53B File Offset: 0x001BA73B
		// (set) Token: 0x0600334C RID: 13132 RVA: 0x001BC548 File Offset: 0x001BA748
		internal virtual Button Button3
		{
			[CompilerGenerated]
			get
			{
				return this._Button3;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button3_Click);
				Button button = this._Button3;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button3 = value;
				button = this._Button3;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17001309 RID: 4873
		// (get) Token: 0x0600334D RID: 13133 RVA: 0x001BC58B File Offset: 0x001BA78B
		// (set) Token: 0x0600334E RID: 13134 RVA: 0x001BC595 File Offset: 0x001BA795
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x0600334F RID: 13135 RVA: 0x00002A30 File Offset: 0x00000C30
		private void PrintReceiptOrInvoice_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06003350 RID: 13136 RVA: 0x001BC5A0 File Offset: 0x001BA7A0
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.printcode = 2;
				base.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06003351 RID: 13137 RVA: 0x001BC5E0 File Offset: 0x001BA7E0
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				this.printcode = 1;
				base.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06003352 RID: 13138 RVA: 0x001BC620 File Offset: 0x001BA820
		private void Button3_Click(object sender, EventArgs e)
		{
			try
			{
				this.printcode = 3;
				base.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x040015F3 RID: 5619
		public int printcode;
	}
}
