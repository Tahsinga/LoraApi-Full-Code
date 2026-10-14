using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;

namespace PointOfSale
{
	// Token: 0x020001DA RID: 474
	[DesignerGenerated]
	public partial class SetCategorySideMenus : Form
	{
		// Token: 0x0600530F RID: 21263 RVA: 0x003049FA File Offset: 0x00302BFA
		public SetCategorySideMenus()
		{
			base.Load += this.SetCategorySideMenus_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.currentID = 0;
			this.InitializeComponent();
		}

		// Token: 0x17001DBF RID: 7615
		// (get) Token: 0x06005312 RID: 21266 RVA: 0x00305663 File Offset: 0x00303863
		// (set) Token: 0x06005313 RID: 21267 RVA: 0x0030566D File Offset: 0x0030386D
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001DC0 RID: 7616
		// (get) Token: 0x06005314 RID: 21268 RVA: 0x00305676 File Offset: 0x00303876
		// (set) Token: 0x06005315 RID: 21269 RVA: 0x00305680 File Offset: 0x00303880
		internal virtual DataGridView DataGridView1
		{
			[CompilerGenerated]
			get
			{
				return this._DataGridView1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
				DataGridView dataGridView = this._DataGridView1;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick -= dataGridViewCellEventHandler;
				}
				this._DataGridView1 = value;
				dataGridView = this._DataGridView1;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x17001DC1 RID: 7617
		// (get) Token: 0x06005316 RID: 21270 RVA: 0x003056C3 File Offset: 0x003038C3
		// (set) Token: 0x06005317 RID: 21271 RVA: 0x003056CD File Offset: 0x003038CD
		internal virtual Panel Panel4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001DC2 RID: 7618
		// (get) Token: 0x06005318 RID: 21272 RVA: 0x003056D6 File Offset: 0x003038D6
		// (set) Token: 0x06005319 RID: 21273 RVA: 0x003056E0 File Offset: 0x003038E0
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
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DGVSearch_CellEnter);
				DataGridView dataGridView = this._DGVSearch;
				if (dataGridView != null)
				{
					dataGridView.CellEnter -= dataGridViewCellEventHandler;
				}
				this._DGVSearch = value;
				dataGridView = this._DGVSearch;
				if (dataGridView != null)
				{
					dataGridView.CellEnter += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x17001DC3 RID: 7619
		// (get) Token: 0x0600531A RID: 21274 RVA: 0x00305723 File Offset: 0x00303923
		// (set) Token: 0x0600531B RID: 21275 RVA: 0x0030572D File Offset: 0x0030392D
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001DC4 RID: 7620
		// (get) Token: 0x0600531C RID: 21276 RVA: 0x00305736 File Offset: 0x00303936
		// (set) Token: 0x0600531D RID: 21277 RVA: 0x00305740 File Offset: 0x00303940
		internal virtual Label Label10
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001DC5 RID: 7621
		// (get) Token: 0x0600531E RID: 21278 RVA: 0x00305749 File Offset: 0x00303949
		// (set) Token: 0x0600531F RID: 21279 RVA: 0x00305754 File Offset: 0x00303954
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

		// Token: 0x17001DC6 RID: 7622
		// (get) Token: 0x06005320 RID: 21280 RVA: 0x00305797 File Offset: 0x00303997
		// (set) Token: 0x06005321 RID: 21281 RVA: 0x003057A1 File Offset: 0x003039A1
		internal virtual Label Label16
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001DC7 RID: 7623
		// (get) Token: 0x06005322 RID: 21282 RVA: 0x003057AA File Offset: 0x003039AA
		// (set) Token: 0x06005323 RID: 21283 RVA: 0x003057B4 File Offset: 0x003039B4
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

		// Token: 0x17001DC8 RID: 7624
		// (get) Token: 0x06005324 RID: 21284 RVA: 0x003057F7 File Offset: 0x003039F7
		// (set) Token: 0x06005325 RID: 21285 RVA: 0x00305801 File Offset: 0x00303A01
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001DC9 RID: 7625
		// (get) Token: 0x06005326 RID: 21286 RVA: 0x0030580A File Offset: 0x00303A0A
		// (set) Token: 0x06005327 RID: 21287 RVA: 0x00305814 File Offset: 0x00303A14
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

		// Token: 0x17001DCA RID: 7626
		// (get) Token: 0x06005328 RID: 21288 RVA: 0x00305857 File Offset: 0x00303A57
		// (set) Token: 0x06005329 RID: 21289 RVA: 0x00305861 File Offset: 0x00303A61
		internal virtual TextBox lblDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001DCB RID: 7627
		// (get) Token: 0x0600532A RID: 21290 RVA: 0x0030586A File Offset: 0x00303A6A
		// (set) Token: 0x0600532B RID: 21291 RVA: 0x00305874 File Offset: 0x00303A74
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

		// Token: 0x17001DCC RID: 7628
		// (get) Token: 0x0600532C RID: 21292 RVA: 0x003058B7 File Offset: 0x00303AB7
		// (set) Token: 0x0600532D RID: 21293 RVA: 0x003058C1 File Offset: 0x00303AC1
		internal virtual Label Label15
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001DCD RID: 7629
		// (get) Token: 0x0600532E RID: 21294 RVA: 0x003058CA File Offset: 0x00303ACA
		// (set) Token: 0x0600532F RID: 21295 RVA: 0x003058D4 File Offset: 0x00303AD4
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

		// Token: 0x17001DCE RID: 7630
		// (get) Token: 0x06005330 RID: 21296 RVA: 0x00305917 File Offset: 0x00303B17
		// (set) Token: 0x06005331 RID: 21297 RVA: 0x00305921 File Offset: 0x00303B21
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001DCF RID: 7631
		// (get) Token: 0x06005332 RID: 21298 RVA: 0x0030592A File Offset: 0x00303B2A
		// (set) Token: 0x06005333 RID: 21299 RVA: 0x00305934 File Offset: 0x00303B34
		internal virtual ComboBox ComboBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06005334 RID: 21300 RVA: 0x00305940 File Offset: 0x00303B40
		private void txtsearch_TextChanged(object sender, EventArgs e)
		{
			try
			{
				bool flag = MyProject.Forms.Form1.OnlineSearchOptimised == 0;
				if (flag)
				{
					this.lblerror.Text = "...";
					this.SearchByDescAdvanced(this.txtsearch.Text);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005335 RID: 21301 RVA: 0x003059C8 File Offset: 0x00303BC8
		private void SearchByDescAdvanced(string searchtext)
		{
			string[] array = searchtext.Split(new char[] { ' ' });
			int num = 1;
			DataTable dataTable = new DataTable();
			checked
			{
				foreach (string text in array)
				{
					bool flag = num == 1;
					if (flag)
					{
						dataTable = this.searchDB(text);
					}
					else
					{
						DataTable dataTable2 = new DataTable();
						dataTable2 = (DataTable)this.searchDat(dataTable, "ProductDesc", text);
						dataTable = dataTable2;
					}
					num++;
				}
				bool flag2 = dataTable.Rows.Count > 0;
				if (flag2)
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
		}

		// Token: 0x06005336 RID: 21302 RVA: 0x00305AD4 File Offset: 0x00303CD4
		private object searchDat(DataTable dt, string column, string value)
		{
			SetCategorySideMenus._Closure$__76-0 CS$<>8__locals1 = new SetCategorySideMenus._Closure$__76-0(CS$<>8__locals1);
			CS$<>8__locals1.$VB$Local_column = column;
			CS$<>8__locals1.$VB$Local_value = value;
			DataTable dataTable = dt.Clone();
			dt.CaseSensitive = false;
			try
			{
				foreach (DataRow dataRow in dt.Rows.Cast<object>().Select<object, DataRow>((SetCategorySideMenus._Closure$__.$I76-0 == null) ? (SetCategorySideMenus._Closure$__.$I76-0 = (object row1) => (DataRow)row1) : SetCategorySideMenus._Closure$__.$I76-0).Where<DataRow>((CS$<>8__locals1.$I1 == null) ? (CS$<>8__locals1.$I1 = (DataRow row1) => Conversions.ToBoolean(NewLateBinding.LateGet(row1[CS$<>8__locals1.$VB$Local_column], null, "Contains", new object[] { CS$<>8__locals1.$VB$Local_value.ToUpper() }, null, null, null))) : CS$<>8__locals1.$I1))
				{
					dataTable.ImportRow(dataRow);
				}
			}
			finally
			{
				IEnumerator<DataRow> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			return dataTable;
		}

		// Token: 0x06005337 RID: 21303 RVA: 0x00305BB0 File Offset: 0x00303DB0
		private DataTable searchDB(string searchtext)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SearchProduct2";
			sqlCommand.Parameters.AddWithValue("search", searchtext);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x06005338 RID: 21304 RVA: 0x00305C38 File Offset: 0x00303E38
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

		// Token: 0x06005339 RID: 21305 RVA: 0x00305C98 File Offset: 0x00303E98
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
				this.DGVSearch.Columns["Bin_Location"].Visible = false;
				this.DGVSearch.Columns["Unit_of_Measure"].Visible = false;
				this.DGVSearch.Columns["SpecialPrice"].Visible = false;
			}
			else
			{
				this.lblerror.Text = "No products match your search.";
			}
		}

		// Token: 0x0600533A RID: 21306 RVA: 0x00305E70 File Offset: 0x00304070
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			bool flag4;
			try
			{
				bool flag = msg.WParam.ToInt32() == 33;
				if (flag)
				{
					bool flag2 = MyProject.Forms.Form1.DefaultSearchDesc == 1;
					if (flag2)
					{
						this.txtsearch.Focus();
					}
					else
					{
						this.txtBarCode.Focus();
					}
				}
				else
				{
					bool flag3 = msg.WParam.ToInt32() == 112;
					if (flag3)
					{
						this.txtBarCode.Text = "";
						this.txtBarCode.Focus();
					}
				}
				flag4 = base.ProcessCmdKey(ref msg, keyData);
			}
			catch (Exception ex)
			{
			}
			return flag4;
		}

		// Token: 0x0600533B RID: 21307 RVA: 0x00305F2C File Offset: 0x0030412C
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

		// Token: 0x0600533C RID: 21308 RVA: 0x00305FEC File Offset: 0x003041EC
		private void FetchProdtDetails(string prodtcode, int coid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchProductByCode";
			sqlCommand.Parameters.AddWithValue("productcode", prodtcode);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				this.lblDesc.Text = dataRow["ProductDesc"].ToString();
				this.currentID = Conversions.ToInteger(dataRow["ProductID"]);
				this.LoadSideMenus();
			}
			else
			{
				this.lblDesc.Text = "Nothing found matching that product ID";
			}
		}

		// Token: 0x0600533D RID: 21309 RVA: 0x003060CC File Offset: 0x003042CC
		private void txtSearchProductCode_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.FetchProdtDetails(this.txtSearchProductCode.Text, MyProject.Forms.Form1.coid);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600533E RID: 21310 RVA: 0x00306134 File Offset: 0x00304334
		private void txtBarCode_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.FetchProdtDetails(this.txtBarCode.Text, MyProject.Forms.Form1.coid);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600533F RID: 21311 RVA: 0x0030619C File Offset: 0x0030439C
		private object LoadSideMenus()
		{
			this.DataGridView1.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetSideMenuforProduct";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("productid", this.currentID);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			this.DataGridView1.DataSource = dataTable;
			this.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
			dataGridViewButtonColumn.HeaderText = "Delete LInk";
			dataGridViewButtonColumn.Text = "Delete";
			dataGridViewButtonColumn.Name = "Delete";
			dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
			this.DataGridView1.Columns.Add(dataGridViewButtonColumn);
			object obj;
			return obj;
		}

		// Token: 0x06005340 RID: 21312 RVA: 0x003062A0 File Offset: 0x003044A0
		private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					bool flag2 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "Delete", false) == 0;
					if (flag2)
					{
						DialogResult dialogResult = (DialogResult)Interaction.MsgBox("Are you sure you want to delete the Side Menu for this product? ", MsgBoxStyle.YesNo, null);
						bool flag3 = dialogResult == DialogResult.Yes;
						if (flag3)
						{
							SqlConnection sqlConnection = new SqlConnection(this._cnn);
							SqlCommand sqlCommand = sqlConnection.CreateCommand();
							sqlCommand.CommandType = CommandType.StoredProcedure;
							sqlCommand.CommandText = "DeleteSideMenuforProduct";
							sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(dataGridView.Rows[e.RowIndex].Cells["Product_ID"].Value));
							sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
							sqlCommand.Parameters.AddWithValue("sidemenu", RuntimeHelpers.GetObjectValue(dataGridView.Rows[e.RowIndex].Cells["Side_Menu_Item"].Value));
							using (sqlConnection)
							{
								sqlConnection.Open();
								sqlCommand.ExecuteNonQuery();
								sqlConnection.Close();
							}
							MessageBox.Show("Side menu item deleted for product.");
							this.LoadSideMenus();
						}
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06005341 RID: 21313 RVA: 0x00306480 File Offset: 0x00304680
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.currentID != 0;
				if (flag)
				{
					bool flag2 = Operators.CompareString(this.ComboBox1.Text, "", false) != 0;
					if (flag2)
					{
						SqlConnection sqlConnection = new SqlConnection(this._cnn);
						SqlCommand sqlCommand = sqlConnection.CreateCommand();
						sqlCommand.CommandType = CommandType.StoredProcedure;
						sqlCommand.CommandText = "InsertSideMenuforProduct";
						sqlCommand.Parameters.AddWithValue("productid", this.currentID);
						sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
						sqlCommand.Parameters.AddWithValue("sidemenu", this.ComboBox1.Text);
						sqlCommand.Parameters.AddWithValue("setby", MyProject.Forms.Form1.username);
						sqlCommand.Parameters.AddWithValue("donewhen", DateAndTime.Today.Date);
						sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
						using (sqlConnection)
						{
							sqlConnection.Open();
							sqlCommand.ExecuteNonQuery();
							sqlConnection.Close();
						}
						MessageBox.Show("Side menu item linked to product.");
						this.LoadSideMenus();
					}
					else
					{
						MessageBox.Show("Please select the Side Menu Item to link with this product.");
					}
				}
				else
				{
					MessageBox.Show("Please select a product first.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving Side Menu for product. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005342 RID: 21314 RVA: 0x00306658 File Offset: 0x00304858
		private void SetCategorySideMenus_Load(object sender, EventArgs e)
		{
			try
			{
				bool flag = MyProject.Forms.Form1.isRestaurant != 1;
				if (flag)
				{
					MessageBox.Show("System not set up for a restaurant. Linking products to side nenu options is only for restaurant mode.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x0400244C RID: 9292
		private string _cnn;

		// Token: 0x0400244D RID: 9293
		private int currentID;
	}
}
