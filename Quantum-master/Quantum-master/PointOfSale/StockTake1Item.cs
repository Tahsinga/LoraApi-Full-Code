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
	// Token: 0x020001F3 RID: 499
	[DesignerGenerated]
	public partial class StockTake1Item : Form
	{
		// Token: 0x06005827 RID: 22567 RVA: 0x0032AD24 File Offset: 0x00328F24
		public StockTake1Item()
		{
			base.Load += this.StockTake1Item_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.currentID = 0;
			this.currentCost = 0m;
			this.currentExpires = false;
			this.pf = new PublicFunctions();
			this.firstbalrun = false;
			this.InitializeComponent();
		}

		// Token: 0x17001FB7 RID: 8119
		// (get) Token: 0x0600582A RID: 22570 RVA: 0x0032BEEE File Offset: 0x0032A0EE
		// (set) Token: 0x0600582B RID: 22571 RVA: 0x0032BEF8 File Offset: 0x0032A0F8
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FB8 RID: 8120
		// (get) Token: 0x0600582C RID: 22572 RVA: 0x0032BF01 File Offset: 0x0032A101
		// (set) Token: 0x0600582D RID: 22573 RVA: 0x0032BF0B File Offset: 0x0032A10B
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FB9 RID: 8121
		// (get) Token: 0x0600582E RID: 22574 RVA: 0x0032BF14 File Offset: 0x0032A114
		// (set) Token: 0x0600582F RID: 22575 RVA: 0x0032BF1E File Offset: 0x0032A11E
		internal virtual Panel Panel4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FBA RID: 8122
		// (get) Token: 0x06005830 RID: 22576 RVA: 0x0032BF27 File Offset: 0x0032A127
		// (set) Token: 0x06005831 RID: 22577 RVA: 0x0032BF34 File Offset: 0x0032A134
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

		// Token: 0x17001FBB RID: 8123
		// (get) Token: 0x06005832 RID: 22578 RVA: 0x0032BF77 File Offset: 0x0032A177
		// (set) Token: 0x06005833 RID: 22579 RVA: 0x0032BF81 File Offset: 0x0032A181
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FBC RID: 8124
		// (get) Token: 0x06005834 RID: 22580 RVA: 0x0032BF8A File Offset: 0x0032A18A
		// (set) Token: 0x06005835 RID: 22581 RVA: 0x0032BF94 File Offset: 0x0032A194
		internal virtual Label Label10
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FBD RID: 8125
		// (get) Token: 0x06005836 RID: 22582 RVA: 0x0032BF9D File Offset: 0x0032A19D
		// (set) Token: 0x06005837 RID: 22583 RVA: 0x0032BFA8 File Offset: 0x0032A1A8
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

		// Token: 0x17001FBE RID: 8126
		// (get) Token: 0x06005838 RID: 22584 RVA: 0x0032BFEB File Offset: 0x0032A1EB
		// (set) Token: 0x06005839 RID: 22585 RVA: 0x0032BFF5 File Offset: 0x0032A1F5
		internal virtual Label Label16
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FBF RID: 8127
		// (get) Token: 0x0600583A RID: 22586 RVA: 0x0032BFFE File Offset: 0x0032A1FE
		// (set) Token: 0x0600583B RID: 22587 RVA: 0x0032C008 File Offset: 0x0032A208
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

		// Token: 0x17001FC0 RID: 8128
		// (get) Token: 0x0600583C RID: 22588 RVA: 0x0032C066 File Offset: 0x0032A266
		// (set) Token: 0x0600583D RID: 22589 RVA: 0x0032C070 File Offset: 0x0032A270
		internal virtual Label lblDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FC1 RID: 8129
		// (get) Token: 0x0600583E RID: 22590 RVA: 0x0032C079 File Offset: 0x0032A279
		// (set) Token: 0x0600583F RID: 22591 RVA: 0x0032C084 File Offset: 0x0032A284
		internal virtual Button Button8
		{
			[CompilerGenerated]
			get
			{
				return this._Button8;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button8_Click);
				Button button = this._Button8;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button8 = value;
				button = this._Button8;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17001FC2 RID: 8130
		// (get) Token: 0x06005840 RID: 22592 RVA: 0x0032C0C7 File Offset: 0x0032A2C7
		// (set) Token: 0x06005841 RID: 22593 RVA: 0x0032C0D1 File Offset: 0x0032A2D1
		internal virtual DataGridView dgvProducts
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FC3 RID: 8131
		// (get) Token: 0x06005842 RID: 22594 RVA: 0x0032C0DA File Offset: 0x0032A2DA
		// (set) Token: 0x06005843 RID: 22595 RVA: 0x0032C0E4 File Offset: 0x0032A2E4
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

		// Token: 0x17001FC4 RID: 8132
		// (get) Token: 0x06005844 RID: 22596 RVA: 0x0032C127 File Offset: 0x0032A327
		// (set) Token: 0x06005845 RID: 22597 RVA: 0x0032C131 File Offset: 0x0032A331
		internal virtual TextBox txtBarCode
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FC5 RID: 8133
		// (get) Token: 0x06005846 RID: 22598 RVA: 0x0032C13A File Offset: 0x0032A33A
		// (set) Token: 0x06005847 RID: 22599 RVA: 0x0032C144 File Offset: 0x0032A344
		internal virtual Label Label15
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FC6 RID: 8134
		// (get) Token: 0x06005848 RID: 22600 RVA: 0x0032C14D File Offset: 0x0032A34D
		// (set) Token: 0x06005849 RID: 22601 RVA: 0x0032C157 File Offset: 0x0032A357
		internal virtual Label Label9
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FC7 RID: 8135
		// (get) Token: 0x0600584A RID: 22602 RVA: 0x0032C160 File Offset: 0x0032A360
		// (set) Token: 0x0600584B RID: 22603 RVA: 0x0032C16C File Offset: 0x0032A36C
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

		// Token: 0x17001FC8 RID: 8136
		// (get) Token: 0x0600584C RID: 22604 RVA: 0x0032C1AF File Offset: 0x0032A3AF
		// (set) Token: 0x0600584D RID: 22605 RVA: 0x0032C1B9 File Offset: 0x0032A3B9
		internal virtual CheckBox chkViewAll
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FC9 RID: 8137
		// (get) Token: 0x0600584E RID: 22606 RVA: 0x0032C1C2 File Offset: 0x0032A3C2
		// (set) Token: 0x0600584F RID: 22607 RVA: 0x0032C1CC File Offset: 0x0032A3CC
		internal virtual ProgressBar ProgressBar1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FCA RID: 8138
		// (get) Token: 0x06005850 RID: 22608 RVA: 0x0032C1D5 File Offset: 0x0032A3D5
		// (set) Token: 0x06005851 RID: 22609 RVA: 0x0032C1DF File Offset: 0x0032A3DF
		internal virtual DateTimePicker DTdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FCB RID: 8139
		// (get) Token: 0x06005852 RID: 22610 RVA: 0x0032C1E8 File Offset: 0x0032A3E8
		// (set) Token: 0x06005853 RID: 22611 RVA: 0x0032C1F4 File Offset: 0x0032A3F4
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

		// Token: 0x17001FCC RID: 8140
		// (get) Token: 0x06005854 RID: 22612 RVA: 0x0032C237 File Offset: 0x0032A437
		// (set) Token: 0x06005855 RID: 22613 RVA: 0x0032C241 File Offset: 0x0032A441
		internal virtual Label lblStockBal
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FCD RID: 8141
		// (get) Token: 0x06005856 RID: 22614 RVA: 0x0032C24A File Offset: 0x0032A44A
		// (set) Token: 0x06005857 RID: 22615 RVA: 0x0032C254 File Offset: 0x0032A454
		internal virtual DataGridView DataGridView1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FCE RID: 8142
		// (get) Token: 0x06005858 RID: 22616 RVA: 0x0032C25D File Offset: 0x0032A45D
		// (set) Token: 0x06005859 RID: 22617 RVA: 0x0032C267 File Offset: 0x0032A467
		internal virtual CheckBox chkRecordAll
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x0600585A RID: 22618 RVA: 0x00002A30 File Offset: 0x00000C30
		private void lblDesc_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600585B RID: 22619 RVA: 0x0032C270 File Offset: 0x0032A470
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

		// Token: 0x0600585C RID: 22620 RVA: 0x0032C330 File Offset: 0x0032A530
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

		// Token: 0x0600585D RID: 22621 RVA: 0x0032C3B8 File Offset: 0x0032A5B8
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

		// Token: 0x0600585E RID: 22622 RVA: 0x0032C4B0 File Offset: 0x0032A6B0
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

		// Token: 0x0600585F RID: 22623 RVA: 0x0032C5BC File Offset: 0x0032A7BC
		private object searchDat(DataTable dt, string column, string value)
		{
			StockTake1Item._Closure$__111-0 CS$<>8__locals1 = new StockTake1Item._Closure$__111-0(CS$<>8__locals1);
			CS$<>8__locals1.$VB$Local_column = column;
			CS$<>8__locals1.$VB$Local_value = value;
			DataTable dataTable = dt.Clone();
			dt.CaseSensitive = false;
			try
			{
				foreach (DataRow dataRow in dt.Rows.Cast<object>().Select<object, DataRow>((StockTake1Item._Closure$__.$I111-0 == null) ? (StockTake1Item._Closure$__.$I111-0 = (object row1) => (DataRow)row1) : StockTake1Item._Closure$__.$I111-0).Where<DataRow>((CS$<>8__locals1.$I1 == null) ? (CS$<>8__locals1.$I1 = (DataRow row1) => Conversions.ToBoolean(NewLateBinding.LateGet(row1[CS$<>8__locals1.$VB$Local_column], null, "Contains", new object[] { CS$<>8__locals1.$VB$Local_value.ToUpper() }, null, null, null))) : CS$<>8__locals1.$I1))
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

		// Token: 0x06005860 RID: 22624 RVA: 0x0032C698 File Offset: 0x0032A898
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

		// Token: 0x06005861 RID: 22625 RVA: 0x0032C720 File Offset: 0x0032A920
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

		// Token: 0x06005862 RID: 22626 RVA: 0x0032C7A8 File Offset: 0x0032A9A8
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

		// Token: 0x06005863 RID: 22627 RVA: 0x0032C810 File Offset: 0x0032AA10
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
				this.currentCost = Conversions.ToDecimal(dataRow["Cost"]);
				this.currentExpires = Conversions.ToBoolean(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["ProductExpires"])), false, RuntimeHelpers.GetObjectValue(dataRow["ProductExpires"])));
				bool flag2 = this.currentExpires;
				if (flag2)
				{
					this.chkViewAll.Visible = true;
				}
				else
				{
					bool flag3 = MyProject.Forms.Form1.IsWarehouse == 1;
					if (flag3)
					{
						this.chkViewAll.Visible = true;
					}
					else
					{
						this.chkViewAll.Visible = false;
					}
				}
				this.GetStockBalance();
				this.lblStockBal.Text = Conversions.ToString(this.pf.GetStockAvailable(this._cnn, this.currentID, this.DataGridView1, dataRow["UOM"].ToString(), MyProject.Forms.Form1.isRestaurant, 0, false, "", 0, false));
			}
			else
			{
				this.lblDesc.Text = "Nothing found matching that product ID";
				this.ClearForm();
			}
		}

		// Token: 0x06005864 RID: 22628 RVA: 0x0032C9F8 File Offset: 0x0032ABF8
		private void ClearForm()
		{
			this.txtSearchProductCode.Text = "";
			DataTable dataTable = new DataTable();
			this.dgvProducts.DataSource = dataTable;
		}

		// Token: 0x06005865 RID: 22629 RVA: 0x0032CA2C File Offset: 0x0032AC2C
		private DataTable GetBal(int showall)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "StockBalanceWarehouse";
			sqlCommand.Parameters.AddWithValue("productid", this.currentID);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			sqlCommand.Parameters.AddWithValue("showall", showall);
			DataTable dataTable = new DataTable();
			new SqlDataAdapter(sqlCommand)
			{
				SelectCommand = sqlCommand
			}.Fill(dataTable);
			dataTable.Columns.Add("physicalbal", typeof(int));
			dataTable.Columns.Add("colvar", typeof(string));
			return dataTable;
		}

		// Token: 0x06005866 RID: 22630 RVA: 0x0032CB3C File Offset: 0x0032AD3C
		private void Button8_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = (MyProject.Forms.Form1.IsWarehouse | ((-((this.currentExpires > false) ? 1 : 0)) ? 1 : 0)) != 0;
				if (flag)
				{
					DataTable bal = this.GetBal(Conversions.ToInteger(Interaction.IIf(this.chkViewAll.Checked, 1, 0)));
					this.dgvProducts.DataSource = bal;
					try
					{
						foreach (object obj in ((IEnumerable)this.dgvProducts.Rows))
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							dataGridViewRow.Cells["physicalbal"].Value = RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["bal"].Value);
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
					DataTable dataTable = new DataTable("TableName");
					DataColumn dataColumn = new DataColumn("productid", typeof(int));
					DataColumn dataColumn2 = new DataColumn("bal", typeof(decimal));
					DataColumn dataColumn3 = new DataColumn("physicalbal", typeof(decimal));
					DataColumn dataColumn4 = new DataColumn("colvar", typeof(string));
					dataTable.Columns.Add(dataColumn);
					dataTable.Columns.Add(dataColumn2);
					dataTable.Columns.Add(dataColumn3);
					dataTable.Columns.Add(dataColumn4);
					DataRow dataRow = dataTable.NewRow();
					dataRow["productid"] = this.currentID.ToString();
					decimal stockBalSimple = this.pf.GetStockBalSimple(this._cnn, this.currentID, MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch);
					dataRow["bal"] = stockBalSimple;
					dataRow["physicalbal"] = stockBalSimple;
					dataRow["colvar"] = "";
					dataTable.Rows.Add(dataRow);
					this.dgvProducts.DataSource = dataTable;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error showing stock balances. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005867 RID: 22631 RVA: 0x0032CDCC File Offset: 0x0032AFCC
		private void GetStockBalance()
		{
			bool flag = (MyProject.Forms.Form1.IsWarehouse | ((-((this.currentExpires > false) ? 1 : 0)) ? 1 : 0)) != 0;
			if (flag)
			{
				DataTable bal = this.GetBal(Conversions.ToInteger(Interaction.IIf(this.chkViewAll.Checked, 1, 0)));
				this.dgvProducts.DataSource = bal;
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvProducts.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						dataGridViewRow.Cells["physicalbal"].Value = RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["bal"].Value);
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
				this.dgvProducts.Columns["bal"].DefaultCellStyle.BackColor = Color.LightGray;
				this.dgvProducts.Columns["bal"].ReadOnly = true;
				this.dgvProducts.Columns["productid"].DefaultCellStyle.BackColor = Color.LightGray;
				this.dgvProducts.Columns["productid"].ReadOnly = true;
				this.dgvProducts.Columns["batchnumber"].DefaultCellStyle.BackColor = Color.LightGray;
				this.dgvProducts.Columns["batchnumber"].ReadOnly = true;
				this.dgvProducts.Columns["expirydate"].DefaultCellStyle.BackColor = Color.LightGray;
				this.dgvProducts.Columns["expirydate"].ReadOnly = true;
			}
			else
			{
				this.pf.GetStockBalSimple(this._cnn, this.currentID, MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch);
			}
		}

		// Token: 0x06005868 RID: 22632 RVA: 0x0032CFF8 File Offset: 0x0032B1F8
		private void StockTake1Item_Load(object sender, EventArgs e)
		{
			try
			{
				bool flag = MyProject.Forms.Form1.IsWarehouse != 0;
				if (flag)
				{
					this.chkViewAll.Visible = true;
				}
				else
				{
					this.chkViewAll.Visible = false;
				}
				this.firstbalrun = this.pf.CheckIfFirstBalRun(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, this._cnn);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading ");
			}
		}

		// Token: 0x06005869 RID: 22633 RVA: 0x0032D0A0 File Offset: 0x0032B2A0
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = (MyProject.Forms.Form1.IsWarehouse == 1) | this.currentExpires;
				if (flag)
				{
					this.AdjustStockBatchNumbers();
				}
				else
				{
					this.AdjustStock();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Stock adjustment failed. Deetail: " + ex.Message);
			}
		}

		// Token: 0x0600586A RID: 22634 RVA: 0x0032D118 File Offset: 0x0032B318
		private void AdjustStockBatchNumbers()
		{
			this.ProgressBar1.Visible = true;
			this.ProgressBar1.BringToFront();
			this.ProgressBar1.Minimum = 1;
			this.ProgressBar1.Maximum = 3;
			this.ProgressBar1.Step = 1;
			this.ProgressBar1.PerformStep();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlConnection.Open();
			SqlTransaction sqlTransaction = sqlConnection.BeginTransaction("RunStockTake");
			sqlCommand.Connection = sqlConnection;
			sqlCommand.Transaction = sqlTransaction;
			try
			{
				this.ProgressBar1.PerformStep();
				int num = checked((int)Math.Round(Conversion.Val(DateAndTime.TimeOfDay.ToString("HHmm"))));
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvProducts.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						decimal num2 = new decimal(Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["bal"].Value)));
						decimal num3 = new decimal(Conversion.Val(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["physicalbal"].Value)), 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["physicalbal"].Value)))));
						bool flag = decimal.Compare(num2, num3) == 0;
						if (flag)
						{
							bool flag2 = !this.firstbalrun;
							if (flag2)
							{
								sqlCommand.Parameters.Clear();
								sqlCommand.CommandType = CommandType.StoredProcedure;
								sqlCommand.CommandText = "InsertNewStockStockTakeWarehouse";
								sqlCommand.Parameters.AddWithValue("trandate", this.DTdate.Value.ToString("yyyyMMdd"));
								sqlCommand.Parameters.AddWithValue("invoicenum", 0);
								sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ProductID"].Value));
								sqlCommand.Parameters.AddWithValue("isstockin", 1);
								sqlCommand.Parameters.AddWithValue("ref", "STOCK MAINTAINED");
								sqlCommand.Parameters.AddWithValue("quantity", 0);
								sqlCommand.Parameters.AddWithValue("cost", this.currentCost);
								sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
								sqlCommand.Parameters.AddWithValue("donewhen", DateTime.Today.ToString("yyyyMMdd"));
								sqlCommand.Parameters.AddWithValue("trancode", 2);
								sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
								sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
								sqlCommand.Parameters.AddWithValue("batchnumber", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["BatchNumber"].Value));
								sqlCommand.Parameters.AddWithValue("expdate", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ExpiryDate"].Value));
								bool flag3 = dataGridViewRow.Cells["colvar"].Value == null;
								string text;
								if (flag3)
								{
									text = "";
								}
								else
								{
									text = dataGridViewRow.Cells["colvar"].Value.ToString();
								}
								sqlCommand.Parameters.AddWithValue("details", text);
								sqlCommand.Parameters.AddWithValue("stockbal", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["bal"].Value));
								sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
								sqlCommand.Parameters.AddWithValue("trantime", DateTime.Now.ToString("HH:mm"));
								sqlCommand.ExecuteNonQuery();
							}
						}
						else
						{
							bool flag4 = decimal.Compare(num2, num3) > 0;
							if (flag4)
							{
								sqlCommand.Parameters.Clear();
								sqlCommand.CommandType = CommandType.StoredProcedure;
								sqlCommand.CommandText = "InsertNewSaleStockTakeWarehouse";
								sqlCommand.Parameters.AddWithValue("trandate", this.DTdate.Value.ToString("yyyyMMdd"));
								sqlCommand.Parameters.AddWithValue("invoicenum", 0);
								sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ProductID"].Value));
								sqlCommand.Parameters.AddWithValue("isstockin", 0);
								sqlCommand.Parameters.AddWithValue("ref", "STOCK REDUCED");
								sqlCommand.Parameters.AddWithValue("quantity", decimal.Subtract(num2, num3));
								sqlCommand.Parameters.AddWithValue("unitcost", this.currentCost);
								sqlCommand.Parameters.AddWithValue("salesprice", 0);
								sqlCommand.Parameters.AddWithValue("paymentmethod", 0);
								sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
								sqlCommand.Parameters.AddWithValue("donewhen", DateTime.Today.ToString("yyyyMMdd"));
								sqlCommand.Parameters.AddWithValue("trancode", 2);
								sqlCommand.Parameters.AddWithValue("TranTime", num);
								sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
								sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
								sqlCommand.Parameters.AddWithValue("batchnumber", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["BatchNumber"].Value));
								sqlCommand.Parameters.AddWithValue("expdate", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ExpiryDate"].Value));
								bool flag5 = dataGridViewRow.Cells["colvar"].Value == null;
								string text2;
								if (flag5)
								{
									text2 = "";
								}
								else
								{
									text2 = dataGridViewRow.Cells["colvar"].Value.ToString();
								}
								sqlCommand.Parameters.AddWithValue("details", text2);
								sqlCommand.Parameters.AddWithValue("stockbal", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["bal"].Value));
								sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
								sqlCommand.ExecuteNonQuery();
							}
							else
							{
								bool flag6 = decimal.Compare(num2, num3) < 0;
								if (flag6)
								{
									sqlCommand.Parameters.Clear();
									sqlCommand.CommandType = CommandType.StoredProcedure;
									sqlCommand.CommandText = "InsertNewStockStockTakeWarehouse";
									sqlCommand.Parameters.AddWithValue("trandate", this.DTdate.Value.ToString("yyyyMMdd"));
									sqlCommand.Parameters.AddWithValue("invoicenum", 0);
									sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ProductID"].Value));
									sqlCommand.Parameters.AddWithValue("isstockin", 1);
									sqlCommand.Parameters.AddWithValue("ref", "STOCK INCREASED");
									sqlCommand.Parameters.AddWithValue("quantity", decimal.Subtract(num3, num2));
									sqlCommand.Parameters.AddWithValue("cost", this.currentCost);
									sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
									sqlCommand.Parameters.AddWithValue("donewhen", DateTime.Today.ToString("yyyyMMdd"));
									sqlCommand.Parameters.AddWithValue("trancode", 2);
									sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
									sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
									sqlCommand.Parameters.AddWithValue("batchnumber", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["BatchNumber"].Value));
									sqlCommand.Parameters.AddWithValue("expdate", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ExpiryDate"].Value));
									bool flag7 = dataGridViewRow.Cells["colvar"].Value == null;
									string text3;
									if (flag7)
									{
										text3 = "";
									}
									else
									{
										text3 = dataGridViewRow.Cells["colvar"].Value.ToString();
									}
									sqlCommand.Parameters.AddWithValue("details", text3);
									sqlCommand.Parameters.AddWithValue("stockbal", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["bal"].Value));
									sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
									sqlCommand.Parameters.AddWithValue("trantime", DateTime.Now.ToString("HH:mm"));
									sqlCommand.ExecuteNonQuery();
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
				bool flag8 = !this.firstbalrun;
				if (flag8)
				{
					sqlCommand.Parameters.Clear();
					sqlCommand.CommandType = CommandType.Text;
					sqlCommand.CommandText = string.Concat(new string[]
					{
						"update branches set FirstStockBalRun=1 where coid=",
						Conversions.ToString(MyProject.Forms.Form1.coid),
						" and branch='",
						MyProject.Forms.Form1.branch,
						"'"
					});
					sqlCommand.ExecuteNonQuery();
				}
				sqlTransaction.Commit();
				sqlCommand.Connection.Close();
				this.ProgressBar1.PerformStep();
				this.ProgressBar1.Visible = false;
				MessageBox.Show("Stock adjusted successfully. To view adjustments made please go to the reports.");
				this.GetBal(Conversions.ToInteger(Interaction.IIf(this.chkViewAll.Checked, 1, 0)));
				this.ClearForm();
			}
			catch (Exception ex)
			{
				sqlTransaction.Rollback();
				sqlCommand.Connection.Close();
				this.ProgressBar1.Visible = false;
				MessageBox.Show("Error occured adjusting stock. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600586B RID: 22635 RVA: 0x0032DC9C File Offset: 0x0032BE9C
		private void AdjustStock()
		{
			this.ProgressBar1.Visible = true;
			this.ProgressBar1.BringToFront();
			this.ProgressBar1.Minimum = 1;
			this.ProgressBar1.Maximum = 3;
			this.ProgressBar1.Step = 1;
			this.ProgressBar1.PerformStep();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlConnection.Open();
			SqlTransaction sqlTransaction = sqlConnection.BeginTransaction("RunStockTake");
			sqlCommand.Connection = sqlConnection;
			sqlCommand.Transaction = sqlTransaction;
			sqlCommand.CommandTimeout = 0;
			try
			{
				int nextInvNumStockTake = this.pf.GetNextInvNumStockTake(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, this._cnn);
				this.ProgressBar1.PerformStep();
				int num = checked((int)Math.Round(Conversion.Val(DateAndTime.TimeOfDay.ToString("HHmm"))));
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvProducts.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						bool flag = Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["bal"].Value));
						if (flag)
						{
							MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject("stock bal is null. productcode ", dataGridViewRow.Cells["ProductDesc"].Value)));
						}
						decimal num2 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["bal"].Value));
						decimal num3 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["physicalbal"].Value)), 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["physicalbal"].Value))));
						bool flag2 = decimal.Compare(num2, num3) > 0;
						if (flag2)
						{
							sqlCommand.Parameters.Clear();
							sqlCommand.CommandType = CommandType.StoredProcedure;
							sqlCommand.CommandText = "InsertNewSaleStockTake";
							sqlCommand.Parameters.AddWithValue("trandate", this.DTdate.Value.ToString("yyyyMMdd"));
							sqlCommand.Parameters.AddWithValue("invoicenum", nextInvNumStockTake);
							sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ProductID"].Value));
							sqlCommand.Parameters.AddWithValue("isstockin", 0);
							sqlCommand.Parameters.AddWithValue("ref", "STOCK REDUCED");
							sqlCommand.Parameters.AddWithValue("quantity", decimal.Subtract(num2, num3));
							sqlCommand.Parameters.AddWithValue("unitcost", this.currentCost);
							sqlCommand.Parameters.AddWithValue("salesprice", 0);
							sqlCommand.Parameters.AddWithValue("paymentmethod", 0);
							sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
							sqlCommand.Parameters.AddWithValue("donewhen", DateTime.Today.ToString("yyyyMMdd"));
							sqlCommand.Parameters.AddWithValue("trancode", 2);
							sqlCommand.Parameters.AddWithValue("TranTime", num);
							sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
							sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
							bool flag3 = dataGridViewRow.Cells["colvar"].Value == null;
							string text;
							if (flag3)
							{
								text = "";
							}
							else
							{
								text = dataGridViewRow.Cells["colvar"].Value.ToString();
							}
							sqlCommand.Parameters.AddWithValue("details", text);
							sqlCommand.Parameters.AddWithValue("stockbal", num2);
							sqlCommand.ExecuteNonQuery();
						}
						else
						{
							bool flag4 = decimal.Compare(num2, num3) < 0;
							if (flag4)
							{
								sqlCommand.Parameters.Clear();
								sqlCommand.CommandType = CommandType.StoredProcedure;
								sqlCommand.CommandText = "InsertNewStockStockTake";
								sqlCommand.Parameters.AddWithValue("trandate", this.DTdate.Value.ToString("yyyyMMdd"));
								sqlCommand.Parameters.AddWithValue("invoicenum", nextInvNumStockTake);
								sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ProductID"].Value));
								sqlCommand.Parameters.AddWithValue("isstockin", 1);
								sqlCommand.Parameters.AddWithValue("ref", "STOCK INCREASED");
								sqlCommand.Parameters.AddWithValue("quantity", decimal.Subtract(num3, num2));
								sqlCommand.Parameters.AddWithValue("cost", this.currentCost);
								sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
								sqlCommand.Parameters.AddWithValue("donewhen", DateTime.Today.ToString("yyyyMMdd"));
								sqlCommand.Parameters.AddWithValue("trancode", 2);
								sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
								sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
								bool flag5 = dataGridViewRow.Cells["colvar"].Value == null;
								string text2;
								if (flag5)
								{
									text2 = "";
								}
								else
								{
									text2 = dataGridViewRow.Cells["colvar"].Value.ToString();
								}
								sqlCommand.Parameters.AddWithValue("details", text2);
								sqlCommand.Parameters.AddWithValue("stockbal", num2);
								sqlCommand.ExecuteNonQuery();
							}
							else
							{
								num2 = num3;
								bool flag6 = !this.firstbalrun | this.chkRecordAll.Checked;
								if (flag6)
								{
									sqlCommand.Parameters.Clear();
									sqlCommand.CommandType = CommandType.StoredProcedure;
									sqlCommand.CommandText = "InsertNewStockStockTake";
									sqlCommand.Parameters.AddWithValue("trandate", this.DTdate.Value.ToString("yyyyMMdd"));
									sqlCommand.Parameters.AddWithValue("invoicenum", nextInvNumStockTake);
									sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ProductID"].Value));
									sqlCommand.Parameters.AddWithValue("isstockin", 1);
									sqlCommand.Parameters.AddWithValue("ref", "STOCK MAINTAINED");
									sqlCommand.Parameters.AddWithValue("quantity", 0);
									sqlCommand.Parameters.AddWithValue("cost", this.currentCost);
									sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
									sqlCommand.Parameters.AddWithValue("donewhen", DateTime.Today.ToString("yyyyMMdd"));
									sqlCommand.Parameters.AddWithValue("trancode", 2);
									sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
									sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
									bool flag7 = dataGridViewRow.Cells["colvar"].Value == null;
									string text3;
									if (flag7)
									{
										text3 = "";
									}
									else
									{
										text3 = dataGridViewRow.Cells["colvar"].Value.ToString();
									}
									sqlCommand.Parameters.AddWithValue("details", text3);
									sqlCommand.Parameters.AddWithValue("stockbal", num2);
									sqlCommand.ExecuteNonQuery();
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
				this.ProgressBar1.PerformStep();
				this.ProgressBar1.Visible = false;
				MessageBox.Show("Stock adjusted successfully. To view adjustments made please go to the reports.");
				base.Close();
			}
			catch (Exception ex)
			{
				try
				{
					this.ProgressBar1.Visible = false;
					MessageBox.Show("Error occured adjusting stock. Detail: " + ex.Message);
					sqlTransaction.Rollback();
					sqlCommand.Connection.Close();
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x0600586C RID: 22636 RVA: 0x0032E658 File Offset: 0x0032C858
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				DialogResult dialogResult = (DialogResult)Interaction.MsgBox("Do you want to redo quick stock bal intialisation? This may take a long time depending.", MsgBoxStyle.YesNo, null);
				bool flag = dialogResult == DialogResult.Yes;
				if (flag)
				{
					Cursor.Current = Cursors.WaitCursor;
					SqlConnection sqlConnection = new SqlConnection(this._cnn);
					SqlCommand sqlCommand = sqlConnection.CreateCommand();
					sqlCommand.CommandType = CommandType.StoredProcedure;
					sqlCommand.CommandText = "SetQuickStockBalForOne";
					sqlCommand.CommandTimeout = 0;
					sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
					sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
					sqlCommand.Parameters.AddWithValue("iswarehouse", MyProject.Forms.Form1.IsWarehouse);
					sqlCommand.Parameters.AddWithValue("productid", this.currentID);
					using (sqlConnection)
					{
						sqlConnection.Open();
						sqlCommand.ExecuteNonQuery();
						sqlConnection.Close();
					}
					Cursor.Current = Cursors.Default;
					MessageBox.Show("Quick stock balance run successfully.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error redoing quick stock bal initialisation. Details: " + ex.Message);
			}
		}

		// Token: 0x0600586D RID: 22637 RVA: 0x0032E7E0 File Offset: 0x0032C9E0
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

		// Token: 0x0600586E RID: 22638 RVA: 0x0032E840 File Offset: 0x0032CA40
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

		// Token: 0x04002694 RID: 9876
		private string _cnn;

		// Token: 0x04002695 RID: 9877
		private int currentID;

		// Token: 0x04002696 RID: 9878
		private decimal currentCost;

		// Token: 0x04002697 RID: 9879
		private bool currentExpires;

		// Token: 0x04002698 RID: 9880
		private PublicFunctions pf;

		// Token: 0x04002699 RID: 9881
		private bool firstbalrun;
	}
}
