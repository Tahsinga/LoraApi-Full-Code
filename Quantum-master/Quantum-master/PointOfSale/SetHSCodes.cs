using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;

namespace PointOfSale
{
	// Token: 0x020001DD RID: 477
	[DesignerGenerated]
	public partial class SetHSCodes : Form
	{
		// Token: 0x06005380 RID: 21376 RVA: 0x00307CF0 File Offset: 0x00305EF0
		public SetHSCodes()
		{
			base.Load += this.SetHSCodes_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x17001DE9 RID: 7657
		// (get) Token: 0x06005383 RID: 21379 RVA: 0x00309197 File Offset: 0x00307397
		// (set) Token: 0x06005384 RID: 21380 RVA: 0x003091A1 File Offset: 0x003073A1
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001DEA RID: 7658
		// (get) Token: 0x06005385 RID: 21381 RVA: 0x003091AA File Offset: 0x003073AA
		// (set) Token: 0x06005386 RID: 21382 RVA: 0x003091B4 File Offset: 0x003073B4
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001DEB RID: 7659
		// (get) Token: 0x06005387 RID: 21383 RVA: 0x003091BD File Offset: 0x003073BD
		// (set) Token: 0x06005388 RID: 21384 RVA: 0x003091C8 File Offset: 0x003073C8
		internal virtual TextBox txtBarCode
		{
			[CompilerGenerated]
			get
			{
				return this._txtBarCode;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.txtBarCode_TextChanged);
				TextBox textBox = this._txtBarCode;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
				}
				this._txtBarCode = value;
				textBox = this._txtBarCode;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17001DEC RID: 7660
		// (get) Token: 0x06005389 RID: 21385 RVA: 0x0030920B File Offset: 0x0030740B
		// (set) Token: 0x0600538A RID: 21386 RVA: 0x00309215 File Offset: 0x00307415
		internal virtual Label Label15
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001DED RID: 7661
		// (get) Token: 0x0600538B RID: 21387 RVA: 0x0030921E File Offset: 0x0030741E
		// (set) Token: 0x0600538C RID: 21388 RVA: 0x00309228 File Offset: 0x00307428
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001DEE RID: 7662
		// (get) Token: 0x0600538D RID: 21389 RVA: 0x00309231 File Offset: 0x00307431
		// (set) Token: 0x0600538E RID: 21390 RVA: 0x0030923B File Offset: 0x0030743B
		internal virtual ComboBox cboCategory
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001DEF RID: 7663
		// (get) Token: 0x0600538F RID: 21391 RVA: 0x00309244 File Offset: 0x00307444
		// (set) Token: 0x06005390 RID: 21392 RVA: 0x0030924E File Offset: 0x0030744E
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001DF0 RID: 7664
		// (get) Token: 0x06005391 RID: 21393 RVA: 0x00309257 File Offset: 0x00307457
		// (set) Token: 0x06005392 RID: 21394 RVA: 0x00309261 File Offset: 0x00307461
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001DF1 RID: 7665
		// (get) Token: 0x06005393 RID: 21395 RVA: 0x0030926A File Offset: 0x0030746A
		// (set) Token: 0x06005394 RID: 21396 RVA: 0x00309274 File Offset: 0x00307474
		internal virtual TextBox txtSearchProductCode
		{
			[CompilerGenerated]
			get
			{
				return this._txtSearchProductCode;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.txtSearchProductCode_TextChanged);
				TextBox textBox = this._txtSearchProductCode;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
				}
				this._txtSearchProductCode = value;
				textBox = this._txtSearchProductCode;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17001DF2 RID: 7666
		// (get) Token: 0x06005395 RID: 21397 RVA: 0x003092B7 File Offset: 0x003074B7
		// (set) Token: 0x06005396 RID: 21398 RVA: 0x003092C1 File Offset: 0x003074C1
		internal virtual TextBox lblDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001DF3 RID: 7667
		// (get) Token: 0x06005397 RID: 21399 RVA: 0x003092CA File Offset: 0x003074CA
		// (set) Token: 0x06005398 RID: 21400 RVA: 0x003092D4 File Offset: 0x003074D4
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001DF4 RID: 7668
		// (get) Token: 0x06005399 RID: 21401 RVA: 0x003092DD File Offset: 0x003074DD
		// (set) Token: 0x0600539A RID: 21402 RVA: 0x003092E7 File Offset: 0x003074E7
		internal virtual Panel Panel4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001DF5 RID: 7669
		// (get) Token: 0x0600539B RID: 21403 RVA: 0x003092F0 File Offset: 0x003074F0
		// (set) Token: 0x0600539C RID: 21404 RVA: 0x003092FC File Offset: 0x003074FC
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

		// Token: 0x17001DF6 RID: 7670
		// (get) Token: 0x0600539D RID: 21405 RVA: 0x0030935A File Offset: 0x0030755A
		// (set) Token: 0x0600539E RID: 21406 RVA: 0x00309364 File Offset: 0x00307564
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001DF7 RID: 7671
		// (get) Token: 0x0600539F RID: 21407 RVA: 0x0030936D File Offset: 0x0030756D
		// (set) Token: 0x060053A0 RID: 21408 RVA: 0x00309378 File Offset: 0x00307578
		internal virtual Button Button4
		{
			[CompilerGenerated]
			get
			{
				return this._Button4;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button4_Click);
				Button button = this._Button4;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button4 = value;
				button = this._Button4;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17001DF8 RID: 7672
		// (get) Token: 0x060053A1 RID: 21409 RVA: 0x003093BB File Offset: 0x003075BB
		// (set) Token: 0x060053A2 RID: 21410 RVA: 0x003093C5 File Offset: 0x003075C5
		internal virtual Label Label16
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001DF9 RID: 7673
		// (get) Token: 0x060053A3 RID: 21411 RVA: 0x003093CE File Offset: 0x003075CE
		// (set) Token: 0x060053A4 RID: 21412 RVA: 0x003093D8 File Offset: 0x003075D8
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

		// Token: 0x17001DFA RID: 7674
		// (get) Token: 0x060053A5 RID: 21413 RVA: 0x0030941B File Offset: 0x0030761B
		// (set) Token: 0x060053A6 RID: 21414 RVA: 0x00309428 File Offset: 0x00307628
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

		// Token: 0x17001DFB RID: 7675
		// (get) Token: 0x060053A7 RID: 21415 RVA: 0x0030946B File Offset: 0x0030766B
		// (set) Token: 0x060053A8 RID: 21416 RVA: 0x00309478 File Offset: 0x00307678
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

		// Token: 0x17001DFC RID: 7676
		// (get) Token: 0x060053A9 RID: 21417 RVA: 0x003094BB File Offset: 0x003076BB
		// (set) Token: 0x060053AA RID: 21418 RVA: 0x003094C8 File Offset: 0x003076C8
		internal virtual ComboBox cboHSCodes
		{
			[CompilerGenerated]
			get
			{
				return this._cboHSCodes;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cboHSCodes_SelectedIndexChanged);
				ComboBox comboBox = this._cboHSCodes;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= eventHandler;
				}
				this._cboHSCodes = value;
				comboBox = this._cboHSCodes;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17001DFD RID: 7677
		// (get) Token: 0x060053AB RID: 21419 RVA: 0x0030950B File Offset: 0x0030770B
		// (set) Token: 0x060053AC RID: 21420 RVA: 0x00309515 File Offset: 0x00307715
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001DFE RID: 7678
		// (get) Token: 0x060053AD RID: 21421 RVA: 0x0030951E File Offset: 0x0030771E
		// (set) Token: 0x060053AE RID: 21422 RVA: 0x00309528 File Offset: 0x00307728
		internal virtual ComboBox cboHSSections
		{
			[CompilerGenerated]
			get
			{
				return this._cboHSSections;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cboHSSections_SelectedIndexChanged);
				ComboBox comboBox = this._cboHSSections;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= eventHandler;
				}
				this._cboHSSections = value;
				comboBox = this._cboHSSections;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17001DFF RID: 7679
		// (get) Token: 0x060053AF RID: 21423 RVA: 0x0030956B File Offset: 0x0030776B
		// (set) Token: 0x060053B0 RID: 21424 RVA: 0x00309575 File Offset: 0x00307775
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E00 RID: 7680
		// (get) Token: 0x060053B1 RID: 21425 RVA: 0x0030957E File Offset: 0x0030777E
		// (set) Token: 0x060053B2 RID: 21426 RVA: 0x00309588 File Offset: 0x00307788
		internal virtual Label lblhscodes
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E01 RID: 7681
		// (get) Token: 0x060053B3 RID: 21427 RVA: 0x00309591 File Offset: 0x00307791
		// (set) Token: 0x060053B4 RID: 21428 RVA: 0x0030959B File Offset: 0x0030779B
		internal virtual Label lbsections
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E02 RID: 7682
		// (get) Token: 0x060053B5 RID: 21429 RVA: 0x003095A4 File Offset: 0x003077A4
		// (set) Token: 0x060053B6 RID: 21430 RVA: 0x003095AE File Offset: 0x003077AE
		internal virtual TextBox txtHSCode
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E03 RID: 7683
		// (get) Token: 0x060053B7 RID: 21431 RVA: 0x003095B7 File Offset: 0x003077B7
		// (set) Token: 0x060053B8 RID: 21432 RVA: 0x003095C1 File Offset: 0x003077C1
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E04 RID: 7684
		// (get) Token: 0x060053B9 RID: 21433 RVA: 0x003095CA File Offset: 0x003077CA
		// (set) Token: 0x060053BA RID: 21434 RVA: 0x003095D4 File Offset: 0x003077D4
		internal virtual Label lblCurrHSCode
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E05 RID: 7685
		// (get) Token: 0x060053BB RID: 21435 RVA: 0x003095DD File Offset: 0x003077DD
		// (set) Token: 0x060053BC RID: 21436 RVA: 0x003095E7 File Offset: 0x003077E7
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E06 RID: 7686
		// (get) Token: 0x060053BD RID: 21437 RVA: 0x003095F0 File Offset: 0x003077F0
		// (set) Token: 0x060053BE RID: 21438 RVA: 0x003095FA File Offset: 0x003077FA
		internal virtual Label Label9
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060053BF RID: 21439 RVA: 0x00309604 File Offset: 0x00307804
		private void SetHSCodes_Load(object sender, EventArgs e)
		{
			try
			{
				base.WindowState = FormWindowState.Maximized;
				this.LoadCategories();
				this.LoadHSSections();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x060053C0 RID: 21440 RVA: 0x00309664 File Offset: 0x00307864
		private void LoadCategories()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchCategories";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			this.cboCategory.DataSource = dataTable;
			this.cboCategory.ValueMember = "CatID";
			this.cboCategory.DisplayMember = "CatDesc";
		}

		// Token: 0x060053C1 RID: 21441 RVA: 0x00309704 File Offset: 0x00307904
		private void txtBarCode_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.FetchProdtDetails(this.txtBarCode.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Detail: " + ex.Message);
			}
		}

		// Token: 0x060053C2 RID: 21442 RVA: 0x00309760 File Offset: 0x00307960
		private void SearchBarCode(int barcode)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SearchProductBarCode";
			sqlCommand.Parameters.AddWithValue("barcode", barcode);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				this.txtSearchProductCode.Text = Conversions.ToString(dataRow["ProductCode"]);
			}
			else
			{
				this.txtSearchProductCode.Text = Conversions.ToString(0);
			}
		}

