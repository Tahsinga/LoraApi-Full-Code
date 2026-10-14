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
	// Token: 0x0200005E RID: 94
	[DesignerGenerated]
	public partial class frmAccStatement : Form
	{
		// Token: 0x060013CE RID: 5070 RVA: 0x000BC348 File Offset: 0x000BA548
		public frmAccStatement()
		{
			base.Load += this.frmAccStatement_Load;
			this.InitializeComponent();
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x060013D1 RID: 5073 RVA: 0x000BC6F4 File Offset: 0x000BA8F4
		// (set) Token: 0x060013D2 RID: 5074 RVA: 0x000BC6FE File Offset: 0x000BA8FE
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x060013D3 RID: 5075 RVA: 0x000BC707 File Offset: 0x000BA907
		// (set) Token: 0x060013D4 RID: 5076 RVA: 0x000BC711 File Offset: 0x000BA911
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x060013D5 RID: 5077 RVA: 0x000BC71A File Offset: 0x000BA91A
		// (set) Token: 0x060013D6 RID: 5078 RVA: 0x000BC724 File Offset: 0x000BA924
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x060013D7 RID: 5079 RVA: 0x000BC72D File Offset: 0x000BA92D
		// (set) Token: 0x060013D8 RID: 5080 RVA: 0x000BC737 File Offset: 0x000BA937
		internal virtual BindingSource BillingCustomerTransactionsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x060013D9 RID: 5081 RVA: 0x000BC740 File Offset: 0x000BA940
		// (set) Token: 0x060013DA RID: 5082 RVA: 0x000BC74A File Offset: 0x000BA94A
		internal virtual BindingSource BillingCalcAccBalanceBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x060013DB RID: 5083 RVA: 0x000BC753 File Offset: 0x000BA953
		// (set) Token: 0x060013DC RID: 5084 RVA: 0x000BC75D File Offset: 0x000BA95D
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x060013DD RID: 5085 RVA: 0x000BC766 File Offset: 0x000BA966
		// (set) Token: 0x060013DE RID: 5086 RVA: 0x000BC770 File Offset: 0x000BA970
		internal virtual BillingCustomerTransactionsTableAdapter BillingCustomerTransactionsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x060013DF RID: 5087 RVA: 0x000BC779 File Offset: 0x000BA979
		// (set) Token: 0x060013E0 RID: 5088 RVA: 0x000BC783 File Offset: 0x000BA983
		internal virtual BillingCalcAccBalanceTableAdapter BillingCalcAccBalanceTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060013E1 RID: 5089 RVA: 0x000BC78C File Offset: 0x000BA98C
		private void frmAccStatement_Load(object sender, EventArgs e)
		{
			SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
			this.BillingCustomerTransactionsTableAdapter.Connection = sqlConnection;
			this.BillingCalcAccBalanceTableAdapter.Connection = sqlConnection;
			this.GetCompanyDetailsTableAdapter.Connection = sqlConnection;
			ReportParameter reportParameter = new ReportParameter("coid", Conversions.ToString(MyProject.Forms.Form1.coid));
			ReportParameter reportParameter2 = new ReportParameter("branch", MyProject.Forms.Form1.branch);
			ReportParameter reportParameter3 = new ReportParameter("customername", Conversions.ToString(this.customerentryno));
			ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter2, reportParameter3 };
			this.ReportViewer1.LocalReport.SetParameters(array);
			this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
			this.BillingCalcAccBalanceTableAdapter.Fill(this.POSDataSet.BillingCalcAccBalance, new int?(this.customerentryno), new int?(MyProject.Forms.Form1.coid), MyProject.Forms.Form1.branch);
			this.BillingCustomerTransactionsTableAdapter.Fill(this.POSDataSet.BillingCustomerTransactions, new int?(this.customerentryno), new int?(MyProject.Forms.Form1.coid), MyProject.Forms.Form1.branch, new int?(this.startdate), new int?(this.enddate), new int?(this.saletype));
			this.ReportViewer1.RefreshReport();
		}

		// Token: 0x04000A15 RID: 2581
		public int customerentryno;

		// Token: 0x04000A16 RID: 2582
		public int startdate;

		// Token: 0x04000A17 RID: 2583
		public int enddate;

		// Token: 0x04000A18 RID: 2584
		public int saletype;
	}
}
