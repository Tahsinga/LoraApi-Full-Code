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
	// Token: 0x0200019F RID: 415
	[DesignerGenerated]
	public partial class SalesforPeriodbyShift : UserControl
	{
		// Token: 0x06004A1B RID: 18971 RVA: 0x002CA358 File Offset: 0x002C8558
		public SalesforPeriodbyShift()
		{
			base.Load += this.SalesforPeriodbyShift_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x17001B0E RID: 6926
		// (get) Token: 0x06004A1E RID: 18974 RVA: 0x002CB342 File Offset: 0x002C9542
		// (set) Token: 0x06004A1F RID: 18975 RVA: 0x002CB34C File Offset: 0x002C954C
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B0F RID: 6927
		// (get) Token: 0x06004A20 RID: 18976 RVA: 0x002CB355 File Offset: 0x002C9555
		// (set) Token: 0x06004A21 RID: 18977 RVA: 0x002CB35F File Offset: 0x002C955F
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B10 RID: 6928
		// (get) Token: 0x06004A22 RID: 18978 RVA: 0x002CB368 File Offset: 0x002C9568
		// (set) Token: 0x06004A23 RID: 18979 RVA: 0x002CB372 File Offset: 0x002C9572
		internal virtual DateTimePicker DTStartdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B11 RID: 6929
		// (get) Token: 0x06004A24 RID: 18980 RVA: 0x002CB37B File Offset: 0x002C957B
		// (set) Token: 0x06004A25 RID: 18981 RVA: 0x002CB388 File Offset: 0x002C9588
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

		// Token: 0x17001B12 RID: 6930
		// (get) Token: 0x06004A26 RID: 18982 RVA: 0x002CB3CB File Offset: 0x002C95CB
		// (set) Token: 0x06004A27 RID: 18983 RVA: 0x002CB3D8 File Offset: 0x002C95D8
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

		// Token: 0x17001B13 RID: 6931
		// (get) Token: 0x06004A28 RID: 18984 RVA: 0x002CB41B File Offset: 0x002C961B
		// (set) Token: 0x06004A29 RID: 18985 RVA: 0x002CB425 File Offset: 0x002C9625
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B14 RID: 6932
		// (get) Token: 0x06004A2A RID: 18986 RVA: 0x002CB42E File Offset: 0x002C962E
		// (set) Token: 0x06004A2B RID: 18987 RVA: 0x002CB438 File Offset: 0x002C9638
		internal virtual ComboBox cboBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B15 RID: 6933
		// (get) Token: 0x06004A2C RID: 18988 RVA: 0x002CB441 File Offset: 0x002C9641
		// (set) Token: 0x06004A2D RID: 18989 RVA: 0x002CB44B File Offset: 0x002C964B
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B16 RID: 6934
		// (get) Token: 0x06004A2E RID: 18990 RVA: 0x002CB454 File Offset: 0x002C9654
		// (set) Token: 0x06004A2F RID: 18991 RVA: 0x002CB45E File Offset: 0x002C965E
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B17 RID: 6935
		// (get) Token: 0x06004A30 RID: 18992 RVA: 0x002CB467 File Offset: 0x002C9667
		// (set) Token: 0x06004A31 RID: 18993 RVA: 0x002CB471 File Offset: 0x002C9671
		internal virtual DateTimePicker DTEnddate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B18 RID: 6936
		// (get) Token: 0x06004A32 RID: 18994 RVA: 0x002CB47A File Offset: 0x002C967A
		// (set) Token: 0x06004A33 RID: 18995 RVA: 0x002CB484 File Offset: 0x002C9684
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B19 RID: 6937
		// (get) Token: 0x06004A34 RID: 18996 RVA: 0x002CB48D File Offset: 0x002C968D
		// (set) Token: 0x06004A35 RID: 18997 RVA: 0x002CB497 File Offset: 0x002C9697
		internal virtual BindingSource ShiftSalesPaymentSummaryforPeriodBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B1A RID: 6938
		// (get) Token: 0x06004A36 RID: 18998 RVA: 0x002CB4A0 File Offset: 0x002C96A0
		// (set) Token: 0x06004A37 RID: 18999 RVA: 0x002CB4AA File Offset: 0x002C96AA
		internal virtual BindingSource ShiftSalesForPERIODBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B1B RID: 6939
		// (get) Token: 0x06004A38 RID: 19000 RVA: 0x002CB4B3 File Offset: 0x002C96B3
		// (set) Token: 0x06004A39 RID: 19001 RVA: 0x002CB4BD File Offset: 0x002C96BD
		internal virtual BindingSource ShiftSalesSummaryByUserPeriodBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B1C RID: 6940
		// (get) Token: 0x06004A3A RID: 19002 RVA: 0x002CB4C6 File Offset: 0x002C96C6
		// (set) Token: 0x06004A3B RID: 19003 RVA: 0x002CB4D0 File Offset: 0x002C96D0
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B1D RID: 6941
		// (get) Token: 0x06004A3C RID: 19004 RVA: 0x002CB4D9 File Offset: 0x002C96D9
		// (set) Token: 0x06004A3D RID: 19005 RVA: 0x002CB4E3 File Offset: 0x002C96E3
		internal virtual ShiftSalesPaymentSummaryforPeriodTableAdapter ShiftSalesPaymentSummaryforPeriodTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B1E RID: 6942
		// (get) Token: 0x06004A3E RID: 19006 RVA: 0x002CB4EC File Offset: 0x002C96EC
		// (set) Token: 0x06004A3F RID: 19007 RVA: 0x002CB4F6 File Offset: 0x002C96F6
		internal virtual ShiftSalesForPERIODTableAdapter ShiftSalesForPERIODTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B1F RID: 6943
		// (get) Token: 0x06004A40 RID: 19008 RVA: 0x002CB4FF File Offset: 0x002C96FF
		// (set) Token: 0x06004A41 RID: 19009 RVA: 0x002CB509 File Offset: 0x002C9709
		internal virtual ShiftSalesSummaryByUserPeriodTableAdapter ShiftSalesSummaryByUserPeriodTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B20 RID: 6944
		// (get) Token: 0x06004A42 RID: 19010 RVA: 0x002CB512 File Offset: 0x002C9712
		// (set) Token: 0x06004A43 RID: 19011 RVA: 0x002CB51C File Offset: 0x002C971C
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B21 RID: 6945
		// (get) Token: 0x06004A44 RID: 19012 RVA: 0x002CB525 File Offset: 0x002C9725
		// (set) Token: 0x06004A45 RID: 19013 RVA: 0x002CB52F File Offset: 0x002C972F
		internal virtual BindingSource BillingSalesBreakdownForPeriodBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B22 RID: 6946
		// (get) Token: 0x06004A46 RID: 19014 RVA: 0x002CB538 File Offset: 0x002C9738
		// (set) Token: 0x06004A47 RID: 19015 RVA: 0x002CB542 File Offset: 0x002C9742
		internal virtual BindingSource BillingPaymentSummaryPeriodBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B23 RID: 6947
		// (get) Token: 0x06004A48 RID: 19016 RVA: 0x002CB54B File Offset: 0x002C974B
		// (set) Token: 0x06004A49 RID: 19017 RVA: 0x002CB555 File Offset: 0x002C9755
		internal virtual BillingSalesBreakdownForPeriodTableAdapter BillingSalesBreakdownForPeriodTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B24 RID: 6948
		// (get) Token: 0x06004A4A RID: 19018 RVA: 0x002CB55E File Offset: 0x002C975E
		// (set) Token: 0x06004A4B RID: 19019 RVA: 0x002CB568 File Offset: 0x002C9768
		internal virtual BillingPaymentSummaryPeriodTableAdapter BillingPaymentSummaryPeriodTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B25 RID: 6949
		// (get) Token: 0x06004A4C RID: 19020 RVA: 0x002CB571 File Offset: 0x002C9771
		// (set) Token: 0x06004A4D RID: 19021 RVA: 0x002CB57B File Offset: 0x002C977B
		private virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B26 RID: 6950
		// (get) Token: 0x06004A4E RID: 19022 RVA: 0x002CB584 File Offset: 0x002C9784
		// (set) Token: 0x06004A4F RID: 19023 RVA: 0x002CB58E File Offset: 0x002C978E
		internal virtual BindingSource DiscountsForPeriodBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B27 RID: 6951
		// (get) Token: 0x06004A50 RID: 19024 RVA: 0x002CB597 File Offset: 0x002C9797
		// (set) Token: 0x06004A51 RID: 19025 RVA: 0x002CB5A1 File Offset: 0x002C97A1
		internal virtual DiscountsForPeriodTableAdapter DiscountsForPeriodTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B28 RID: 6952
		// (get) Token: 0x06004A52 RID: 19026 RVA: 0x002CB5AA File Offset: 0x002C97AA
		// (set) Token: 0x06004A53 RID: 19027 RVA: 0x002CB5B4 File Offset: 0x002C97B4
		internal virtual BindingSource SalesbyTaxPeriodAllUsersBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B29 RID: 6953
		// (get) Token: 0x06004A54 RID: 19028 RVA: 0x002CB5BD File Offset: 0x002C97BD
		// (set) Token: 0x06004A55 RID: 19029 RVA: 0x002CB5C7 File Offset: 0x002C97C7
		internal virtual SalesbyTaxPeriodAllUsersTableAdapter SalesbyTaxPeriodAllUsersTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B2A RID: 6954
		// (get) Token: 0x06004A56 RID: 19030 RVA: 0x002CB5D0 File Offset: 0x002C97D0
		// (set) Token: 0x06004A57 RID: 19031 RVA: 0x002CB5DA File Offset: 0x002C97DA
		internal virtual BindingSource GetProdCreditNoteChargesBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B2B RID: 6955
		// (get) Token: 0x06004A58 RID: 19032 RVA: 0x002CB5E3 File Offset: 0x002C97E3
		// (set) Token: 0x06004A59 RID: 19033 RVA: 0x002CB5ED File Offset: 0x002C97ED
		internal virtual GetProdCreditNoteChargesTableAdapter GetProdCreditNoteChargesTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B2C RID: 6956
		// (get) Token: 0x06004A5A RID: 19034 RVA: 0x002CB5F6 File Offset: 0x002C97F6
		// (set) Token: 0x06004A5B RID: 19035 RVA: 0x002CB600 File Offset: 0x002C9800
		internal virtual BindingSource CreditPaymentsForPeriodBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B2D RID: 6957
		// (get) Token: 0x06004A5C RID: 19036 RVA: 0x002CB609 File Offset: 0x002C9809
		// (set) Token: 0x06004A5D RID: 19037 RVA: 0x002CB613 File Offset: 0x002C9813
		internal virtual BindingSource PeriodAuditInfoBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B2E RID: 6958
		// (get) Token: 0x06004A5E RID: 19038 RVA: 0x002CB61C File Offset: 0x002C981C
		// (set) Token: 0x06004A5F RID: 19039 RVA: 0x002CB626 File Offset: 0x002C9826
		internal virtual CreditPaymentsForPeriodTableAdapter CreditPaymentsForPeriodTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B2F RID: 6959
		// (get) Token: 0x06004A60 RID: 19040 RVA: 0x002CB62F File Offset: 0x002C982F
		// (set) Token: 0x06004A61 RID: 19041 RVA: 0x002CB639 File Offset: 0x002C9839
		internal virtual PeriodAuditInfoTableAdapter PeriodAuditInfoTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B30 RID: 6960
		// (get) Token: 0x06004A62 RID: 19042 RVA: 0x002CB642 File Offset: 0x002C9842
		// (set) Token: 0x06004A63 RID: 19043 RVA: 0x002CB64C File Offset: 0x002C984C
		internal virtual CheckBox chkReduce
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06004A64 RID: 19044 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label2_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06004A65 RID: 19045 RVA: 0x002CB658 File Offset: 0x002C9858
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

		// Token: 0x06004A66 RID: 19046 RVA: 0x002CB71C File Offset: 0x002C991C
		private void SalesforPeriodbyShift_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadBranches();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06004A67 RID: 19047 RVA: 0x002CB76C File Offset: 0x002C996C
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
				this.DiscountsForPeriodTableAdapter.Connection = sqlConnection;
				this.SalesbyTaxPeriodAllUsersTableAdapter.Connection = sqlConnection;
				this.GetProdCreditNoteChargesTableAdapter.Connection = sqlConnection;
				this.PeriodAuditInfoTableAdapter.Connection = sqlConnection;
				this.CreditPaymentsForPeriodTableAdapter.Connection = sqlConnection;
				int num = 3000;
				ReportParameter reportParameter = new ReportParameter("shiftdatestart", Conversions.ToString(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))));
				ReportParameter reportParameter2 = new ReportParameter("shiftdateend", Conversions.ToString(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))));
				ReportParameter reportParameter3 = new ReportParameter("startdatedesc", this.DTStartdate.Value.ToShortDateString());
				ReportParameter reportParameter4 = new ReportParameter("enddatedesc", this.DTEnddate.Value.ToShortDateString());
				ReportParameter reportParameter5 = new ReportParameter("coid", Conversions.ToString(MyProject.Forms.Form1.coid));
				ReportParameter reportParameter6 = new ReportParameter("branch", this.cboBranch.Text);
				ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter2, reportParameter3, reportParameter4, reportParameter5, reportParameter6 };
				this.ReportViewer1.LocalReport.SetParameters(array);
				this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
				this.ShiftSalesForPERIODTableAdapter.Fill(this.POSDataSet.ShiftSalesForPERIOD, new int?(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text, (int?)Interaction.IIf(this.chkReduce.Checked, 1, 0), new int?(0), null, null);
				this.ShiftSalesPaymentSummaryforPeriodTableAdapter.Fill(this.POSDataSet.ShiftSalesPaymentSummaryforPeriod, new int?(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text, new int?(0), null, null);
				this.ShiftSalesSummaryByUserPeriodTableAdapter.Fill(this.POSDataSet.ShiftSalesSummaryByUserPeriod, new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text, new int?(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))), new int?(0), null, null);
				this.BillingPaymentSummaryPeriodTableAdapter.Fill(this.POSDataSet.BillingPaymentSummaryPeriod, new int?(Convert.ToInt32(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Convert.ToInt32(this.DTEnddate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text, new int?(0), null, null);
				this.BillingSalesBreakdownForPeriodTableAdapter.Fill(this.POSDataSet.BillingSalesBreakdownForPeriod, new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text, new int?(Convert.ToInt32(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Convert.ToInt32(this.DTEnddate.Value.ToString("yyyyMMdd"))), new int?(0), null, null);
				this.DiscountsForPeriodTableAdapter.Fill(this.POSDataSet.DiscountsForPeriod, new int?(Convert.ToInt32(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Convert.ToInt32(this.DTEnddate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text);
				this.SalesbyTaxPeriodAllUsersTableAdapter.Fill(this.POSDataSet.SalesbyTaxPeriodAllUsers, new int?(MyProject.Forms.Form1.coid), new int?(Convert.ToInt32(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Convert.ToInt32(this.DTEnddate.Value.ToString("yyyyMMdd"))), this.cboBranch.Text);
				string text = null;
				this.GetProdCreditNoteChargesTableAdapter.Fill(this.POSDataSet.GetProdCreditNoteCharges, new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text, new int?(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))), text);
				this.PeriodAuditInfoTableAdapter.Fill(this.POSDataSet.PeriodAuditInfo, new int?(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text);
				this.CreditPaymentsForPeriodTableAdapter.Fill(this.POSDataSet.CreditPaymentsForPeriod, new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text, new int?(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))));
				this.GetCompanyDetailsTableAdapter.Adapter.SelectCommand.CommandTimeout = num;
				this.ShiftSalesPaymentSummaryforPeriodTableAdapter.Adapter.SelectCommand.CommandTimeout = num;
				this.ShiftSalesForPERIODTableAdapter.Adapter.SelectCommand.CommandTimeout = num;
				this.ShiftSalesSummaryByUserPeriodTableAdapter.Adapter.SelectCommand.CommandTimeout = num;
				this.BillingPaymentSummaryPeriodTableAdapter.Adapter.SelectCommand.CommandTimeout = num;
				this.BillingSalesBreakdownForPeriodTableAdapter.Adapter.SelectCommand.CommandTimeout = num;
				this.DiscountsForPeriodTableAdapter.Adapter.SelectCommand.CommandTimeout = num;
				this.SalesbyTaxPeriodAllUsersTableAdapter.Adapter.SelectCommand.CommandTimeout = num;
				this.GetProdCreditNoteChargesTableAdapter.Adapter.SelectCommand.CommandTimeout = num;
				this.PeriodAuditInfoTableAdapter.Adapter.SelectCommand.CommandTimeout = num;
				this.CreditPaymentsForPeriodTableAdapter.Adapter.SelectCommand.CommandTimeout = num;
				this.ReportViewer1.RefreshReport();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying report. Detail: " + ex.Message);
			}
		}

		// Token: 0x040020A1 RID: 8353
		private string _cnn;
	}
}
