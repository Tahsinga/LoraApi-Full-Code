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
	// Token: 0x020001AA RID: 426
	[DesignerGenerated]
	public partial class SalesInvoicePortraitFDMS : Form
	{
		// Token: 0x06004C3D RID: 19517 RVA: 0x002D7228 File Offset: 0x002D5428
		public SalesInvoicePortraitFDMS()
		{
			base.Load += this.SalesInvoicePortraitFDMS_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.reprint = 0;
			this.isEltradeESDfiscal = 0;
			this.branch = "";
			this.showinvdisc = 0;
			this.InitializeComponent();
		}

		// Token: 0x17001BEE RID: 7150
		// (get) Token: 0x06004C40 RID: 19520 RVA: 0x002D7A21 File Offset: 0x002D5C21
		// (set) Token: 0x06004C41 RID: 19521 RVA: 0x002D7A2B File Offset: 0x002D5C2B
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BEF RID: 7151
		// (get) Token: 0x06004C42 RID: 19522 RVA: 0x002D7A34 File Offset: 0x002D5C34
		// (set) Token: 0x06004C43 RID: 19523 RVA: 0x002D7A3E File Offset: 0x002D5C3E
		internal virtual BindingSource GetPaymentMethodsForInvoiceBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BF0 RID: 7152
		// (get) Token: 0x06004C44 RID: 19524 RVA: 0x002D7A47 File Offset: 0x002D5C47
		// (set) Token: 0x06004C45 RID: 19525 RVA: 0x002D7A51 File Offset: 0x002D5C51
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BF1 RID: 7153
		// (get) Token: 0x06004C46 RID: 19526 RVA: 0x002D7A5A File Offset: 0x002D5C5A
		// (set) Token: 0x06004C47 RID: 19527 RVA: 0x002D7A64 File Offset: 0x002D5C64
		internal virtual BindingSource GetUserForInvoiceBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BF2 RID: 7154
		// (get) Token: 0x06004C48 RID: 19528 RVA: 0x002D7A6D File Offset: 0x002D5C6D
		// (set) Token: 0x06004C49 RID: 19529 RVA: 0x002D7A77 File Offset: 0x002D5C77
		internal virtual BindingSource FetchCustomerDetailsFromInvBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BF3 RID: 7155
		// (get) Token: 0x06004C4A RID: 19530 RVA: 0x002D7A80 File Offset: 0x002D5C80
		// (set) Token: 0x06004C4B RID: 19531 RVA: 0x002D7A8A File Offset: 0x002D5C8A
		internal virtual BindingSource SalesByInvoiceNumberBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BF4 RID: 7156
		// (get) Token: 0x06004C4C RID: 19532 RVA: 0x002D7A93 File Offset: 0x002D5C93
		// (set) Token: 0x06004C4D RID: 19533 RVA: 0x002D7A9D File Offset: 0x002D5C9D
		internal virtual BindingSource GetBranchDetails1BindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BF5 RID: 7157
		// (get) Token: 0x06004C4E RID: 19534 RVA: 0x002D7AA6 File Offset: 0x002D5CA6
		// (set) Token: 0x06004C4F RID: 19535 RVA: 0x002D7AB0 File Offset: 0x002D5CB0
		internal virtual BindingSource GetBankingDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BF6 RID: 7158
		// (get) Token: 0x06004C50 RID: 19536 RVA: 0x002D7AB9 File Offset: 0x002D5CB9
		// (set) Token: 0x06004C51 RID: 19537 RVA: 0x002D7AC3 File Offset: 0x002D5CC3
		internal virtual BindingSource BankingDetails2BindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BF7 RID: 7159
		// (get) Token: 0x06004C52 RID: 19538 RVA: 0x002D7ACC File Offset: 0x002D5CCC
		// (set) Token: 0x06004C53 RID: 19539 RVA: 0x002D7AD6 File Offset: 0x002D5CD6
		internal virtual BindingSource SalesByInvoiceNumberTotalsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BF8 RID: 7160
		// (get) Token: 0x06004C54 RID: 19540 RVA: 0x002D7ADF File Offset: 0x002D5CDF
		// (set) Token: 0x06004C55 RID: 19541 RVA: 0x002D7AE9 File Offset: 0x002D5CE9
		internal virtual BindingSource GetCompanyDetailsForCoidBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BF9 RID: 7161
		// (get) Token: 0x06004C56 RID: 19542 RVA: 0x002D7AF2 File Offset: 0x002D5CF2
		// (set) Token: 0x06004C57 RID: 19543 RVA: 0x002D7AFC File Offset: 0x002D5CFC
		internal virtual GetPaymentMethodsForInvoiceTableAdapter GetPaymentMethodsForInvoiceTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BFA RID: 7162
		// (get) Token: 0x06004C58 RID: 19544 RVA: 0x002D7B05 File Offset: 0x002D5D05
		// (set) Token: 0x06004C59 RID: 19545 RVA: 0x002D7B0F File Offset: 0x002D5D0F
		internal virtual GetUserForInvoiceTableAdapter GetUserForInvoiceTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BFB RID: 7163
		// (get) Token: 0x06004C5A RID: 19546 RVA: 0x002D7B18 File Offset: 0x002D5D18
		// (set) Token: 0x06004C5B RID: 19547 RVA: 0x002D7B22 File Offset: 0x002D5D22
		internal virtual FetchCustomerDetailsFromInvTableAdapter FetchCustomerDetailsFromInvTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BFC RID: 7164
		// (get) Token: 0x06004C5C RID: 19548 RVA: 0x002D7B2B File Offset: 0x002D5D2B
		// (set) Token: 0x06004C5D RID: 19549 RVA: 0x002D7B35 File Offset: 0x002D5D35
		internal virtual SalesByInvoiceNumberTableAdapter SalesByInvoiceNumberTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BFD RID: 7165
		// (get) Token: 0x06004C5E RID: 19550 RVA: 0x002D7B3E File Offset: 0x002D5D3E
		// (set) Token: 0x06004C5F RID: 19551 RVA: 0x002D7B48 File Offset: 0x002D5D48
		internal virtual GetBranchDetails1TableAdapter GetBranchDetails1TableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BFE RID: 7166
		// (get) Token: 0x06004C60 RID: 19552 RVA: 0x002D7B51 File Offset: 0x002D5D51
		// (set) Token: 0x06004C61 RID: 19553 RVA: 0x002D7B5B File Offset: 0x002D5D5B
		internal virtual GetBankingDetailsTableAdapter GetBankingDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BFF RID: 7167
		// (get) Token: 0x06004C62 RID: 19554 RVA: 0x002D7B64 File Offset: 0x002D5D64
		// (set) Token: 0x06004C63 RID: 19555 RVA: 0x002D7B6E File Offset: 0x002D5D6E
		internal virtual BankingDetails2TableAdapter BankingDetails2TableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C00 RID: 7168
		// (get) Token: 0x06004C64 RID: 19556 RVA: 0x002D7B77 File Offset: 0x002D5D77
		// (set) Token: 0x06004C65 RID: 19557 RVA: 0x002D7B81 File Offset: 0x002D5D81
		internal virtual SalesByInvoiceNumberTotalsTableAdapter SalesByInvoiceNumberTotalsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C01 RID: 7169
		// (get) Token: 0x06004C66 RID: 19558 RVA: 0x002D7B8A File Offset: 0x002D5D8A
		// (set) Token: 0x06004C67 RID: 19559 RVA: 0x002D7B94 File Offset: 0x002D5D94
		internal virtual GetCompanyDetailsForCoidTableAdapter GetCompanyDetailsForCoidTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C02 RID: 7170
		// (get) Token: 0x06004C68 RID: 19560 RVA: 0x002D7B9D File Offset: 0x002D5D9D
		// (set) Token: 0x06004C69 RID: 19561 RVA: 0x002D7BA7 File Offset: 0x002D5DA7
		internal virtual BindingSource GetBankingDetails2BindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C03 RID: 7171
		// (get) Token: 0x06004C6A RID: 19562 RVA: 0x002D7BB0 File Offset: 0x002D5DB0
		// (set) Token: 0x06004C6B RID: 19563 RVA: 0x002D7BBA File Offset: 0x002D5DBA
		internal virtual GetBankingDetails2TableAdapter GetBankingDetails2TableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06004C6C RID: 19564 RVA: 0x002D7BC4 File Offset: 0x002D5DC4
		private void SalesInvoicePortraitFDMS_Load(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
				this.GetCompanyDetailsForCoidTableAdapter.Connection = sqlConnection;
				this.SalesByInvoiceNumberTableAdapter.Connection = sqlConnection;
				this.GetPaymentMethodsForInvoiceTableAdapter.Connection = sqlConnection;
				this.GetUserForInvoiceTableAdapter.Connection = sqlConnection;
				this.FetchCustomerDetailsFromInvTableAdapter.Connection = sqlConnection;
				this.GetBranchDetails1TableAdapter.Connection = sqlConnection;
				this.GetBankingDetailsTableAdapter.Connection = sqlConnection;
				this.GetBankingDetails2TableAdapter.Connection = sqlConnection;
				this.SalesByInvoiceNumberTotalsTableAdapter.Connection = sqlConnection;
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
				bool flag2 = MyProject.Forms.Form1.IsWarehouse == 1;
				bool flag3 = flag2;
				ReportParameter reportParameter = new ReportParameter("BranchNetwork", text);
				ReportParameter reportParameter2 = new ReportParameter("IsWarehouse", Conversions.ToString(flag3));
				ReportParameter reportParameter3 = new ReportParameter("digsig", this.revmax_sign);
				ReportParameter reportParameter4 = new ReportParameter("paymentmethod", this.GetPayMethName(this.GetInvPayDisplayDetails()));
				ReportParameter reportParameter5 = new ReportParameter("reprint", Conversions.ToString(Conversions.ToInteger(Interaction.IIf(this.reprint == 1, 1, 0))));
				int num = 0;
				bool flag4 = Operators.CompareString(this.revmax_sign, "", false) != 0;
				if (flag4)
				{
					num = 1;
				}
				bool flag5 = this.isEltradeESDfiscal == 1;
				if (flag5)
				{
					num = 1;
				}
				ReportParameter reportParameter6 = new ReportParameter("isfiscal", Conversions.ToString(num));
				ReportParameter reportParameter7 = new ReportParameter("ShowFooter", Conversions.ToString(MyProject.Forms.Form1.showfooter));
				ReportParameter reportParameter8 = new ReportParameter("invheader", MyProject.Forms.Form1.InvoiceHeaderText);
				ReportParameter reportParameter9 = new ReportParameter("ShowInvDisc", Conversions.ToString(this.showinvdisc));
				ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter2, reportParameter3, reportParameter4, reportParameter5, reportParameter6, reportParameter7, reportParameter8, reportParameter9 };
				this.ReportViewer1.LocalReport.SetParameters(array);
				this.GetCompanyDetailsForCoidTableAdapter.Fill(this.POSDataSet.GetCompanyDetailsForCoid, new int?(MyProject.Forms.Form1.coid));
				this.SalesByInvoiceNumberTableAdapter.Fill(this.POSDataSet.SalesByInvoiceNumber, new int?(this.invnum), new int?(MyProject.Forms.Form1.coid), this.branch);
				this.GetPaymentMethodsForInvoiceTableAdapter.Fill(this.POSDataSet.GetPaymentMethodsForInvoice, new long?((long)this.invnum), new int?(MyProject.Forms.Form1.coid), this.branch);
				this.GetUserForInvoiceTableAdapter.Fill(this.POSDataSet.GetUserForInvoice, new int?(this.invnum), new int?(MyProject.Forms.Form1.coid), this.branch);
				this.FetchCustomerDetailsFromInvTableAdapter.Fill(this.POSDataSet.FetchCustomerDetailsFromInv, new int?(this.invnum), new int?(MyProject.Forms.Form1.coid), this.branch);
				this.GetBranchDetails1TableAdapter.Fill(this.POSDataSet.GetBranchDetails1, this.branch, new int?(MyProject.Forms.Form1.coid), new int?(this.GetInvPayDisplayDetails()));
				this.GetBankingDetailsTableAdapter.Fill(this.POSDataSet.GetBankingDetails, new int?(MyProject.Forms.Form1.coid));
				this.GetBankingDetails2TableAdapter.Fill(this.POSDataSet.GetBankingDetails2, new int?(MyProject.Forms.Form1.coid));
				this.SalesByInvoiceNumberTotalsTableAdapter.Fill(this.POSDataSet.SalesByInvoiceNumberTotals, new int?(this.invnum), new int?(MyProject.Forms.Form1.coid), this.branch);
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
			this.ReportViewer1.RefreshReport();
		}

		// Token: 0x06004C6D RID: 19565 RVA: 0x002D81C8 File Offset: 0x002D63C8
		private int GetInvPayDisplayDetails()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SalesByInvoiceNumber";
			sqlCommand.Parameters.AddWithValue("invoicenum", this.invnum);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			DataRow dataRow = dataTable.Rows[0];
			return Conversions.ToInteger(dataRow["ReceiptDisplayPaymentMethod"]);
		}

		// Token: 0x06004C6E RID: 19566 RVA: 0x002D8278 File Offset: 0x002D6478
		private string GetPayMethName(int paymethid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
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

		// Token: 0x040021B5 RID: 8629
		public int invnum;

		// Token: 0x040021B6 RID: 8630
		private string _cnn;

		// Token: 0x040021B7 RID: 8631
		private PublicFunctions pf;

		// Token: 0x040021B8 RID: 8632
		public string revmax_sign;

		// Token: 0x040021B9 RID: 8633
		public int reprint;

		// Token: 0x040021BA RID: 8634
		public int isEltradeESDfiscal;

		// Token: 0x040021BB RID: 8635
		public string branch;

		// Token: 0x040021BC RID: 8636
		public int showinvdisc;
	}
}
