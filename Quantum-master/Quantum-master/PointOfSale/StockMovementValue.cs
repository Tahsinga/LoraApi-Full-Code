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
	// Token: 0x020001ED RID: 493
	[DesignerGenerated]
	public partial class StockMovementValue : UserControl
	{
		// Token: 0x06005701 RID: 22273 RVA: 0x003222DC File Offset: 0x003204DC
		public StockMovementValue()
		{
			base.Load += this.StockMovementValue_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x17001F44 RID: 8004
		// (get) Token: 0x06005704 RID: 22276 RVA: 0x00322B71 File Offset: 0x00320D71
		// (set) Token: 0x06005705 RID: 22277 RVA: 0x00322B7B File Offset: 0x00320D7B
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F45 RID: 8005
		// (get) Token: 0x06005706 RID: 22278 RVA: 0x00322B84 File Offset: 0x00320D84
		// (set) Token: 0x06005707 RID: 22279 RVA: 0x00322B90 File Offset: 0x00320D90
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

		// Token: 0x17001F46 RID: 8006
		// (get) Token: 0x06005708 RID: 22280 RVA: 0x00322BD3 File Offset: 0x00320DD3
		// (set) Token: 0x06005709 RID: 22281 RVA: 0x00322BDD File Offset: 0x00320DDD
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F47 RID: 8007
		// (get) Token: 0x0600570A RID: 22282 RVA: 0x00322BE6 File Offset: 0x00320DE6
		// (set) Token: 0x0600570B RID: 22283 RVA: 0x00322BF0 File Offset: 0x00320DF0
		internal virtual DateTimePicker DTEnddate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F48 RID: 8008
		// (get) Token: 0x0600570C RID: 22284 RVA: 0x00322BF9 File Offset: 0x00320DF9
		// (set) Token: 0x0600570D RID: 22285 RVA: 0x00322C04 File Offset: 0x00320E04
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

		// Token: 0x17001F49 RID: 8009
		// (get) Token: 0x0600570E RID: 22286 RVA: 0x00322C47 File Offset: 0x00320E47
		// (set) Token: 0x0600570F RID: 22287 RVA: 0x00322C51 File Offset: 0x00320E51
		internal virtual DateTimePicker DTStartdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F4A RID: 8010
		// (get) Token: 0x06005710 RID: 22288 RVA: 0x00322C5A File Offset: 0x00320E5A
		// (set) Token: 0x06005711 RID: 22289 RVA: 0x00322C64 File Offset: 0x00320E64
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F4B RID: 8011
		// (get) Token: 0x06005712 RID: 22290 RVA: 0x00322C6D File Offset: 0x00320E6D
		// (set) Token: 0x06005713 RID: 22291 RVA: 0x00322C77 File Offset: 0x00320E77
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F4C RID: 8012
		// (get) Token: 0x06005714 RID: 22292 RVA: 0x00322C80 File Offset: 0x00320E80
		// (set) Token: 0x06005715 RID: 22293 RVA: 0x00322C8A File Offset: 0x00320E8A
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F4D RID: 8013
		// (get) Token: 0x06005716 RID: 22294 RVA: 0x00322C93 File Offset: 0x00320E93
		// (set) Token: 0x06005717 RID: 22295 RVA: 0x00322C9D File Offset: 0x00320E9D
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F4E RID: 8014
		// (get) Token: 0x06005718 RID: 22296 RVA: 0x00322CA6 File Offset: 0x00320EA6
		// (set) Token: 0x06005719 RID: 22297 RVA: 0x00322CB0 File Offset: 0x00320EB0
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F4F RID: 8015
		// (get) Token: 0x0600571A RID: 22298 RVA: 0x00322CB9 File Offset: 0x00320EB9
		// (set) Token: 0x0600571B RID: 22299 RVA: 0x00322CC3 File Offset: 0x00320EC3
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F50 RID: 8016
		// (get) Token: 0x0600571C RID: 22300 RVA: 0x00322CCC File Offset: 0x00320ECC
		// (set) Token: 0x0600571D RID: 22301 RVA: 0x00322CD6 File Offset: 0x00320ED6
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F51 RID: 8017
		// (get) Token: 0x0600571E RID: 22302 RVA: 0x00322CDF File Offset: 0x00320EDF
		// (set) Token: 0x0600571F RID: 22303 RVA: 0x00322CE9 File Offset: 0x00320EE9
		internal virtual ComboBox cboBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F52 RID: 8018
		// (get) Token: 0x06005720 RID: 22304 RVA: 0x00322CF2 File Offset: 0x00320EF2
		// (set) Token: 0x06005721 RID: 22305 RVA: 0x00322CFC File Offset: 0x00320EFC
		internal virtual BindingSource StockMovementByValuePerBranchBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F53 RID: 8019
		// (get) Token: 0x06005722 RID: 22306 RVA: 0x00322D05 File Offset: 0x00320F05
		// (set) Token: 0x06005723 RID: 22307 RVA: 0x00322D0F File Offset: 0x00320F0F
		internal virtual StockMovementByValuePerBranchTableAdapter StockMovementByValuePerBranchTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06005724 RID: 22308 RVA: 0x00322D18 File Offset: 0x00320F18
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

		// Token: 0x06005725 RID: 22309 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label3_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06005726 RID: 22310 RVA: 0x00322DB8 File Offset: 0x00320FB8
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
				this.GetCompanyDetailsTableAdapter.Connection = sqlConnection;
				this.StockMovementByValuePerBranchTableAdapter.Connection = sqlConnection;
				ReportParameter reportParameter = new ReportParameter("startdate", Conversions.ToString(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))));
				ReportParameter reportParameter2 = new ReportParameter("StartDateDesc", this.DTStartdate.Value.ToShortDateString());
				ReportParameter reportParameter3 = new ReportParameter("enddate", Conversions.ToString(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))));
				ReportParameter reportParameter4 = new ReportParameter("EndDateDesc", this.DTEnddate.Value.ToShortDateString());
				ReportParameter reportParameter5 = new ReportParameter("coid", Conversions.ToString(MyProject.Forms.Form1.coid));
				ReportParameter reportParameter6 = new ReportParameter("branch", this.cboBranch.Text);
				ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter2, reportParameter3, reportParameter4, reportParameter5, reportParameter6 };
				this.ReportViewer1.LocalReport.SetParameters(array);
				this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
				this.StockMovementByValuePerBranchTableAdapter.Fill(this.POSDataSet.StockMovementByValuePerBranch, new int?(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text);
				this.ReportViewer1.RefreshReport();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying report. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005727 RID: 22311 RVA: 0x00322FE4 File Offset: 0x003211E4
		private void StockMovementValue_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadBranches();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading page. Detail: " + ex.Message);
			}
		}

		// Token: 0x04002607 RID: 9735
		private string _cnn;
	}
}
