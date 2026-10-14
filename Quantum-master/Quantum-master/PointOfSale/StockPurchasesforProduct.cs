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
using Microsoft.Reporting.WinForms;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;
using PointOfSale.POSDataSetTableAdapters;

namespace PointOfSale
{
	// Token: 0x020001EF RID: 495
	[DesignerGenerated]
	public partial class StockPurchasesforProduct : Form
	{
		// Token: 0x06005753 RID: 22355 RVA: 0x00324094 File Offset: 0x00322294
		public StockPurchasesforProduct()
		{
			base.Load += this.StockPurchasesforProduct_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.currentid = 0;
			this.InitializeComponent();
		}

		// Token: 0x17001F66 RID: 8038
		// (get) Token: 0x06005756 RID: 22358 RVA: 0x00324DF7 File Offset: 0x00322FF7
		// (set) Token: 0x06005757 RID: 22359 RVA: 0x00324E01 File Offset: 0x00323001
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F67 RID: 8039
		// (get) Token: 0x06005758 RID: 22360 RVA: 0x00324E0A File Offset: 0x0032300A
		// (set) Token: 0x06005759 RID: 22361 RVA: 0x00324E14 File Offset: 0x00323014
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F68 RID: 8040
		// (get) Token: 0x0600575A RID: 22362 RVA: 0x00324E1D File Offset: 0x0032301D
		// (set) Token: 0x0600575B RID: 22363 RVA: 0x00324E28 File Offset: 0x00323028
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

		// Token: 0x17001F69 RID: 8041
		// (get) Token: 0x0600575C RID: 22364 RVA: 0x00324E6B File Offset: 0x0032306B
		// (set) Token: 0x0600575D RID: 22365 RVA: 0x00324E75 File Offset: 0x00323075
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F6A RID: 8042
		// (get) Token: 0x0600575E RID: 22366 RVA: 0x00324E7E File Offset: 0x0032307E
		// (set) Token: 0x0600575F RID: 22367 RVA: 0x00324E88 File Offset: 0x00323088
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

		// Token: 0x17001F6B RID: 8043
		// (get) Token: 0x06005760 RID: 22368 RVA: 0x00324ECB File Offset: 0x003230CB
		// (set) Token: 0x06005761 RID: 22369 RVA: 0x00324ED5 File Offset: 0x003230D5
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F6C RID: 8044
		// (get) Token: 0x06005762 RID: 22370 RVA: 0x00324EDE File Offset: 0x003230DE
		// (set) Token: 0x06005763 RID: 22371 RVA: 0x00324EE8 File Offset: 0x003230E8
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

		// Token: 0x17001F6D RID: 8045
		// (get) Token: 0x06005764 RID: 22372 RVA: 0x00324F46 File Offset: 0x00323146
		// (set) Token: 0x06005765 RID: 22373 RVA: 0x00324F50 File Offset: 0x00323150
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F6E RID: 8046
		// (get) Token: 0x06005766 RID: 22374 RVA: 0x00324F59 File Offset: 0x00323159
		// (set) Token: 0x06005767 RID: 22375 RVA: 0x00324F63 File Offset: 0x00323163
		internal virtual ComboBox cboBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F6F RID: 8047
		// (get) Token: 0x06005768 RID: 22376 RVA: 0x00324F6C File Offset: 0x0032316C
		// (set) Token: 0x06005769 RID: 22377 RVA: 0x00324F76 File Offset: 0x00323176
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F70 RID: 8048
		// (get) Token: 0x0600576A RID: 22378 RVA: 0x00324F7F File Offset: 0x0032317F
		// (set) Token: 0x0600576B RID: 22379 RVA: 0x00324F89 File Offset: 0x00323189
		internal virtual DateTimePicker DTEnddate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F71 RID: 8049
		// (get) Token: 0x0600576C RID: 22380 RVA: 0x00324F92 File Offset: 0x00323192
		// (set) Token: 0x0600576D RID: 22381 RVA: 0x00324F9C File Offset: 0x0032319C
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

