using System;
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
	// Token: 0x0200019E RID: 414
	[DesignerGenerated]
	public partial class SalesForPeriod : UserControl
	{
		// Token: 0x060049D4 RID: 18900 RVA: 0x002C8ABC File Offset: 0x002C6CBC
		public SalesForPeriod()
		{
			base.Load += this.SalesForPeriod_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x17001AEE RID: 6894
		// (get) Token: 0x060049D7 RID: 18903 RVA: 0x002C9820 File Offset: 0x002C7A20
		// (set) Token: 0x060049D8 RID: 18904 RVA: 0x002C982A File Offset: 0x002C7A2A
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AEF RID: 6895
		// (get) Token: 0x060049D9 RID: 18905 RVA: 0x002C9833 File Offset: 0x002C7A33
		// (set) Token: 0x060049DA RID: 18906 RVA: 0x002C9840 File Offset: 0x002C7A40
		internal virtual Button Button1
		{
			[CompilerGenerated]
			get
			{
				return this._Button1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button1_Click);
				Button button = this._Button1;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button1 = value;
				button = this._Button1;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17001AF0 RID: 6896
		// (get) Token: 0x060049DB RID: 18907 RVA: 0x002C9883 File Offset: 0x002C7A83
		// (set) Token: 0x060049DC RID: 18908 RVA: 0x002C988D File Offset: 0x002C7A8D
		internal virtual DateTimePicker DTStartdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AF1 RID: 6897
		// (get) Token: 0x060049DD RID: 18909 RVA: 0x002C9896 File Offset: 0x002C7A96
		// (set) Token: 0x060049DE RID: 18910 RVA: 0x002C98A0 File Offset: 0x002C7AA0
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AF2 RID: 6898
		// (get) Token: 0x060049DF RID: 18911 RVA: 0x002C98A9 File Offset: 0x002C7AA9
		// (set) Token: 0x060049E0 RID: 18912 RVA: 0x002C98B3 File Offset: 0x002C7AB3
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AF3 RID: 6899
		// (get) Token: 0x060049E1 RID: 18913 RVA: 0x002C98BC File Offset: 0x002C7ABC
		// (set) Token: 0x060049E2 RID: 18914 RVA: 0x002C98C6 File Offset: 0x002C7AC6
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AF4 RID: 6900
		// (get) Token: 0x060049E3 RID: 18915 RVA: 0x002C98CF File Offset: 0x002C7ACF
		// (set) Token: 0x060049E4 RID: 18916 RVA: 0x002C98D9 File Offset: 0x002C7AD9
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AF5 RID: 6901
		// (get) Token: 0x060049E5 RID: 18917 RVA: 0x002C98E2 File Offset: 0x002C7AE2
		// (set) Token: 0x060049E6 RID: 18918 RVA: 0x002C98EC File Offset: 0x002C7AEC
		internal virtual BindingSource CostofSalesForPeriodBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AF6 RID: 6902
		// (get) Token: 0x060049E7 RID: 18919 RVA: 0x002C98F5 File Offset: 0x002C7AF5
		// (set) Token: 0x060049E8 RID: 18920 RVA: 0x002C98FF File Offset: 0x002C7AFF
		internal virtual BindingSource CostofAdjustmentsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AF7 RID: 6903
		// (get) Token: 0x060049E9 RID: 18921 RVA: 0x002C9908 File Offset: 0x002C7B08
		// (set) Token: 0x060049EA RID: 18922 RVA: 0x002C9912 File Offset: 0x002C7B12
		internal virtual BindingSource ExpensesForPeriodBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AF8 RID: 6904
		// (get) Token: 0x060049EB RID: 18923 RVA: 0x002C991B File Offset: 0x002C7B1B
		// (set) Token: 0x060049EC RID: 18924 RVA: 0x002C9925 File Offset: 0x002C7B25
		internal virtual BindingSource SalesForPeriodBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AF9 RID: 6905
		// (get) Token: 0x060049ED RID: 18925 RVA: 0x002C992E File Offset: 0x002C7B2E
		// (set) Token: 0x060049EE RID: 18926 RVA: 0x002C9938 File Offset: 0x002C7B38
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AFA RID: 6906
		// (get) Token: 0x060049EF RID: 18927 RVA: 0x002C9941 File Offset: 0x002C7B41
		// (set) Token: 0x060049F0 RID: 18928 RVA: 0x002C994B File Offset: 0x002C7B4B
		internal virtual CostofSalesForPeriodTableAdapter CostofSalesForPeriodTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AFB RID: 6907
		// (get) Token: 0x060049F1 RID: 18929 RVA: 0x002C9954 File Offset: 0x002C7B54
		// (set) Token: 0x060049F2 RID: 18930 RVA: 0x002C995E File Offset: 0x002C7B5E
		internal virtual CostofAdjustmentsTableAdapter CostofAdjustmentsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AFC RID: 6908
		// (get) Token: 0x060049F3 RID: 18931 RVA: 0x002C9967 File Offset: 0x002C7B67
		// (set) Token: 0x060049F4 RID: 18932 RVA: 0x002C9971 File Offset: 0x002C7B71
		internal virtual ExpensesForPeriodTableAdapter ExpensesForPeriodTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AFD RID: 6909
		// (get) Token: 0x060049F5 RID: 18933 RVA: 0x002C997A File Offset: 0x002C7B7A
		// (set) Token: 0x060049F6 RID: 18934 RVA: 0x002C9984 File Offset: 0x002C7B84
		internal virtual SalesForPeriodTableAdapter SalesForPeriodTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AFE RID: 6910
		// (get) Token: 0x060049F7 RID: 18935 RVA: 0x002C998D File Offset: 0x002C7B8D
		// (set) Token: 0x060049F8 RID: 18936 RVA: 0x002C9997 File Offset: 0x002C7B97
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AFF RID: 6911
		// (get) Token: 0x060049F9 RID: 18937 RVA: 0x002C99A0 File Offset: 0x002C7BA0
		// (set) Token: 0x060049FA RID: 18938 RVA: 0x002C99AA File Offset: 0x002C7BAA
		internal virtual DateTimePicker DTEnddate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B00 RID: 6912
		// (get) Token: 0x060049FB RID: 18939 RVA: 0x002C99B3 File Offset: 0x002C7BB3
		// (set) Token: 0x060049FC RID: 18940 RVA: 0x002C99C0 File Offset: 0x002C7BC0
		internal virtual Label Label3
		{
			[CompilerGenerated]
			get
			{
				return this._Label3;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label3_Click);
				Label label = this._Label3;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label3 = value;
				label = this._Label3;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x17001B01 RID: 6913
		// (get) Token: 0x060049FD RID: 18941 RVA: 0x002C9A03 File Offset: 0x002C7C03
		// (set) Token: 0x060049FE RID: 18942 RVA: 0x002C9A0D File Offset: 0x002C7C0D
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B02 RID: 6914
		// (get) Token: 0x060049FF RID: 18943 RVA: 0x002C9A16 File Offset: 0x002C7C16
		// (set) Token: 0x06004A00 RID: 18944 RVA: 0x002C9A20 File Offset: 0x002C7C20
		internal virtual BindingSource TaxReturnsForPeriodSummaryBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B03 RID: 6915
		// (get) Token: 0x06004A01 RID: 18945 RVA: 0x002C9A29 File Offset: 0x002C7C29
		// (set) Token: 0x06004A02 RID: 18946 RVA: 0x002C9A33 File Offset: 0x002C7C33
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B04 RID: 6916
		// (get) Token: 0x06004A03 RID: 18947 RVA: 0x002C9A3C File Offset: 0x002C7C3C
		// (set) Token: 0x06004A04 RID: 18948 RVA: 0x002C9A46 File Offset: 0x002C7C46
		internal virtual ComboBox cboBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B05 RID: 6917
		// (get) Token: 0x06004A05 RID: 18949 RVA: 0x002C9A4F File Offset: 0x002C7C4F
		// (set) Token: 0x06004A06 RID: 18950 RVA: 0x002C9A59 File Offset: 0x002C7C59
		internal virtual TaxReturnsForPeriodSummaryTableAdapter TaxReturnsForPeriodSummaryTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B06 RID: 6918
		// (get) Token: 0x06004A07 RID: 18951 RVA: 0x002C9A62 File Offset: 0x002C7C62
		// (set) Token: 0x06004A08 RID: 18952 RVA: 0x002C9A6C File Offset: 0x002C7C6C
		internal virtual BindingSource SalesPaymentSummaryPERIODBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B07 RID: 6919
		// (get) Token: 0x06004A09 RID: 18953 RVA: 0x002C9A75 File Offset: 0x002C7C75
		// (set) Token: 0x06004A0A RID: 18954 RVA: 0x002C9A7F File Offset: 0x002C7C7F
		internal virtual SalesPaymentSummaryPERIODTableAdapter SalesPaymentSummaryPERIODTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B08 RID: 6920
		// (get) Token: 0x06004A0B RID: 18955 RVA: 0x002C9A88 File Offset: 0x002C7C88
		// (set) Token: 0x06004A0C RID: 18956 RVA: 0x002C9A92 File Offset: 0x002C7C92
		internal virtual BindingSource BillingSalesBreakdownForPeriodBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B09 RID: 6921
		// (get) Token: 0x06004A0D RID: 18957 RVA: 0x002C9A9B File Offset: 0x002C7C9B
		// (set) Token: 0x06004A0E RID: 18958 RVA: 0x002C9AA5 File Offset: 0x002C7CA5
		internal virtual BindingSource BillingPaymentSummaryPeriodBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B0A RID: 6922
		// (get) Token: 0x06004A0F RID: 18959 RVA: 0x002C9AAE File Offset: 0x002C7CAE
		// (set) Token: 0x06004A10 RID: 18960 RVA: 0x002C9AB8 File Offset: 0x002C7CB8
		internal virtual BillingSalesBreakdownForPeriodTableAdapter BillingSalesBreakdownForPeriodTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B0B RID: 6923
		// (get) Token: 0x06004A11 RID: 18961 RVA: 0x002C9AC1 File Offset: 0x002C7CC1
		// (set) Token: 0x06004A12 RID: 18962 RVA: 0x002C9ACB File Offset: 0x002C7CCB
		internal virtual BillingPaymentSummaryPeriodTableAdapter BillingPaymentSummaryPeriodTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B0C RID: 6924
		// (get) Token: 0x06004A13 RID: 18963 RVA: 0x002C9AD4 File Offset: 0x002C7CD4
		// (set) Token: 0x06004A14 RID: 18964 RVA: 0x002C9ADE File Offset: 0x002C7CDE
		internal virtual BindingSource GetInvoiceDiscountsForPeriodBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B0D RID: 6925
		// (get) Token: 0x06004A15 RID: 18965 RVA: 0x002C9AE7 File Offset: 0x002C7CE7
		// (set) Token: 0x06004A16 RID: 18966 RVA: 0x002C9AF1 File Offset: 0x002C7CF1
		internal virtual GetInvoiceDiscountsForPeriodTableAdapter GetInvoiceDiscountsForPeriodTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06004A17 RID: 18967 RVA: 0x002C9AFC File Offset: 0x002C7CFC
		private void LoadBranches()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchBranches";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			this.cboBranch.DataSource = dataTable;
			this.cboBranch.ValueMember = "branch";
			this.cboBranch.DisplayMember = "branch";
			bool flag = MyProject.Forms.Form1.OpenImpReports == 0;
			if (flag)
			{
				int num = this.cboBranch.FindString(MyProject.Forms.Form1.branch);
				this.cboBranch.SelectedIndex = num;
				this.cboBranch.Enabled = false;
			}
		}

		// Token: 0x06004A18 RID: 18968 RVA: 0x002C9BEC File Offset: 0x002C7DEC
		private void Button1_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
					this.GetCompanyDetailsTableAdapter.Connection = sqlConnection;
					this.SalesForPeriodTableAdapter.Connection = sqlConnection;
					this.SalesPaymentSummaryPERIODTableAdapter.Connection = sqlConnection;
					this.ExpensesForPeriodTableAdapter.Connection = sqlConnection;
					this.CostofAdjustmentsTableAdapter.Connection = sqlConnection;
					this.CostofSalesForPeriodTableAdapter.Connection = sqlConnection;
					this.TaxReturnsForPeriodSummaryTableAdapter.Connection = sqlConnection;
					this.BillingPaymentSummaryPeriodTableAdapter.Connection = sqlConnection;
					this.BillingSalesBreakdownForPeriodTableAdapter.Connection = sqlConnection;
					this.GetInvoiceDiscountsForPeriodTableAdapter.Connection = sqlConnection;
					ReportParameter reportParameter = new ReportParameter("startdate", Conversions.ToString(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))));
					ReportParameter reportParameter2 = new ReportParameter("shiftdateStart", Conversions.ToString(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))));
					ReportParameter reportParameter3 = new ReportParameter("StartDateDesc", this.DTStartdate.Value.ToShortDateString());
					ReportParameter reportParameter4 = new ReportParameter("enddate", Conversions.ToString(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))));
					ReportParameter reportParameter5 = new ReportParameter("shiftdateEnd", Conversions.ToString(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))));
					ReportParameter reportParameter6 = new ReportParameter("EndDateDesc", this.DTEnddate.Value.ToShortDateString());
					ReportParameter reportParameter7 = new ReportParameter("coid", Conversions.ToString(MyProject.Forms.Form1.coid));
					ReportParameter reportParameter8 = new ReportParameter("branch", this.cboBranch.Text);
					ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter3, reportParameter4, reportParameter6, reportParameter7, reportParameter8, reportParameter2, reportParameter5 };
					this.ReportViewer1.LocalReport.SetParameters(array);
					this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
					this.SalesForPeriodTableAdapter.Fill(this.POSDataSet.SalesForPeriod, new int?(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text);
					this.SalesPaymentSummaryPERIODTableAdapter.Fill(this.POSDataSet.SalesPaymentSummaryPERIOD, new int?((int)Math.Round(Conversion.Val(this.DTStartdate.Value.ToString("yyyyMMdd")))), new int?((int)Math.Round(Conversion.Val(this.DTEnddate.Value.ToString("yyyyMMdd")))), new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text);
					this.ExpensesForPeriodTableAdapter.Fill(this.POSDataSet.ExpensesForPeriod, new int?(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text);
					this.CostofAdjustmentsTableAdapter.Fill(this.POSDataSet.CostofAdjustments, new int?(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text);
					this.CostofSalesForPeriodTableAdapter.Fill(this.POSDataSet.CostofSalesForPeriod, new int?(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text);
					this.TaxReturnsForPeriodSummaryTableAdapter.Fill(this.POSDataSet.TaxReturnsForPeriodSummary, new int?(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text);
					this.BillingSalesBreakdownForPeriodTableAdapter.Fill(this.POSDataSet.BillingSalesBreakdownForPeriod, new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text, new int?(Convert.ToInt32(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Convert.ToInt32(this.DTEnddate.Value.ToString("yyyyMMdd"))), new int?(0), null, null);
					this.BillingPaymentSummaryPeriodTableAdapter.Fill(this.POSDataSet.BillingPaymentSummaryPeriod, new int?(Convert.ToInt32(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Convert.ToInt32(this.DTEnddate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text, new int?(0), null, null);
					this.GetInvoiceDiscountsForPeriodTableAdapter.Fill(this.POSDataSet.GetInvoiceDiscountsForPeriod, new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text, new int?(Convert.ToInt32(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Convert.ToInt32(this.DTEnddate.Value.ToString("yyyyMMdd"))));
					this.ReportViewer1.RefreshReport();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error displaying report. Detail: " + ex.Message);
				}
			}
		}

		// Token: 0x06004A19 RID: 18969 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label3_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06004A1A RID: 18970 RVA: 0x002CA308 File Offset: 0x002C8508
		private void SalesForPeriod_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadBranches();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying page. Detail: " + ex.Message);
			}
		}

		// Token: 0x0400207C RID: 8316
		private string _cnn;
	}
}
