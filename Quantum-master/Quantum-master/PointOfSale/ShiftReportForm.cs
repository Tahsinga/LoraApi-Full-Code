using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;
using PointOfSale.POSDataSetTableAdapters;

namespace PointOfSale
{
	// Token: 0x020001DF RID: 479
	[DesignerGenerated]
	public partial class ShiftReportForm : Form
	{
		// Token: 0x06005401 RID: 21505 RVA: 0x0030B75C File Offset: 0x0030995C
		public ShiftReportForm()
		{
			base.Load += this.ShiftReportForm_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x17001E1B RID: 7707
		// (get) Token: 0x06005404 RID: 21508 RVA: 0x0030C576 File Offset: 0x0030A776
		// (set) Token: 0x06005405 RID: 21509 RVA: 0x0030C580 File Offset: 0x0030A780
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E1C RID: 7708
		// (get) Token: 0x06005406 RID: 21510 RVA: 0x0030C589 File Offset: 0x0030A789
		// (set) Token: 0x06005407 RID: 21511 RVA: 0x0030C593 File Offset: 0x0030A793
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E1D RID: 7709
		// (get) Token: 0x06005408 RID: 21512 RVA: 0x0030C59C File Offset: 0x0030A79C
		// (set) Token: 0x06005409 RID: 21513 RVA: 0x0030C5A6 File Offset: 0x0030A7A6
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E1E RID: 7710
		// (get) Token: 0x0600540A RID: 21514 RVA: 0x0030C5AF File Offset: 0x0030A7AF
		// (set) Token: 0x0600540B RID: 21515 RVA: 0x0030C5B9 File Offset: 0x0030A7B9
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E1F RID: 7711
		// (get) Token: 0x0600540C RID: 21516 RVA: 0x0030C5C2 File Offset: 0x0030A7C2
		// (set) Token: 0x0600540D RID: 21517 RVA: 0x0030C5CC File Offset: 0x0030A7CC
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

		// Token: 0x17001E20 RID: 7712
		// (get) Token: 0x0600540E RID: 21518 RVA: 0x0030C60F File Offset: 0x0030A80F
		// (set) Token: 0x0600540F RID: 21519 RVA: 0x0030C619 File Offset: 0x0030A819
		internal virtual DateTimePicker DTStartDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E21 RID: 7713
		// (get) Token: 0x06005410 RID: 21520 RVA: 0x0030C622 File Offset: 0x0030A822
		// (set) Token: 0x06005411 RID: 21521 RVA: 0x0030C62C File Offset: 0x0030A82C
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E22 RID: 7714
		// (get) Token: 0x06005412 RID: 21522 RVA: 0x0030C635 File Offset: 0x0030A835
		// (set) Token: 0x06005413 RID: 21523 RVA: 0x0030C63F File Offset: 0x0030A83F
		internal virtual Label lblbranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E23 RID: 7715
		// (get) Token: 0x06005414 RID: 21524 RVA: 0x0030C648 File Offset: 0x0030A848
		// (set) Token: 0x06005415 RID: 21525 RVA: 0x0030C652 File Offset: 0x0030A852
		internal virtual Label lbluser
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E24 RID: 7716
		// (get) Token: 0x06005416 RID: 21526 RVA: 0x0030C65B File Offset: 0x0030A85B
		// (set) Token: 0x06005417 RID: 21527 RVA: 0x0030C665 File Offset: 0x0030A865
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E25 RID: 7717
		// (get) Token: 0x06005418 RID: 21528 RVA: 0x0030C66E File Offset: 0x0030A86E
		// (set) Token: 0x06005419 RID: 21529 RVA: 0x0030C678 File Offset: 0x0030A878
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E26 RID: 7718
		// (get) Token: 0x0600541A RID: 21530 RVA: 0x0030C681 File Offset: 0x0030A881
		// (set) Token: 0x0600541B RID: 21531 RVA: 0x0030C68B File Offset: 0x0030A88B
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E27 RID: 7719
		// (get) Token: 0x0600541C RID: 21532 RVA: 0x0030C694 File Offset: 0x0030A894
		// (set) Token: 0x0600541D RID: 21533 RVA: 0x0030C69E File Offset: 0x0030A89E
		internal virtual BindingSource USERSalesDayDetailBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E28 RID: 7720
		// (get) Token: 0x0600541E RID: 21534 RVA: 0x0030C6A7 File Offset: 0x0030A8A7
		// (set) Token: 0x0600541F RID: 21535 RVA: 0x0030C6B1 File Offset: 0x0030A8B1
		internal virtual BindingSource USERSalesPaymentSummaryBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E29 RID: 7721
		// (get) Token: 0x06005420 RID: 21536 RVA: 0x0030C6BA File Offset: 0x0030A8BA
		// (set) Token: 0x06005421 RID: 21537 RVA: 0x0030C6C4 File Offset: 0x0030A8C4
		internal virtual BindingSource UserSalesCategorySummaryPERIODBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E2A RID: 7722
		// (get) Token: 0x06005422 RID: 21538 RVA: 0x0030C6CD File Offset: 0x0030A8CD
		// (set) Token: 0x06005423 RID: 21539 RVA: 0x0030C6D7 File Offset: 0x0030A8D7
		internal virtual BindingSource ShiftSalesSummaryByUserBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E2B RID: 7723
		// (get) Token: 0x06005424 RID: 21540 RVA: 0x0030C6E0 File Offset: 0x0030A8E0
		// (set) Token: 0x06005425 RID: 21541 RVA: 0x0030C6EA File Offset: 0x0030A8EA
		internal virtual BindingSource BillingSalesBreakdownForUserBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E2C RID: 7724
		// (get) Token: 0x06005426 RID: 21542 RVA: 0x0030C6F3 File Offset: 0x0030A8F3
		// (set) Token: 0x06005427 RID: 21543 RVA: 0x0030C6FD File Offset: 0x0030A8FD
		internal virtual BindingSource BillingPaymentSummaryUserBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E2D RID: 7725
		// (get) Token: 0x06005428 RID: 21544 RVA: 0x0030C706 File Offset: 0x0030A906
		// (set) Token: 0x06005429 RID: 21545 RVA: 0x0030C710 File Offset: 0x0030A910
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E2E RID: 7726
		// (get) Token: 0x0600542A RID: 21546 RVA: 0x0030C719 File Offset: 0x0030A919
		// (set) Token: 0x0600542B RID: 21547 RVA: 0x0030C723 File Offset: 0x0030A923
		internal virtual USERSalesDayDetailTableAdapter USERSalesDayDetailTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E2F RID: 7727
		// (get) Token: 0x0600542C RID: 21548 RVA: 0x0030C72C File Offset: 0x0030A92C
		// (set) Token: 0x0600542D RID: 21549 RVA: 0x0030C736 File Offset: 0x0030A936
		internal virtual USERSalesPaymentSummaryTableAdapter USERSalesPaymentSummaryTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E30 RID: 7728
		// (get) Token: 0x0600542E RID: 21550 RVA: 0x0030C73F File Offset: 0x0030A93F
		// (set) Token: 0x0600542F RID: 21551 RVA: 0x0030C749 File Offset: 0x0030A949
		internal virtual UserSalesCategorySummaryPERIODTableAdapter UserSalesCategorySummaryPERIODTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E31 RID: 7729
		// (get) Token: 0x06005430 RID: 21552 RVA: 0x0030C752 File Offset: 0x0030A952
		// (set) Token: 0x06005431 RID: 21553 RVA: 0x0030C75C File Offset: 0x0030A95C
		internal virtual ShiftSalesSummaryByUserTableAdapter ShiftSalesSummaryByUserTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E32 RID: 7730
		// (get) Token: 0x06005432 RID: 21554 RVA: 0x0030C765 File Offset: 0x0030A965
		// (set) Token: 0x06005433 RID: 21555 RVA: 0x0030C76F File Offset: 0x0030A96F
		internal virtual BillingSalesBreakdownForUserTableAdapter BillingSalesBreakdownForUserTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E33 RID: 7731
		// (get) Token: 0x06005434 RID: 21556 RVA: 0x0030C778 File Offset: 0x0030A978
		// (set) Token: 0x06005435 RID: 21557 RVA: 0x0030C782 File Offset: 0x0030A982
		internal virtual BillingPaymentSummaryUserTableAdapter BillingPaymentSummaryUserTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E34 RID: 7732
		// (get) Token: 0x06005436 RID: 21558 RVA: 0x0030C78B File Offset: 0x0030A98B
		// (set) Token: 0x06005437 RID: 21559 RVA: 0x0030C795 File Offset: 0x0030A995
		internal virtual BindingSource DiscountsForUserForDayBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E35 RID: 7733
		// (get) Token: 0x06005438 RID: 21560 RVA: 0x0030C79E File Offset: 0x0030A99E
		// (set) Token: 0x06005439 RID: 21561 RVA: 0x0030C7A8 File Offset: 0x0030A9A8
		internal virtual BindingSource DiscountsForDayBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E36 RID: 7734
		// (get) Token: 0x0600543A RID: 21562 RVA: 0x0030C7B1 File Offset: 0x0030A9B1
		// (set) Token: 0x0600543B RID: 21563 RVA: 0x0030C7BB File Offset: 0x0030A9BB
		internal virtual DiscountsForUserForDayTableAdapter DiscountsForUserForDayTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E37 RID: 7735
		// (get) Token: 0x0600543C RID: 21564 RVA: 0x0030C7C4 File Offset: 0x0030A9C4
		// (set) Token: 0x0600543D RID: 21565 RVA: 0x0030C7CE File Offset: 0x0030A9CE
		internal virtual DiscountsForDayTableAdapter DiscountsForDayTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E38 RID: 7736
		// (get) Token: 0x0600543E RID: 21566 RVA: 0x0030C7D7 File Offset: 0x0030A9D7
		// (set) Token: 0x0600543F RID: 21567 RVA: 0x0030C7E1 File Offset: 0x0030A9E1
		internal virtual BindingSource ShiftDetailBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E39 RID: 7737
		// (get) Token: 0x06005440 RID: 21568 RVA: 0x0030C7EA File Offset: 0x0030A9EA
		// (set) Token: 0x06005441 RID: 21569 RVA: 0x0030C7F4 File Offset: 0x0030A9F4
		internal virtual ShiftDetailTableAdapter ShiftDetailTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06005442 RID: 21570 RVA: 0x0030C800 File Offset: 0x0030AA00
		private void GetShift()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = string.Concat(new string[]
			{
				"select * from shiftdetail where coid=",
				Conversions.ToString(MyProject.Forms.Form1.coid),
				" and branch='",
				this.lblbranch.Text,
				"' and entryno=",
				Conversions.ToString(this.shift_entryno)
			});
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				this.lbluser.Text = Conversions.ToString(dataRow["shiftuser"]);
				DateTime dateTime = DateTime.ParseExact(Conversions.ToInteger(dataRow["shiftdate"]).ToString(), "yyyyMMdd", DateTimeFormatInfo.InvariantInfo);
				this.DTStartDate.Value = dateTime;
			}
			else
			{
				MessageBox.Show("Shift with entry number: " + this.shift_entryno.ToString() + " not found.");
			}
		}