		// Token: 0x17001F72 RID: 8050
		// (get) Token: 0x0600576E RID: 22382 RVA: 0x00324FDF File Offset: 0x003231DF
		// (set) Token: 0x0600576F RID: 22383 RVA: 0x00324FE9 File Offset: 0x003231E9
		internal virtual DateTimePicker DTStartdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F73 RID: 8051
		// (get) Token: 0x06005770 RID: 22384 RVA: 0x00324FF2 File Offset: 0x003231F2
		// (set) Token: 0x06005771 RID: 22385 RVA: 0x00324FFC File Offset: 0x003231FC
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F74 RID: 8052
		// (get) Token: 0x06005772 RID: 22386 RVA: 0x00325005 File Offset: 0x00323205
		// (set) Token: 0x06005773 RID: 22387 RVA: 0x0032500F File Offset: 0x0032320F
		internal virtual TextBox lblDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F75 RID: 8053
		// (get) Token: 0x06005774 RID: 22388 RVA: 0x00325018 File Offset: 0x00323218
		// (set) Token: 0x06005775 RID: 22389 RVA: 0x00325022 File Offset: 0x00323222
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F76 RID: 8054
		// (get) Token: 0x06005776 RID: 22390 RVA: 0x0032502B File Offset: 0x0032322B
		// (set) Token: 0x06005777 RID: 22391 RVA: 0x00325038 File Offset: 0x00323238
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