		// Token: 0x060053C3 RID: 21443 RVA: 0x00309834 File Offset: 0x00307A34
		private void Button4_Click(object sender, EventArgs e)
		{
			try
			{
				this.lblerror.Text = "...";
				this.FetchAllProducts();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Detail: " + ex.Message);
			}
		}

		// Token: 0x060053C4 RID: 21444 RVA: 0x00309894 File Offset: 0x00307A94
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
				this.DGVSearch.Columns["Bin_Location"].Visible = false;
				this.DGVSearch.Columns["Unit_of_Measure"].Visible = false;
			}
			else
			{
				this.lblerror.Text = "No products match your search.";
			}
		}

		// Token: 0x060053C5 RID: 21445 RVA: 0x00309A6C File Offset: 0x00307C6C
		private void DGVSearch_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				bool flag = e.KeyCode == Keys.Return;
				if (flag)
				{
					this.cboCategory.Focus();
					e.Handled = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Key down error. Ignore");
			}
		}

		// Token: 0x060053C6 RID: 21446 RVA: 0x00309ACC File Offset: 0x00307CCC
		private void DGVSearch_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					string text = Conversions.ToString(this.DGVSearch.Rows[e.RowIndex].Cells["ProductCode"].Value);
					this.txtSearchProductCode.Text = text;
				}
			}
			catch (Exception ex)
			{
				this.lblerror.Text = "Error: " + ex.Message;
			}
		}

		// Token: 0x060053C7 RID: 21447 RVA: 0x00309B8C File Offset: 0x00307D8C
		private void txtsearch_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.lblerror.Text = "...";
				this.SearchByDesc(this.txtsearch.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Detail: " + ex.Message);
			}
		}

		// Token: 0x060053C8 RID: 21448 RVA: 0x00309BF8 File Offset: 0x00307DF8
		private void SearchByDesc(string searchtext)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SearchProduct2";
			sqlCommand.Parameters.AddWithValue("search", searchtext);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				this.DGVSearch.DataSource = dataTable;
				this.DGVSearch.Columns["ProductCode"].Visible = false;
				this.DGVSearch.Columns["ProductID"].Visible = false;
				this.DGVSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			}
			else
			{
				this.lblerror.Text = "No products match your search.";
			}
		}

		// Token: 0x060053C9 RID: 21449 RVA: 0x00309CF0 File Offset: 0x00307EF0
		private void txtSearchProductCode_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.FetchProdtDetails(this.txtSearchProductCode.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Detail: " + ex.Message);
			}
		}

		// Token: 0x060053CA RID: 21450 RVA: 0x00309D4C File Offset: 0x00307F4C
		private void FetchProdtDetails(string prodtcode)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchProductByCode";
			sqlCommand.Parameters.AddWithValue("productcode", prodtcode);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				this.lblDesc.Text = dataRow["ProductDesc"].ToString();
				this.CurrentID = Conversions.ToInteger(dataRow["ProductID"]);
				this.CurrentHSCode = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["HSCode"])), "", RuntimeHelpers.GetObjectValue(dataRow["HSCOde"])));
				this.lblCurrHSCode.Text = this.CurrentHSCode;
				this.GetProdtDetails(this.CurrentID);
			}
			else
			{
				this.lblDesc.Text = "Nothing found matching that product ID";
				this.CurrentID = 0;
			}
		}

		// Token: 0x060053CB RID: 21451 RVA: 0x00309E98 File Offset: 0x00308098
		private void GetProdtDetails(int prdtID)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchProductByID";
			sqlCommand.Parameters.AddWithValue("prodtID", prdtID);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				int num2 = Conversions.ToInteger(dataRow["CatID"]);
				string catDesc = this.GetCatDesc(num2);
				int num3 = this.cboCategory.FindStringExact(catDesc);
				this.cboCategory.SelectedIndex = num3;
			}
		}

		// Token: 0x060053CC RID: 21452 RVA: 0x00309F74 File Offset: 0x00308174
		private string GetCatDesc(int catid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetCategoryName";
			sqlCommand.Parameters.AddWithValue("CategoryID", catid);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			string text;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				text = dataRow["CatDesc"].ToString();
			}
			else
			{
				text = "";
			}
			return text;
		}

		// Token: 0x060053CD RID: 21453 RVA: 0x0030A034 File Offset: 0x00308234
		private void UpdateProductCat(int catid, int prodtid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "UpdateProductCategory";
			sqlCommand.Parameters.AddWithValue("ProductID", prodtid);
			sqlCommand.Parameters.AddWithValue("CatID", catid);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x060053CE RID: 21454 RVA: 0x0030A0F4 File Offset: 0x003082F4
		private void LoadHSSections()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = "select distinct Section from HSSectionChapters";
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			int num = sqlDataAdapter.Fill(dataTable);
			this.cboHSSections.DataSource = dataTable;
			this.cboHSSections.ValueMember = "Section";
			this.cboHSSections.DisplayMember = "Section";
			this.lbsections.Text = num.ToString() + " rows.";
		}

		// Token: 0x060053CF RID: 21455 RVA: 0x0030A18C File Offset: 0x0030838C
		private void LoadHSChaptersForSection(string section)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = "select HSCODESFULL,Goods_Description from HSCodes where chapter=(select top 1 chapter from HSSectionChapters where section='" + section + "')";
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			int num = sqlDataAdapter.Fill(dataTable);
			this.cboHSCodes.DataSource = dataTable;
			this.cboHSCodes.ValueMember = "HSCODESFULL";
			this.cboHSCodes.DisplayMember = "GOODS_DESCRIPTION";
			this.lblhscodes.Text = num.ToString() + " rows.";
		}

		// Token: 0x060053D0 RID: 21456 RVA: 0x0030A230 File Offset: 0x00308430
		private void cboHSSections_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.LoadHSChaptersForSection(this.cboHSSections.Text);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060053D1 RID: 21457 RVA: 0x0030A274 File Offset: 0x00308474
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.CurrentID == 0;
				if (flag)
				{
					MessageBox.Show("Please select a product first.");
				}
				else
				{
					bool flag2 = Operators.CompareString(this.txtHSCode.Text, "", false) == 0;
					if (flag2)
					{
						MessageBox.Show("Please select the HS Code first");
					}
					else
					{
						SqlConnection sqlConnection = new SqlConnection(this._cnn);
						SqlCommand sqlCommand = sqlConnection.CreateCommand();
						sqlCommand.CommandType = CommandType.Text;
						sqlCommand.CommandText = string.Concat(new string[]
						{
							"Update products set HSCODE='",
							this.txtHSCode.Text,
							"' where productid=",
							Conversions.ToString(this.CurrentID),
							" and coid=",
							Conversions.ToString(MyProject.Forms.Form1.coid)
						});
						using (sqlConnection)
						{
							sqlConnection.Open();
							sqlCommand.ExecuteNonQuery();
							sqlConnection.Close();
						}
						MessageBox.Show("HS Code for product: " + this.lblDesc.Text + ", has been done successfully.");
						this.clearform();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error setting product HS Code for product. Detail: " + ex.Message);
			}
		}

		// Token: 0x060053D2 RID: 21458 RVA: 0x0030A3F8 File Offset: 0x003085F8
		private void cboHSCodes_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.txtHSCode.Text = this.cboHSCodes.SelectedValue.ToString();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060053D3 RID: 21459 RVA: 0x0030A448 File Offset: 0x00308648
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.CurrentID == 0;
				if (flag)
				{
					MessageBox.Show("Please select a product first.");
				}
				else
				{
					bool flag2 = Operators.CompareString(this.txtHSCode.Text, "", false) == 0;
					if (flag2)
					{
						MessageBox.Show("Please select the HS Code first");
					}
					else
					{
						bool flag3 = Operators.CompareString(this.cboCategory.Text, "", false) == 0;
						if (flag3)
						{
							MessageBox.Show("Error with blank category name- please fix.");
						}
						else
						{
							SqlConnection sqlConnection = new SqlConnection(this._cnn);
							SqlCommand sqlCommand = sqlConnection.CreateCommand();
							sqlCommand.CommandType = CommandType.Text;
							sqlCommand.CommandText = string.Concat(new string[]
							{
								"Update products set HSCODE=",
								this.txtHSCode.Text,
								" where coid=",
								Conversions.ToString(MyProject.Forms.Form1.coid),
								" and catid=(select catid from products where coid=",
								Conversions.ToString(MyProject.Forms.Form1.coid),
								" and productid=",
								Conversions.ToString(this.CurrentID),
								")"
							});
							using (sqlConnection)
							{
								sqlConnection.Open();
								sqlCommand.ExecuteNonQuery();
								sqlConnection.Close();
							}
							MessageBox.Show("Products in category: " + this.cboCategory.Text + ", have been given the same HS Code: " + this.txtHSCode.Text);
							this.clearform();
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error setting product HS Code for category.");
			}
		}

		// Token: 0x060053D4 RID: 21460 RVA: 0x0030A620 File Offset: 0x00308820
		private void clearform()
		{
			this.txtHSCode.Text = "";
			this.CurrentID = 0;
			this.cboHSCodes.SelectedIndex = -1;
			this.lblDesc.Text = "";
			this.txtsearch.Text = "";
		}

		// Token: 0x0400248C RID: 9356
		private string _cnn;

		// Token: 0x0400248D RID: 9357
		private int CurrentID;

		// Token: 0x0400248E RID: 9358
		private string CurrentHSCode;
	}
}
