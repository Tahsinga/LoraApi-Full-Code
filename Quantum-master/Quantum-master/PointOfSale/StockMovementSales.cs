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
	// Token: 0x020001EC RID: 492
	[DesignerGenerated]
	public partial class StockMovementSales : UserControl
	{
		// Token: 0x060056DA RID: 22234 RVA: 0x00321498 File Offset: 0x0031F698
		public StockMovementSales()
		{
			base.Load += this.StockMovementSales_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x17001F34 RID: 7988
		// (get) Token: 0x060056DD RID: 22237 RVA: 0x00321E1A File Offset: 0x0032001A
		// (set) Token: 0x060056DE RID: 22238 RVA: 0x00321E24 File Offset: 0x00320024
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F35 RID: 7989
		// (get) Token: 0x060056DF RID: 22239 RVA: 0x00321E2D File Offset: 0x0032002D
		// (set) Token: 0x060056E0 RID: 22240 RVA: 0x00321E37 File Offset: 0x00320037
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F36 RID: 7990
		// (get) Token: 0x060056E1 RID: 22241 RVA: 0x00321E40 File Offset: 0x00320040
		// (set) Token: 0x060056E2 RID: 22242 RVA: 0x00321E4A File Offset: 0x0032004A
		internal virtual ComboBox cboBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F37 RID: 7991
		// (get) Token: 0x060056E3 RID: 22243 RVA: 0x00321E53 File Offset: 0x00320053
		// (set) Token: 0x060056E4 RID: 22244 RVA: 0x00321E5D File Offset: 0x0032005D
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F38 RID: 7992
		// (get) Token: 0x060056E5 RID: 22245 RVA: 0x00321E66 File Offset: 0x00320066
		// (set) Token: 0x060056E6 RID: 22246 RVA: 0x00321E70 File Offset: 0x00320070
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

		// Token: 0x17001F39 RID: 7993
		// (get) Token: 0x060056E7 RID: 22247 RVA: 0x00321EB3 File Offset: 0x003200B3
		// (set) Token: 0x060056E8 RID: 22248 RVA: 0x00321EBD File Offset: 0x003200BD
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F3A RID: 7994
		// (get) Token: 0x060056E9 RID: 22249 RVA: 0x00321EC6 File Offset: 0x003200C6
		// (set) Token: 0x060056EA RID: 22250 RVA: 0x00321ED0 File Offset: 0x003200D0
		internal virtual DateTimePicker DTEnddate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F3B RID: 7995
		// (get) Token: 0x060056EB RID: 22251 RVA: 0x00321ED9 File Offset: 0x003200D9
		// (set) Token: 0x060056EC RID: 22252 RVA: 0x00321EE4 File Offset: 0x003200E4
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

		// Token: 0x17001F3C RID: 7996
		// (get) Token: 0x060056ED RID: 22253 RVA: 0x00321F27 File Offset: 0x00320127
		// (set) Token: 0x060056EE RID: 22254 RVA: 0x00321F31 File Offset: 0x00320131
		internal virtual DateTimePicker DTStartdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F3D RID: 7997
		// (get) Token: 0x060056EF RID: 22255 RVA: 0x00321F3A File Offset: 0x0032013A
		// (set) Token: 0x060056F0 RID: 22256 RVA: 0x00321F44 File Offset: 0x00320144
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F3E RID: 7998
		// (get) Token: 0x060056F1 RID: 22257 RVA: 0x00321F4D File Offset: 0x0032014D
		// (set) Token: 0x060056F2 RID: 22258 RVA: 0x00321F57 File Offset: 0x00320157
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F3F RID: 7999
		// (get) Token: 0x060056F3 RID: 22259 RVA: 0x00321F60 File Offset: 0x00320160
		// (set) Token: 0x060056F4 RID: 22260 RVA: 0x00321F6A File Offset: 0x0032016A
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F40 RID: 8000
		// (get) Token: 0x060056F5 RID: 22261 RVA: 0x00321F73 File Offset: 0x00320173
		// (set) Token: 0x060056F6 RID: 22262 RVA: 0x00321F7D File Offset: 0x0032017D
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F41 RID: 8001
		// (get) Token: 0x060056F7 RID: 22263 RVA: 0x00321F86 File Offset: 0x00320186
		// (set) Token: 0x060056F8 RID: 22264 RVA: 0x00321F90 File Offset: 0x00320190
		internal virtual BindingSource StockMovementBySalesPerBranchBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F42 RID: 8002
		// (get) Token: 0x060056F9 RID: 22265 RVA: 0x00321F99 File Offset: 0x00320199
		// (set) Token: 0x060056FA RID: 22266 RVA: 0x00321FA3 File Offset: 0x003201A3
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F43 RID: 8003
		// (get) Token: 0x060056FB RID: 22267 RVA: 0x00321FAC File Offset: 0x003201AC
		// (set) Token: 0x060056FC RID: 22268 RVA: 0x00321FB6 File Offset: 0x003201B6
		internal virtual StockMovementBySalesPerBranchTableAdapter StockMovementBySalesPerBranchTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060056FD RID: 22269 RVA: 0x00321FC0 File Offset: 0x003201C0
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

		// Token: 0x060056FE RID: 22270 RVA: 0x00322060 File Offset: 0x00320260
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
				this.GetCompanyDetailsTableAdapter.Connection = sqlConnection;
				this.StockMovementBySalesPerBranchTableAdapter.Connection = sqlConnection;
				ReportParameter reportParameter = new ReportParameter("startdate", Conversions.ToString(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))));
				ReportParameter reportParameter2 = new ReportParameter("StartDateDesc", this.DTStartdate.Value.ToShortDateString());
				ReportParameter reportParameter3 = new ReportParameter("enddate", Conversions.ToString(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))));
				ReportParameter reportParameter4 = new ReportParameter("EndDateDesc", this.DTEnddate.Value.ToShortDateString());
				ReportParameter reportParameter5 = new ReportParameter("coid", Conversions.ToString(MyProject.Forms.Form1.coid));
				ReportParameter reportParameter6 = new ReportParameter("branch", this.cboBranch.Text);
				ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter2, reportParameter3, reportParameter4, reportParameter5, reportParameter6 };
				this.ReportViewer1.LocalReport.SetParameters(array);
				this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
				this.StockMovementBySalesPerBranchTableAdapter.Fill(this.POSDataSet.StockMovementBySalesPerBranch, new int?(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text);
				this.ReportViewer1.RefreshReport();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying report. Detail: " + ex.Message);
			}
		}

		// Token: 0x060056FF RID: 22271 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label3_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06005700 RID: 22272 RVA: 0x0032228C File Offset: 0x0032048C
		private void StockMovementSales_Load(object sender, EventArgs e)
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

		// Token: 0x040025F5 RID: 9717
		private string _cnn;
	}
}
