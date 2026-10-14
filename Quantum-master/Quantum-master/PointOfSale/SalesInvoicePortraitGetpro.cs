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
	// Token: 0x020001AB RID: 427
	[DesignerGenerated]
	public partial class SalesInvoicePortraitGetpro : Form
	{
		// Token: 0x06004C6F RID: 19567 RVA: 0x002D8324 File Offset: 0x002D6524
		public SalesInvoicePortraitGetpro()
		{
			base.Load += this.SalesInvoicePortraitGetpro_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.reprint = 0;
			this.isEltradeESDfiscal = 0;
			this.branch = "";
			this.showinvdisc = 0;
			this.isfiscal = 0;
			this.InitializeComponent();
		}

		// Token: 0x17001C04 RID: 7172
		// (get) Token: 0x06004C72 RID: 19570 RVA: 0x002D8ABF File Offset: 0x002D6CBF
		// (set) Token: 0x06004C73 RID: 19571 RVA: 0x002D8AC9 File Offset: 0x002D6CC9
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C05 RID: 7173
		// (get) Token: 0x06004C74 RID: 19572 RVA: 0x002D8AD2 File Offset: 0x002D6CD2
		// (set) Token: 0x06004C75 RID: 19573 RVA: 0x002D8ADC File Offset: 0x002D6CDC
		internal virtual BindingSource GetPaymentMethodsForInvoiceBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C06 RID: 7174
		// (get) Token: 0x06004C76 RID: 19574 RVA: 0x002D8AE5 File Offset: 0x002D6CE5
		// (set) Token: 0x06004C77 RID: 19575 RVA: 0x002D8AEF File Offset: 0x002D6CEF
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C07 RID: 7175
		// (get) Token: 0x06004C78 RID: 19576 RVA: 0x002D8AF8 File Offset: 0x002D6CF8
		// (set) Token: 0x06004C79 RID: 19577 RVA: 0x002D8B02 File Offset: 0x002D6D02
		internal virtual BindingSource GetUserForInvoiceBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C08 RID: 7176
		// (get) Token: 0x06004C7A RID: 19578 RVA: 0x002D8B0B File Offset: 0x002D6D0B
		// (set) Token: 0x06004C7B RID: 19579 RVA: 0x002D8B15 File Offset: 0x002D6D15
		internal virtual BindingSource FetchCustomerDetailsFromInvBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C09 RID: 7177
		// (get) Token: 0x06004C7C RID: 19580 RVA: 0x002D8B1E File Offset: 0x002D6D1E
		// (set) Token: 0x06004C7D RID: 19581 RVA: 0x002D8B28 File Offset: 0x002D6D28
		internal virtual BindingSource SalesByInvoiceNumberBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C0A RID: 7178
		// (get) Token: 0x06004C7E RID: 19582 RVA: 0x002D8B31 File Offset: 0x002D6D31
		// (set) Token: 0x06004C7F RID: 19583 RVA: 0x002D8B3B File Offset: 0x002D6D3B
		internal virtual BindingSource GetBranchDetails1BindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C0B RID: 7179
		// (get) Token: 0x06004C80 RID: 19584 RVA: 0x002D8B44 File Offset: 0x002D6D44
		// (set) Token: 0x06004C81 RID: 19585 RVA: 0x002D8B4E File Offset: 0x002D6D4E
		internal virtual BindingSource GetBankingDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C0C RID: 7180
		// (get) Token: 0x06004C82 RID: 19586 RVA: 0x002D8B57 File Offset: 0x002D6D57
		// (set) Token: 0x06004C83 RID: 19587 RVA: 0x002D8B61 File Offset: 0x002D6D61
		internal virtual BindingSource BankingDetails2BindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C0D RID: 7181
		// (get) Token: 0x06004C84 RID: 19588 RVA: 0x002D8B6A File Offset: 0x002D6D6A
		// (set) Token: 0x06004C85 RID: 19589 RVA: 0x002D8B74 File Offset: 0x002D6D74
		internal virtual BindingSource SalesByInvoiceNumberTotalsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C0E RID: 7182
		// (get) Token: 0x06004C86 RID: 19590 RVA: 0x002D8B7D File Offset: 0x002D6D7D
		// (set) Token: 0x06004C87 RID: 19591 RVA: 0x002D8B87 File Offset: 0x002D6D87
		internal virtual BindingSource GetCompanyDetailsForCoidBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C0F RID: 7183
		// (get) Token: 0x06004C88 RID: 19592 RVA: 0x002D8B90 File Offset: 0x002D6D90
		// (set) Token: 0x06004C89 RID: 19593 RVA: 0x002D8B9A File Offset: 0x002D6D9A
		internal virtual GetPaymentMethodsForInvoiceTableAdapter GetPaymentMethodsForInvoiceTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C10 RID: 7184
		// (get) Token: 0x06004C8A RID: 19594 RVA: 0x002D8BA3 File Offset: 0x002D6DA3
		// (set) Token: 0x06004C8B RID: 19595 RVA: 0x002D8BAD File Offset: 0x002D6DAD
		internal virtual GetUserForInvoiceTableAdapter GetUserForInvoiceTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C11 RID: 7185
		// (get) Token: 0x06004C8C RID: 19596 RVA: 0x002D8BB6 File Offset: 0x002D6DB6
		// (set) Token: 0x06004C8D RID: 19597 RVA: 0x002D8BC0 File Offset: 0x002D6DC0
		internal virtual FetchCustomerDetailsFromInvTableAdapter FetchCustomerDetailsFromInvTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C12 RID: 7186
		// (get) Token: 0x06004C8E RID: 19598 RVA: 0x002D8BC9 File Offset: 0x002D6DC9
		// (set) Token: 0x06004C8F RID: 19599 RVA: 0x002D8BD3 File Offset: 0x002D6DD3
		internal virtual SalesByInvoiceNumberTableAdapter SalesByInvoiceNumberTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C13 RID: 7187
		// (get) Token: 0x06004C90 RID: 19600 RVA: 0x002D8BDC File Offset: 0x002D6DDC
		// (set) Token: 0x06004C91 RID: 19601 RVA: 0x002D8BE6 File Offset: 0x002D6DE6
		internal virtual GetBranchDetails1TableAdapter GetBranchDetails1TableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C14 RID: 7188
		// (get) Token: 0x06004C92 RID: 19602 RVA: 0x002D8BEF File Offset: 0x002D6DEF
		// (set) Token: 0x06004C93 RID: 19603 RVA: 0x002D8BF9 File Offset: 0x002D6DF9
		internal virtual GetBankingDetailsTableAdapter GetBankingDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C15 RID: 7189
		// (get) Token: 0x06004C94 RID: 19604 RVA: 0x002D8C02 File Offset: 0x002D6E02
		// (set) Token: 0x06004C95 RID: 19605 RVA: 0x002D8C0C File Offset: 0x002D6E0C
		internal virtual BankingDetails2TableAdapter BankingDetails2TableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C16 RID: 7190
		// (get) Token: 0x06004C96 RID: 19606 RVA: 0x002D8C15 File Offset: 0x002D6E15
		// (set) Token: 0x06004C97 RID: 19607 RVA: 0x002D8C1F File Offset: 0x002D6E1F
		internal virtual SalesByInvoiceNumberTotalsTableAdapter SalesByInvoiceNumberTotalsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C17 RID: 7191
		// (get) Token: 0x06004C98 RID: 19608 RVA: 0x002D8C28 File Offset: 0x002D6E28
		// (set) Token: 0x06004C99 RID: 19609 RVA: 0x002D8C32 File Offset: 0x002D6E32
		internal virtual GetCompanyDetailsForCoidTableAdapter GetCompanyDetailsForCoidTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06004C9A RID: 19610 RVA: 0x002D8C3C File Offset: 0x002D6E3C
		private void SalesInvoicePortraitGetpro_Load(object sender, EventArgs e)
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

		// Token: 0x06004C9B RID: 19611 RVA: 0x002D923C File Offset: 0x002D743C
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

		// Token: 0x06004C9C RID: 19612 RVA: 0x002D92EC File Offset: 0x002D74EC
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

		// Token: 0x040021D2 RID: 8658
		public int invnum;

		// Token: 0x040021D3 RID: 8659
		private string _cnn;

		// Token: 0x040021D4 RID: 8660
		private PublicFunctions pf;

		// Token: 0x040021D5 RID: 8661
		public string revmax_sign;

		// Token: 0x040021D6 RID: 8662
		public int reprint;

		// Token: 0x040021D7 RID: 8663
		public int isEltradeESDfiscal;

		// Token: 0x040021D8 RID: 8664
		public string branch;

		// Token: 0x040021D9 RID: 8665
		public int showinvdisc;

		// Token: 0x040021DA RID: 8666
		public int isfiscal;
	}
}
