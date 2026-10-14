using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;
using PointOfSale.POSDataSetTableAdapters;

namespace PointOfSale
{
	// Token: 0x02000184 RID: 388
	[DesignerGenerated]
	public partial class ReparisCheckOut : Form
	{
		// Token: 0x060039B9 RID: 14777 RVA: 0x001F62BC File Offset: 0x001F44BC
		public ReparisCheckOut()
		{
			base.Load += this.ReparisCheckOut_Load;
			this.InitializeComponent();
		}

		// Token: 0x17001550 RID: 5456
		// (get) Token: 0x060039BC RID: 14780 RVA: 0x001F6643 File Offset: 0x001F4843
		// (set) Token: 0x060039BD RID: 14781 RVA: 0x001F664D File Offset: 0x001F484D
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001551 RID: 5457
		// (get) Token: 0x060039BE RID: 14782 RVA: 0x001F6656 File Offset: 0x001F4856
		// (set) Token: 0x060039BF RID: 14783 RVA: 0x001F6660 File Offset: 0x001F4860
		internal virtual BindingSource GetCompanyDetailsForCoidBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001552 RID: 5458
		// (get) Token: 0x060039C0 RID: 14784 RVA: 0x001F6669 File Offset: 0x001F4869
		// (set) Token: 0x060039C1 RID: 14785 RVA: 0x001F6673 File Offset: 0x001F4873
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001553 RID: 5459
		// (get) Token: 0x060039C2 RID: 14786 RVA: 0x001F667C File Offset: 0x001F487C
		// (set) Token: 0x060039C3 RID: 14787 RVA: 0x001F6686 File Offset: 0x001F4886
		internal virtual BindingSource RepairsViewBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001554 RID: 5460
		// (get) Token: 0x060039C4 RID: 14788 RVA: 0x001F668F File Offset: 0x001F488F
		// (set) Token: 0x060039C5 RID: 14789 RVA: 0x001F6699 File Offset: 0x001F4899
		internal virtual BindingSource GetBranchDetails1BindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001555 RID: 5461
		// (get) Token: 0x060039C6 RID: 14790 RVA: 0x001F66A2 File Offset: 0x001F48A2
		// (set) Token: 0x060039C7 RID: 14791 RVA: 0x001F66AC File Offset: 0x001F48AC
		internal virtual GetCompanyDetailsForCoidTableAdapter GetCompanyDetailsForCoidTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001556 RID: 5462
		// (get) Token: 0x060039C8 RID: 14792 RVA: 0x001F66B5 File Offset: 0x001F48B5
		// (set) Token: 0x060039C9 RID: 14793 RVA: 0x001F66BF File Offset: 0x001F48BF
		internal virtual RepairsViewTableAdapter RepairsViewTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001557 RID: 5463
		// (get) Token: 0x060039CA RID: 14794 RVA: 0x001F66C8 File Offset: 0x001F48C8
		// (set) Token: 0x060039CB RID: 14795 RVA: 0x001F66D2 File Offset: 0x001F48D2
		internal virtual GetBranchDetails1TableAdapter GetBranchDetails1TableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060039CC RID: 14796 RVA: 0x001F66DC File Offset: 0x001F48DC
		private void ReparisCheckOut_Load(object sender, EventArgs e)
		{
			try
			{
				this.RunReport();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading report. Details: " + ex.Message);
			}
		}

		// Token: 0x060039CD RID: 14797 RVA: 0x001F672C File Offset: 0x001F492C
		private void RunReport()
		{
			SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
			this.GetCompanyDetailsForCoidTableAdapter.Connection = sqlConnection;
			this.RepairsViewTableAdapter.Connection = sqlConnection;
			this.GetBranchDetails1TableAdapter.Connection = sqlConnection;
			this.GetCompanyDetailsForCoidTableAdapter.Fill(this.POSDataSet.GetCompanyDetailsForCoid, new int?(MyProject.Forms.Form1.coid));
			this.RepairsViewTableAdapter.Fill(this.POSDataSet.RepairsView, new int?(MyProject.Forms.Form1.coid), MyProject.Forms.Form1.branch, new int?(this.CheckInEntryNo));
			this.GetBranchDetails1TableAdapter.Fill(this.POSDataSet.GetBranchDetails1, MyProject.Forms.Form1.branch, new int?(MyProject.Forms.Form1.coid), new int?(0));
			this.ReportViewer1.RefreshReport();
		}

		// Token: 0x040018A2 RID: 6306
		public int CheckInEntryNo;
	}
}
