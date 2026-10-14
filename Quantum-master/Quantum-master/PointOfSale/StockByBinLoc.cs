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
	// Token: 0x020001E8 RID: 488
	[DesignerGenerated]
	public partial class StockByBinLoc : UserControl
	{
		// Token: 0x060055ED RID: 21997 RVA: 0x0031A428 File Offset: 0x00318628
		public StockByBinLoc()
		{
			base.Load += this.StockBalancesByCategory_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pfunctions = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x17001EDC RID: 7900
		// (get) Token: 0x060055F0 RID: 22000 RVA: 0x0031B3E2 File Offset: 0x003195E2
		// (set) Token: 0x060055F1 RID: 22001 RVA: 0x0031B3EC File Offset: 0x003195EC
		internal virtual DataGridView dgvproducts
		{
			[CompilerGenerated]
			get
			{
				return this._dgvproducts;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewRowPostPaintEventHandler dataGridViewRowPostPaintEventHandler = new DataGridViewRowPostPaintEventHandler(this.dgvproducts_RowPostPaint);
				DataGridView dataGridView = this._dgvproducts;
				if (dataGridView != null)
				{
					dataGridView.RowPostPaint -= dataGridViewRowPostPaintEventHandler;
				}
				this._dgvproducts = value;
				dataGridView = this._dgvproducts;
				if (dataGridView != null)
				{
					dataGridView.RowPostPaint += dataGridViewRowPostPaintEventHandler;
				}
			}
		}

		// Token: 0x17001EDD RID: 7901
		// (get) Token: 0x060055F2 RID: 22002 RVA: 0x0031B42F File Offset: 0x0031962F
		// (set) Token: 0x060055F3 RID: 22003 RVA: 0x0031B439 File Offset: 0x00319639
		internal virtual Label lblValue
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001EDE RID: 7902
		// (get) Token: 0x060055F4 RID: 22004 RVA: 0x0031B442 File Offset: 0x00319642
		// (set) Token: 0x060055F5 RID: 22005 RVA: 0x0031B44C File Offset: 0x0031964C
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001EDF RID: 7903
		// (get) Token: 0x060055F6 RID: 22006 RVA: 0x0031B455 File Offset: 0x00319655
		// (set) Token: 0x060055F7 RID: 22007 RVA: 0x0031B45F File Offset: 0x0031965F
		internal virtual Label lblCost
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001EE0 RID: 7904
		// (get) Token: 0x060055F8 RID: 22008 RVA: 0x0031B468 File Offset: 0x00319668
		// (set) Token: 0x060055F9 RID: 22009 RVA: 0x0031B472 File Offset: 0x00319672
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001EE1 RID: 7905
		// (get) Token: 0x060055FA RID: 22010 RVA: 0x0031B47B File Offset: 0x0031967B
		// (set) Token: 0x060055FB RID: 22011 RVA: 0x0031B485 File Offset: 0x00319685
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001EE2 RID: 7906
		// (get) Token: 0x060055FC RID: 22012 RVA: 0x0031B48E File Offset: 0x0031968E
		// (set) Token: 0x060055FD RID: 22013 RVA: 0x0031B498 File Offset: 0x00319698
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001EE3 RID: 7907
		// (get) Token: 0x060055FE RID: 22014 RVA: 0x0031B4A1 File Offset: 0x003196A1
		// (set) Token: 0x060055FF RID: 22015 RVA: 0x0031B4AC File Offset: 0x003196AC
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

		// Token: 0x17001EE4 RID: 7908
		// (get) Token: 0x06005600 RID: 22016 RVA: 0x0031B4EF File Offset: 0x003196EF
		// (set) Token: 0x06005601 RID: 22017 RVA: 0x0031B4F9 File Offset: 0x003196F9
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001EE5 RID: 7909
		// (get) Token: 0x06005602 RID: 22018 RVA: 0x0031B502 File Offset: 0x00319702
		// (set) Token: 0x06005603 RID: 22019 RVA: 0x0031B50C File Offset: 0x0031970C
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

		// Token: 0x17001EE6 RID: 7910
		// (get) Token: 0x06005604 RID: 22020 RVA: 0x0031B54F File Offset: 0x0031974F
		// (set) Token: 0x06005605 RID: 22021 RVA: 0x0031B559 File Offset: 0x00319759
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001EE7 RID: 7911
		// (get) Token: 0x06005606 RID: 22022 RVA: 0x0031B562 File Offset: 0x00319762
		// (set) Token: 0x06005607 RID: 22023 RVA: 0x0031B56C File Offset: 0x0031976C
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

		// Token: 0x17001EE8 RID: 7912
		// (get) Token: 0x06005608 RID: 22024 RVA: 0x0031B5AF File Offset: 0x003197AF
		// (set) Token: 0x06005609 RID: 22025 RVA: 0x0031B5BC File Offset: 0x003197BC
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

		// Token: 0x17001EE9 RID: 7913
		// (get) Token: 0x0600560A RID: 22026 RVA: 0x0031B61A File Offset: 0x0031981A
		// (set) Token: 0x0600560B RID: 22027 RVA: 0x0031B624 File Offset: 0x00319824
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

		// Token: 0x17001EEA RID: 7914
		// (get) Token: 0x0600560C RID: 22028 RVA: 0x0031B667 File Offset: 0x00319867
		// (set) Token: 0x0600560D RID: 22029 RVA: 0x0031B671 File Offset: 0x00319871
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001EEB RID: 7915
		// (get) Token: 0x0600560E RID: 22030 RVA: 0x0031B67A File Offset: 0x0031987A
		// (set) Token: 0x0600560F RID: 22031 RVA: 0x0031B684 File Offset: 0x00319884
		internal virtual ComboBox cbobins
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001EEC RID: 7916
		// (get) Token: 0x06005610 RID: 22032 RVA: 0x0031B68D File Offset: 0x0031988D
		// (set) Token: 0x06005611 RID: 22033 RVA: 0x0031B697 File Offset: 0x00319897
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001EED RID: 7917
		// (get) Token: 0x06005612 RID: 22034 RVA: 0x0031B6A0 File Offset: 0x003198A0
		// (set) Token: 0x06005613 RID: 22035 RVA: 0x0031B6AC File Offset: 0x003198AC
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

		// Token: 0x17001EEE RID: 7918
		// (get) Token: 0x06005614 RID: 22036 RVA: 0x0031B6EF File Offset: 0x003198EF
		// (set) Token: 0x06005615 RID: 22037 RVA: 0x0031B6F9 File Offset: 0x003198F9
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001EEF RID: 7919
		// (get) Token: 0x06005616 RID: 22038 RVA: 0x0031B702 File Offset: 0x00319902
		// (set) Token: 0x06005617 RID: 22039 RVA: 0x0031B70C File Offset: 0x0031990C
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001EF0 RID: 7920
		// (get) Token: 0x06005618 RID: 22040 RVA: 0x0031B715 File Offset: 0x00319915
		// (set) Token: 0x06005619 RID: 22041 RVA: 0x0031B71F File Offset: 0x0031991F
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001EF1 RID: 7921
		// (get) Token: 0x0600561A RID: 22042 RVA: 0x0031B728 File Offset: 0x00319928
		// (set) Token: 0x0600561B RID: 22043 RVA: 0x0031B732 File Offset: 0x00319932
		internal virtual Label lblprodcount
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001EF2 RID: 7922
		// (get) Token: 0x0600561C RID: 22044 RVA: 0x0031B73B File Offset: 0x0031993B
		// (set) Token: 0x0600561D RID: 22045 RVA: 0x0031B745 File Offset: 0x00319945
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x0600561E RID: 22046 RVA: 0x0031B750 File Offset: 0x00319950
		private void LoadLevels(string binloc)
		{
			this.dgvproducts.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "CurrentStockLevelsBinloc";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			sqlCommand.Parameters.AddWithValue("binloc", binloc);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			this.dgvproducts.DataSource = dataTable;
			this.dgvproducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			bool flag = Operators.CompareString(MyProject.Forms.Form1.BusType, "Tuckshop", false) == 0;
			if (flag)
			{
				this.dgvproducts.Columns["ProductCode"].Visible = false;
			}
			else
			{
				bool flag2 = Operators.CompareString(MyProject.Forms.Form1.BusType, "Parts", false) == 0;
				if (flag2)
				{
					this.dgvproducts.Columns["ProductID"].Visible = false;
				}
			}
			this.dgvproducts.Columns["ProductID"].HeaderText = "Product ID";
			this.dgvproducts.Columns["ProductCode"].HeaderText = "Product Code";
			this.dgvproducts.Columns["ProductDesc"].HeaderText = "Description";
			this.dgvproducts.Columns["ProductDesc2"].HeaderText = "Description";
			this.dgvproducts.Columns["ReorderLevel"].HeaderText = "Reorder Level";
			this.dgvproducts.Columns["StockBalance"].HeaderText = "Current Balance";
			this.lblprodcount.Text = this.dgvproducts.RowCount.ToString();
		}

		// Token: 0x0600561F RID: 22047 RVA: 0x0031B980 File Offset: 0x00319B80
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
					int num4 = Conversions.ToInteger(dataGridViewRow.Cells["StockBalance"].Value);
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
			this.lblCost.Text = MyProject.Forms.Form1.basecurrency + num.ToString();
			this.lblValue.Text = MyProject.Forms.Form1.basecurrency + num2.ToString();
		}

		// Token: 0x06005620 RID: 22048 RVA: 0x0031BAC4 File Offset: 0x00319CC4
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.LoadLevels(this.cbobins.SelectedValue.ToString());
				this.CalcStockValue();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading stock balances. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005621 RID: 22049 RVA: 0x0031BB2C File Offset: 0x00319D2C
		private void dgvproducts_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
		{
			checked
			{
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvproducts.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						int num = (int)Math.Round(unchecked(Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["StockBalance"].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ReorderLevel"].Value))));
						bool flag = num <= 0;
						if (flag)
						{
							dataGridViewRow.DefaultCellStyle.BackColor = Color.Yellow;
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
		}

		// Token: 0x06005622 RID: 22050 RVA: 0x0031BBF4 File Offset: 0x00319DF4
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

		// Token: 0x06005623 RID: 22051 RVA: 0x0031BCD8 File Offset: 0x00319ED8
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

		// Token: 0x06005624 RID: 22052 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label3_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06005625 RID: 22053 RVA: 0x0031BDCC File Offset: 0x00319FCC
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

		// Token: 0x06005626 RID: 22054 RVA: 0x0031BE2C File Offset: 0x0031A02C
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

		// Token: 0x06005627 RID: 22055 RVA: 0x0031BF1C File Offset: 0x0031A11C
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

		// Token: 0x06005628 RID: 22056 RVA: 0x0031BFDC File Offset: 0x0031A1DC
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

		// Token: 0x06005629 RID: 22057 RVA: 0x0031C17C File Offset: 0x0031A37C
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

		// Token: 0x0600562A RID: 22058 RVA: 0x0031C1DC File Offset: 0x0031A3DC
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

		// Token: 0x0600562B RID: 22059 RVA: 0x0031C2D4 File Offset: 0x0031A4D4
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

		// Token: 0x0600562C RID: 22060 RVA: 0x0031C340 File Offset: 0x0031A540
		private void StockBalancesByCategory_Load(object sender, EventArgs e)
		{
			try
			{
				this.cbobins.DataSource = this.GetBinLocs();
				this.cbobins.DisplayMember = "BinLocation";
				this.cbobins.ValueMember = "BinLocation";
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600562D RID: 22061 RVA: 0x0031C3BC File Offset: 0x0031A5BC
		private DataTable GetBinLocs()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetDistinctBinLocs";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x04002599 RID: 9625
		private string _cnn;

		// Token: 0x0400259A RID: 9626
		private PublicFunctions pfunctions;
	}
}
