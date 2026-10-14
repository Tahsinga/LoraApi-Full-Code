using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;
using PointOfSale.POSDataSetTableAdapters;

namespace PointOfSale
{
	// Token: 0x02000195 RID: 405
	[DesignerGenerated]
	public partial class SalesByInvoice : Form
	{
		// Token: 0x060047CB RID: 18379 RVA: 0x002BD1B8 File Offset: 0x002BB3B8
		public SalesByInvoice()
		{
			base.Load += this.SalesByInvoice_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x17001A0D RID: 6669
		// (get) Token: 0x060047CE RID: 18382 RVA: 0x002BDF7C File Offset: 0x002BC17C
		// (set) Token: 0x060047CF RID: 18383 RVA: 0x002BDF86 File Offset: 0x002BC186
		internal virtual BindingSource SalesForPeriodInvoiceNumbersBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A0E RID: 6670
		// (get) Token: 0x060047D0 RID: 18384 RVA: 0x002BDF8F File Offset: 0x002BC18F
		// (set) Token: 0x060047D1 RID: 18385 RVA: 0x002BDF99 File Offset: 0x002BC199
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A0F RID: 6671
		// (get) Token: 0x060047D2 RID: 18386 RVA: 0x002BDFA2 File Offset: 0x002BC1A2
		// (set) Token: 0x060047D3 RID: 18387 RVA: 0x002BDFAC File Offset: 0x002BC1AC
		internal virtual BindingSource GetCompanyDetailsForCoidBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A10 RID: 6672
		// (get) Token: 0x060047D4 RID: 18388 RVA: 0x002BDFB5 File Offset: 0x002BC1B5
		// (set) Token: 0x060047D5 RID: 18389 RVA: 0x002BDFBF File Offset: 0x002BC1BF
		internal virtual SalesForPeriodInvoiceNumbersTableAdapter SalesForPeriodInvoiceNumbersTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A11 RID: 6673
		// (get) Token: 0x060047D6 RID: 18390 RVA: 0x002BDFC8 File Offset: 0x002BC1C8
		// (set) Token: 0x060047D7 RID: 18391 RVA: 0x002BDFD2 File Offset: 0x002BC1D2
		internal virtual GetCompanyDetailsForCoidTableAdapter GetCompanyDetailsForCoidTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A12 RID: 6674
		// (get) Token: 0x060047D8 RID: 18392 RVA: 0x002BDFDB File Offset: 0x002BC1DB
		// (set) Token: 0x060047D9 RID: 18393 RVA: 0x002BDFE5 File Offset: 0x002BC1E5
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A13 RID: 6675
		// (get) Token: 0x060047DA RID: 18394 RVA: 0x002BDFEE File Offset: 0x002BC1EE
		// (set) Token: 0x060047DB RID: 18395 RVA: 0x002BDFF8 File Offset: 0x002BC1F8
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A14 RID: 6676
		// (get) Token: 0x060047DC RID: 18396 RVA: 0x002BE001 File Offset: 0x002BC201
		// (set) Token: 0x060047DD RID: 18397 RVA: 0x002BE00B File Offset: 0x002BC20B
		internal virtual DateTimePicker DTEnddate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A15 RID: 6677
		// (get) Token: 0x060047DE RID: 18398 RVA: 0x002BE014 File Offset: 0x002BC214
		// (set) Token: 0x060047DF RID: 18399 RVA: 0x002BE01E File Offset: 0x002BC21E
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A16 RID: 6678
		// (get) Token: 0x060047E0 RID: 18400 RVA: 0x002BE027 File Offset: 0x002BC227
		// (set) Token: 0x060047E1 RID: 18401 RVA: 0x002BE031 File Offset: 0x002BC231
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A17 RID: 6679
		// (get) Token: 0x060047E2 RID: 18402 RVA: 0x002BE03A File Offset: 0x002BC23A
		// (set) Token: 0x060047E3 RID: 18403 RVA: 0x002BE044 File Offset: 0x002BC244
		internal virtual ComboBox cboBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A18 RID: 6680
		// (get) Token: 0x060047E4 RID: 18404 RVA: 0x002BE04D File Offset: 0x002BC24D
		// (set) Token: 0x060047E5 RID: 18405 RVA: 0x002BE057 File Offset: 0x002BC257
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A19 RID: 6681
		// (get) Token: 0x060047E6 RID: 18406 RVA: 0x002BE060 File Offset: 0x002BC260
		// (set) Token: 0x060047E7 RID: 18407 RVA: 0x002BE06C File Offset: 0x002BC26C
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

		// Token: 0x17001A1A RID: 6682
		// (get) Token: 0x060047E8 RID: 18408 RVA: 0x002BE0AF File Offset: 0x002BC2AF
		// (set) Token: 0x060047E9 RID: 18409 RVA: 0x002BE0B9 File Offset: 0x002BC2B9
		internal virtual DateTimePicker DTStartdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A1B RID: 6683
		// (get) Token: 0x060047EA RID: 18410 RVA: 0x002BE0C2 File Offset: 0x002BC2C2
		// (set) Token: 0x060047EB RID: 18411 RVA: 0x002BE0CC File Offset: 0x002BC2CC
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A1C RID: 6684
		// (get) Token: 0x060047EC RID: 18412 RVA: 0x002BE0D5 File Offset: 0x002BC2D5
		// (set) Token: 0x060047ED RID: 18413 RVA: 0x002BE0DF File Offset: 0x002BC2DF
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A1D RID: 6685
		// (get) Token: 0x060047EE RID: 18414 RVA: 0x002BE0E8 File Offset: 0x002BC2E8
		// (set) Token: 0x060047EF RID: 18415 RVA: 0x002BE0F2 File Offset: 0x002BC2F2
		internal virtual ComboBox cboUsers
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A1E RID: 6686
		// (get) Token: 0x060047F0 RID: 18416 RVA: 0x002BE0FB File Offset: 0x002BC2FB
		// (set) Token: 0x060047F1 RID: 18417 RVA: 0x002BE108 File Offset: 0x002BC308
		internal virtual CheckBox chkAllusers
		{
			[CompilerGenerated]
			get
			{
				return this._chkAllusers;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CheckBox1_CheckedChanged);
				CheckBox checkBox = this._chkAllusers;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= eventHandler;
				}
				this._chkAllusers = value;
				checkBox = this._chkAllusers;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x17001A1F RID: 6687
		// (get) Token: 0x060047F2 RID: 18418 RVA: 0x002BE14B File Offset: 0x002BC34B
		// (set) Token: 0x060047F3 RID: 18419 RVA: 0x002BE155 File Offset: 0x002BC355
		internal virtual BindingSource DiscountsForPeriodBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A20 RID: 6688
		// (get) Token: 0x060047F4 RID: 18420 RVA: 0x002BE15E File Offset: 0x002BC35E
		// (set) Token: 0x060047F5 RID: 18421 RVA: 0x002BE168 File Offset: 0x002BC368
		internal virtual BindingSource GetProdCreditNoteChargesBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A21 RID: 6689
		// (get) Token: 0x060047F6 RID: 18422 RVA: 0x002BE171 File Offset: 0x002BC371
		// (set) Token: 0x060047F7 RID: 18423 RVA: 0x002BE17B File Offset: 0x002BC37B
		internal virtual BindingSource ShiftSalesPaymentSummaryforPeriodBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A22 RID: 6690
		// (get) Token: 0x060047F8 RID: 18424 RVA: 0x002BE184 File Offset: 0x002BC384
		// (set) Token: 0x060047F9 RID: 18425 RVA: 0x002BE18E File Offset: 0x002BC38E
		internal virtual DiscountsForPeriodTableAdapter DiscountsForPeriodTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A23 RID: 6691
		// (get) Token: 0x060047FA RID: 18426 RVA: 0x002BE197 File Offset: 0x002BC397
		// (set) Token: 0x060047FB RID: 18427 RVA: 0x002BE1A1 File Offset: 0x002BC3A1
		internal virtual GetProdCreditNoteChargesTableAdapter GetProdCreditNoteChargesTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A24 RID: 6692
		// (get) Token: 0x060047FC RID: 18428 RVA: 0x002BE1AA File Offset: 0x002BC3AA
		// (set) Token: 0x060047FD RID: 18429 RVA: 0x002BE1B4 File Offset: 0x002BC3B4
		internal virtual ShiftSalesPaymentSummaryforPeriodTableAdapter ShiftSalesPaymentSummaryforPeriodTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A25 RID: 6693
		// (get) Token: 0x060047FE RID: 18430 RVA: 0x002BE1BD File Offset: 0x002BC3BD
		// (set) Token: 0x060047FF RID: 18431 RVA: 0x002BE1C7 File Offset: 0x002BC3C7
		internal virtual BindingSource PeriodAuditInfoBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A26 RID: 6694
		// (get) Token: 0x06004800 RID: 18432 RVA: 0x002BE1D0 File Offset: 0x002BC3D0
		// (set) Token: 0x06004801 RID: 18433 RVA: 0x002BE1DA File Offset: 0x002BC3DA
		internal virtual PeriodAuditInfoTableAdapter PeriodAuditInfoTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A27 RID: 6695
		// (get) Token: 0x06004802 RID: 18434 RVA: 0x002BE1E3 File Offset: 0x002BC3E3
		// (set) Token: 0x06004803 RID: 18435 RVA: 0x002BE1ED File Offset: 0x002BC3ED
		internal virtual BindingSource CreditPaymentsForPeriodBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A28 RID: 6696
		// (get) Token: 0x06004804 RID: 18436 RVA: 0x002BE1F6 File Offset: 0x002BC3F6
		// (set) Token: 0x06004805 RID: 18437 RVA: 0x002BE200 File Offset: 0x002BC400
		internal virtual CreditPaymentsForPeriodTableAdapter CreditPaymentsForPeriodTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06004806 RID: 18438 RVA: 0x002BE20C File Offset: 0x002BC40C
		private void SalesByInvoice_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadBranches();
				this.cboUsers.DataSource = this.pf.GetUsers(MyProject.Forms.Form1.coid, this._cnn);
				this.cboUsers.DisplayMember = "Username";
				this.cboUsers.ValueMember = "Username";
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06004807 RID: 18439 RVA: 0x002BE2A8 File Offset: 0x002BC4A8
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

		// Token: 0x06004808 RID: 18440 RVA: 0x002BE36C File Offset: 0x002BC56C
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
				this.GetCompanyDetailsForCoidTableAdapter.Connection = sqlConnection;
				this.SalesForPeriodInvoiceNumbersTableAdapter.Connection = sqlConnection;
				this.ShiftSalesPaymentSummaryforPeriodTableAdapter.Connection = sqlConnection;
				this.DiscountsForPeriodTableAdapter.Connection = sqlConnection;
				this.GetProdCreditNoteChargesTableAdapter.Connection = sqlConnection;
				this.PeriodAuditInfoTableAdapter.Connection = sqlConnection;
				this.CreditPaymentsForPeriodTableAdapter.Connection = sqlConnection;
				ReportParameter reportParameter = new ReportParameter("startdatedesc", this.DTStartdate.Value.ToShortDateString());
				ReportParameter reportParameter2 = new ReportParameter("enddatedesc", this.DTEnddate.Value.ToShortDateString());
				string text = null;
				bool @checked = this.chkAllusers.Checked;
				string text2;
				if (@checked)
				{
					text2 = "All Users";
				}
				else
				{
					text2 = this.cboUsers.Text;
					text = this.cboUsers.Text;
				}
				ReportParameter reportParameter3 = new ReportParameter("doneby", text2);
				ReportParameter reportParameter4 = new ReportParameter("branch", this.cboBranch.Text);
				ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter2, reportParameter4, reportParameter3 };
				this.ReportViewer1.LocalReport.SetParameters(array);
				this.GetCompanyDetailsForCoidTableAdapter.Fill(this.POSDataSet.GetCompanyDetailsForCoid, new int?(MyProject.Forms.Form1.coid));
				this.SalesForPeriodInvoiceNumbersTableAdapter.Fill(this.POSDataSet.SalesForPeriodInvoiceNumbers, new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text, new int?(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))), text);
				this.ShiftSalesPaymentSummaryforPeriodTableAdapter.Fill(this.POSDataSet.ShiftSalesPaymentSummaryforPeriod, new int?(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text, new int?(0), null, null);
				this.DiscountsForPeriodTableAdapter.Fill(this.POSDataSet.DiscountsForPeriod, new int?(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text);
				this.GetProdCreditNoteChargesTableAdapter.Fill(this.POSDataSet.GetProdCreditNoteCharges, new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text, new int?(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))), text);
				this.PeriodAuditInfoTableAdapter.Fill(this.POSDataSet.PeriodAuditInfo, new int?(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text);
				this.CreditPaymentsForPeriodTableAdapter.Fill(this.POSDataSet.CreditPaymentsForPeriod, new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text, new int?(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))));
				this.ReportViewer1.RefreshReport();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying report. Detail: " + ex.Message);
			}
		}

		// Token: 0x06004809 RID: 18441 RVA: 0x002BE838 File Offset: 0x002BCA38
		private void CheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				bool @checked = this.chkAllusers.Checked;
				if (@checked)
				{
					this.cboUsers.Enabled = false;
				}
				else
				{
					this.cboUsers.Enabled = true;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x04001F83 RID: 8067
		private string _cnn;

		// Token: 0x04001F84 RID: 8068
		private PublicFunctions pf;
	}
}
