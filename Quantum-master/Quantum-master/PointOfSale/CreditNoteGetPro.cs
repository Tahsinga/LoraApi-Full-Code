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
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;
using PointOfSale.POSDataSetTableAdapters;

namespace PointOfSale
{
	// Token: 0x02000033 RID: 51
	[DesignerGenerated]
	public partial class CreditNoteGetPro : Form
	{
		// Token: 0x06000B1B RID: 2843 RVA: 0x00070BB4 File Offset: 0x0006EDB4
		public CreditNoteGetPro()
		{
			base.Load += this.CreditNoteGetPro_Load;
			this.pf = new PublicFunctions();
			this.reprint = 0;
			this.isEltradeESDfiscal = 0;
			this.branch = "";
			this.showinvdisc = 0;
			this.isfiscal = 0;
			this.InitializeComponent();
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06000B1E RID: 2846 RVA: 0x00071337 File Offset: 0x0006F537
		// (set) Token: 0x06000B1F RID: 2847 RVA: 0x00071341 File Offset: 0x0006F541
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06000B20 RID: 2848 RVA: 0x0007134A File Offset: 0x0006F54A
		// (set) Token: 0x06000B21 RID: 2849 RVA: 0x00071354 File Offset: 0x0006F554
		internal virtual BindingSource GetPaymentMethodsForInvoiceBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06000B22 RID: 2850 RVA: 0x0007135D File Offset: 0x0006F55D
		// (set) Token: 0x06000B23 RID: 2851 RVA: 0x00071367 File Offset: 0x0006F567
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06000B24 RID: 2852 RVA: 0x00071370 File Offset: 0x0006F570
		// (set) Token: 0x06000B25 RID: 2853 RVA: 0x0007137A File Offset: 0x0006F57A
		internal virtual BindingSource GetUserForInvoiceBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06000B26 RID: 2854 RVA: 0x00071383 File Offset: 0x0006F583
		// (set) Token: 0x06000B27 RID: 2855 RVA: 0x0007138D File Offset: 0x0006F58D
		internal virtual BindingSource FetchCustomerDetailsFromInvBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06000B28 RID: 2856 RVA: 0x00071396 File Offset: 0x0006F596
		// (set) Token: 0x06000B29 RID: 2857 RVA: 0x000713A0 File Offset: 0x0006F5A0
		internal virtual BindingSource SalesByInvoiceNumberCNBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06000B2A RID: 2858 RVA: 0x000713A9 File Offset: 0x0006F5A9
		// (set) Token: 0x06000B2B RID: 2859 RVA: 0x000713B3 File Offset: 0x0006F5B3
		internal virtual BindingSource GetBranchDetails1BindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06000B2C RID: 2860 RVA: 0x000713BC File Offset: 0x0006F5BC
		// (set) Token: 0x06000B2D RID: 2861 RVA: 0x000713C6 File Offset: 0x0006F5C6
		internal virtual BindingSource GetBankingDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06000B2E RID: 2862 RVA: 0x000713CF File Offset: 0x0006F5CF
		// (set) Token: 0x06000B2F RID: 2863 RVA: 0x000713D9 File Offset: 0x0006F5D9
		internal virtual BindingSource BankingDetails2BindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06000B30 RID: 2864 RVA: 0x000713E2 File Offset: 0x0006F5E2
		// (set) Token: 0x06000B31 RID: 2865 RVA: 0x000713EC File Offset: 0x0006F5EC
		internal virtual BindingSource SalesByInvoiceNumberTotalsCNBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06000B32 RID: 2866 RVA: 0x000713F5 File Offset: 0x0006F5F5
		// (set) Token: 0x06000B33 RID: 2867 RVA: 0x000713FF File Offset: 0x0006F5FF
		internal virtual BindingSource GetCompanyDetailsForCoidBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06000B34 RID: 2868 RVA: 0x00071408 File Offset: 0x0006F608
		// (set) Token: 0x06000B35 RID: 2869 RVA: 0x00071412 File Offset: 0x0006F612
		internal virtual GetPaymentMethodsForInvoiceTableAdapter GetPaymentMethodsForInvoiceTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06000B36 RID: 2870 RVA: 0x0007141B File Offset: 0x0006F61B
		// (set) Token: 0x06000B37 RID: 2871 RVA: 0x00071425 File Offset: 0x0006F625
		internal virtual GetUserForInvoiceTableAdapter GetUserForInvoiceTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06000B38 RID: 2872 RVA: 0x0007142E File Offset: 0x0006F62E
		// (set) Token: 0x06000B39 RID: 2873 RVA: 0x00071438 File Offset: 0x0006F638
		internal virtual FetchCustomerDetailsFromInvTableAdapter FetchCustomerDetailsFromInvTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06000B3A RID: 2874 RVA: 0x00071441 File Offset: 0x0006F641
		// (set) Token: 0x06000B3B RID: 2875 RVA: 0x0007144B File Offset: 0x0006F64B
		internal virtual SalesByInvoiceNumberCNTableAdapter SalesByInvoiceNumberCNTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06000B3C RID: 2876 RVA: 0x00071454 File Offset: 0x0006F654
		// (set) Token: 0x06000B3D RID: 2877 RVA: 0x0007145E File Offset: 0x0006F65E
		internal virtual GetBranchDetails1TableAdapter GetBranchDetails1TableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06000B3E RID: 2878 RVA: 0x00071467 File Offset: 0x0006F667
		// (set) Token: 0x06000B3F RID: 2879 RVA: 0x00071471 File Offset: 0x0006F671
		internal virtual GetBankingDetailsTableAdapter GetBankingDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06000B40 RID: 2880 RVA: 0x0007147A File Offset: 0x0006F67A
		// (set) Token: 0x06000B41 RID: 2881 RVA: 0x00071484 File Offset: 0x0006F684
		internal virtual BankingDetails2TableAdapter BankingDetails2TableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06000B42 RID: 2882 RVA: 0x0007148D File Offset: 0x0006F68D
		// (set) Token: 0x06000B43 RID: 2883 RVA: 0x00071497 File Offset: 0x0006F697
		internal virtual SalesByInvoiceNumberTotalsCNTableAdapter SalesByInvoiceNumberTotalsCNTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06000B44 RID: 2884 RVA: 0x000714A0 File Offset: 0x0006F6A0
		// (set) Token: 0x06000B45 RID: 2885 RVA: 0x000714AA File Offset: 0x0006F6AA
		internal virtual GetCompanyDetailsForCoidTableAdapter GetCompanyDetailsForCoidTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x000714B4 File Offset: 0x0006F6B4
		private void CreditNoteGetPro_Load(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
				this.GetCompanyDetailsForCoidTableAdapter.Connection = sqlConnection;
				this.SalesByInvoiceNumberCNTableAdapter.Connection = sqlConnection;
				this.GetPaymentMethodsForInvoiceTableAdapter.Connection = sqlConnection;
				this.GetUserForInvoiceTableAdapter.Connection = sqlConnection;
				this.FetchCustomerDetailsFromInvTableAdapter.Connection = sqlConnection;
				this.GetBranchDetails1TableAdapter.Connection = sqlConnection;
				this.GetBankingDetailsTableAdapter.Connection = sqlConnection;
				this.BankingDetails2TableAdapter.Connection = sqlConnection;
				this.SalesByInvoiceNumberTotalsCNTableAdapter.Connection = sqlConnection;
				string text = " ";
				DataTable branches = this.pf.GetBranches(MyProject.Forms.Form1.Constring);
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
				bool flag2 = MyProject.Forms.Form1.IsWarehouse == 1;
				bool flag3 = flag2;
				ReportParameter reportParameter = new ReportParameter("BranchNetwork", text);
				ReportParameter reportParameter2 = new ReportParameter("IsWarehouse", Conversions.ToString(flag3));
				ReportParameter reportParameter3 = new ReportParameter("digsig", this.revmax_sign);
				ReportParameter reportParameter4 = new ReportParameter("paymentmethod", this.GetPayMethName(this.GetInvPayDisplayDetails()));
				ReportParameter reportParameter5 = new ReportParameter("reprint", Conversions.ToString(Conversions.ToInteger(Interaction.IIf(this.reprint == 1, 1, 0))));
				bool flag4 = Operators.CompareString(this.revmax_sign, "", false) != 0;
				if (flag4)
				{
					this.isfiscal = 1;
				}
				bool flag5 = this.isEltradeESDfiscal == 1;
				if (flag5)
				{
					this.isfiscal = 1;
				}
				ReportParameter reportParameter6 = new ReportParameter("isfiscal", Conversions.ToString(this.isfiscal));
				ReportParameter reportParameter7 = new ReportParameter("ShowFooter", Conversions.ToString(MyProject.Forms.Form1.showfooter));
				ReportParameter reportParameter8 = new ReportParameter("invheader", MyProject.Forms.Form1.InvoiceHeaderText);
				ReportParameter reportParameter9 = new ReportParameter("ShowInvDisc", Conversions.ToString(this.showinvdisc));
				ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter2, reportParameter3, reportParameter4, reportParameter5, reportParameter6, reportParameter7, reportParameter8, reportParameter9 };
				this.ReportViewer1.LocalReport.SetParameters(array);
				this.GetCompanyDetailsForCoidTableAdapter.Fill(this.POSDataSet.GetCompanyDetailsForCoid, new int?(MyProject.Forms.Form1.coid));
				this.SalesByInvoiceNumberCNTableAdapter.Fill(this.POSDataSet.SalesByInvoiceNumberCN, new int?(this.invnum), new int?(MyProject.Forms.Form1.coid), this.branch);
				this.GetPaymentMethodsForInvoiceTableAdapter.Fill(this.POSDataSet.GetPaymentMethodsForInvoice, new long?((long)this.invnum), new int?(MyProject.Forms.Form1.coid), this.branch);
				this.GetUserForInvoiceTableAdapter.Fill(this.POSDataSet.GetUserForInvoice, new int?(this.invnum), new int?(MyProject.Forms.Form1.coid), this.branch);
				this.FetchCustomerDetailsFromInvTableAdapter.Fill(this.POSDataSet.FetchCustomerDetailsFromInv, new int?(this.invnum), new int?(MyProject.Forms.Form1.coid), this.branch);
				this.GetBranchDetails1TableAdapter.Fill(this.POSDataSet.GetBranchDetails1, this.branch, new int?(MyProject.Forms.Form1.coid), new int?(this.GetInvPayDisplayDetails()));
				this.GetBankingDetailsTableAdapter.Fill(this.POSDataSet.GetBankingDetails, new int?(MyProject.Forms.Form1.coid));
				this.BankingDetails2TableAdapter.Fill(this.POSDataSet.BankingDetails2, new int?(MyProject.Forms.Form1.coid));
				this.SalesByInvoiceNumberTotalsCNTableAdapter.Fill(this.POSDataSet.SalesByInvoiceNumberTotalsCN, new int?(this.invnum), new int?(MyProject.Forms.Form1.coid));
				this.ReportViewer1.RefreshReport();
				bool flag6 = (Operators.CompareString(MyProject.Forms.Form1.PrintFilePath, "", false) != 0) & (MyProject.Forms.Form1.PrintToFile == 1) & (this.reprint == 0);
				if (flag6)
				{
					this.pf.SaveReportToPDF(this.ReportViewer1, MyProject.Forms.Form1.PrintFilePath, this.invnum);
					base.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading report. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x00071AB8 File Offset: 0x0006FCB8
		private int GetInvPayDisplayDetails()
		{
			SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SalesByInvoiceNumberCN";
			sqlCommand.Parameters.AddWithValue("invoicenum", this.invnum);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			DataRow dataRow = dataTable.Rows[0];
			return Conversions.ToInteger(dataRow["ReceiptDisplayPaymentMethod"]);
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x00071B74 File Offset: 0x0006FD74
		private string GetPayMethName(int paymethid)
		{
			SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetpayMethDetails";
			sqlCommand.Parameters.AddWithValue("paymentmethodid", paymethid);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			DataRow dataRow = dataTable.Rows[0];
			return Conversions.ToString(dataRow["Currency"]);
		}

		// Token: 0x04000550 RID: 1360
		private PublicFunctions pf;

		// Token: 0x04000551 RID: 1361
		public int invnum;

		// Token: 0x04000552 RID: 1362
		public string revmax_sign;

		// Token: 0x04000553 RID: 1363
		public int reprint;

		// Token: 0x04000554 RID: 1364
		public int isEltradeESDfiscal;

		// Token: 0x04000555 RID: 1365
		public string branch;

		// Token: 0x04000556 RID: 1366
		public int showinvdisc;

		// Token: 0x04000557 RID: 1367
		public int isfiscal;
	}
}
