using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;
using PointOfSale.POSDataSetTableAdapters;

namespace PointOfSale
{
	// Token: 0x02000030 RID: 48
	[DesignerGenerated]
	public partial class CreateCoupons : UserControl
	{
		// Token: 0x0600098B RID: 2443 RVA: 0x0005ADDB File Offset: 0x00058FDB
		public CreateCoupons()
		{
			base.Load += this.CreateCoupons_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x0600098E RID: 2446 RVA: 0x0005BFBF File Offset: 0x0005A1BF
		// (set) Token: 0x0600098F RID: 2447 RVA: 0x0005BFC9 File Offset: 0x0005A1C9
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000990 RID: 2448 RVA: 0x0005BFD2 File Offset: 0x0005A1D2
		// (set) Token: 0x06000991 RID: 2449 RVA: 0x0005BFDC File Offset: 0x0005A1DC
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000992 RID: 2450 RVA: 0x0005BFE5 File Offset: 0x0005A1E5
		// (set) Token: 0x06000993 RID: 2451 RVA: 0x0005BFEF File Offset: 0x0005A1EF
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000994 RID: 2452 RVA: 0x0005BFF8 File Offset: 0x0005A1F8
		// (set) Token: 0x06000995 RID: 2453 RVA: 0x0005C002 File Offset: 0x0005A202
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000996 RID: 2454 RVA: 0x0005C00B File Offset: 0x0005A20B
		// (set) Token: 0x06000997 RID: 2455 RVA: 0x0005C015 File Offset: 0x0005A215
		internal virtual BindingSource SelectCouponsbyRefNameBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000998 RID: 2456 RVA: 0x0005C01E File Offset: 0x0005A21E
		// (set) Token: 0x06000999 RID: 2457 RVA: 0x0005C028 File Offset: 0x0005A228
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x0600099A RID: 2458 RVA: 0x0005C031 File Offset: 0x0005A231
		// (set) Token: 0x0600099B RID: 2459 RVA: 0x0005C03B File Offset: 0x0005A23B
		internal virtual SelectCouponsbyRefNameTableAdapter SelectCouponsbyRefNameTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x0600099C RID: 2460 RVA: 0x0005C044 File Offset: 0x0005A244
		// (set) Token: 0x0600099D RID: 2461 RVA: 0x0005C050 File Offset: 0x0005A250
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

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x0600099E RID: 2462 RVA: 0x0005C093 File Offset: 0x0005A293
		// (set) Token: 0x0600099F RID: 2463 RVA: 0x0005C09D File Offset: 0x0005A29D
		internal virtual TextBox txtRef
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x060009A0 RID: 2464 RVA: 0x0005C0A6 File Offset: 0x0005A2A6
		// (set) Token: 0x060009A1 RID: 2465 RVA: 0x0005C0B0 File Offset: 0x0005A2B0
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x060009A2 RID: 2466 RVA: 0x0005C0B9 File Offset: 0x0005A2B9
		// (set) Token: 0x060009A3 RID: 2467 RVA: 0x0005C0C3 File Offset: 0x0005A2C3
		internal virtual TextBox txyQty
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x060009A4 RID: 2468 RVA: 0x0005C0CC File Offset: 0x0005A2CC
		// (set) Token: 0x060009A5 RID: 2469 RVA: 0x0005C0D6 File Offset: 0x0005A2D6
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x060009A6 RID: 2470 RVA: 0x0005C0DF File Offset: 0x0005A2DF
		// (set) Token: 0x060009A7 RID: 2471 RVA: 0x0005C0E9 File Offset: 0x0005A2E9
		internal virtual TextBox txtQtyRequired
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x060009A8 RID: 2472 RVA: 0x0005C0F2 File Offset: 0x0005A2F2
		// (set) Token: 0x060009A9 RID: 2473 RVA: 0x0005C0FC File Offset: 0x0005A2FC
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x060009AA RID: 2474 RVA: 0x0005C105 File Offset: 0x0005A305
		// (set) Token: 0x060009AB RID: 2475 RVA: 0x0005C10F File Offset: 0x0005A30F
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x060009AC RID: 2476 RVA: 0x0005C118 File Offset: 0x0005A318
		// (set) Token: 0x060009AD RID: 2477 RVA: 0x0005C122 File Offset: 0x0005A322
		internal virtual TextBox txtPercentage
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x060009AE RID: 2478 RVA: 0x0005C12B File Offset: 0x0005A32B
		// (set) Token: 0x060009AF RID: 2479 RVA: 0x0005C135 File Offset: 0x0005A335
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x060009B0 RID: 2480 RVA: 0x0005C13E File Offset: 0x0005A33E
		// (set) Token: 0x060009B1 RID: 2481 RVA: 0x0005C148 File Offset: 0x0005A348
		internal virtual TextBox txtProductDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x060009B2 RID: 2482 RVA: 0x0005C151 File Offset: 0x0005A351
		// (set) Token: 0x060009B3 RID: 2483 RVA: 0x0005C15B File Offset: 0x0005A35B
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x060009B4 RID: 2484 RVA: 0x0005C164 File Offset: 0x0005A364
		// (set) Token: 0x060009B5 RID: 2485 RVA: 0x0005C170 File Offset: 0x0005A370
		internal virtual DataGridView DGVSearch
		{
			[CompilerGenerated]
			get
			{
				return this._DGVSearch;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.DGVSearch_KeyDown);
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DGVSearch_CellEnter);
				DataGridView dataGridView = this._DGVSearch;
				if (dataGridView != null)
				{
					dataGridView.KeyDown -= keyEventHandler;
					dataGridView.CellEnter -= dataGridViewCellEventHandler;
				}
				this._DGVSearch = value;
				dataGridView = this._DGVSearch;
				if (dataGridView != null)
				{
					dataGridView.KeyDown += keyEventHandler;
					dataGridView.CellEnter += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x060009B6 RID: 2486 RVA: 0x0005C1CE File Offset: 0x0005A3CE
		// (set) Token: 0x060009B7 RID: 2487 RVA: 0x0005C1D8 File Offset: 0x0005A3D8
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x060009B8 RID: 2488 RVA: 0x0005C1E1 File Offset: 0x0005A3E1
		// (set) Token: 0x060009B9 RID: 2489 RVA: 0x0005C1EC File Offset: 0x0005A3EC
		internal virtual Button Button3
		{
			[CompilerGenerated]
			get
			{
				return this._Button3;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button3_Click);
				Button button = this._Button3;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button3 = value;
				button = this._Button3;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x060009BA RID: 2490 RVA: 0x0005C22F File Offset: 0x0005A42F
		// (set) Token: 0x060009BB RID: 2491 RVA: 0x0005C239 File Offset: 0x0005A439
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x060009BC RID: 2492 RVA: 0x0005C242 File Offset: 0x0005A442
		// (set) Token: 0x060009BD RID: 2493 RVA: 0x0005C24C File Offset: 0x0005A44C
		internal virtual TextBox txtsearch
		{
			[CompilerGenerated]
			get
			{
				return this._txtsearch;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.txtsearch_TextChanged);
				TextBox textBox = this._txtsearch;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
				}
				this._txtsearch = value;
				textBox = this._txtsearch;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x060009BE RID: 2494 RVA: 0x0005C28F File Offset: 0x0005A48F
		// (set) Token: 0x060009BF RID: 2495 RVA: 0x0005C299 File Offset: 0x0005A499
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x060009C0 RID: 2496 RVA: 0x0005C2A2 File Offset: 0x0005A4A2
		// (set) Token: 0x060009C1 RID: 2497 RVA: 0x0005C2AC File Offset: 0x0005A4AC
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x060009C2 RID: 2498 RVA: 0x0005C2B5 File Offset: 0x0005A4B5
		// (set) Token: 0x060009C3 RID: 2499 RVA: 0x0005C2BF File Offset: 0x0005A4BF
		internal virtual ComboBox cboCoupons
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x060009C4 RID: 2500 RVA: 0x0005C2C8 File Offset: 0x0005A4C8
		// (set) Token: 0x060009C5 RID: 2501 RVA: 0x0005C2D4 File Offset: 0x0005A4D4
		internal virtual Button Button2
		{
			[CompilerGenerated]
			get
			{
				return this._Button2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button2_Click);
				Button button = this._Button2;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button2 = value;
				button = this._Button2;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x060009C6 RID: 2502 RVA: 0x0005C317 File Offset: 0x0005A517
		// (set) Token: 0x060009C7 RID: 2503 RVA: 0x0005C321 File Offset: 0x0005A521
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x060009C8 RID: 2504 RVA: 0x0005C32A File Offset: 0x0005A52A
		// (set) Token: 0x060009C9 RID: 2505 RVA: 0x0005C334 File Offset: 0x0005A534
		internal virtual TextBox txtproductID
		{
			[CompilerGenerated]
			get
			{
				return this._txtproductID;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.txtproductID_TextChanged);
				TextBox textBox = this._txtproductID;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
				}
				this._txtproductID = value;
				textBox = this._txtproductID;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x060009CA RID: 2506 RVA: 0x0005C377 File Offset: 0x0005A577
		// (set) Token: 0x060009CB RID: 2507 RVA: 0x0005C381 File Offset: 0x0005A581
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x060009CC RID: 2508 RVA: 0x0005C38A File Offset: 0x0005A58A
		// (set) Token: 0x060009CD RID: 2509 RVA: 0x0005C394 File Offset: 0x0005A594
		internal virtual Label Label8
		{
			[CompilerGenerated]
			get
			{
				return this._Label8;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label8_Click);
				Label label = this._Label8;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label8 = value;
				label = this._Label8;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x0005C3D8 File Offset: 0x0005A5D8
		private void Button1_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					DialogResult dialogResult = (DialogResult)Interaction.MsgBox("Are you sure you want to create these coupons?", MsgBoxStyle.YesNo, null);
					bool flag = dialogResult == DialogResult.Yes;
					if (flag)
					{
						bool flag2 = (Operators.CompareString(this.txtProductDesc.Text, "", false) != 0) & (Operators.CompareString(this.txyQty.Text, "", false) != 0);
						if (flag2)
						{
							for (int i = (int)Math.Round(Conversion.Val(this.txyQty.Text)); i > 0; i--)
							{
								this.CreateCoupon((int)Math.Round(Conversion.Val(this.txtproductID.Text)), Conversion.Val(this.txtPercentage.Text), MyProject.Forms.Form1.username, (int)Math.Round(Conversion.Val(DateTime.Today.ToString("yyyyMMdd"))), MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, (int)Math.Round(Conversion.Val(this.txtQtyRequired.Text)), this.txtRef.Text, this.txtProductDesc.Text);
							}
						}
					}
					this.PrintCoupons(this.txtRef.Text);
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error creating coupons. Detail: " + ex.Message);
				}
			}
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x0005C568 File Offset: 0x0005A768
		private void CreateCoupon(int productid, double DiscountPercentage, string createdby, int createdwhen, int coid, string branch, int qtyrequired, string refname, string proddesc)
		{
			SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			DataTable dataTable = new DataTable();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "CreateCoupon";
			sqlCommand.Parameters.AddWithValue("ProductID", productid);
			sqlCommand.Parameters.AddWithValue("DiscountPercentage", DiscountPercentage);
			sqlCommand.Parameters.AddWithValue("CreatedBy", createdby);
			sqlCommand.Parameters.AddWithValue("CreatedWhen", createdwhen);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("qtyrequired", qtyrequired);
			sqlCommand.Parameters.AddWithValue("RefName", refname);
			sqlCommand.Parameters.AddWithValue("ProductDesc", proddesc);
			SqlConnection sqlConnection2 = sqlConnection;
			sqlConnection2.Open();
			sqlCommand.ExecuteNonQuery();
			sqlConnection2.Close();
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x0005C688 File Offset: 0x0005A888
		private void PrintCoupons(string refname)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
				this.GetCompanyDetailsTableAdapter.Connection = sqlConnection;
				this.SelectCouponsbyRefNameTableAdapter.Connection = sqlConnection;
				ReportParameter reportParameter = new ReportParameter("RefName", refname);
				ReportParameter[] array = new ReportParameter[] { reportParameter };
				this.ReportViewer1.LocalReport.SetParameters(array);
				this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
				this.SelectCouponsbyRefNameTableAdapter.Fill(this.POSDataSet.SelectCouponsbyRefName, refname);
				this.ReportViewer1.RefreshReport();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying report. Detail: " + ex.Message);
			}
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x0005C764 File Offset: 0x0005A964
		private void SearchByDesc(string searchtext)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SearchProduct";
			sqlCommand.Parameters.AddWithValue("search", searchtext);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				this.DGVSearch.DataSource = dataTable;
				this.DGVSearch.Columns["ProductID"].Visible = false;
				this.DGVSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			}
			else
			{
				this.lblerror.Text = "No products match your search.";
			}
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x0005C840 File Offset: 0x0005AA40
		private void FetchAllProducts()
		{
			this.lblerror.Text = "...";
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectAllProducts2";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				this.DGVSearch.DataSource = dataTable;
				this.DGVSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				this.DGVSearch.Columns["CatDesc"].Visible = false;
				this.DGVSearch.Columns["Reorder_Level"].Visible = false;
				this.DGVSearch.Columns["Unit_Selling_Price"].Visible = false;
				this.DGVSearch.Columns["Unit_Cost"].Visible = false;
				this.DGVSearch.Columns["ProductID"].Visible = false;
				this.DGVSearch.Columns["ProductCode"].Visible = false;
				this.DGVSearch.Columns["Tax_Percentage"].Visible = false;
				this.DGVSearch.Columns["SpecialPrice"].Visible = false;
			}
			else
			{
				this.lblerror.Text = "No products match your search.";
			}
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x0005C9E0 File Offset: 0x0005ABE0
		private void Button3_Click(object sender, EventArgs e)
		{
			try
			{
				this.FetchAllProducts();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error showing products. Detail: " + ex.Message);
			}
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x0005CA30 File Offset: 0x0005AC30
		private void DGVSearch_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				bool flag = e.KeyCode == Keys.Return;
				if (flag)
				{
					this.txtRef.Focus();
					e.Handled = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Key down error. Ignore");
			}
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x0005CA90 File Offset: 0x0005AC90
		private void DGVSearch_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					int num = Conversions.ToInteger(this.DGVSearch.Rows[e.RowIndex].Cells["ProductID"].Value);
					this.txtproductID.Text = Conversions.ToString(num);
				}
			}
			catch (Exception ex)
			{
				this.lblerror.Text = "Error: " + ex.Message;
			}
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x0005CB54 File Offset: 0x0005AD54
		private void SearchBarCode(int prodtID)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchProductByID";
			sqlCommand.Parameters.AddWithValue("prodtID", prodtID);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				this.txtProductDesc.Text = Conversions.ToString(dataRow["ProductDesc"]);
			}
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x0005CC18 File Offset: 0x0005AE18
		private void txtproductID_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.SearchBarCode(Conversions.ToInteger(this.txtproductID.Text));
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching for product details. Detail: " + ex.Message);
			}
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x0005CC78 File Offset: 0x0005AE78
		private void txtsearch_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.SearchByDesc(this.txtsearch.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching by description. Detail: " + ex.Message);
			}
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label8_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x0005CCD4 File Offset: 0x0005AED4
		private void LoadCoupons()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectAllCoupons";
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			this.cboCoupons.DataSource = dataTable;
			this.cboCoupons.ValueMember = "RefName";
			this.cboCoupons.DisplayMember = "RefName";
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x0005CD50 File Offset: 0x0005AF50
		private void CreateCoupons_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadCoupons();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x0005CDA0 File Offset: 0x0005AFA0
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				this.PrintCoupons(this.cboCoupons.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error reprinting coupons. Detail " + ex.Message);
			}
		}

		// Token: 0x0400049C RID: 1180
		private string _cnn;
	}
}
