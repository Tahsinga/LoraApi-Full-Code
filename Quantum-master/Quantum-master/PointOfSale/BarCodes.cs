using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace PointOfSale
{
	// Token: 0x02000012 RID: 18
	[DesignerGenerated]
	public partial class BarCodes : Form
	{
		// Token: 0x060002F8 RID: 760 RVA: 0x0001A7C0 File Offset: 0x000189C0
		public BarCodes()
		{
			this.publicfunction = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060002FB RID: 763 RVA: 0x0001A9B1 File Offset: 0x00018BB1
		// (set) Token: 0x060002FC RID: 764 RVA: 0x0001A9BB File Offset: 0x00018BBB
		internal virtual CheckBox chkBarCodes
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060002FD RID: 765 RVA: 0x0001A9C4 File Offset: 0x00018BC4
		// (set) Token: 0x060002FE RID: 766 RVA: 0x0001A9D0 File Offset: 0x00018BD0
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

		// Token: 0x060002FF RID: 767 RVA: 0x0001AA14 File Offset: 0x00018C14
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool @checked = this.chkBarCodes.Checked;
				int num;
				if (@checked)
				{
					num = 1;
				}
				else
				{
					num = 0;
				}
				this.publicfunction.AddUpdateAppSettings("BarCode", Conversions.ToString(num));
				MessageBox.Show("Bar Code settings successfully saved.");
				base.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving data. Detal: " + ex.Message);
			}
		}

		// Token: 0x0400014B RID: 331
		private PublicFunctions publicfunction;
	}
}
