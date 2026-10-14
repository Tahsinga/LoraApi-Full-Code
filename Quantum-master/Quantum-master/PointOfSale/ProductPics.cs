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
	// Token: 0x02000172 RID: 370
	[DesignerGenerated]
	public partial class ProductPics : Form
	{
		// Token: 0x06003475 RID: 13429 RVA: 0x001C52E8 File Offset: 0x001C34E8
		public ProductPics()
		{
			base.Load += this.ProductPics_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.CurrentID = 0;
			this.InitializeComponent();
		}

		// Token: 0x17001383 RID: 4995
		// (get) Token: 0x06003478 RID: 13432 RVA: 0x001C5E96 File Offset: 0x001C4096
		// (set) Token: 0x06003479 RID: 13433 RVA: 0x001C5EA0 File Offset: 0x001C40A0
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001384 RID: 4996
		// (get) Token: 0x0600347A RID: 13434 RVA: 0x001C5EA9 File Offset: 0x001C40A9
		// (set) Token: 0x0600347B RID: 13435 RVA: 0x001C5EB3 File Offset: 0x001C40B3
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001385 RID: 4997
		// (get) Token: 0x0600347C RID: 13436 RVA: 0x001C5EBC File Offset: 0x001C40BC
		// (set) Token: 0x0600347D RID: 13437 RVA: 0x001C5EC8 File Offset: 0x001C40C8
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

		// Token: 0x17001386 RID: 4998
		// (get) Token: 0x0600347E RID: 13438 RVA: 0x001C5F26 File Offset: 0x001C4126
		// (set) Token: 0x0600347F RID: 13439 RVA: 0x001C5F30 File Offset: 0x001C4130
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001387 RID: 4999
		// (get) Token: 0x06003480 RID: 13440 RVA: 0x001C5F39 File Offset: 0x001C4139
		// (set) Token: 0x06003481 RID: 13441 RVA: 0x001C5F44 File Offset: 0x001C4144
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

		// Token: 0x17001388 RID: 5000
		// (get) Token: 0x06003482 RID: 13442 RVA: 0x001C5F87 File Offset: 0x001C4187
		// (set) Token: 0x06003483 RID: 13443 RVA: 0x001C5F91 File Offset: 0x001C4191
		internal virtual Label Label12
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001389 RID: 5001
		// (get) Token: 0x06003484 RID: 13444 RVA: 0x001C5F9A File Offset: 0x001C419A
		// (set) Token: 0x06003485 RID: 13445 RVA: 0x001C5FA4 File Offset: 0x001C41A4
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

		// Token: 0x1700138A RID: 5002
		// (get) Token: 0x06003486 RID: 13446 RVA: 0x001C5FE7 File Offset: 0x001C41E7
		// (set) Token: 0x06003487 RID: 13447 RVA: 0x001C5FF1 File Offset: 0x001C41F1
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700138B RID: 5003
		// (get) Token: 0x06003488 RID: 13448 RVA: 0x001C5FFA File Offset: 0x001C41FA
		// (set) Token: 0x06003489 RID: 13449 RVA: 0x001C6004 File Offset: 0x001C4204
		internal virtual TextBox txtDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700138C RID: 5004
		// (get) Token: 0x0600348A RID: 13450 RVA: 0x001C600D File Offset: 0x001C420D
		// (set) Token: 0x0600348B RID: 13451 RVA: 0x001C6017 File Offset: 0x001C4217
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700138D RID: 5005
		// (get) Token: 0x0600348C RID: 13452 RVA: 0x001C6020 File Offset: 0x001C4220
		// (set) Token: 0x0600348D RID: 13453 RVA: 0x001C602C File Offset: 0x001C422C
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

		// Token: 0x1700138E RID: 5006
		// (get) Token: 0x0600348E RID: 13454 RVA: 0x001C606F File Offset: 0x001C426F
		// (set) Token: 0x0600348F RID: 13455 RVA: 0x001C6079 File Offset: 0x001C4279
		internal virtual Label Label20
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700138F RID: 5007
		// (get) Token: 0x06003490 RID: 13456 RVA: 0x001C6082 File Offset: 0x001C4282
		// (set) Token: 0x06003491 RID: 13457 RVA: 0x001C608C File Offset: 0x001C428C
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

		// Token: 0x17001390 RID: 5008
		// (get) Token: 0x06003492 RID: 13458 RVA: 0x001C60CF File Offset: 0x001C42CF
		// (set) Token: 0x06003493 RID: 13459 RVA: 0x001C60DC File Offset: 0x001C42DC
		internal virtual Button btnChoose
		{
			[CompilerGenerated]
			get
			{
				return this._btnChoose;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.btnChoose_Click);
				Button button = this._btnChoose;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._btnChoose = value;
				button = this._btnChoose;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17001391 RID: 5009
		// (get) Token: 0x06003494 RID: 13460 RVA: 0x001C611F File Offset: 0x001C431F
		// (set) Token: 0x06003495 RID: 13461 RVA: 0x001C612C File Offset: 0x001C432C
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

		// Token: 0x17001392 RID: 5010
		// (get) Token: 0x06003496 RID: 13462 RVA: 0x001C616F File Offset: 0x001C436F
		// (set) Token: 0x06003497 RID: 13463 RVA: 0x001C6179 File Offset: 0x001C4379
		internal virtual Label lblcode
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06003498 RID: 13464 RVA: 0x001C6184 File Offset: 0x001C4384
		private void ProductPics_Load(object sender, EventArgs e)
		{
			try
			{
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail:" + ex.Message);
			}
		}

		// Token: 0x06003499 RID: 13465 RVA: 0x001C61CC File Offset: 0x001C43CC
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

		// Token: 0x0600349A RID: 13466 RVA: 0x001C6254 File Offset: 0x001C4454
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

		// Token: 0x0600349B RID: 13467 RVA: 0x001C634C File Offset: 0x001C454C
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

		// Token: 0x0600349C RID: 13468 RVA: 0x001C6458 File Offset: 0x001C4658
		private object searchDat(DataTable dt, string column, string value)
		{
			ProductPics._Closure$__74-0 CS$<>8__locals1 = new ProductPics._Closure$__74-0(CS$<>8__locals1);
			CS$<>8__locals1.$VB$Local_column = column;
			CS$<>8__locals1.$VB$Local_value = value;
			DataTable dataTable = dt.Clone();
			dt.CaseSensitive = false;
			try
			{
				foreach (DataRow dataRow in dt.Rows.Cast<object>().Select<object, DataRow>((ProductPics._Closure$__.$I74-0 == null) ? (ProductPics._Closure$__.$I74-0 = (object row1) => (DataRow)row1) : ProductPics._Closure$__.$I74-0).Where<DataRow>((CS$<>8__locals1.$I1 == null) ? (CS$<>8__locals1.$I1 = (DataRow row1) => Conversions.ToBoolean(NewLateBinding.LateGet(row1[CS$<>8__locals1.$VB$Local_column], null, "Contains", new object[] { CS$<>8__locals1.$VB$Local_value.ToUpper() }, null, null, null))) : CS$<>8__locals1.$I1))
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

		// Token: 0x0600349D RID: 13469 RVA: 0x001C6534 File Offset: 0x001C4734
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

		// Token: 0x0600349E RID: 13470 RVA: 0x001C65BC File Offset: 0x001C47BC
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

		// Token: 0x0600349F RID: 13471 RVA: 0x001C6794 File Offset: 0x001C4994
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

		// Token: 0x060034A0 RID: 13472 RVA: 0x001C67F4 File Offset: 0x001C49F4
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

		// Token: 0x060034A1 RID: 13473 RVA: 0x001C68B8 File Offset: 0x001C4AB8
		private void DGVSearch_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				bool flag = e.KeyCode == Keys.Return;
				if (flag)
				{
					this.btnChoose.Focus();
					e.Handled = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Key down error on search. Ignore");
			}
		}

		// Token: 0x060034A2 RID: 13474 RVA: 0x001C6918 File Offset: 0x001C4B18
		private void txtBarCode_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.txtDesc.Text = "No product matches your search.";
				this.SearchProductCode(Conversions.ToString(Interaction.IIf(Operators.CompareString(this.txtBarCode.Text, "", false) == 0, 0, this.txtBarCode.Text)));
			}
			catch (Exception ex)
			{
				MessageBox.Show("Bar code error. Detail: " + ex.Message);
			}
		}

		// Token: 0x060034A3 RID: 13475 RVA: 0x001C69AC File Offset: 0x001C4BAC
		private void SearchBarCode(int prodtID)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchProductByID2";
			sqlCommand.Parameters.AddWithValue("prodtID", prodtID);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				this.txtDesc.Text = Conversions.ToString(Operators.AddObject(Operators.AddObject(dataRow["ProductDesc"], " "), dataRow["ProductDesc2"]));
				this.lblcode.Text = Conversions.ToString(dataRow["ProductCode"]);
				decimal num2 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataRow["SellingPrice"]));
				decimal num3 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TaxRate"])), 0, RuntimeHelpers.GetObjectValue(dataRow["TaxRate"]))));
				decimal num4 = decimal.Add(num2, decimal.Multiply(decimal.Divide(num3, 100m), num2));
				num4 = Math.Round(num4, 2);
				this.CurrentID = Conversions.ToInteger(dataRow["ProductID"]);
				this.LoadImage(MyProject.Forms.Form1.coid, prodtID);
			}
			else
			{
				this.txtSearchProductCode.Text = "";
			}
		}

		// Token: 0x060034A4 RID: 13476 RVA: 0x001C6B68 File Offset: 0x001C4D68
		private void SearchProductCode(string prodtcode)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchProductByCode2";
			sqlCommand.Parameters.AddWithValue("productcode", prodtcode);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				this.txtDesc.Text = Conversions.ToString(Operators.AddObject(Operators.AddObject(dataRow["ProductDesc"], " "), dataRow["ProductDesc2"]));
				this.lblcode.Text = Conversions.ToString(dataRow["ProductCode"]);
				this.CurrentID = Conversions.ToInteger(dataRow["ProductID"]);
				this.LoadImage(MyProject.Forms.Form1.coid, Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataRow["ProductID"])));
			}
			else
			{
				this.txtSearchProductCode.Text = "";
			}
		}

		// Token: 0x060034A5 RID: 13477 RVA: 0x001C6CB4 File Offset: 0x001C4EB4
		private void txtSearchProductCode_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.txtDesc.Text = "No product matches your search.";
				this.SearchBarCode(Conversions.ToInteger(Interaction.IIf(Operators.CompareString(this.txtSearchProductCode.Text, "", false) == 0, 0, Conversion.Val(this.txtSearchProductCode.Text))));
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Details: " + ex.Message, "Error");
			}
		}

		// Token: 0x060034A6 RID: 13478 RVA: 0x001C6D58 File Offset: 0x001C4F58
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			bool flag5;
			try
			{
				bool flag = msg.WParam.ToInt32() == 34;
				if (!flag)
				{
					bool flag2 = msg.WParam.ToInt32() == 33;
					if (flag2)
					{
						bool flag3 = MyProject.Forms.Form1.DefaultSearchDesc == 1;
						if (flag3)
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
						bool flag4 = msg.WParam.ToInt32() == 112;
						if (flag4)
						{
							this.txtBarCode.Focus();
						}
					}
				}
				flag5 = base.ProcessCmdKey(ref msg, keyData);
			}
			catch (Exception ex)
			{
			}
			return flag5;
		}

		// Token: 0x060034A7 RID: 13479 RVA: 0x001C6E20 File Offset: 0x001C5020
		private void PrepGrid()
		{
			this.DataGridView1.AutoGenerateColumns = false;
			this.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.DataGridView1.ColumnCount = 4;
			this.DataGridView1.Columns[0].Name = "ID";
			this.DataGridView1.Columns[0].HeaderText = "Product ID";
			this.DataGridView1.Columns[0].DataPropertyName = "productid";
			this.DataGridView1.Columns[1].HeaderText = "Name";
			this.DataGridView1.Columns[1].Name = "Name";
			this.DataGridView1.Columns[1].DataPropertyName = "Name";
			this.DataGridView1.Columns[2].HeaderText = "Path";
			this.DataGridView1.Columns[2].Name = "Path";
			this.DataGridView1.Columns[2].DataPropertyName = "Path";
			DataGridViewImageColumn dataGridViewImageColumn = new DataGridViewImageColumn();
			dataGridViewImageColumn.Name = "Image";
			dataGridViewImageColumn.DataPropertyName = "Data";
			dataGridViewImageColumn.HeaderText = "Image";
			dataGridViewImageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
			this.DataGridView1.Columns.Insert(3, dataGridViewImageColumn);
			this.DataGridView1.RowTemplate.Height = 100;
			this.DataGridView1.Columns[3].Width = 100;
			DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
			dataGridViewButtonColumn.Name = "Delete";
			dataGridViewButtonColumn.DataPropertyName = "Delete";
			dataGridViewButtonColumn.HeaderText = "Delete";
			dataGridViewButtonColumn.Text = "Delete Image";
			dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
			this.DataGridView1.Columns.Insert(4, dataGridViewButtonColumn);
			this.DataGridView1.Columns[5].HeaderText = "EntryNo";
			this.DataGridView1.Columns[5].Name = "EntryNo";
			this.DataGridView1.Columns[5].DataPropertyName = "EntryNo";
			this.DataGridView1.Columns[5].Visible = false;
		}

		// Token: 0x060034A8 RID: 13480 RVA: 0x001C7080 File Offset: 0x001C5280
		private void LoadImage(int coid, int productid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "PicsSelect";
			sqlCommand.Parameters.AddWithValue("productid", productid);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			this.DataGridView1.DataSource = dataTable;
		}

		// Token: 0x060034A9 RID: 13481 RVA: 0x001C7108 File Offset: 0x001C5308
		private void btnChoose_Click(object sender, EventArgs e)
		{
			try
			{
				using (OpenFileDialog openFileDialog = new OpenFileDialog())
				{
					bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
					if (flag)
					{
						string fileName = openFileDialog.FileName;
						SqlConnection sqlConnection = new SqlConnection(this._cnn);
						SqlCommand sqlCommand = sqlConnection.CreateCommand();
						sqlCommand.CommandType = CommandType.Text;
						sqlCommand.CommandText = string.Concat(new string[]
						{
							"UPDATE products SET pic = (SELECT BulkColumn FROM OPENROWSET (BULK '",
							fileName,
							"', SINGLE_BLOB) a) WHERE (productid = ",
							this.CurrentID.ToString(),
							")"
						});
						using (sqlConnection)
						{
							sqlConnection.Open();
							sqlCommand.ExecuteNonQuery();
							sqlConnection.Close();
						}
					}
				}
				this.LoadImage(MyProject.Forms.Form1.coid, this.CurrentID);
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
			catch (Exception ex)
			{
				MessageBox.Show("Error selecting file. Detail: " + ex.Message);
			}
		}

		// Token: 0x060034AA RID: 13482 RVA: 0x001C7290 File Offset: 0x001C5490
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
						SqlConnection sqlConnection = new SqlConnection(this._cnn);
						SqlCommand sqlCommand = sqlConnection.CreateCommand();
						sqlCommand.CommandType = CommandType.StoredProcedure;
						sqlCommand.CommandText = "PicsDelete";
						sqlCommand.Parameters.AddWithValue("entryno", RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[e.RowIndex].Cells["EntryNo"].Value));
						sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
						using (sqlConnection)
						{
							sqlConnection.Open();
							sqlCommand.ExecuteNonQuery();
							sqlConnection.Close();
						}
						this.LoadImage(MyProject.Forms.Form1.coid, this.CurrentID);
						bool flag3 = MyProject.Forms.Form1.DefaultSearchDesc == 1;
						if (flag3)
						{
							this.txtsearch.Focus();
						}
						else
						{
							this.txtBarCode.Focus();
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error. Detail: " + ex.Message);
			}
		}

		// Token: 0x0400168A RID: 5770
		private string _cnn;

		// Token: 0x0400168B RID: 5771
		private int CurrentID;
	}
}
