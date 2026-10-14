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
	// Token: 0x020001AF RID: 431
	[DesignerGenerated]
	public partial class SalesInvoicePortraitTongaat : Form
	{
		// Token: 0x06004D27 RID: 19751 RVA: 0x002DC4D8 File Offset: 0x002DA6D8
		public SalesInvoicePortraitTongaat()
		{
			base.Load += this.SalesInvoicePortraitTongaat_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.reprint = 0;
			this.isEltradeESDfiscal = 0;
			this.branch = "";
			this.showinvdisc = 0;
			this.InitializeComponent();
		}

		// Token: 0x17001C54 RID: 7252
		// (get) Token: 0x06004D2A RID: 19754 RVA: 0x002DCC6B File Offset: 0x002DAE6B
		// (set) Token: 0x06004D2B RID: 19755 RVA: 0x002DCC75 File Offset: 0x002DAE75
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C55 RID: 7253
		// (get) Token: 0x06004D2C RID: 19756 RVA: 0x002DCC7E File Offset: 0x002DAE7E
		// (set) Token: 0x06004D2D RID: 19757 RVA: 0x002DCC88 File Offset: 0x002DAE88
		internal virtual BindingSource GetPaymentMethodsForInvoiceBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C56 RID: 7254
		// (get) Token: 0x06004D2E RID: 19758 RVA: 0x002DCC91 File Offset: 0x002DAE91
		// (set) Token: 0x06004D2F RID: 19759 RVA: 0x002DCC9B File Offset: 0x002DAE9B
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C57 RID: 7255
		// (get) Token: 0x06004D30 RID: 19760 RVA: 0x002DCCA4 File Offset: 0x002DAEA4
		// (set) Token: 0x06004D31 RID: 19761 RVA: 0x002DCCAE File Offset: 0x002DAEAE
		internal virtual BindingSource GetUserForInvoiceBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C58 RID: 7256
		// (get) Token: 0x06004D32 RID: 19762 RVA: 0x002DCCB7 File Offset: 0x002DAEB7
		// (set) Token: 0x06004D33 RID: 19763 RVA: 0x002DCCC1 File Offset: 0x002DAEC1
		internal virtual BindingSource FetchCustomerDetailsFromInvBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C59 RID: 7257
		// (get) Token: 0x06004D34 RID: 19764 RVA: 0x002DCCCA File Offset: 0x002DAECA
		// (set) Token: 0x06004D35 RID: 19765 RVA: 0x002DCCD4 File Offset: 0x002DAED4
		internal virtual BindingSource SalesByInvoiceNumberBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C5A RID: 7258
		// (get) Token: 0x06004D36 RID: 19766 RVA: 0x002DCCDD File Offset: 0x002DAEDD
		// (set) Token: 0x06004D37 RID: 19767 RVA: 0x002DCCE7 File Offset: 0x002DAEE7
		internal virtual BindingSource GetBranchDetails1BindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C5B RID: 7259
		// (get) Token: 0x06004D38 RID: 19768 RVA: 0x002DCCF0 File Offset: 0x002DAEF0
		// (set) Token: 0x06004D39 RID: 19769 RVA: 0x002DCCFA File Offset: 0x002DAEFA
		internal virtual BindingSource GetBankingDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C5C RID: 7260
		// (get) Token: 0x06004D3A RID: 19770 RVA: 0x002DCD03 File Offset: 0x002DAF03
		// (set) Token: 0x06004D3B RID: 19771 RVA: 0x002DCD0D File Offset: 0x002DAF0D
		internal virtual BindingSource BankingDetails2BindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C5D RID: 7261
		// (get) Token: 0x06004D3C RID: 19772 RVA: 0x002DCD16 File Offset: 0x002DAF16
		// (set) Token: 0x06004D3D RID: 19773 RVA: 0x002DCD20 File Offset: 0x002DAF20
		internal virtual BindingSource SalesByInvoiceNumberTotalsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C5E RID: 7262
		// (get) Token: 0x06004D3E RID: 19774 RVA: 0x002DCD29 File Offset: 0x002DAF29
		// (set) Token: 0x06004D3F RID: 19775 RVA: 0x002DCD33 File Offset: 0x002DAF33
		internal virtual BindingSource GetCompanyDetailsForCoidBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C5F RID: 7263
		// (get) Token: 0x06004D40 RID: 19776 RVA: 0x002DCD3C File Offset: 0x002DAF3C
		// (set) Token: 0x06004D41 RID: 19777 RVA: 0x002DCD46 File Offset: 0x002DAF46
		internal virtual GetPaymentMethodsForInvoiceTableAdapter GetPaymentMethodsForInvoiceTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C60 RID: 7264
		// (get) Token: 0x06004D42 RID: 19778 RVA: 0x002DCD4F File Offset: 0x002DAF4F
		// (set) Token: 0x06004D43 RID: 19779 RVA: 0x002DCD59 File Offset: 0x002DAF59
		internal virtual GetUserForInvoiceTableAdapter GetUserForInvoiceTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C61 RID: 7265
		// (get) Token: 0x06004D44 RID: 19780 RVA: 0x002DCD62 File Offset: 0x002DAF62
		// (set) Token: 0x06004D45 RID: 19781 RVA: 0x002DCD6C File Offset: 0x002DAF6C
		internal virtual FetchCustomerDetailsFromInvTableAdapter FetchCustomerDetailsFromInvTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C62 RID: 7266
		// (get) Token: 0x06004D46 RID: 19782 RVA: 0x002DCD75 File Offset: 0x002DAF75
		// (set) Token: 0x06004D47 RID: 19783 RVA: 0x002DCD7F File Offset: 0x002DAF7F
		internal virtual SalesByInvoiceNumberTableAdapter SalesByInvoiceNumberTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C63 RID: 7267
		// (get) Token: 0x06004D48 RID: 19784 RVA: 0x002DCD88 File Offset: 0x002DAF88
		// (set) Token: 0x06004D49 RID: 19785 RVA: 0x002DCD92 File Offset: 0x002DAF92
		internal virtual GetBranchDetails1TableAdapter GetBranchDetails1TableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C64 RID: 7268
		// (get) Token: 0x06004D4A RID: 19786 RVA: 0x002DCD9B File Offset: 0x002DAF9B
		// (set) Token: 0x06004D4B RID: 19787 RVA: 0x002DCDA5 File Offset: 0x002DAFA5
		internal virtual GetBankingDetailsTableAdapter GetBankingDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C65 RID: 7269
		// (get) Token: 0x06004D4C RID: 19788 RVA: 0x002DCDAE File Offset: 0x002DAFAE
		// (set) Token: 0x06004D4D RID: 19789 RVA: 0x002DCDB8 File Offset: 0x002DAFB8
		internal virtual BankingDetails2TableAdapter BankingDetails2TableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C66 RID: 7270
		// (get) Token: 0x06004D4E RID: 19790 RVA: 0x002DCDC1 File Offset: 0x002DAFC1
		// (set) Token: 0x06004D4F RID: 19791 RVA: 0x002DCDCB File Offset: 0x002DAFCB
		internal virtual SalesByInvoiceNumberTotalsTableAdapter SalesByInvoiceNumberTotalsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001C67 RID: 7271
		// (get) Token: 0x06004D50 RID: 19792 RVA: 0x002DCDD4 File Offset: 0x002DAFD4
		// (set) Token: 0x06004D51 RID: 19793 RVA: 0x002DCDDE File Offset: 0x002DAFDE
		internal virtual GetCompanyDetailsForCoidTableAdapter GetCompanyDetailsForCoidTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06004D52 RID: 19794 RVA: 0x002DCDE8 File Offset: 0x002DAFE8
		private void SalesInvoicePortraitTongaat_Load(object sender, EventArgs e)
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

		// Token: 0x06004D53 RID: 19795 RVA: 0x002DD3E0 File Offset: 0x002DB5E0
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

		// Token: 0x06004D54 RID: 19796 RVA: 0x002DD490 File Offset: 0x002DB690
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

		// Token: 0x04002247 RID: 8775
		public int invnum;

		// Token: 0x04002248 RID: 8776
		private string _cnn;

		// Token: 0x04002249 RID: 8777
		private PublicFunctions pf;

		// Token: 0x0400224A RID: 8778
		public string revmax_sign;

		// Token: 0x0400224B RID: 8779
		public int reprint;

		// Token: 0x0400224C RID: 8780
		public int isEltradeESDfiscal;

		// Token: 0x0400224D RID: 8781
		public string branch;

		// Token: 0x0400224E RID: 8782
		public int showinvdisc;
	}
}
