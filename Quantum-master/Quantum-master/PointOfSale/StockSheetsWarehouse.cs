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
	// Token: 0x020001F1 RID: 497
	[DesignerGenerated]
	public partial class StockSheetsWarehouse : Form
	{
		// Token: 0x060057BE RID: 22462 RVA: 0x00326E0C File Offset: 0x0032500C
		public StockSheetsWarehouse()
		{
			base.Load += this.StockSheetsWarehouse_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x17001F8F RID: 8079
		// (get) Token: 0x060057C1 RID: 22465 RVA: 0x00327946 File Offset: 0x00325B46
		// (set) Token: 0x060057C2 RID: 22466 RVA: 0x00327950 File Offset: 0x00325B50
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F90 RID: 8080
		// (get) Token: 0x060057C3 RID: 22467 RVA: 0x00327959 File Offset: 0x00325B59
		// (set) Token: 0x060057C4 RID: 22468 RVA: 0x00327963 File Offset: 0x00325B63
		internal virtual CheckBox chkWithFigures
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F91 RID: 8081
		// (get) Token: 0x060057C5 RID: 22469 RVA: 0x0032796C File Offset: 0x00325B6C
		// (set) Token: 0x060057C6 RID: 22470 RVA: 0x00327976 File Offset: 0x00325B76
		internal virtual CheckBox chkBins
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F92 RID: 8082
		// (get) Token: 0x060057C7 RID: 22471 RVA: 0x0032797F File Offset: 0x00325B7F
		// (set) Token: 0x060057C8 RID: 22472 RVA: 0x00327989 File Offset: 0x00325B89
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F93 RID: 8083
		// (get) Token: 0x060057C9 RID: 22473 RVA: 0x00327992 File Offset: 0x00325B92
		// (set) Token: 0x060057CA RID: 22474 RVA: 0x0032799C File Offset: 0x00325B9C
		internal virtual ComboBox cbobins
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F94 RID: 8084
		// (get) Token: 0x060057CB RID: 22475 RVA: 0x003279A5 File Offset: 0x00325BA5
		// (set) Token: 0x060057CC RID: 22476 RVA: 0x003279AF File Offset: 0x00325BAF
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F95 RID: 8085
		// (get) Token: 0x060057CD RID: 22477 RVA: 0x003279B8 File Offset: 0x00325BB8
		// (set) Token: 0x060057CE RID: 22478 RVA: 0x003279C2 File Offset: 0x00325BC2
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F96 RID: 8086
		// (get) Token: 0x060057CF RID: 22479 RVA: 0x003279CB File Offset: 0x00325BCB
		// (set) Token: 0x060057D0 RID: 22480 RVA: 0x003279D5 File Offset: 0x00325BD5
		internal virtual ComboBox cboBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F97 RID: 8087
		// (get) Token: 0x060057D1 RID: 22481 RVA: 0x003279DE File Offset: 0x00325BDE
		// (set) Token: 0x060057D2 RID: 22482 RVA: 0x003279E8 File Offset: 0x00325BE8
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F98 RID: 8088
		// (get) Token: 0x060057D3 RID: 22483 RVA: 0x003279F1 File Offset: 0x00325BF1
		// (set) Token: 0x060057D4 RID: 22484 RVA: 0x003279FC File Offset: 0x00325BFC
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

		// Token: 0x17001F99 RID: 8089
		// (get) Token: 0x060057D5 RID: 22485 RVA: 0x00327A3F File Offset: 0x00325C3F
		// (set) Token: 0x060057D6 RID: 22486 RVA: 0x00327A49 File Offset: 0x00325C49
		internal virtual DateTimePicker DTStartdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F9A RID: 8090
		// (get) Token: 0x060057D7 RID: 22487 RVA: 0x00327A52 File Offset: 0x00325C52
		// (set) Token: 0x060057D8 RID: 22488 RVA: 0x00327A5C File Offset: 0x00325C5C
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F9B RID: 8091
		// (get) Token: 0x060057D9 RID: 22489 RVA: 0x00327A65 File Offset: 0x00325C65
		// (set) Token: 0x060057DA RID: 22490 RVA: 0x00327A6F File Offset: 0x00325C6F
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F9C RID: 8092
		// (get) Token: 0x060057DB RID: 22491 RVA: 0x00327A78 File Offset: 0x00325C78
		// (set) Token: 0x060057DC RID: 22492 RVA: 0x00327A82 File Offset: 0x00325C82
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F9D RID: 8093
		// (get) Token: 0x060057DD RID: 22493 RVA: 0x00327A8B File Offset: 0x00325C8B
		// (set) Token: 0x060057DE RID: 22494 RVA: 0x00327A95 File Offset: 0x00325C95
		internal virtual BindingSource CurrentStockLevelsWarehouseReportBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F9E RID: 8094
		// (get) Token: 0x060057DF RID: 22495 RVA: 0x00327A9E File Offset: 0x00325C9E
		// (set) Token: 0x060057E0 RID: 22496 RVA: 0x00327AA8 File Offset: 0x00325CA8
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F9F RID: 8095
		// (get) Token: 0x060057E1 RID: 22497 RVA: 0x00327AB1 File Offset: 0x00325CB1
		// (set) Token: 0x060057E2 RID: 22498 RVA: 0x00327ABB File Offset: 0x00325CBB
		internal virtual CurrentStockLevelsWarehouseReportTableAdapter CurrentStockLevelsWarehouseReportTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FA0 RID: 8096
		// (get) Token: 0x060057E3 RID: 22499 RVA: 0x00327AC4 File Offset: 0x00325CC4
		// (set) Token: 0x060057E4 RID: 22500 RVA: 0x00327ACE File Offset: 0x00325CCE
		internal virtual CheckBox chkShowAll
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060057E5 RID: 22501 RVA: 0x00327AD8 File Offset: 0x00325CD8
		private void StockSheetsWarehouse_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadBranches();
				this.cbobins.DataSource = this.GetBinLocs();
				this.cbobins.DisplayMember = "BinLocation";
				this.cbobins.ValueMember = "BinLocation";
				this.cbobins.SelectedIndex = -1;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x060057E6 RID: 22502 RVA: 0x00327B68 File Offset: 0x00325D68
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

		// Token: 0x060057E7 RID: 22503 RVA: 0x00327C2C File Offset: 0x00325E2C
		private DataTable GetBinLocs()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetDistinctBinLocs";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x060057E8 RID: 22504 RVA: 0x00327CA4 File Offset: 0x00325EA4
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
				this.GetCompanyDetailsTableAdapter.Connection = sqlConnection;
				this.CurrentStockLevelsWarehouseReportTableAdapter.Connection = sqlConnection;
				ReportParameter reportParameter = new ReportParameter("StartDateDesc", this.DTStartdate.Value.ToShortDateString());
				ReportParameter reportParameter2 = new ReportParameter("coid", Conversions.ToString(MyProject.Forms.Form1.coid));
				ReportParameter reportParameter3 = new ReportParameter("branch", this.cboBranch.Text);
				ReportParameter reportParameter4 = new ReportParameter("theday", Conversions.ToString(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))));
				bool @checked = this.chkWithFigures.Checked;
				int num;
				if (@checked)
				{
					num = 1;
				}
				else
				{
					num = 0;
				}
				ReportParameter reportParameter5 = new ReportParameter("WithFigures", Conversions.ToString(num));
				bool checked2 = this.chkBins.Checked;
				if (checked2)
				{
					string text = "All Bin Locations";
					ReportParameter reportParameter6 = new ReportParameter("binlocdesc", text);
					ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter2, reportParameter3, reportParameter4, reportParameter6, reportParameter5 };
					this.ReportViewer1.LocalReport.SetParameters(array);
				}
				else
				{
					string text2 = this.cbobins.SelectedValue.ToString();
					ReportParameter reportParameter7 = new ReportParameter("binloc", text2);
					string text = this.cbobins.SelectedValue.ToString();
					ReportParameter reportParameter8 = new ReportParameter("binlocdesc", text);
					ReportParameter[] array2 = new ReportParameter[] { reportParameter, reportParameter2, reportParameter3, reportParameter4, reportParameter7, reportParameter8, reportParameter5 };
					this.ReportViewer1.LocalReport.SetParameters(array2);
				}
				this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
				bool checked3 = this.chkShowAll.Checked;
				int num2;
				if (checked3)
				{
					num2 = 1;
				}
				else
				{
					num2 = 0;
				}
				string text3 = null;
				bool checked4 = this.chkBins.Checked;
				if (!checked4)
				{
					bool flag = Operators.CompareString(this.cbobins.Text, "", false) == 0;
					if (flag)
					{
						MessageBox.Show("Please select a bin location.");
						return;
					}
					text3 = this.cbobins.Text;
				}
				this.CurrentStockLevelsWarehouseReportTableAdapter.Fill(this.POSDataSet.CurrentStockLevelsWarehouseReport, new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text, text3, new int?(num2));
				this.ReportViewer1.RefreshReport();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying report. Detail: " + ex.Message);
			}
		}

		// Token: 0x0400265F RID: 9823
		private string _cnn;
	}
}
