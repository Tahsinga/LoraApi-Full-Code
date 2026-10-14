using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace PointOfSale
{
	// Token: 0x02000041 RID: 65
	[DesignerGenerated]
	public partial class DespatchReprint : Form
	{
		// Token: 0x06000E87 RID: 3719 RVA: 0x0008B4FF File Offset: 0x000896FF
		public DespatchReprint()
		{
			base.Load += this.DespatchReprint_Load;
			this.InitializeComponent();
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06000E8A RID: 3722 RVA: 0x0008B650 File Offset: 0x00089850
		// (set) Token: 0x06000E8B RID: 3723 RVA: 0x0008B65A File Offset: 0x0008985A
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x0008B664 File Offset: 0x00089864
		private void DespatchReprint_Load(object sender, EventArgs e)
		{
			try
			{
				DespatchReportForPeriod despatchReportForPeriod = new DespatchReportForPeriod();
				this.Panel1.Controls.Add(despatchReportForPeriod);
				despatchReportForPeriod.Dock = DockStyle.Fill;
				despatchReportForPeriod.BringToFront();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error occured. Detail: " + ex.Message);
			}
		}
	}
}
