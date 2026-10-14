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
	// Token: 0x020001EA RID: 490
	[DesignerGenerated]
	public partial class StockLevelsWarehouse : UserControl
	{
		// Token: 0x06005672 RID: 22130 RVA: 0x0031E8B8 File Offset: 0x0031CAB8
		public StockLevelsWarehouse()
		{
			base.Load += this.StockLevels_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x17001F0C RID: 7948
		// (get) Token: 0x06005675 RID: 22133 RVA: 0x0031F8D8 File Offset: 0x0031DAD8
		// (set) Token: 0x06005676 RID: 22134 RVA: 0x0031F8E2 File Offset: 0x0031DAE2
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F0D RID: 7949
		// (get) Token: 0x06005677 RID: 22135 RVA: 0x0031F8EB File Offset: 0x0031DAEB
		// (set) Token: 0x06005678 RID: 22136 RVA: 0x0031F8F5 File Offset: 0x0031DAF5
		internal virtual DataGridView dgvproducts
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F0E RID: 7950
		// (get) Token: 0x06005679 RID: 22137 RVA: 0x0031F8FE File Offset: 0x0031DAFE
		// (set) Token: 0x0600567A RID: 22138 RVA: 0x0031F908 File Offset: 0x0031DB08
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F0F RID: 7951
		// (get) Token: 0x0600567B RID: 22139 RVA: 0x0031F911 File Offset: 0x0031DB11
		// (set) Token: 0x0600567C RID: 22140 RVA: 0x0031F91C File Offset: 0x0031DB1C
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

		// Token: 0x17001F10 RID: 7952
		// (get) Token: 0x0600567D RID: 22141 RVA: 0x0031F95F File Offset: 0x0031DB5F
		// (set) Token: 0x0600567E RID: 22142 RVA: 0x0031F969 File Offset: 0x0031DB69
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F11 RID: 7953
		// (get) Token: 0x0600567F RID: 22143 RVA: 0x0031F972 File Offset: 0x0031DB72
		// (set) Token: 0x06005680 RID: 22144 RVA: 0x0031F97C File Offset: 0x0031DB7C
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F12 RID: 7954
		// (get) Token: 0x06005681 RID: 22145 RVA: 0x0031F985 File Offset: 0x0031DB85
		// (set) Token: 0x06005682 RID: 22146 RVA: 0x0031F98F File Offset: 0x0031DB8F
		internal virtual Label lblValue
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F13 RID: 7955
		// (get) Token: 0x06005683 RID: 22147 RVA: 0x0031F998 File Offset: 0x0031DB98
		// (set) Token: 0x06005684 RID: 22148 RVA: 0x0031F9A2 File Offset: 0x0031DBA2
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F14 RID: 7956
		// (get) Token: 0x06005685 RID: 22149 RVA: 0x0031F9AB File Offset: 0x0031DBAB
		// (set) Token: 0x06005686 RID: 22150 RVA: 0x0031F9B5 File Offset: 0x0031DBB5
		internal virtual Label lblCost
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F15 RID: 7957
		// (get) Token: 0x06005687 RID: 22151 RVA: 0x0031F9BE File Offset: 0x0031DBBE
		// (set) Token: 0x06005688 RID: 22152 RVA: 0x0031F9C8 File Offset: 0x0031DBC8
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F16 RID: 7958
		// (get) Token: 0x06005689 RID: 22153 RVA: 0x0031F9D1 File Offset: 0x0031DBD1
		// (set) Token: 0x0600568A RID: 22154 RVA: 0x0031F9DB File Offset: 0x0031DBDB
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F17 RID: 7959
		// (get) Token: 0x0600568B RID: 22155 RVA: 0x0031F9E4 File Offset: 0x0031DBE4
		// (set) Token: 0x0600568C RID: 22156 RVA: 0x0031F9F0 File Offset: 0x0031DBF0
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

		// Token: 0x17001F18 RID: 7960
		// (get) Token: 0x0600568D RID: 22157 RVA: 0x0031FA4E File Offset: 0x0031DC4E
		// (set) Token: 0x0600568E RID: 22158 RVA: 0x0031FA58 File Offset: 0x0031DC58
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F19 RID: 7961
		// (get) Token: 0x0600568F RID: 22159 RVA: 0x0031FA61 File Offset: 0x0031DC61
		// (set) Token: 0x06005690 RID: 22160 RVA: 0x0031FA6C File Offset: 0x0031DC6C
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

		// Token: 0x17001F1A RID: 7962
		// (get) Token: 0x06005691 RID: 22161 RVA: 0x0031FAAF File Offset: 0x0031DCAF
		// (set) Token: 0x06005692 RID: 22162 RVA: 0x0031FAB9 File Offset: 0x0031DCB9
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F1B RID: 7963
		// (get) Token: 0x06005693 RID: 22163 RVA: 0x0031FAC2 File Offset: 0x0031DCC2
		// (set) Token: 0x06005694 RID: 22164 RVA: 0x0031FACC File Offset: 0x0031DCCC
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

		// Token: 0x17001F1C RID: 7964
		// (get) Token: 0x06005695 RID: 22165 RVA: 0x0031FB0F File Offset: 0x0031DD0F
		// (set) Token: 0x06005696 RID: 22166 RVA: 0x0031FB1C File Offset: 0x0031DD1C
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

		// Token: 0x17001F1D RID: 7965
		// (get) Token: 0x06005697 RID: 22167 RVA: 0x0031FB5F File Offset: 0x0031DD5F
		// (set) Token: 0x06005698 RID: 22168 RVA: 0x0031FB69 File Offset: 0x0031DD69
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F1E RID: 7966
		// (get) Token: 0x06005699 RID: 22169 RVA: 0x0031FB72 File Offset: 0x0031DD72
		// (set) Token: 0x0600569A RID: 22170 RVA: 0x0031FB7C File Offset: 0x0031DD7C
		internal virtual Label lblprodcount
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F1F RID: 7967
		// (get) Token: 0x0600569B RID: 22171 RVA: 0x0031FB85 File Offset: 0x0031DD85
		// (set) Token: 0x0600569C RID: 22172 RVA: 0x0031FB8F File Offset: 0x0031DD8F
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F20 RID: 7968
		// (get) Token: 0x0600569D RID: 22173 RVA: 0x0031FB98 File Offset: 0x0031DD98
		// (set) Token: 0x0600569E RID: 22174 RVA: 0x0031FBA2 File Offset: 0x0031DDA2
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F21 RID: 7969
		// (get) Token: 0x0600569F RID: 22175 RVA: 0x0031FBAB File Offset: 0x0031DDAB
		// (set) Token: 0x060056A0 RID: 22176 RVA: 0x0031FBB5 File Offset: 0x0031DDB5
		internal virtual Label Label9
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F22 RID: 7970
		// (get) Token: 0x060056A1 RID: 22177 RVA: 0x0031FBBE File Offset: 0x0031DDBE
		// (set) Token: 0x060056A2 RID: 22178 RVA: 0x0031FBC8 File Offset: 0x0031DDC8
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

		// Token: 0x17001F23 RID: 7971
		// (get) Token: 0x060056A3 RID: 22179 RVA: 0x0031FC0B File Offset: 0x0031DE0B
		// (set) Token: 0x060056A4 RID: 22180 RVA: 0x0031FC15 File Offset: 0x0031DE15
		internal virtual SaveFileDialog SaveFileDialog1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060056A5 RID: 22181 RVA: 0x0031FC20 File Offset: 0x0031DE20
		private void LoadLevels()
		{
			this.dgvproducts.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "CurrentStockLevelsWarehouse";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			this.dgvproducts.DataSource = dataTable;
			this.dgvproducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvproducts.Columns["ProductID"].HeaderText = "Product ID";
			this.dgvproducts.Columns["ProductDesc"].HeaderText = "Description";
			this.dgvproducts.Columns["BatchNumber"].HeaderText = "Batch Number";
			this.dgvproducts.Columns["ExpiryDate"].HeaderText = "Expiry Date";
			this.dgvproducts.Columns["bal"].HeaderText = "Current Balance";
			this.lblprodcount.Text = this.dgvproducts.RowCount.ToString();
		}

		// Token: 0x060056A6 RID: 22182 RVA: 0x0031FD9C File Offset: 0x0031DF9C
		private void StockLevels_Load(object sender, EventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
				this.LoadLevels();
				this.CalcStockValue();
				this.Cursor = Cursors.Default;
			}
			catch (Exception ex)
			{
				MessageBox.Show("error displaying form. Detail: " + ex.Message);
			}
		}

		// Token: 0x060056A7 RID: 22183 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label3_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x060056A8 RID: 22184 RVA: 0x0031FE0C File Offset: 0x0031E00C
		private double CostofProduct(int prodid, int coid)
		{
			double num = 0.0;
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "CostofProduct";
			sqlCommand.Parameters.AddWithValue("productid", prodid);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			int num2 = sqlDataAdapter.Fill(dataTable);
			bool flag = num2 > 0;
			double num3;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				num = Conversions.ToDouble(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["cost"])), 0, RuntimeHelpers.GetObjectValue(dataRow["cost"])));
				num3 = num;
			}
			else
			{
				num3 = num;
			}
			return num3;
		}

		// Token: 0x060056A9 RID: 22185 RVA: 0x0031FEF0 File Offset: 0x0031E0F0
		private double PriceofProduct(int prodid)
		{
			double num = 0.0;
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SalePriceofProduct";
			sqlCommand.Parameters.AddWithValue("productid", prodid);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			int num2 = sqlDataAdapter.Fill(dataTable);
			bool flag = num2 > 0;
			double num3;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				num = Conversions.ToDouble(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["SellingPrice"])), 0, RuntimeHelpers.GetObjectValue(dataRow["SellingPrice"])));
				num3 = num;
			}
			else
			{
				num3 = num;
			}
			return num3;
		}

		// Token: 0x060056AA RID: 22186 RVA: 0x0031FFE4 File Offset: 0x0031E1E4
		private void CalcStockValue()
		{
			double num = 0.0;
			double num2 = 0.0;
			try
			{
				foreach (object obj in ((IEnumerable)this.dgvproducts.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					int num3 = Conversions.ToInteger(dataGridViewRow.Cells["ProductID"].Value);
					int num4 = Conversions.ToInteger(dataGridViewRow.Cells["bal"].Value);
					double num5 = this.CostofProduct(num3, MyProject.Forms.Form1.coid);
					double num6 = this.PriceofProduct(num3);
					num += (double)num4 * num5;
					num2 += (double)num4 * num6;
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
			num = Math.Round(num, 2);
			num2 = Math.Round(num2, 2);
			this.lblCost.Text = "$" + num.ToString();
			this.lblValue.Text = "$" + num2.ToString();
		}

		// Token: 0x060056AB RID: 22187 RVA: 0x00320114 File Offset: 0x0031E314
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

		// Token: 0x060056AC RID: 22188 RVA: 0x00320174 File Offset: 0x0031E374
		private void txtProductCode_TextChanged(object sender, EventArgs e)
		{
			try
			{
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvproducts.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						bool flag = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["ProductCode"].Value, this.txtProductCode.Text, false);
						if (flag)
						{
							this.dgvproducts.ClearSelection();
							dataGridViewRow.Cells["ProductCode"].Selected = true;
							this.dgvproducts.CurrentCell = dataGridViewRow.Cells["ProductCode"];
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

		// Token: 0x060056AD RID: 22189 RVA: 0x00320264 File Offset: 0x0031E464
		private void DGVSearch_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					string text = Conversions.ToString(this.DGVSearch.Rows[e.RowIndex].Cells["ProductCode"].Value);
					this.txtProductCode.Text = text;
				}
			}
			catch (Exception ex)
			{
				this.lblerror.Text = "Error: " + ex.Message;
			}
		}

		// Token: 0x060056AE RID: 22190 RVA: 0x00320324 File Offset: 0x0031E524
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

		// Token: 0x060056AF RID: 22191 RVA: 0x003204C4 File Offset: 0x0031E6C4
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

		// Token: 0x060056B0 RID: 22192 RVA: 0x00320524 File Offset: 0x0031E724
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

		// Token: 0x060056B1 RID: 22193 RVA: 0x0032061C File Offset: 0x0031E81C
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

		// Token: 0x060056B2 RID: 22194 RVA: 0x00320688 File Offset: 0x0031E888
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.dgvproducts.RowCount > 0;
				if (flag)
				{
					this.SaveFileDialog1.Filter = "EXCEL Files (*.csv*)|*.csv";
					bool flag2 = this.SaveFileDialog1.ShowDialog() == DialogResult.OK;
					if (flag2)
					{
						this.pf.DATAGRIDVIEW_TO_CSV(this.dgvproducts, this.SaveFileDialog1.FileName);
						MessageBox.Show("File saved.");
					}
				}
				else
				{
					MessageBox.Show("There are no rows to export.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error exporting to excel. Detail: " + ex.Message);
			}
		}

		// Token: 0x040025D0 RID: 9680
		private string _cnn;

		// Token: 0x040025D1 RID: 9681
		private PublicFunctions pf;
	}
}
