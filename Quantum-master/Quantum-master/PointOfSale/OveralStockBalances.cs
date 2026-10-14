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
	// Token: 0x02000083 RID: 131
	[DesignerGenerated]
	public partial class OveralStockBalances : UserControl
	{
		// Token: 0x06001E27 RID: 7719 RVA: 0x0010CCB8 File Offset: 0x0010AEB8
		public OveralStockBalances()
		{
			base.Load += this.OveralStockBalances_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x17000B13 RID: 2835
		// (get) Token: 0x06001E2A RID: 7722 RVA: 0x0010DBA4 File Offset: 0x0010BDA4
		// (set) Token: 0x06001E2B RID: 7723 RVA: 0x0010DBAE File Offset: 0x0010BDAE
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B14 RID: 2836
		// (get) Token: 0x06001E2C RID: 7724 RVA: 0x0010DBB7 File Offset: 0x0010BDB7
		// (set) Token: 0x06001E2D RID: 7725 RVA: 0x0010DBC1 File Offset: 0x0010BDC1
		internal virtual DataGridView dgvStocks
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B15 RID: 2837
		// (get) Token: 0x06001E2E RID: 7726 RVA: 0x0010DBCA File Offset: 0x0010BDCA
		// (set) Token: 0x06001E2F RID: 7727 RVA: 0x0010DBD4 File Offset: 0x0010BDD4
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

		// Token: 0x17000B16 RID: 2838
		// (get) Token: 0x06001E30 RID: 7728 RVA: 0x0010DC17 File Offset: 0x0010BE17
		// (set) Token: 0x06001E31 RID: 7729 RVA: 0x0010DC21 File Offset: 0x0010BE21
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B17 RID: 2839
		// (get) Token: 0x06001E32 RID: 7730 RVA: 0x0010DC2A File Offset: 0x0010BE2A
		// (set) Token: 0x06001E33 RID: 7731 RVA: 0x0010DC34 File Offset: 0x0010BE34
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

		// Token: 0x17000B18 RID: 2840
		// (get) Token: 0x06001E34 RID: 7732 RVA: 0x0010DC77 File Offset: 0x0010BE77
		// (set) Token: 0x06001E35 RID: 7733 RVA: 0x0010DC81 File Offset: 0x0010BE81
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B19 RID: 2841
		// (get) Token: 0x06001E36 RID: 7734 RVA: 0x0010DC8A File Offset: 0x0010BE8A
		// (set) Token: 0x06001E37 RID: 7735 RVA: 0x0010DC94 File Offset: 0x0010BE94
		internal virtual DateTimePicker DTDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B1A RID: 2842
		// (get) Token: 0x06001E38 RID: 7736 RVA: 0x0010DC9D File Offset: 0x0010BE9D
		// (set) Token: 0x06001E39 RID: 7737 RVA: 0x0010DCA7 File Offset: 0x0010BEA7
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B1B RID: 2843
		// (get) Token: 0x06001E3A RID: 7738 RVA: 0x0010DCB0 File Offset: 0x0010BEB0
		// (set) Token: 0x06001E3B RID: 7739 RVA: 0x0010DCBC File Offset: 0x0010BEBC
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

		// Token: 0x17000B1C RID: 2844
		// (get) Token: 0x06001E3C RID: 7740 RVA: 0x0010DD1A File Offset: 0x0010BF1A
		// (set) Token: 0x06001E3D RID: 7741 RVA: 0x0010DD24 File Offset: 0x0010BF24
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B1D RID: 2845
		// (get) Token: 0x06001E3E RID: 7742 RVA: 0x0010DD2D File Offset: 0x0010BF2D
		// (set) Token: 0x06001E3F RID: 7743 RVA: 0x0010DD38 File Offset: 0x0010BF38
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

		// Token: 0x17000B1E RID: 2846
		// (get) Token: 0x06001E40 RID: 7744 RVA: 0x0010DD7B File Offset: 0x0010BF7B
		// (set) Token: 0x06001E41 RID: 7745 RVA: 0x0010DD85 File Offset: 0x0010BF85
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B1F RID: 2847
		// (get) Token: 0x06001E42 RID: 7746 RVA: 0x0010DD8E File Offset: 0x0010BF8E
		// (set) Token: 0x06001E43 RID: 7747 RVA: 0x0010DD98 File Offset: 0x0010BF98
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

		// Token: 0x17000B20 RID: 2848
		// (get) Token: 0x06001E44 RID: 7748 RVA: 0x0010DDDB File Offset: 0x0010BFDB
		// (set) Token: 0x06001E45 RID: 7749 RVA: 0x0010DDE5 File Offset: 0x0010BFE5
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B21 RID: 2849
		// (get) Token: 0x06001E46 RID: 7750 RVA: 0x0010DDEE File Offset: 0x0010BFEE
		// (set) Token: 0x06001E47 RID: 7751 RVA: 0x0010DDF8 File Offset: 0x0010BFF8
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

		// Token: 0x17000B22 RID: 2850
		// (get) Token: 0x06001E48 RID: 7752 RVA: 0x0010DE3B File Offset: 0x0010C03B
		// (set) Token: 0x06001E49 RID: 7753 RVA: 0x0010DE45 File Offset: 0x0010C045
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B23 RID: 2851
		// (get) Token: 0x06001E4A RID: 7754 RVA: 0x0010DE4E File Offset: 0x0010C04E
		// (set) Token: 0x06001E4B RID: 7755 RVA: 0x0010DE58 File Offset: 0x0010C058
		internal virtual ComboBox cboCategories
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B24 RID: 2852
		// (get) Token: 0x06001E4C RID: 7756 RVA: 0x0010DE61 File Offset: 0x0010C061
		// (set) Token: 0x06001E4D RID: 7757 RVA: 0x0010DE6C File Offset: 0x0010C06C
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

		// Token: 0x17000B25 RID: 2853
		// (get) Token: 0x06001E4E RID: 7758 RVA: 0x0010DEAF File Offset: 0x0010C0AF
		// (set) Token: 0x06001E4F RID: 7759 RVA: 0x0010DEBC File Offset: 0x0010C0BC
		internal virtual CheckBox chkUseActual
		{
			[CompilerGenerated]
			get
			{
				return this._chkUseActual;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.chkUseActual_CheckedChanged);
				CheckBox checkBox = this._chkUseActual;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= eventHandler;
				}
				this._chkUseActual = value;
				checkBox = this._chkUseActual;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B26 RID: 2854
		// (get) Token: 0x06001E50 RID: 7760 RVA: 0x0010DEFF File Offset: 0x0010C0FF
		// (set) Token: 0x06001E51 RID: 7761 RVA: 0x0010DF0C File Offset: 0x0010C10C
		internal virtual CheckBox chkAllCats
		{
			[CompilerGenerated]
			get
			{
				return this._chkAllCats;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.chkAllCats_CheckedChanged);
				CheckBox checkBox = this._chkAllCats;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= eventHandler;
				}
				this._chkAllCats = value;
				checkBox = this._chkAllCats;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x06001E52 RID: 7762 RVA: 0x0010DF50 File Offset: 0x0010C150
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.LoadStockBalances();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error fetching stocks data. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001E53 RID: 7763 RVA: 0x0010DFA0 File Offset: 0x0010C1A0
		private void LoadStockBalances()
		{
			this.dgvStocks.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchBranches";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			this.dgvStocks.Columns.Add("ProductID", "Product ID");
			this.dgvStocks.Columns.Add("ProductCode", "Product Code");
			this.dgvStocks.Columns.Add("Product", "Product");
			this.dgvStocks.Columns.Add("ProductCost", "Product Cost");
			this.dgvStocks.Columns.Add("SellingPrice", "Current Selling Price");
			try
			{
				foreach (object obj in dataTable.Rows)
				{
					DataRow dataRow = (DataRow)obj;
					this.dgvStocks.Columns.Add(dataRow["branch"].ToString(), dataRow["branch"].ToString());
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
			this.dgvStocks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			SqlConnection sqlConnection2 = new SqlConnection(this._cnn);
			SqlCommand sqlCommand2 = sqlConnection2.CreateCommand();
			sqlCommand2.CommandType = CommandType.StoredProcedure;
			sqlCommand2.CommandText = "FetchProductsByCategory";
			sqlCommand2.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand2.Parameters.AddWithValue("category", Convert.ToInt32(RuntimeHelpers.GetObjectValue(this.cboCategories.SelectedValue)));
			sqlCommand2.Parameters.AddWithValue("allcats", RuntimeHelpers.GetObjectValue(Interaction.IIf(this.chkAllCats.Checked, 1, 0)));
			SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter(sqlCommand2);
			DataTable dataTable2 = new DataTable();
			sqlDataAdapter2.Fill(dataTable2);
			int num = 0;
			checked
			{
				try
				{
					foreach (object obj2 in dataTable.Rows)
					{
						DataRow dataRow2 = (DataRow)obj2;
						string text = dataRow2["branch"].ToString();
						num++;
						int num2 = 0;
						try
						{
							foreach (object obj3 in dataTable2.Rows)
							{
								DataRow dataRow3 = (DataRow)obj3;
								num2++;
								int num3 = Conversions.ToInteger(dataRow3["ProductID"]);
								string text2 = dataRow3["productdesc"].ToString();
								string text3 = dataRow3["ProductCode"].ToString();
								double num4 = Conversions.ToDouble(dataRow3["cost"]);
								double num5 = Conversions.ToDouble(dataRow3["sellingprice"]);
								int stockBalByID = this.GetStockBalByID(num3, text, MyProject.Forms.Form1.coid, (int)Math.Round(Conversion.Val(this.DTDate.Value.ToString("yyyyMMdd"))));
								bool flag = num == 1;
								if (flag)
								{
									this.dgvStocks.Rows.Add();
									DataGridViewRow dataGridViewRow = this.dgvStocks.Rows[num2 - 1];
									dataGridViewRow.Cells[text].Value = stockBalByID;
									dataGridViewRow.Cells["Product"].Value = text2;
									dataGridViewRow.Cells["ProductCode"].Value = text3;
									dataGridViewRow.Cells["ProductID"].Value = num3;
									dataGridViewRow.Cells["ProductCost"].Value = num4;
									dataGridViewRow.Cells["SellingPrice"].Value = num5;
								}
								else
								{
									bool flag2 = num > 1;
									if (flag2)
									{
										try
										{
											foreach (object obj4 in ((IEnumerable)this.dgvStocks.Rows))
											{
												DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj4;
												bool flag3 = Operators.ConditionalCompareObjectEqual(dataGridViewRow2.Cells["Product"].Value, text2, false);
												if (flag3)
												{
													dataGridViewRow2.Cells[text].Value = stockBalByID;
												}
											}
										}
										finally
										{
											IEnumerator enumerator4;
											if (enumerator4 is IDisposable)
											{
												(enumerator4 as IDisposable).Dispose();
											}
										}
									}
								}
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
				finally
				{
					IEnumerator enumerator2;
					if (enumerator2 is IDisposable)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
			}
		}

		// Token: 0x06001E54 RID: 7764 RVA: 0x0010E530 File Offset: 0x0010C730
		private int GetStockBalByID(int productid, string branch, int coid, int theday)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchBalanceAsAt";
			sqlCommand.Parameters.AddWithValue("ProductID", productid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("theday", theday);
			sqlCommand.Parameters.AddWithValue("useactual", RuntimeHelpers.GetObjectValue(Interaction.IIf(this.chkUseActual.Checked, 1, 0)));
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			int num2;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				num2 = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["StockBalance"])), 0, RuntimeHelpers.GetObjectValue(dataRow["StockBalance"])));
			}
			else
			{
				num2 = 0;
			}
			return num2;
		}

		// Token: 0x06001E55 RID: 7765 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label3_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06001E56 RID: 7766 RVA: 0x0010E664 File Offset: 0x0010C864
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

		// Token: 0x06001E57 RID: 7767 RVA: 0x0010E724 File Offset: 0x0010C924
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

		// Token: 0x06001E58 RID: 7768 RVA: 0x0010E8C4 File Offset: 0x0010CAC4
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

		// Token: 0x06001E59 RID: 7769 RVA: 0x0010E924 File Offset: 0x0010CB24
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

		// Token: 0x06001E5A RID: 7770 RVA: 0x0010EA1C File Offset: 0x0010CC1C
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

		// Token: 0x06001E5B RID: 7771 RVA: 0x0010EA88 File Offset: 0x0010CC88
		private void txtProductCode_TextChanged(object sender, EventArgs e)
		{
			try
			{
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvStocks.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						bool flag = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["ProductCode"].Value, this.txtProductCode.Text, false);
						if (flag)
						{
							this.dgvStocks.ClearSelection();
							dataGridViewRow.Cells["ProductCode"].Selected = true;
							this.dgvStocks.CurrentCell = dataGridViewRow.Cells["ProductCode"];
							dataGridViewRow.Selected = true;
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

		// Token: 0x06001E5C RID: 7772 RVA: 0x0010EB84 File Offset: 0x0010CD84
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

		// Token: 0x06001E5D RID: 7773 RVA: 0x0010EBE4 File Offset: 0x0010CDE4
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
			this.cboCategories.DataSource = dataTable;
			this.cboCategories.ValueMember = "CatID";
			this.cboCategories.DisplayMember = "CatDesc";
		}

		// Token: 0x06001E5E RID: 7774 RVA: 0x0010EC84 File Offset: 0x0010CE84
		private void OveralStockBalances_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadCategories();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001E5F RID: 7775 RVA: 0x0010ECD4 File Offset: 0x0010CED4
		private void DATAGRIDVIEW_TO_EXCEL(DataGridView DGV)
		{
			checked
			{
				try
				{
					DataTable dataTable = new DataTable();
					int num = DGV.ColumnCount - 1;
					for (int i = 0; i <= num; i++)
					{
						dataTable.Columns.Add(DGV.Columns[i].Name.ToString());
					}
					int num2 = DGV.Rows.Count - 1;
					for (int j = 0; j <= num2; j++)
					{
						DataRow dataRow = dataTable.NewRow();
						int num3 = DGV.ColumnCount - 1;
						for (int i = 0; i <= num3; i++)
						{
							try
							{
								dataRow[dataTable.Columns[i].ColumnName.ToString()] = DGV.Rows[j].Cells[i].Value.ToString();
							}
							catch (Exception ex)
							{
							}
						}
						dataTable.Rows.Add(dataRow);
					}
					dataTable.AcceptChanges();
					DataSet dataSet = new DataSet();
					dataSet.Tables.Add(dataTable);
					string text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Overal Stock Balance" + DateTime.Today.ToString("yyyyMMdd") + ".xls";
					dataTable.WriteXml(text);
				}
				catch (Exception ex2)
				{
					Interaction.MsgBox(ex2.ToString(), MsgBoxStyle.OkOnly, null);
				}
			}
		}

		// Token: 0x06001E60 RID: 7776 RVA: 0x0010EE68 File Offset: 0x0010D068
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				this.DATAGRIDVIEW_TO_EXCEL(this.dgvStocks);
				MessageBox.Show("Data exported to excel and saved on the Desktop.");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error exporting. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001E61 RID: 7777 RVA: 0x0010EEC8 File Offset: 0x0010D0C8
		private void chkUseActual_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				bool @checked = this.chkUseActual.Checked;
				if (@checked)
				{
					this.DTDate.Enabled = false;
				}
				else
				{
					this.DTDate.Enabled = true;
					MessageBox.Show("Please note that Stock Balance report for a certain date is a slower process.");
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001E62 RID: 7778 RVA: 0x0010EF34 File Offset: 0x0010D134
		private void chkAllCats_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				bool @checked = this.chkAllCats.Checked;
				if (@checked)
				{
					this.cboCategories.Enabled = false;
				}
				else
				{
					this.cboCategories.Enabled = true;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x04000E71 RID: 3697
		private string _cnn;
	}
}
