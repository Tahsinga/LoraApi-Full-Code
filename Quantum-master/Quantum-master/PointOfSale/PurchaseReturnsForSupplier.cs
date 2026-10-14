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
	// Token: 0x0200017B RID: 379
	[DesignerGenerated]
	public partial class PurchaseReturnsForSupplier : UserControl
	{
		// Token: 0x060037DC RID: 14300 RVA: 0x001E77C0 File Offset: 0x001E59C0
		public PurchaseReturnsForSupplier()
		{
			base.Load += this.PurchaseReturnsForSupplier_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x1700148E RID: 5262
		// (get) Token: 0x060037DF RID: 14303 RVA: 0x001E8318 File Offset: 0x001E6518
		// (set) Token: 0x060037E0 RID: 14304 RVA: 0x001E8322 File Offset: 0x001E6522
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700148F RID: 5263
		// (get) Token: 0x060037E1 RID: 14305 RVA: 0x001E832B File Offset: 0x001E652B
		// (set) Token: 0x060037E2 RID: 14306 RVA: 0x001E8338 File Offset: 0x001E6538
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

		// Token: 0x17001490 RID: 5264
		// (get) Token: 0x060037E3 RID: 14307 RVA: 0x001E837B File Offset: 0x001E657B
		// (set) Token: 0x060037E4 RID: 14308 RVA: 0x001E8385 File Offset: 0x001E6585
		internal virtual DateTimePicker DTEnddate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001491 RID: 5265
		// (get) Token: 0x060037E5 RID: 14309 RVA: 0x001E838E File Offset: 0x001E658E
		// (set) Token: 0x060037E6 RID: 14310 RVA: 0x001E8398 File Offset: 0x001E6598
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001492 RID: 5266
		// (get) Token: 0x060037E7 RID: 14311 RVA: 0x001E83A1 File Offset: 0x001E65A1
		// (set) Token: 0x060037E8 RID: 14312 RVA: 0x001E83AB File Offset: 0x001E65AB
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001493 RID: 5267
		// (get) Token: 0x060037E9 RID: 14313 RVA: 0x001E83B4 File Offset: 0x001E65B4
		// (set) Token: 0x060037EA RID: 14314 RVA: 0x001E83BE File Offset: 0x001E65BE
		internal virtual ComboBox cboBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001494 RID: 5268
		// (get) Token: 0x060037EB RID: 14315 RVA: 0x001E83C7 File Offset: 0x001E65C7
		// (set) Token: 0x060037EC RID: 14316 RVA: 0x001E83D1 File Offset: 0x001E65D1
		internal virtual DateTimePicker DTStartdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001495 RID: 5269
		// (get) Token: 0x060037ED RID: 14317 RVA: 0x001E83DA File Offset: 0x001E65DA
		// (set) Token: 0x060037EE RID: 14318 RVA: 0x001E83E4 File Offset: 0x001E65E4
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001496 RID: 5270
		// (get) Token: 0x060037EF RID: 14319 RVA: 0x001E83ED File Offset: 0x001E65ED
		// (set) Token: 0x060037F0 RID: 14320 RVA: 0x001E83F7 File Offset: 0x001E65F7
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001497 RID: 5271
		// (get) Token: 0x060037F1 RID: 14321 RVA: 0x001E8400 File Offset: 0x001E6600
		// (set) Token: 0x060037F2 RID: 14322 RVA: 0x001E840A File Offset: 0x001E660A
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001498 RID: 5272
		// (get) Token: 0x060037F3 RID: 14323 RVA: 0x001E8413 File Offset: 0x001E6613
		// (set) Token: 0x060037F4 RID: 14324 RVA: 0x001E8420 File Offset: 0x001E6620
		internal virtual DataGridView DGVPurchases
		{
			[CompilerGenerated]
			get
			{
				return this._DGVPurchases;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DGVPurchases_CellContentClick);
				DataGridView dataGridView = this._DGVPurchases;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick -= dataGridViewCellEventHandler;
				}
				this._DGVPurchases = value;
				dataGridView = this._DGVPurchases;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x17001499 RID: 5273
		// (get) Token: 0x060037F5 RID: 14325 RVA: 0x001E8463 File Offset: 0x001E6663
		// (set) Token: 0x060037F6 RID: 14326 RVA: 0x001E846D File Offset: 0x001E666D
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700149A RID: 5274
		// (get) Token: 0x060037F7 RID: 14327 RVA: 0x001E8476 File Offset: 0x001E6676
		// (set) Token: 0x060037F8 RID: 14328 RVA: 0x001E8480 File Offset: 0x001E6680
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700149B RID: 5275
		// (get) Token: 0x060037F9 RID: 14329 RVA: 0x001E8489 File Offset: 0x001E6689
		// (set) Token: 0x060037FA RID: 14330 RVA: 0x001E8493 File Offset: 0x001E6693
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700149C RID: 5276
		// (get) Token: 0x060037FB RID: 14331 RVA: 0x001E849C File Offset: 0x001E669C
		// (set) Token: 0x060037FC RID: 14332 RVA: 0x001E84A6 File Offset: 0x001E66A6
		internal virtual BindingSource PurchaseReturnsForSupplierBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700149D RID: 5277
		// (get) Token: 0x060037FD RID: 14333 RVA: 0x001E84AF File Offset: 0x001E66AF
		// (set) Token: 0x060037FE RID: 14334 RVA: 0x001E84B9 File Offset: 0x001E66B9
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700149E RID: 5278
		// (get) Token: 0x060037FF RID: 14335 RVA: 0x001E84C2 File Offset: 0x001E66C2
		// (set) Token: 0x06003800 RID: 14336 RVA: 0x001E84CC File Offset: 0x001E66CC
		internal virtual PurchaseReturnsForSupplierTableAdapter PurchaseReturnsForSupplierTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700149F RID: 5279
		// (get) Token: 0x06003801 RID: 14337 RVA: 0x001E84D5 File Offset: 0x001E66D5
		// (set) Token: 0x06003802 RID: 14338 RVA: 0x001E84E0 File Offset: 0x001E66E0
		internal virtual Label Label2
		{
			[CompilerGenerated]
			get
			{
				return this._Label2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label2_Click);
				Label label = this._Label2;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label2 = value;
				label = this._Label2;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x06003803 RID: 14339 RVA: 0x001E8524 File Offset: 0x001E6724
		private void PurchaseReturnsForSupplier_Load(object sender, EventArgs e)
		{
			try
			{
				this.cboBranch.DataSource = this.pf.LoadBranches(this._cnn);
				this.cboBranch.DisplayMember = "branch";
				this.cboBranch.ValueMember = "branch";
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06003804 RID: 14340 RVA: 0x001E85AC File Offset: 0x001E67AC
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "PurchaseReturnHeaders";
				sqlCommand.Parameters.AddWithValue("branch", this.cboBranch.Text);
				sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
				sqlCommand.Parameters.AddWithValue("startdate", Convert.ToInt32(this.DTStartdate.Value.ToString("yyyyMMdd")));
				sqlCommand.Parameters.AddWithValue("enddate", Convert.ToInt32(this.DTEnddate.Value.ToString("yyyyMMdd")));
				DataTable dataTable = new DataTable();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				sqlDataAdapter.Fill(dataTable);
				this.DGVPurchases.DataSource = dataTable;
				DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
				dataGridViewButtonColumn.HeaderText = "View Returns";
				dataGridViewButtonColumn.Text = "View";
				dataGridViewButtonColumn.Name = "View";
				dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
				this.DGVPurchases.Columns.Insert(4, dataGridViewButtonColumn);
				this.DGVPurchases.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				this.DGVPurchases.Columns["trandate"].Visible = false;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying distinct purchase returns. Detail: " + ex.Message);
			}
		}

		// Token: 0x06003805 RID: 14341 RVA: 0x001E8768 File Offset: 0x001E6968
		private void DGVPurchases_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					bool flag2 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "View", false) == 0;
					if (flag2)
					{
						try
						{
							SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
							this.GetCompanyDetailsTableAdapter.Connection = sqlConnection;
							this.PurchaseReturnsForSupplierTableAdapter.Connection = sqlConnection;
							ReportParameter reportParameter = new ReportParameter("trandate", Conversions.ToString(this.DGVPurchases.Rows[e.RowIndex].Cells["trandate"].Value));
							ReportParameter reportParameter2 = new ReportParameter("coid", Conversions.ToString(MyProject.Forms.Form1.coid));
							ReportParameter reportParameter3 = new ReportParameter("branch", this.cboBranch.Text);
							ReportParameter reportParameter4 = new ReportParameter("ref", Conversions.ToString(this.DGVPurchases.Rows[e.RowIndex].Cells["Reason"].Value));
							ReportParameter reportParameter5 = new ReportParameter("Reason", Conversions.ToString(this.DGVPurchases.Rows[e.RowIndex].Cells["Reason"].Value));
							ReportParameter reportParameter6 = new ReportParameter("suppliername", Conversions.ToString(this.DGVPurchases.Rows[e.RowIndex].Cells["Supplier_Name"].Value));
							ReportParameter[] array = new ReportParameter[] { reportParameter2, reportParameter3, reportParameter4, reportParameter6, reportParameter, reportParameter5 };
							this.ReportViewer1.LocalReport.SetParameters(array);
							this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
							this.PurchaseReturnsForSupplierTableAdapter.Fill(this.POSDataSet.PurchaseReturnsForSupplier, Conversions.ToString(this.DGVPurchases.Rows[e.RowIndex].Cells["Reason"].Value), Conversions.ToString(this.DGVPurchases.Rows[e.RowIndex].Cells["Supplier_Name"].Value), new int?(Convert.ToInt32(RuntimeHelpers.GetObjectValue(this.DGVPurchases.Rows[e.RowIndex].Cells["trandate"].Value))), new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text);
							this.ReportViewer1.RefreshReport();
						}
						catch (Exception ex)
						{
							MessageBox.Show("Error displaying report. Detail: " + ex.Message);
						}
					}
				}
			}
			catch (Exception ex2)
			{
				MessageBox.Show("error displaying report. Detail: " + ex2.Message);
			}
		}

		// Token: 0x06003806 RID: 14342 RVA: 0x001E8AE0 File Offset: 0x001E6CE0
		private void Label2_Click(object sender, EventArgs e)
		{
			try
			{
				base.Dispose();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x040017BA RID: 6074
		private string _cnn;

		// Token: 0x040017BB RID: 6075
		private PublicFunctions pf;
	}
}
