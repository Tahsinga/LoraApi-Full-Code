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
	// Token: 0x0200020D RID: 525
	[DesignerGenerated]
	public partial class ViewDebitNote : Form
	{
		// Token: 0x06005E5A RID: 24154 RVA: 0x003621B0 File Offset: 0x003603B0
		public ViewDebitNote()
		{
			base.Load += this.ViewDebitNote_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.reprint = 0;
			this.isEltradeESDfiscal = 0;
			this.branch = "";
			this.showinvdisc = 0;
			this.InitializeComponent();
		}

		// Token: 0x17002214 RID: 8724
		// (get) Token: 0x06005E5D RID: 24157 RVA: 0x00362943 File Offset: 0x00360B43
		// (set) Token: 0x06005E5E RID: 24158 RVA: 0x0036294D File Offset: 0x00360B4D
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002215 RID: 8725
		// (get) Token: 0x06005E5F RID: 24159 RVA: 0x00362956 File Offset: 0x00360B56
		// (set) Token: 0x06005E60 RID: 24160 RVA: 0x00362960 File Offset: 0x00360B60
		internal virtual BindingSource GetPaymentMethodsForInvoiceBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002216 RID: 8726
		// (get) Token: 0x06005E61 RID: 24161 RVA: 0x00362969 File Offset: 0x00360B69
		// (set) Token: 0x06005E62 RID: 24162 RVA: 0x00362973 File Offset: 0x00360B73
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002217 RID: 8727
		// (get) Token: 0x06005E63 RID: 24163 RVA: 0x0036297C File Offset: 0x00360B7C
		// (set) Token: 0x06005E64 RID: 24164 RVA: 0x00362986 File Offset: 0x00360B86
		internal virtual BindingSource GetUserForInvoiceDBBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002218 RID: 8728
		// (get) Token: 0x06005E65 RID: 24165 RVA: 0x0036298F File Offset: 0x00360B8F
		// (set) Token: 0x06005E66 RID: 24166 RVA: 0x00362999 File Offset: 0x00360B99
		internal virtual BindingSource FetchCustomerDetailsFromInvBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002219 RID: 8729
		// (get) Token: 0x06005E67 RID: 24167 RVA: 0x003629A2 File Offset: 0x00360BA2
		// (set) Token: 0x06005E68 RID: 24168 RVA: 0x003629AC File Offset: 0x00360BAC
		internal virtual BindingSource GetCompanyDetailsForCoidBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700221A RID: 8730
		// (get) Token: 0x06005E69 RID: 24169 RVA: 0x003629B5 File Offset: 0x00360BB5
		// (set) Token: 0x06005E6A RID: 24170 RVA: 0x003629BF File Offset: 0x00360BBF
		internal virtual BindingSource GetBranchDetails1BindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700221B RID: 8731
		// (get) Token: 0x06005E6B RID: 24171 RVA: 0x003629C8 File Offset: 0x00360BC8
		// (set) Token: 0x06005E6C RID: 24172 RVA: 0x003629D2 File Offset: 0x00360BD2
		internal virtual BindingSource GetBankingDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700221C RID: 8732
		// (get) Token: 0x06005E6D RID: 24173 RVA: 0x003629DB File Offset: 0x00360BDB
		// (set) Token: 0x06005E6E RID: 24174 RVA: 0x003629E5 File Offset: 0x00360BE5
		internal virtual BindingSource BankingDetails2BindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700221D RID: 8733
		// (get) Token: 0x06005E6F RID: 24175 RVA: 0x003629EE File Offset: 0x00360BEE
		// (set) Token: 0x06005E70 RID: 24176 RVA: 0x003629F8 File Offset: 0x00360BF8
		internal virtual BindingSource SalesByInvoiceNumberTotalsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700221E RID: 8734
		// (get) Token: 0x06005E71 RID: 24177 RVA: 0x00362A01 File Offset: 0x00360C01
		// (set) Token: 0x06005E72 RID: 24178 RVA: 0x00362A0B File Offset: 0x00360C0B
		internal virtual GetPaymentMethodsForInvoiceTableAdapter GetPaymentMethodsForInvoiceTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700221F RID: 8735
		// (get) Token: 0x06005E73 RID: 24179 RVA: 0x00362A14 File Offset: 0x00360C14
		// (set) Token: 0x06005E74 RID: 24180 RVA: 0x00362A1E File Offset: 0x00360C1E
		internal virtual GetUserForInvoiceDBTableAdapter GetUserForInvoiceDBTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002220 RID: 8736
		// (get) Token: 0x06005E75 RID: 24181 RVA: 0x00362A27 File Offset: 0x00360C27
		// (set) Token: 0x06005E76 RID: 24182 RVA: 0x00362A31 File Offset: 0x00360C31
		internal virtual FetchCustomerDetailsFromInvTableAdapter FetchCustomerDetailsFromInvTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002221 RID: 8737
		// (get) Token: 0x06005E77 RID: 24183 RVA: 0x00362A3A File Offset: 0x00360C3A
		// (set) Token: 0x06005E78 RID: 24184 RVA: 0x00362A44 File Offset: 0x00360C44
		internal virtual GetCompanyDetailsForCoidTableAdapter GetCompanyDetailsForCoidTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002222 RID: 8738
		// (get) Token: 0x06005E79 RID: 24185 RVA: 0x00362A4D File Offset: 0x00360C4D
		// (set) Token: 0x06005E7A RID: 24186 RVA: 0x00362A57 File Offset: 0x00360C57
		internal virtual GetBranchDetails1TableAdapter GetBranchDetails1TableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002223 RID: 8739
		// (get) Token: 0x06005E7B RID: 24187 RVA: 0x00362A60 File Offset: 0x00360C60
		// (set) Token: 0x06005E7C RID: 24188 RVA: 0x00362A6A File Offset: 0x00360C6A
		internal virtual GetBankingDetailsTableAdapter GetBankingDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002224 RID: 8740
		// (get) Token: 0x06005E7D RID: 24189 RVA: 0x00362A73 File Offset: 0x00360C73
		// (set) Token: 0x06005E7E RID: 24190 RVA: 0x00362A7D File Offset: 0x00360C7D
		internal virtual BankingDetails2TableAdapter BankingDetails2TableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002225 RID: 8741
		// (get) Token: 0x06005E7F RID: 24191 RVA: 0x00362A86 File Offset: 0x00360C86
		// (set) Token: 0x06005E80 RID: 24192 RVA: 0x00362A90 File Offset: 0x00360C90
		internal virtual SalesByInvoiceNumberTotalsTableAdapter SalesByInvoiceNumberTotalsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002226 RID: 8742
		// (get) Token: 0x06005E81 RID: 24193 RVA: 0x00362A99 File Offset: 0x00360C99
		// (set) Token: 0x06005E82 RID: 24194 RVA: 0x00362AA3 File Offset: 0x00360CA3
		internal virtual BindingSource SalesByInvoiceNumberDBBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002227 RID: 8743
		// (get) Token: 0x06005E83 RID: 24195 RVA: 0x00362AAC File Offset: 0x00360CAC
		// (set) Token: 0x06005E84 RID: 24196 RVA: 0x00362AB6 File Offset: 0x00360CB6
		internal virtual SalesByInvoiceNumberDBTableAdapter SalesByInvoiceNumberDBTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06005E85 RID: 24197 RVA: 0x00362AC0 File Offset: 0x00360CC0
		private void ViewDebitNote_Load(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
				this.GetCompanyDetailsForCoidTableAdapter.Connection = sqlConnection;
				this.SalesByInvoiceNumberDBTableAdapter.Connection = sqlConnection;
				this.GetPaymentMethodsForInvoiceTableAdapter.Connection = sqlConnection;
				this.GetUserForInvoiceDBTableAdapter.Connection = sqlConnection;
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
				ReportParameter reportParameter3 = new ReportParameter("paymentmethod", this.GetPayMethName(this.GetInvPayDisplayDetails()));
				ReportParameter reportParameter4 = new ReportParameter("reprint", Conversions.ToString(Conversions.ToInteger(Interaction.IIf(this.reprint == 1, 1, 0))));
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
				ReportParameter reportParameter5 = new ReportParameter("isfiscal", Conversions.ToString(num));
				ReportParameter reportParameter6 = new ReportParameter("coid", Conversions.ToString(MyProject.Forms.Form1.coid));
				ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter2, reportParameter3, reportParameter4, reportParameter5, reportParameter6 };
				this.ReportViewer1.LocalReport.SetParameters(array);
				this.GetCompanyDetailsForCoidTableAdapter.Fill(this.POSDataSet.GetCompanyDetailsForCoid, new int?(MyProject.Forms.Form1.coid));
				this.SalesByInvoiceNumberDBTableAdapter.Fill(this.POSDataSet.SalesByInvoiceNumberDB, new int?(this.invnum), new int?(MyProject.Forms.Form1.coid), this.branch);
				this.GetPaymentMethodsForInvoiceTableAdapter.Fill(this.POSDataSet.GetPaymentMethodsForInvoice, new long?((long)this.invnum), new int?(MyProject.Forms.Form1.coid), this.branch);
				this.GetUserForInvoiceDBTableAdapter.Fill(this.POSDataSet.GetUserForInvoiceDB, new int?(this.invnum), new int?(MyProject.Forms.Form1.coid), this.branch);
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

		// Token: 0x06005E86 RID: 24198 RVA: 0x00363064 File Offset: 0x00361264
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

		// Token: 0x06005E87 RID: 24199 RVA: 0x00363114 File Offset: 0x00361314
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

		// Token: 0x04002975 RID: 10613
		public int invnum;

		// Token: 0x04002976 RID: 10614
		private string _cnn;

		// Token: 0x04002977 RID: 10615
		private PublicFunctions pf;

		// Token: 0x04002978 RID: 10616
		public string revmax_sign;

		// Token: 0x04002979 RID: 10617
		public int reprint;

		// Token: 0x0400297A RID: 10618
		public int isEltradeESDfiscal;

		// Token: 0x0400297B RID: 10619
		public string branch;

		// Token: 0x0400297C RID: 10620
		public int showinvdisc;
	}
}
