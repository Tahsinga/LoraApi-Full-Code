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
	// Token: 0x020001F8 RID: 504
	[DesignerGenerated]
	public partial class StockTransfersForPeriod : Form
	{
		// Token: 0x06005A4C RID: 23116 RVA: 0x003423A0 File Offset: 0x003405A0
		public StockTransfersForPeriod()
		{
			base.Load += this.StockTransfersForPeriod_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x1700207D RID: 8317
		// (get) Token: 0x06005A4F RID: 23119 RVA: 0x00342DC4 File Offset: 0x00340FC4
		// (set) Token: 0x06005A50 RID: 23120 RVA: 0x00342DCE File Offset: 0x00340FCE
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700207E RID: 8318
		// (get) Token: 0x06005A51 RID: 23121 RVA: 0x00342DD7 File Offset: 0x00340FD7
		// (set) Token: 0x06005A52 RID: 23122 RVA: 0x00342DE1 File Offset: 0x00340FE1
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700207F RID: 8319
		// (get) Token: 0x06005A53 RID: 23123 RVA: 0x00342DEA File Offset: 0x00340FEA
		// (set) Token: 0x06005A54 RID: 23124 RVA: 0x00342DF4 File Offset: 0x00340FF4
		internal virtual ComboBox cboBranch
		{
			[CompilerGenerated]
			get
			{
				return this._cboBranch;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cboBranch_SelectedIndexChanged);
				ComboBox comboBox = this._cboBranch;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= eventHandler;
				}
				this._cboBranch = value;
				comboBox = this._cboBranch;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17002080 RID: 8320
		// (get) Token: 0x06005A55 RID: 23125 RVA: 0x00342E37 File Offset: 0x00341037
		// (set) Token: 0x06005A56 RID: 23126 RVA: 0x00342E41 File Offset: 0x00341041
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002081 RID: 8321
		// (get) Token: 0x06005A57 RID: 23127 RVA: 0x00342E4A File Offset: 0x0034104A
		// (set) Token: 0x06005A58 RID: 23128 RVA: 0x00342E54 File Offset: 0x00341054
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002082 RID: 8322
		// (get) Token: 0x06005A59 RID: 23129 RVA: 0x00342E5D File Offset: 0x0034105D
		// (set) Token: 0x06005A5A RID: 23130 RVA: 0x00342E67 File Offset: 0x00341067
		internal virtual DateTimePicker DTEnddate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002083 RID: 8323
		// (get) Token: 0x06005A5B RID: 23131 RVA: 0x00342E70 File Offset: 0x00341070
		// (set) Token: 0x06005A5C RID: 23132 RVA: 0x00342E7C File Offset: 0x0034107C
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

		// Token: 0x17002084 RID: 8324
		// (get) Token: 0x06005A5D RID: 23133 RVA: 0x00342EBF File Offset: 0x003410BF
		// (set) Token: 0x06005A5E RID: 23134 RVA: 0x00342EC9 File Offset: 0x003410C9
		internal virtual DateTimePicker DTStartdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002085 RID: 8325
		// (get) Token: 0x06005A5F RID: 23135 RVA: 0x00342ED2 File Offset: 0x003410D2
		// (set) Token: 0x06005A60 RID: 23136 RVA: 0x00342EDC File Offset: 0x003410DC
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002086 RID: 8326
		// (get) Token: 0x06005A61 RID: 23137 RVA: 0x00342EE5 File Offset: 0x003410E5
		// (set) Token: 0x06005A62 RID: 23138 RVA: 0x00342EEF File Offset: 0x003410EF
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002087 RID: 8327
		// (get) Token: 0x06005A63 RID: 23139 RVA: 0x00342EF8 File Offset: 0x003410F8
		// (set) Token: 0x06005A64 RID: 23140 RVA: 0x00342F02 File Offset: 0x00341102
		internal virtual BindingSource FetchTransferDetailsToForPeriodBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002088 RID: 8328
		// (get) Token: 0x06005A65 RID: 23141 RVA: 0x00342F0B File Offset: 0x0034110B
		// (set) Token: 0x06005A66 RID: 23142 RVA: 0x00342F15 File Offset: 0x00341115
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002089 RID: 8329
		// (get) Token: 0x06005A67 RID: 23143 RVA: 0x00342F1E File Offset: 0x0034111E
		// (set) Token: 0x06005A68 RID: 23144 RVA: 0x00342F28 File Offset: 0x00341128
		internal virtual FetchTransferDetailsToForPeriodTableAdapter FetchTransferDetailsToForPeriodTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700208A RID: 8330
		// (get) Token: 0x06005A69 RID: 23145 RVA: 0x00342F31 File Offset: 0x00341131
		// (set) Token: 0x06005A6A RID: 23146 RVA: 0x00342F3B File Offset: 0x0034113B
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700208B RID: 8331
		// (get) Token: 0x06005A6B RID: 23147 RVA: 0x00342F44 File Offset: 0x00341144
		// (set) Token: 0x06005A6C RID: 23148 RVA: 0x00342F4E File Offset: 0x0034114E
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700208C RID: 8332
		// (get) Token: 0x06005A6D RID: 23149 RVA: 0x00342F57 File Offset: 0x00341157
		// (set) Token: 0x06005A6E RID: 23150 RVA: 0x00342F61 File Offset: 0x00341161
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700208D RID: 8333
		// (get) Token: 0x06005A6F RID: 23151 RVA: 0x00342F6A File Offset: 0x0034116A
		// (set) Token: 0x06005A70 RID: 23152 RVA: 0x00342F74 File Offset: 0x00341174
		internal virtual Label lblBranchFrom
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06005A71 RID: 23153 RVA: 0x00342F80 File Offset: 0x00341180
		private void StockTransfersForPeriod_Load(object sender, EventArgs e)
		{
			try
			{
				DataTable dataTable = this.LoadBranches();
				this.lblBranchFrom.Text = MyProject.Forms.Form1.branch;
				this.cboBranch.DataSource = dataTable;
				this.cboBranch.ValueMember = "branch";
				this.cboBranch.DisplayMember = "branch";
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005A72 RID: 23154 RVA: 0x00343018 File Offset: 0x00341218
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

		// Token: 0x06005A73 RID: 23155 RVA: 0x00343090 File Offset: 0x00341290
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
				this.GetCompanyDetailsTableAdapter.Connection = sqlConnection;
				this.FetchTransferDetailsToForPeriodTableAdapter.Connection = sqlConnection;
				ReportParameter reportParameter = new ReportParameter("startdate", Conversions.ToString(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))));
				ReportParameter reportParameter2 = new ReportParameter("startdatedesc", this.DTStartdate.Value.ToShortDateString());
				ReportParameter reportParameter3 = new ReportParameter("enddate", Conversions.ToString(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))));
				ReportParameter reportParameter4 = new ReportParameter("enddatedesc", this.DTEnddate.Value.ToShortDateString());
				ReportParameter reportParameter5 = new ReportParameter("coid", Conversions.ToString(MyProject.Forms.Form1.coid));
				ReportParameter reportParameter6 = new ReportParameter("branchto", this.cboBranch.Text);
				ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter2, reportParameter3, reportParameter4, reportParameter5, reportParameter6 };
				this.ReportViewer1.LocalReport.SetParameters(array);
				this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
				this.FetchTransferDetailsToForPeriodTableAdapter.Fill(this.POSDataSet.FetchTransferDetailsToForPeriod, new int?(MyProject.Forms.Form1.coid), new int?(Convert.ToInt32(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Convert.ToInt32(this.DTEnddate.Value.ToString("yyyyMMdd"))), this.cboBranch.Text, this.lblBranchFrom.Text);
				this.ReportViewer1.RefreshReport();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying transfers report. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005A74 RID: 23156 RVA: 0x00002A30 File Offset: 0x00000C30
		private void cboBranch_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0400277C RID: 10108
		private string _cnn;
	}
}
