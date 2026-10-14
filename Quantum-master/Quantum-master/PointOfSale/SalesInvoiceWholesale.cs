using System;
using System.Collections;
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
	// Token: 0x020001B1 RID: 433
	[DesignerGenerated]
	public partial class SalesInvoiceWholesale : Form
	{
		// Token: 0x06004D83 RID: 19843 RVA: 0x002DE5A0 File Offset: 0x002DC7A0
		public SalesInvoiceWholesale()
		{
			base.Load += this.SalesInvoiceWholesale_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x17001C7C RID: 7292
		// (get) Token: 0x06004D86 RID: 19846 RVA: 0x002DEC73 File Offset: 0x002DCE73
		// (set) Token: 0x06004D87 RID: 19847 RVA: 0x002DEC7D File Offset: 0x002DCE7D
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C7D RID: 7293
		// (get) Token: 0x06004D88 RID: 19848 RVA: 0x002DEC86 File Offset: 0x002DCE86
		// (set) Token: 0x06004D89 RID: 19849 RVA: 0x002DEC90 File Offset: 0x002DCE90
		internal virtual BindingSource GetPaymentMethodsForInvoiceBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C7E RID: 7294
		// (get) Token: 0x06004D8A RID: 19850 RVA: 0x002DEC99 File Offset: 0x002DCE99
		// (set) Token: 0x06004D8B RID: 19851 RVA: 0x002DECA3 File Offset: 0x002DCEA3
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C7F RID: 7295
		// (get) Token: 0x06004D8C RID: 19852 RVA: 0x002DECAC File Offset: 0x002DCEAC
		// (set) Token: 0x06004D8D RID: 19853 RVA: 0x002DECB6 File Offset: 0x002DCEB6
		internal virtual BindingSource GetUserForInvoiceBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C80 RID: 7296
		// (get) Token: 0x06004D8E RID: 19854 RVA: 0x002DECBF File Offset: 0x002DCEBF
		// (set) Token: 0x06004D8F RID: 19855 RVA: 0x002DECC9 File Offset: 0x002DCEC9
		internal virtual BindingSource FetchCustomerDetailsFromInvBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C81 RID: 7297
		// (get) Token: 0x06004D90 RID: 19856 RVA: 0x002DECD2 File Offset: 0x002DCED2
		// (set) Token: 0x06004D91 RID: 19857 RVA: 0x002DECDC File Offset: 0x002DCEDC
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C82 RID: 7298
		// (get) Token: 0x06004D92 RID: 19858 RVA: 0x002DECE5 File Offset: 0x002DCEE5
		// (set) Token: 0x06004D93 RID: 19859 RVA: 0x002DECEF File Offset: 0x002DCEEF
		internal virtual BindingSource SalesByInvoiceNumberBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C83 RID: 7299
		// (get) Token: 0x06004D94 RID: 19860 RVA: 0x002DECF8 File Offset: 0x002DCEF8
		// (set) Token: 0x06004D95 RID: 19861 RVA: 0x002DED02 File Offset: 0x002DCF02
		internal virtual BindingSource GetBankingDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C84 RID: 7300
		// (get) Token: 0x06004D96 RID: 19862 RVA: 0x002DED0B File Offset: 0x002DCF0B
		// (set) Token: 0x06004D97 RID: 19863 RVA: 0x002DED15 File Offset: 0x002DCF15
		internal virtual BindingSource BankingDetails2BindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C85 RID: 7301
		// (get) Token: 0x06004D98 RID: 19864 RVA: 0x002DED1E File Offset: 0x002DCF1E
		// (set) Token: 0x06004D99 RID: 19865 RVA: 0x002DED28 File Offset: 0x002DCF28
		internal virtual BindingSource GetBranchDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C86 RID: 7302
		// (get) Token: 0x06004D9A RID: 19866 RVA: 0x002DED31 File Offset: 0x002DCF31
		// (set) Token: 0x06004D9B RID: 19867 RVA: 0x002DED3B File Offset: 0x002DCF3B
		internal virtual GetPaymentMethodsForInvoiceTableAdapter GetPaymentMethodsForInvoiceTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C87 RID: 7303
		// (get) Token: 0x06004D9C RID: 19868 RVA: 0x002DED44 File Offset: 0x002DCF44
		// (set) Token: 0x06004D9D RID: 19869 RVA: 0x002DED4E File Offset: 0x002DCF4E
		internal virtual GetUserForInvoiceTableAdapter GetUserForInvoiceTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C88 RID: 7304
		// (get) Token: 0x06004D9E RID: 19870 RVA: 0x002DED57 File Offset: 0x002DCF57
		// (set) Token: 0x06004D9F RID: 19871 RVA: 0x002DED61 File Offset: 0x002DCF61
		internal virtual FetchCustomerDetailsFromInvTableAdapter FetchCustomerDetailsFromInvTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C89 RID: 7305
		// (get) Token: 0x06004DA0 RID: 19872 RVA: 0x002DED6A File Offset: 0x002DCF6A
		// (set) Token: 0x06004DA1 RID: 19873 RVA: 0x002DED74 File Offset: 0x002DCF74
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C8A RID: 7306
		// (get) Token: 0x06004DA2 RID: 19874 RVA: 0x002DED7D File Offset: 0x002DCF7D
		// (set) Token: 0x06004DA3 RID: 19875 RVA: 0x002DED87 File Offset: 0x002DCF87
		internal virtual SalesByInvoiceNumberTableAdapter SalesByInvoiceNumberTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C8B RID: 7307
		// (get) Token: 0x06004DA4 RID: 19876 RVA: 0x002DED90 File Offset: 0x002DCF90
		// (set) Token: 0x06004DA5 RID: 19877 RVA: 0x002DED9A File Offset: 0x002DCF9A
		internal virtual GetBankingDetailsTableAdapter GetBankingDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C8C RID: 7308
		// (get) Token: 0x06004DA6 RID: 19878 RVA: 0x002DEDA3 File Offset: 0x002DCFA3
		// (set) Token: 0x06004DA7 RID: 19879 RVA: 0x002DEDAD File Offset: 0x002DCFAD
		internal virtual BankingDetails2TableAdapter BankingDetails2TableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C8D RID: 7309
		// (get) Token: 0x06004DA8 RID: 19880 RVA: 0x002DEDB6 File Offset: 0x002DCFB6
		// (set) Token: 0x06004DA9 RID: 19881 RVA: 0x002DEDC0 File Offset: 0x002DCFC0
		internal virtual GetBranchDetailsTableAdapter GetBranchDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06004DAA RID: 19882 RVA: 0x002DEDCC File Offset: 0x002DCFCC
		private void SalesInvoiceWholesale_Load(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
				this.GetCompanyDetailsTableAdapter.Connection = sqlConnection;
				this.SalesByInvoiceNumberTableAdapter.Connection = sqlConnection;
				this.GetPaymentMethodsForInvoiceTableAdapter.Connection = sqlConnection;
				this.GetUserForInvoiceTableAdapter.Connection = sqlConnection;
				this.FetchCustomerDetailsFromInvTableAdapter.Connection = sqlConnection;
				this.GetBranchDetailsTableAdapter.Connection = sqlConnection;
				this.GetBankingDetailsTableAdapter.Connection = sqlConnection;
				this.BankingDetails2TableAdapter.Connection = sqlConnection;
				string text = " ";
				DataTable branches = this.pf.GetBranches(this._cnn);
				bool flag = branches.Rows.Count > 0;
				if (flag)
				{
					text = "Branch Network" + Environment.NewLine + Environment.NewLine;
					try
					{
						foreach (object obj in branches.Rows)
						{
							DataRow dataRow = (DataRow)obj;
							text = string.Concat(new string[]
							{
								text,
								dataRow["Branch"].ToString(),
								" ",
								dataRow["Tel"].ToString(),
								Environment.NewLine,
								dataRow["Address"].ToString(),
								", ",
								dataRow["Address2"].ToString(),
								Environment.NewLine,
								Environment.NewLine
							});
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				ReportParameter reportParameter = new ReportParameter("BranchNetwork", text);
				ReportParameter[] array = new ReportParameter[] { reportParameter };
				this.ReportViewer1.LocalReport.SetParameters(array);
				this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
				this.SalesByInvoiceNumberTableAdapter.Fill(this.POSDataSet.SalesByInvoiceNumber, new int?(this.invnum), new int?(MyProject.Forms.Form1.coid), MyProject.Forms.Form1.branch);
				this.GetPaymentMethodsForInvoiceTableAdapter.Fill(this.POSDataSet.GetPaymentMethodsForInvoice, new long?((long)this.invnum), new int?(MyProject.Forms.Form1.coid), MyProject.Forms.Form1.branch);
				this.GetUserForInvoiceTableAdapter.Fill(this.POSDataSet.GetUserForInvoice, new int?(this.invnum), new int?(MyProject.Forms.Form1.coid), MyProject.Forms.Form1.branch);
				this.FetchCustomerDetailsFromInvTableAdapter.Fill(this.POSDataSet.FetchCustomerDetailsFromInv, new int?(this.invnum), new int?(MyProject.Forms.Form1.coid), MyProject.Forms.Form1.branch);
				this.GetBranchDetailsTableAdapter.Fill(this.POSDataSet.GetBranchDetails, MyProject.Forms.Form1.branch, new int?(MyProject.Forms.Form1.coid));
				this.GetBankingDetailsTableAdapter.Fill(this.POSDataSet.GetBankingDetails, new int?(MyProject.Forms.Form1.coid));
				this.BankingDetails2TableAdapter.Fill(this.POSDataSet.BankingDetails2, new int?(MyProject.Forms.Form1.coid));
				this.ReportViewer1.RefreshReport();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading report. Detail: " + ex.Message);
			}
		}

		// Token: 0x0400227F RID: 8831
		public int invnum;

		// Token: 0x04002280 RID: 8832
		private string _cnn;

		// Token: 0x04002281 RID: 8833
		private PublicFunctions pf;
	}
}
