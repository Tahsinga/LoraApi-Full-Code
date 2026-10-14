using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;

namespace PointOfSale
{
	// Token: 0x0200001E RID: 30
	[DesignerGenerated]
	public partial class ChangeExpiryDate : Form
	{
		// Token: 0x0600055E RID: 1374 RVA: 0x00035320 File Offset: 0x00033520
		public ChangeExpiryDate()
		{
			base.Load += this.ChangeExpiryDate_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000561 RID: 1377 RVA: 0x00036420 File Offset: 0x00034620
		// (set) Token: 0x06000562 RID: 1378 RVA: 0x0003642A File Offset: 0x0003462A
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000563 RID: 1379 RVA: 0x00036433 File Offset: 0x00034633
		// (set) Token: 0x06000564 RID: 1380 RVA: 0x00036440 File Offset: 0x00034640
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

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000565 RID: 1381 RVA: 0x00036483 File Offset: 0x00034683
		// (set) Token: 0x06000566 RID: 1382 RVA: 0x0003648D File Offset: 0x0003468D
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000567 RID: 1383 RVA: 0x00036496 File Offset: 0x00034696
		// (set) Token: 0x06000568 RID: 1384 RVA: 0x000364A0 File Offset: 0x000346A0
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

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000569 RID: 1385 RVA: 0x000364FE File Offset: 0x000346FE
		// (set) Token: 0x0600056A RID: 1386 RVA: 0x00036508 File Offset: 0x00034708
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x0600056B RID: 1387 RVA: 0x00036511 File Offset: 0x00034711
		// (set) Token: 0x0600056C RID: 1388 RVA: 0x0003651C File Offset: 0x0003471C
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

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x0600056D RID: 1389 RVA: 0x0003655F File Offset: 0x0003475F
		// (set) Token: 0x0600056E RID: 1390 RVA: 0x00036569 File Offset: 0x00034769
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x0600056F RID: 1391 RVA: 0x00036572 File Offset: 0x00034772
		// (set) Token: 0x06000570 RID: 1392 RVA: 0x0003657C File Offset: 0x0003477C
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

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000571 RID: 1393 RVA: 0x000365DA File Offset: 0x000347DA
		// (set) Token: 0x06000572 RID: 1394 RVA: 0x000365E4 File Offset: 0x000347E4
		internal virtual DataGridView dgvWarehouse
		{
			[CompilerGenerated]
			get
			{
				return this._dgvWarehouse;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgvWarehouse_CellEnter);
				DataGridView dataGridView = this._dgvWarehouse;
				if (dataGridView != null)
				{
					dataGridView.CellEnter -= dataGridViewCellEventHandler;
				}
				this._dgvWarehouse = value;
				dataGridView = this._dgvWarehouse;
				if (dataGridView != null)
				{
					dataGridView.CellEnter += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000573 RID: 1395 RVA: 0x00036627 File Offset: 0x00034827
		// (set) Token: 0x06000574 RID: 1396 RVA: 0x00036631 File Offset: 0x00034831
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000575 RID: 1397 RVA: 0x0003663A File Offset: 0x0003483A
		// (set) Token: 0x06000576 RID: 1398 RVA: 0x00036644 File Offset: 0x00034844
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000577 RID: 1399 RVA: 0x0003664D File Offset: 0x0003484D
		// (set) Token: 0x06000578 RID: 1400 RVA: 0x00036658 File Offset: 0x00034858
		internal virtual ComboBox cboBranchFrom
		{
			[CompilerGenerated]
			get
			{
				return this._cboBranchFrom;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cboBranchFrom_SelectedIndexChanged);
				ComboBox comboBox = this._cboBranchFrom;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= eventHandler;
				}
				this._cboBranchFrom = value;
				comboBox = this._cboBranchFrom;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000579 RID: 1401 RVA: 0x0003669B File Offset: 0x0003489B
		// (set) Token: 0x0600057A RID: 1402 RVA: 0x000366A5 File Offset: 0x000348A5
		internal virtual Label lblDisplay
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x0600057B RID: 1403 RVA: 0x000366AE File Offset: 0x000348AE
		// (set) Token: 0x0600057C RID: 1404 RVA: 0x000366B8 File Offset: 0x000348B8
		internal virtual TextBox txtDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x0600057D RID: 1405 RVA: 0x000366C1 File Offset: 0x000348C1
		// (set) Token: 0x0600057E RID: 1406 RVA: 0x000366CB File Offset: 0x000348CB
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x0600057F RID: 1407 RVA: 0x000366D4 File Offset: 0x000348D4
		// (set) Token: 0x06000580 RID: 1408 RVA: 0x000366DE File Offset: 0x000348DE
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000581 RID: 1409 RVA: 0x000366E7 File Offset: 0x000348E7
		// (set) Token: 0x06000582 RID: 1410 RVA: 0x000366F4 File Offset: 0x000348F4
		internal virtual DateTimePicker DTNewExpiryDate
		{
			[CompilerGenerated]
			get
			{
				return this._DTNewExpiryDate;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.DTNewExpiryDate_ValueChanged);
				DateTimePicker dateTimePicker = this._DTNewExpiryDate;
				if (dateTimePicker != null)
				{
					dateTimePicker.ValueChanged -= eventHandler;
				}
				this._DTNewExpiryDate = value;
				dateTimePicker = this._DTNewExpiryDate;
				if (dateTimePicker != null)
				{
					dateTimePicker.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000583 RID: 1411 RVA: 0x00036737 File Offset: 0x00034937
		// (set) Token: 0x06000584 RID: 1412 RVA: 0x00036741 File Offset: 0x00034941
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000585 RID: 1413 RVA: 0x0003674A File Offset: 0x0003494A
		// (set) Token: 0x06000586 RID: 1414 RVA: 0x00036754 File Offset: 0x00034954
		internal virtual DateTimePicker DTCurrentExpDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000587 RID: 1415 RVA: 0x0003675D File Offset: 0x0003495D
		// (set) Token: 0x06000588 RID: 1416 RVA: 0x00036767 File Offset: 0x00034967
		internal virtual TextBox txtNewBatchNumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000589 RID: 1417 RVA: 0x00036770 File Offset: 0x00034970
		// (set) Token: 0x0600058A RID: 1418 RVA: 0x0003677A File Offset: 0x0003497A
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x0600058B RID: 1419 RVA: 0x00036783 File Offset: 0x00034983
		// (set) Token: 0x0600058C RID: 1420 RVA: 0x0003678D File Offset: 0x0003498D
		internal virtual TextBox txtCurrentBatchNumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x0600058D RID: 1421 RVA: 0x00036796 File Offset: 0x00034996
		// (set) Token: 0x0600058E RID: 1422 RVA: 0x000367A0 File Offset: 0x000349A0
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x0600058F RID: 1423 RVA: 0x000367A9 File Offset: 0x000349A9
		// (set) Token: 0x06000590 RID: 1424 RVA: 0x000367B4 File Offset: 0x000349B4
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

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x000367F7 File Offset: 0x000349F7
		// (set) Token: 0x06000592 RID: 1426 RVA: 0x00036801 File Offset: 0x00034A01
		internal virtual TextBox txtProductID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x0003680C File Offset: 0x00034A0C
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

		// Token: 0x06000594 RID: 1428 RVA: 0x0003686C File Offset: 0x00034A6C
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

		// Token: 0x06000595 RID: 1429 RVA: 0x000368F4 File Offset: 0x00034AF4
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

		// Token: 0x06000596 RID: 1430 RVA: 0x000369EC File Offset: 0x00034BEC
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

		// Token: 0x06000597 RID: 1431 RVA: 0x00036B8C File Offset: 0x00034D8C
		private void txtProductCode_TextChanged(object sender, EventArgs e)
		{
			try
			{
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvWarehouse.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						bool flag = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["ProductCode"].Value, this.txtProductCode.Text, false);
						if (flag)
						{
							this.dgvWarehouse.ClearSelection();
							dataGridViewRow.Cells["ProductCode"].Selected = true;
							this.dgvWarehouse.CurrentCell = dataGridViewRow.Cells["ProductCode"];
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

		// Token: 0x06000598 RID: 1432 RVA: 0x00036C88 File Offset: 0x00034E88
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

		// Token: 0x06000599 RID: 1433 RVA: 0x00036D48 File Offset: 0x00034F48
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

		// Token: 0x0600059A RID: 1434 RVA: 0x00036DA8 File Offset: 0x00034FA8
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

		// Token: 0x0600059B RID: 1435 RVA: 0x00036E30 File Offset: 0x00035030
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

		// Token: 0x0600059C RID: 1436 RVA: 0x00036F3C File Offset: 0x0003513C
		private object searchDat(DataTable dt, string column, string value)
		{
			ChangeExpiryDate._Closure$__114-0 CS$<>8__locals1 = new ChangeExpiryDate._Closure$__114-0(CS$<>8__locals1);
			CS$<>8__locals1.$VB$Local_column = column;
			CS$<>8__locals1.$VB$Local_value = value;
			DataTable dataTable = dt.Clone();
			dt.CaseSensitive = false;
			try
			{
				foreach (DataRow dataRow in dt.Rows.Cast<object>().Select<object, DataRow>((ChangeExpiryDate._Closure$__.$I114-0 == null) ? (ChangeExpiryDate._Closure$__.$I114-0 = (object row1) => (DataRow)row1) : ChangeExpiryDate._Closure$__.$I114-0).Where<DataRow>((CS$<>8__locals1.$I1 == null) ? (CS$<>8__locals1.$I1 = (DataRow row1) => Conversions.ToBoolean(NewLateBinding.LateGet(row1[CS$<>8__locals1.$VB$Local_column], null, "Contains", new object[] { CS$<>8__locals1.$VB$Local_value.ToUpper() }, null, null, null))) : CS$<>8__locals1.$I1))
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

		// Token: 0x0600059D RID: 1437 RVA: 0x00037018 File Offset: 0x00035218
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

		// Token: 0x0600059E RID: 1438 RVA: 0x000370A0 File Offset: 0x000352A0
		private void ChangeExpiryDate_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadBranches();
				this.LoadStocks(this.cboBranchFrom.Text);
				this.DTNewExpiryDate.Format = DateTimePickerFormat.Custom;
				this.DTNewExpiryDate.CustomFormat = " ";
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00037120 File Offset: 0x00035320
		private void LoadStocks(string branch)
		{
			this.dgvWarehouse.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "CurrentStockLevelsWarehouse";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			this.dgvWarehouse.DataSource = dataTable;
			this.dgvWarehouse.Columns["ProductID"].Visible = false;
			this.dgvWarehouse.Columns["productdesc"].HeaderText = "Product Description";
			this.dgvWarehouse.Columns["productcode"].HeaderText = "Product Code";
			this.dgvWarehouse.Columns["BatchNumber"].HeaderText = "Batch Number";
			this.dgvWarehouse.Columns["ExpiryDate"].HeaderText = "Expiry Date yyyyMMdd";
			this.dgvWarehouse.Columns["bal"].HeaderText = "Stock Balance";
			this.dgvWarehouse.Columns["ProductExpires"].HeaderText = "Does Product Expire?";
			this.dgvWarehouse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.lblDisplay.Text = "Showing stocks for branch: " + branch;
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x000372C0 File Offset: 0x000354C0
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
			this.cboBranchFrom.DataSource = dataTable;
			this.cboBranchFrom.ValueMember = "branch";
			this.cboBranchFrom.DisplayMember = "branch";
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x00037360 File Offset: 0x00035560
		private void cboBranchFrom_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.LoadStocks(this.cboBranchFrom.Text);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x000373A4 File Offset: 0x000355A4
		private void dgvWarehouse_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				this.txtCurrentBatchNumber.Text = this.dgvWarehouse.Rows[e.RowIndex].Cells["batchnumber"].Value.ToString();
				this.txtDesc.Text = this.dgvWarehouse.Rows[e.RowIndex].Cells["ProductDesc"].Value.ToString();
				this.txtProductID.Text = this.dgvWarehouse.Rows[e.RowIndex].Cells["productid"].Value.ToString();
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
				string text = this.dgvWarehouse.Rows[e.RowIndex].Cells["ExpiryDate"].Value.ToString();
				string text2 = "yyyyMMdd";
				try
				{
					DateTime dateTime = DateTime.ParseExact(text, text2, invariantCulture);
					this.DTCurrentExpDate.Value = dateTime;
				}
				catch (FormatException ex)
				{
				}
			}
			catch (Exception ex2)
			{
				MessageBox.Show("Error cell enter datagridview. Detail: " + ex2.Message);
			}
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x00037528 File Offset: 0x00035728
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = (Operators.CompareString(this.DTNewExpiryDate.Text, "", false) != 0) & (Operators.CompareString(this.txtNewBatchNumber.Text, "", false) != 0);
				if (flag)
				{
					DialogResult dialogResult = (DialogResult)Interaction.MsgBox("Are you sure you want to update this expiry date and batch number?", MsgBoxStyle.YesNo, null);
					bool flag2 = dialogResult == DialogResult.Yes;
					if (flag2)
					{
						this.UpdateExpiryDate(MyProject.Forms.Form1.coid, Convert.ToInt32(this.txtProductID.Text), MyProject.Forms.Form1.username, DateTime.Now, Environment.MachineName, this.txtCurrentBatchNumber.Text, this.txtNewBatchNumber.Text, Convert.ToInt32(this.DTNewExpiryDate.Value.ToString("yyyyMMdd")), Convert.ToInt32(this.DTCurrentExpDate.Value.ToString("yyyyMMdd")));
						this.LoadStocks(this.cboBranchFrom.Text);
						this.ClearForm();
					}
				}
				else
				{
					MessageBox.Show("Please ensure that the updated expiry date and batch numbers are entered first.");
					this.DTNewExpiryDate.Focus();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error updating batch and expiry details. Detail: " + ex.Message);
			}
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x00037698 File Offset: 0x00035898
		private void ClearForm()
		{
			this.txtCurrentBatchNumber.Text = "";
			this.txtNewBatchNumber.Text = "";
			this.txtProductID.Text = "";
			this.DTNewExpiryDate.Format = DateTimePickerFormat.Custom;
			this.DTNewExpiryDate.CustomFormat = " ";
			this.txtsearch.Focus();
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x00037704 File Offset: 0x00035904
		private void UpdateExpiryDate(int coid, int productid, string doneby, DateTime donewhen, string machinename, string oldbatchnumber, string batchnumber, int expirydate, int oldexpirydate)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "UpdateExpiryDate";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("productid", productid);
			sqlCommand.Parameters.AddWithValue("oldbatchnumber", oldbatchnumber);
			sqlCommand.Parameters.AddWithValue("batchnumber", batchnumber);
			sqlCommand.Parameters.AddWithValue("oldexpirydate", oldexpirydate);
			sqlCommand.Parameters.AddWithValue("expirydate", expirydate);
			sqlCommand.Parameters.AddWithValue("donewhen", donewhen);
			sqlCommand.Parameters.AddWithValue("doneby", doneby);
			sqlCommand.Parameters.AddWithValue("machinename", machinename);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00037830 File Offset: 0x00035A30
		private void DTNewExpiryDate_ValueChanged(object sender, EventArgs e)
		{
			try
			{
				this.DTNewExpiryDate.Format = DateTimePickerFormat.Long;
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x04000287 RID: 647
		private string _cnn;
	}
}
