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
	// Token: 0x020001FC RID: 508
	[DesignerGenerated]
	public partial class SupplierAging : Form
	{
		// Token: 0x06005B70 RID: 23408 RVA: 0x0034AF68 File Offset: 0x00349168
		public SupplierAging()
		{
			base.Load += this.SupplierAging_Load;
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x170020F3 RID: 8435
		// (get) Token: 0x06005B73 RID: 23411 RVA: 0x0034B379 File Offset: 0x00349579
		// (set) Token: 0x06005B74 RID: 23412 RVA: 0x0034B383 File Offset: 0x00349583
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020F4 RID: 8436
		// (get) Token: 0x06005B75 RID: 23413 RVA: 0x0034B38C File Offset: 0x0034958C
		// (set) Token: 0x06005B76 RID: 23414 RVA: 0x0034B396 File Offset: 0x00349596
		internal virtual Label lblsuppliername
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020F5 RID: 8437
		// (get) Token: 0x06005B77 RID: 23415 RVA: 0x0034B39F File Offset: 0x0034959F
		// (set) Token: 0x06005B78 RID: 23416 RVA: 0x0034B3A9 File Offset: 0x003495A9
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020F6 RID: 8438
		// (get) Token: 0x06005B79 RID: 23417 RVA: 0x0034B3B2 File Offset: 0x003495B2
		// (set) Token: 0x06005B7A RID: 23418 RVA: 0x0034B3BC File Offset: 0x003495BC
		internal virtual DataGridView dgvAging
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020F7 RID: 8439
		// (get) Token: 0x06005B7B RID: 23419 RVA: 0x0034B3C5 File Offset: 0x003495C5
		// (set) Token: 0x06005B7C RID: 23420 RVA: 0x0034B3D0 File Offset: 0x003495D0
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

		// Token: 0x170020F8 RID: 8440
		// (get) Token: 0x06005B7D RID: 23421 RVA: 0x0034B413 File Offset: 0x00349613
		// (set) Token: 0x06005B7E RID: 23422 RVA: 0x0034B41D File Offset: 0x0034961D
		internal virtual SaveFileDialog SaveFileDialog1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06005B7F RID: 23423 RVA: 0x0034B428 File Offset: 0x00349628
		private void SupplierAging_Load(object sender, EventArgs e)
		{
			try
			{
				this.lblsuppliername.Text = this.suppliername;
				this.dgvAging.DataSource = this.pf.GetSupplierAging(MyProject.Forms.Form1.coid, this.supplierid, MyProject.Forms.Form1.Constring);
				this.dgvAging.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				this.dgvAging.ReadOnly = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading details. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005B80 RID: 23424 RVA: 0x0034B4D8 File Offset: 0x003496D8
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.dgvAging.RowCount > 0;
				if (flag)
				{
					this.SaveFileDialog1.Filter = "CSV Files (*.csv*)|*.csv";
					bool flag2 = this.SaveFileDialog1.ShowDialog() == DialogResult.OK;
					if (flag2)
					{
						this.pf.DATAGRIDVIEW_TO_CSV(this.dgvAging, this.SaveFileDialog1.FileName);
					}
					MessageBox.Show("Data exported to excel.");
				}
				else
				{
					MessageBox.Show("There are no items to export.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error exporting. Detail: " + ex.Message);
			}
		}

		// Token: 0x04002800 RID: 10240
		public int supplierid;

		// Token: 0x04002801 RID: 10241
		public string suppliername;

		// Token: 0x04002802 RID: 10242
		private PublicFunctions pf;
	}
}
