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
	// Token: 0x020001EE RID: 494
	[DesignerGenerated]
	public partial class StockMvtBySupplier : UserControl
	{
		// Token: 0x06005728 RID: 22312 RVA: 0x00323034 File Offset: 0x00321234
		public StockMvtBySupplier()
		{
			base.Load += this.StockMovementSales_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x17001F54 RID: 8020
		// (get) Token: 0x0600572B RID: 22315 RVA: 0x00323B15 File Offset: 0x00321D15
		// (set) Token: 0x0600572C RID: 22316 RVA: 0x00323B1F File Offset: 0x00321D1F
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F55 RID: 8021
		// (get) Token: 0x0600572D RID: 22317 RVA: 0x00323B28 File Offset: 0x00321D28
		// (set) Token: 0x0600572E RID: 22318 RVA: 0x00323B32 File Offset: 0x00321D32
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F56 RID: 8022
		// (get) Token: 0x0600572F RID: 22319 RVA: 0x00323B3B File Offset: 0x00321D3B
		// (set) Token: 0x06005730 RID: 22320 RVA: 0x00323B45 File Offset: 0x00321D45
		internal virtual ComboBox cboSupplier
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F57 RID: 8023
		// (get) Token: 0x06005731 RID: 22321 RVA: 0x00323B4E File Offset: 0x00321D4E
		// (set) Token: 0x06005732 RID: 22322 RVA: 0x00323B58 File Offset: 0x00321D58
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F58 RID: 8024
		// (get) Token: 0x06005733 RID: 22323 RVA: 0x00323B61 File Offset: 0x00321D61
		// (set) Token: 0x06005734 RID: 22324 RVA: 0x00323B6B File Offset: 0x00321D6B
		internal virtual ComboBox cboBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F59 RID: 8025
		// (get) Token: 0x06005735 RID: 22325 RVA: 0x00323B74 File Offset: 0x00321D74
		// (set) Token: 0x06005736 RID: 22326 RVA: 0x00323B7E File Offset: 0x00321D7E
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F5A RID: 8026
		// (get) Token: 0x06005737 RID: 22327 RVA: 0x00323B87 File Offset: 0x00321D87
		// (set) Token: 0x06005738 RID: 22328 RVA: 0x00323B94 File Offset: 0x00321D94
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

		// Token: 0x17001F5B RID: 8027
		// (get) Token: 0x06005739 RID: 22329 RVA: 0x00323BD7 File Offset: 0x00321DD7
		// (set) Token: 0x0600573A RID: 22330 RVA: 0x00323BE1 File Offset: 0x00321DE1
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F5C RID: 8028
		// (get) Token: 0x0600573B RID: 22331 RVA: 0x00323BEA File Offset: 0x00321DEA
		// (set) Token: 0x0600573C RID: 22332 RVA: 0x00323BF4 File Offset: 0x00321DF4
		internal virtual DateTimePicker DTEnddate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F5D RID: 8029
		// (get) Token: 0x0600573D RID: 22333 RVA: 0x00323BFD File Offset: 0x00321DFD
		// (set) Token: 0x0600573E RID: 22334 RVA: 0x00323C08 File Offset: 0x00321E08
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

		// Token: 0x17001F5E RID: 8030
		// (get) Token: 0x0600573F RID: 22335 RVA: 0x00323C4B File Offset: 0x00321E4B
		// (set) Token: 0x06005740 RID: 22336 RVA: 0x00323C55 File Offset: 0x00321E55
		internal virtual DateTimePicker DTStartdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F5F RID: 8031
		// (get) Token: 0x06005741 RID: 22337 RVA: 0x00323C5E File Offset: 0x00321E5E
		// (set) Token: 0x06005742 RID: 22338 RVA: 0x00323C68 File Offset: 0x00321E68
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F60 RID: 8032
		// (get) Token: 0x06005743 RID: 22339 RVA: 0x00323C71 File Offset: 0x00321E71
		// (set) Token: 0x06005744 RID: 22340 RVA: 0x00323C7B File Offset: 0x00321E7B
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F61 RID: 8033
		// (get) Token: 0x06005745 RID: 22341 RVA: 0x00323C84 File Offset: 0x00321E84
		// (set) Token: 0x06005746 RID: 22342 RVA: 0x00323C8E File Offset: 0x00321E8E
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F62 RID: 8034
		// (get) Token: 0x06005747 RID: 22343 RVA: 0x00323C97 File Offset: 0x00321E97
		// (set) Token: 0x06005748 RID: 22344 RVA: 0x00323CA1 File Offset: 0x00321EA1
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F63 RID: 8035
		// (get) Token: 0x06005749 RID: 22345 RVA: 0x00323CAA File Offset: 0x00321EAA
		// (set) Token: 0x0600574A RID: 22346 RVA: 0x00323CB4 File Offset: 0x00321EB4
		internal virtual BindingSource StockMovementBySupplierBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F64 RID: 8036
		// (get) Token: 0x0600574B RID: 22347 RVA: 0x00323CBD File Offset: 0x00321EBD
		// (set) Token: 0x0600574C RID: 22348 RVA: 0x00323CC7 File Offset: 0x00321EC7
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F65 RID: 8037
		// (get) Token: 0x0600574D RID: 22349 RVA: 0x00323CD0 File Offset: 0x00321ED0
		// (set) Token: 0x0600574E RID: 22350 RVA: 0x00323CDA File Offset: 0x00321EDA
		internal virtual StockMovementBySupplierTableAdapter StockMovementBySupplierTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x0600574F RID: 22351 RVA: 0x00323CE4 File Offset: 0x00321EE4
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

		// Token: 0x06005750 RID: 22352 RVA: 0x00323D84 File Offset: 0x00321F84
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
				this.GetCompanyDetailsTableAdapter.Connection = sqlConnection;
				this.StockMovementBySupplierTableAdapter.Connection = sqlConnection;
				ReportParameter reportParameter = new ReportParameter("startdate", Conversions.ToString(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))));
				ReportParameter reportParameter2 = new ReportParameter("StartDateDesc", this.DTStartdate.Value.ToShortDateString());
				ReportParameter reportParameter3 = new ReportParameter("enddate", Conversions.ToString(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))));
				ReportParameter reportParameter4 = new ReportParameter("EndDateDesc", this.DTEnddate.Value.ToShortDateString());
				ReportParameter reportParameter5 = new ReportParameter("coid", Conversions.ToString(MyProject.Forms.Form1.coid));
				ReportParameter reportParameter6 = new ReportParameter("branch", this.cboBranch.Text);
				ReportParameter reportParameter7 = new ReportParameter("suppliername", this.cboSupplier.Text);
				ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter2, reportParameter3, reportParameter4, reportParameter5, reportParameter6, reportParameter7 };
				this.ReportViewer1.LocalReport.SetParameters(array);
				this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
				this.StockMovementBySupplierTableAdapter.Fill(this.POSDataSet.StockMovementBySupplier, new int?(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text, (int?)this.cboSupplier.SelectedValue);
				this.ReportViewer1.RefreshReport();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying report. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005751 RID: 22353 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label3_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06005752 RID: 22354 RVA: 0x00323FDC File Offset: 0x003221DC
		private void StockMovementSales_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadBranches();
				this.cboSupplier.DataSource = this.pf.GetSuppliersList(this._cnn);
				this.cboSupplier.ValueMember = "supplierid";
				this.cboSupplier.DisplayMember = "SupplierName";
				this.cboSupplier.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
				this.cboSupplier.AutoCompleteSource = AutoCompleteSource.ListItems;
				this.cboSupplier.SelectedIndex = -1;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading page. Detail: " + ex.Message);
			}
		}

		// Token: 0x0400261B RID: 9755
		private string _cnn;

		// Token: 0x0400261C RID: 9756
		private PublicFunctions pf;
	}
}
