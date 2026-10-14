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
	// Token: 0x02000050 RID: 80
	[DesignerGenerated]
	public partial class EditProductSupplier : Form
	{
		// Token: 0x0600113F RID: 4415 RVA: 0x000A678C File Offset: 0x000A498C
		public EditProductSupplier()
		{
			base.Load += this.EditProductSupplier_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.dat = new DataTable();
			this.pf = new PublicFunctions();
			this.currentID = 0;
			this.InitializeComponent();
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06001142 RID: 4418 RVA: 0x000A7ACD File Offset: 0x000A5CCD
		// (set) Token: 0x06001143 RID: 4419 RVA: 0x000A7AD7 File Offset: 0x000A5CD7
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06001144 RID: 4420 RVA: 0x000A7AE0 File Offset: 0x000A5CE0
		// (set) Token: 0x06001145 RID: 4421 RVA: 0x000A7AEA File Offset: 0x000A5CEA
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06001146 RID: 4422 RVA: 0x000A7AF3 File Offset: 0x000A5CF3
		// (set) Token: 0x06001147 RID: 4423 RVA: 0x000A7AFD File Offset: 0x000A5CFD
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x06001148 RID: 4424 RVA: 0x000A7B06 File Offset: 0x000A5D06
		// (set) Token: 0x06001149 RID: 4425 RVA: 0x000A7B10 File Offset: 0x000A5D10
		internal virtual Panel Panel3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x0600114A RID: 4426 RVA: 0x000A7B19 File Offset: 0x000A5D19
		// (set) Token: 0x0600114B RID: 4427 RVA: 0x000A7B24 File Offset: 0x000A5D24
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

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x0600114C RID: 4428 RVA: 0x000A7B82 File Offset: 0x000A5D82
		// (set) Token: 0x0600114D RID: 4429 RVA: 0x000A7B8C File Offset: 0x000A5D8C
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x0600114E RID: 4430 RVA: 0x000A7B95 File Offset: 0x000A5D95
		// (set) Token: 0x0600114F RID: 4431 RVA: 0x000A7B9F File Offset: 0x000A5D9F
		internal virtual Label Label34
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06001150 RID: 4432 RVA: 0x000A7BA8 File Offset: 0x000A5DA8
		// (set) Token: 0x06001151 RID: 4433 RVA: 0x000A7BB4 File Offset: 0x000A5DB4
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

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06001152 RID: 4434 RVA: 0x000A7BF7 File Offset: 0x000A5DF7
		// (set) Token: 0x06001153 RID: 4435 RVA: 0x000A7C01 File Offset: 0x000A5E01
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06001154 RID: 4436 RVA: 0x000A7C0A File Offset: 0x000A5E0A
		// (set) Token: 0x06001155 RID: 4437 RVA: 0x000A7C14 File Offset: 0x000A5E14
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
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtsearch_KeyDown);
				TextBox textBox = this._txtsearch;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
					textBox.KeyDown -= keyEventHandler;
				}
				this._txtsearch = value;
				textBox = this._txtsearch;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
					textBox.KeyDown += keyEventHandler;
				}
			}
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06001156 RID: 4438 RVA: 0x000A7C72 File Offset: 0x000A5E72
		// (set) Token: 0x06001157 RID: 4439 RVA: 0x000A7C7C File Offset: 0x000A5E7C
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06001158 RID: 4440 RVA: 0x000A7C85 File Offset: 0x000A5E85
		// (set) Token: 0x06001159 RID: 4441 RVA: 0x000A7C8F File Offset: 0x000A5E8F
		internal virtual Label Label15
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x0600115A RID: 4442 RVA: 0x000A7C98 File Offset: 0x000A5E98
		// (set) Token: 0x0600115B RID: 4443 RVA: 0x000A7CA4 File Offset: 0x000A5EA4
		internal virtual TextBox txtBarcode
		{
			[CompilerGenerated]
			get
			{
				return this._txtBarcode;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtBarCode_KeyDown);
				KeyEventHandler keyEventHandler2 = new KeyEventHandler(this.txtProductCode_KeyDown);
				TextBox textBox = this._txtBarcode;
				if (textBox != null)
				{
					textBox.KeyDown -= keyEventHandler;
					textBox.KeyDown -= keyEventHandler2;
				}
				this._txtBarcode = value;
				textBox = this._txtBarcode;
				if (textBox != null)
				{
					textBox.KeyDown += keyEventHandler;
					textBox.KeyDown += keyEventHandler2;
				}
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x0600115C RID: 4444 RVA: 0x000A7D02 File Offset: 0x000A5F02
		// (set) Token: 0x0600115D RID: 4445 RVA: 0x000A7D0C File Offset: 0x000A5F0C
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

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x0600115E RID: 4446 RVA: 0x000A7D4F File Offset: 0x000A5F4F
		// (set) Token: 0x0600115F RID: 4447 RVA: 0x000A7D59 File Offset: 0x000A5F59
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x06001160 RID: 4448 RVA: 0x000A7D62 File Offset: 0x000A5F62
		// (set) Token: 0x06001161 RID: 4449 RVA: 0x000A7D6C File Offset: 0x000A5F6C
		internal virtual Label lblsupplierid
		{
			[CompilerGenerated]
			get
			{
				return this._lblsupplierid;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.lblsupplierid_TextChanged_1);
				Label label = this._lblsupplierid;
				if (label != null)
				{
					label.TextChanged -= eventHandler;
				}
				this._lblsupplierid = value;
				label = this._lblsupplierid;
				if (label != null)
				{
					label.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x06001162 RID: 4450 RVA: 0x000A7DAF File Offset: 0x000A5FAF
		// (set) Token: 0x06001163 RID: 4451 RVA: 0x000A7DB9 File Offset: 0x000A5FB9
		internal virtual Label lblproductid
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06001164 RID: 4452 RVA: 0x000A7DC2 File Offset: 0x000A5FC2
		// (set) Token: 0x06001165 RID: 4453 RVA: 0x000A7DCC File Offset: 0x000A5FCC
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
				EventHandler eventHandler = new EventHandler(this.Button4_Click_1);
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

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06001166 RID: 4454 RVA: 0x000A7E0F File Offset: 0x000A600F
		// (set) Token: 0x06001167 RID: 4455 RVA: 0x000A7E19 File Offset: 0x000A6019
		internal virtual ComboBox cboSupplier
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x06001168 RID: 4456 RVA: 0x000A7E22 File Offset: 0x000A6022
		// (set) Token: 0x06001169 RID: 4457 RVA: 0x000A7E2C File Offset: 0x000A602C
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x0600116A RID: 4458 RVA: 0x000A7E35 File Offset: 0x000A6035
		// (set) Token: 0x0600116B RID: 4459 RVA: 0x000A7E3F File Offset: 0x000A603F
		internal virtual Label lblSupplier
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x0600116C RID: 4460 RVA: 0x000A7E48 File Offset: 0x000A6048
		// (set) Token: 0x0600116D RID: 4461 RVA: 0x000A7E52 File Offset: 0x000A6052
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x0600116E RID: 4462 RVA: 0x000A7E5B File Offset: 0x000A605B
		// (set) Token: 0x0600116F RID: 4463 RVA: 0x000A7E65 File Offset: 0x000A6065
		internal virtual Label lblDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06001170 RID: 4464 RVA: 0x000A7E6E File Offset: 0x000A606E
		// (set) Token: 0x06001171 RID: 4465 RVA: 0x000A7E78 File Offset: 0x000A6078
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
				EventHandler eventHandler = new EventHandler(this.Button1_Click_1);
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

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06001172 RID: 4466 RVA: 0x000A7EBB File Offset: 0x000A60BB
		// (set) Token: 0x06001173 RID: 4467 RVA: 0x000A7EC5 File Offset: 0x000A60C5
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06001174 RID: 4468 RVA: 0x000A7ECE File Offset: 0x000A60CE
		// (set) Token: 0x06001175 RID: 4469 RVA: 0x000A7ED8 File Offset: 0x000A60D8
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06001176 RID: 4470 RVA: 0x000A7EE4 File Offset: 0x000A60E4
		private void EditProductSupplier_Load(object sender, EventArgs e)
		{
			try
			{
				bool isbranch = MyProject.Forms.Form1.isbranch;
				if (isbranch)
				{
					MessageBox.Show("This is a branch computer and cannot edit products. Product detail changes should be changed at HQ.");
					base.Dispose();
				}
				this.cboSupplier.DataSource = this.pf.GetSuppliersList(this._cnn);
				this.cboSupplier.ValueMember = "supplierid";
				this.cboSupplier.DisplayMember = "SupplierName";
				this.cboSupplier.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
				this.cboSupplier.AutoCompleteSource = AutoCompleteSource.ListItems;
				this.cboSupplier.SelectedIndex = -1;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001177 RID: 4471 RVA: 0x000A7FBC File Offset: 0x000A61BC
		private void txtsearch_TextChanged(object sender, EventArgs e)
		{
			try
			{
				bool flag = MyProject.Forms.Form1.OnlineSearchOptimised == 0;
				if (flag)
				{
					this.lblerror.Text = "...";
					this.txtBarcode.Text = "";
					this.SearchByDescAdvanced(this.txtsearch.Text);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001178 RID: 4472 RVA: 0x000A8054 File Offset: 0x000A6254
		private void txtsearch_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				bool flag = e.KeyCode == Keys.Tab;
				if (flag)
				{
					this.DGVSearch.Focus();
					e.Handled = true;
				}
				else
				{
					bool flag2 = e.KeyCode == Keys.Return;
					if (flag2)
					{
						this.lblerror.Text = "...";
						this.SearchByDescAdvanced(this.txtsearch.Text);
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001179 RID: 4473 RVA: 0x000A80DC File Offset: 0x000A62DC
		private void txtBarCode_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				try
				{
					this.lblerror.Text = "";
					this.lblDesc.Text = "No product matches your search.";
					this.SearchBarCode(Conversions.ToString(Interaction.IIf(Operators.CompareString(this.txtBarcode.Text, "", false) == 0, 0, this.txtBarcode.Text)));
				}
				catch (Exception ex)
				{
					MessageBox.Show("Bar code error. Detail: " + ex.Message);
				}
			}
		}

		// Token: 0x0600117A RID: 4474 RVA: 0x000A8194 File Offset: 0x000A6394
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

		// Token: 0x0600117B RID: 4475 RVA: 0x000A828C File Offset: 0x000A648C
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

		// Token: 0x0600117C RID: 4476 RVA: 0x000A8398 File Offset: 0x000A6598
		private object searchDat(DataTable dt, string column, string value)
		{
			EditProductSupplier._Closure$__118-0 CS$<>8__locals1 = new EditProductSupplier._Closure$__118-0(CS$<>8__locals1);
			CS$<>8__locals1.$VB$Local_column = column;
			CS$<>8__locals1.$VB$Local_value = value;
			DataTable dataTable = dt.Clone();
			dt.CaseSensitive = false;
			try
			{
				foreach (DataRow dataRow in dt.Rows.Cast<object>().Select<object, DataRow>((EditProductSupplier._Closure$__.$I118-0 == null) ? (EditProductSupplier._Closure$__.$I118-0 = (object row1) => (DataRow)row1) : EditProductSupplier._Closure$__.$I118-0).Where<DataRow>((CS$<>8__locals1.$I1 == null) ? (CS$<>8__locals1.$I1 = (DataRow row1) => Conversions.ToBoolean(NewLateBinding.LateGet(row1[CS$<>8__locals1.$VB$Local_column], null, "Contains", new object[] { CS$<>8__locals1.$VB$Local_value.ToUpper() }, null, null, null))) : CS$<>8__locals1.$I1))
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

		// Token: 0x0600117D RID: 4477 RVA: 0x000A8474 File Offset: 0x000A6674
		private DataTable searchDB(string searchtext)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SearchProduct2";
			sqlCommand.Parameters.AddWithValue("search", searchtext);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("isingridient", 0);
			sqlCommand.Parameters.AddWithValue("username", MyProject.Forms.Form1.username);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x0600117E RID: 4478 RVA: 0x000A8534 File Offset: 0x000A6734
		private void FetchAllProducts()
		{
			this.lblerror.Text = "...";
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectAllProducts2";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("isingridient", 0);
			sqlCommand.Parameters.AddWithValue("username", MyProject.Forms.Form1.username);
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

		// Token: 0x0600117F RID: 4479 RVA: 0x000A8744 File Offset: 0x000A6944
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

		// Token: 0x06001180 RID: 4480 RVA: 0x000A87A4 File Offset: 0x000A69A4
		private void DGVSearch_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					this.txtBarcode.Text = "";
					int num = Conversions.ToInteger(this.DGVSearch.Rows[e.RowIndex].Cells["ProductID"].Value);
					this.txtSearchProductCode.Text = Conversions.ToString(num);
				}
			}
			catch (Exception ex)
			{
				this.lblerror.Text = "Error: " + ex.Message;
			}
		}

		// Token: 0x06001181 RID: 4481 RVA: 0x000A8878 File Offset: 0x000A6A78
		private void DGVSearch_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				bool flag = e.KeyCode == Keys.Return;
				if (flag)
				{
					this.cboSupplier.Focus();
					e.Handled = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Key down error. Ignore");
			}
		}

		// Token: 0x06001182 RID: 4482 RVA: 0x000A88D8 File Offset: 0x000A6AD8
		private void txtSearchProductCode_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.lblDesc.Text = "...";
				this.lblSupplier.Text = "...";
				bool flag = (Operators.CompareString(this.txtSearchProductCode.Text, " ", false) != 0) | (Operators.CompareString(this.txtSearchProductCode.Text, "", false) != 0);
				if (flag)
				{
					this.SearchProductID(Conversions.ToInteger(Interaction.IIf(Operators.CompareString(this.txtSearchProductCode.Text, "", false) == 0, 0, Conversion.Val(this.txtSearchProductCode.Text))));
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001183 RID: 4483 RVA: 0x000A89C0 File Offset: 0x000A6BC0
		private void SearchBarCode(string prodtcode)
		{
			bool flag = Operators.CompareString(prodtcode, "", false) == 0;
			if (flag)
			{
				this.txtSearchProductCode.Text = "";
			}
			else
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.Text;
				sqlCommand.CommandText = string.Concat(new string[]
				{
					"select productid,productcode,productdesc,productdesc2,p.supplierid from products p where p.coid=",
					Conversions.ToString(MyProject.Forms.Form1.coid),
					" and productcode='",
					prodtcode,
					"'"
				});
				DataTable dataTable = new DataTable();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				int num = sqlDataAdapter.Fill(dataTable);
				bool flag2 = num > 0;
				if (flag2)
				{
					DataRow dataRow = dataTable.Rows[0];
					this.lblDesc.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(dataRow["ProductDesc"], "("), dataRow["ProductDesc2"]), ")"));
					this.lblsupplierid.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["supplierid"])), 0, RuntimeHelpers.GetObjectValue(dataRow["supplierid"])));
					this.currentID = Conversions.ToInteger(dataRow["productid"]);
				}
				else
				{
					this.currentID = 0;
					this.txtSearchProductCode.Text = "";
				}
			}
		}

		// Token: 0x06001184 RID: 4484 RVA: 0x000A8B48 File Offset: 0x000A6D48
		private void SearchProductID(int prodtID)
		{
			bool flag = prodtID == 0;
			if (flag)
			{
				this.txtSearchProductCode.Text = "";
			}
			else
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.Text;
				sqlCommand.CommandText = "select productid,productcode,productdesc,productdesc2,p.supplierid from products p where p.coid=" + Conversions.ToString(MyProject.Forms.Form1.coid) + " and productid=" + Conversions.ToString(prodtID);
				DataTable dataTable = new DataTable();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				int num = sqlDataAdapter.Fill(dataTable);
				bool flag2 = num > 0;
				if (flag2)
				{
					DataRow dataRow = dataTable.Rows[0];
					this.lblDesc.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(dataRow["ProductDesc"], "("), dataRow["ProductDesc2"]), ")"));
					this.lblsupplierid.Text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["supplierid"])), 0, RuntimeHelpers.GetObjectValue(dataRow["supplierid"])));
					this.currentID = Conversions.ToInteger(dataRow["productid"]);
				}
				else
				{
					this.currentID = 0;
					this.txtSearchProductCode.Text = "";
				}
			}
		}

		// Token: 0x06001185 RID: 4485 RVA: 0x00002A30 File Offset: 0x00000C30
		private void Button1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06001186 RID: 4486 RVA: 0x000A8CB0 File Offset: 0x000A6EB0
		private void txtProductCode_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				bool flag = e.KeyCode == Keys.Return;
				if (flag)
				{
					this.lblDesc.Text = "...";
					this.lblSupplier.Text = "...";
					this.txtSearchProductCode.Text = "";
					bool flag2 = (Operators.CompareString(this.txtSearchProductCode.Text, " ", false) != 0) | (Operators.CompareString(this.txtSearchProductCode.Text, "", false) != 0);
					if (flag2)
					{
						this.SearchBarCode(Conversions.ToString(Interaction.IIf(Operators.CompareString(this.txtBarcode.Text, "", false) == 0, 0, Conversion.Val(this.txtBarcode.Text))));
					}
				}
				this.CheckSupplierName();
				this.txtsearch.Text = "";
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001187 RID: 4487 RVA: 0x000A8DD4 File Offset: 0x000A6FD4
		private void Button4_Click(object sender, EventArgs e)
		{
			try
			{
				Suppliers suppliers = new Suppliers();
				suppliers.ShowDialog(this);
				suppliers.Dispose();
				string suppliername = MyProject.Forms.Form1.suppliername;
				this.cboSupplier.DataSource = this.pf.GetSuppliersList(this._cnn);
				this.cboSupplier.ValueMember = "SupplierID";
				this.cboSupplier.DisplayMember = "SupplierName";
				this.cboSupplier.SelectedIndex = -1;
				this.cboSupplier.SelectedIndex = this.cboSupplier.FindStringExact(MyProject.Forms.Form1.suppliername);
				this.Button1.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error entering new supplier details at new stock purchase");
			}
		}

		// Token: 0x06001188 RID: 4488 RVA: 0x000A8EB4 File Offset: 0x000A70B4
		private void lblsupplierid_TextChanged_1(object sender, EventArgs e)
		{
			try
			{
				this.CheckSupplierName();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error getting supplier name. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001189 RID: 4489 RVA: 0x000A8F04 File Offset: 0x000A7104
		private void CheckSupplierName()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = "select suppliername from suppliers where coid=" + Conversions.ToString(MyProject.Forms.Form1.coid) + " and supplierid=" + Conversions.ToString(Conversions.ToInteger(this.lblsupplierid.Text));
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				this.lblSupplier.Text = Conversions.ToString(dataRow["suppliername"]);
			}
			else
			{
				this.lblSupplier.Text = "NO SUPPLIER";
			}
		}

		// Token: 0x0600118A RID: 4490 RVA: 0x000A8FD0 File Offset: 0x000A71D0
		private void Button4_Click_1(object sender, EventArgs e)
		{
			try
			{
				Suppliers suppliers = new Suppliers();
				suppliers.ShowDialog(this);
				suppliers.Dispose();
				string suppliername = MyProject.Forms.Form1.suppliername;
				this.cboSupplier.DataSource = this.pf.GetSuppliersList(this._cnn);
				this.cboSupplier.ValueMember = "SupplierID";
				this.cboSupplier.DisplayMember = "SupplierName";
				this.cboSupplier.SelectedIndex = -1;
				this.cboSupplier.SelectedIndex = this.cboSupplier.FindStringExact(MyProject.Forms.Form1.suppliername);
				this.Button1.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error entering new supplier details at new stock purchase");
			}
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x000A90B0 File Offset: 0x000A72B0
		private void Button1_Click_1(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.cboSupplier.SelectedIndex == -1;
				if (flag)
				{
					MessageBox.Show("Please select a supplier first.");
					this.cboSupplier.Focus();
				}
				else
				{
					bool flag2 = this.currentID == 0;
					if (flag2)
					{
						MessageBox.Show("Please select a product first.");
						this.txtsearch.Focus();
					}
					else
					{
						SqlConnection sqlConnection = new SqlConnection(this._cnn);
						SqlCommand sqlCommand = sqlConnection.CreateCommand();
						sqlCommand.CommandType = CommandType.Text;
						sqlCommand.CommandText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("update products set supplierid=", this.cboSupplier.SelectedValue), " where coid="), MyProject.Forms.Form1.coid), " and productid="), this.currentID));
						int num = 0;
						using (sqlConnection)
						{
							sqlConnection.Open();
							num = sqlCommand.ExecuteNonQuery();
							sqlConnection.Close();
						}
						bool flag3 = num > 0;
						if (flag3)
						{
							MessageBox.Show("Product supplier changed successfully.");
							this.SearchProductID(this.currentID);
						}
						else
						{
							MessageBox.Show("Changes NOT saved! Odd error check coid and product ID.");
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving supplier. Detail: " + ex.Message);
			}
		}

		// Token: 0x0400083C RID: 2108
		private string _cnn;

		// Token: 0x0400083D RID: 2109
		private DataTable dat;

		// Token: 0x0400083E RID: 2110
		private PublicFunctions pf;

		// Token: 0x0400083F RID: 2111
		private int currentID;
	}
}
