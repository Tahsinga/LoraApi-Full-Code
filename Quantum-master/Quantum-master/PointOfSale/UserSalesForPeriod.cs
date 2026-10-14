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
	// Token: 0x02000208 RID: 520
	[DesignerGenerated]
	public partial class UserSalesForPeriod : UserControl
	{
		// Token: 0x06005D9B RID: 23963 RVA: 0x0035B2C0 File Offset: 0x003594C0
		public UserSalesForPeriod()
		{
			base.Load += this.UserSalesForPeriod_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x170021C9 RID: 8649
		// (get) Token: 0x06005D9E RID: 23966 RVA: 0x0035C372 File Offset: 0x0035A572
		// (set) Token: 0x06005D9F RID: 23967 RVA: 0x0035C37C File Offset: 0x0035A57C
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021CA RID: 8650
		// (get) Token: 0x06005DA0 RID: 23968 RVA: 0x0035C385 File Offset: 0x0035A585
		// (set) Token: 0x06005DA1 RID: 23969 RVA: 0x0035C38F File Offset: 0x0035A58F
		internal virtual DateTimePicker DTEndDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021CB RID: 8651
		// (get) Token: 0x06005DA2 RID: 23970 RVA: 0x0035C398 File Offset: 0x0035A598
		// (set) Token: 0x06005DA3 RID: 23971 RVA: 0x0035C3A2 File Offset: 0x0035A5A2
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021CC RID: 8652
		// (get) Token: 0x06005DA4 RID: 23972 RVA: 0x0035C3AB File Offset: 0x0035A5AB
		// (set) Token: 0x06005DA5 RID: 23973 RVA: 0x0035C3B5 File Offset: 0x0035A5B5
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021CD RID: 8653
		// (get) Token: 0x06005DA6 RID: 23974 RVA: 0x0035C3BE File Offset: 0x0035A5BE
		// (set) Token: 0x06005DA7 RID: 23975 RVA: 0x0035C3C8 File Offset: 0x0035A5C8
		internal virtual ComboBox cboBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021CE RID: 8654
		// (get) Token: 0x06005DA8 RID: 23976 RVA: 0x0035C3D1 File Offset: 0x0035A5D1
		// (set) Token: 0x06005DA9 RID: 23977 RVA: 0x0035C3DB File Offset: 0x0035A5DB
		internal virtual ComboBox cboUsers
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021CF RID: 8655
		// (get) Token: 0x06005DAA RID: 23978 RVA: 0x0035C3E4 File Offset: 0x0035A5E4
		// (set) Token: 0x06005DAB RID: 23979 RVA: 0x0035C3EE File Offset: 0x0035A5EE
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021D0 RID: 8656
		// (get) Token: 0x06005DAC RID: 23980 RVA: 0x0035C3F7 File Offset: 0x0035A5F7
		// (set) Token: 0x06005DAD RID: 23981 RVA: 0x0035C401 File Offset: 0x0035A601
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021D1 RID: 8657
		// (get) Token: 0x06005DAE RID: 23982 RVA: 0x0035C40A File Offset: 0x0035A60A
		// (set) Token: 0x06005DAF RID: 23983 RVA: 0x0035C414 File Offset: 0x0035A614
		internal virtual Label Label2
		{
			[CompilerGenerated]
			get
			{
				return this._Label2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label2_Click);
				Label label = this._Label2;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label2 = value;
				label = this._Label2;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x170021D2 RID: 8658
		// (get) Token: 0x06005DB0 RID: 23984 RVA: 0x0035C457 File Offset: 0x0035A657
		// (set) Token: 0x06005DB1 RID: 23985 RVA: 0x0035C464 File Offset: 0x0035A664
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

		// Token: 0x170021D3 RID: 8659
		// (get) Token: 0x06005DB2 RID: 23986 RVA: 0x0035C4A7 File Offset: 0x0035A6A7
		// (set) Token: 0x06005DB3 RID: 23987 RVA: 0x0035C4B1 File Offset: 0x0035A6B1
		internal virtual DateTimePicker DTStartDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021D4 RID: 8660
		// (get) Token: 0x06005DB4 RID: 23988 RVA: 0x0035C4BA File Offset: 0x0035A6BA
		// (set) Token: 0x06005DB5 RID: 23989 RVA: 0x0035C4C4 File Offset: 0x0035A6C4
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021D5 RID: 8661
		// (get) Token: 0x06005DB6 RID: 23990 RVA: 0x0035C4CD File Offset: 0x0035A6CD
		// (set) Token: 0x06005DB7 RID: 23991 RVA: 0x0035C4D7 File Offset: 0x0035A6D7
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021D6 RID: 8662
		// (get) Token: 0x06005DB8 RID: 23992 RVA: 0x0035C4E0 File Offset: 0x0035A6E0
		// (set) Token: 0x06005DB9 RID: 23993 RVA: 0x0035C4EA File Offset: 0x0035A6EA
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021D7 RID: 8663
		// (get) Token: 0x06005DBA RID: 23994 RVA: 0x0035C4F3 File Offset: 0x0035A6F3
		// (set) Token: 0x06005DBB RID: 23995 RVA: 0x0035C4FD File Offset: 0x0035A6FD
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021D8 RID: 8664
		// (get) Token: 0x06005DBC RID: 23996 RVA: 0x0035C506 File Offset: 0x0035A706
		// (set) Token: 0x06005DBD RID: 23997 RVA: 0x0035C510 File Offset: 0x0035A710
		internal virtual BindingSource UserSalesCategorySummaryPERIOD2BindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021D9 RID: 8665
		// (get) Token: 0x06005DBE RID: 23998 RVA: 0x0035C519 File Offset: 0x0035A719
		// (set) Token: 0x06005DBF RID: 23999 RVA: 0x0035C523 File Offset: 0x0035A723
		internal virtual BindingSource USERSalesPaymentSummaryPeriodBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021DA RID: 8666
		// (get) Token: 0x06005DC0 RID: 24000 RVA: 0x0035C52C File Offset: 0x0035A72C
		// (set) Token: 0x06005DC1 RID: 24001 RVA: 0x0035C536 File Offset: 0x0035A736
		internal virtual BindingSource USERSalesDetailPeriodBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021DB RID: 8667
		// (get) Token: 0x06005DC2 RID: 24002 RVA: 0x0035C53F File Offset: 0x0035A73F
		// (set) Token: 0x06005DC3 RID: 24003 RVA: 0x0035C549 File Offset: 0x0035A749
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021DC RID: 8668
		// (get) Token: 0x06005DC4 RID: 24004 RVA: 0x0035C552 File Offset: 0x0035A752
		// (set) Token: 0x06005DC5 RID: 24005 RVA: 0x0035C55C File Offset: 0x0035A75C
		internal virtual UserSalesCategorySummaryPERIOD2TableAdapter UserSalesCategorySummaryPERIOD2TableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021DD RID: 8669
		// (get) Token: 0x06005DC6 RID: 24006 RVA: 0x0035C565 File Offset: 0x0035A765
		// (set) Token: 0x06005DC7 RID: 24007 RVA: 0x0035C56F File Offset: 0x0035A76F
		internal virtual USERSalesPaymentSummaryPeriodTableAdapter USERSalesPaymentSummaryPeriodTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021DE RID: 8670
		// (get) Token: 0x06005DC8 RID: 24008 RVA: 0x0035C578 File Offset: 0x0035A778
		// (set) Token: 0x06005DC9 RID: 24009 RVA: 0x0035C582 File Offset: 0x0035A782
		internal virtual USERSalesDetailPeriodTableAdapter USERSalesDetailPeriodTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021DF RID: 8671
		// (get) Token: 0x06005DCA RID: 24010 RVA: 0x0035C58B File Offset: 0x0035A78B
		// (set) Token: 0x06005DCB RID: 24011 RVA: 0x0035C595 File Offset: 0x0035A795
		internal virtual BindingSource ShiftSalesSummaryByUserPeriodBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021E0 RID: 8672
		// (get) Token: 0x06005DCC RID: 24012 RVA: 0x0035C59E File Offset: 0x0035A79E
		// (set) Token: 0x06005DCD RID: 24013 RVA: 0x0035C5A8 File Offset: 0x0035A7A8
		internal virtual ShiftSalesSummaryByUserPeriodTableAdapter ShiftSalesSummaryByUserPeriodTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021E1 RID: 8673
		// (get) Token: 0x06005DCE RID: 24014 RVA: 0x0035C5B1 File Offset: 0x0035A7B1
		// (set) Token: 0x06005DCF RID: 24015 RVA: 0x0035C5BB File Offset: 0x0035A7BB
		internal virtual BindingSource BillingSalesBreakdownForUserPeriodBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021E2 RID: 8674
		// (get) Token: 0x06005DD0 RID: 24016 RVA: 0x0035C5C4 File Offset: 0x0035A7C4
		// (set) Token: 0x06005DD1 RID: 24017 RVA: 0x0035C5CE File Offset: 0x0035A7CE
		internal virtual BindingSource BillingPaymentSummaryUserPeriodBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021E3 RID: 8675
		// (get) Token: 0x06005DD2 RID: 24018 RVA: 0x0035C5D7 File Offset: 0x0035A7D7
		// (set) Token: 0x06005DD3 RID: 24019 RVA: 0x0035C5E1 File Offset: 0x0035A7E1
		internal virtual BillingSalesBreakdownForUserPeriodTableAdapter BillingSalesBreakdownForUserPeriodTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021E4 RID: 8676
		// (get) Token: 0x06005DD4 RID: 24020 RVA: 0x0035C5EA File Offset: 0x0035A7EA
		// (set) Token: 0x06005DD5 RID: 24021 RVA: 0x0035C5F4 File Offset: 0x0035A7F4
		internal virtual BillingPaymentSummaryUserPeriodTableAdapter BillingPaymentSummaryUserPeriodTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021E5 RID: 8677
		// (get) Token: 0x06005DD6 RID: 24022 RVA: 0x0035C5FD File Offset: 0x0035A7FD
		// (set) Token: 0x06005DD7 RID: 24023 RVA: 0x0035C607 File Offset: 0x0035A807
		internal virtual BindingSource DiscountsForUserForPeriodBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021E6 RID: 8678
		// (get) Token: 0x06005DD8 RID: 24024 RVA: 0x0035C610 File Offset: 0x0035A810
		// (set) Token: 0x06005DD9 RID: 24025 RVA: 0x0035C61A File Offset: 0x0035A81A
		internal virtual BindingSource DiscountsForPeriodBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021E7 RID: 8679
		// (get) Token: 0x06005DDA RID: 24026 RVA: 0x0035C623 File Offset: 0x0035A823
		// (set) Token: 0x06005DDB RID: 24027 RVA: 0x0035C62D File Offset: 0x0035A82D
		internal virtual DiscountsForUserForPeriodTableAdapter DiscountsForUserForPeriodTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021E8 RID: 8680
		// (get) Token: 0x06005DDC RID: 24028 RVA: 0x0035C636 File Offset: 0x0035A836
		// (set) Token: 0x06005DDD RID: 24029 RVA: 0x0035C640 File Offset: 0x0035A840
		internal virtual DiscountsForPeriodTableAdapter DiscountsForPeriodTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021E9 RID: 8681
		// (get) Token: 0x06005DDE RID: 24030 RVA: 0x0035C649 File Offset: 0x0035A849
		// (set) Token: 0x06005DDF RID: 24031 RVA: 0x0035C653 File Offset: 0x0035A853
		internal virtual BindingSource SalesbyTaxPeriodBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021EA RID: 8682
		// (get) Token: 0x06005DE0 RID: 24032 RVA: 0x0035C65C File Offset: 0x0035A85C
		// (set) Token: 0x06005DE1 RID: 24033 RVA: 0x0035C666 File Offset: 0x0035A866
		internal virtual SalesbyTaxPeriodTableAdapter SalesbyTaxPeriodTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021EB RID: 8683
		// (get) Token: 0x06005DE2 RID: 24034 RVA: 0x0035C66F File Offset: 0x0035A86F
		// (set) Token: 0x06005DE3 RID: 24035 RVA: 0x0035C679 File Offset: 0x0035A879
		internal virtual CheckBox chkHideCats
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06005DE4 RID: 24036 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label2_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06005DE5 RID: 24037 RVA: 0x0035C684 File Offset: 0x0035A884
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

		// Token: 0x06005DE6 RID: 24038 RVA: 0x0035C748 File Offset: 0x0035A948
		private void LoadUsers(int coid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchUsers";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				this.cboUsers.DataSource = dataTable;
				this.cboUsers.DisplayMember = "Username";
				this.cboUsers.ValueMember = "Username";
			}
		}

		// Token: 0x06005DE7 RID: 24039 RVA: 0x0035C7E8 File Offset: 0x0035A9E8
		private void UserSalesForPeriod_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadUsers(MyProject.Forms.Form1.coid);
				this.LoadBranches();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading users. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005DE8 RID: 24040 RVA: 0x0035C84C File Offset: 0x0035AA4C
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.runreport();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error running report. Details: " + ex.Message);
			}
		}

		// Token: 0x06005DE9 RID: 24041 RVA: 0x0035C89C File Offset: 0x0035AA9C
		private void runreport()
		{
			SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
			this.GetCompanyDetailsTableAdapter.Connection = sqlConnection;
			this.USERSalesPaymentSummaryPeriodTableAdapter.Connection = sqlConnection;
			this.UserSalesCategorySummaryPERIOD2TableAdapter.Connection = sqlConnection;
			this.USERSalesDetailPeriodTableAdapter.Connection = sqlConnection;
			this.ShiftSalesSummaryByUserPeriodTableAdapter.Connection = sqlConnection;
			this.BillingPaymentSummaryUserPeriodTableAdapter.Connection = sqlConnection;
			this.BillingSalesBreakdownForUserPeriodTableAdapter.Connection = sqlConnection;
			this.DiscountsForPeriodTableAdapter.Connection = sqlConnection;
			this.DiscountsForUserForPeriodTableAdapter.Connection = sqlConnection;
			this.SalesbyTaxPeriodTableAdapter.Connection = sqlConnection;
			ReportParameter reportParameter = new ReportParameter("shiftdateStart", Conversions.ToString(Conversions.ToInteger(this.DTStartDate.Value.ToString("yyyyMMdd"))));
			ReportParameter reportParameter2 = new ReportParameter("shiftdateStartDesc", this.DTStartDate.Value.ToShortDateString());
			ReportParameter reportParameter3 = new ReportParameter("shiftdateEnd", Conversions.ToString(Conversions.ToInteger(this.DTEndDate.Value.ToString("yyyyMMdd"))));
			ReportParameter reportParameter4 = new ReportParameter("shiftdateEndDesc", this.DTEndDate.Value.ToShortDateString());
			ReportParameter reportParameter5 = new ReportParameter("coid", Conversions.ToString(MyProject.Forms.Form1.coid));
			ReportParameter reportParameter6 = new ReportParameter("branch", this.cboBranch.Text);
			ReportParameter reportParameter7 = new ReportParameter("theuser", this.cboUsers.Text);
			ReportParameter reportParameter8 = new ReportParameter("hidecats", Conversions.ToString(Conversions.ToInteger(Interaction.IIf(this.chkHideCats.Checked, 1, 0))));
			ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter3, reportParameter2, reportParameter4, reportParameter5, reportParameter6, reportParameter7, reportParameter8 };
			this.ReportViewer1.LocalReport.SetParameters(array);
			this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
			this.USERSalesPaymentSummaryPeriodTableAdapter.Fill(this.POSDataSet.USERSalesPaymentSummaryPeriod, new int?(Conversions.ToInteger(this.DTStartDate.Value.ToString("yyyyMMdd"))), new int?(Conversions.ToInteger(this.DTEndDate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text, this.cboUsers.Text);
			checked
			{
				this.USERSalesDetailPeriodTableAdapter.Fill(this.POSDataSet.USERSalesDetailPeriod, new int?((int)Math.Round(Conversion.Val(this.DTStartDate.Value.ToString("yyyyMMdd")))), new int?(Conversions.ToInteger(this.DTEndDate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text, this.cboUsers.Text);
				this.UserSalesCategorySummaryPERIOD2TableAdapter.Fill(this.POSDataSet.UserSalesCategorySummaryPERIOD2, new int?((int)Math.Round(Conversion.Val(this.DTStartDate.Value.ToString("yyyyMMdd")))), new int?(Conversions.ToInteger(this.DTEndDate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text, this.cboUsers.Text);
				this.ShiftSalesSummaryByUserPeriodTableAdapter.Fill(this.POSDataSet.ShiftSalesSummaryByUserPeriod, new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text, new int?((int)Math.Round(Conversion.Val(this.DTStartDate.Value.ToString("yyyyMMdd")))), new int?(Conversions.ToInteger(this.DTEndDate.Value.ToString("yyyyMMdd"))), new int?(0), null, null);
				this.BillingPaymentSummaryUserPeriodTableAdapter.Fill(this.POSDataSet.BillingPaymentSummaryUserPeriod, new int?(Convert.ToInt32(this.DTStartDate.Value.ToString("yyyyMMdd"))), new int?(Convert.ToInt32(this.DTEndDate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text, this.cboUsers.Text);
				this.BillingSalesBreakdownForUserPeriodTableAdapter.Fill(this.POSDataSet.BillingSalesBreakdownForUserPeriod, new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text, this.cboUsers.Text, new int?(Convert.ToInt32(this.DTStartDate.Value.ToString("yyyyMMdd"))), new int?(Convert.ToInt32(this.DTEndDate.Value.ToString("yyyyMMdd"))));
				this.DiscountsForUserForPeriodTableAdapter.Fill(this.POSDataSet.DiscountsForUserForPeriod, new int?(Convert.ToInt32(this.DTStartDate.Value.ToString("yyyyMMdd"))), new int?(Convert.ToInt32(this.DTEndDate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text, this.cboUsers.Text);
				this.DiscountsForPeriodTableAdapter.Fill(this.POSDataSet.DiscountsForPeriod, new int?(Convert.ToInt32(this.DTStartDate.Value.ToString("yyyyMMdd"))), new int?(Convert.ToInt32(this.DTEndDate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text);
				this.SalesbyTaxPeriodTableAdapter.Fill(this.POSDataSet.SalesbyTaxPeriod, new int?(MyProject.Forms.Form1.coid), new int?(Convert.ToInt32(this.DTStartDate.Value.ToString("yyyyMMdd"))), new int?(Convert.ToInt32(this.DTEndDate.Value.ToString("yyyyMMdd"))), this.cboBranch.Text, this.cboUsers.Text);
				this.ReportViewer1.RefreshReport();
			}
		}

		// Token: 0x04002913 RID: 10515
		private string _cnn;
	}
}
