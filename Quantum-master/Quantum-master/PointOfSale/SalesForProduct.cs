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
	// Token: 0x020001A3 RID: 419
	[DesignerGenerated]
	public partial class SalesForProduct : UserControl
	{
		// Token: 0x06004AE1 RID: 19169 RVA: 0x002CECBC File Offset: 0x002CCEBC
		public SalesForProduct()
		{
			base.Load += this.SalesForProduct_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x17001B62 RID: 7010
		// (get) Token: 0x06004AE4 RID: 19172 RVA: 0x002CFF91 File Offset: 0x002CE191
		// (set) Token: 0x06004AE5 RID: 19173 RVA: 0x002CFF9B File Offset: 0x002CE19B
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B63 RID: 7011
		// (get) Token: 0x06004AE6 RID: 19174 RVA: 0x002CFFA4 File Offset: 0x002CE1A4
		// (set) Token: 0x06004AE7 RID: 19175 RVA: 0x002CFFAE File Offset: 0x002CE1AE
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B64 RID: 7012
		// (get) Token: 0x06004AE8 RID: 19176 RVA: 0x002CFFB7 File Offset: 0x002CE1B7
		// (set) Token: 0x06004AE9 RID: 19177 RVA: 0x002CFFC1 File Offset: 0x002CE1C1
		internal virtual Panel Panel4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B65 RID: 7013
		// (get) Token: 0x06004AEA RID: 19178 RVA: 0x002CFFCA File Offset: 0x002CE1CA
		// (set) Token: 0x06004AEB RID: 19179 RVA: 0x002CFFD4 File Offset: 0x002CE1D4
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
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.DGVSearch_KeyDown);
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DGVSearch_CellEnter);
				DataGridView dataGridView = this._DGVSearch;
				if (dataGridView != null)
				{
					dataGridView.KeyDown -= keyEventHandler;
					dataGridView.CellEnter -= dataGridViewCellEventHandler;
				}
				this._DGVSearch = value;
				dataGridView = this._DGVSearch;
				if (dataGridView != null)
				{
					dataGridView.KeyDown += keyEventHandler;
					dataGridView.CellEnter += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x17001B66 RID: 7014
		// (get) Token: 0x06004AEC RID: 19180 RVA: 0x002D0032 File Offset: 0x002CE232
		// (set) Token: 0x06004AED RID: 19181 RVA: 0x002D003C File Offset: 0x002CE23C
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B67 RID: 7015
		// (get) Token: 0x06004AEE RID: 19182 RVA: 0x002D0045 File Offset: 0x002CE245
		// (set) Token: 0x06004AEF RID: 19183 RVA: 0x002D004F File Offset: 0x002CE24F
		internal virtual Label Label10
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B68 RID: 7016
		// (get) Token: 0x06004AF0 RID: 19184 RVA: 0x002D0058 File Offset: 0x002CE258
		// (set) Token: 0x06004AF1 RID: 19185 RVA: 0x002D0064 File Offset: 0x002CE264
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

		// Token: 0x17001B69 RID: 7017
		// (get) Token: 0x06004AF2 RID: 19186 RVA: 0x002D00A7 File Offset: 0x002CE2A7
		// (set) Token: 0x06004AF3 RID: 19187 RVA: 0x002D00B1 File Offset: 0x002CE2B1
		internal virtual Label Label16
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B6A RID: 7018
		// (get) Token: 0x06004AF4 RID: 19188 RVA: 0x002D00BA File Offset: 0x002CE2BA
		// (set) Token: 0x06004AF5 RID: 19189 RVA: 0x002D00C4 File Offset: 0x002CE2C4
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

		// Token: 0x17001B6B RID: 7019
		// (get) Token: 0x06004AF6 RID: 19190 RVA: 0x002D0107 File Offset: 0x002CE307
		// (set) Token: 0x06004AF7 RID: 19191 RVA: 0x002D0111 File Offset: 0x002CE311
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B6C RID: 7020
		// (get) Token: 0x06004AF8 RID: 19192 RVA: 0x002D011A File Offset: 0x002CE31A
		// (set) Token: 0x06004AF9 RID: 19193 RVA: 0x002D0124 File Offset: 0x002CE324
		internal virtual ComboBox cboBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B6D RID: 7021
		// (get) Token: 0x06004AFA RID: 19194 RVA: 0x002D012D File Offset: 0x002CE32D
		// (set) Token: 0x06004AFB RID: 19195 RVA: 0x002D0137 File Offset: 0x002CE337
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B6E RID: 7022
		// (get) Token: 0x06004AFC RID: 19196 RVA: 0x002D0140 File Offset: 0x002CE340
		// (set) Token: 0x06004AFD RID: 19197 RVA: 0x002D014A File Offset: 0x002CE34A
		internal virtual DateTimePicker DTEndDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B6F RID: 7023
		// (get) Token: 0x06004AFE RID: 19198 RVA: 0x002D0153 File Offset: 0x002CE353
		// (set) Token: 0x06004AFF RID: 19199 RVA: 0x002D015D File Offset: 0x002CE35D
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B70 RID: 7024
		// (get) Token: 0x06004B00 RID: 19200 RVA: 0x002D0166 File Offset: 0x002CE366
		// (set) Token: 0x06004B01 RID: 19201 RVA: 0x002D0170 File Offset: 0x002CE370
		internal virtual DateTimePicker DTStartDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B71 RID: 7025
		// (get) Token: 0x06004B02 RID: 19202 RVA: 0x002D0179 File Offset: 0x002CE379
		// (set) Token: 0x06004B03 RID: 19203 RVA: 0x002D0183 File Offset: 0x002CE383
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B72 RID: 7026
		// (get) Token: 0x06004B04 RID: 19204 RVA: 0x002D018C File Offset: 0x002CE38C
		// (set) Token: 0x06004B05 RID: 19205 RVA: 0x002D0196 File Offset: 0x002CE396
		internal virtual TextBox lblDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B73 RID: 7027
		// (get) Token: 0x06004B06 RID: 19206 RVA: 0x002D019F File Offset: 0x002CE39F
		// (set) Token: 0x06004B07 RID: 19207 RVA: 0x002D01AC File Offset: 0x002CE3AC
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

		// Token: 0x17001B74 RID: 7028
		// (get) Token: 0x06004B08 RID: 19208 RVA: 0x002D01EF File Offset: 0x002CE3EF
		// (set) Token: 0x06004B09 RID: 19209 RVA: 0x002D01FC File Offset: 0x002CE3FC
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

		// Token: 0x17001B75 RID: 7029
		// (get) Token: 0x06004B0A RID: 19210 RVA: 0x002D023F File Offset: 0x002CE43F
		// (set) Token: 0x06004B0B RID: 19211 RVA: 0x002D0249 File Offset: 0x002CE449
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B76 RID: 7030
		// (get) Token: 0x06004B0C RID: 19212 RVA: 0x002D0252 File Offset: 0x002CE452
		// (set) Token: 0x06004B0D RID: 19213 RVA: 0x002D025C File Offset: 0x002CE45C
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B77 RID: 7031
		// (get) Token: 0x06004B0E RID: 19214 RVA: 0x002D0265 File Offset: 0x002CE465
		// (set) Token: 0x06004B0F RID: 19215 RVA: 0x002D026F File Offset: 0x002CE46F
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B78 RID: 7032
		// (get) Token: 0x06004B10 RID: 19216 RVA: 0x002D0278 File Offset: 0x002CE478
		// (set) Token: 0x06004B11 RID: 19217 RVA: 0x002D0282 File Offset: 0x002CE482
		internal virtual BindingSource SalesForProductBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B79 RID: 7033
		// (get) Token: 0x06004B12 RID: 19218 RVA: 0x002D028B File Offset: 0x002CE48B
		// (set) Token: 0x06004B13 RID: 19219 RVA: 0x002D0295 File Offset: 0x002CE495
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B7A RID: 7034
		// (get) Token: 0x06004B14 RID: 19220 RVA: 0x002D029E File Offset: 0x002CE49E
		// (set) Token: 0x06004B15 RID: 19221 RVA: 0x002D02A8 File Offset: 0x002CE4A8
		internal virtual SalesForProductTableAdapter SalesForProductTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B7B RID: 7035
		// (get) Token: 0x06004B16 RID: 19222 RVA: 0x002D02B1 File Offset: 0x002CE4B1
		// (set) Token: 0x06004B17 RID: 19223 RVA: 0x002D02BC File Offset: 0x002CE4BC
		internal virtual Label Label4
		{
			[CompilerGenerated]
			get
			{
				return this._Label4;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label4_Click);
				Label label = this._Label4;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label4 = value;
				label = this._Label4;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x17001B7C RID: 7036
		// (get) Token: 0x06004B18 RID: 19224 RVA: 0x002D02FF File Offset: 0x002CE4FF
		// (set) Token: 0x06004B19 RID: 19225 RVA: 0x002D0309 File Offset: 0x002CE509
		internal virtual ComboBox cboExpDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B7D RID: 7037
		// (get) Token: 0x06004B1A RID: 19226 RVA: 0x002D0312 File Offset: 0x002CE512
		// (set) Token: 0x06004B1B RID: 19227 RVA: 0x002D031C File Offset: 0x002CE51C
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B7E RID: 7038
		// (get) Token: 0x06004B1C RID: 19228 RVA: 0x002D0325 File Offset: 0x002CE525
		// (set) Token: 0x06004B1D RID: 19229 RVA: 0x002D0330 File Offset: 0x002CE530
		internal virtual ComboBox cboBatchNum
		{
			[CompilerGenerated]
			get
			{
				return this._cboBatchNum;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cboBatchNum_SelectedIndexChanged);
				ComboBox comboBox = this._cboBatchNum;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= eventHandler;
				}
				this._cboBatchNum = value;
				comboBox = this._cboBatchNum;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17001B7F RID: 7039
		// (get) Token: 0x06004B1E RID: 19230 RVA: 0x002D0373 File Offset: 0x002CE573
		// (set) Token: 0x06004B1F RID: 19231 RVA: 0x002D037D File Offset: 0x002CE57D
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06004B20 RID: 19232 RVA: 0x002D0388 File Offset: 0x002CE588
		private void SearchBarCode(int barcode)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SearchProductBarCode";
			sqlCommand.Parameters.AddWithValue("barcode", barcode);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				this.txtSearchProductCode.Text = Conversions.ToString(dataRow["ProductCode"]);
			}
			else
			{
				this.txtSearchProductCode.Text = Conversions.ToString(0);
			}
		}

		// Token: 0x06004B21 RID: 19233 RVA: 0x002D045C File Offset: 0x002CE65C
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

		// Token: 0x06004B22 RID: 19234 RVA: 0x002D04BC File Offset: 0x002CE6BC
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

		// Token: 0x06004B23 RID: 19235 RVA: 0x002D0694 File Offset: 0x002CE894
		private void DGVSearch_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				bool flag = (e.KeyCode == Keys.Return) | (e.KeyCode == Keys.Tab);
				if (flag)
				{
					this.Button1.Focus();
					e.Handled = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Key down error. Ignore");
			}
		}

		// Token: 0x06004B24 RID: 19236 RVA: 0x002D0700 File Offset: 0x002CE900
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

		// Token: 0x06004B25 RID: 19237 RVA: 0x002D07C0 File Offset: 0x002CE9C0
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

		// Token: 0x06004B26 RID: 19238 RVA: 0x002D0848 File Offset: 0x002CEA48
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

		// Token: 0x06004B27 RID: 19239 RVA: 0x002D0954 File Offset: 0x002CEB54
		private object searchDat(DataTable dt, string column, string value)
		{
			SalesForProduct._Closure$__134-0 CS$<>8__locals1 = new SalesForProduct._Closure$__134-0(CS$<>8__locals1);
			CS$<>8__locals1.$VB$Local_column = column;
			CS$<>8__locals1.$VB$Local_value = value;
			DataTable dataTable = dt.Clone();
			dt.CaseSensitive = false;
			try
			{
				foreach (DataRow dataRow in dt.Rows.Cast<object>().Select<object, DataRow>((SalesForProduct._Closure$__.$I134-0 == null) ? (SalesForProduct._Closure$__.$I134-0 = (object row1) => (DataRow)row1) : SalesForProduct._Closure$__.$I134-0).Where<DataRow>((CS$<>8__locals1.$I1 == null) ? (CS$<>8__locals1.$I1 = (DataRow row1) => Conversions.ToBoolean(NewLateBinding.LateGet(row1[CS$<>8__locals1.$VB$Local_column], null, "Contains", new object[] { CS$<>8__locals1.$VB$Local_value.ToUpper() }, null, null, null))) : CS$<>8__locals1.$I1))
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

		// Token: 0x06004B28 RID: 19240 RVA: 0x002D0A30 File Offset: 0x002CEC30
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

		// Token: 0x06004B29 RID: 19241 RVA: 0x002D0AB8 File Offset: 0x002CECB8
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

		// Token: 0x06004B2A RID: 19242 RVA: 0x002D0BB0 File Offset: 0x002CEDB0
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
			this.cboBranch.SelectedIndex = this.cboBranch.FindStringExact(MyProject.Forms.Form1.branch);
		}

		// Token: 0x06004B2B RID: 19243 RVA: 0x002D0C78 File Offset: 0x002CEE78
		private void SalesForProduct_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadBranches();
				bool flag = MyProject.Forms.Form1.IsWarehouse == 1;
				if (flag)
				{
					this.cboBatchNum.Visible = true;
					this.cboExpDate.Visible = true;
					this.Label5.Visible = true;
					this.Label6.Visible = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06004B2C RID: 19244 RVA: 0x002D0D14 File Offset: 0x002CEF14
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				Cursor.Current = Cursors.WaitCursor;
				SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
				this.GetCompanyDetailsTableAdapter.Connection = sqlConnection;
				this.SalesForProductTableAdapter.Connection = sqlConnection;
				ReportParameter reportParameter = new ReportParameter("shiftdateStart", Conversions.ToString(Conversions.ToInteger(this.DTStartDate.Value.ToString("yyyyMMdd"))));
				ReportParameter reportParameter2 = new ReportParameter("shiftdateEnd", Conversions.ToString(Conversions.ToInteger(this.DTEndDate.Value.ToString("yyyyMMdd"))));
				ReportParameter reportParameter3 = new ReportParameter("shiftdateStartDesc", this.DTStartDate.Value.ToShortDateString());
				ReportParameter reportParameter4 = new ReportParameter("shiftdateEndDesc", this.DTEndDate.Value.ToShortDateString());
				ReportParameter reportParameter5 = new ReportParameter("branch", this.cboBranch.Text);
				ReportParameter reportParameter6 = new ReportParameter("ProductDesc", string.Concat(new string[]
				{
					this.lblDesc.Text,
					". Batch Num: ",
					this.cboBatchNum.Text,
					" Expiry Date: ",
					this.cboExpDate.Text
				}));
				ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter2, reportParameter3, reportParameter4, reportParameter5, reportParameter6 };
				this.ReportViewer1.LocalReport.SetParameters(array);
				this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
				bool flag = Operators.CompareString(this.cboExpDate.Text, "", false) == 0;
				int num;
				if (flag)
				{
					num = 0;
				}
				else
				{
					num = Conversions.ToInteger(this.cboExpDate.Text);
				}
				this.SalesForProductTableAdapter.Fill(this.POSDataSet.SalesForProduct, new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text, new int?(Conversions.ToInteger(this.DTStartDate.Value.ToString("yyyyMMdd"))), new int?(Conversions.ToInteger(this.DTEndDate.Value.ToString("yyyyMMdd"))), new int?(this.CurrentID), new int?(MyProject.Forms.Form1.IsWarehouse), this.cboBatchNum.Text, new int?(num));
				this.ReportViewer1.RefreshReport();
				Cursor.Current = Cursors.Default;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying report. Detail: " + ex.Message);
			}
		}

		// Token: 0x06004B2D RID: 19245 RVA: 0x002D0FF0 File Offset: 0x002CF1F0
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

		// Token: 0x06004B2E RID: 19246 RVA: 0x002D1058 File Offset: 0x002CF258
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
				this.CurrentID = Conversions.ToInteger(dataRow["ProductID"]);
				bool flag2 = MyProject.Forms.Form1.IsWarehouse == 1;
				if (flag2)
				{
					this.LoadBatches();
				}
			}
			else
			{
				this.lblDesc.Text = "Nothing found matching that product ID";
			}
		}

		// Token: 0x06004B2F RID: 19247 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label4_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06004B30 RID: 19248 RVA: 0x002D1150 File Offset: 0x002CF350
		private void cboBatchNum_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.cboExpDate.DataSource = this.pf.ExpiryDatesForBatch(MyProject.Forms.Form1.coid, this.cboBranch.Text, this.CurrentID, Conversions.ToInteger(this.DTStartDate.Value.ToString("yyyyMMdd")), Conversions.ToInteger(this.DTEndDate.Value.ToString("yyyyMMdd")), this._cnn, this.cboBatchNum.Text);
				this.cboExpDate.DisplayMember = "ExpiryDate";
				this.cboExpDate.ValueMember = "ExpiryDate";
				this.cboExpDate.SelectedIndex = -1;
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06004B31 RID: 19249 RVA: 0x00002A30 File Offset: 0x00000C30
		private void cboExpDate_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06004B32 RID: 19250 RVA: 0x002D1234 File Offset: 0x002CF434
		private void LoadBatches()
		{
			try
			{
				this.cboBatchNum.DataSource = this.pf.BatchNumbersForProduct(MyProject.Forms.Form1.coid, this.cboBranch.Text, this.CurrentID, Conversions.ToInteger(this.DTStartDate.Value.ToString("yyyyMMdd")), Conversions.ToInteger(this.DTEndDate.Value.ToString("yyyyMMdd")), this._cnn);
				this.cboBatchNum.ValueMember = "BatchNumber";
				this.cboBatchNum.DisplayMember = "BatchNumber";
				this.cboBatchNum.SelectedIndex = -1;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading batches. Detail: " + ex.Message);
			}
		}

		// Token: 0x040020F7 RID: 8439
		private string _cnn;

		// Token: 0x040020F8 RID: 8440
		private int CurrentID;

		// Token: 0x040020F9 RID: 8441
		private PublicFunctions pf;
	}
}
