using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace PointOfSale
{
	// Token: 0x0200008A RID: 138
	[DesignerGenerated]
	public partial class PayMethRef : Form
	{
		// Token: 0x06001F84 RID: 8068 RVA: 0x00119570 File Offset: 0x00117770
		public PayMethRef()
		{
			base.Load += this.PayMethRef_Load;
			this.paymethname = "";
			this.InitializeComponent();
		}

		// Token: 0x17000B87 RID: 2951
		// (get) Token: 0x06001F87 RID: 8071 RVA: 0x00119889 File Offset: 0x00117A89
		// (set) Token: 0x06001F88 RID: 8072 RVA: 0x00119893 File Offset: 0x00117A93
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B88 RID: 2952
		// (get) Token: 0x06001F89 RID: 8073 RVA: 0x0011989C File Offset: 0x00117A9C
		// (set) Token: 0x06001F8A RID: 8074 RVA: 0x001198A6 File Offset: 0x00117AA6
		internal virtual TextBox txtRef
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B89 RID: 2953
		// (get) Token: 0x06001F8B RID: 8075 RVA: 0x001198AF File Offset: 0x00117AAF
		// (set) Token: 0x06001F8C RID: 8076 RVA: 0x001198BC File Offset: 0x00117ABC
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

		// Token: 0x06001F8D RID: 8077 RVA: 0x00119900 File Offset: 0x00117B00
		private void PayMethRef_Load(object sender, EventArgs e)
		{
			try
			{
				base.MaximizeBox = false;
				this.GroupBox1.Text = this.paymethname + " Reference";
				base.AcceptButton = this.Button1;
				this.txtRef.Focus();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001F8E RID: 8078 RVA: 0x00119970 File Offset: 0x00117B70
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				base.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x04000EFD RID: 3837
		public string paymethname;
	}
}
