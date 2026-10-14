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
	// Token: 0x0200019A RID: 410
	[DesignerGenerated]
	public partial class SalesForCustomer : UserControl
	{
		// Token: 0x060048EB RID: 18667 RVA: 0x002C3D78 File Offset: 0x002C1F78
		public SalesForCustomer()
		{
			base.Load += this.SalesForCustomer_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x17001A89 RID: 6793
		// (get) Token: 0x060048EE RID: 18670 RVA: 0x002C499D File Offset: 0x002C2B9D
		// (set) Token: 0x060048EF RID: 18671 RVA: 0x002C49A7 File Offset: 0x002C2BA7
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A8A RID: 6794
		// (get) Token: 0x060048F0 RID: 18672 RVA: 0x002C49B0 File Offset: 0x002C2BB0
		// (set) Token: 0x060048F1 RID: 18673 RVA: 0x002C49BA File Offset: 0x002C2BBA
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A8B RID: 6795
		// (get) Token: 0x060048F2 RID: 18674 RVA: 0x002C49C3 File Offset: 0x002C2BC3
		// (set) Token: 0x060048F3 RID: 18675 RVA: 0x002C49CD File Offset: 0x002C2BCD
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A8C RID: 6796
		// (get) Token: 0x060048F4 RID: 18676 RVA: 0x002C49D6 File Offset: 0x002C2BD6
		// (set) Token: 0x060048F5 RID: 18677 RVA: 0x002C49E0 File Offset: 0x002C2BE0
		internal virtual DateTimePicker DTEnddate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A8D RID: 6797
		// (get) Token: 0x060048F6 RID: 18678 RVA: 0x002C49E9 File Offset: 0x002C2BE9
		// (set) Token: 0x060048F7 RID: 18679 RVA: 0x002C49F3 File Offset: 0x002C2BF3
		internal virtual DateTimePicker DTStartdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A8E RID: 6798
		// (get) Token: 0x060048F8 RID: 18680 RVA: 0x002C49FC File Offset: 0x002C2BFC
		// (set) Token: 0x060048F9 RID: 18681 RVA: 0x002C4A06 File Offset: 0x002C2C06
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A8F RID: 6799
		// (get) Token: 0x060048FA RID: 18682 RVA: 0x002C4A0F File Offset: 0x002C2C0F
		// (set) Token: 0x060048FB RID: 18683 RVA: 0x002C4A19 File Offset: 0x002C2C19
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A90 RID: 6800
		// (get) Token: 0x060048FC RID: 18684 RVA: 0x002C4A22 File Offset: 0x002C2C22
		// (set) Token: 0x060048FD RID: 18685 RVA: 0x002C4A2C File Offset: 0x002C2C2C
		internal virtual ComboBox cboBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A91 RID: 6801
		// (get) Token: 0x060048FE RID: 18686 RVA: 0x002C4A35 File Offset: 0x002C2C35
		// (set) Token: 0x060048FF RID: 18687 RVA: 0x002C4A40 File Offset: 0x002C2C40
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

		// Token: 0x17001A92 RID: 6802
		// (get) Token: 0x06004900 RID: 18688 RVA: 0x002C4A83 File Offset: 0x002C2C83
		// (set) Token: 0x06004901 RID: 18689 RVA: 0x002C4A8D File Offset: 0x002C2C8D
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A93 RID: 6803
		// (get) Token: 0x06004902 RID: 18690 RVA: 0x002C4A96 File Offset: 0x002C2C96
		// (set) Token: 0x06004903 RID: 18691 RVA: 0x002C4AA0 File Offset: 0x002C2CA0
		internal virtual ComboBox cboCustomers
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A94 RID: 6804
		// (get) Token: 0x06004904 RID: 18692 RVA: 0x002C4AA9 File Offset: 0x002C2CA9
		// (set) Token: 0x06004905 RID: 18693 RVA: 0x002C4AB3 File Offset: 0x002C2CB3
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A95 RID: 6805
		// (get) Token: 0x06004906 RID: 18694 RVA: 0x002C4ABC File Offset: 0x002C2CBC
		// (set) Token: 0x06004907 RID: 18695 RVA: 0x002C4AC6 File Offset: 0x002C2CC6
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A96 RID: 6806
		// (get) Token: 0x06004908 RID: 18696 RVA: 0x002C4ACF File Offset: 0x002C2CCF
		// (set) Token: 0x06004909 RID: 18697 RVA: 0x002C4AD9 File Offset: 0x002C2CD9
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A97 RID: 6807
		// (get) Token: 0x0600490A RID: 18698 RVA: 0x002C4AE2 File Offset: 0x002C2CE2
		// (set) Token: 0x0600490B RID: 18699 RVA: 0x002C4AEC File Offset: 0x002C2CEC
		internal virtual BindingSource CustomerSalesForPeriodBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A98 RID: 6808
		// (get) Token: 0x0600490C RID: 18700 RVA: 0x002C4AF5 File Offset: 0x002C2CF5
		// (set) Token: 0x0600490D RID: 18701 RVA: 0x002C4AFF File Offset: 0x002C2CFF
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A99 RID: 6809
		// (get) Token: 0x0600490E RID: 18702 RVA: 0x002C4B08 File Offset: 0x002C2D08
		// (set) Token: 0x0600490F RID: 18703 RVA: 0x002C4B12 File Offset: 0x002C2D12
		internal virtual CustomerSalesForPeriodTableAdapter CustomerSalesForPeriodTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A9A RID: 6810
		// (get) Token: 0x06004910 RID: 18704 RVA: 0x002C4B1B File Offset: 0x002C2D1B
		// (set) Token: 0x06004911 RID: 18705 RVA: 0x002C4B28 File Offset: 0x002C2D28
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

		// Token: 0x17001A9B RID: 6811
		// (get) Token: 0x06004912 RID: 18706 RVA: 0x002C4B6B File Offset: 0x002C2D6B
		// (set) Token: 0x06004913 RID: 18707 RVA: 0x002C4B75 File Offset: 0x002C2D75
		internal virtual BindingSource CustomerSalesPaymentSummaryPeriodBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A9C RID: 6812
		// (get) Token: 0x06004914 RID: 18708 RVA: 0x002C4B7E File Offset: 0x002C2D7E
		// (set) Token: 0x06004915 RID: 18709 RVA: 0x002C4B88 File Offset: 0x002C2D88
		internal virtual CustomerSalesPaymentSummaryPeriodTableAdapter CustomerSalesPaymentSummaryPeriodTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A9D RID: 6813
		// (get) Token: 0x06004916 RID: 18710 RVA: 0x002C4B91 File Offset: 0x002C2D91
		// (set) Token: 0x06004917 RID: 18711 RVA: 0x002C4B9B File Offset: 0x002C2D9B
		internal virtual BindingSource FetchCustomerDetailsEntrynoBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A9E RID: 6814
		// (get) Token: 0x06004918 RID: 18712 RVA: 0x002C4BA4 File Offset: 0x002C2DA4
		// (set) Token: 0x06004919 RID: 18713 RVA: 0x002C4BAE File Offset: 0x002C2DAE
		internal virtual FetchCustomerDetailsEntrynoTableAdapter FetchCustomerDetailsEntrynoTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x0600491A RID: 18714 RVA: 0x002C4BB8 File Offset: 0x002C2DB8
		private void LoadCustomers()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchAllCustomers";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			this.cboCustomers.DataSource = dataTable;
			this.cboCustomers.DisplayMember = "CustomerName";
			this.cboCustomers.ValueMember = "EntryNo";
		}

		// Token: 0x0600491B RID: 18715 RVA: 0x002C4C78 File Offset: 0x002C2E78
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
		}

		// Token: 0x0600491C RID: 18716 RVA: 0x002C4D18 File Offset: 0x002C2F18
		private void SalesForCustomer_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadBranches();
				this.LoadCustomers();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600491D RID: 18717 RVA: 0x002C4D70 File Offset: 0x002C2F70
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
				this.GetCompanyDetailsTableAdapter.Connection = sqlConnection;
				this.CustomerSalesForPeriodTableAdapter.Connection = sqlConnection;
				this.FetchCustomerDetailsEntrynoTableAdapter.Connection = sqlConnection;
				this.CustomerSalesPaymentSummaryPeriodTableAdapter.Connection = sqlConnection;
				ReportParameter reportParameter = new ReportParameter("startdate", Conversions.ToString(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))));
				ReportParameter reportParameter2 = new ReportParameter("startdatedesc", this.DTStartdate.Value.ToShortDateString());
				ReportParameter reportParameter3 = new ReportParameter("enddate", Conversions.ToString(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))));
				ReportParameter reportParameter4 = new ReportParameter("enddatedesc", this.DTEnddate.Value.ToShortDateString());
				ReportParameter reportParameter5 = new ReportParameter("coid", Conversions.ToString(MyProject.Forms.Form1.coid));
				ReportParameter reportParameter6 = new ReportParameter("branch", this.cboBranch.Text);
				ReportParameter reportParameter7 = new ReportParameter("CustomerName", this.cboCustomers.Text);
				ReportParameter reportParameter8 = new ReportParameter("customerid", this.cboCustomers.Text);
				ReportParameter[] array = new ReportParameter[] { reportParameter5, reportParameter6, reportParameter8, reportParameter7, reportParameter, reportParameter2, reportParameter3, reportParameter4 };
				this.ReportViewer1.LocalReport.SetParameters(array);
				this.CustomerSalesForPeriodTableAdapter.Fill(this.POSDataSet.CustomerSalesForPeriod, new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text, new int?(Convert.ToInt32(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Convert.ToInt32(this.DTEnddate.Value.ToString("yyyyMMdd"))), (int?)this.cboCustomers.SelectedValue);
				this.FetchCustomerDetailsEntrynoTableAdapter.Fill(this.POSDataSet.FetchCustomerDetailsEntryno, (int?)this.cboCustomers.SelectedValue, new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text);
				this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
				this.CustomerSalesPaymentSummaryPeriodTableAdapter.Fill(this.POSDataSet.CustomerSalesPaymentSummaryPeriod, new int?(Convert.ToInt32(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Convert.ToInt32(this.DTEnddate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text, (int?)this.cboCustomers.SelectedValue);
				this.ReportViewer1.RefreshReport();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error running report. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600491E RID: 18718 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label6_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x04002005 RID: 8197
		private string _cnn;
	}
}
