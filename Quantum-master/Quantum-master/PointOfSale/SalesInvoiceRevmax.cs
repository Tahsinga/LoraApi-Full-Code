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
	// Token: 0x020001B0 RID: 432
	[DesignerGenerated]
	public partial class SalesInvoiceRevmax : Form
	{
		// Token: 0x06004D55 RID: 19797 RVA: 0x002DD53C File Offset: 0x002DB73C
		public SalesInvoiceRevmax()
		{
			base.Load += this.SalesInvoiceRevmax_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.reprint = 0;
			this.isEltradeESDfiscal = 0;
			this.branch = "";
			this.showinvdisc = 0;
			this.InitializeComponent();
		}

		// Token: 0x17001C68 RID: 7272
		// (get) Token: 0x06004D58 RID: 19800 RVA: 0x002DDCCF File Offset: 0x002DBECF
		// (set) Token: 0x06004D59 RID: 19801 RVA: 0x002DDCD9 File Offset: 0x002DBED9
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C69 RID: 7273
		// (get) Token: 0x06004D5A RID: 19802 RVA: 0x002DDCE2 File Offset: 0x002DBEE2
		// (set) Token: 0x06004D5B RID: 19803 RVA: 0x002DDCEC File Offset: 0x002DBEEC
		internal virtual BindingSource GetPaymentMethodsForInvoiceBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C6A RID: 7274
		// (get) Token: 0x06004D5C RID: 19804 RVA: 0x002DDCF5 File Offset: 0x002DBEF5
		// (set) Token: 0x06004D5D RID: 19805 RVA: 0x002DDCFF File Offset: 0x002DBEFF
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C6B RID: 7275
		// (get) Token: 0x06004D5E RID: 19806 RVA: 0x002DDD08 File Offset: 0x002DBF08
		// (set) Token: 0x06004D5F RID: 19807 RVA: 0x002DDD12 File Offset: 0x002DBF12
		internal virtual BindingSource GetUserForInvoiceBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C6C RID: 7276
		// (get) Token: 0x06004D60 RID: 19808 RVA: 0x002DDD1B File Offset: 0x002DBF1B
		// (set) Token: 0x06004D61 RID: 19809 RVA: 0x002DDD25 File Offset: 0x002DBF25
		internal virtual BindingSource FetchCustomerDetailsFromInvBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C6D RID: 7277
		// (get) Token: 0x06004D62 RID: 19810 RVA: 0x002DDD2E File Offset: 0x002DBF2E
		// (set) Token: 0x06004D63 RID: 19811 RVA: 0x002DDD38 File Offset: 0x002DBF38
		internal virtual BindingSource SalesByInvoiceNumberBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C6E RID: 7278
		// (get) Token: 0x06004D64 RID: 19812 RVA: 0x002DDD41 File Offset: 0x002DBF41
		// (set) Token: 0x06004D65 RID: 19813 RVA: 0x002DDD4B File Offset: 0x002DBF4B
		internal virtual BindingSource GetBranchDetails1BindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C6F RID: 7279
		// (get) Token: 0x06004D66 RID: 19814 RVA: 0x002DDD54 File Offset: 0x002DBF54
		// (set) Token: 0x06004D67 RID: 19815 RVA: 0x002DDD5E File Offset: 0x002DBF5E
		internal virtual BindingSource GetBankingDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C70 RID: 7280
		// (get) Token: 0x06004D68 RID: 19816 RVA: 0x002DDD67 File Offset: 0x002DBF67
		// (set) Token: 0x06004D69 RID: 19817 RVA: 0x002DDD71 File Offset: 0x002DBF71
		internal virtual BindingSource BankingDetails2BindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C71 RID: 7281
		// (get) Token: 0x06004D6A RID: 19818 RVA: 0x002DDD7A File Offset: 0x002DBF7A
		// (set) Token: 0x06004D6B RID: 19819 RVA: 0x002DDD84 File Offset: 0x002DBF84
		internal virtual BindingSource SalesByInvoiceNumberTotalsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C72 RID: 7282
		// (get) Token: 0x06004D6C RID: 19820 RVA: 0x002DDD8D File Offset: 0x002DBF8D
		// (set) Token: 0x06004D6D RID: 19821 RVA: 0x002DDD97 File Offset: 0x002DBF97
		internal virtual BindingSource GetCompanyDetailsForCoidBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C73 RID: 7283
		// (get) Token: 0x06004D6E RID: 19822 RVA: 0x002DDDA0 File Offset: 0x002DBFA0
		// (set) Token: 0x06004D6F RID: 19823 RVA: 0x002DDDAA File Offset: 0x002DBFAA
		internal virtual GetPaymentMethodsForInvoiceTableAdapter GetPaymentMethodsForInvoiceTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C74 RID: 7284
		// (get) Token: 0x06004D70 RID: 19824 RVA: 0x002DDDB3 File Offset: 0x002DBFB3
		// (set) Token: 0x06004D71 RID: 19825 RVA: 0x002DDDBD File Offset: 0x002DBFBD
		internal virtual GetUserForInvoiceTableAdapter GetUserForInvoiceTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C75 RID: 7285
		// (get) Token: 0x06004D72 RID: 19826 RVA: 0x002DDDC6 File Offset: 0x002DBFC6
		// (set) Token: 0x06004D73 RID: 19827 RVA: 0x002DDDD0 File Offset: 0x002DBFD0
		internal virtual FetchCustomerDetailsFromInvTableAdapter FetchCustomerDetailsFromInvTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C76 RID: 7286
		// (get) Token: 0x06004D74 RID: 19828 RVA: 0x002DDDD9 File Offset: 0x002DBFD9
		// (set) Token: 0x06004D75 RID: 19829 RVA: 0x002DDDE3 File Offset: 0x002DBFE3
		internal virtual SalesByInvoiceNumberTableAdapter SalesByInvoiceNumberTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C77 RID: 7287
		// (get) Token: 0x06004D76 RID: 19830 RVA: 0x002DDDEC File Offset: 0x002DBFEC
		// (set) Token: 0x06004D77 RID: 19831 RVA: 0x002DDDF6 File Offset: 0x002DBFF6
		internal virtual GetBranchDetails1TableAdapter GetBranchDetails1TableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C78 RID: 7288
		// (get) Token: 0x06004D78 RID: 19832 RVA: 0x002DDDFF File Offset: 0x002DBFFF
		// (set) Token: 0x06004D79 RID: 19833 RVA: 0x002DDE09 File Offset: 0x002DC009
		internal virtual GetBankingDetailsTableAdapter GetBankingDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C79 RID: 7289
		// (get) Token: 0x06004D7A RID: 19834 RVA: 0x002DDE12 File Offset: 0x002DC012
		// (set) Token: 0x06004D7B RID: 19835 RVA: 0x002DDE1C File Offset: 0x002DC01C
		internal virtual BankingDetails2TableAdapter BankingDetails2TableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C7A RID: 7290
		// (get) Token: 0x06004D7C RID: 19836 RVA: 0x002DDE25 File Offset: 0x002DC025
		// (set) Token: 0x06004D7D RID: 19837 RVA: 0x002DDE2F File Offset: 0x002DC02F
		internal virtual SalesByInvoiceNumberTotalsTableAdapter SalesByInvoiceNumberTotalsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C7B RID: 7291
		// (get) Token: 0x06004D7E RID: 19838 RVA: 0x002DDE38 File Offset: 0x002DC038
		// (set) Token: 0x06004D7F RID: 19839 RVA: 0x002DDE42 File Offset: 0x002DC042
		internal virtual GetCompanyDetailsForCoidTableAdapter GetCompanyDetailsForCoidTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06004D80 RID: 19840 RVA: 0x002DDE4C File Offset: 0x002DC04C
		private void SalesInvoiceRevmax_Load(object sender, EventArgs e)
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
				this.BankingDetails2TableAdapter.Connection = sqlConnection;
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
				this.BankingDetails2TableAdapter.Fill(this.POSDataSet.BankingDetails2, new int?(MyProject.Forms.Form1.coid));
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
		}

		// Token: 0x06004D81 RID: 19841 RVA: 0x002DE444 File Offset: 0x002DC644
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

		// Token: 0x06004D82 RID: 19842 RVA: 0x002DE4F4 File Offset: 0x002DC6F4
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

		// Token: 0x04002264 RID: 8804
		public int invnum;

		// Token: 0x04002265 RID: 8805
		private string _cnn;

		// Token: 0x04002266 RID: 8806
		private PublicFunctions pf;

		// Token: 0x04002267 RID: 8807
		public string revmax_sign;

		// Token: 0x04002268 RID: 8808
		public int reprint;

		// Token: 0x04002269 RID: 8809
		public int isEltradeESDfiscal;

		// Token: 0x0400226A RID: 8810
		public string branch;

		// Token: 0x0400226B RID: 8811
		public int showinvdisc;
	}
}
