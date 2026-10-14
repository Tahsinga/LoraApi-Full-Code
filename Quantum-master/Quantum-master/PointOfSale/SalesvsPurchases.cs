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
	// Token: 0x020001B4 RID: 436
	[DesignerGenerated]
	public partial class SalesvsPurchases : UserControl
	{
		// Token: 0x06004F35 RID: 20277 RVA: 0x002F75A8 File Offset: 0x002F57A8
		public SalesvsPurchases()
		{
			base.Load += this.SalesvsPurchases_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x17001D13 RID: 7443
		// (get) Token: 0x06004F38 RID: 20280 RVA: 0x002F7E9E File Offset: 0x002F609E
		// (set) Token: 0x06004F39 RID: 20281 RVA: 0x002F7EA8 File Offset: 0x002F60A8
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D14 RID: 7444
		// (get) Token: 0x06004F3A RID: 20282 RVA: 0x002F7EB1 File Offset: 0x002F60B1
		// (set) Token: 0x06004F3B RID: 20283 RVA: 0x002F7EBB File Offset: 0x002F60BB
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D15 RID: 7445
		// (get) Token: 0x06004F3C RID: 20284 RVA: 0x002F7EC4 File Offset: 0x002F60C4
		// (set) Token: 0x06004F3D RID: 20285 RVA: 0x002F7ECE File Offset: 0x002F60CE
		internal virtual ComboBox cboBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D16 RID: 7446
		// (get) Token: 0x06004F3E RID: 20286 RVA: 0x002F7ED7 File Offset: 0x002F60D7
		// (set) Token: 0x06004F3F RID: 20287 RVA: 0x002F7EE1 File Offset: 0x002F60E1
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D17 RID: 7447
		// (get) Token: 0x06004F40 RID: 20288 RVA: 0x002F7EEA File Offset: 0x002F60EA
		// (set) Token: 0x06004F41 RID: 20289 RVA: 0x002F7EF4 File Offset: 0x002F60F4
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

		// Token: 0x17001D18 RID: 7448
		// (get) Token: 0x06004F42 RID: 20290 RVA: 0x002F7F37 File Offset: 0x002F6137
		// (set) Token: 0x06004F43 RID: 20291 RVA: 0x002F7F41 File Offset: 0x002F6141
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D19 RID: 7449
		// (get) Token: 0x06004F44 RID: 20292 RVA: 0x002F7F4A File Offset: 0x002F614A
		// (set) Token: 0x06004F45 RID: 20293 RVA: 0x002F7F54 File Offset: 0x002F6154
		internal virtual DateTimePicker DTEnddate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D1A RID: 7450
		// (get) Token: 0x06004F46 RID: 20294 RVA: 0x002F7F5D File Offset: 0x002F615D
		// (set) Token: 0x06004F47 RID: 20295 RVA: 0x002F7F68 File Offset: 0x002F6168
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

		// Token: 0x17001D1B RID: 7451
		// (get) Token: 0x06004F48 RID: 20296 RVA: 0x002F7FAB File Offset: 0x002F61AB
		// (set) Token: 0x06004F49 RID: 20297 RVA: 0x002F7FB5 File Offset: 0x002F61B5
		internal virtual DateTimePicker DTStartdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D1C RID: 7452
		// (get) Token: 0x06004F4A RID: 20298 RVA: 0x002F7FBE File Offset: 0x002F61BE
		// (set) Token: 0x06004F4B RID: 20299 RVA: 0x002F7FC8 File Offset: 0x002F61C8
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D1D RID: 7453
		// (get) Token: 0x06004F4C RID: 20300 RVA: 0x002F7FD1 File Offset: 0x002F61D1
		// (set) Token: 0x06004F4D RID: 20301 RVA: 0x002F7FDB File Offset: 0x002F61DB
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D1E RID: 7454
		// (get) Token: 0x06004F4E RID: 20302 RVA: 0x002F7FE4 File Offset: 0x002F61E4
		// (set) Token: 0x06004F4F RID: 20303 RVA: 0x002F7FEE File Offset: 0x002F61EE
		internal virtual BindingSource FetchCustomerDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D1F RID: 7455
		// (get) Token: 0x06004F50 RID: 20304 RVA: 0x002F7FF7 File Offset: 0x002F61F7
		// (set) Token: 0x06004F51 RID: 20305 RVA: 0x002F8001 File Offset: 0x002F6201
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D20 RID: 7456
		// (get) Token: 0x06004F52 RID: 20306 RVA: 0x002F800A File Offset: 0x002F620A
		// (set) Token: 0x06004F53 RID: 20307 RVA: 0x002F8014 File Offset: 0x002F6214
		internal virtual BindingSource RptSalesVsPurchasesBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D21 RID: 7457
		// (get) Token: 0x06004F54 RID: 20308 RVA: 0x002F801D File Offset: 0x002F621D
		// (set) Token: 0x06004F55 RID: 20309 RVA: 0x002F8027 File Offset: 0x002F6227
		internal virtual FetchCustomerDetailsTableAdapter FetchCustomerDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D22 RID: 7458
		// (get) Token: 0x06004F56 RID: 20310 RVA: 0x002F8030 File Offset: 0x002F6230
		// (set) Token: 0x06004F57 RID: 20311 RVA: 0x002F803A File Offset: 0x002F623A
		internal virtual RptSalesVsPurchasesTableAdapter RptSalesVsPurchasesTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D23 RID: 7459
		// (get) Token: 0x06004F58 RID: 20312 RVA: 0x002F8043 File Offset: 0x002F6243
		// (set) Token: 0x06004F59 RID: 20313 RVA: 0x002F804D File Offset: 0x002F624D
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D24 RID: 7460
		// (get) Token: 0x06004F5A RID: 20314 RVA: 0x002F8056 File Offset: 0x002F6256
		// (set) Token: 0x06004F5B RID: 20315 RVA: 0x002F8060 File Offset: 0x002F6260
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06004F5C RID: 20316 RVA: 0x002F806C File Offset: 0x002F626C
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

		// Token: 0x06004F5D RID: 20317 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label3_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06004F5E RID: 20318 RVA: 0x002F810C File Offset: 0x002F630C
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
				this.GetCompanyDetailsTableAdapter.Connection = sqlConnection;
				this.RptSalesVsPurchasesTableAdapter.Connection = sqlConnection;
				ReportParameter reportParameter = new ReportParameter("startdate", Conversions.ToString(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))));
				ReportParameter reportParameter2 = new ReportParameter("startdateDesc", this.DTStartdate.Value.ToShortDateString());
				ReportParameter reportParameter3 = new ReportParameter("enddate", Conversions.ToString(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))));
				ReportParameter reportParameter4 = new ReportParameter("enddateDesc", this.DTEnddate.Value.ToShortDateString());
				ReportParameter reportParameter5 = new ReportParameter("coid", Conversions.ToString(MyProject.Forms.Form1.coid));
				ReportParameter reportParameter6 = new ReportParameter("branch", this.cboBranch.Text);
				ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter2, reportParameter3, reportParameter4, reportParameter5, reportParameter6 };
				this.ReportViewer1.LocalReport.SetParameters(array);
				this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
				this.RptSalesVsPurchasesTableAdapter.Fill(this.POSDataSet.RptSalesVsPurchases, new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text, new int?(Convert.ToInt32(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Convert.ToInt32(this.DTEnddate.Value.ToString("yyyyMMdd"))));
				this.ReportViewer1.RefreshReport();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying report. Detail: " + ex.Message);
			}
		}

		// Token: 0x06004F5F RID: 20319 RVA: 0x002F8338 File Offset: 0x002F6538
		private void SalesvsPurchases_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadBranches();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loding form. Detail: " + ex.Message);
			}
		}

		// Token: 0x04002365 RID: 9061
		private string _cnn;
	}
}
