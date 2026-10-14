using System;
using System.Collections;
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
	// Token: 0x0200002E RID: 46
	[DesignerGenerated]
	public partial class ConsignmentReport : Form
	{
		// Token: 0x060008B1 RID: 2225 RVA: 0x00054174 File Offset: 0x00052374
		public ConsignmentReport()
		{
			base.Load += this.ConsignmentReport_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.CurrentID = 0;
			this.CurrentCode = "";
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x060008B4 RID: 2228 RVA: 0x0005540A File Offset: 0x0005360A
		// (set) Token: 0x060008B5 RID: 2229 RVA: 0x00055414 File Offset: 0x00053614
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x060008B6 RID: 2230 RVA: 0x0005541D File Offset: 0x0005361D
		// (set) Token: 0x060008B7 RID: 2231 RVA: 0x00055427 File Offset: 0x00053627
		internal virtual DataGridView dgvItems
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x060008B8 RID: 2232 RVA: 0x00055430 File Offset: 0x00053630
		// (set) Token: 0x060008B9 RID: 2233 RVA: 0x0005543A File Offset: 0x0005363A
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x060008BA RID: 2234 RVA: 0x00055443 File Offset: 0x00053643
		// (set) Token: 0x060008BB RID: 2235 RVA: 0x00055450 File Offset: 0x00053650
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

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x060008BC RID: 2236 RVA: 0x000554AE File Offset: 0x000536AE
		// (set) Token: 0x060008BD RID: 2237 RVA: 0x000554B8 File Offset: 0x000536B8
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x060008BE RID: 2238 RVA: 0x000554C1 File Offset: 0x000536C1
		// (set) Token: 0x060008BF RID: 2239 RVA: 0x000554CC File Offset: 0x000536CC
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

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x060008C0 RID: 2240 RVA: 0x0005550F File Offset: 0x0005370F
		// (set) Token: 0x060008C1 RID: 2241 RVA: 0x00055519 File Offset: 0x00053719
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x060008C2 RID: 2242 RVA: 0x00055522 File Offset: 0x00053722
		// (set) Token: 0x060008C3 RID: 2243 RVA: 0x0005552C File Offset: 0x0005372C
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

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x060008C4 RID: 2244 RVA: 0x0005558A File Offset: 0x0005378A
		// (set) Token: 0x060008C5 RID: 2245 RVA: 0x00055594 File Offset: 0x00053794
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x060008C6 RID: 2246 RVA: 0x0005559D File Offset: 0x0005379D
		// (set) Token: 0x060008C7 RID: 2247 RVA: 0x000555A8 File Offset: 0x000537A8
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

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x060008C8 RID: 2248 RVA: 0x000555EB File Offset: 0x000537EB
		// (set) Token: 0x060008C9 RID: 2249 RVA: 0x000555F8 File Offset: 0x000537F8
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

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x060008CA RID: 2250 RVA: 0x0005563B File Offset: 0x0005383B
		// (set) Token: 0x060008CB RID: 2251 RVA: 0x00055645 File Offset: 0x00053845
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x060008CC RID: 2252 RVA: 0x0005564E File Offset: 0x0005384E
		// (set) Token: 0x060008CD RID: 2253 RVA: 0x00055658 File Offset: 0x00053858
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x060008CE RID: 2254 RVA: 0x00055661 File Offset: 0x00053861
		// (set) Token: 0x060008CF RID: 2255 RVA: 0x0005566B File Offset: 0x0005386B
		internal virtual DateTimePicker DTEndDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x060008D0 RID: 2256 RVA: 0x00055674 File Offset: 0x00053874
		// (set) Token: 0x060008D1 RID: 2257 RVA: 0x0005567E File Offset: 0x0005387E
		internal virtual DateTimePicker DTStartDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x060008D2 RID: 2258 RVA: 0x00055687 File Offset: 0x00053887
		// (set) Token: 0x060008D3 RID: 2259 RVA: 0x00055694 File Offset: 0x00053894
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

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x060008D4 RID: 2260 RVA: 0x000556D7 File Offset: 0x000538D7
		// (set) Token: 0x060008D5 RID: 2261 RVA: 0x000556E1 File Offset: 0x000538E1
		internal virtual TextBox txtDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x060008D6 RID: 2262 RVA: 0x000556EA File Offset: 0x000538EA
		// (set) Token: 0x060008D7 RID: 2263 RVA: 0x000556F4 File Offset: 0x000538F4
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x060008D8 RID: 2264 RVA: 0x000556FD File Offset: 0x000538FD
		// (set) Token: 0x060008D9 RID: 2265 RVA: 0x00055707 File Offset: 0x00053907
		internal virtual Label Label20
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x060008DA RID: 2266 RVA: 0x00055710 File Offset: 0x00053910
		// (set) Token: 0x060008DB RID: 2267 RVA: 0x0005571C File Offset: 0x0005391C
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

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x060008DC RID: 2268 RVA: 0x0005575F File Offset: 0x0005395F
		// (set) Token: 0x060008DD RID: 2269 RVA: 0x00055769 File Offset: 0x00053969
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x060008DE RID: 2270 RVA: 0x00055772 File Offset: 0x00053972
		// (set) Token: 0x060008DF RID: 2271 RVA: 0x0005577C File Offset: 0x0005397C
		internal virtual ComboBox cboBranches
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x060008E0 RID: 2272 RVA: 0x00055785 File Offset: 0x00053985
		// (set) Token: 0x060008E1 RID: 2273 RVA: 0x0005578F File Offset: 0x0005398F
		internal virtual DataGridViewTextBoxColumn ProductID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x060008E2 RID: 2274 RVA: 0x00055798 File Offset: 0x00053998
		// (set) Token: 0x060008E3 RID: 2275 RVA: 0x000557A2 File Offset: 0x000539A2
		internal virtual DataGridViewTextBoxColumn ProductCode
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x060008E4 RID: 2276 RVA: 0x000557AB File Offset: 0x000539AB
		// (set) Token: 0x060008E5 RID: 2277 RVA: 0x000557B5 File Offset: 0x000539B5
		internal virtual DataGridViewTextBoxColumn ProductDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x060008E6 RID: 2278 RVA: 0x000557BE File Offset: 0x000539BE
		// (set) Token: 0x060008E7 RID: 2279 RVA: 0x000557C8 File Offset: 0x000539C8
		internal virtual DataGridViewTextBoxColumn OpeningStock
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x060008E8 RID: 2280 RVA: 0x000557D1 File Offset: 0x000539D1
		// (set) Token: 0x060008E9 RID: 2281 RVA: 0x000557DB File Offset: 0x000539DB
		internal virtual DataGridViewTextBoxColumn StockPurchases
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x060008EA RID: 2282 RVA: 0x000557E4 File Offset: 0x000539E4
		// (set) Token: 0x060008EB RID: 2283 RVA: 0x000557EE File Offset: 0x000539EE
		internal virtual DataGridViewTextBoxColumn UnitCost
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x060008EC RID: 2284 RVA: 0x000557F7 File Offset: 0x000539F7
		// (set) Token: 0x060008ED RID: 2285 RVA: 0x00055801 File Offset: 0x00053A01
		internal virtual DataGridViewTextBoxColumn UnitsSold
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x060008EE RID: 2286 RVA: 0x0005580A File Offset: 0x00053A0A
		// (set) Token: 0x060008EF RID: 2287 RVA: 0x00055814 File Offset: 0x00053A14
		internal virtual DataGridViewTextBoxColumn TotalCost
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x060008F0 RID: 2288 RVA: 0x0005581D File Offset: 0x00053A1D
		// (set) Token: 0x060008F1 RID: 2289 RVA: 0x00055827 File Offset: 0x00053A27
		internal virtual DataGridViewTextBoxColumn SellingPrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x060008F2 RID: 2290 RVA: 0x00055830 File Offset: 0x00053A30
		// (set) Token: 0x060008F3 RID: 2291 RVA: 0x0005583A File Offset: 0x00053A3A
		internal virtual DataGridViewTextBoxColumn TotalSelling
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x060008F4 RID: 2292 RVA: 0x00055843 File Offset: 0x00053A43
		// (set) Token: 0x060008F5 RID: 2293 RVA: 0x0005584D File Offset: 0x00053A4D
		internal virtual DataGridViewTextBoxColumn GrossProfit
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x060008F6 RID: 2294 RVA: 0x00055856 File Offset: 0x00053A56
		// (set) Token: 0x060008F7 RID: 2295 RVA: 0x00055860 File Offset: 0x00053A60
		internal virtual DataGridViewTextBoxColumn ClosingStock
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x0005586C File Offset: 0x00053A6C
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

		// Token: 0x060008F9 RID: 2297 RVA: 0x000558F4 File Offset: 0x00053AF4
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

		// Token: 0x060008FA RID: 2298 RVA: 0x0005597C File Offset: 0x00053B7C
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

		// Token: 0x060008FB RID: 2299 RVA: 0x00055A88 File Offset: 0x00053C88
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

		// Token: 0x060008FC RID: 2300 RVA: 0x00055AE8 File Offset: 0x00053CE8
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

		// Token: 0x060008FD RID: 2301 RVA: 0x00055CC0 File Offset: 0x00053EC0
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

		// Token: 0x060008FE RID: 2302 RVA: 0x00055D48 File Offset: 0x00053F48
		private object searchDat(DataTable dt, string column, string value)
		{
			ConsignmentReport._Closure$__152-0 CS$<>8__locals1 = new ConsignmentReport._Closure$__152-0(CS$<>8__locals1);
			CS$<>8__locals1.$VB$Local_column = column;
			CS$<>8__locals1.$VB$Local_value = value;
			DataTable dataTable = dt.Clone();
			dt.CaseSensitive = false;
			try
			{
				foreach (DataRow dataRow in dt.Rows.Cast<object>().Select<object, DataRow>((ConsignmentReport._Closure$__.$I152-0 == null) ? (ConsignmentReport._Closure$__.$I152-0 = (object row1) => (DataRow)row1) : ConsignmentReport._Closure$__.$I152-0).Where<DataRow>((CS$<>8__locals1.$I1 == null) ? (CS$<>8__locals1.$I1 = (DataRow row1) => Conversions.ToBoolean(NewLateBinding.LateGet(row1[CS$<>8__locals1.$VB$Local_column], null, "Contains", new object[] { CS$<>8__locals1.$VB$Local_value.ToUpper() }, null, null, null))) : CS$<>8__locals1.$I1))
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

		// Token: 0x060008FF RID: 2303 RVA: 0x00055E24 File Offset: 0x00054024
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

		// Token: 0x06000900 RID: 2304 RVA: 0x00055EE8 File Offset: 0x000540E8
		private void DGVSearch_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				bool flag = e.KeyCode == Keys.Return;
				if (flag)
				{
					this.Button1.Focus();
					e.Handled = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Key down error on search. Ignore");
			}
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x00055F48 File Offset: 0x00054148
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

		// Token: 0x06000902 RID: 2306 RVA: 0x00055FDC File Offset: 0x000541DC
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
				this.CurrentID = Conversions.ToInteger(dataRow["ProductID"]);
				this.CurrentCode = Conversions.ToString(dataRow["ProductCode"]);
				this.CurrentCost = Conversions.ToDecimal(dataRow["Cost"]);
				this.CurrentSelling = Conversions.ToDecimal(dataRow["SellingPrice"]);
			}
			else
			{
				this.txtSearchProductCode.Text = "";
			}
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x00056124 File Offset: 0x00054324
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

		// Token: 0x06000904 RID: 2308 RVA: 0x000561C8 File Offset: 0x000543C8
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
				this.CurrentID = Conversions.ToInteger(dataRow["ProductID"]);
				this.CurrentCode = Conversions.ToString(dataRow["ProductCode"]);
				this.CurrentCost = Conversions.ToDecimal(dataRow["Cost"]);
				this.CurrentSelling = Conversions.ToDecimal(dataRow["SellingPrice"]);
			}
			else
			{
				this.txtSearchProductCode.Text = "";
			}
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x00056318 File Offset: 0x00054518
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				string[] array = new string[]
				{
					Conversions.ToString(this.CurrentID),
					this.CurrentCode,
					this.txtDesc.Text,
					Conversions.ToString(0),
					Conversions.ToString(0),
					Conversions.ToString(this.CurrentCost),
					Conversions.ToString(0),
					Conversions.ToString(0),
					Conversions.ToString(this.CurrentSelling),
					Conversions.ToString(0),
					Conversions.ToString(0),
					Conversions.ToString(0)
				};
				this.dgvItems.Rows.Add(array);
				this.txtSearchProductCode.Text = "";
				bool flag = MyProject.Forms.Form1.DefaultSearchDesc == 1;
				if (flag)
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
				MessageBox.Show("Error adding items. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x00056440 File Offset: 0x00054640
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.dgvItems.Rows.Count > 0;
				if (flag)
				{
					decimal num = 0m;
					decimal num2 = 0m;
					decimal num3 = 0m;
					decimal num4 = 0m;
					try
					{
						foreach (object obj in ((IEnumerable)this.dgvItems.Rows))
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							int num5 = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[0].Value));
							int num6 = Convert.ToInt32(this.DTStartDate.Value.ToString("yyyyMMdd"));
							int num7 = Convert.ToInt32(this.DTEndDate.Value.ToString("yyyyMMdd"));
							dataGridViewRow.Cells[3].Value = this.StockBalAsAt(num5, num6, MyProject.Forms.Form1.coid, this.cboBranches.Text);
							dataGridViewRow.Cells[4].Value = this.StockPurchasesforproduct(num5, MyProject.Forms.Form1.coid, this.cboBranches.Text, num6, num7);
							dataGridViewRow.Cells[6].Value = this.StockSalesforproduct(num5, MyProject.Forms.Form1.coid, this.cboBranches.Text, num6, num7);
							dataGridViewRow.Cells[7].Value = Operators.MultiplyObject(dataGridViewRow.Cells[5].Value, dataGridViewRow.Cells[6].Value);
							dataGridViewRow.Cells[9].Value = Operators.MultiplyObject(dataGridViewRow.Cells[8].Value, dataGridViewRow.Cells[6].Value);
							dataGridViewRow.Cells[10].Value = Operators.SubtractObject(dataGridViewRow.Cells[9].Value, dataGridViewRow.Cells[7].Value);
							dataGridViewRow.Cells[11].Value = this.StockBalAsAt(num5, num7, MyProject.Forms.Form1.coid, this.cboBranches.Text);
							num4 = Conversions.ToDecimal(Operators.AddObject(num4, dataGridViewRow.Cells[6].Value));
							num2 = Conversions.ToDecimal(Operators.AddObject(num2, dataGridViewRow.Cells[9].Value));
							num3 = Conversions.ToDecimal(Operators.AddObject(num3, dataGridViewRow.Cells[10].Value));
							num = Conversions.ToDecimal(Operators.AddObject(num, dataGridViewRow.Cells[7].Value));
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
					string[] array = new string[]
					{
						"TOTAL",
						"",
						"",
						"",
						"",
						"",
						Conversions.ToString(num4),
						Conversions.ToString(num),
						"",
						Conversions.ToString(num2),
						Conversions.ToString(num3),
						""
					};
					this.dgvItems.Rows.Add(array);
				}
				else
				{
					MessageBox.Show("Please ADD PRODUCT first before running report.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error running report. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x00056864 File Offset: 0x00054A64
		private decimal StockBalAsAt(int productid, int stockdate, int coid, string branch)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchBalanceAsAt";
			sqlCommand.Parameters.AddWithValue("ProductID", productid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("theday", stockdate);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			decimal num2;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				num2 = Conversions.ToDecimal(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["StockBalance"])), 0, RuntimeHelpers.GetObjectValue(dataRow["StockBalance"])));
			}
			else
			{
				num2 = 0m;
			}
			return num2;
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x0005696C File Offset: 0x00054B6C
		private decimal StockPurchasesforproduct(int productid, int coid, string branch, int startdate, int enddate)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetPurchasesForProduct";
			sqlCommand.Parameters.AddWithValue("ProductID", productid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("startdate", startdate);
			sqlCommand.Parameters.AddWithValue("enddate", enddate);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			decimal num2;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				num2 = Conversions.ToDecimal(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Quantity"])), 0, RuntimeHelpers.GetObjectValue(dataRow["Quantity"])));
			}
			else
			{
				num2 = 0m;
			}
			return num2;
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x00056A8C File Offset: 0x00054C8C
		private decimal StockSalesforproduct(int productid, int coid, string branch, int startdate, int enddate)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "ProductSalesForPeriod";
			sqlCommand.Parameters.AddWithValue("ProductID", productid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("startdate", startdate);
			sqlCommand.Parameters.AddWithValue("enddate", enddate);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			decimal num2;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				num2 = Conversions.ToDecimal(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Quantity"])), 0, RuntimeHelpers.GetObjectValue(dataRow["Quantity"])));
			}
			else
			{
				num2 = 0m;
			}
			return num2;
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x00056BAC File Offset: 0x00054DAC
		private void ConsignmentReport_Load(object sender, EventArgs e)
		{
			try
			{
				this.cboBranches.DataSource = this.pf.LoadBranches(this._cnn);
				this.cboBranches.DisplayMember = "Branch";
				this.cboBranches.ValueMember = "Branch";
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading page. Detail: " + ex.Message);
			}
		}

		// Token: 0x04000436 RID: 1078
		private string _cnn;

		// Token: 0x04000437 RID: 1079
		private int CurrentID;

		// Token: 0x04000438 RID: 1080
		private string CurrentCode;

		// Token: 0x04000439 RID: 1081
		private decimal CurrentCost;

		// Token: 0x0400043A RID: 1082
		private decimal CurrentSelling;

		// Token: 0x0400043B RID: 1083
		private PublicFunctions pf;
	}
}
