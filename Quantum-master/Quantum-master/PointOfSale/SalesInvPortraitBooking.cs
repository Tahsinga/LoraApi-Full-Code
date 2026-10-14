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
	// Token: 0x020001B2 RID: 434
	[DesignerGenerated]
	public partial class SalesInvPortraitBooking : Form
	{
		// Token: 0x06004DAB RID: 19883 RVA: 0x002DF1C4 File Offset: 0x002DD3C4
		public SalesInvPortraitBooking()
		{
			base.Load += this.SalesInvPortraitBooking_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.reprint = 0;
			this.isEltradeESDfiscal = 0;
			this.InitializeComponent();
		}

		// Token: 0x17001C8E RID: 7310
		// (get) Token: 0x06004DAE RID: 19886 RVA: 0x002DF943 File Offset: 0x002DDB43
		// (set) Token: 0x06004DAF RID: 19887 RVA: 0x002DF94D File Offset: 0x002DDB4D
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C8F RID: 7311
		// (get) Token: 0x06004DB0 RID: 19888 RVA: 0x002DF956 File Offset: 0x002DDB56
		// (set) Token: 0x06004DB1 RID: 19889 RVA: 0x002DF960 File Offset: 0x002DDB60
		internal virtual BindingSource GetPaymentMethodsForInvoiceBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C90 RID: 7312
		// (get) Token: 0x06004DB2 RID: 19890 RVA: 0x002DF969 File Offset: 0x002DDB69
		// (set) Token: 0x06004DB3 RID: 19891 RVA: 0x002DF973 File Offset: 0x002DDB73
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C91 RID: 7313
		// (get) Token: 0x06004DB4 RID: 19892 RVA: 0x002DF97C File Offset: 0x002DDB7C
		// (set) Token: 0x06004DB5 RID: 19893 RVA: 0x002DF986 File Offset: 0x002DDB86
		internal virtual BindingSource GetUserForInvoiceBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C92 RID: 7314
		// (get) Token: 0x06004DB6 RID: 19894 RVA: 0x002DF98F File Offset: 0x002DDB8F
		// (set) Token: 0x06004DB7 RID: 19895 RVA: 0x002DF999 File Offset: 0x002DDB99
		internal virtual BindingSource FetchCustomerDetailsFromInvBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C93 RID: 7315
		// (get) Token: 0x06004DB8 RID: 19896 RVA: 0x002DF9A2 File Offset: 0x002DDBA2
		// (set) Token: 0x06004DB9 RID: 19897 RVA: 0x002DF9AC File Offset: 0x002DDBAC
		internal virtual BindingSource GetCompanyDetailsForCoidBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C94 RID: 7316
		// (get) Token: 0x06004DBA RID: 19898 RVA: 0x002DF9B5 File Offset: 0x002DDBB5
		// (set) Token: 0x06004DBB RID: 19899 RVA: 0x002DF9BF File Offset: 0x002DDBBF
		internal virtual BindingSource SalesByInvoiceNumberBookingBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C95 RID: 7317
		// (get) Token: 0x06004DBC RID: 19900 RVA: 0x002DF9C8 File Offset: 0x002DDBC8
		// (set) Token: 0x06004DBD RID: 19901 RVA: 0x002DF9D2 File Offset: 0x002DDBD2
		internal virtual BindingSource GetBranchDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C96 RID: 7318
		// (get) Token: 0x06004DBE RID: 19902 RVA: 0x002DF9DB File Offset: 0x002DDBDB
		// (set) Token: 0x06004DBF RID: 19903 RVA: 0x002DF9E5 File Offset: 0x002DDBE5
		internal virtual BindingSource GetBankingDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C97 RID: 7319
		// (get) Token: 0x06004DC0 RID: 19904 RVA: 0x002DF9EE File Offset: 0x002DDBEE
		// (set) Token: 0x06004DC1 RID: 19905 RVA: 0x002DF9F8 File Offset: 0x002DDBF8
		internal virtual BindingSource BankingDetails2BindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C98 RID: 7320
		// (get) Token: 0x06004DC2 RID: 19906 RVA: 0x002DFA01 File Offset: 0x002DDC01
		// (set) Token: 0x06004DC3 RID: 19907 RVA: 0x002DFA0B File Offset: 0x002DDC0B
		internal virtual GetPaymentMethodsForInvoiceTableAdapter GetPaymentMethodsForInvoiceTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C99 RID: 7321
		// (get) Token: 0x06004DC4 RID: 19908 RVA: 0x002DFA14 File Offset: 0x002DDC14
		// (set) Token: 0x06004DC5 RID: 19909 RVA: 0x002DFA1E File Offset: 0x002DDC1E
		internal virtual GetUserForInvoiceTableAdapter GetUserForInvoiceTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C9A RID: 7322
		// (get) Token: 0x06004DC6 RID: 19910 RVA: 0x002DFA27 File Offset: 0x002DDC27
		// (set) Token: 0x06004DC7 RID: 19911 RVA: 0x002DFA31 File Offset: 0x002DDC31
		internal virtual FetchCustomerDetailsFromInvTableAdapter FetchCustomerDetailsFromInvTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C9B RID: 7323
		// (get) Token: 0x06004DC8 RID: 19912 RVA: 0x002DFA3A File Offset: 0x002DDC3A
		// (set) Token: 0x06004DC9 RID: 19913 RVA: 0x002DFA44 File Offset: 0x002DDC44
		internal virtual GetCompanyDetailsForCoidTableAdapter GetCompanyDetailsForCoidTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C9C RID: 7324
		// (get) Token: 0x06004DCA RID: 19914 RVA: 0x002DFA4D File Offset: 0x002DDC4D
		// (set) Token: 0x06004DCB RID: 19915 RVA: 0x002DFA57 File Offset: 0x002DDC57
		internal virtual SalesByInvoiceNumberBookingTableAdapter SalesByInvoiceNumberBookingTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C9D RID: 7325
		// (get) Token: 0x06004DCC RID: 19916 RVA: 0x002DFA60 File Offset: 0x002DDC60
		// (set) Token: 0x06004DCD RID: 19917 RVA: 0x002DFA6A File Offset: 0x002DDC6A
		internal virtual GetBranchDetailsTableAdapter GetBranchDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C9E RID: 7326
		// (get) Token: 0x06004DCE RID: 19918 RVA: 0x002DFA73 File Offset: 0x002DDC73
		// (set) Token: 0x06004DCF RID: 19919 RVA: 0x002DFA7D File Offset: 0x002DDC7D
		internal virtual GetBankingDetailsTableAdapter GetBankingDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C9F RID: 7327
		// (get) Token: 0x06004DD0 RID: 19920 RVA: 0x002DFA86 File Offset: 0x002DDC86
		// (set) Token: 0x06004DD1 RID: 19921 RVA: 0x002DFA90 File Offset: 0x002DDC90
		internal virtual BankingDetails2TableAdapter BankingDetails2TableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CA0 RID: 7328
		// (get) Token: 0x06004DD2 RID: 19922 RVA: 0x002DFA99 File Offset: 0x002DDC99
		// (set) Token: 0x06004DD3 RID: 19923 RVA: 0x002DFAA3 File Offset: 0x002DDCA3
		internal virtual BindingSource SalesByInvoiceNumberTotalsBookingBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001CA1 RID: 7329
		// (get) Token: 0x06004DD4 RID: 19924 RVA: 0x002DFAAC File Offset: 0x002DDCAC
		// (set) Token: 0x06004DD5 RID: 19925 RVA: 0x002DFAB6 File Offset: 0x002DDCB6
		internal virtual SalesByInvoiceNumberTotalsBookingTableAdapter SalesByInvoiceNumberTotalsBookingTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06004DD6 RID: 19926 RVA: 0x002DFAC0 File Offset: 0x002DDCC0
		private void SalesInvPortraitBooking_Load(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
				this.GetCompanyDetailsForCoidTableAdapter.Connection = sqlConnection;
				this.SalesByInvoiceNumberBookingTableAdapter.Connection = sqlConnection;
				this.GetPaymentMethodsForInvoiceTableAdapter.Connection = sqlConnection;
				this.GetUserForInvoiceTableAdapter.Connection = sqlConnection;
				this.FetchCustomerDetailsFromInvTableAdapter.Connection = sqlConnection;
				this.GetBranchDetailsTableAdapter.Connection = sqlConnection;
				this.GetBankingDetailsTableAdapter.Connection = sqlConnection;
				this.BankingDetails2TableAdapter.Connection = sqlConnection;
				this.SalesByInvoiceNumberTotalsBookingTableAdapter.Connection = sqlConnection;
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
				ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter2, reportParameter3, reportParameter4, reportParameter5, reportParameter6, reportParameter7 };
				this.ReportViewer1.LocalReport.SetParameters(array);
				this.GetCompanyDetailsForCoidTableAdapter.Fill(this.POSDataSet.GetCompanyDetailsForCoid, new int?(MyProject.Forms.Form1.coid));
				this.SalesByInvoiceNumberBookingTableAdapter.Fill(this.POSDataSet.SalesByInvoiceNumberBooking, new int?(this.invnum), new int?(MyProject.Forms.Form1.coid));
				this.GetPaymentMethodsForInvoiceTableAdapter.Fill(this.POSDataSet.GetPaymentMethodsForInvoice, new long?((long)this.invnum), new int?(MyProject.Forms.Form1.coid), MyProject.Forms.Form1.branch);
				this.GetUserForInvoiceTableAdapter.Fill(this.POSDataSet.GetUserForInvoice, new int?(this.invnum), new int?(MyProject.Forms.Form1.coid), MyProject.Forms.Form1.branch);
				this.FetchCustomerDetailsFromInvTableAdapter.Fill(this.POSDataSet.FetchCustomerDetailsFromInv, new int?(this.invnum), new int?(MyProject.Forms.Form1.coid), MyProject.Forms.Form1.branch);
				this.GetBranchDetailsTableAdapter.Fill(this.POSDataSet.GetBranchDetails, MyProject.Forms.Form1.branch, new int?(MyProject.Forms.Form1.coid));
				this.GetBankingDetailsTableAdapter.Fill(this.POSDataSet.GetBankingDetails, new int?(MyProject.Forms.Form1.coid));
				this.BankingDetails2TableAdapter.Fill(this.POSDataSet.BankingDetails2, new int?(MyProject.Forms.Form1.coid));
				this.SalesByInvoiceNumberTotalsBookingTableAdapter.Fill(this.POSDataSet.SalesByInvoiceNumberTotalsBooking, new int?(this.invnum), new int?(MyProject.Forms.Form1.coid));
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

		// Token: 0x06004DD7 RID: 19927 RVA: 0x002E0088 File Offset: 0x002DE288
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

		// Token: 0x06004DD8 RID: 19928 RVA: 0x002E0138 File Offset: 0x002DE338
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

		// Token: 0x04002297 RID: 8855
		public int invnum;

		// Token: 0x04002298 RID: 8856
		private string _cnn;

		// Token: 0x04002299 RID: 8857
		private PublicFunctions pf;

		// Token: 0x0400229A RID: 8858
		public string revmax_sign;

		// Token: 0x0400229B RID: 8859
		public int reprint;

		// Token: 0x0400229C RID: 8860
		public int isEltradeESDfiscal;
	}
}
