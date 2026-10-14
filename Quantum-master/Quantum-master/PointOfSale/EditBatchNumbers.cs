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
	// Token: 0x0200004B RID: 75
	[DesignerGenerated]
	public partial class EditBatchNumbers : Form
	{
		// Token: 0x06000FD8 RID: 4056 RVA: 0x00095C64 File Offset: 0x00093E64
		public EditBatchNumbers()
		{
			base.Load += this.EditBatchNumbers_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06000FDB RID: 4059 RVA: 0x00096736 File Offset: 0x00094936
		// (set) Token: 0x06000FDC RID: 4060 RVA: 0x00096740 File Offset: 0x00094940
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06000FDD RID: 4061 RVA: 0x00096749 File Offset: 0x00094949
		// (set) Token: 0x06000FDE RID: 4062 RVA: 0x00096753 File Offset: 0x00094953
		internal virtual Label lblproductcount
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06000FDF RID: 4063 RVA: 0x0009675C File Offset: 0x0009495C
		// (set) Token: 0x06000FE0 RID: 4064 RVA: 0x00096766 File Offset: 0x00094966
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06000FE1 RID: 4065 RVA: 0x0009676F File Offset: 0x0009496F
		// (set) Token: 0x06000FE2 RID: 4066 RVA: 0x0009677C File Offset: 0x0009497C
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

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06000FE3 RID: 4067 RVA: 0x000967DA File Offset: 0x000949DA
		// (set) Token: 0x06000FE4 RID: 4068 RVA: 0x000967E4 File Offset: 0x000949E4
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06000FE5 RID: 4069 RVA: 0x000967ED File Offset: 0x000949ED
		// (set) Token: 0x06000FE6 RID: 4070 RVA: 0x000967F8 File Offset: 0x000949F8
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

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06000FE7 RID: 4071 RVA: 0x0009683B File Offset: 0x00094A3B
		// (set) Token: 0x06000FE8 RID: 4072 RVA: 0x00096845 File Offset: 0x00094A45
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06000FE9 RID: 4073 RVA: 0x0009684E File Offset: 0x00094A4E
		// (set) Token: 0x06000FEA RID: 4074 RVA: 0x00096858 File Offset: 0x00094A58
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

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06000FEB RID: 4075 RVA: 0x0009689B File Offset: 0x00094A9B
		// (set) Token: 0x06000FEC RID: 4076 RVA: 0x000968A8 File Offset: 0x00094AA8
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
				EventHandler eventHandler2 = new EventHandler(this.txtProductCode_TextChanged_1);
				TextBox textBox = this._txtProductCode;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
					textBox.TextChanged -= eventHandler2;
				}
				this._txtProductCode = value;
				textBox = this._txtProductCode;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
					textBox.TextChanged += eventHandler2;
				}
			}
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06000FED RID: 4077 RVA: 0x00096906 File Offset: 0x00094B06
		// (set) Token: 0x06000FEE RID: 4078 RVA: 0x00096910 File Offset: 0x00094B10
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06000FEF RID: 4079 RVA: 0x00096919 File Offset: 0x00094B19
		// (set) Token: 0x06000FF0 RID: 4080 RVA: 0x00096923 File Offset: 0x00094B23
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06000FF1 RID: 4081 RVA: 0x0009692C File Offset: 0x00094B2C
		// (set) Token: 0x06000FF2 RID: 4082 RVA: 0x00096938 File Offset: 0x00094B38
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

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06000FF3 RID: 4083 RVA: 0x0009697B File Offset: 0x00094B7B
		// (set) Token: 0x06000FF4 RID: 4084 RVA: 0x00096985 File Offset: 0x00094B85
		internal virtual DateTimePicker DTdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06000FF5 RID: 4085 RVA: 0x0009698E File Offset: 0x00094B8E
		// (set) Token: 0x06000FF6 RID: 4086 RVA: 0x00096998 File Offset: 0x00094B98
		internal virtual DataGridView dgvProducts
		{
			[CompilerGenerated]
			get
			{
				return this._dgvProducts;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
				DataGridView dataGridView = this._dgvProducts;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick -= dataGridViewCellEventHandler;
				}
				this._dgvProducts = value;
				dataGridView = this._dgvProducts;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x06000FF7 RID: 4087 RVA: 0x000969DB File Offset: 0x00094BDB
		// (set) Token: 0x06000FF8 RID: 4088 RVA: 0x000969E5 File Offset: 0x00094BE5
		internal virtual ProgressBar ProgressBar1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06000FF9 RID: 4089 RVA: 0x000969EE File Offset: 0x00094BEE
		// (set) Token: 0x06000FFA RID: 4090 RVA: 0x000969F8 File Offset: 0x00094BF8
		internal virtual TextBox txtsearchproductcode
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06000FFB RID: 4091 RVA: 0x00096A04 File Offset: 0x00094C04
		private void EditBatchNumbers_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadLevels();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Details: " + ex.Message);
			}
		}

		// Token: 0x06000FFC RID: 4092 RVA: 0x00096A54 File Offset: 0x00094C54
		private void LoadLevels()
		{
			this.dgvProducts.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "CurrentStockLevelsWarehouse";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			this.dgvProducts.DataSource = dataTable;
			this.dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvProducts.Columns["ProductID"].HeaderText = "Product ID";
			this.dgvProducts.Columns["ProductID"].ReadOnly = true;
			this.dgvProducts.Columns["ProductID"].DefaultCellStyle.BackColor = Color.LightGray;
			this.dgvProducts.Columns["ProductDesc"].HeaderText = "Description";
			this.dgvProducts.Columns["ProductDesc"].ReadOnly = true;
			this.dgvProducts.Columns["ProductDesc"].DefaultCellStyle.BackColor = Color.LightGray;
			this.dgvProducts.Columns["BatchNumber"].HeaderText = "Batch Number";
			this.dgvProducts.Columns["BatchNumber"].ReadOnly = true;
			this.dgvProducts.Columns["BatchNumber"].DefaultCellStyle.BackColor = Color.LightGray;
			this.dgvProducts.Columns["ExpiryDate"].HeaderText = "Expiry Date";
			this.dgvProducts.Columns["ExpiryDate"].ReadOnly = true;
			this.dgvProducts.Columns["ExpiryDate"].DefaultCellStyle.BackColor = Color.LightGray;
			this.dgvProducts.Columns["bal"].HeaderText = "Current Balance";
			this.dgvProducts.Columns["bal"].ReadOnly = true;
			this.dgvProducts.Columns["bal"].DefaultCellStyle.BackColor = Color.LightGray;
			this.lblproductcount.Text = this.dgvProducts.RowCount.ToString();
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn.Name = "NewBatchNumber";
			dataGridViewTextBoxColumn.HeaderText = "NewBatchNumber";
			this.dgvProducts.Columns.Insert(3, dataGridViewTextBoxColumn);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn2.Name = "NewExpiryDate";
			dataGridViewTextBoxColumn2.HeaderText = "NewExpiryDate";
			this.dgvProducts.Columns.Insert(5, dataGridViewTextBoxColumn2);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn3.Name = "colvar";
			dataGridViewTextBoxColumn3.HeaderText = "Reason for Change";
			this.dgvProducts.Columns.Insert(7, dataGridViewTextBoxColumn3);
			this.CopyBatchNumbers();
		}

		// Token: 0x06000FFD RID: 4093 RVA: 0x00096DBC File Offset: 0x00094FBC
		private void CopyBatchNumbers()
		{
			try
			{
				foreach (object obj in ((IEnumerable)this.dgvProducts.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					dataGridViewRow.Cells[3].Value = RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["batchnumber"].Value);
					dataGridViewRow.Cells[5].Value = RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ExpiryDate"].Value);
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

		// Token: 0x06000FFE RID: 4094 RVA: 0x00096E74 File Offset: 0x00095074
		private void Button1_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = (DialogResult)Interaction.MsgBox("Are you sure you have entered the correct Physical Stock count figures and want to adjust stock?", MsgBoxStyle.YesNo, null);
			bool flag = dialogResult == DialogResult.Yes;
			checked
			{
				if (flag)
				{
					int num = 0;
					this.ProgressBar1.Visible = true;
					this.ProgressBar1.BringToFront();
					this.ProgressBar1.Minimum = 1;
					this.ProgressBar1.Maximum = 3;
					this.ProgressBar1.Step = 1;
					this.ProgressBar1.PerformStep();
					SqlConnection sqlConnection = new SqlConnection(this._cnn);
					SqlCommand sqlCommand = sqlConnection.CreateCommand();
					sqlConnection.Open();
					SqlTransaction sqlTransaction = sqlConnection.BeginTransaction("RunEditBatchNumber");
					sqlCommand.Connection = sqlConnection;
					sqlCommand.Transaction = sqlTransaction;
					try
					{
						this.ProgressBar1.PerformStep();
						int num2 = (int)Math.Round(Conversion.Val(DateAndTime.TimeOfDay.ToString("HHmm")));
						try
						{
							foreach (object obj in ((IEnumerable)this.dgvProducts.Rows))
							{
								DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
								string text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["BatchNumber"].Value)), "", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["BatchNumber"].Value)));
								string text2 = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[3].Value)), "", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[3].Value)));
								int num3 = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ExpiryDate"].Value)), 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ExpiryDate"].Value)));
								int num4 = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[5].Value)), 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[5].Value)));
								decimal num5 = Conversions.ToDecimal(dataGridViewRow.Cells["bal"].Value);
								bool flag2 = dataGridViewRow.Cells[7].Value == null;
								string text3;
								if (flag2)
								{
									text3 = "";
								}
								else
								{
									text3 = dataGridViewRow.Cells[7].Value.ToString();
								}
								bool flag3 = (Operators.CompareString(text, text2, false) != 0) | (num3 != num4);
								if (flag3)
								{
									num++;
									sqlCommand.Parameters.Clear();
									sqlCommand.CommandType = CommandType.StoredProcedure;
									sqlCommand.CommandText = "UpdateBatchNumberExpiryDate";
									sqlCommand.Parameters.AddWithValue("trandate", this.DTdate.Value.ToString("yyyyMMdd"));
									sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ProductID"].Value));
									sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
									sqlCommand.Parameters.AddWithValue("TranTime", num2);
									sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
									sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
									sqlCommand.Parameters.AddWithValue("oldbatchnumber", text);
									sqlCommand.Parameters.AddWithValue("newbatchnumber", text2);
									sqlCommand.Parameters.AddWithValue("oldexpirydate", num3);
									sqlCommand.Parameters.AddWithValue("newexpirydate", num4);
									sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
									sqlCommand.Parameters.AddWithValue("Reason", text3);
									sqlCommand.Parameters.AddWithValue("bal", num5);
									sqlCommand.ExecuteNonQuery();
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
						MessageBox.Show(num.ToString() + " stock items adjusted successfully. To view adjustments made please go to the reports.");
						this.LoadLevels();
					}
					catch (Exception ex)
					{
						sqlTransaction.Rollback();
						sqlCommand.Connection.Close();
						this.ProgressBar1.Visible = false;
						MessageBox.Show("Error occured adjusting stock. Detail: " + ex.Message);
					}
				}
			}
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x000973B4 File Offset: 0x000955B4
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

		// Token: 0x06001000 RID: 4096 RVA: 0x000974C0 File Offset: 0x000956C0
		private object searchDat(DataTable dt, string column, string value)
		{
			EditBatchNumbers._Closure$__75-0 CS$<>8__locals1 = new EditBatchNumbers._Closure$__75-0(CS$<>8__locals1);
			CS$<>8__locals1.$VB$Local_column = column;
			CS$<>8__locals1.$VB$Local_value = value;
			DataTable dataTable = dt.Clone();
			dt.CaseSensitive = false;
			try
			{
				foreach (DataRow dataRow in dt.Rows.Cast<object>().Select<object, DataRow>((EditBatchNumbers._Closure$__.$I75-0 == null) ? (EditBatchNumbers._Closure$__.$I75-0 = (object row1) => (DataRow)row1) : EditBatchNumbers._Closure$__.$I75-0).Where<DataRow>((CS$<>8__locals1.$I1 == null) ? (CS$<>8__locals1.$I1 = (DataRow row1) => Conversions.ToBoolean(NewLateBinding.LateGet(row1[CS$<>8__locals1.$VB$Local_column], null, "Contains", new object[] { CS$<>8__locals1.$VB$Local_value.ToUpper() }, null, null, null))) : CS$<>8__locals1.$I1))
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

		// Token: 0x06001001 RID: 4097 RVA: 0x0009759C File Offset: 0x0009579C
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

		// Token: 0x06001002 RID: 4098 RVA: 0x00097624 File Offset: 0x00095824
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

		// Token: 0x06001003 RID: 4099 RVA: 0x00002A30 File Offset: 0x00000C30
		private void txtProductCode_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06001004 RID: 4100 RVA: 0x00097684 File Offset: 0x00095884
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

		// Token: 0x06001005 RID: 4101 RVA: 0x00097744 File Offset: 0x00095944
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

		// Token: 0x06001006 RID: 4102 RVA: 0x000978E4 File Offset: 0x00095AE4
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

		// Token: 0x06001007 RID: 4103 RVA: 0x00097944 File Offset: 0x00095B44
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

		// Token: 0x06001008 RID: 4104 RVA: 0x00097A3C File Offset: 0x00095C3C
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

		// Token: 0x06001009 RID: 4105 RVA: 0x00097AA8 File Offset: 0x00095CA8
		private void txtProductCode_TextChanged_1(object sender, EventArgs e)
		{
			try
			{
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvProducts.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						bool flag = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["ProductCode"].Value, this.txtProductCode.Text, false);
						if (flag)
						{
							this.dgvProducts.ClearSelection();
							dataGridViewRow.Cells["ProductCode"].Selected = true;
							this.dgvProducts.CurrentCell = dataGridViewRow.Cells["ProductCode"];
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

		// Token: 0x0600100A RID: 4106 RVA: 0x00002A30 File Offset: 0x00000C30
		private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x040007A8 RID: 1960
		private string _cnn;

		// Token: 0x040007A9 RID: 1961
		private PublicFunctions pf;
	}
}
