using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;

namespace PointOfSale
{
	// Token: 0x02000078 RID: 120
	[DesignerGenerated]
	public partial class NegativeStockSetting : Form
	{
		// Token: 0x060019F8 RID: 6648 RVA: 0x000EEEBC File Offset: 0x000ED0BC
		public NegativeStockSetting()
		{
			base.Load += this.NegativeStockSetting_Load;
			this.publicfunction = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x060019FB RID: 6651 RVA: 0x000EF0CA File Offset: 0x000ED2CA
		// (set) Token: 0x060019FC RID: 6652 RVA: 0x000EF0D4 File Offset: 0x000ED2D4
		internal virtual CheckBox CheckBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x060019FD RID: 6653 RVA: 0x000EF0DD File Offset: 0x000ED2DD
		// (set) Token: 0x060019FE RID: 6654 RVA: 0x000EF0E8 File Offset: 0x000ED2E8
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

		// Token: 0x060019FF RID: 6655 RVA: 0x000EF12C File Offset: 0x000ED32C
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool @checked = this.CheckBox1.Checked;
				if (@checked)
				{
					this.publicfunction.AddUpdateAppSettings("NegativeStock", "1");
					MyProject.Forms.Form1.NegativeStock = 1;
				}
				else
				{
					this.publicfunction.AddUpdateAppSettings("NegativeStock", "0");
					MyProject.Forms.Form1.NegativeStock = 0;
				}
				MessageBox.Show("Settings saved.", "Information");
				base.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving data. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001A00 RID: 6656 RVA: 0x000EF1EC File Offset: 0x000ED3EC
		private void FetchNegStockSettings()
		{
			bool flag = MyProject.Forms.Form1.NegativeStock == 1;
			if (flag)
			{
				this.CheckBox1.Checked = true;
			}
			else
			{
				this.CheckBox1.Checked = false;
			}
		}

		// Token: 0x06001A01 RID: 6657 RVA: 0x000EF230 File Offset: 0x000ED430
		private void NegativeStockSetting_Load(object sender, EventArgs e)
		{
			try
			{
				this.FetchNegStockSettings();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x04000C8C RID: 3212
		private PublicFunctions publicfunction;
	}
}
