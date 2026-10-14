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
	// Token: 0x02000024 RID: 36
	[DesignerGenerated]
	public partial class CheckSerialNumber : Form
	{
		// Token: 0x060006D3 RID: 1747 RVA: 0x00044FBC File Offset: 0x000431BC
		public CheckSerialNumber()
		{
			base.Load += this.CheckSerialNumber_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.currentRecordSerial = false;
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x060006D6 RID: 1750 RVA: 0x000463A3 File Offset: 0x000445A3
		// (set) Token: 0x060006D7 RID: 1751 RVA: 0x000463AD File Offset: 0x000445AD
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x060006D8 RID: 1752 RVA: 0x000463B6 File Offset: 0x000445B6
		// (set) Token: 0x060006D9 RID: 1753 RVA: 0x000463C0 File Offset: 0x000445C0
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x060006DA RID: 1754 RVA: 0x000463C9 File Offset: 0x000445C9
		// (set) Token: 0x060006DB RID: 1755 RVA: 0x000463D4 File Offset: 0x000445D4
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

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x060006DC RID: 1756 RVA: 0x00046417 File Offset: 0x00044617
		// (set) Token: 0x060006DD RID: 1757 RVA: 0x00046421 File Offset: 0x00044621
		internal virtual GroupBox GroupBox6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x060006DE RID: 1758 RVA: 0x0004642A File Offset: 0x0004462A
		// (set) Token: 0x060006DF RID: 1759 RVA: 0x00046434 File Offset: 0x00044634
		internal virtual Panel Panel7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x060006E0 RID: 1760 RVA: 0x0004643D File Offset: 0x0004463D
		// (set) Token: 0x060006E1 RID: 1761 RVA: 0x00046447 File Offset: 0x00044647
		internal virtual Label Label20
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x060006E2 RID: 1762 RVA: 0x00046450 File Offset: 0x00044650
		// (set) Token: 0x060006E3 RID: 1763 RVA: 0x0004645C File Offset: 0x0004465C
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
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtBarCode_KeyDown);
				TextBox textBox = this._txtBarCode;
				if (textBox != null)
				{
					textBox.KeyDown -= keyEventHandler;
				}
				this._txtBarCode = value;
				textBox = this._txtBarCode;
				if (textBox != null)
				{
					textBox.KeyDown += keyEventHandler;
				}
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x060006E4 RID: 1764 RVA: 0x0004649F File Offset: 0x0004469F
		// (set) Token: 0x060006E5 RID: 1765 RVA: 0x000464A9 File Offset: 0x000446A9
		internal virtual Label Label24
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x060006E6 RID: 1766 RVA: 0x000464B2 File Offset: 0x000446B2
		// (set) Token: 0x060006E7 RID: 1767 RVA: 0x000464BC File Offset: 0x000446BC
		internal virtual Label Label34
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x060006E8 RID: 1768 RVA: 0x000464C5 File Offset: 0x000446C5
		// (set) Token: 0x060006E9 RID: 1769 RVA: 0x000464D0 File Offset: 0x000446D0
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

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x060006EA RID: 1770 RVA: 0x00046513 File Offset: 0x00044713
		// (set) Token: 0x060006EB RID: 1771 RVA: 0x0004651D File Offset: 0x0004471D
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x060006EC RID: 1772 RVA: 0x00046526 File Offset: 0x00044726
		// (set) Token: 0x060006ED RID: 1773 RVA: 0x00046530 File Offset: 0x00044730
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

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x060006EE RID: 1774 RVA: 0x00046573 File Offset: 0x00044773
		// (set) Token: 0x060006EF RID: 1775 RVA: 0x0004657D File Offset: 0x0004477D
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x060006F0 RID: 1776 RVA: 0x00046586 File Offset: 0x00044786
		// (set) Token: 0x060006F1 RID: 1777 RVA: 0x00046590 File Offset: 0x00044790
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x060006F2 RID: 1778 RVA: 0x00046599 File Offset: 0x00044799
		// (set) Token: 0x060006F3 RID: 1779 RVA: 0x000465A4 File Offset: 0x000447A4
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

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x060006F4 RID: 1780 RVA: 0x000465E7 File Offset: 0x000447E7
		// (set) Token: 0x060006F5 RID: 1781 RVA: 0x000465F1 File Offset: 0x000447F1
		internal virtual TextBox txtSerial
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x060006F6 RID: 1782 RVA: 0x000465FA File Offset: 0x000447FA
		// (set) Token: 0x060006F7 RID: 1783 RVA: 0x00046604 File Offset: 0x00044804
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x060006F8 RID: 1784 RVA: 0x0004660D File Offset: 0x0004480D
		// (set) Token: 0x060006F9 RID: 1785 RVA: 0x00046618 File Offset: 0x00044818
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

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x060006FA RID: 1786 RVA: 0x0004665B File Offset: 0x0004485B
		// (set) Token: 0x060006FB RID: 1787 RVA: 0x00046665 File Offset: 0x00044865
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x060006FC RID: 1788 RVA: 0x0004666E File Offset: 0x0004486E
		// (set) Token: 0x060006FD RID: 1789 RVA: 0x00046678 File Offset: 0x00044878
		internal virtual TextBox txtDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x060006FE RID: 1790 RVA: 0x00046681 File Offset: 0x00044881
		// (set) Token: 0x060006FF RID: 1791 RVA: 0x0004668B File Offset: 0x0004488B
		internal virtual DataGridView dgvSerials
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000700 RID: 1792 RVA: 0x00046694 File Offset: 0x00044894
		// (set) Token: 0x06000701 RID: 1793 RVA: 0x0004669E File Offset: 0x0004489E
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000702 RID: 1794 RVA: 0x000466A7 File Offset: 0x000448A7
		// (set) Token: 0x06000703 RID: 1795 RVA: 0x000466B4 File Offset: 0x000448B4
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

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000704 RID: 1796 RVA: 0x000466F7 File Offset: 0x000448F7
		// (set) Token: 0x06000705 RID: 1797 RVA: 0x00046704 File Offset: 0x00044904
		internal virtual Button btnEnable
		{
			[CompilerGenerated]
			get
			{
				return this._btnEnable;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.btnEnable_Click);
				Button button = this._btnEnable;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._btnEnable = value;
				button = this._btnEnable;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000706 RID: 1798 RVA: 0x00046747 File Offset: 0x00044947
		// (set) Token: 0x06000707 RID: 1799 RVA: 0x00046754 File Offset: 0x00044954
		internal virtual Button Button5
		{
			[CompilerGenerated]
			get
			{
				return this._Button5;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button5_Click);
				Button button = this._Button5;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button5 = value;
				button = this._Button5;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000708 RID: 1800 RVA: 0x00046797 File Offset: 0x00044997
		// (set) Token: 0x06000709 RID: 1801 RVA: 0x000467A4 File Offset: 0x000449A4
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

		// Token: 0x0600070A RID: 1802 RVA: 0x000467E8 File Offset: 0x000449E8
		private void CheckSerialNumber_Load(object sender, EventArgs e)
		{
			try
			{
				this.Panel2.Visible = true;
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
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x00046870 File Offset: 0x00044A70
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

		// Token: 0x0600070C RID: 1804 RVA: 0x000468F8 File Offset: 0x00044AF8
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

		// Token: 0x0600070D RID: 1805 RVA: 0x000469F0 File Offset: 0x00044BF0
		private void SearchByDescAdvanced(string searchtext)
		{
			bool flag = Operators.CompareString(searchtext, "", false) == 0;
			checked
			{
				if (!flag)
				{
					Cursor.Current = Cursors.WaitCursor;
					string[] array = searchtext.Split(new char[] { ' ' });
					int num = 1;
					DataTable dataTable = new DataTable();
					foreach (string text in array)
					{
						bool flag2 = num == 1;
						if (flag2)
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
					bool flag3 = dataTable.Rows.Count > 0;
					if (flag3)
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
					Cursor.Current = Cursors.Default;
				}
			}
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x00046B2C File Offset: 0x00044D2C
		private object searchDat(DataTable dt, string column, string value)
		{
			CheckSerialNumber._Closure$__124-0 CS$<>8__locals1 = new CheckSerialNumber._Closure$__124-0(CS$<>8__locals1);
			CS$<>8__locals1.$VB$Local_column = column;
			CS$<>8__locals1.$VB$Local_value = value;
			DataTable dataTable = dt.Clone();
			dt.CaseSensitive = false;
			try
			{
				foreach (DataRow dataRow in dt.Rows.Cast<object>().Select<object, DataRow>((CheckSerialNumber._Closure$__.$I124-0 == null) ? (CheckSerialNumber._Closure$__.$I124-0 = (object row1) => (DataRow)row1) : CheckSerialNumber._Closure$__.$I124-0).Where<DataRow>((CS$<>8__locals1.$I1 == null) ? (CS$<>8__locals1.$I1 = (DataRow row1) => Conversions.ToBoolean(NewLateBinding.LateGet(row1[CS$<>8__locals1.$VB$Local_column], null, "Contains", new object[] { CS$<>8__locals1.$VB$Local_value.ToUpper() }, null, null, null))) : CS$<>8__locals1.$I1))
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

		// Token: 0x0600070F RID: 1807 RVA: 0x00046C08 File Offset: 0x00044E08
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

		// Token: 0x06000710 RID: 1808 RVA: 0x00046CC8 File Offset: 0x00044EC8
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

		// Token: 0x06000711 RID: 1809 RVA: 0x00046ED8 File Offset: 0x000450D8
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

		// Token: 0x06000712 RID: 1810 RVA: 0x00046F38 File Offset: 0x00045138
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

		// Token: 0x06000713 RID: 1811 RVA: 0x00046FFC File Offset: 0x000451FC
		private void SearchBarCode(int prodtID)
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
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "FetchProductByID2";
				sqlCommand.Parameters.AddWithValue("prodtID", prodtID);
				sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
				sqlCommand.Parameters.AddWithValue("isingridient", 0);
				DataTable dataTable = new DataTable();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				int num = sqlDataAdapter.Fill(dataTable);
				bool flag2 = num > 0;
				if (flag2)
				{
					DataRow dataRow = dataTable.Rows[0];
					this.txtDesc.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(dataRow["ProductDesc"], "("), Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["ProductDesc2"])), "", RuntimeHelpers.GetObjectValue(dataRow["ProductDesc2"]))), ")"));
					this.currentRecordSerial = Conversions.ToBoolean(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["RecordSerialNumber"])), false, RuntimeHelpers.GetObjectValue(dataRow["RecordSerialNumber"])));
					this.CurrentID = Conversions.ToInteger(dataRow["ProductID"]);
					this.CurrentCode = Conversions.ToString(dataRow["ProductCode"]);
					bool flag3 = this.currentRecordSerial;
					if (flag3)
					{
						this.btnEnable.Text = "record enabled. DISABLE RECORD SERIAL NUMBER FOR PRODUCT?";
					}
					else
					{
						this.btnEnable.Text = "record disabled. ENABLE RECORD SERIAL NUMBERS FOR PRODUCT?";
					}
				}
			}
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x000471E0 File Offset: 0x000453E0
		private void SearchProductCode(string prodtcode, int use_price_from_scale = 0, decimal price_from_scale = 0m, decimal qty_from_scale = 0m)
		{
			bool flag = (Operators.CompareString(prodtcode, "0", false) == 0) | (Operators.CompareString(prodtcode, "", false) == 0);
			if (flag)
			{
				this.txtSearchProductCode.Text = "";
			}
			else
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "FetchProductByCode2";
				sqlCommand.Parameters.AddWithValue("productcode", prodtcode);
				sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
				sqlCommand.Parameters.AddWithValue("isingridient", 0);
				DataTable dataTable = new DataTable();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				int num = sqlDataAdapter.Fill(dataTable);
				bool flag2 = num > 0;
				if (flag2)
				{
					DataRow dataRow = dataTable.Rows[0];
					int num2 = Conversions.ToInteger(dataRow["catid"]);
					this.txtDesc.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(dataRow["ProductDesc"], "("), Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["ProductDesc2"])), "", RuntimeHelpers.GetObjectValue(dataRow["ProductDesc2"]))), ")"));
					this.currentRecordSerial = Conversions.ToBoolean(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["RecordSerialNumber"])), false, RuntimeHelpers.GetObjectValue(dataRow["RecordSerialNumber"])));
					this.CurrentID = Conversions.ToInteger(dataRow["ProductID"]);
					this.CurrentCode = Conversions.ToString(dataRow["ProductCode"]);
					bool flag3 = this.currentRecordSerial;
					if (flag3)
					{
						this.btnEnable.Text = "record serial enabled. DISABLE RECORD SERIAL NUMBER FOR PRODUCT?";
					}
					else
					{
						this.btnEnable.Text = "record serial disabled. ENABLE RECORD SERIAL NUMBERS FOR PRODUCT?";
					}
				}
			}
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x000473F0 File Offset: 0x000455F0
		private void txtBarCode_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				try
				{
					this.lblerror.Text = "";
					this.txtDesc.Text = "No product matches your search.";
					bool flag2 = MyProject.Forms.Form1.deposits_inuse == 1;
					if (flag2)
					{
						bool flag3 = this.txtBarCode.Text.Length > 2;
						if (flag3)
						{
							string text = this.txtBarCode.Text.Substring(0, 3);
							bool flag4 = Operators.CompareString(text, "999", false) == 0;
							if (flag4)
							{
								PayDeposit payDeposit = new PayDeposit();
								payDeposit.depBarcode = this.txtBarCode.Text;
								payDeposit.coid = MyProject.Forms.Form1.coid;
								payDeposit.branch = MyProject.Forms.Form1.branch;
								payDeposit.ShowDialog(this);
								payDeposit.Dispose();
								this.txtBarCode.Select();
								return;
							}
						}
					}
					bool flag5 = MyProject.Forms.Form1.usingBarcodePrintingScale == 1;
					if (flag5)
					{
						DataRow butcheryProductDetails = this.GetButcheryProductDetails(Conversions.ToString(Interaction.IIf(Operators.CompareString(this.txtBarCode.Text, "", false) == 0, 0, this.txtBarCode.Text)));
						bool flag6 = Operators.ConditionalCompareObjectEqual(butcheryProductDetails[2], 1, false);
						if (flag6)
						{
							this.SearchProductCode(Conversions.ToString(butcheryProductDetails["productcode"]), 0, 0m, 0m);
						}
						else
						{
							this.txtDesc.Text = this.txtDesc.Text + " BARCODE PRODUCT NOT FOUND";
							this.SearchProductCode(Conversions.ToString(Interaction.IIf(Operators.CompareString(this.txtBarCode.Text, "", false) == 0, 0, this.txtBarCode.Text)), 0, 0m, 0m);
						}
					}
					else
					{
						this.SearchProductCode(Conversions.ToString(Interaction.IIf(Operators.CompareString(this.txtBarCode.Text, "", false) == 0, 0, this.txtBarCode.Text)), 0, 0m, 0m);
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Bar code error. Detail: " + ex.Message);
				}
			}
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x0004768C File Offset: 0x0004588C
		private DataRow GetButcheryProductDetails(string barcode)
		{
			DataRow dataRow = new DataTable
			{
				Columns = 
				{
					{
						"productcode",
						typeof(string)
					},
					{
						"productqty",
						typeof(decimal)
					},
					{
						"isvalidbutchery",
						typeof(int)
					},
					{
						"productprice",
						typeof(decimal)
					},
					{
						"use_price_from_scale",
						typeof(int)
					}
				}
			}.NewRow();
			DataRow dataRow2;
			try
			{
				this.GetBarcodeScaleSettings();
				string text = barcode.Substring(0, 1);
				bool flag = Conversions.ToDouble(text) == (double)this.BCstartchar;
				if (flag)
				{
					bool flag2 = MyProject.Forms.Form1.BarcodePrintingScaleWeight == 1;
					if (flag2)
					{
						string text2 = barcode.Substring(this.BCcodestartposition, this.BCcodelength);
						dataRow[4] = 0;
						dataRow[0] = text2;
						string text3 = barcode.Substring(this.BCweightstartposition, this.BCweightlength);
						bool flag3 = this.BCweightlength == 5;
						int num;
						if (flag3)
						{
							num = 1000;
						}
						else
						{
							bool flag4 = this.BCweightlength == 4;
							if (flag4)
							{
								num = 100;
							}
						}
						decimal num2 = decimal.Divide(Conversions.ToDecimal(text3), new decimal(num));
						dataRow[1] = Math.Round(num2, 4);
						dataRow[2] = 1;
						dataRow[3] = 0;
						dataRow2 = dataRow;
					}
					else
					{
						bool flag5 = MyProject.Forms.Form1.BarcodePrintingScalePrice == 1;
						if (flag5)
						{
							dataRow[4] = 1;
							string text4 = barcode.Substring(this.BCcodestartposition, this.BCcodelength);
							DataTable dataTable = this.FetchProductDetailsbyCode(text4);
							DataRow dataRow3 = dataTable.Rows[0];
							decimal num3 = Conversions.ToDecimal(dataRow3["SellingPrice"]);
							string text5 = barcode.Substring(this.BCpricestartposition, this.BCpricelength);
							decimal num4 = Conversions.ToDecimal(text5);
							num4 = Math.Round(decimal.Divide(num4, 100m), 2);
							string text6 = Conversions.ToString(dataRow3["UOM"]);
							bool flag6 = Operators.CompareString(text6, "EA", false) == 0;
							decimal num5;
							if (flag6)
							{
								num5 = 1m;
							}
							else
							{
								num5 = Math.Round(decimal.Divide(num4, num3), 5);
							}
							dataRow[0] = text4;
							dataRow[1] = num5;
							dataRow[2] = 1;
							dataRow[3] = num4;
							dataRow2 = dataRow;
						}
					}
				}
				else
				{
					dataRow[0] = " Then0";
					dataRow[1] = 0;
					dataRow[2] = 0;
					dataRow2 = dataRow;
				}
			}
			catch (Exception ex)
			{
				dataRow[0] = "0";
				dataRow[1] = 0;
				dataRow[2] = 0;
				dataRow2 = dataRow;
			}
			return dataRow2;
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x000479E4 File Offset: 0x00045BE4
		private DataTable FetchProductDetailsbyCode(string prodcode)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchProductByCode2";
			sqlCommand.Parameters.AddWithValue("productcode", prodcode);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x00047A70 File Offset: 0x00045C70
		private void GetBarcodeScaleSettings()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "BarcodeScaleSettingsSelect";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			DataRow dataRow = dataTable.Rows[0];
			bool flag = Conversions.ToBoolean(dataRow["hasweight"]);
			if (flag)
			{
				this.BCweightlength = Conversions.ToInteger(dataRow["WeightLength"]);
				this.BCweightstartposition = Conversions.ToInteger(dataRow["WeightStartPosition"]);
			}
			else
			{
				this.BCpricelength = Conversions.ToInteger(dataRow["PriceLength"]);
				this.BCpricestartposition = Conversions.ToInteger(dataRow["PriceStartPosition"]);
			}
			this.BCcodestartposition = Conversions.ToInteger(dataRow["CodeStartPosition"]);
			this.BCcodelength = Conversions.ToInteger(dataRow["CodeLength"]);
			this.BCstartchar = Conversions.ToInteger(dataRow["startchar"]);
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x00047BCC File Offset: 0x00045DCC
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.CurrentID == 0;
				if (flag)
				{
					MessageBox.Show("Please select a product first.");
				}
				else
				{
					SqlConnection sqlConnection = new SqlConnection(this._cnn);
					SqlCommand sqlCommand = sqlConnection.CreateCommand();
					sqlCommand.CommandType = CommandType.StoredProcedure;
					sqlCommand.CommandText = "SearchSerialNumbersForProduct";
					sqlCommand.Parameters.AddWithValue("productid", this.CurrentID);
					sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
					sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
					DataTable dataTable = new DataTable();
					SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
					int num = sqlDataAdapter.Fill(dataTable);
					this.dgvSerials.DataSource = dataTable;
					this.dgvSerials.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error. Details: " + ex.Message);
			}
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x00047CF0 File Offset: 0x00045EF0
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.txtSerial.Text, "", false) == 0;
				if (flag)
				{
					MessageBox.Show("Please enter the serial number first.");
				}
				else
				{
					SqlConnection sqlConnection = new SqlConnection(this._cnn);
					SqlCommand sqlCommand = sqlConnection.CreateCommand();
					sqlCommand.CommandType = CommandType.StoredProcedure;
					sqlCommand.CommandText = "SearchSerialNumbersBySerial";
					sqlCommand.Parameters.AddWithValue("serialnumber", this.txtSerial.Text);
					sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
					sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
					DataTable dataTable = new DataTable();
					SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
					int num = sqlDataAdapter.Fill(dataTable);
					this.dgvSerials.DataSource = dataTable;
					this.dgvSerials.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error. Details: " + ex.Message);
			}
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x00047E24 File Offset: 0x00046024
		private void txtSearchProductCode_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.txtDesc.Text = "No product matches your search.";
				bool flag = Operators.CompareString(this.txtSearchProductCode.Text, " ", false) != 0;
				if (flag)
				{
					this.SearchBarCode(Conversions.ToInteger(Interaction.IIf(Operators.CompareString(this.txtSearchProductCode.Text, "", false) == 0, 0, Conversion.Val(this.txtSearchProductCode.Text))));
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Details: " + ex.Message, "Error");
			}
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x00047EE8 File Offset: 0x000460E8
		private void btnEnable_Click(object sender, EventArgs e)
		{
			try
			{
				string text = "";
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.Text;
				bool flag = this.currentRecordSerial;
				if (flag)
				{
					sqlCommand.CommandText = "update products set recordserialnumber=0 where productid=" + Conversions.ToString(this.CurrentID) + " and coid=" + Conversions.ToString(MyProject.Forms.Form1.coid);
					text = "Record Serial Number for product has been disabled.";
				}
				else
				{
					sqlCommand.CommandText = "update products set recordserialnumber=1 where productid=" + Conversions.ToString(this.CurrentID) + " and coid=" + Conversions.ToString(MyProject.Forms.Form1.coid);
					text = "Record Serial Number for product has been enabled.";
				}
				using (sqlConnection)
				{
					sqlConnection.Open();
					sqlCommand.ExecuteNonQuery();
					sqlConnection.Close();
				}
				MessageBox.Show(text);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x00048014 File Offset: 0x00046214
		private void Button4_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.Text;
				sqlCommand.CommandText = "update products set recordserialnumber=1 where coid=" + Conversions.ToString(MyProject.Forms.Form1.coid);
				using (sqlConnection)
				{
					sqlConnection.Open();
					sqlCommand.ExecuteNonQuery();
					sqlConnection.Close();
				}
				MessageBox.Show("All products now require serial numbers when making new purchases and for sales");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x000480E0 File Offset: 0x000462E0
		private void Button5_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.Text;
				sqlCommand.CommandText = "update products set recordserialnumber=0 where coid=" + Conversions.ToString(MyProject.Forms.Form1.coid);
				using (sqlConnection)
				{
					sqlConnection.Open();
					sqlCommand.ExecuteNonQuery();
					sqlConnection.Close();
				}
				MessageBox.Show("All products DO NOT require or use serial numbers when making new purchases and for sales");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error. Detail: " + ex.Message);
			}
		}

		// Token: 0x0400034B RID: 843
		private string _cnn;

		// Token: 0x0400034C RID: 844
		private bool currentRecordSerial;

		// Token: 0x0400034D RID: 845
		private int CurrentID;

		// Token: 0x0400034E RID: 846
		private string CurrentCode;

		// Token: 0x0400034F RID: 847
		private int BCweightlength;

		// Token: 0x04000350 RID: 848
		private int BCweightstartposition;

		// Token: 0x04000351 RID: 849
		private int BCpricelength;

		// Token: 0x04000352 RID: 850
		private int BCpricestartposition;

		// Token: 0x04000353 RID: 851
		private int BCcodestartposition;

		// Token: 0x04000354 RID: 852
		private int BCcodelength;

		// Token: 0x04000355 RID: 853
		private int BCstartchar;

		// Token: 0x04000356 RID: 854
		private PublicFunctions pf;
	}
}
