using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace PointOfSale
{
	// Token: 0x0200020F RID: 527
	[DesignerGenerated]
	public partial class ViewInvoiceDetails : Form
	{
		// Token: 0x06005EAB RID: 24235 RVA: 0x00364014 File Offset: 0x00362214
		public ViewInvoiceDetails()
		{
			base.Load += this.ViewInvoiceDetails_Load;
			this.InitializeComponent();
		}

		// Token: 0x17002235 RID: 8757
		// (get) Token: 0x06005EAE RID: 24238 RVA: 0x003641B0 File Offset: 0x003623B0
		// (set) Token: 0x06005EAF RID: 24239 RVA: 0x003641BA File Offset: 0x003623BA
		internal virtual DataGridView DataGridView1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06005EB0 RID: 24240 RVA: 0x003641C4 File Offset: 0x003623C4
		private void ViewInvoiceDetails_Load(object sender, EventArgs e)
		{
			try
			{
				this.DataGridView1.DataSource = this.inv_details;
				this.Text = this.inv_header;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading data. Detail: " + ex.Message);
			}
		}

		// Token: 0x0400298F RID: 10639
		public string inv_header;

		// Token: 0x04002990 RID: 10640
		public DataTable inv_details;
	}
}
