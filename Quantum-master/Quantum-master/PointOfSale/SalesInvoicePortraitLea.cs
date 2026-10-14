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
	// Token: 0x020001AD RID: 429
	[DesignerGenerated]
	public partial class SalesInvoicePortraitLea : Form
	{
		// Token: 0x06004CCB RID: 19659 RVA: 0x002DA404 File Offset: 0x002D8604
		public SalesInvoicePortraitLea()
		{
			base.Load += this.SalesInvoicePortraitLea_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.reprint = 0;
			this.isEltradeESDfiscal = 0;
			this.branch = "";
			this.showinvdisc = 0;
			this.InitializeComponent();
		}

		// Token: 0x17001C2C RID: 7212
		// (get) Token: 0x06004CCE RID: 19662 RVA: 0x002DAB97 File Offset: 0x002D8D97
		// (set) Token: 0x06004CCF RID: 19663 RVA: 0x002DABA1 File Offset: 0x002D8DA1
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C2D RID: 7213
		// (get) Token: 0x06004CD0 RID: 19664 RVA: 0x002DABAA File Offset: 0x002D8DAA
		// (set) Token: 0x06004CD1 RID: 19665 RVA: 0x002DABB4 File Offset: 0x002D8DB4
		internal virtual BindingSource GetPaymentMethodsForInvoiceBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C2E RID: 7214
		// (get) Token: 0x06004CD2 RID: 19666 RVA: 0x002DABBD File Offset: 0x002D8DBD
		// (set) Token: 0x06004CD3 RID: 19667 RVA: 0x002DABC7 File Offset: 0x002D8DC7
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C2F RID: 7215
		// (get) Token: 0x06004CD4 RID: 19668 RVA: 0x002DABD0 File Offset: 0x002D8DD0
		// (set) Token: 0x06004CD5 RID: 19669 RVA: 0x002DABDA File Offset: 0x002D8DDA
		internal virtual BindingSource GetUserForInvoiceBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C30 RID: 7216
		// (get) Token: 0x06004CD6 RID: 19670 RVA: 0x002DABE3 File Offset: 0x002D8DE3
		// (set) Token: 0x06004CD7 RID: 19671 RVA: 0x002DABED File Offset: 0x002D8DED
		internal virtual BindingSource FetchCustomerDetailsFromInvBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C31 RID: 7217
		// (get) Token: 0x06004CD8 RID: 19672 RVA: 0x002DABF6 File Offset: 0x002D8DF6
		// (set) Token: 0x06004CD9 RID: 19673 RVA: 0x002DAC00 File Offset: 0x002D8E00
		internal virtual BindingSource SalesByInvoiceNumberBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C32 RID: 7218
		// (get) Token: 0x06004CDA RID: 19674 RVA: 0x002DAC09 File Offset: 0x002D8E09
		// (set) Token: 0x06004CDB RID: 19675 RVA: 0x002DAC13 File Offset: 0x002D8E13
		internal virtual BindingSource GetBranchDetails1BindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C33 RID: 7219
		// (get) Token: 0x06004CDC RID: 19676 RVA: 0x002DAC1C File Offset: 0x002D8E1C
		// (set) Token: 0x06004CDD RID: 19677 RVA: 0x002DAC26 File Offset: 0x002D8E26
		internal virtual BindingSource GetBankingDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C34 RID: 7220
		// (get) Token: 0x06004CDE RID: 19678 RVA: 0x002DAC2F File Offset: 0x002D8E2F
		// (set) Token: 0x06004CDF RID: 19679 RVA: 0x002DAC39 File Offset: 0x002D8E39
		internal virtual BindingSource BankingDetails2BindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C35 RID: 7221
		// (get) Token: 0x06004CE0 RID: 19680 RVA: 0x002DAC42 File Offset: 0x002D8E42
		// (set) Token: 0x06004CE1 RID: 19681 RVA: 0x002DAC4C File Offset: 0x002D8E4C
		internal virtual BindingSource SalesByInvoiceNumberTotalsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C36 RID: 7222
		// (get) Token: 0x06004CE2 RID: 19682 RVA: 0x002DAC55 File Offset: 0x002D8E55
		// (set) Token: 0x06004CE3 RID: 19683 RVA: 0x002DAC5F File Offset: 0x002D8E5F
		internal virtual BindingSource GetCompanyDetailsForCoidBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C37 RID: 7223
		// (get) Token: 0x06004CE4 RID: 19684 RVA: 0x002DAC68 File Offset: 0x002D8E68
		// (set) Token: 0x06004CE5 RID: 19685 RVA: 0x002DAC72 File Offset: 0x002D8E72
		internal virtual GetPaymentMethodsForInvoiceTableAdapter GetPaymentMethodsForInvoiceTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C38 RID: 7224
		// (get) Token: 0x06004CE6 RID: 19686 RVA: 0x002DAC7B File Offset: 0x002D8E7B
		// (set) Token: 0x06004CE7 RID: 19687 RVA: 0x002DAC85 File Offset: 0x002D8E85
		internal virtual GetUserForInvoiceTableAdapter GetUserForInvoiceTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C39 RID: 7225
		// (get) Token: 0x06004CE8 RID: 19688 RVA: 0x002DAC8E File Offset: 0x002D8E8E
		// (set) Token: 0x06004CE9 RID: 19689 RVA: 0x002DAC98 File Offset: 0x002D8E98
		internal virtual FetchCustomerDetailsFromInvTableAdapter FetchCustomerDetailsFromInvTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C3A RID: 7226
		// (get) Token: 0x06004CEA RID: 19690 RVA: 0x002DACA1 File Offset: 0x002D8EA1
		// (set) Token: 0x06004CEB RID: 19691 RVA: 0x002DACAB File Offset: 0x002D8EAB
		internal virtual SalesByInvoiceNumberTableAdapter SalesByInvoiceNumberTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C3B RID: 7227
		// (get) Token: 0x06004CEC RID: 19692 RVA: 0x002DACB4 File Offset: 0x002D8EB4
		// (set) Token: 0x06004CED RID: 19693 RVA: 0x002DACBE File Offset: 0x002D8EBE
		internal virtual GetBranchDetails1TableAdapter GetBranchDetails1TableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C3C RID: 7228
		// (get) Token: 0x06004CEE RID: 19694 RVA: 0x002DACC7 File Offset: 0x002D8EC7
		// (set) Token: 0x06004CEF RID: 19695 RVA: 0x002DACD1 File Offset: 0x002D8ED1
		internal virtual GetBankingDetailsTableAdapter GetBankingDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C3D RID: 7229
		// (get) Token: 0x06004CF0 RID: 19696 RVA: 0x002DACDA File Offset: 0x002D8EDA
		// (set) Token: 0x06004CF1 RID: 19697 RVA: 0x002DACE4 File Offset: 0x002D8EE4
		internal virtual BankingDetails2TableAdapter BankingDetails2TableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C3E RID: 7230
		// (get) Token: 0x06004CF2 RID: 19698 RVA: 0x002DACED File Offset: 0x002D8EED
		// (set) Token: 0x06004CF3 RID: 19699 RVA: 0x002DACF7 File Offset: 0x002D8EF7
		internal virtual SalesByInvoiceNumberTotalsTableAdapter SalesByInvoiceNumberTotalsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C3F RID: 7231
		// (get) Token: 0x06004CF4 RID: 19700 RVA: 0x002DAD00 File Offset: 0x002D8F00
		// (set) Token: 0x06004CF5 RID: 19701 RVA: 0x002DAD0A File Offset: 0x002D8F0A
		internal virtual GetCompanyDetailsForCoidTableAdapter GetCompanyDetailsForCoidTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06004CF6 RID: 19702 RVA: 0x002DAD14 File Offset: 0x002D8F14
		private void SalesInvoicePortraitLea_Load(object sender, EventArgs e)
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

		// Token: 0x06004CF7 RID: 19703 RVA: 0x002DB30C File Offset: 0x002D950C
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

		// Token: 0x06004CF8 RID: 19704 RVA: 0x002DB3BC File Offset: 0x002D95BC
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

		// Token: 0x0400220D RID: 8717
		public int invnum;

		// Token: 0x0400220E RID: 8718
		private string _cnn;

		// Token: 0x0400220F RID: 8719
		private PublicFunctions pf;

		// Token: 0x04002210 RID: 8720
		public string revmax_sign;

		// Token: 0x04002211 RID: 8721
		public int reprint;

		// Token: 0x04002212 RID: 8722
		public int isEltradeESDfiscal;

		// Token: 0x04002213 RID: 8723
		public string branch;

		// Token: 0x04002214 RID: 8724
		public int showinvdisc;
	}
}
