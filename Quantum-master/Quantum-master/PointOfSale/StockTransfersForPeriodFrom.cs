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
	// Token: 0x020001F9 RID: 505
	[DesignerGenerated]
	public partial class StockTransfersForPeriodFrom : Form
	{
		// Token: 0x06005A75 RID: 23157 RVA: 0x003432C8 File Offset: 0x003414C8
		public StockTransfersForPeriodFrom()
		{
			base.Load += this.StockTransfersForPeriodFrom_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x1700208E RID: 8334
		// (get) Token: 0x06005A78 RID: 23160 RVA: 0x00343CC7 File Offset: 0x00341EC7
		// (set) Token: 0x06005A79 RID: 23161 RVA: 0x00343CD1 File Offset: 0x00341ED1
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700208F RID: 8335
		// (get) Token: 0x06005A7A RID: 23162 RVA: 0x00343CDA File Offset: 0x00341EDA
		// (set) Token: 0x06005A7B RID: 23163 RVA: 0x00343CE4 File Offset: 0x00341EE4
		internal virtual Label lblBranchTo
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002090 RID: 8336
		// (get) Token: 0x06005A7C RID: 23164 RVA: 0x00343CED File Offset: 0x00341EED
		// (set) Token: 0x06005A7D RID: 23165 RVA: 0x00343CF7 File Offset: 0x00341EF7
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002091 RID: 8337
		// (get) Token: 0x06005A7E RID: 23166 RVA: 0x00343D00 File Offset: 0x00341F00
		// (set) Token: 0x06005A7F RID: 23167 RVA: 0x00343D0A File Offset: 0x00341F0A
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002092 RID: 8338
		// (get) Token: 0x06005A80 RID: 23168 RVA: 0x00343D13 File Offset: 0x00341F13
		// (set) Token: 0x06005A81 RID: 23169 RVA: 0x00343D1D File Offset: 0x00341F1D
		internal virtual ComboBox cboBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002093 RID: 8339
		// (get) Token: 0x06005A82 RID: 23170 RVA: 0x00343D26 File Offset: 0x00341F26
		// (set) Token: 0x06005A83 RID: 23171 RVA: 0x00343D30 File Offset: 0x00341F30
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002094 RID: 8340
		// (get) Token: 0x06005A84 RID: 23172 RVA: 0x00343D39 File Offset: 0x00341F39
		// (set) Token: 0x06005A85 RID: 23173 RVA: 0x00343D43 File Offset: 0x00341F43
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002095 RID: 8341
		// (get) Token: 0x06005A86 RID: 23174 RVA: 0x00343D4C File Offset: 0x00341F4C
		// (set) Token: 0x06005A87 RID: 23175 RVA: 0x00343D56 File Offset: 0x00341F56
		internal virtual DateTimePicker DTEnddate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002096 RID: 8342
		// (get) Token: 0x06005A88 RID: 23176 RVA: 0x00343D5F File Offset: 0x00341F5F
		// (set) Token: 0x06005A89 RID: 23177 RVA: 0x00343D6C File Offset: 0x00341F6C
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

		// Token: 0x17002097 RID: 8343
		// (get) Token: 0x06005A8A RID: 23178 RVA: 0x00343DAF File Offset: 0x00341FAF
		// (set) Token: 0x06005A8B RID: 23179 RVA: 0x00343DB9 File Offset: 0x00341FB9
		internal virtual DateTimePicker DTStartdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002098 RID: 8344
		// (get) Token: 0x06005A8C RID: 23180 RVA: 0x00343DC2 File Offset: 0x00341FC2
		// (set) Token: 0x06005A8D RID: 23181 RVA: 0x00343DCC File Offset: 0x00341FCC
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002099 RID: 8345
		// (get) Token: 0x06005A8E RID: 23182 RVA: 0x00343DD5 File Offset: 0x00341FD5
		// (set) Token: 0x06005A8F RID: 23183 RVA: 0x00343DDF File Offset: 0x00341FDF
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700209A RID: 8346
		// (get) Token: 0x06005A90 RID: 23184 RVA: 0x00343DE8 File Offset: 0x00341FE8
		// (set) Token: 0x06005A91 RID: 23185 RVA: 0x00343DF2 File Offset: 0x00341FF2
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700209B RID: 8347
		// (get) Token: 0x06005A92 RID: 23186 RVA: 0x00343DFB File Offset: 0x00341FFB
		// (set) Token: 0x06005A93 RID: 23187 RVA: 0x00343E05 File Offset: 0x00342005
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700209C RID: 8348
		// (get) Token: 0x06005A94 RID: 23188 RVA: 0x00343E0E File Offset: 0x0034200E
		// (set) Token: 0x06005A95 RID: 23189 RVA: 0x00343E18 File Offset: 0x00342018
		internal virtual BindingSource FetchTransferDetailsFromForPeriodBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700209D RID: 8349
		// (get) Token: 0x06005A96 RID: 23190 RVA: 0x00343E21 File Offset: 0x00342021
		// (set) Token: 0x06005A97 RID: 23191 RVA: 0x00343E2B File Offset: 0x0034202B
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700209E RID: 8350
		// (get) Token: 0x06005A98 RID: 23192 RVA: 0x00343E34 File Offset: 0x00342034
		// (set) Token: 0x06005A99 RID: 23193 RVA: 0x00343E3E File Offset: 0x0034203E
		internal virtual FetchTransferDetailsFromForPeriodTableAdapter FetchTransferDetailsFromForPeriodTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06005A9A RID: 23194 RVA: 0x00343E48 File Offset: 0x00342048
		private void StockTransfersForPeriodFrom_Load(object sender, EventArgs e)
		{
			try
			{
				this.lblBranchTo.Text = MyProject.Forms.Form1.branch;
				DataTable dataTable = this.LoadBranches();
				this.cboBranch.DataSource = dataTable;
				this.cboBranch.ValueMember = "branch";
				this.cboBranch.DisplayMember = "branch";
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005A9B RID: 23195 RVA: 0x00343EE0 File Offset: 0x003420E0
		private DataTable LoadBranches()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchBranches";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x06005A9C RID: 23196 RVA: 0x00343F58 File Offset: 0x00342158
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
				this.GetCompanyDetailsTableAdapter.Connection = sqlConnection;
				this.FetchTransferDetailsFromForPeriodTableAdapter.Connection = sqlConnection;
				ReportParameter reportParameter = new ReportParameter("startdate", Conversions.ToString(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))));
				ReportParameter reportParameter2 = new ReportParameter("startdatedesc", this.DTStartdate.Value.ToShortDateString());
				ReportParameter reportParameter3 = new ReportParameter("enddate", Conversions.ToString(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))));
				ReportParameter reportParameter4 = new ReportParameter("enddatedesc", this.DTEnddate.Value.ToShortDateString());
				ReportParameter reportParameter5 = new ReportParameter("coid", Conversions.ToString(MyProject.Forms.Form1.coid));
				ReportParameter reportParameter6 = new ReportParameter("branchfrom", this.cboBranch.Text);
				ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter2, reportParameter3, reportParameter4, reportParameter5, reportParameter6 };
				this.ReportViewer1.LocalReport.SetParameters(array);
				this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
				this.FetchTransferDetailsFromForPeriodTableAdapter.Fill(this.POSDataSet.FetchTransferDetailsFromForPeriod, new int?(MyProject.Forms.Form1.coid), new int?(Convert.ToInt32(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Convert.ToInt32(this.DTEnddate.Value.ToString("yyyyMMdd"))), this.lblBranchTo.Text, this.cboBranch.Text);
				this.ReportViewer1.RefreshReport();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying transfers report. Detail: " + ex.Message);
			}
		}

		// Token: 0x0400278F RID: 10127
		private string _cnn;
	}
}
