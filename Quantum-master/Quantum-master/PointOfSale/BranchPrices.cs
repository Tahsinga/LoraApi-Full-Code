using System;
using System.Collections;
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
	// Token: 0x02000018 RID: 24
	[DesignerGenerated]
	public partial class BranchPrices : Form
	{
		// Token: 0x06000436 RID: 1078 RVA: 0x00027468 File Offset: 0x00025668
		public BranchPrices()
		{
			base.Load += this.BranchPrices_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.dat_compare = new DataTable();
			this.InitializeComponent();
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000439 RID: 1081 RVA: 0x000281D2 File Offset: 0x000263D2
		// (set) Token: 0x0600043A RID: 1082 RVA: 0x000281DC File Offset: 0x000263DC
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x0600043B RID: 1083 RVA: 0x000281E5 File Offset: 0x000263E5
		// (set) Token: 0x0600043C RID: 1084 RVA: 0x000281F0 File Offset: 0x000263F0
		internal virtual DataGridView dgvProducts
		{
			[CompilerGenerated]
			get
			{
				return this._dgvProducts;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
				DataGridView dataGridView = this._dgvProducts;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick -= dataGridViewCellEventHandler;
				}
				this._dgvProducts = value;
				dataGridView = this._dgvProducts;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x0600043D RID: 1085 RVA: 0x00028233 File Offset: 0x00026433
		// (set) Token: 0x0600043E RID: 1086 RVA: 0x00028240 File Offset: 0x00026440
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

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x0600043F RID: 1087 RVA: 0x00028283 File Offset: 0x00026483
		// (set) Token: 0x06000440 RID: 1088 RVA: 0x0002828D File Offset: 0x0002648D
		internal virtual Label lblView
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000441 RID: 1089 RVA: 0x00028296 File Offset: 0x00026496
		// (set) Token: 0x06000442 RID: 1090 RVA: 0x000282A0 File Offset: 0x000264A0
		internal virtual ComboBox cboBranch
		{
			[CompilerGenerated]
			get
			{
				return this._cboBranch;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cboBranch_SelectedIndexChanged);
				ComboBox comboBox = this._cboBranch;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= eventHandler;
				}
				this._cboBranch = value;
				comboBox = this._cboBranch;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000443 RID: 1091 RVA: 0x000282E3 File Offset: 0x000264E3
		// (set) Token: 0x06000444 RID: 1092 RVA: 0x000282ED File Offset: 0x000264ED
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000445 RID: 1093 RVA: 0x000282F6 File Offset: 0x000264F6
		// (set) Token: 0x06000446 RID: 1094 RVA: 0x00028300 File Offset: 0x00026500
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000447 RID: 1095 RVA: 0x00028309 File Offset: 0x00026509
		// (set) Token: 0x06000448 RID: 1096 RVA: 0x00028314 File Offset: 0x00026514
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

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000449 RID: 1097 RVA: 0x00028372 File Offset: 0x00026572
		// (set) Token: 0x0600044A RID: 1098 RVA: 0x0002837C File Offset: 0x0002657C
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x0600044B RID: 1099 RVA: 0x00028385 File Offset: 0x00026585
		// (set) Token: 0x0600044C RID: 1100 RVA: 0x00028390 File Offset: 0x00026590
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

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x0600044D RID: 1101 RVA: 0x000283D3 File Offset: 0x000265D3
		// (set) Token: 0x0600044E RID: 1102 RVA: 0x000283DD File Offset: 0x000265DD
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x0600044F RID: 1103 RVA: 0x000283E6 File Offset: 0x000265E6
		// (set) Token: 0x06000450 RID: 1104 RVA: 0x000283F0 File Offset: 0x000265F0
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

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000451 RID: 1105 RVA: 0x00028433 File Offset: 0x00026633
		// (set) Token: 0x06000452 RID: 1106 RVA: 0x00028440 File Offset: 0x00026640
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

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000453 RID: 1107 RVA: 0x00028483 File Offset: 0x00026683
		// (set) Token: 0x06000454 RID: 1108 RVA: 0x0002848D File Offset: 0x0002668D
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000455 RID: 1109 RVA: 0x00028496 File Offset: 0x00026696
		// (set) Token: 0x06000456 RID: 1110 RVA: 0x000284A0 File Offset: 0x000266A0
		internal virtual Label Label15
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000457 RID: 1111 RVA: 0x000284A9 File Offset: 0x000266A9
		// (set) Token: 0x06000458 RID: 1112 RVA: 0x000284B4 File Offset: 0x000266B4
		internal virtual TextBox txtProductCode
		{
			[CompilerGenerated]
			get
			{
				return this._txtProductCode;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.txtProductCode_TextChanged);
				TextBox textBox = this._txtProductCode;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
				}
				this._txtProductCode = value;
				textBox = this._txtProductCode;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000459 RID: 1113 RVA: 0x000284F7 File Offset: 0x000266F7
		// (set) Token: 0x0600045A RID: 1114 RVA: 0x00028501 File Offset: 0x00026701
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x0002850C File Offset: 0x0002670C
		private void BranchPrices_Load(object sender, EventArgs e)
		{
			try
			{
				bool isbranch = MyProject.Forms.Form1.isbranch;
				if (isbranch)
				{
					MessageBox.Show("This is a branch computer and cannot edit prices. Prices should be changed at HQ.");
					base.Dispose();
				}
				this.LoadBranches();
				this.LoadGlobalPrices();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading global prices. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00028588 File Offset: 0x00026788
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
			this.cboBranch.SelectedIndex = -1;
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x00028634 File Offset: 0x00026834
		private void LoadGlobalPrices()
		{
			this.dgvProducts.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetGlobalPrices";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			this.dgvProducts.DataSource = dataTable;
			this.dgvProducts.Columns["DifferentPricesPerBranch"].DefaultCellStyle.BackColor = Color.Gray;
			this.dgvProducts.Columns["ProductID"].DefaultCellStyle.BackColor = Color.Gray;
			this.dgvProducts.Columns["ProductDesc"].DefaultCellStyle.BackColor = Color.Gray;
			this.dgvProducts.Columns["DifferentPricesPerBranch"].ReadOnly = true;
			this.dgvProducts.Columns["ProductID"].ReadOnly = true;
			this.dgvProducts.Columns["ProductDesc"].ReadOnly = true;
			this.dgvProducts.Columns["ProductID"].HeaderText = "Product ID";
			this.dgvProducts.Columns["ProductDesc"].HeaderText = "Product Description";
			this.dgvProducts.Columns["DifferentPricesPerBranch"].HeaderText = "Has Different Prices Per Branch?";
			this.dgvProducts.Columns["sellingprice"].HeaderText = "Selling Price";
			this.dgvProducts.Columns["sellingpricewholesale"].HeaderText = "Wholesale Price";
			this.dgvProducts.Columns["wholesaleqty"].HeaderText = "Wholesale Qty";
			this.dgvProducts.Columns["specialprice"].HeaderText = "Special Price";
			this.dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.lblView.Text = "VIEWING GLOBAL PRICES NOW";
			this.CurrentBranch = MyProject.Forms.Form1.branch;
			this.IsGlobal = 1;
			DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
			dataGridViewButtonColumn.HeaderText = "Save Changes";
			dataGridViewButtonColumn.Text = "Save";
			dataGridViewButtonColumn.Name = "save";
			dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
			this.dgvProducts.Columns.Add(dataGridViewButtonColumn);
			this.cboBranch.Text = "";
			this.LoadGlobalPricesCompare();
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x00028904 File Offset: 0x00026B04
		private void LoadGlobalPricesCompare()
		{
			DataTable dataTable = new DataTable();
			this.dat_compare = dataTable;
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetGlobalPrices";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(this.dat_compare);
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x00028980 File Offset: 0x00026B80
		private void loadBranchPrices(string branch)
		{
			this.dgvProducts.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetBranchPrices";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			this.dgvProducts.DataSource = dataTable;
			this.dgvProducts.Columns["ProductID"].DefaultCellStyle.BackColor = Color.Gray;
			this.dgvProducts.Columns["ProductDesc"].DefaultCellStyle.BackColor = Color.Gray;
			this.dgvProducts.Columns["ProductID"].ReadOnly = true;
			this.dgvProducts.Columns["ProductDesc"].ReadOnly = true;
			this.dgvProducts.Columns["ProductID"].HeaderText = "Product ID";
			this.dgvProducts.Columns["ProductDesc"].HeaderText = "Product Description";
			this.dgvProducts.Columns["sellingprice"].HeaderText = "Selling Price";
			this.dgvProducts.Columns["sellingpricewholesale"].HeaderText = "Wholesale Price";
			this.dgvProducts.Columns["wholesaleqty"].HeaderText = "Wholesale Qty";
			this.dgvProducts.Columns["specialprice"].HeaderText = "Special Price";
			this.dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.lblView.Text = "VIEWING " + branch + " BRANCH PRICES";
			this.CurrentBranch = branch;
			this.IsGlobal = 0;
			DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
			dataGridViewButtonColumn.HeaderText = "Save Changes";
			dataGridViewButtonColumn.Text = "Save";
			dataGridViewButtonColumn.Name = "save";
			dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
			this.dgvProducts.Columns.Add(dataGridViewButtonColumn);
			this.LoadBranchPricesCompare(branch);
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x00028BEC File Offset: 0x00026DEC
		private void LoadBranchPricesCompare(string branch)
		{
			DataTable dataTable = new DataTable();
			this.dat_compare = dataTable;
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetBranchPrices";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(this.dat_compare);
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x00028C7C File Offset: 0x00026E7C
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				this.loadBranchPrices(this.cboBranch.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading branch prices.");
			}
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x00028CCC File Offset: 0x00026ECC
		private void Button4_Click(object sender, EventArgs e)
		{
			int num = 0;
			DialogResult dialogResult = (DialogResult)Interaction.MsgBox("Do you want to set this price for other branches as well? ", MsgBoxStyle.YesNo, null);
			bool flag = dialogResult == DialogResult.Yes;
			if (flag)
			{
				bool flag2 = this.IsGlobal == 1;
				if (flag2)
				{
					num = 1;
					Branches branches = new Branches();
					branches.ShowDialog(this);
					branches.Dispose();
				}
				else
				{
					num = 1;
					Branches branches2 = new Branches();
					branches2.ShowDialog(this);
					branches2.Dispose();
				}
			}
			else
			{
				num = 0;
				bool flag3 = this.IsGlobal == 1;
				if (flag3)
				{
					MessageBox.Show("Setting prices for global prices not branch.");
				}
			}
			int num2 = 0;
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.Connection = sqlConnection;
			sqlConnection.Open();
			SqlTransaction sqlTransaction = sqlConnection.BeginTransaction("RunProductDetailsSaveAll");
			sqlCommand.Transaction = sqlTransaction;
			int num3 = 0;
			checked
			{
				try
				{
					try
					{
						foreach (object obj in ((IEnumerable)this.dgvProducts.Rows))
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							double num4 = Conversions.ToDouble(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["sellingprice"].Value)), 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["sellingprice"].Value)));
							int num5 = Conversions.ToInteger(dataGridViewRow.Cells["ProductID"].Value);
							decimal num6 = Conversions.ToDecimal(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["sellingpricewholesale"].Value)), 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["sellingpricewholesale"].Value)));
							decimal num7 = Conversions.ToDecimal(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["wholesaleqty"].Value)), 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["wholesaleqty"].Value)));
							decimal num8 = Conversions.ToDecimal(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["specialprice"].Value)), 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["specialprice"].Value)));
							bool flag4 = false;
							bool flag5 = false;
							bool flag6 = false;
							bool flag7 = false;
							bool flag8 = false;
							DataRow[] array = this.dat_compare.Select("ProductID=" + num5.ToString());
							DataRow dataRow = array[0];
							bool flag9 = Operators.ConditionalCompareObjectNotEqual(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["sellingprice"])), 0, RuntimeHelpers.GetObjectValue(dataRow["sellingprice"])), num4, false);
							if (flag9)
							{
								flag5 = true;
								flag4 = true;
							}
							bool flag10 = Operators.ConditionalCompareObjectNotEqual(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["sellingpricewholesale"])), 0, RuntimeHelpers.GetObjectValue(dataRow["sellingpricewholesale"])), num6, false);
							if (flag10)
							{
								flag6 = true;
								flag4 = true;
							}
							bool flag11 = Operators.ConditionalCompareObjectNotEqual(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["wholesaleqty"])), 0, RuntimeHelpers.GetObjectValue(dataRow["wholesaleqty"])), num7, false);
							if (flag11)
							{
								flag7 = true;
								flag4 = true;
							}
							bool flag12 = Operators.ConditionalCompareObjectNotEqual(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["specialprice"])), 0, RuntimeHelpers.GetObjectValue(dataRow["specialprice"])), num8, false);
							if (flag12)
							{
								flag8 = true;
								flag4 = true;
							}
							bool flag13 = flag5 || flag6 || flag7 || flag8;
							if (flag13)
							{
								bool flag14 = num == 1;
								if (flag14)
								{
									try
									{
										foreach (object obj2 in MyProject.Forms.Form1.datPriceBranches.Rows)
										{
											DataRow dataRow2 = (DataRow)obj2;
											sqlCommand.Parameters.Clear();
											sqlCommand.CommandType = CommandType.StoredProcedure;
											sqlCommand.CommandText = "Audit_PriceChangeInsert";
											sqlCommand.Parameters.AddWithValue("productid", num5);
											sqlCommand.Parameters.AddWithValue("systemdate", DateTime.Now);
											sqlCommand.Parameters.AddWithValue("IsCostPriceChanged", false);
											sqlCommand.Parameters.AddWithValue("IsSellingPriceChanged", flag5);
											sqlCommand.Parameters.AddWithValue("IsWholesalePriceChanged", flag6);
											sqlCommand.Parameters.AddWithValue("IsWholesaleQtyChanged", flag7);
											sqlCommand.Parameters.AddWithValue("Old_CostPrice", 0);
											sqlCommand.Parameters.AddWithValue("New_CostPrice", 0);
											sqlCommand.Parameters.AddWithValue("Old_SellingPrice", RuntimeHelpers.GetObjectValue(dataRow["sellingprice"]));
											sqlCommand.Parameters.AddWithValue("New_SellingPrice", num4);
											sqlCommand.Parameters.AddWithValue("Old_WholesalePrice", RuntimeHelpers.GetObjectValue(dataRow["sellingpricewholesale"]));
											sqlCommand.Parameters.AddWithValue("New_WholesalePrice", num6);
											sqlCommand.Parameters.AddWithValue("Old_WholesaleQty", RuntimeHelpers.GetObjectValue(dataRow["wholesaleqty"]));
											sqlCommand.Parameters.AddWithValue("New_WholesaleQty", num7);
											sqlCommand.Parameters.AddWithValue("ChangesDoneBy", MyProject.Forms.Form1.username);
											sqlCommand.Parameters.AddWithValue("ComputerName", Environment.MachineName);
											sqlCommand.Parameters.AddWithValue("branch", RuntimeHelpers.GetObjectValue(dataRow2["branch"]));
											sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
											sqlCommand.Parameters.AddWithValue("comment", "CHANGE BRANCH PRICES");
											sqlCommand.Parameters.AddWithValue("new_entryno", num2);
											num2 = Conversions.ToInteger(sqlCommand.ExecuteScalar());
										}
									}
									finally
									{
										IEnumerator enumerator2;
										if (enumerator2 is IDisposable)
										{
											(enumerator2 as IDisposable).Dispose();
										}
									}
								}
								else
								{
									sqlCommand.Parameters.Clear();
									sqlCommand.CommandType = CommandType.StoredProcedure;
									sqlCommand.CommandText = "Audit_PriceChangeInsert";
									sqlCommand.Parameters.AddWithValue("productid", num5);
									sqlCommand.Parameters.AddWithValue("systemdate", DateTime.Now);
									sqlCommand.Parameters.AddWithValue("IsCostPriceChanged", false);
									sqlCommand.Parameters.AddWithValue("IsSellingPriceChanged", flag5);
									sqlCommand.Parameters.AddWithValue("IsWholesalePriceChanged", flag6);
									sqlCommand.Parameters.AddWithValue("IsWholesaleQtyChanged", flag7);
									sqlCommand.Parameters.AddWithValue("Old_CostPrice", 0);
									sqlCommand.Parameters.AddWithValue("New_CostPrice", 0);
									sqlCommand.Parameters.AddWithValue("Old_SellingPrice", RuntimeHelpers.GetObjectValue(dataRow["sellingprice"]));
									sqlCommand.Parameters.AddWithValue("New_SellingPrice", num4);
									sqlCommand.Parameters.AddWithValue("Old_WholesalePrice", RuntimeHelpers.GetObjectValue(dataRow["sellingpricewholesale"]));
									sqlCommand.Parameters.AddWithValue("New_WholesalePrice", num6);
									sqlCommand.Parameters.AddWithValue("Old_WholesaleQty", RuntimeHelpers.GetObjectValue(dataRow["wholesaleqty"]));
									sqlCommand.Parameters.AddWithValue("New_WholesaleQty", num7);
									sqlCommand.Parameters.AddWithValue("ChangesDoneBy", MyProject.Forms.Form1.username);
									sqlCommand.Parameters.AddWithValue("ComputerName", Environment.MachineName);
									sqlCommand.Parameters.AddWithValue("branch", this.CurrentBranch);
									sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
									sqlCommand.Parameters.AddWithValue("comment", "CHANGE BRANCH PRICES");
									sqlCommand.Parameters.AddWithValue("new_entryno", num2);
									num2 = Conversions.ToInteger(sqlCommand.ExecuteScalar());
								}
							}
							bool flag15 = num == 1;
							if (flag15)
							{
								bool flag16 = flag4;
								if (flag16)
								{
									try
									{
										foreach (object obj3 in MyProject.Forms.Form1.datPriceBranches.Rows)
										{
											DataRow dataRow3 = (DataRow)obj3;
											sqlCommand.Parameters.Clear();
											sqlCommand.CommandType = CommandType.StoredProcedure;
											sqlCommand.CommandText = "SaveBranchPrices";
											sqlCommand.Parameters.AddWithValue("ProductID", num5);
											sqlCommand.Parameters.AddWithValue("ProductSellingPrice", num4);
											sqlCommand.Parameters.AddWithValue("DoneBy", MyProject.Forms.Form1.username);
											sqlCommand.Parameters.AddWithValue("DoneWhen", Conversion.Val(DateTime.Today.ToString("yyyyMMdd")));
											sqlCommand.Parameters.AddWithValue("wholesaleprice", num6);
											sqlCommand.Parameters.AddWithValue("wholesaleqty", num7);
											sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
											sqlCommand.Parameters.AddWithValue("specialprice", num8);
											sqlCommand.Parameters.AddWithValue("branch", RuntimeHelpers.GetObjectValue(dataRow3["branch"]));
											sqlCommand.Parameters.AddWithValue("isglobal", 0);
											sqlCommand.ExecuteNonQuery();
											num3++;
										}
									}
									finally
									{
										IEnumerator enumerator3;
										if (enumerator3 is IDisposable)
										{
											(enumerator3 as IDisposable).Dispose();
										}
									}
								}
							}
							else
							{
								bool flag17 = (num == 0) & (this.IsGlobal == 0);
								if (flag17)
								{
									bool flag18 = flag4;
									if (flag18)
									{
										sqlCommand.Parameters.Clear();
										sqlCommand.CommandType = CommandType.StoredProcedure;
										sqlCommand.CommandText = "SaveBranchPrices";
										sqlCommand.Parameters.AddWithValue("ProductID", num5);
										sqlCommand.Parameters.AddWithValue("ProductSellingPrice", num4);
										sqlCommand.Parameters.AddWithValue("DoneBy", MyProject.Forms.Form1.username);
										sqlCommand.Parameters.AddWithValue("DoneWhen", Conversion.Val(DateTime.Today.ToString("yyyyMMdd")));
										sqlCommand.Parameters.AddWithValue("wholesaleprice", num6);
										sqlCommand.Parameters.AddWithValue("wholesaleqty", num7);
										sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
										sqlCommand.Parameters.AddWithValue("specialprice", num8);
										sqlCommand.Parameters.AddWithValue("branch", this.cboBranch.Text);
										sqlCommand.Parameters.AddWithValue("isglobal", 0);
										sqlCommand.ExecuteNonQuery();
										num3++;
									}
								}
								else
								{
									bool flag19 = (this.IsGlobal == 1) & (num == 0);
									if (flag19)
									{
										bool flag20 = flag4;
										if (flag20)
										{
											sqlCommand.Parameters.Clear();
											sqlCommand.CommandType = CommandType.StoredProcedure;
											sqlCommand.CommandText = "SaveBranchPrices";
											sqlCommand.Parameters.AddWithValue("ProductID", num5);
											sqlCommand.Parameters.AddWithValue("ProductSellingPrice", num4);
											sqlCommand.Parameters.AddWithValue("DoneBy", MyProject.Forms.Form1.username);
											sqlCommand.Parameters.AddWithValue("DoneWhen", Conversion.Val(DateTime.Today.ToString("yyyyMMdd")));
											sqlCommand.Parameters.AddWithValue("wholesaleprice", num6);
											sqlCommand.Parameters.AddWithValue("wholesaleqty", num7);
											sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
											sqlCommand.Parameters.AddWithValue("specialprice", num8);
											sqlCommand.Parameters.AddWithValue("branch", this.CurrentBranch);
											sqlCommand.Parameters.AddWithValue("isglobal", this.IsGlobal);
											sqlCommand.ExecuteNonQuery();
											num3++;
										}
									}
								}
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
					sqlTransaction.Commit();
					sqlCommand.Connection.Close();
					MessageBox.Show(num3.ToString() + " Price changes saved.");
					bool flag21 = this.IsGlobal == 1;
					if (flag21)
					{
						this.LoadGlobalPrices();
					}
					else
					{
						this.loadBranchPrices(this.cboBranch.Text);
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error saving price changes. Detail: " + ex.Message);
					try
					{
						sqlTransaction.Rollback();
						sqlConnection.Close();
					}
					catch (Exception ex2)
					{
					}
				}
			}
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x00029BD4 File Offset: 0x00027DD4
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.LoadGlobalPrices();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading global prices. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00029C24 File Offset: 0x00027E24
		private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridView dataGridView = (DataGridView)sender;
			bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn) & (e.RowIndex >= 0);
			checked
			{
				if (flag)
				{
					bool flag2 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "save", false) == 0;
					if (flag2)
					{
						int num = 0;
						DialogResult dialogResult = (DialogResult)Interaction.MsgBox("Do you want to set this price for other branches as well? ", MsgBoxStyle.YesNo, null);
						bool flag3 = dialogResult == DialogResult.Yes;
						if (flag3)
						{
							bool flag4 = this.IsGlobal == 1;
							if (flag4)
							{
								bool flag5 = Operators.CompareString(this.dgvProducts.Rows[e.RowIndex].Cells["DifferentPricesPerBranch"].Value.ToString(), "True", false) == 0;
								if (!flag5)
								{
									MessageBox.Show("Product not set for different prices per branch. No price will be changed.");
									return;
								}
								num = 1;
								Branches branches = new Branches();
								branches.ShowDialog(this);
								branches.Dispose();
							}
							else
							{
								num = 1;
								Branches branches2 = new Branches();
								branches2.ShowDialog(this);
								branches2.Dispose();
							}
						}
						else
						{
							bool flag6 = this.IsGlobal == 1;
							if (flag6)
							{
								num = 0;
								MessageBox.Show("Setting prices for global prices not branch.");
							}
							else
							{
								num = 1;
								DataTable dataTable = new DataTable();
								dataTable.Columns.Add("branch", typeof(string));
								dataTable.Rows.Add(new object[] { this.cboBranch.Text });
								MyProject.Forms.Form1.datPriceBranches = dataTable;
								MessageBox.Show("Setting prices for " + this.cboBranch.Text + " branch.");
							}
						}
						int num2 = 0;
						SqlConnection sqlConnection = new SqlConnection(this._cnn);
						SqlCommand sqlCommand = sqlConnection.CreateCommand();
						sqlCommand.Connection = sqlConnection;
						sqlConnection.Open();
						SqlTransaction sqlTransaction = sqlConnection.BeginTransaction("RunProductDetailsSaveAll");
						sqlCommand.Transaction = sqlTransaction;
						int num3 = 0;
						try
						{
							double num4 = Conversions.ToDouble(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.dgvProducts.Rows[e.RowIndex].Cells["sellingprice"].Value)), 0, RuntimeHelpers.GetObjectValue(this.dgvProducts.Rows[e.RowIndex].Cells["sellingprice"].Value)));
							int num5 = Conversions.ToInteger(this.dgvProducts.Rows[e.RowIndex].Cells["ProductID"].Value);
							decimal num6 = Conversions.ToDecimal(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.dgvProducts.Rows[e.RowIndex].Cells["sellingpricewholesale"].Value)), 0, RuntimeHelpers.GetObjectValue(this.dgvProducts.Rows[e.RowIndex].Cells["sellingpricewholesale"].Value)));
							decimal num7 = Conversions.ToDecimal(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.dgvProducts.Rows[e.RowIndex].Cells["wholesaleqty"].Value)), 0, RuntimeHelpers.GetObjectValue(this.dgvProducts.Rows[e.RowIndex].Cells["wholesaleqty"].Value)));
							decimal num8 = Conversions.ToDecimal(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.dgvProducts.Rows[e.RowIndex].Cells["specialprice"].Value)), 0, RuntimeHelpers.GetObjectValue(this.dgvProducts.Rows[e.RowIndex].Cells["specialprice"].Value)));
							bool flag7 = false;
							bool flag8 = false;
							bool flag9 = false;
							bool flag10 = false;
							DataRow[] array = this.dat_compare.Select("ProductID=" + num5.ToString());
							DataRow dataRow = array[0];
							bool flag11 = Operators.ConditionalCompareObjectNotEqual(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["sellingprice"])), 0, RuntimeHelpers.GetObjectValue(dataRow["sellingprice"])), num4, false);
							if (flag11)
							{
								flag7 = true;
							}
							bool flag12 = Operators.ConditionalCompareObjectNotEqual(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["sellingpricewholesale"])), 0, RuntimeHelpers.GetObjectValue(dataRow["sellingpricewholesale"])), num6, false);
							if (flag12)
							{
								flag8 = true;
							}
							bool flag13 = Operators.ConditionalCompareObjectNotEqual(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["wholesaleqty"])), 0, RuntimeHelpers.GetObjectValue(dataRow["wholesaleqty"])), num7, false);
							if (flag13)
							{
								flag9 = true;
							}
							bool flag14 = Operators.ConditionalCompareObjectNotEqual(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["specialprice"])), 0, RuntimeHelpers.GetObjectValue(dataRow["specialprice"])), num8, false);
							if (flag14)
							{
								flag10 = true;
							}
							bool flag15 = flag7 || flag8 || flag9 || flag10;
							if (flag15)
							{
								bool flag16 = num == 1;
								if (flag16)
								{
									try
									{
										foreach (object obj in MyProject.Forms.Form1.datPriceBranches.Rows)
										{
											DataRow dataRow2 = (DataRow)obj;
											sqlCommand.Parameters.Clear();
											sqlCommand.CommandType = CommandType.StoredProcedure;
											sqlCommand.CommandText = "Audit_PriceChangeInsert";
											sqlCommand.Parameters.AddWithValue("productid", num5);
											sqlCommand.Parameters.AddWithValue("systemdate", DateTime.Now);
											sqlCommand.Parameters.AddWithValue("IsCostPriceChanged", false);
											sqlCommand.Parameters.AddWithValue("IsSellingPriceChanged", flag7);
											sqlCommand.Parameters.AddWithValue("IsWholesalePriceChanged", flag8);
											sqlCommand.Parameters.AddWithValue("IsWholesaleQtyChanged", flag9);
											sqlCommand.Parameters.AddWithValue("Old_CostPrice", 0);
											sqlCommand.Parameters.AddWithValue("New_CostPrice", 0);
											sqlCommand.Parameters.AddWithValue("Old_SellingPrice", RuntimeHelpers.GetObjectValue(dataRow["sellingprice"]));
											sqlCommand.Parameters.AddWithValue("New_SellingPrice", num4);
											sqlCommand.Parameters.AddWithValue("Old_WholesalePrice", RuntimeHelpers.GetObjectValue(dataRow["sellingpricewholesale"]));
											sqlCommand.Parameters.AddWithValue("New_WholesalePrice", num6);
											sqlCommand.Parameters.AddWithValue("Old_WholesaleQty", RuntimeHelpers.GetObjectValue(dataRow["wholesaleqty"]));
											sqlCommand.Parameters.AddWithValue("New_WholesaleQty", num7);
											sqlCommand.Parameters.AddWithValue("ChangesDoneBy", MyProject.Forms.Form1.username);
											sqlCommand.Parameters.AddWithValue("ComputerName", Environment.MachineName);
											sqlCommand.Parameters.AddWithValue("branch", RuntimeHelpers.GetObjectValue(dataRow2["branch"]));
											sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
											sqlCommand.Parameters.AddWithValue("comment", "CHANGE BRANCH PRICES");
											sqlCommand.Parameters.AddWithValue("new_entryno", num2);
											sqlCommand.ExecuteNonQuery();
										}
									}
									finally
									{
										IEnumerator enumerator;
										if (enumerator is IDisposable)
										{
											(enumerator as IDisposable).Dispose();
										}
									}
								}
								else
								{
									sqlCommand.Parameters.Clear();
									sqlCommand.CommandType = CommandType.StoredProcedure;
									sqlCommand.CommandText = "Audit_PriceChangeInsert";
									sqlCommand.Parameters.AddWithValue("productid", num5);
									sqlCommand.Parameters.AddWithValue("systemdate", DateTime.Now);
									sqlCommand.Parameters.AddWithValue("IsCostPriceChanged", false);
									sqlCommand.Parameters.AddWithValue("IsSellingPriceChanged", flag7);
									sqlCommand.Parameters.AddWithValue("IsWholesalePriceChanged", flag8);
									sqlCommand.Parameters.AddWithValue("IsWholesaleQtyChanged", flag9);
									sqlCommand.Parameters.AddWithValue("Old_CostPrice", 0);
									sqlCommand.Parameters.AddWithValue("New_CostPrice", 0);
									sqlCommand.Parameters.AddWithValue("Old_SellingPrice", RuntimeHelpers.GetObjectValue(dataRow["sellingprice"]));
									sqlCommand.Parameters.AddWithValue("New_SellingPrice", num4);
									sqlCommand.Parameters.AddWithValue("Old_WholesalePrice", RuntimeHelpers.GetObjectValue(dataRow["sellingpricewholesale"]));
									sqlCommand.Parameters.AddWithValue("New_WholesalePrice", num6);
									sqlCommand.Parameters.AddWithValue("Old_WholesaleQty", RuntimeHelpers.GetObjectValue(dataRow["wholesaleqty"]));
									sqlCommand.Parameters.AddWithValue("New_WholesaleQty", num7);
									sqlCommand.Parameters.AddWithValue("ChangesDoneBy", MyProject.Forms.Form1.username);
									sqlCommand.Parameters.AddWithValue("ComputerName", Environment.MachineName);
									sqlCommand.Parameters.AddWithValue("branch", this.CurrentBranch);
									sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
									sqlCommand.Parameters.AddWithValue("comment", "CHANGE BRANCH PRICES");
									sqlCommand.Parameters.AddWithValue("new_entryno", num2);
									sqlCommand.ExecuteNonQuery();
								}
							}
							bool flag17 = num == 1;
							if (flag17)
							{
								try
								{
									foreach (object obj2 in MyProject.Forms.Form1.datPriceBranches.Rows)
									{
										DataRow dataRow3 = (DataRow)obj2;
										sqlCommand.Parameters.Clear();
										sqlCommand.CommandType = CommandType.StoredProcedure;
										sqlCommand.CommandText = "SaveBranchPrices";
										sqlCommand.Parameters.AddWithValue("ProductID", num5);
										sqlCommand.Parameters.AddWithValue("ProductSellingPrice", num4);
										sqlCommand.Parameters.AddWithValue("DoneBy", MyProject.Forms.Form1.username);
										sqlCommand.Parameters.AddWithValue("DoneWhen", Conversion.Val(DateTime.Today.ToString("yyyyMMdd")));
										sqlCommand.Parameters.AddWithValue("wholesaleprice", num6);
										sqlCommand.Parameters.AddWithValue("wholesaleqty", num7);
										sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
										sqlCommand.Parameters.AddWithValue("specialprice", num8);
										sqlCommand.Parameters.AddWithValue("branch", RuntimeHelpers.GetObjectValue(dataRow3["branch"]));
										sqlCommand.Parameters.AddWithValue("isglobal", 0);
										sqlCommand.ExecuteNonQuery();
										num3++;
									}
								}
								finally
								{
									IEnumerator enumerator2;
									if (enumerator2 is IDisposable)
									{
										(enumerator2 as IDisposable).Dispose();
									}
								}
							}
							else
							{
								bool flag18 = (num == 0) & (this.IsGlobal == 0);
								if (flag18)
								{
									sqlCommand.Parameters.Clear();
									sqlCommand.CommandType = CommandType.StoredProcedure;
									sqlCommand.CommandText = "SaveBranchPrices";
									sqlCommand.Parameters.AddWithValue("ProductID", num5);
									sqlCommand.Parameters.AddWithValue("ProductSellingPrice", num4);
									sqlCommand.Parameters.AddWithValue("DoneBy", MyProject.Forms.Form1.username);
									sqlCommand.Parameters.AddWithValue("DoneWhen", Conversion.Val(DateTime.Today.ToString("yyyyMMdd")));
									sqlCommand.Parameters.AddWithValue("wholesaleprice", num6);
									sqlCommand.Parameters.AddWithValue("wholesaleqty", num7);
									sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
									sqlCommand.Parameters.AddWithValue("specialprice", num8);
									sqlCommand.Parameters.AddWithValue("branch", this.cboBranch.Text);
									sqlCommand.Parameters.AddWithValue("isglobal", 0);
									sqlCommand.ExecuteNonQuery();
								}
								else
								{
									bool flag19 = (num == 0) & (this.IsGlobal == 1);
									if (flag19)
									{
										sqlCommand.Parameters.Clear();
										sqlCommand.CommandType = CommandType.StoredProcedure;
										sqlCommand.CommandText = "SaveBranchPrices";
										sqlCommand.Parameters.AddWithValue("ProductID", num5);
										sqlCommand.Parameters.AddWithValue("ProductSellingPrice", num4);
										sqlCommand.Parameters.AddWithValue("DoneBy", MyProject.Forms.Form1.username);
										sqlCommand.Parameters.AddWithValue("DoneWhen", Conversion.Val(DateTime.Today.ToString("yyyyMMdd")));
										sqlCommand.Parameters.AddWithValue("wholesaleprice", num6);
										sqlCommand.Parameters.AddWithValue("wholesaleqty", num7);
										sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
										sqlCommand.Parameters.AddWithValue("specialprice", num8);
										sqlCommand.Parameters.AddWithValue("branch", this.CurrentBranch);
										sqlCommand.Parameters.AddWithValue("isglobal", this.IsGlobal);
										sqlCommand.ExecuteNonQuery();
										num3++;
									}
								}
							}
							sqlTransaction.Commit();
							sqlCommand.Connection.Close();
							MessageBox.Show(num3.ToString() + " Price changes saved.");
							bool flag20 = this.IsGlobal == 1;
							if (flag20)
							{
								this.LoadGlobalPrices();
							}
							else
							{
								this.loadBranchPrices(this.cboBranch.Text);
							}
						}
						catch (Exception ex)
						{
							MessageBox.Show("Error saving price changes. Detail: " + ex.Message);
							try
							{
								sqlTransaction.Rollback();
								sqlConnection.Close();
							}
							catch (Exception ex2)
							{
							}
						}
					}
				}
			}
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x0002AC74 File Offset: 0x00028E74
		private void cboBranch_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.loadBranchPrices(this.cboBranch.Text);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x0002ACB8 File Offset: 0x00028EB8
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

		// Token: 0x06000467 RID: 1127 RVA: 0x0002AD24 File Offset: 0x00028F24
		private void Button3_Click(object sender, EventArgs e)
		{
			try
			{
				this.lblerror.Text = "...";
				this.FetchAllProductsSearch();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x0002AD84 File Offset: 0x00028F84
		private void DGVSearch_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					int num = Conversions.ToInteger(this.DGVSearch.Rows[e.RowIndex].Cells["ProductID"].Value);
					this.txtProductCode.Text = Conversions.ToString(num);
				}
			}
			catch (Exception ex)
			{
				this.lblerror.Text = "Error: " + ex.Message;
			}
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x0002AE48 File Offset: 0x00029048
		private void txtProductCode_TextChanged(object sender, EventArgs e)
		{
			try
			{
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvProducts.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						bool flag = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["ProductID"].Value, this.txtProductCode.Text, false);
						if (flag)
						{
							this.dgvProducts.ClearSelection();
							dataGridViewRow.Cells["ProductDesc"].Selected = true;
							this.dgvProducts.CurrentCell = dataGridViewRow.Cells["ProductDesc"];
							break;
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x0002AF38 File Offset: 0x00029138
		private void FetchAllProductsSearch()
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

		// Token: 0x0600046B RID: 1131 RVA: 0x0002B110 File Offset: 0x00029310
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

		// Token: 0x0600046C RID: 1132 RVA: 0x0002B208 File Offset: 0x00029408
		private void DGVSearch_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				bool flag = e.KeyCode == Keys.Return;
				if (flag)
				{
					this.txtsearch.Focus();
					e.Handled = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Key down error. Ignore");
			}
		}

		// Token: 0x04000205 RID: 517
		private string _cnn;

		// Token: 0x04000206 RID: 518
		private string CurrentBranch;

		// Token: 0x04000207 RID: 519
		private int IsGlobal;

		// Token: 0x04000208 RID: 520
		private DataTable dat_compare;
	}
}