		// Token: 0x17001F77 RID: 8055
		// (get) Token: 0x06005778 RID: 22392 RVA: 0x0032507B File Offset: 0x0032327B
		// (set) Token: 0x06005779 RID: 22393 RVA: 0x00325085 File Offset: 0x00323285
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F78 RID: 8056
		// (get) Token: 0x0600577A RID: 22394 RVA: 0x0032508E File Offset: 0x0032328E
		// (set) Token: 0x0600577B RID: 22395 RVA: 0x00325098 File Offset: 0x00323298
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F79 RID: 8057
		// (get) Token: 0x0600577C RID: 22396 RVA: 0x003250A1 File Offset: 0x003232A1
		// (set) Token: 0x0600577D RID: 22397 RVA: 0x003250AB File Offset: 0x003232AB
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F7A RID: 8058
		// (get) Token: 0x0600577E RID: 22398 RVA: 0x003250B4 File Offset: 0x003232B4
		// (set) Token: 0x0600577F RID: 22399 RVA: 0x003250BE File Offset: 0x003232BE
		internal virtual BindingSource FetchStockPurchasesforProductBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F7B RID: 8059
		// (get) Token: 0x06005780 RID: 22400 RVA: 0x003250C7 File Offset: 0x003232C7
		// (set) Token: 0x06005781 RID: 22401 RVA: 0x003250D1 File Offset: 0x003232D1
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F7C RID: 8060
		// (get) Token: 0x06005782 RID: 22402 RVA: 0x003250DA File Offset: 0x003232DA
		// (set) Token: 0x06005783 RID: 22403 RVA: 0x003250E4 File Offset: 0x003232E4
		internal virtual FetchStockPurchasesforProductTableAdapter FetchStockPurchasesforProductTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06005784 RID: 22404 RVA: 0x003250F0 File Offset: 0x003232F0
		private void StockPurchasesforProduct_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadBranches();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Details: " + ex.Message);
			}
		}

		// Token: 0x06005785 RID: 22405 RVA: 0x00325140 File Offset: 0x00323340
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

		// Token: 0x06005786 RID: 22406 RVA: 0x003251C8 File Offset: 0x003233C8
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

		// Token: 0x06005787 RID: 22407 RVA: 0x003252C0 File Offset: 0x003234C0
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

		// Token: 0x06005788 RID: 22408 RVA: 0x00325348 File Offset: 0x00323548
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

		// Token: 0x06005789 RID: 22409 RVA: 0x00325454 File Offset: 0x00323654
		private object searchDat(DataTable dt, string column, string value)
		{
			StockPurchasesforProduct._Closure$__103-0 CS$<>8__locals1 = new StockPurchasesforProduct._Closure$__103-0(CS$<>8__locals1);
			CS$<>8__locals1.$VB$Local_column = column;
			CS$<>8__locals1.$VB$Local_value = value;
			DataTable dataTable = dt.Clone();
			dt.CaseSensitive = false;
			try
			{
				foreach (DataRow dataRow in dt.Rows.Cast<object>().Select<object, DataRow>((StockPurchasesforProduct._Closure$__.$I103-0 == null) ? (StockPurchasesforProduct._Closure$__.$I103-0 = (object row1) => (DataRow)row1) : StockPurchasesforProduct._Closure$__.$I103-0).Where<DataRow>((CS$<>8__locals1.$I1 == null) ? (CS$<>8__locals1.$I1 = (DataRow row1) => Conversions.ToBoolean(NewLateBinding.LateGet(row1[CS$<>8__locals1.$VB$Local_column], null, "Contains", new object[] { CS$<>8__locals1.$VB$Local_value.ToUpper() }, null, null, null))) : CS$<>8__locals1.$I1))
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

		// Token: 0x0600578A RID: 22410 RVA: 0x00325530 File Offset: 0x00323730
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

		// Token: 0x0600578B RID: 22411 RVA: 0x003255B8 File Offset: 0x003237B8
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
				this.GetCompanyDetailsTableAdapter.Connection = sqlConnection;
				this.FetchStockPurchasesforProductTableAdapter.Connection = sqlConnection;
				ReportParameter reportParameter = new ReportParameter("startdate", Conversions.ToString(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))));
				ReportParameter reportParameter2 = new ReportParameter("startdateDesc", this.DTStartdate.Value.ToShortDateString());
				ReportParameter reportParameter3 = new ReportParameter("enddate", Conversions.ToString(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))));
				ReportParameter reportParameter4 = new ReportParameter("enddateDesc", this.DTEnddate.Value.ToShortDateString());
				ReportParameter reportParameter5 = new ReportParameter("coid", Conversions.ToString(MyProject.Forms.Form1.coid));
				ReportParameter reportParameter6 = new ReportParameter("branch", this.cboBranch.Text);
				ReportParameter reportParameter7 = new ReportParameter("productdesc", this.lblDesc.Text);
				ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter2, reportParameter3, reportParameter4, reportParameter5, reportParameter6, reportParameter7 };
				this.ReportViewer1.LocalReport.SetParameters(array);
				this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
				this.FetchStockPurchasesforProductTableAdapter.Fill(this.POSDataSet.FetchStockPurchasesforProduct, new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text, new int?(Convert.ToInt32(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Convert.ToInt32(this.DTEnddate.Value.ToString("yyyyMMdd"))), new int?(this.currentid));
				this.ReportViewer1.RefreshReport();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying report. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600578C RID: 22412 RVA: 0x0032580C File Offset: 0x00323A0C
		private void ClearForm()
		{
			this.lblDesc.Text = "";
			this.currentid = 0;
			this.txtsearch.Focus();
		}

		// Token: 0x0600578D RID: 22413 RVA: 0x00325834 File Offset: 0x00323A34
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

		// Token: 0x0600578E RID: 22414 RVA: 0x00325894 File Offset: 0x00323A94
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

		// Token: 0x0600578F RID: 22415 RVA: 0x00325A6C File Offset: 0x00323C6C
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

		// Token: 0x06005790 RID: 22416 RVA: 0x00325B2C File Offset: 0x00323D2C
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

		// Token: 0x06005791 RID: 22417 RVA: 0x00325B94 File Offset: 0x00323D94
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
				this.currentid = Conversions.ToInteger(dataRow["ProductID"]);
			}
			else
			{
				this.lblDesc.Text = "Nothing found matching that product ID";
				this.ClearForm();
			}
		}

		// Token: 0x06005792 RID: 22418 RVA: 0x00325C74 File Offset: 0x00323E74
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
		}

		// Token: 0x04002635 RID: 9781
		private string _cnn;

		// Token: 0x04002636 RID: 9782
		private int currentid;
	}
}
