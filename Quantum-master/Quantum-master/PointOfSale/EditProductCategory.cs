using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;

namespace PointOfSale
{
	// Token: 0x0200004E RID: 78
	[DesignerGenerated]
	public partial class EditProductCategory : Form
	{
		// Token: 0x06001084 RID: 4228 RVA: 0x0009C224 File Offset: 0x0009A424
		public EditProductCategory()
		{
			base.Load += this.EditProductCategory_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06001087 RID: 4231 RVA: 0x0009CF5F File Offset: 0x0009B15F
		// (set) Token: 0x06001088 RID: 4232 RVA: 0x0009CF69 File Offset: 0x0009B169
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06001089 RID: 4233 RVA: 0x0009CF72 File Offset: 0x0009B172
		// (set) Token: 0x0600108A RID: 4234 RVA: 0x0009CF7C File Offset: 0x0009B17C
		internal virtual Panel Panel4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x0600108B RID: 4235 RVA: 0x0009CF85 File Offset: 0x0009B185
		// (set) Token: 0x0600108C RID: 4236 RVA: 0x0009CF90 File Offset: 0x0009B190
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

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x0600108D RID: 4237 RVA: 0x0009CFEE File Offset: 0x0009B1EE
		// (set) Token: 0x0600108E RID: 4238 RVA: 0x0009CFF8 File Offset: 0x0009B1F8
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x0600108F RID: 4239 RVA: 0x0009D001 File Offset: 0x0009B201
		// (set) Token: 0x06001090 RID: 4240 RVA: 0x0009D00C File Offset: 0x0009B20C
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

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06001091 RID: 4241 RVA: 0x0009D04F File Offset: 0x0009B24F
		// (set) Token: 0x06001092 RID: 4242 RVA: 0x0009D059 File Offset: 0x0009B259
		internal virtual Label Label16
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06001093 RID: 4243 RVA: 0x0009D062 File Offset: 0x0009B262
		// (set) Token: 0x06001094 RID: 4244 RVA: 0x0009D06C File Offset: 0x0009B26C
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

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06001095 RID: 4245 RVA: 0x0009D0AF File Offset: 0x0009B2AF
		// (set) Token: 0x06001096 RID: 4246 RVA: 0x0009D0B9 File Offset: 0x0009B2B9
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06001097 RID: 4247 RVA: 0x0009D0C2 File Offset: 0x0009B2C2
		// (set) Token: 0x06001098 RID: 4248 RVA: 0x0009D0CC File Offset: 0x0009B2CC
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06001099 RID: 4249 RVA: 0x0009D0D5 File Offset: 0x0009B2D5
		// (set) Token: 0x0600109A RID: 4250 RVA: 0x0009D0E0 File Offset: 0x0009B2E0
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

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x0600109B RID: 4251 RVA: 0x0009D123 File Offset: 0x0009B323
		// (set) Token: 0x0600109C RID: 4252 RVA: 0x0009D12D File Offset: 0x0009B32D
		internal virtual TextBox lblDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x0600109D RID: 4253 RVA: 0x0009D136 File Offset: 0x0009B336
		// (set) Token: 0x0600109E RID: 4254 RVA: 0x0009D140 File Offset: 0x0009B340
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x0600109F RID: 4255 RVA: 0x0009D149 File Offset: 0x0009B349
		// (set) Token: 0x060010A0 RID: 4256 RVA: 0x0009D153 File Offset: 0x0009B353
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x060010A1 RID: 4257 RVA: 0x0009D15C File Offset: 0x0009B35C
		// (set) Token: 0x060010A2 RID: 4258 RVA: 0x0009D166 File Offset: 0x0009B366
		internal virtual ComboBox cboCategory
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x060010A3 RID: 4259 RVA: 0x0009D16F File Offset: 0x0009B36F
		// (set) Token: 0x060010A4 RID: 4260 RVA: 0x0009D17C File Offset: 0x0009B37C
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

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x060010A5 RID: 4261 RVA: 0x0009D1BF File Offset: 0x0009B3BF
		// (set) Token: 0x060010A6 RID: 4262 RVA: 0x0009D1C9 File Offset: 0x0009B3C9
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x060010A7 RID: 4263 RVA: 0x0009D1D2 File Offset: 0x0009B3D2
		// (set) Token: 0x060010A8 RID: 4264 RVA: 0x0009D1DC File Offset: 0x0009B3DC
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

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x060010A9 RID: 4265 RVA: 0x0009D21F File Offset: 0x0009B41F
		// (set) Token: 0x060010AA RID: 4266 RVA: 0x0009D229 File Offset: 0x0009B429
		internal virtual Label Label15
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x060010AB RID: 4267 RVA: 0x0009D232 File Offset: 0x0009B432
		// (set) Token: 0x060010AC RID: 4268 RVA: 0x0009D23C File Offset: 0x0009B43C
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x060010AD RID: 4269 RVA: 0x0009D245 File Offset: 0x0009B445
		// (set) Token: 0x060010AE RID: 4270 RVA: 0x0009D24F File Offset: 0x0009B44F
		internal virtual ComboBox cboNewCat
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060010AF RID: 4271 RVA: 0x0009D258 File Offset: 0x0009B458
		private void EditProductCategory_Load(object sender, EventArgs e)
		{
			try
			{
				bool isbranch = MyProject.Forms.Form1.isbranch;
				if (isbranch)
				{
					MessageBox.Show("This is a branch computer and cannot edit products. Product details should be changed at HQ.");
					base.Dispose();
				}
				this.LoadCategories();
				this.LoadCategoriesNew();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x060010B0 RID: 4272 RVA: 0x0009D2D4 File Offset: 0x0009B4D4
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

		// Token: 0x060010B1 RID: 4273 RVA: 0x0009D374 File Offset: 0x0009B574
		private void LoadCategoriesNew()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchCategories";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			this.cboNewCat.DataSource = dataTable;
			this.cboNewCat.ValueMember = "CatID";
			this.cboNewCat.DisplayMember = "CatDesc";
		}

		// Token: 0x060010B2 RID: 4274 RVA: 0x0009D414 File Offset: 0x0009B614
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

		// Token: 0x060010B3 RID: 4275 RVA: 0x0009D470 File Offset: 0x0009B670
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

		// Token: 0x060010B4 RID: 4276 RVA: 0x0009D544 File Offset: 0x0009B744
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

		// Token: 0x060010B5 RID: 4277 RVA: 0x0009D5A4 File Offset: 0x0009B7A4
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

		// Token: 0x060010B6 RID: 4278 RVA: 0x0009D744 File Offset: 0x0009B944
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

		// Token: 0x060010B7 RID: 4279 RVA: 0x0009D7A4 File Offset: 0x0009B9A4
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

		// Token: 0x060010B8 RID: 4280 RVA: 0x0009D864 File Offset: 0x0009BA64
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

		// Token: 0x060010B9 RID: 4281 RVA: 0x0009D8D0 File Offset: 0x0009BAD0
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

		// Token: 0x060010BA RID: 4282 RVA: 0x0009D9C8 File Offset: 0x0009BBC8
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

		// Token: 0x060010BB RID: 4283 RVA: 0x0009DA24 File Offset: 0x0009BC24
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
				this.GetProdtDetails(this.CurrentID);
			}
			else
			{
				this.lblDesc.Text = "Nothing found matching that product ID";
				this.CurrentID = 0;
			}
		}

		// Token: 0x060010BC RID: 4284 RVA: 0x0009DB20 File Offset: 0x0009BD20
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

		// Token: 0x060010BD RID: 4285 RVA: 0x0009DBFC File Offset: 0x0009BDFC
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

		// Token: 0x060010BE RID: 4286 RVA: 0x0009DCBC File Offset: 0x0009BEBC
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.cboNewCat.Text, "", false) != 0;
				if (flag)
				{
					this.UpdateProductCat(Conversions.ToInteger(this.cboNewCat.SelectedValue), this.CurrentID);
					MessageBox.Show("Product category updated.");
				}
				else
				{
					MessageBox.Show("Please select the new category first.");
					this.cboNewCat.Focus();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving changes. Detail: " + ex.Message);
			}
		}

		// Token: 0x060010BF RID: 4287 RVA: 0x0009DD64 File Offset: 0x0009BF64
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

		// Token: 0x040007F4 RID: 2036
		private string _cnn;

		// Token: 0x040007F5 RID: 2037
		private int CurrentID;
	}
}
