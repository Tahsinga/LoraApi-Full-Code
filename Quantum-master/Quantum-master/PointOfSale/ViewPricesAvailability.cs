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
	// Token: 0x02000210 RID: 528
	[DesignerGenerated]
	public partial class ViewPricesAvailability : Form
	{
		// Token: 0x06005EB1 RID: 24241 RVA: 0x0036422C File Offset: 0x0036242C
		public ViewPricesAvailability()
		{
			base.Load += this.ViewPricesAvailability_Load;
			base.FormClosed += this.ViewPricesAvailability_FormClosed;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.currentid = 0;
			this.currentcode = "";
			this.thecoid = MyProject.Forms.Form1.coid;
			this.thebranch = MyProject.Forms.Form1.branch;
			this.theuser = MyProject.Forms.Form1.username;
			this.toclose = 0;
			this.InitializeComponent();
		}

		// Token: 0x17002236 RID: 8758
		// (get) Token: 0x06005EB4 RID: 24244 RVA: 0x0036584E File Offset: 0x00363A4E
		// (set) Token: 0x06005EB5 RID: 24245 RVA: 0x00365858 File Offset: 0x00363A58
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002237 RID: 8759
		// (get) Token: 0x06005EB6 RID: 24246 RVA: 0x00365861 File Offset: 0x00363A61
		// (set) Token: 0x06005EB7 RID: 24247 RVA: 0x0036586B File Offset: 0x00363A6B
		internal virtual Label Label20
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002238 RID: 8760
		// (get) Token: 0x06005EB8 RID: 24248 RVA: 0x00365874 File Offset: 0x00363A74
		// (set) Token: 0x06005EB9 RID: 24249 RVA: 0x00365880 File Offset: 0x00363A80
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
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtBarCode_KeyDown);
				TextBox textBox = this._txtBarCode;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
					textBox.KeyDown -= keyEventHandler;
				}
				this._txtBarCode = value;
				textBox = this._txtBarCode;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
					textBox.KeyDown += keyEventHandler;
				}
			}
		}

		// Token: 0x17002239 RID: 8761
		// (get) Token: 0x06005EBA RID: 24250 RVA: 0x003658DE File Offset: 0x00363ADE
		// (set) Token: 0x06005EBB RID: 24251 RVA: 0x003658E8 File Offset: 0x00363AE8
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700223A RID: 8762
		// (get) Token: 0x06005EBC RID: 24252 RVA: 0x003658F1 File Offset: 0x00363AF1
		// (set) Token: 0x06005EBD RID: 24253 RVA: 0x003658FC File Offset: 0x00363AFC
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

		// Token: 0x1700223B RID: 8763
		// (get) Token: 0x06005EBE RID: 24254 RVA: 0x0036593F File Offset: 0x00363B3F
		// (set) Token: 0x06005EBF RID: 24255 RVA: 0x00365949 File Offset: 0x00363B49
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700223C RID: 8764
		// (get) Token: 0x06005EC0 RID: 24256 RVA: 0x00365952 File Offset: 0x00363B52
		// (set) Token: 0x06005EC1 RID: 24257 RVA: 0x0036595C File Offset: 0x00363B5C
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700223D RID: 8765
		// (get) Token: 0x06005EC2 RID: 24258 RVA: 0x00365965 File Offset: 0x00363B65
		// (set) Token: 0x06005EC3 RID: 24259 RVA: 0x00365970 File Offset: 0x00363B70
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
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.DGVSearch_KeyDown);
				DataGridView dataGridView = this._DGVSearch;
				if (dataGridView != null)
				{
					dataGridView.CellEnter -= dataGridViewCellEventHandler;
					dataGridView.KeyDown -= keyEventHandler;
				}
				this._DGVSearch = value;
				dataGridView = this._DGVSearch;
				if (dataGridView != null)
				{
					dataGridView.CellEnter += dataGridViewCellEventHandler;
					dataGridView.KeyDown += keyEventHandler;
				}
			}
		}

		// Token: 0x1700223E RID: 8766
		// (get) Token: 0x06005EC4 RID: 24260 RVA: 0x003659CE File Offset: 0x00363BCE
		// (set) Token: 0x06005EC5 RID: 24261 RVA: 0x003659D8 File Offset: 0x00363BD8
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700223F RID: 8767
		// (get) Token: 0x06005EC6 RID: 24262 RVA: 0x003659E1 File Offset: 0x00363BE1
		// (set) Token: 0x06005EC7 RID: 24263 RVA: 0x003659EC File Offset: 0x00363BEC
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

		// Token: 0x17002240 RID: 8768
		// (get) Token: 0x06005EC8 RID: 24264 RVA: 0x00365A2F File Offset: 0x00363C2F
		// (set) Token: 0x06005EC9 RID: 24265 RVA: 0x00365A39 File Offset: 0x00363C39
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002241 RID: 8769
		// (get) Token: 0x06005ECA RID: 24266 RVA: 0x00365A42 File Offset: 0x00363C42
		// (set) Token: 0x06005ECB RID: 24267 RVA: 0x00365A4C File Offset: 0x00363C4C
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

		// Token: 0x17002242 RID: 8770
		// (get) Token: 0x06005ECC RID: 24268 RVA: 0x00365A8F File Offset: 0x00363C8F
		// (set) Token: 0x06005ECD RID: 24269 RVA: 0x00365A9C File Offset: 0x00363C9C
		internal virtual Button btnNext
		{
			[CompilerGenerated]
			get
			{
				return this._btnNext;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.btnNext_Click);
				Button button = this._btnNext;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._btnNext = value;
				button = this._btnNext;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17002243 RID: 8771
		// (get) Token: 0x06005ECE RID: 24270 RVA: 0x00365ADF File Offset: 0x00363CDF
		// (set) Token: 0x06005ECF RID: 24271 RVA: 0x00365AE9 File Offset: 0x00363CE9
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002244 RID: 8772
		// (get) Token: 0x06005ED0 RID: 24272 RVA: 0x00365AF2 File Offset: 0x00363CF2
		// (set) Token: 0x06005ED1 RID: 24273 RVA: 0x00365AFC File Offset: 0x00363CFC
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002245 RID: 8773
		// (get) Token: 0x06005ED2 RID: 24274 RVA: 0x00365B05 File Offset: 0x00363D05
		// (set) Token: 0x06005ED3 RID: 24275 RVA: 0x00365B0F File Offset: 0x00363D0F
		internal virtual TextBox txtStockAvail
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002246 RID: 8774
		// (get) Token: 0x06005ED4 RID: 24276 RVA: 0x00365B18 File Offset: 0x00363D18
		// (set) Token: 0x06005ED5 RID: 24277 RVA: 0x00365B22 File Offset: 0x00363D22
		internal virtual TextBox txtDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002247 RID: 8775
		// (get) Token: 0x06005ED6 RID: 24278 RVA: 0x00365B2B File Offset: 0x00363D2B
		// (set) Token: 0x06005ED7 RID: 24279 RVA: 0x00365B35 File Offset: 0x00363D35
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002248 RID: 8776
		// (get) Token: 0x06005ED8 RID: 24280 RVA: 0x00365B3E File Offset: 0x00363D3E
		// (set) Token: 0x06005ED9 RID: 24281 RVA: 0x00365B48 File Offset: 0x00363D48
		internal virtual DateTimePicker DTdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002249 RID: 8777
		// (get) Token: 0x06005EDA RID: 24282 RVA: 0x00365B51 File Offset: 0x00363D51
		// (set) Token: 0x06005EDB RID: 24283 RVA: 0x00365B5B File Offset: 0x00363D5B
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700224A RID: 8778
		// (get) Token: 0x06005EDC RID: 24284 RVA: 0x00365B64 File Offset: 0x00363D64
		// (set) Token: 0x06005EDD RID: 24285 RVA: 0x00365B6E File Offset: 0x00363D6E
		internal virtual Label txtPrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700224B RID: 8779
		// (get) Token: 0x06005EDE RID: 24286 RVA: 0x00365B77 File Offset: 0x00363D77
		// (set) Token: 0x06005EDF RID: 24287 RVA: 0x00365B81 File Offset: 0x00363D81
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700224C RID: 8780
		// (get) Token: 0x06005EE0 RID: 24288 RVA: 0x00365B8A File Offset: 0x00363D8A
		// (set) Token: 0x06005EE1 RID: 24289 RVA: 0x00365B94 File Offset: 0x00363D94
		internal virtual TextBox txtcomment
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700224D RID: 8781
		// (get) Token: 0x06005EE2 RID: 24290 RVA: 0x00365B9D File Offset: 0x00363D9D
		// (set) Token: 0x06005EE3 RID: 24291 RVA: 0x00365BA7 File Offset: 0x00363DA7
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700224E RID: 8782
		// (get) Token: 0x06005EE4 RID: 24292 RVA: 0x00365BB0 File Offset: 0x00363DB0
		// (set) Token: 0x06005EE5 RID: 24293 RVA: 0x00365BBA File Offset: 0x00363DBA
		internal virtual Label txtCostPrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700224F RID: 8783
		// (get) Token: 0x06005EE6 RID: 24294 RVA: 0x00365BC3 File Offset: 0x00363DC3
		// (set) Token: 0x06005EE7 RID: 24295 RVA: 0x00365BCD File Offset: 0x00363DCD
		internal virtual Label Label9
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002250 RID: 8784
		// (get) Token: 0x06005EE8 RID: 24296 RVA: 0x00365BD6 File Offset: 0x00363DD6
		// (set) Token: 0x06005EE9 RID: 24297 RVA: 0x00365BE0 File Offset: 0x00363DE0
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06005EEA RID: 24298 RVA: 0x00365BEC File Offset: 0x00363DEC
		private void ViewPricesAvailability_Load(object sender, EventArgs e)
		{
			try
			{
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06005EEB RID: 24299 RVA: 0x00365C20 File Offset: 0x00363E20
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

		// Token: 0x06005EEC RID: 24300 RVA: 0x00365C8C File Offset: 0x00363E8C
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

		// Token: 0x06005EED RID: 24301 RVA: 0x00365D84 File Offset: 0x00363F84
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

		// Token: 0x06005EEE RID: 24302 RVA: 0x00365F5C File Offset: 0x0036415C
		private void Button3_Click(object sender, EventArgs e)
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

		// Token: 0x06005EEF RID: 24303 RVA: 0x00365FBC File Offset: 0x003641BC
		private void DGVSearch_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					int num = Conversions.ToInteger(this.DGVSearch.Rows[e.RowIndex].Cells["ProductID"].Value);
					this.txtSearchProductCode.Text = Conversions.ToString(num);
				}
			}
			catch (Exception ex)
			{
				this.lblerror.Text = "Error: " + ex.Message;
			}
		}

		// Token: 0x06005EF0 RID: 24304 RVA: 0x00366080 File Offset: 0x00364280
		private void DGVSearch_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				bool flag = e.KeyCode == Keys.Return;
				if (flag)
				{
					this.btnNext.Focus();
					e.Handled = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Key down error. Ignore");
			}
		}

		// Token: 0x06005EF1 RID: 24305 RVA: 0x00002A30 File Offset: 0x00000C30
		private void txtBarCode_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06005EF2 RID: 24306 RVA: 0x003660E0 File Offset: 0x003642E0
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
				this.txtDesc.Text = Conversions.ToString(dataRow["ProductDesc"]);
				decimal num2 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataRow["SellingPrice"]));
				this.currentid = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataRow["ProductID"]));
				this.currentcode = dataRow["ProductCode"].ToString();
				decimal num3 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
				decimal num4 = decimal.Add(num2, decimal.Multiply(decimal.Divide(num3, 100m), num2));
				num4 = Math.Round(num4, 2);
				this.txtPrice.Text = num4.ToString();
				this.txtCostPrice.Text = Conversions.ToString(dataRow["Cost"]);
				this.txtStockAvail.Text = Conversions.ToString(this.GetStockAvailable(prodtID));
			}
			else
			{
				this.txtSearchProductCode.Text = "";
				this.currentcode = "";
				this.currentid = 0;
			}
		}

		// Token: 0x06005EF3 RID: 24307 RVA: 0x003662C4 File Offset: 0x003644C4
		private decimal GetStockAvailable(int productid)
		{
			int num = 0;
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "TotalStockIn";
			sqlCommand.Parameters.AddWithValue("productid", productid);
			sqlCommand.Parameters.AddWithValue("coid", this.thecoid);
			sqlCommand.Parameters.AddWithValue("branch", this.thebranch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			using (sqlConnection)
			{
				sqlConnection.Open();
				int num2 = sqlDataAdapter.Fill(dataTable);
				bool flag = num2 > 0;
				if (flag)
				{
					DataRow dataRow = dataTable.Rows[0];
					num = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow[0])), 0, RuntimeHelpers.GetObjectValue(dataRow[0])));
				}
				else
				{
					num = 0;
				}
				sqlConnection.Close();
			}
			int num3 = 0;
			SqlConnection sqlConnection3 = new SqlConnection(this._cnn);
			SqlCommand sqlCommand2 = sqlConnection3.CreateCommand();
			sqlCommand2.CommandType = CommandType.StoredProcedure;
			sqlCommand2.CommandText = "TotalStockOut";
			sqlCommand2.Parameters.AddWithValue("productid", productid);
			sqlCommand2.Parameters.AddWithValue("coid", this.thecoid);
			sqlCommand2.Parameters.AddWithValue("branch", this.thebranch);
			DataTable dataTable2 = new DataTable();
			SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter(sqlCommand2);
			using (sqlConnection3)
			{
				sqlConnection3.Open();
				int num4 = sqlDataAdapter2.Fill(dataTable2);
				bool flag2 = num4 > 0;
				if (flag2)
				{
					DataRow dataRow2 = dataTable2.Rows[0];
					num3 = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2[0])), 0, RuntimeHelpers.GetObjectValue(dataRow2[0])));
				}
				else
				{
					num3 = 0;
				}
				sqlConnection3.Close();
			}
			decimal num5 = new decimal(checked(num - num3));
			return num5;
		}

		// Token: 0x06005EF4 RID: 24308 RVA: 0x0036650C File Offset: 0x0036470C
		private void SearchProductCode(string prodtcode)
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
				double num2 = Conversions.ToDouble(dataRow["SellingPrice"]);
				this.txtDesc.Text = Conversions.ToString(dataRow["ProductDesc"]);
				this.txtPrice.Text = num2.ToString();
				this.txtCostPrice.Text = Conversions.ToString(dataRow["Cost"]);
				this.currentid = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataRow["ProductID"]));
				this.currentcode = dataRow["ProductCode"].ToString();
				this.txtStockAvail.Text = Conversions.ToString(this.GetStockAvailable(Conversions.ToInteger(dataRow["ProductID"])));
			}
			else
			{
				this.txtSearchProductCode.Text = "";
				this.currentcode = "";
				this.currentid = 0;
			}
		}

		// Token: 0x06005EF5 RID: 24309 RVA: 0x00366690 File Offset: 0x00364890
		private void txtSearchProductCode_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.txtBarCode.Text = "";
				this.txtStockAvail.Text = Conversions.ToString(0);
				this.txtPrice.Text = Conversions.ToString(0);
				this.txtDesc.Text = "No product matches your search.";
				this.SearchBarCode(Conversions.ToInteger(Interaction.IIf(Operators.CompareString(this.txtSearchProductCode.Text, "", false) == 0, 0, Conversion.Val(this.txtSearchProductCode.Text))));
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Details: " + ex.Message, "Error");
			}
		}

		// Token: 0x06005EF6 RID: 24310 RVA: 0x00366768 File Offset: 0x00364968
		private void btnNext_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "InsertEnquiry";
				sqlCommand.Parameters.AddWithValue("datedone", Convert.ToInt32(DateTime.Today.ToString("yyyyMMdd")));
				sqlCommand.Parameters.AddWithValue("timedone", DateTime.Now.ToString("HH:mm"));
				sqlCommand.Parameters.AddWithValue("productid", this.currentid);
				sqlCommand.Parameters.AddWithValue("productcode", this.currentcode);
				sqlCommand.Parameters.AddWithValue("productdesc", this.txtDesc.Text);
				sqlCommand.Parameters.AddWithValue("stockathand", Convert.ToInt32(this.txtStockAvail.Text));
				sqlCommand.Parameters.AddWithValue("coid", this.thecoid);
				sqlCommand.Parameters.AddWithValue("branch", this.thebranch);
				sqlCommand.Parameters.AddWithValue("comment", this.txtcomment.Text);
				sqlCommand.Parameters.AddWithValue("DoneBy", this.theuser);
				using (sqlConnection)
				{
					sqlConnection.Open();
					sqlCommand.ExecuteNonQuery();
					sqlConnection.Close();
				}
				this.txtBarCode.Text = "";
				this.txtSearchProductCode.Text = "";
				this.currentcode = "";
				this.currentid = 0;
				this.txtcomment.Text = "";
				this.txtBarCode.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error occurred. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005EF7 RID: 24311 RVA: 0x003669A0 File Offset: 0x00364BA0
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void ViewPricesAvailability_FormClosed(object sender, FormClosedEventArgs e)
		{
			try
			{
				bool flag = this.toclose == 0;
				if (flag)
				{
					ProjectData.EndApp();
				}
				else
				{
					bool flag2 = this.toclose == 1;
					if (flag2)
					{
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06005EF8 RID: 24312 RVA: 0x003669F8 File Offset: 0x00364BF8
		private void txtBarCode_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				bool flag = e.KeyCode == Keys.Return;
				if (flag)
				{
					this.txtStockAvail.Text = Conversions.ToString(0);
					this.txtPrice.Text = Conversions.ToString(0);
					this.txtDesc.Text = "No product matches your search.";
					this.SearchProductCode(Conversions.ToString(Interaction.IIf(Operators.CompareString(this.txtBarCode.Text, "", false) == 0, 0, this.txtBarCode.Text)));
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching for product. Detail: " + ex.Message);
			}
		}

		// Token: 0x040029AD RID: 10669
		private string _cnn;

		// Token: 0x040029AE RID: 10670
		private int currentid;

		// Token: 0x040029AF RID: 10671
		private string currentcode;

		// Token: 0x040029B0 RID: 10672
		private int thecoid;

		// Token: 0x040029B1 RID: 10673
		private string thebranch;

		// Token: 0x040029B2 RID: 10674
		private string theuser;

		// Token: 0x040029B3 RID: 10675
		public int toclose;
	}
}
