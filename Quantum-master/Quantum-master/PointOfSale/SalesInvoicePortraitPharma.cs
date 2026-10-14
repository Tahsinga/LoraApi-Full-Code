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
	// Token: 0x020001AE RID: 430
	[DesignerGenerated]
	public partial class SalesInvoicePortraitPharma : Form
	{
		// Token: 0x06004CF9 RID: 19705 RVA: 0x002DB468 File Offset: 0x002D9668
		public SalesInvoicePortraitPharma()
		{
			base.Load += this.SalesInvoicePortraitPharma_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.reprint = 0;
			this.isEltradeESDfiscal = 0;
			this.branch = "";
			this.showinvdisc = 0;
			this.InitializeComponent();
		}

		// Token: 0x17001C40 RID: 7232
		// (get) Token: 0x06004CFC RID: 19708 RVA: 0x002DBBFB File Offset: 0x002D9DFB
		// (set) Token: 0x06004CFD RID: 19709 RVA: 0x002DBC05 File Offset: 0x002D9E05
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C41 RID: 7233
		// (get) Token: 0x06004CFE RID: 19710 RVA: 0x002DBC0E File Offset: 0x002D9E0E
		// (set) Token: 0x06004CFF RID: 19711 RVA: 0x002DBC18 File Offset: 0x002D9E18
		internal virtual BindingSource GetPaymentMethodsForInvoiceBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C42 RID: 7234
		// (get) Token: 0x06004D00 RID: 19712 RVA: 0x002DBC21 File Offset: 0x002D9E21
		// (set) Token: 0x06004D01 RID: 19713 RVA: 0x002DBC2B File Offset: 0x002D9E2B
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C43 RID: 7235
		// (get) Token: 0x06004D02 RID: 19714 RVA: 0x002DBC34 File Offset: 0x002D9E34
		// (set) Token: 0x06004D03 RID: 19715 RVA: 0x002DBC3E File Offset: 0x002D9E3E
		internal virtual BindingSource GetUserForInvoiceBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C44 RID: 7236
		// (get) Token: 0x06004D04 RID: 19716 RVA: 0x002DBC47 File Offset: 0x002D9E47
		// (set) Token: 0x06004D05 RID: 19717 RVA: 0x002DBC51 File Offset: 0x002D9E51
		internal virtual BindingSource FetchCustomerDetailsFromInvBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C45 RID: 7237
		// (get) Token: 0x06004D06 RID: 19718 RVA: 0x002DBC5A File Offset: 0x002D9E5A
		// (set) Token: 0x06004D07 RID: 19719 RVA: 0x002DBC64 File Offset: 0x002D9E64
		internal virtual BindingSource SalesByInvoiceNumberBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C46 RID: 7238
		// (get) Token: 0x06004D08 RID: 19720 RVA: 0x002DBC6D File Offset: 0x002D9E6D
		// (set) Token: 0x06004D09 RID: 19721 RVA: 0x002DBC77 File Offset: 0x002D9E77
		internal virtual BindingSource GetBranchDetails1BindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C47 RID: 7239
		// (get) Token: 0x06004D0A RID: 19722 RVA: 0x002DBC80 File Offset: 0x002D9E80
		// (set) Token: 0x06004D0B RID: 19723 RVA: 0x002DBC8A File Offset: 0x002D9E8A
		internal virtual BindingSource GetBankingDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C48 RID: 7240
		// (get) Token: 0x06004D0C RID: 19724 RVA: 0x002DBC93 File Offset: 0x002D9E93
		// (set) Token: 0x06004D0D RID: 19725 RVA: 0x002DBC9D File Offset: 0x002D9E9D
		internal virtual BindingSource BankingDetails2BindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C49 RID: 7241
		// (get) Token: 0x06004D0E RID: 19726 RVA: 0x002DBCA6 File Offset: 0x002D9EA6
		// (set) Token: 0x06004D0F RID: 19727 RVA: 0x002DBCB0 File Offset: 0x002D9EB0
		internal virtual BindingSource SalesByInvoiceNumberTotalsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C4A RID: 7242
		// (get) Token: 0x06004D10 RID: 19728 RVA: 0x002DBCB9 File Offset: 0x002D9EB9
		// (set) Token: 0x06004D11 RID: 19729 RVA: 0x002DBCC3 File Offset: 0x002D9EC3
		internal virtual BindingSource GetCompanyDetailsForCoidBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C4B RID: 7243
		// (get) Token: 0x06004D12 RID: 19730 RVA: 0x002DBCCC File Offset: 0x002D9ECC
		// (set) Token: 0x06004D13 RID: 19731 RVA: 0x002DBCD6 File Offset: 0x002D9ED6
		internal virtual GetPaymentMethodsForInvoiceTableAdapter GetPaymentMethodsForInvoiceTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C4C RID: 7244
		// (get) Token: 0x06004D14 RID: 19732 RVA: 0x002DBCDF File Offset: 0x002D9EDF
		// (set) Token: 0x06004D15 RID: 19733 RVA: 0x002DBCE9 File Offset: 0x002D9EE9
		internal virtual GetUserForInvoiceTableAdapter GetUserForInvoiceTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C4D RID: 7245
		// (get) Token: 0x06004D16 RID: 19734 RVA: 0x002DBCF2 File Offset: 0x002D9EF2
		// (set) Token: 0x06004D17 RID: 19735 RVA: 0x002DBCFC File Offset: 0x002D9EFC
		internal virtual FetchCustomerDetailsFromInvTableAdapter FetchCustomerDetailsFromInvTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C4E RID: 7246
		// (get) Token: 0x06004D18 RID: 19736 RVA: 0x002DBD05 File Offset: 0x002D9F05
		// (set) Token: 0x06004D19 RID: 19737 RVA: 0x002DBD0F File Offset: 0x002D9F0F
		internal virtual SalesByInvoiceNumberTableAdapter SalesByInvoiceNumberTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C4F RID: 7247
		// (get) Token: 0x06004D1A RID: 19738 RVA: 0x002DBD18 File Offset: 0x002D9F18
		// (set) Token: 0x06004D1B RID: 19739 RVA: 0x002DBD22 File Offset: 0x002D9F22
		internal virtual GetBranchDetails1TableAdapter GetBranchDetails1TableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C50 RID: 7248
		// (get) Token: 0x06004D1C RID: 19740 RVA: 0x002DBD2B File Offset: 0x002D9F2B
		// (set) Token: 0x06004D1D RID: 19741 RVA: 0x002DBD35 File Offset: 0x002D9F35
		internal virtual GetBankingDetailsTableAdapter GetBankingDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C51 RID: 7249
		// (get) Token: 0x06004D1E RID: 19742 RVA: 0x002DBD3E File Offset: 0x002D9F3E
		// (set) Token: 0x06004D1F RID: 19743 RVA: 0x002DBD48 File Offset: 0x002D9F48
		internal virtual BankingDetails2TableAdapter BankingDetails2TableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C52 RID: 7250
		// (get) Token: 0x06004D20 RID: 19744 RVA: 0x002DBD51 File Offset: 0x002D9F51
		// (set) Token: 0x06004D21 RID: 19745 RVA: 0x002DBD5B File Offset: 0x002D9F5B
		internal virtual SalesByInvoiceNumberTotalsTableAdapter SalesByInvoiceNumberTotalsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C53 RID: 7251
		// (get) Token: 0x06004D22 RID: 19746 RVA: 0x002DBD64 File Offset: 0x002D9F64
		// (set) Token: 0x06004D23 RID: 19747 RVA: 0x002DBD6E File Offset: 0x002D9F6E
		internal virtual GetCompanyDetailsForCoidTableAdapter GetCompanyDetailsForCoidTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06004D24 RID: 19748 RVA: 0x002DBD78 File Offset: 0x002D9F78
		private void SalesInvoicePortraitPharma_Load(object sender, EventArgs e)
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
			this.ReportViewer1.RefreshReport();
		}

		// Token: 0x06004D25 RID: 19749 RVA: 0x002DC37C File Offset: 0x002DA57C
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

		// Token: 0x06004D26 RID: 19750 RVA: 0x002DC42C File Offset: 0x002DA62C
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

		// Token: 0x0400222A RID: 8746
		public int invnum;

		// Token: 0x0400222B RID: 8747
		private string _cnn;

		// Token: 0x0400222C RID: 8748
		private PublicFunctions pf;

		// Token: 0x0400222D RID: 8749
		public string revmax_sign;

		// Token: 0x0400222E RID: 8750
		public int reprint;

		// Token: 0x0400222F RID: 8751
		public int isEltradeESDfiscal;

		// Token: 0x04002230 RID: 8752
		public string branch;

		// Token: 0x04002231 RID: 8753
		public int showinvdisc;
	}
}
