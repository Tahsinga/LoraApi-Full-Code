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
	// Token: 0x020001AC RID: 428
	[DesignerGenerated]
	public partial class SalesInvoicePortraitInco : Form
	{
		// Token: 0x06004C9D RID: 19613 RVA: 0x002D9398 File Offset: 0x002D7598
		public SalesInvoicePortraitInco()
		{
			base.Load += this.SalesInvoicePortraitInco_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.reprint = 0;
			this.isEltradeESDfiscal = 0;
			this.branch = "";
			this.showinvdisc = 0;
			this.InitializeComponent();
		}

		// Token: 0x17001C18 RID: 7192
		// (get) Token: 0x06004CA0 RID: 19616 RVA: 0x002D9B2B File Offset: 0x002D7D2B
		// (set) Token: 0x06004CA1 RID: 19617 RVA: 0x002D9B35 File Offset: 0x002D7D35
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C19 RID: 7193
		// (get) Token: 0x06004CA2 RID: 19618 RVA: 0x002D9B3E File Offset: 0x002D7D3E
		// (set) Token: 0x06004CA3 RID: 19619 RVA: 0x002D9B48 File Offset: 0x002D7D48
		internal virtual BindingSource GetPaymentMethodsForInvoiceBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C1A RID: 7194
		// (get) Token: 0x06004CA4 RID: 19620 RVA: 0x002D9B51 File Offset: 0x002D7D51
		// (set) Token: 0x06004CA5 RID: 19621 RVA: 0x002D9B5B File Offset: 0x002D7D5B
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C1B RID: 7195
		// (get) Token: 0x06004CA6 RID: 19622 RVA: 0x002D9B64 File Offset: 0x002D7D64
		// (set) Token: 0x06004CA7 RID: 19623 RVA: 0x002D9B6E File Offset: 0x002D7D6E
		internal virtual BindingSource GetUserForInvoiceBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C1C RID: 7196
		// (get) Token: 0x06004CA8 RID: 19624 RVA: 0x002D9B77 File Offset: 0x002D7D77
		// (set) Token: 0x06004CA9 RID: 19625 RVA: 0x002D9B81 File Offset: 0x002D7D81
		internal virtual BindingSource FetchCustomerDetailsFromInvBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C1D RID: 7197
		// (get) Token: 0x06004CAA RID: 19626 RVA: 0x002D9B8A File Offset: 0x002D7D8A
		// (set) Token: 0x06004CAB RID: 19627 RVA: 0x002D9B94 File Offset: 0x002D7D94
		internal virtual BindingSource SalesByInvoiceNumberBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C1E RID: 7198
		// (get) Token: 0x06004CAC RID: 19628 RVA: 0x002D9B9D File Offset: 0x002D7D9D
		// (set) Token: 0x06004CAD RID: 19629 RVA: 0x002D9BA7 File Offset: 0x002D7DA7
		internal virtual BindingSource GetBranchDetails1BindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C1F RID: 7199
		// (get) Token: 0x06004CAE RID: 19630 RVA: 0x002D9BB0 File Offset: 0x002D7DB0
		// (set) Token: 0x06004CAF RID: 19631 RVA: 0x002D9BBA File Offset: 0x002D7DBA
		internal virtual BindingSource GetBankingDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C20 RID: 7200
		// (get) Token: 0x06004CB0 RID: 19632 RVA: 0x002D9BC3 File Offset: 0x002D7DC3
		// (set) Token: 0x06004CB1 RID: 19633 RVA: 0x002D9BCD File Offset: 0x002D7DCD
		internal virtual BindingSource BankingDetails2BindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C21 RID: 7201
		// (get) Token: 0x06004CB2 RID: 19634 RVA: 0x002D9BD6 File Offset: 0x002D7DD6
		// (set) Token: 0x06004CB3 RID: 19635 RVA: 0x002D9BE0 File Offset: 0x002D7DE0
		internal virtual BindingSource SalesByInvoiceNumberTotalsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C22 RID: 7202
		// (get) Token: 0x06004CB4 RID: 19636 RVA: 0x002D9BE9 File Offset: 0x002D7DE9
		// (set) Token: 0x06004CB5 RID: 19637 RVA: 0x002D9BF3 File Offset: 0x002D7DF3
		internal virtual BindingSource GetCompanyDetailsForCoidBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C23 RID: 7203
		// (get) Token: 0x06004CB6 RID: 19638 RVA: 0x002D9BFC File Offset: 0x002D7DFC
		// (set) Token: 0x06004CB7 RID: 19639 RVA: 0x002D9C06 File Offset: 0x002D7E06
		internal virtual GetPaymentMethodsForInvoiceTableAdapter GetPaymentMethodsForInvoiceTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C24 RID: 7204
		// (get) Token: 0x06004CB8 RID: 19640 RVA: 0x002D9C0F File Offset: 0x002D7E0F
		// (set) Token: 0x06004CB9 RID: 19641 RVA: 0x002D9C19 File Offset: 0x002D7E19
		internal virtual GetUserForInvoiceTableAdapter GetUserForInvoiceTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C25 RID: 7205
		// (get) Token: 0x06004CBA RID: 19642 RVA: 0x002D9C22 File Offset: 0x002D7E22
		// (set) Token: 0x06004CBB RID: 19643 RVA: 0x002D9C2C File Offset: 0x002D7E2C
		internal virtual FetchCustomerDetailsFromInvTableAdapter FetchCustomerDetailsFromInvTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C26 RID: 7206
		// (get) Token: 0x06004CBC RID: 19644 RVA: 0x002D9C35 File Offset: 0x002D7E35
		// (set) Token: 0x06004CBD RID: 19645 RVA: 0x002D9C3F File Offset: 0x002D7E3F
		internal virtual SalesByInvoiceNumberTableAdapter SalesByInvoiceNumberTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C27 RID: 7207
		// (get) Token: 0x06004CBE RID: 19646 RVA: 0x002D9C48 File Offset: 0x002D7E48
		// (set) Token: 0x06004CBF RID: 19647 RVA: 0x002D9C52 File Offset: 0x002D7E52
		internal virtual GetBranchDetails1TableAdapter GetBranchDetails1TableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C28 RID: 7208
		// (get) Token: 0x06004CC0 RID: 19648 RVA: 0x002D9C5B File Offset: 0x002D7E5B
		// (set) Token: 0x06004CC1 RID: 19649 RVA: 0x002D9C65 File Offset: 0x002D7E65
		internal virtual GetBankingDetailsTableAdapter GetBankingDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C29 RID: 7209
		// (get) Token: 0x06004CC2 RID: 19650 RVA: 0x002D9C6E File Offset: 0x002D7E6E
		// (set) Token: 0x06004CC3 RID: 19651 RVA: 0x002D9C78 File Offset: 0x002D7E78
		internal virtual BankingDetails2TableAdapter BankingDetails2TableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C2A RID: 7210
		// (get) Token: 0x06004CC4 RID: 19652 RVA: 0x002D9C81 File Offset: 0x002D7E81
		// (set) Token: 0x06004CC5 RID: 19653 RVA: 0x002D9C8B File Offset: 0x002D7E8B
		internal virtual SalesByInvoiceNumberTotalsTableAdapter SalesByInvoiceNumberTotalsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C2B RID: 7211
		// (get) Token: 0x06004CC6 RID: 19654 RVA: 0x002D9C94 File Offset: 0x002D7E94
		// (set) Token: 0x06004CC7 RID: 19655 RVA: 0x002D9C9E File Offset: 0x002D7E9E
		internal virtual GetCompanyDetailsForCoidTableAdapter GetCompanyDetailsForCoidTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06004CC8 RID: 19656 RVA: 0x002D9CA8 File Offset: 0x002D7EA8
		private void SalesInvoicePortraitInco_Load(object sender, EventArgs e)
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
				this.GetBranchDetails1TableAdapter.Fill(this.POSDataSet.GetBranchDetails1, MyProject.Forms.Form1.branch, new int?(MyProject.Forms.Form1.coid), new int?(this.GetInvPayDisplayDetails()));
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

		// Token: 0x06004CC9 RID: 19657 RVA: 0x002DA2A8 File Offset: 0x002D84A8
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

		// Token: 0x06004CCA RID: 19658 RVA: 0x002DA358 File Offset: 0x002D8558
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

		// Token: 0x040021F0 RID: 8688
		public int invnum;

		// Token: 0x040021F1 RID: 8689
		private string _cnn;

		// Token: 0x040021F2 RID: 8690
		private PublicFunctions pf;

		// Token: 0x040021F3 RID: 8691
		public string revmax_sign;

		// Token: 0x040021F4 RID: 8692
		public int reprint;

		// Token: 0x040021F5 RID: 8693
		public int isEltradeESDfiscal;

		// Token: 0x040021F6 RID: 8694
		public string branch;

		// Token: 0x040021F7 RID: 8695
		public int showinvdisc;
	}
}
