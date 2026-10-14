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
	// Token: 0x02000175 RID: 373
	[DesignerGenerated]
	public partial class ProductsCreditedReport : Form
	{
		// Token: 0x060035C6 RID: 13766 RVA: 0x001D0F0C File Offset: 0x001CF10C
		public ProductsCreditedReport()
		{
			base.Load += this.ProductsCreditedReport_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.reprint = 0;
			this.isEltradeESDfiscal = 0;
			this.donotlinkinv = 0;
			this.oginvnum = 0;
			this.InitializeComponent();
		}

		// Token: 0x170013FC RID: 5116
		// (get) Token: 0x060035C9 RID: 13769 RVA: 0x001D16C0 File Offset: 0x001CF8C0
		// (set) Token: 0x060035CA RID: 13770 RVA: 0x001D16CA File Offset: 0x001CF8CA
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013FD RID: 5117
		// (get) Token: 0x060035CB RID: 13771 RVA: 0x001D16D3 File Offset: 0x001CF8D3
		// (set) Token: 0x060035CC RID: 13772 RVA: 0x001D16DD File Offset: 0x001CF8DD
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013FE RID: 5118
		// (get) Token: 0x060035CD RID: 13773 RVA: 0x001D16E6 File Offset: 0x001CF8E6
		// (set) Token: 0x060035CE RID: 13774 RVA: 0x001D16F0 File Offset: 0x001CF8F0
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013FF RID: 5119
		// (get) Token: 0x060035CF RID: 13775 RVA: 0x001D16F9 File Offset: 0x001CF8F9
		// (set) Token: 0x060035D0 RID: 13776 RVA: 0x001D1703 File Offset: 0x001CF903
		internal virtual BindingSource ProductCreditNotePayMethodsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001400 RID: 5120
		// (get) Token: 0x060035D1 RID: 13777 RVA: 0x001D170C File Offset: 0x001CF90C
		// (set) Token: 0x060035D2 RID: 13778 RVA: 0x001D1716 File Offset: 0x001CF916
		internal virtual BindingSource ProductCreditNoteUserBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001401 RID: 5121
		// (get) Token: 0x060035D3 RID: 13779 RVA: 0x001D171F File Offset: 0x001CF91F
		// (set) Token: 0x060035D4 RID: 13780 RVA: 0x001D1729 File Offset: 0x001CF929
		internal virtual BindingSource ProductCreditNoteCustomerDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001402 RID: 5122
		// (get) Token: 0x060035D5 RID: 13781 RVA: 0x001D1732 File Offset: 0x001CF932
		// (set) Token: 0x060035D6 RID: 13782 RVA: 0x001D173C File Offset: 0x001CF93C
		internal virtual BindingSource ProductCreditNoteSelectBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001403 RID: 5123
		// (get) Token: 0x060035D7 RID: 13783 RVA: 0x001D1745 File Offset: 0x001CF945
		// (set) Token: 0x060035D8 RID: 13784 RVA: 0x001D174F File Offset: 0x001CF94F
		internal virtual BindingSource GetBranchDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001404 RID: 5124
		// (get) Token: 0x060035D9 RID: 13785 RVA: 0x001D1758 File Offset: 0x001CF958
		// (set) Token: 0x060035DA RID: 13786 RVA: 0x001D1762 File Offset: 0x001CF962
		internal virtual BindingSource GetBankingDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001405 RID: 5125
		// (get) Token: 0x060035DB RID: 13787 RVA: 0x001D176B File Offset: 0x001CF96B
		// (set) Token: 0x060035DC RID: 13788 RVA: 0x001D1775 File Offset: 0x001CF975
		internal virtual BindingSource BankingDetails2BindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001406 RID: 5126
		// (get) Token: 0x060035DD RID: 13789 RVA: 0x001D177E File Offset: 0x001CF97E
		// (set) Token: 0x060035DE RID: 13790 RVA: 0x001D1788 File Offset: 0x001CF988
		internal virtual BindingSource ProductCreditNoteInvTotalsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001407 RID: 5127
		// (get) Token: 0x060035DF RID: 13791 RVA: 0x001D1791 File Offset: 0x001CF991
		// (set) Token: 0x060035E0 RID: 13792 RVA: 0x001D179B File Offset: 0x001CF99B
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001408 RID: 5128
		// (get) Token: 0x060035E1 RID: 13793 RVA: 0x001D17A4 File Offset: 0x001CF9A4
		// (set) Token: 0x060035E2 RID: 13794 RVA: 0x001D17AE File Offset: 0x001CF9AE
		internal virtual ProductCreditNotePayMethodsTableAdapter ProductCreditNotePayMethodsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001409 RID: 5129
		// (get) Token: 0x060035E3 RID: 13795 RVA: 0x001D17B7 File Offset: 0x001CF9B7
		// (set) Token: 0x060035E4 RID: 13796 RVA: 0x001D17C1 File Offset: 0x001CF9C1
		internal virtual ProductCreditNoteUserTableAdapter ProductCreditNoteUserTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700140A RID: 5130
		// (get) Token: 0x060035E5 RID: 13797 RVA: 0x001D17CA File Offset: 0x001CF9CA
		// (set) Token: 0x060035E6 RID: 13798 RVA: 0x001D17D4 File Offset: 0x001CF9D4
		internal virtual ProductCreditNoteCustomerDetailsTableAdapter ProductCreditNoteCustomerDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700140B RID: 5131
		// (get) Token: 0x060035E7 RID: 13799 RVA: 0x001D17DD File Offset: 0x001CF9DD
		// (set) Token: 0x060035E8 RID: 13800 RVA: 0x001D17E7 File Offset: 0x001CF9E7
		internal virtual ProductCreditNoteSelectTableAdapter ProductCreditNoteSelectTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700140C RID: 5132
		// (get) Token: 0x060035E9 RID: 13801 RVA: 0x001D17F0 File Offset: 0x001CF9F0
		// (set) Token: 0x060035EA RID: 13802 RVA: 0x001D17FA File Offset: 0x001CF9FA
		internal virtual GetBranchDetailsTableAdapter GetBranchDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700140D RID: 5133
		// (get) Token: 0x060035EB RID: 13803 RVA: 0x001D1803 File Offset: 0x001CFA03
		// (set) Token: 0x060035EC RID: 13804 RVA: 0x001D180D File Offset: 0x001CFA0D
		internal virtual GetBankingDetailsTableAdapter GetBankingDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700140E RID: 5134
		// (get) Token: 0x060035ED RID: 13805 RVA: 0x001D1816 File Offset: 0x001CFA16
		// (set) Token: 0x060035EE RID: 13806 RVA: 0x001D1820 File Offset: 0x001CFA20
		internal virtual BankingDetails2TableAdapter BankingDetails2TableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700140F RID: 5135
		// (get) Token: 0x060035EF RID: 13807 RVA: 0x001D1829 File Offset: 0x001CFA29
		// (set) Token: 0x060035F0 RID: 13808 RVA: 0x001D1833 File Offset: 0x001CFA33
		internal virtual ProductCreditNoteInvTotalsTableAdapter ProductCreditNoteInvTotalsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060035F1 RID: 13809 RVA: 0x001D183C File Offset: 0x001CFA3C
		private void ProductsCreditedReport_Load(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
				this.GetCompanyDetailsTableAdapter.Connection = sqlConnection;
				this.ProductCreditNoteSelectTableAdapter.Connection = sqlConnection;
				this.ProductCreditNotePayMethodsTableAdapter.Connection = sqlConnection;
				this.ProductCreditNoteUserTableAdapter.Connection = sqlConnection;
				this.ProductCreditNoteCustomerDetailsTableAdapter.Connection = sqlConnection;
				this.GetBranchDetailsTableAdapter.Connection = sqlConnection;
				this.GetBankingDetailsTableAdapter.Connection = sqlConnection;
				this.BankingDetails2TableAdapter.Connection = sqlConnection;
				this.ProductCreditNoteInvTotalsTableAdapter.Connection = sqlConnection;
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
				ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter2, reportParameter3, reportParameter4, reportParameter5, reportParameter6 };
				this.ReportViewer1.LocalReport.SetParameters(array);
				this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
				this.ProductCreditNoteSelectTableAdapter.Fill(this.POSDataSet.ProductCreditNoteSelect, new int?(this.invnum), new int?(MyProject.Forms.Form1.coid), new int?(this.donotlinkinv), new int?(this.oginvnum));
				this.ProductCreditNotePayMethodsTableAdapter.Fill(this.POSDataSet.ProductCreditNotePayMethods, new long?((long)this.invnum), new int?(MyProject.Forms.Form1.coid), MyProject.Forms.Form1.branch);
				this.ProductCreditNoteUserTableAdapter.Fill(this.POSDataSet.ProductCreditNoteUser, new int?(this.invnum), new int?(MyProject.Forms.Form1.coid));
				this.ProductCreditNoteCustomerDetailsTableAdapter.Fill(this.POSDataSet.ProductCreditNoteCustomerDetails, new int?(this.invnum), new int?(MyProject.Forms.Form1.coid), MyProject.Forms.Form1.branch);
				this.GetBranchDetailsTableAdapter.Fill(this.POSDataSet.GetBranchDetails, MyProject.Forms.Form1.branch, new int?(MyProject.Forms.Form1.coid));
				this.GetBankingDetailsTableAdapter.Fill(this.POSDataSet.GetBankingDetails, new int?(MyProject.Forms.Form1.coid));
				this.BankingDetails2TableAdapter.Fill(this.POSDataSet.BankingDetails2, new int?(MyProject.Forms.Form1.coid));
				this.ProductCreditNoteInvTotalsTableAdapter.Fill(this.POSDataSet.ProductCreditNoteInvTotals, new int?(this.invnum), new int?(MyProject.Forms.Form1.coid));
				this.ReportViewer1.RefreshReport();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading report. Detail: " + ex.Message);
			}
		}

		// Token: 0x060035F2 RID: 13810 RVA: 0x001D1D60 File Offset: 0x001CFF60
		private int GetInvPayDisplayDetails()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "ProductCreditNoteSelect";
			sqlCommand.Parameters.AddWithValue("invoicenum", this.invnum);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("oginvnum", this.oginvnum);
			sqlCommand.Parameters.AddWithValue("donotlinkinv", this.donotlinkinv);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			DataRow dataRow = dataTable.Rows[0];
			return Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["ReceiptDisplayPaymentMethod"])), 0, RuntimeHelpers.GetObjectValue(dataRow["ReceiptDisplayPaymentMethod"])));
		}

		// Token: 0x060035F3 RID: 13811 RVA: 0x001D1E70 File Offset: 0x001D0070
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
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			string text;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				text = Conversions.ToString(dataRow["Currency"]);
			}
			else
			{
				text = " ";
			}
			return text;
		}

		// Token: 0x04001718 RID: 5912
		public int invnum;

		// Token: 0x04001719 RID: 5913
		private string _cnn;

		// Token: 0x0400171A RID: 5914
		private PublicFunctions pf;

		// Token: 0x0400171B RID: 5915
		public string revmax_sign;

		// Token: 0x0400171C RID: 5916
		public int reprint;

		// Token: 0x0400171D RID: 5917
		public int isEltradeESDfiscal;

		// Token: 0x0400171E RID: 5918
		public int donotlinkinv;

		// Token: 0x0400171F RID: 5919
		public int oginvnum;
	}
}
