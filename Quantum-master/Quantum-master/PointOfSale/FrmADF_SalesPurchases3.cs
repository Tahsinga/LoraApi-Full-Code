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
	// Token: 0x0200005F RID: 95
	[DesignerGenerated]
	public partial class FrmADF_SalesPurchases3 : Form
	{
		// Token: 0x060013E2 RID: 5090 RVA: 0x000BC91A File Offset: 0x000BAB1A
		public FrmADF_SalesPurchases3()
		{
			base.Load += this.FrmADF_SalesPurchases3_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x060013E5 RID: 5093 RVA: 0x000BD11C File Offset: 0x000BB31C
		// (set) Token: 0x060013E6 RID: 5094 RVA: 0x000BD126 File Offset: 0x000BB326
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x060013E7 RID: 5095 RVA: 0x000BD12F File Offset: 0x000BB32F
		// (set) Token: 0x060013E8 RID: 5096 RVA: 0x000BD139 File Offset: 0x000BB339
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x060013E9 RID: 5097 RVA: 0x000BD142 File Offset: 0x000BB342
		// (set) Token: 0x060013EA RID: 5098 RVA: 0x000BD14C File Offset: 0x000BB34C
		internal virtual BindingSource ADF_Purchases_StockValueBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x060013EB RID: 5099 RVA: 0x000BD155 File Offset: 0x000BB355
		// (set) Token: 0x060013EC RID: 5100 RVA: 0x000BD15F File Offset: 0x000BB35F
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x060013ED RID: 5101 RVA: 0x000BD168 File Offset: 0x000BB368
		// (set) Token: 0x060013EE RID: 5102 RVA: 0x000BD172 File Offset: 0x000BB372
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x060013EF RID: 5103 RVA: 0x000BD17B File Offset: 0x000BB37B
		// (set) Token: 0x060013F0 RID: 5104 RVA: 0x000BD185 File Offset: 0x000BB385
		internal virtual ADF_Purchases_StockValueTableAdapter ADF_Purchases_StockValueTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x060013F1 RID: 5105 RVA: 0x000BD18E File Offset: 0x000BB38E
		// (set) Token: 0x060013F2 RID: 5106 RVA: 0x000BD198 File Offset: 0x000BB398
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x060013F3 RID: 5107 RVA: 0x000BD1A1 File Offset: 0x000BB3A1
		// (set) Token: 0x060013F4 RID: 5108 RVA: 0x000BD1AC File Offset: 0x000BB3AC
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

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x060013F5 RID: 5109 RVA: 0x000BD1EF File Offset: 0x000BB3EF
		// (set) Token: 0x060013F6 RID: 5110 RVA: 0x000BD1F9 File Offset: 0x000BB3F9
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x060013F7 RID: 5111 RVA: 0x000BD202 File Offset: 0x000BB402
		// (set) Token: 0x060013F8 RID: 5112 RVA: 0x000BD20C File Offset: 0x000BB40C
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x060013F9 RID: 5113 RVA: 0x000BD215 File Offset: 0x000BB415
		// (set) Token: 0x060013FA RID: 5114 RVA: 0x000BD21F File Offset: 0x000BB41F
		internal virtual ComboBox cboBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x060013FB RID: 5115 RVA: 0x000BD228 File Offset: 0x000BB428
		// (set) Token: 0x060013FC RID: 5116 RVA: 0x000BD232 File Offset: 0x000BB432
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x060013FD RID: 5117 RVA: 0x000BD23B File Offset: 0x000BB43B
		// (set) Token: 0x060013FE RID: 5118 RVA: 0x000BD245 File Offset: 0x000BB445
		internal virtual DateTimePicker DTEndDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x060013FF RID: 5119 RVA: 0x000BD24E File Offset: 0x000BB44E
		// (set) Token: 0x06001400 RID: 5120 RVA: 0x000BD258 File Offset: 0x000BB458
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x06001401 RID: 5121 RVA: 0x000BD261 File Offset: 0x000BB461
		// (set) Token: 0x06001402 RID: 5122 RVA: 0x000BD26B File Offset: 0x000BB46B
		internal virtual DateTimePicker DTStartdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06001403 RID: 5123 RVA: 0x000BD274 File Offset: 0x000BB474
		private void FrmADF_SalesPurchases3_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadBranches();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying report. Details: " + ex.Message);
			}
		}

		// Token: 0x06001404 RID: 5124 RVA: 0x000BD2C4 File Offset: 0x000BB4C4
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

		// Token: 0x06001405 RID: 5125 RVA: 0x000BD364 File Offset: 0x000BB564
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
				this.GetCompanyDetailsTableAdapter.Connection = sqlConnection;
				this.ADF_Purchases_StockValueTableAdapter.Connection = sqlConnection;
				ReportParameter reportParameter = new ReportParameter("startdatedesc", this.DTStartdate.Value.ToShortDateString());
				ReportParameter reportParameter2 = new ReportParameter("enddatedesc", this.DTEndDate.Value.ToShortDateString());
				ReportParameter reportParameter3 = new ReportParameter("coid", Conversions.ToString(MyProject.Forms.Form1.coid));
				ReportParameter reportParameter4 = new ReportParameter("startdate", Conversions.ToString(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))));
				ReportParameter reportParameter5 = new ReportParameter("enddate", Conversions.ToString(Conversions.ToInteger(this.DTEndDate.Value.ToString("yyyyMMdd"))));
				ReportParameter reportParameter6 = new ReportParameter("branch", this.cboBranch.Text);
				ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter3, reportParameter2, reportParameter5, reportParameter4, reportParameter6 };
				this.ReportViewer1.LocalReport.SetParameters(array);
				this.ADF_Purchases_StockValueTableAdapter.Fill(this.POSDataSet.ADF_Purchases_StockValue, new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text, new int?(Convert.ToInt32(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Convert.ToInt32(this.DTEndDate.Value.ToString("yyyyMMdd"))));
				this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
				this.ReportViewer1.RefreshReport();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying report. Detail: " + ex.Message);
			}
		}

		// Token: 0x04000A29 RID: 2601
		private string _cnn;
	}
}
