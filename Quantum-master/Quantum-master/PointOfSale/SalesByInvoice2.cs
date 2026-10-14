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
	// Token: 0x02000196 RID: 406
	[DesignerGenerated]
	public partial class SalesByInvoice2 : UserControl
	{
		// Token: 0x0600480A RID: 18442 RVA: 0x002BE898 File Offset: 0x002BCA98
		public SalesByInvoice2()
		{
			base.Load += this.SalesByInvoice2_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x17001A29 RID: 6697
		// (get) Token: 0x0600480D RID: 18445 RVA: 0x002BF802 File Offset: 0x002BDA02
		// (set) Token: 0x0600480E RID: 18446 RVA: 0x002BF80C File Offset: 0x002BDA0C
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A2A RID: 6698
		// (get) Token: 0x0600480F RID: 18447 RVA: 0x002BF815 File Offset: 0x002BDA15
		// (set) Token: 0x06004810 RID: 18448 RVA: 0x002BF81F File Offset: 0x002BDA1F
		internal virtual DateTimePicker DTEnddate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A2B RID: 6699
		// (get) Token: 0x06004811 RID: 18449 RVA: 0x002BF828 File Offset: 0x002BDA28
		// (set) Token: 0x06004812 RID: 18450 RVA: 0x002BF832 File Offset: 0x002BDA32
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A2C RID: 6700
		// (get) Token: 0x06004813 RID: 18451 RVA: 0x002BF83B File Offset: 0x002BDA3B
		// (set) Token: 0x06004814 RID: 18452 RVA: 0x002BF845 File Offset: 0x002BDA45
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A2D RID: 6701
		// (get) Token: 0x06004815 RID: 18453 RVA: 0x002BF84E File Offset: 0x002BDA4E
		// (set) Token: 0x06004816 RID: 18454 RVA: 0x002BF858 File Offset: 0x002BDA58
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

		// Token: 0x17001A2E RID: 6702
		// (get) Token: 0x06004817 RID: 18455 RVA: 0x002BF89B File Offset: 0x002BDA9B
		// (set) Token: 0x06004818 RID: 18456 RVA: 0x002BF8A5 File Offset: 0x002BDAA5
		internal virtual DateTimePicker DTStartdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A2F RID: 6703
		// (get) Token: 0x06004819 RID: 18457 RVA: 0x002BF8AE File Offset: 0x002BDAAE
		// (set) Token: 0x0600481A RID: 18458 RVA: 0x002BF8B8 File Offset: 0x002BDAB8
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A30 RID: 6704
		// (get) Token: 0x0600481B RID: 18459 RVA: 0x002BF8C1 File Offset: 0x002BDAC1
		// (set) Token: 0x0600481C RID: 18460 RVA: 0x002BF8CC File Offset: 0x002BDACC
		internal virtual Label Label6
		{
			[CompilerGenerated]
			get
			{
				return this._Label6;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label6_Click);
				Label label = this._Label6;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label6 = value;
				label = this._Label6;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x17001A31 RID: 6705
		// (get) Token: 0x0600481D RID: 18461 RVA: 0x002BF90F File Offset: 0x002BDB0F
		// (set) Token: 0x0600481E RID: 18462 RVA: 0x002BF919 File Offset: 0x002BDB19
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A32 RID: 6706
		// (get) Token: 0x0600481F RID: 18463 RVA: 0x002BF922 File Offset: 0x002BDB22
		// (set) Token: 0x06004820 RID: 18464 RVA: 0x002BF92C File Offset: 0x002BDB2C
		internal virtual BindingSource ShiftSalesPaymentSummaryforPeriodBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A33 RID: 6707
		// (get) Token: 0x06004821 RID: 18465 RVA: 0x002BF935 File Offset: 0x002BDB35
		// (set) Token: 0x06004822 RID: 18466 RVA: 0x002BF93F File Offset: 0x002BDB3F
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A34 RID: 6708
		// (get) Token: 0x06004823 RID: 18467 RVA: 0x002BF948 File Offset: 0x002BDB48
		// (set) Token: 0x06004824 RID: 18468 RVA: 0x002BF952 File Offset: 0x002BDB52
		internal virtual BindingSource ShiftSalesForPERIODBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A35 RID: 6709
		// (get) Token: 0x06004825 RID: 18469 RVA: 0x002BF95B File Offset: 0x002BDB5B
		// (set) Token: 0x06004826 RID: 18470 RVA: 0x002BF965 File Offset: 0x002BDB65
		internal virtual BindingSource ShiftSalesSummaryByUserPeriodBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A36 RID: 6710
		// (get) Token: 0x06004827 RID: 18471 RVA: 0x002BF96E File Offset: 0x002BDB6E
		// (set) Token: 0x06004828 RID: 18472 RVA: 0x002BF978 File Offset: 0x002BDB78
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A37 RID: 6711
		// (get) Token: 0x06004829 RID: 18473 RVA: 0x002BF981 File Offset: 0x002BDB81
		// (set) Token: 0x0600482A RID: 18474 RVA: 0x002BF98B File Offset: 0x002BDB8B
		internal virtual BindingSource BillingSalesBreakdownForPeriodBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A38 RID: 6712
		// (get) Token: 0x0600482B RID: 18475 RVA: 0x002BF994 File Offset: 0x002BDB94
		// (set) Token: 0x0600482C RID: 18476 RVA: 0x002BF99E File Offset: 0x002BDB9E
		internal virtual BindingSource BillingPaymentSummaryPeriodBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A39 RID: 6713
		// (get) Token: 0x0600482D RID: 18477 RVA: 0x002BF9A7 File Offset: 0x002BDBA7
		// (set) Token: 0x0600482E RID: 18478 RVA: 0x002BF9B1 File Offset: 0x002BDBB1
		internal virtual ShiftSalesPaymentSummaryforPeriodTableAdapter ShiftSalesPaymentSummaryforPeriodTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A3A RID: 6714
		// (get) Token: 0x0600482F RID: 18479 RVA: 0x002BF9BA File Offset: 0x002BDBBA
		// (set) Token: 0x06004830 RID: 18480 RVA: 0x002BF9C4 File Offset: 0x002BDBC4
		internal virtual ShiftSalesForPERIODTableAdapter ShiftSalesForPERIODTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A3B RID: 6715
		// (get) Token: 0x06004831 RID: 18481 RVA: 0x002BF9CD File Offset: 0x002BDBCD
		// (set) Token: 0x06004832 RID: 18482 RVA: 0x002BF9D7 File Offset: 0x002BDBD7
		internal virtual ShiftSalesSummaryByUserPeriodTableAdapter ShiftSalesSummaryByUserPeriodTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A3C RID: 6716
		// (get) Token: 0x06004833 RID: 18483 RVA: 0x002BF9E0 File Offset: 0x002BDBE0
		// (set) Token: 0x06004834 RID: 18484 RVA: 0x002BF9EA File Offset: 0x002BDBEA
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A3D RID: 6717
		// (get) Token: 0x06004835 RID: 18485 RVA: 0x002BF9F3 File Offset: 0x002BDBF3
		// (set) Token: 0x06004836 RID: 18486 RVA: 0x002BF9FD File Offset: 0x002BDBFD
		internal virtual BillingSalesBreakdownForPeriodTableAdapter BillingSalesBreakdownForPeriodTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A3E RID: 6718
		// (get) Token: 0x06004837 RID: 18487 RVA: 0x002BFA06 File Offset: 0x002BDC06
		// (set) Token: 0x06004838 RID: 18488 RVA: 0x002BFA10 File Offset: 0x002BDC10
		internal virtual BillingPaymentSummaryPeriodTableAdapter BillingPaymentSummaryPeriodTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A3F RID: 6719
		// (get) Token: 0x06004839 RID: 18489 RVA: 0x002BFA19 File Offset: 0x002BDC19
		// (set) Token: 0x0600483A RID: 18490 RVA: 0x002BFA23 File Offset: 0x002BDC23
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A40 RID: 6720
		// (get) Token: 0x0600483B RID: 18491 RVA: 0x002BFA2C File Offset: 0x002BDC2C
		// (set) Token: 0x0600483C RID: 18492 RVA: 0x002BFA36 File Offset: 0x002BDC36
		internal virtual ComboBox cboBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A41 RID: 6721
		// (get) Token: 0x0600483D RID: 18493 RVA: 0x002BFA3F File Offset: 0x002BDC3F
		// (set) Token: 0x0600483E RID: 18494 RVA: 0x002BFA49 File Offset: 0x002BDC49
		internal virtual CheckBox chkReduce
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A42 RID: 6722
		// (get) Token: 0x0600483F RID: 18495 RVA: 0x002BFA52 File Offset: 0x002BDC52
		// (set) Token: 0x06004840 RID: 18496 RVA: 0x002BFA5C File Offset: 0x002BDC5C
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A43 RID: 6723
		// (get) Token: 0x06004841 RID: 18497 RVA: 0x002BFA65 File Offset: 0x002BDC65
		// (set) Token: 0x06004842 RID: 18498 RVA: 0x002BFA6F File Offset: 0x002BDC6F
		internal virtual DateTimePicker DTTimeEnd
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A44 RID: 6724
		// (get) Token: 0x06004843 RID: 18499 RVA: 0x002BFA78 File Offset: 0x002BDC78
		// (set) Token: 0x06004844 RID: 18500 RVA: 0x002BFA82 File Offset: 0x002BDC82
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A45 RID: 6725
		// (get) Token: 0x06004845 RID: 18501 RVA: 0x002BFA8B File Offset: 0x002BDC8B
		// (set) Token: 0x06004846 RID: 18502 RVA: 0x002BFA95 File Offset: 0x002BDC95
		internal virtual DateTimePicker DTTimeStart
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A46 RID: 6726
		// (get) Token: 0x06004847 RID: 18503 RVA: 0x002BFA9E File Offset: 0x002BDC9E
		// (set) Token: 0x06004848 RID: 18504 RVA: 0x002BFAA8 File Offset: 0x002BDCA8
		internal virtual CheckBox chkByTime
		{
			[CompilerGenerated]
			get
			{
				return this._chkByTime;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.chkByTime_CheckedChanged);
				CheckBox checkBox = this._chkByTime;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= eventHandler;
				}
				this._chkByTime = value;
				checkBox = this._chkByTime;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x06004849 RID: 18505 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label6_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x0600484A RID: 18506 RVA: 0x002BFAEC File Offset: 0x002BDCEC
		private void SalesByInvoice2_Load(object sender, EventArgs e)
		{
			try
			{
				this.DTTimeStart.Format = DateTimePickerFormat.Time;
				this.DTTimeStart.ShowUpDown = true;
				this.DTTimeEnd.Format = DateTimePickerFormat.Time;
				this.DTTimeEnd.ShowUpDown = true;
				this.DTStartdate.Format = DateTimePickerFormat.Short;
				this.DTEnddate.Format = DateTimePickerFormat.Short;
				this.LoadBranches();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600484B RID: 18507 RVA: 0x002BFB88 File Offset: 0x002BDD88
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
			this.cboBranch.SelectedIndex = this.cboBranch.FindStringExact(MyProject.Forms.Form1.branch);
		}

		// Token: 0x0600484C RID: 18508 RVA: 0x002BFC4C File Offset: 0x002BDE4C
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
				this.GetCompanyDetailsTableAdapter.Connection = sqlConnection;
				this.ShiftSalesPaymentSummaryforPeriodTableAdapter.Connection = sqlConnection;
				this.ShiftSalesForPERIODTableAdapter.Connection = sqlConnection;
				this.ShiftSalesSummaryByUserPeriodTableAdapter.Connection = sqlConnection;
				this.BillingPaymentSummaryPeriodTableAdapter.Connection = sqlConnection;
				this.BillingSalesBreakdownForPeriodTableAdapter.Connection = sqlConnection;
				int num = 3000;
				this.GetCompanyDetailsTableAdapter.Adapter.SelectCommand.CommandTimeout = num;
				this.ShiftSalesPaymentSummaryforPeriodTableAdapter.Adapter.SelectCommand.CommandTimeout = num;
				this.ShiftSalesForPERIODTableAdapter.Adapter.SelectCommand.CommandTimeout = num;
				this.ShiftSalesSummaryByUserPeriodTableAdapter.Adapter.SelectCommand.CommandTimeout = num;
				this.BillingPaymentSummaryPeriodTableAdapter.Adapter.SelectCommand.CommandTimeout = num;
				this.BillingSalesBreakdownForPeriodTableAdapter.Adapter.SelectCommand.CommandTimeout = num;
				ReportParameter reportParameter = new ReportParameter("shiftdatestart", Conversions.ToString(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))));
				ReportParameter reportParameter2 = new ReportParameter("shiftdateend", Conversions.ToString(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))));
				ReportParameter reportParameter3 = new ReportParameter("startdatedesc", this.DTStartdate.Value.ToShortDateString());
				ReportParameter reportParameter4 = new ReportParameter("enddatedesc", this.DTEnddate.Value.ToShortDateString());
				ReportParameter reportParameter5 = new ReportParameter("coid", Conversions.ToString(MyProject.Forms.Form1.coid));
				ReportParameter reportParameter6 = new ReportParameter("branch", this.cboBranch.Text);
				ReportParameter reportParameter7 = new ReportParameter("bytime", Conversions.ToString(Conversions.ToInteger(Interaction.IIf(this.chkByTime.Checked, 1, 0))));
				ReportParameter reportParameter8 = new ReportParameter("starttime", this.DTTimeStart.Value.ToString("HH:mm"));
				ReportParameter reportParameter9 = new ReportParameter("endtime", this.DTTimeEnd.Value.ToString("HH:mm"));
				ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter2, reportParameter3, reportParameter4, reportParameter5, reportParameter6, reportParameter7, reportParameter8, reportParameter9 };
				this.ReportViewer1.LocalReport.SetParameters(array);
				string text = new DateTime(this.DTStartdate.Value.Year, this.DTStartdate.Value.Month, this.DTStartdate.Value.Day, this.DTTimeStart.Value.Hour, this.DTTimeStart.Value.Minute, this.DTTimeStart.Value.Second).ToString("yyyy-MM-dd HH:mm:ss");
				string text2 = new DateTime(this.DTEnddate.Value.Year, this.DTEnddate.Value.Month, this.DTEnddate.Value.Day, this.DTTimeEnd.Value.Hour, this.DTTimeEnd.Value.Minute, this.DTTimeEnd.Value.Second).ToString("yyyy-MM-dd HH:mm:ss");
				this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
				this.ShiftSalesForPERIODTableAdapter.Fill(this.POSDataSet.ShiftSalesForPERIOD, new int?(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text, (int?)Interaction.IIf(this.chkReduce.Checked, 1, 0), (int?)Interaction.IIf(this.chkByTime.Checked, 1, 0), new DateTime?(Conversions.ToDate(text)), new DateTime?(Conversions.ToDate(text2)));
				this.ShiftSalesPaymentSummaryforPeriodTableAdapter.Fill(this.POSDataSet.ShiftSalesPaymentSummaryforPeriod, new int?(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text, (int?)Interaction.IIf(this.chkByTime.Checked, 1, 0), new DateTime?(Conversions.ToDate(text)), new DateTime?(Conversions.ToDate(text2)));
				this.ShiftSalesSummaryByUserPeriodTableAdapter.Fill(this.POSDataSet.ShiftSalesSummaryByUserPeriod, new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text, new int?(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))), (int?)Interaction.IIf(this.chkByTime.Checked, 1, 0), new DateTime?(Conversions.ToDate(text)), new DateTime?(Conversions.ToDate(text2)));
				this.BillingPaymentSummaryPeriodTableAdapter.Fill(this.POSDataSet.BillingPaymentSummaryPeriod, new int?(Convert.ToInt32(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Convert.ToInt32(this.DTEnddate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text, (int?)Interaction.IIf(this.chkByTime.Checked, 1, 0), new DateTime?(Conversions.ToDate(text)), new DateTime?(Conversions.ToDate(text2)));
				this.BillingSalesBreakdownForPeriodTableAdapter.Fill(this.POSDataSet.BillingSalesBreakdownForPeriod, new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text, new int?(Convert.ToInt32(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Convert.ToInt32(this.DTEnddate.Value.ToString("yyyyMMdd"))), (int?)Interaction.IIf(this.chkByTime.Checked, 1, 0), new DateTime?(Conversions.ToDate(text)), new DateTime?(Conversions.ToDate(text2)));
				this.ReportViewer1.RefreshReport();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying report. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600484D RID: 18509 RVA: 0x002C0414 File Offset: 0x002BE614
		private void chkByTime_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.chkByTime.Checked;
			if (@checked)
			{
				this.Label2.Visible = true;
				this.DTTimeStart.Visible = true;
				this.Label7.Visible = true;
				this.DTTimeEnd.Visible = true;
			}
			else
			{
				this.Label2.Visible = false;
				this.DTTimeStart.Visible = false;
				this.Label7.Visible = false;
				this.DTTimeEnd.Visible = false;
			}
		}

		// Token: 0x04001FA4 RID: 8100
		private string _cnn;

		// Token: 0x04001FA5 RID: 8101
		private PublicFunctions pf;
	}
}