		// Token: 0x06005443 RID: 21571 RVA: 0x0030C930 File Offset: 0x0030AB30
		private void ShiftReportForm_Load(object sender, EventArgs e)
		{
			this.lblbranch.Text = MyProject.Forms.Form1.branch;
			this.GetShift();
			try
			{
				this.runreport();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error running report at form load. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005444 RID: 21572 RVA: 0x0030C9A0 File Offset: 0x0030ABA0
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.runreport();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error running report. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005445 RID: 21573 RVA: 0x0030C9F0 File Offset: 0x0030ABF0
		private void runreport()
		{
			SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
			this.GetCompanyDetailsTableAdapter.Connection = sqlConnection;
			this.USERSalesPaymentSummaryTableAdapter.Connection = sqlConnection;
			this.UserSalesCategorySummaryPERIODTableAdapter.Connection = sqlConnection;
			this.USERSalesDayDetailTableAdapter.Connection = sqlConnection;
			this.ShiftSalesSummaryByUserTableAdapter.Connection = sqlConnection;
			this.BillingPaymentSummaryUserTableAdapter.Connection = sqlConnection;
			this.BillingSalesBreakdownForUserTableAdapter.Connection = sqlConnection;
			this.DiscountsForDayTableAdapter.Connection = sqlConnection;
			this.ShiftDetailTableAdapter.Connection = sqlConnection;
			ReportParameter reportParameter = new ReportParameter("shiftdate", Conversions.ToString(Conversions.ToInteger(this.DTStartDate.Value.ToString("yyyyMMdd"))));
			ReportParameter reportParameter2 = new ReportParameter("shiftdateDesc", this.DTStartDate.Value.ToShortDateString());
			ReportParameter reportParameter3 = new ReportParameter("coid", Conversions.ToString(MyProject.Forms.Form1.coid));
			ReportParameter reportParameter4 = new ReportParameter("branch", this.lblbranch.Text);
			ReportParameter reportParameter5 = new ReportParameter("theuser", this.lbluser.Text);
			ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter2, reportParameter3, reportParameter4, reportParameter5 };
			this.ReportViewer1.LocalReport.SetParameters(array);
			this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
			this.USERSalesPaymentSummaryTableAdapter.Fill(this.POSDataSet.USERSalesPaymentSummary, new int?(Conversions.ToInteger(this.DTStartDate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid), this.lblbranch.Text, this.lbluser.Text);
			checked
			{
				this.USERSalesDayDetailTableAdapter.Fill(this.POSDataSet.USERSalesDayDetail, new int?((int)Math.Round(Conversion.Val(this.DTStartDate.Value.ToString("yyyyMMdd")))), new int?(MyProject.Forms.Form1.coid), this.lblbranch.Text, this.lbluser.Text);
				this.UserSalesCategorySummaryPERIODTableAdapter.Fill(this.POSDataSet.UserSalesCategorySummaryPERIOD, new int?((int)Math.Round(Conversion.Val(this.DTStartDate.Value.ToString("yyyyMMdd")))), new int?(MyProject.Forms.Form1.coid), this.lblbranch.Text, this.lbluser.Text);
				this.ShiftSalesSummaryByUserTableAdapter.Fill(this.POSDataSet.ShiftSalesSummaryByUser, new int?((int)Math.Round(Conversion.Val(this.DTStartDate.Value.ToString("yyyyMMdd")))), new int?(MyProject.Forms.Form1.coid), this.lblbranch.Text);
				this.BillingPaymentSummaryUserTableAdapter.Fill(this.POSDataSet.BillingPaymentSummaryUser, new int?(Convert.ToInt32(this.DTStartDate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid), this.lblbranch.Text, this.lbluser.Text);
				this.BillingSalesBreakdownForUserTableAdapter.Fill(this.POSDataSet.BillingSalesBreakdownForUser, new int?(MyProject.Forms.Form1.coid), this.lblbranch.Text, this.lbluser.Text, new int?(Convert.ToInt32(this.DTStartDate.Value.ToString("yyyyMMdd"))));
				this.DiscountsForDayTableAdapter.Fill(this.POSDataSet.DiscountsForDay, new int?(Convert.ToInt32(this.DTStartDate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid), this.lblbranch.Text);
				this.ShiftDetailTableAdapter.Fill(this.POSDataSet.ShiftDetail, Convert.ToInt32(this.DTStartDate.Value.ToString("yyyyMMdd")), MyProject.Forms.Form1.coid, this.lblbranch.Text, this.lbluser.Text);
				this.ReportViewer1.RefreshReport();
			}
		}

		// Token: 0x040024C4 RID: 9412
		private string _cnn;

		// Token: 0x040024C5 RID: 9413
		public int shift_entryno;
	}
}
