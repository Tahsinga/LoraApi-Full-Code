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
	// Token: 0x02000049 RID: 73
	[DesignerGenerated]
	public partial class eltratefiscaldevice : Form
	{
		// Token: 0x06000F9C RID: 3996 RVA: 0x00093104 File Offset: 0x00091304
		public eltratefiscaldevice()
		{
			base.Load += this.EditBarCodes_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.dat = new DataTable();
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06000F9F RID: 3999 RVA: 0x000939A9 File Offset: 0x00091BA9
		// (set) Token: 0x06000FA0 RID: 4000 RVA: 0x000939B3 File Offset: 0x00091BB3
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06000FA1 RID: 4001 RVA: 0x000939BC File Offset: 0x00091BBC
		// (set) Token: 0x06000FA2 RID: 4002 RVA: 0x000939C8 File Offset: 0x00091BC8
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

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x06000FA3 RID: 4003 RVA: 0x00093A0B File Offset: 0x00091C0B
		// (set) Token: 0x06000FA4 RID: 4004 RVA: 0x00093A18 File Offset: 0x00091C18
		internal virtual TextBox txtSearchProducts
		{
			[CompilerGenerated]
			get
			{
				return this._txtSearchProducts;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.TextBox1_TextChanged);
				TextBox textBox = this._txtSearchProducts;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
				}
				this._txtSearchProducts = value;
				textBox = this._txtSearchProducts;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06000FA5 RID: 4005 RVA: 0x00093A5B File Offset: 0x00091C5B
		// (set) Token: 0x06000FA6 RID: 4006 RVA: 0x00093A65 File Offset: 0x00091C65
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06000FA7 RID: 4007 RVA: 0x00093A6E File Offset: 0x00091C6E
		// (set) Token: 0x06000FA8 RID: 4008 RVA: 0x00093A78 File Offset: 0x00091C78
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06000FA9 RID: 4009 RVA: 0x00093A81 File Offset: 0x00091C81
		// (set) Token: 0x06000FAA RID: 4010 RVA: 0x00093A8C File Offset: 0x00091C8C
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

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06000FAB RID: 4011 RVA: 0x00093ACF File Offset: 0x00091CCF
		// (set) Token: 0x06000FAC RID: 4012 RVA: 0x00093AD9 File Offset: 0x00091CD9
		internal virtual ProgressBar ProgressBar1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06000FAD RID: 4013 RVA: 0x00093AE2 File Offset: 0x00091CE2
		// (set) Token: 0x06000FAE RID: 4014 RVA: 0x00093AEC File Offset: 0x00091CEC
		internal virtual Label lblError
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06000FAF RID: 4015 RVA: 0x00093AF5 File Offset: 0x00091CF5
		// (set) Token: 0x06000FB0 RID: 4016 RVA: 0x00093B00 File Offset: 0x00091D00
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

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06000FB1 RID: 4017 RVA: 0x00093B43 File Offset: 0x00091D43
		// (set) Token: 0x06000FB2 RID: 4018 RVA: 0x00093B50 File Offset: 0x00091D50
		internal virtual CheckBox chkSelectAll
		{
			[CompilerGenerated]
			get
			{
				return this._chkSelectAll;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.chkSelectAll_CheckedChanged);
				CheckBox checkBox = this._chkSelectAll;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= eventHandler;
				}
				this._chkSelectAll = value;
				checkBox = this._chkSelectAll;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x06000FB3 RID: 4019 RVA: 0x00093B94 File Offset: 0x00091D94
		private void EditBarCodes_Load(object sender, EventArgs e)
		{
			try
			{
				bool isbranch = MyProject.Forms.Form1.isbranch;
				if (isbranch)
				{
					MessageBox.Show("This is a branch computer and cannot edit product details. Product changes should be changed at HQ.");
					base.Dispose();
				}
				this.LoadProducts();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading Bar Codes form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000FB4 RID: 4020 RVA: 0x00093C0C File Offset: 0x00091E0C
		private void LoadProducts()
		{
			try
			{
				this.dgvProducts.Columns.Clear();
				this.dat.Clear();
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "SelectProductDetailsBarCode";
				sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				int num = sqlDataAdapter.Fill(this.dat);
				bool flag = num > 0;
				if (flag)
				{
					this.dgvProducts.DataSource = this.dat;
					this.dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
					this.dgvProducts.Columns["Product_ID"].ReadOnly = true;
					this.dgvProducts.Columns["Product_ID"].DefaultCellStyle.BackColor = Color.Gray;
					this.dgvProducts.Columns["Description"].DefaultCellStyle.BackColor = Color.Gray;
					this.dgvProducts.Columns["Description"].ReadOnly = true;
					this.dgvProducts.Columns["product_Code"].DefaultCellStyle.BackColor = Color.LightYellow;
					this.dgvProducts.Columns["product_code"].HeaderText = "Bar Code";
					this.dgvProducts.Columns["Bar_Code"].Visible = false;
					DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
					dataGridViewCheckBoxColumn.Name = "Select";
					dataGridViewCheckBoxColumn.HeaderText = "Select";
					this.dgvProducts.Columns.Insert(0, dataGridViewCheckBoxColumn);
					DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
					dataGridViewButtonColumn.HeaderText = "Generate Barcode";
					dataGridViewButtonColumn.Text = "Generate & Save";
					dataGridViewButtonColumn.Name = "Generate";
					dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
					this.dgvProducts.Columns.Insert(5, dataGridViewButtonColumn);
					DataGridViewButtonColumn dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
					dataGridViewButtonColumn2.HeaderText = "Save Change";
					dataGridViewButtonColumn2.Text = "Save";
					dataGridViewButtonColumn2.Name = "Save";
					dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
					this.dgvProducts.Columns.Insert(6, dataGridViewButtonColumn2);
				}
			}
			catch (NullReferenceException ex)
			{
			}
			catch (Exception ex2)
			{
				throw ex2;
			}
		}

		// Token: 0x06000FB5 RID: 4021 RVA: 0x00093EC8 File Offset: 0x000920C8
		private void Button3_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = (DialogResult)Interaction.MsgBox("Are you sure you have entered the correct BAR CODE details?", MsgBoxStyle.YesNo, null);
			bool flag = dialogResult == DialogResult.Yes;
			if (flag)
			{
				this.lblError.Text = "...";
				this.SaveBarCodes();
			}
		}

		// Token: 0x06000FB6 RID: 4022 RVA: 0x00093F08 File Offset: 0x00092108
		private void SaveBarCodes()
		{
			this.ProgressBar1.Visible = true;
			this.ProgressBar1.BringToFront();
			this.ProgressBar1.Minimum = 1;
			this.ProgressBar1.Maximum = 3;
			this.ProgressBar1.Step = 1;
			this.ProgressBar1.PerformStep();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			SqlCommand sqlCommand2 = sqlConnection.CreateCommand();
			sqlConnection.Open();
			SqlTransaction sqlTransaction = sqlConnection.BeginTransaction("RunEditBarCodes");
			sqlCommand.Connection = sqlConnection;
			sqlCommand2.Connection = sqlConnection;
			sqlCommand.Transaction = sqlTransaction;
			sqlCommand2.Transaction = sqlTransaction;
			try
			{
				this.ProgressBar1.PerformStep();
				try
				{
					foreach (object obj in this.dat.Rows)
					{
						DataRow dataRow = (DataRow)obj;
						sqlCommand2.Parameters.Clear();
						sqlCommand2.CommandType = CommandType.StoredProcedure;
						sqlCommand2.CommandText = "CheckIfBarCodeExists";
						sqlCommand2.Parameters.AddWithValue("BarCode", RuntimeHelpers.GetObjectValue(dataRow["Product_Code"]));
						sqlCommand2.Parameters.AddWithValue("ProductID", RuntimeHelpers.GetObjectValue(dataRow["Product_ID"]));
						sqlCommand2.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
						SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand2);
						DataTable dataTable = new DataTable();
						int num = sqlDataAdapter.Fill(dataTable);
						bool flag = num > 0;
						bool flag2;
						if (flag)
						{
							DataRow dataRow2 = dataTable.Rows[0];
							this.lblError.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Duplicate on Product IDs ", dataRow2["ProductID"]), " and "));
							flag2 = true;
						}
						else
						{
							flag2 = false;
						}
						bool flag3 = !flag2;
						if (!flag3)
						{
							this.lblError.Text = Conversions.ToString(Operators.ConcatenateObject(this.lblError.Text, dataRow["Product_ID"]));
							MessageBox.Show("Duplicate Bar Codes noticed. Please rectify. Check the error message on the form.", "Error", MessageBoxButtons.OK);
							sqlTransaction.Rollback();
							sqlCommand.Connection.Close();
							this.ProgressBar1.Visible = false;
							return;
						}
						sqlCommand.Parameters.Clear();
						sqlCommand.CommandType = CommandType.StoredProcedure;
						sqlCommand.CommandText = "UpdateProductDetails";
						sqlCommand.Parameters.AddWithValue("BarCode", RuntimeHelpers.GetObjectValue(dataRow["Bar_Code"]));
						sqlCommand.Parameters.AddWithValue("Desc", RuntimeHelpers.GetObjectValue(dataRow["Description"]));
						sqlCommand.Parameters.AddWithValue("ProductCode", RuntimeHelpers.GetObjectValue(dataRow["Product_Code"]));
						sqlCommand.Parameters.AddWithValue("ProductID", RuntimeHelpers.GetObjectValue(dataRow["Product_ID"]));
						sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
						sqlCommand.ExecuteNonQuery();
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
				MessageBox.Show("Bar Codes updated successfully.");
			}
			catch (Exception ex)
			{
				sqlTransaction.Rollback();
				sqlCommand.Connection.Close();
				this.ProgressBar1.Visible = false;
				MessageBox.Show("Error occured adjusting Bar Codes. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000FB7 RID: 4023 RVA: 0x00094304 File Offset: 0x00092504
		private void GenerateSaveBarCodes()
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
			SqlTransaction sqlTransaction = sqlConnection.BeginTransaction("RunEditBarCodes2");
			sqlCommand.Connection = sqlConnection;
			sqlCommand.Transaction = sqlTransaction;
			checked
			{
				try
				{
					this.ProgressBar1.PerformStep();
					int num = 0;
					try
					{
						foreach (object obj in ((IEnumerable)this.dgvProducts.Rows))
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							bool flag = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["Select"].Value, true, false);
							if (flag)
							{
								num++;
								string nextProductCode = this.pf.GetNextProductCode(this._cnn, MyProject.Forms.Form1.coid);
								dataGridViewRow.Cells["Product_Code"].Value = nextProductCode;
								sqlCommand.Parameters.Clear();
								sqlCommand.CommandType = CommandType.StoredProcedure;
								sqlCommand.CommandText = "UpdateProductDetails";
								sqlCommand.Parameters.AddWithValue("BarCode", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Bar_Code"].Value));
								sqlCommand.Parameters.AddWithValue("Desc", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Description"].Value));
								sqlCommand.Parameters.AddWithValue("ProductCode", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Product_Code"].Value));
								sqlCommand.Parameters.AddWithValue("ProductID", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Product_ID"].Value));
								sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
								sqlCommand.ExecuteNonQuery();
								sqlCommand.Parameters.Clear();
								sqlCommand.CommandType = CommandType.StoredProcedure;
								sqlCommand.CommandText = "UpdateProductCodeBase";
								sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
								string text = Conversions.ToString(dataGridViewRow.Cells["Product_Code"].Value);
								bool flag2 = text.Length == 13;
								string text2;
								if (flag2)
								{
									text2 = text.Substring(3, 9);
								}
								else
								{
									text2 = text.Substring(2, text.Length - 2);
								}
								sqlCommand.Parameters.AddWithValue("code", Conversions.ToDecimal(text2));
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
					bool flag3 = num > 0;
					if (flag3)
					{
						sqlTransaction.Commit();
						sqlCommand.Connection.Close();
						this.ProgressBar1.PerformStep();
						this.ProgressBar1.Visible = false;
						MessageBox.Show(num.ToString() + " Bar Codes updated successfully.");
						base.Dispose();
					}
					else
					{
						MessageBox.Show("No product bar codes updated. Select products first.");
						sqlTransaction.Rollback();
						sqlCommand.Connection.Close();
					}
				}
				catch (Exception ex)
				{
					sqlTransaction.Rollback();
					sqlCommand.Connection.Close();
					this.ProgressBar1.Visible = false;
					MessageBox.Show("Error occured adjusting Bar Codes. Detail: " + ex.Message);
				}
			}
		}

		// Token: 0x06000FB8 RID: 4024 RVA: 0x0009470C File Offset: 0x0009290C
		private void TextBox1_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.FilterProducts(this.txtSearchProducts.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching products. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000FB9 RID: 4025 RVA: 0x00094768 File Offset: 0x00092968
		private void FilterProducts(string searchtext)
		{
			DataView dataView = new DataView(this.dat, "[Description] like '%" + searchtext + "%'", "Description Desc", DataViewRowState.CurrentRows);
			this.dgvProducts.DataSource = dataView;
		}

		// Token: 0x06000FBA RID: 4026 RVA: 0x000947A8 File Offset: 0x000929A8
		private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				SqlCommand sqlCommand2 = sqlConnection.CreateCommand();
				sqlConnection.Open();
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					bool flag2 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "Save", false) == 0;
					if (flag2)
					{
						SqlTransaction sqlTransaction = sqlConnection.BeginTransaction("RunEditBarCodes");
						sqlCommand.Connection = sqlConnection;
						sqlCommand2.Connection = sqlConnection;
						sqlCommand.Transaction = sqlTransaction;
						sqlCommand2.Transaction = sqlTransaction;
						try
						{
							this.ProgressBar1.PerformStep();
							sqlCommand2.Parameters.Clear();
							sqlCommand2.CommandType = CommandType.StoredProcedure;
							sqlCommand2.CommandText = "CheckIfBarCodeExists";
							sqlCommand2.Parameters.AddWithValue("BarCode", RuntimeHelpers.GetObjectValue(dataGridView.Rows[e.RowIndex].Cells["Product_Code"].Value));
							sqlCommand2.Parameters.AddWithValue("ProductID", RuntimeHelpers.GetObjectValue(dataGridView.Rows[e.RowIndex].Cells["Product_ID"].Value));
							sqlCommand2.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
							SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand2);
							DataTable dataTable = new DataTable();
							int num = sqlDataAdapter.Fill(dataTable);
							bool flag3 = num > 0;
							bool flag4;
							if (flag3)
							{
								DataRow dataRow = dataTable.Rows[0];
								this.lblError.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Duplicate on Product IDs ", dataRow["ProductID"]), " and "));
								flag4 = true;
							}
							else
							{
								flag4 = false;
							}
							bool flag5 = !flag4;
							if (flag5)
							{
								sqlCommand.Parameters.Clear();
								sqlCommand.CommandType = CommandType.StoredProcedure;
								sqlCommand.CommandText = "UpdateProductDetails";
								sqlCommand.Parameters.AddWithValue("BarCode", RuntimeHelpers.GetObjectValue(dataGridView.Rows[e.RowIndex].Cells["Bar_Code"].Value));
								sqlCommand.Parameters.AddWithValue("Desc", RuntimeHelpers.GetObjectValue(dataGridView.Rows[e.RowIndex].Cells["Description"].Value));
								sqlCommand.Parameters.AddWithValue("ProductCode", RuntimeHelpers.GetObjectValue(dataGridView.Rows[e.RowIndex].Cells["Product_Code"].Value));
								sqlCommand.Parameters.AddWithValue("ProductID", RuntimeHelpers.GetObjectValue(dataGridView.Rows[e.RowIndex].Cells["Product_ID"].Value));
								sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
								sqlCommand.ExecuteNonQuery();
								sqlTransaction.Commit();
								sqlCommand.Connection.Close();
								MessageBox.Show("Bar Codes updated successfully.");
							}
							else
							{
								this.lblError.Text = this.lblError.Text + dataGridView.Rows[e.RowIndex].Cells["Product_ID"].Value.ToString();
								MessageBox.Show("Duplicate Bar Codes noticed. Please rectify. Check the error message on the form.", "Error", MessageBoxButtons.OK);
								sqlTransaction.Rollback();
								sqlCommand.Connection.Close();
								this.ProgressBar1.Visible = false;
							}
						}
						catch (Exception ex)
						{
							sqlTransaction.Rollback();
							sqlCommand.Connection.Close();
							this.ProgressBar1.Visible = false;
							MessageBox.Show("Error occured adjusting Bar Codes. Detail: " + ex.Message);
						}
					}
					else
					{
						bool flag6 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "Generate", false) == 0;
						if (flag6)
						{
							SqlTransaction sqlTransaction = sqlConnection.BeginTransaction("RunEditBarCodes");
							sqlCommand.Connection = sqlConnection;
							sqlCommand.Transaction = sqlTransaction;
							try
							{
								string nextProductCode = this.pf.GetNextProductCode(this._cnn, MyProject.Forms.Form1.coid);
								dataGridView.Rows[e.RowIndex].Cells["Product_Code"].Value = nextProductCode;
								sqlCommand.CommandType = CommandType.StoredProcedure;
								sqlCommand.CommandText = "UpdateProductDetails";
								sqlCommand.Parameters.AddWithValue("BarCode", RuntimeHelpers.GetObjectValue(dataGridView.Rows[e.RowIndex].Cells["Bar_Code"].Value));
								sqlCommand.Parameters.AddWithValue("Desc", RuntimeHelpers.GetObjectValue(dataGridView.Rows[e.RowIndex].Cells["Description"].Value));
								sqlCommand.Parameters.AddWithValue("ProductCode", RuntimeHelpers.GetObjectValue(dataGridView.Rows[e.RowIndex].Cells["Product_Code"].Value));
								sqlCommand.Parameters.AddWithValue("ProductID", RuntimeHelpers.GetObjectValue(dataGridView.Rows[e.RowIndex].Cells["Product_ID"].Value));
								sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
								sqlCommand.ExecuteNonQuery();
								sqlCommand.Parameters.Clear();
								sqlCommand.CommandText = "UpdateProductCodeBase";
								sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
								string text = Conversions.ToString(dataGridView.Rows[e.RowIndex].Cells["Product_Code"].Value);
								bool flag7 = text.Length == 13;
								string text2;
								if (flag7)
								{
									text2 = text.Substring(3, 9);
								}
								else
								{
									text2 = text.Substring(2, checked(text.Length - 2));
								}
								sqlCommand.Parameters.AddWithValue("code", Conversions.ToDecimal(text2));
								sqlCommand.ExecuteNonQuery();
								sqlTransaction.Commit();
								sqlConnection.Close();
								MessageBox.Show("Barcode generated and saved for product " + dataGridView.Rows[e.RowIndex].Cells["Description"].Value.ToString());
							}
							catch (Exception ex2)
							{
								MessageBox.Show("Error saving barcode/product code changes. Detail: " + ex2.Message);
							}
						}
					}
				}
			}
			catch (Exception ex3)
			{
				MessageBox.Show("Error occured on Invoice Grid. Detail: " + ex3.Message);
			}
		}

		// Token: 0x06000FBB RID: 4027 RVA: 0x00094F4C File Offset: 0x0009314C
		private void Button1_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = (DialogResult)Interaction.MsgBox("Are you sure that you want to create and save new barcodes for all selected products? This cannot be reversed.", MsgBoxStyle.YesNo, null);
			bool flag = dialogResult == DialogResult.Yes;
			if (flag)
			{
				this.lblError.Text = "...";
				this.GenerateSaveBarCodes();
			}
		}

		// Token: 0x06000FBC RID: 4028 RVA: 0x00094F8C File Offset: 0x0009318C
		private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				bool @checked = this.chkSelectAll.Checked;
				if (@checked)
				{
					try
					{
						foreach (object obj in ((IEnumerable)this.dgvProducts.Rows))
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							dataGridViewRow.Cells["Select"].Value = true;
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
					try
					{
						foreach (object obj2 in ((IEnumerable)this.dgvProducts.Rows))
						{
							DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj2;
							dataGridViewRow2.Cells["Select"].Value = false;
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
			catch (Exception ex)
			{
				MessageBox.Show("Error. Detail: " + ex.Message);
			}
		}

		// Token: 0x04000784 RID: 1924
		private string _cnn;

		// Token: 0x04000785 RID: 1925
		private DataTable dat;

		// Token: 0x04000786 RID: 1926
		private PublicFunctions pf;
	}
}
