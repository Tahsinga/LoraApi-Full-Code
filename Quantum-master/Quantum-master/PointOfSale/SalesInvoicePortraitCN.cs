using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;
using PointOfSale.POSDataSetTableAdapters;

namespace PointOfSale
{
	// Token: 0x020001A8 RID: 424
	[DesignerGenerated]
	public partial class SalesInvoicePortraitCN : Form
	{
		// Token: 0x06004BE0 RID: 19424 RVA: 0x002D4BFC File Offset: 0x002D2DFC
		public SalesInvoicePortraitCN()
		{
			base.Load += this.SalesInvoicePortraitCN_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.reprint = 0;
			this.isEltradeESDfiscal = 0;
			this.branch = "";
			this.isdebitorder = 0;
			this.isfiscal = 0;
			this.template = "";
			this.InitializeComponent();
		}

		// Token: 0x17001BC8 RID: 7112
		// (get) Token: 0x06004BE3 RID: 19427 RVA: 0x002D53AF File Offset: 0x002D35AF
		// (set) Token: 0x06004BE4 RID: 19428 RVA: 0x002D53B9 File Offset: 0x002D35B9
		internal virtual BindingSource GetPaymentMethodsForInvoiceBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BC9 RID: 7113
		// (get) Token: 0x06004BE5 RID: 19429 RVA: 0x002D53C2 File Offset: 0x002D35C2
		// (set) Token: 0x06004BE6 RID: 19430 RVA: 0x002D53CC File Offset: 0x002D35CC
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BCA RID: 7114
		// (get) Token: 0x06004BE7 RID: 19431 RVA: 0x002D53D5 File Offset: 0x002D35D5
		// (set) Token: 0x06004BE8 RID: 19432 RVA: 0x002D53DF File Offset: 0x002D35DF
		internal virtual BindingSource GetUserForInvoiceCNBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BCB RID: 7115
		// (get) Token: 0x06004BE9 RID: 19433 RVA: 0x002D53E8 File Offset: 0x002D35E8
		// (set) Token: 0x06004BEA RID: 19434 RVA: 0x002D53F2 File Offset: 0x002D35F2
		internal virtual BindingSource FetchCustomerDetailsFromInvCNBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BCC RID: 7116
		// (get) Token: 0x06004BEB RID: 19435 RVA: 0x002D53FB File Offset: 0x002D35FB
		// (set) Token: 0x06004BEC RID: 19436 RVA: 0x002D5405 File Offset: 0x002D3605
		internal virtual BindingSource SalesByInvoiceNumberCNBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BCD RID: 7117
		// (get) Token: 0x06004BED RID: 19437 RVA: 0x002D540E File Offset: 0x002D360E
		// (set) Token: 0x06004BEE RID: 19438 RVA: 0x002D5418 File Offset: 0x002D3618
		internal virtual BindingSource GetBankingDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BCE RID: 7118
		// (get) Token: 0x06004BEF RID: 19439 RVA: 0x002D5421 File Offset: 0x002D3621
		// (set) Token: 0x06004BF0 RID: 19440 RVA: 0x002D542B File Offset: 0x002D362B
		internal virtual BindingSource BankingDetails2BindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BCF RID: 7119
		// (get) Token: 0x06004BF1 RID: 19441 RVA: 0x002D5434 File Offset: 0x002D3634
		// (set) Token: 0x06004BF2 RID: 19442 RVA: 0x002D543E File Offset: 0x002D363E
		internal virtual BindingSource SalesByInvoiceNumberTotalsCNBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BD0 RID: 7120
		// (get) Token: 0x06004BF3 RID: 19443 RVA: 0x002D5447 File Offset: 0x002D3647
		// (set) Token: 0x06004BF4 RID: 19444 RVA: 0x002D5451 File Offset: 0x002D3651
		internal virtual GetPaymentMethodsForInvoiceTableAdapter GetPaymentMethodsForInvoiceTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BD1 RID: 7121
		// (get) Token: 0x06004BF5 RID: 19445 RVA: 0x002D545A File Offset: 0x002D365A
		// (set) Token: 0x06004BF6 RID: 19446 RVA: 0x002D5464 File Offset: 0x002D3664
		internal virtual GetUserForInvoiceCNTableAdapter GetUserForInvoiceCNTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BD2 RID: 7122
		// (get) Token: 0x06004BF7 RID: 19447 RVA: 0x002D546D File Offset: 0x002D366D
		// (set) Token: 0x06004BF8 RID: 19448 RVA: 0x002D5477 File Offset: 0x002D3677
		internal virtual FetchCustomerDetailsFromInvCNTableAdapter FetchCustomerDetailsFromInvCNTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BD3 RID: 7123
		// (get) Token: 0x06004BF9 RID: 19449 RVA: 0x002D5480 File Offset: 0x002D3680
		// (set) Token: 0x06004BFA RID: 19450 RVA: 0x002D548A File Offset: 0x002D368A
		internal virtual SalesByInvoiceNumberCNTableAdapter SalesByInvoiceNumberCNTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BD4 RID: 7124
		// (get) Token: 0x06004BFB RID: 19451 RVA: 0x002D5493 File Offset: 0x002D3693
		// (set) Token: 0x06004BFC RID: 19452 RVA: 0x002D549D File Offset: 0x002D369D
		internal virtual GetBankingDetailsTableAdapter GetBankingDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BD5 RID: 7125
		// (get) Token: 0x06004BFD RID: 19453 RVA: 0x002D54A6 File Offset: 0x002D36A6
		// (set) Token: 0x06004BFE RID: 19454 RVA: 0x002D54B0 File Offset: 0x002D36B0
		internal virtual BankingDetails2TableAdapter BankingDetails2TableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BD6 RID: 7126
		// (get) Token: 0x06004BFF RID: 19455 RVA: 0x002D54B9 File Offset: 0x002D36B9
		// (set) Token: 0x06004C00 RID: 19456 RVA: 0x002D54C3 File Offset: 0x002D36C3
		internal virtual SalesByInvoiceNumberTotalsCNTableAdapter SalesByInvoiceNumberTotalsCNTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BD7 RID: 7127
		// (get) Token: 0x06004C01 RID: 19457 RVA: 0x002D54CC File Offset: 0x002D36CC
		// (set) Token: 0x06004C02 RID: 19458 RVA: 0x002D54D6 File Offset: 0x002D36D6
		internal virtual BindingSource GetCompanyDetailsForCoidBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BD8 RID: 7128
		// (get) Token: 0x06004C03 RID: 19459 RVA: 0x002D54DF File Offset: 0x002D36DF
		// (set) Token: 0x06004C04 RID: 19460 RVA: 0x002D54E9 File Offset: 0x002D36E9
		internal virtual GetCompanyDetailsForCoidTableAdapter GetCompanyDetailsForCoidTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BD9 RID: 7129
		// (get) Token: 0x06004C05 RID: 19461 RVA: 0x002D54F2 File Offset: 0x002D36F2
		// (set) Token: 0x06004C06 RID: 19462 RVA: 0x002D54FC File Offset: 0x002D36FC
		internal virtual BindingSource GetBranchDetails1BindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BDA RID: 7130
		// (get) Token: 0x06004C07 RID: 19463 RVA: 0x002D5505 File Offset: 0x002D3705
		// (set) Token: 0x06004C08 RID: 19464 RVA: 0x002D550F File Offset: 0x002D370F
		internal virtual GetBranchDetails1TableAdapter GetBranchDetails1TableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BDB RID: 7131
		// (get) Token: 0x06004C09 RID: 19465 RVA: 0x002D5518 File Offset: 0x002D3718
		// (set) Token: 0x06004C0A RID: 19466 RVA: 0x002D5522 File Offset: 0x002D3722
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06004C0B RID: 19467 RVA: 0x002D552C File Offset: 0x002D372C
		private void SalesInvoicePortraitCN_Load(object sender, EventArgs e)
		{
			try
			{
				this.ReportViewer1.Reset();
				bool flag = MyProject.Forms.Form1.inv_template_Binum == 1;
				string text;
				if (flag)
				{
					text = Application.StartupPath + "\\CreditNotePortraitBinum.rdlc";
				}
				else
				{
					text = Application.StartupPath + "\\CreditNotePortrait.rdlc";
				}
				bool flag2 = !File.Exists(text);
				if (flag2)
				{
					throw new FileNotFoundException("RDLC file not found: " + text);
				}
				this.ReportViewer1.LocalReport.ReportPath = text;
				SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
				this.GetCompanyDetailsForCoidTableAdapter.Connection = sqlConnection;
				this.SalesByInvoiceNumberCNTableAdapter.Connection = sqlConnection;
				this.GetPaymentMethodsForInvoiceTableAdapter.Connection = sqlConnection;
				this.GetUserForInvoiceCNTableAdapter.Connection = sqlConnection;
				this.FetchCustomerDetailsFromInvCNTableAdapter.Connection = sqlConnection;
				this.GetBranchDetails1TableAdapter.Connection = sqlConnection;
				this.GetBankingDetailsTableAdapter.Connection = sqlConnection;
				this.BankingDetails2TableAdapter.Connection = sqlConnection;
				this.SalesByInvoiceNumberTotalsCNTableAdapter.Connection = sqlConnection;
				string text2 = " ";
				DataTable branches = this.pf.GetBranches(this._cnn);
				bool flag3 = branches.Rows.Count > 0;
				if (flag3)
				{
					text2 = "Branch Network" + Environment.NewLine + Environment.NewLine;
					try
					{
						foreach (object obj in branches.Rows)
						{
							DataRow dataRow = (DataRow)obj;
							text2 = string.Concat(new string[]
							{
								text2,
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
				bool flag4 = MyProject.Forms.Form1.IsWarehouse == 1;
				bool flag5 = flag4;
				ReportParameter reportParameter = new ReportParameter("BranchNetwork", text2);
				ReportParameter reportParameter2 = new ReportParameter("IsWarehouse", Conversions.ToString(flag5));
				ReportParameter reportParameter3 = new ReportParameter("digsig", this.revmax_sign);
				int invPayDisplayDetails = this.GetInvPayDisplayDetails();
				ReportParameter reportParameter4 = new ReportParameter("paymentmethod", this.GetPayMethName(invPayDisplayDetails));
				ReportParameter reportParameter5 = new ReportParameter("reprint", Conversions.ToString(Conversions.ToInteger(Interaction.IIf(this.reprint == 1, 1, 0))));
				bool flag6 = Operators.CompareString(this.revmax_sign, "", false) != 0;
				if (flag6)
				{
					this.isfiscal = 1;
				}
				bool flag7 = this.isEltradeESDfiscal == 1;
				if (flag7)
				{
					this.isfiscal = 1;
				}
				ReportParameter reportParameter6 = new ReportParameter("isfiscal", Conversions.ToString(this.isfiscal));
				ReportParameter reportParameter7 = new ReportParameter("coid", Conversions.ToString(MyProject.Forms.Form1.coid));
				ReportParameter reportParameter8 = new ReportParameter("isdebitorder", Conversions.ToString(this.isdebitorder));
				int num = checked((int)Math.Round(Conversion.Val(this.pf.AdditionalSettings2Check(MyProject.Forms.Form1.coid, this.branch, "LeafbrightA4", MyProject.Forms.Form1.Constring))));
				ReportParameter reportParameter9 = new ReportParameter("LeafbrightA4", Conversions.ToString(num));
				ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter2, reportParameter3, reportParameter4, reportParameter5, reportParameter6, reportParameter7, reportParameter8, reportParameter9 };
				this.ReportViewer1.LocalReport.SetParameters(array);
				this.GetCompanyDetailsForCoidTableAdapter.Fill(this.POSDataSet.GetCompanyDetailsForCoid, new int?(MyProject.Forms.Form1.coid));
				this.SalesByInvoiceNumberCNTableAdapter.Fill(this.POSDataSet.SalesByInvoiceNumberCN, new int?(this.invnum), new int?(MyProject.Forms.Form1.coid), MyProject.Forms.Form1.branch);
				this.GetPaymentMethodsForInvoiceTableAdapter.Fill(this.POSDataSet.GetPaymentMethodsForInvoice, new long?((long)this.invnum), new int?(MyProject.Forms.Form1.coid), this.branch);
				this.GetUserForInvoiceCNTableAdapter.Fill(this.POSDataSet.GetUserForInvoiceCN, new int?(this.invnum), new int?(MyProject.Forms.Form1.coid), this.branch);
				this.FetchCustomerDetailsFromInvCNTableAdapter.Fill(this.POSDataSet.FetchCustomerDetailsFromInvCN, new int?(this.invnum), new int?(MyProject.Forms.Form1.coid), this.branch);
				this.GetBranchDetails1TableAdapter.Fill(this.POSDataSet.GetBranchDetails1, MyProject.Forms.Form1.branch, new int?(MyProject.Forms.Form1.coid), new int?(invPayDisplayDetails));
				this.GetBankingDetailsTableAdapter.Fill(this.POSDataSet.GetBankingDetails, new int?(MyProject.Forms.Form1.coid));
				this.BankingDetails2TableAdapter.Fill(this.POSDataSet.BankingDetails2, new int?(MyProject.Forms.Form1.coid));
				this.SalesByInvoiceNumberTotalsCNTableAdapter.Fill(this.POSDataSet.SalesByInvoiceNumberTotalsCN, new int?(this.invnum), new int?(MyProject.Forms.Form1.coid));
				this.ReportViewer1.LocalReport.DataSources.Clear();
				this.ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("CompanyDetails", this.POSDataSet.GetCompanyDetailsForCoid));
				this.ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("PaymentMethods", this.POSDataSet.GetPaymentMethodsForInvoice));
				this.ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("InvoiceUser", this.POSDataSet.GetUserForInvoiceCN));
				this.ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("CustomerDetails", this.POSDataSet.FetchCustomerDetailsFromInvCN));
				this.ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("InvoiceDetails", this.POSDataSet.SalesByInvoiceNumberCN));
				this.ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("BranchDetails", this.POSDataSet.GetBranchDetails1));
				this.ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("BankingDetails", this.POSDataSet.GetBankingDetails));
				this.ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("BankingDetails2", this.POSDataSet.GetBankingDetails2));
				this.ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("InvTotals", this.POSDataSet.SalesByInvoiceNumberTotalsCN));
				this.ReportViewer1.RefreshReport();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading report. Detail: " + ex.Message);
			}
		}

		// Token: 0x06004C0C RID: 19468 RVA: 0x002D5D18 File Offset: 0x002D3F18
		private int GetInvPayDisplayDetails()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SalesByInvoiceNumberCN";
			sqlCommand.Parameters.AddWithValue("invoicenum", this.invnum);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", this.branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			DataRow dataRow = dataTable.Rows[0];
			return Conversions.ToInteger(dataRow["ReceiptDisplayPaymentMethod"]);
		}

		// Token: 0x06004C0D RID: 19469 RVA: 0x002D5DE0 File Offset: 0x002D3FE0
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

		// Token: 0x04002174 RID: 8564
		public int invnum;

		// Token: 0x04002175 RID: 8565
		private string _cnn;

		// Token: 0x04002176 RID: 8566
		private PublicFunctions pf;

		// Token: 0x04002177 RID: 8567
		public string revmax_sign;

		// Token: 0x04002178 RID: 8568
		public int reprint;

		// Token: 0x04002179 RID: 8569
		public int isEltradeESDfiscal;

		// Token: 0x0400217A RID: 8570
		public string branch;

		// Token: 0x0400217B RID: 8571
		public int isdebitorder;

		// Token: 0x0400217C RID: 8572
		public int isfiscal;

		// Token: 0x0400217D RID: 8573
		public string template;
	}
}
