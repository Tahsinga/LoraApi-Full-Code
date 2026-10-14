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
	// Token: 0x02000026 RID: 38
	[DesignerGenerated]
	public partial class Collections : Form
	{
		// Token: 0x06000736 RID: 1846 RVA: 0x00048842 File Offset: 0x00046A42
		public Collections()
		{
			base.Load += this.Collections_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000739 RID: 1849 RVA: 0x000495CA File Offset: 0x000477CA
		// (set) Token: 0x0600073A RID: 1850 RVA: 0x000495D4 File Offset: 0x000477D4
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x0600073B RID: 1851 RVA: 0x000495DD File Offset: 0x000477DD
		// (set) Token: 0x0600073C RID: 1852 RVA: 0x000495E7 File Offset: 0x000477E7
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x0600073D RID: 1853 RVA: 0x000495F0 File Offset: 0x000477F0
		// (set) Token: 0x0600073E RID: 1854 RVA: 0x000495FA File Offset: 0x000477FA
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x0600073F RID: 1855 RVA: 0x00049603 File Offset: 0x00047803
		// (set) Token: 0x06000740 RID: 1856 RVA: 0x0004960D File Offset: 0x0004780D
		internal virtual ComboBox cboBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000741 RID: 1857 RVA: 0x00049616 File Offset: 0x00047816
		// (set) Token: 0x06000742 RID: 1858 RVA: 0x00049620 File Offset: 0x00047820
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

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000743 RID: 1859 RVA: 0x00049663 File Offset: 0x00047863
		// (set) Token: 0x06000744 RID: 1860 RVA: 0x0004966D File Offset: 0x0004786D
		internal virtual DateTimePicker DTEnddate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000745 RID: 1861 RVA: 0x00049676 File Offset: 0x00047876
		// (set) Token: 0x06000746 RID: 1862 RVA: 0x00049680 File Offset: 0x00047880
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000747 RID: 1863 RVA: 0x00049689 File Offset: 0x00047889
		// (set) Token: 0x06000748 RID: 1864 RVA: 0x00049693 File Offset: 0x00047893
		internal virtual DateTimePicker DTStartdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000749 RID: 1865 RVA: 0x0004969C File Offset: 0x0004789C
		// (set) Token: 0x0600074A RID: 1866 RVA: 0x000496A6 File Offset: 0x000478A6
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x0600074B RID: 1867 RVA: 0x000496AF File Offset: 0x000478AF
		// (set) Token: 0x0600074C RID: 1868 RVA: 0x000496B9 File Offset: 0x000478B9
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x0600074D RID: 1869 RVA: 0x000496C2 File Offset: 0x000478C2
		// (set) Token: 0x0600074E RID: 1870 RVA: 0x000496CC File Offset: 0x000478CC
		internal virtual DataGridView dgvInvoices
		{
			[CompilerGenerated]
			get
			{
				return this._dgvInvoices;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgvInvoices_CellContentClick);
				DataGridView dataGridView = this._dgvInvoices;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick -= dataGridViewCellEventHandler;
				}
				this._dgvInvoices = value;
				dataGridView = this._dgvInvoices;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x0600074F RID: 1871 RVA: 0x0004970F File Offset: 0x0004790F
		// (set) Token: 0x06000750 RID: 1872 RVA: 0x00049719 File Offset: 0x00047919
		internal virtual GroupBox GroupBox3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000751 RID: 1873 RVA: 0x00049722 File Offset: 0x00047922
		// (set) Token: 0x06000752 RID: 1874 RVA: 0x0004972C File Offset: 0x0004792C
		internal virtual DataGridView dgvInvDetails
		{
			[CompilerGenerated]
			get
			{
				return this._dgvInvDetails;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewEditingControlShowingEventHandler dataGridViewEditingControlShowingEventHandler = new DataGridViewEditingControlShowingEventHandler(this.dgvInvDetails_EditingControlShowing);
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgvInvDetails_CellContentClick);
				DataGridView dataGridView = this._dgvInvDetails;
				if (dataGridView != null)
				{
					dataGridView.EditingControlShowing -= dataGridViewEditingControlShowingEventHandler;
					dataGridView.CellContentClick -= dataGridViewCellEventHandler;
				}
				this._dgvInvDetails = value;
				dataGridView = this._dgvInvDetails;
				if (dataGridView != null)
				{
					dataGridView.EditingControlShowing += dataGridViewEditingControlShowingEventHandler;
					dataGridView.CellContentClick += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000753 RID: 1875 RVA: 0x0004978A File Offset: 0x0004798A
		// (set) Token: 0x06000754 RID: 1876 RVA: 0x00049794 File Offset: 0x00047994
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000755 RID: 1877 RVA: 0x0004979D File Offset: 0x0004799D
		// (set) Token: 0x06000756 RID: 1878 RVA: 0x000497A8 File Offset: 0x000479A8
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

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000757 RID: 1879 RVA: 0x000497EB File Offset: 0x000479EB
		// (set) Token: 0x06000758 RID: 1880 RVA: 0x000497F5 File Offset: 0x000479F5
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000759 RID: 1881 RVA: 0x000497FE File Offset: 0x000479FE
		// (set) Token: 0x0600075A RID: 1882 RVA: 0x00049808 File Offset: 0x00047A08
		internal virtual TextBox txtCollectedBy
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x0600075B RID: 1883 RVA: 0x00049811 File Offset: 0x00047A11
		// (set) Token: 0x0600075C RID: 1884 RVA: 0x0004981B File Offset: 0x00047A1B
		internal virtual CheckBox chkCollectionsOnly
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x00049824 File Offset: 0x00047A24
		private void Collections_Load(object sender, EventArgs e)
		{
			try
			{
				base.WindowState = FormWindowState.Maximized;
				this.LoadBranches();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x0004987C File Offset: 0x00047A7C
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

		// Token: 0x0600075F RID: 1887 RVA: 0x00049940 File Offset: 0x00047B40
		private void LoadSales()
		{
			this.dgvInvoices.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SalesForPeriodByInvoiceCollection";
			sqlCommand.Parameters.AddWithValue("startdate", Conversion.Val(this.DTStartdate.Value.ToString("yyyyMMdd")));
			sqlCommand.Parameters.AddWithValue("enddate", Conversion.Val(this.DTEnddate.Value.ToString("yyyyMMdd")));
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", this.cboBranch.Text);
			bool @checked = this.chkCollectionsOnly.Checked;
			if (@checked)
			{
				sqlCommand.Parameters.AddWithValue("collection", 1);
			}
			else
			{
				sqlCommand.Parameters.AddWithValue("collection", 0);
			}
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				this.dgvInvoices.DataSource = dataTable;
				this.dgvInvoices.Columns["collection_done"].HeaderText = "Collection/Delivery done?";
				this.dgvInvoices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
				dataGridViewButtonColumn.HeaderText = "View Details";
				dataGridViewButtonColumn.Text = "View";
				dataGridViewButtonColumn.Name = "view";
				dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
				this.dgvInvoices.Columns.Add(dataGridViewButtonColumn);
			}
			else
			{
				MessageBox.Show("There are no sales for the period selected.");
				DataTable dataTable2 = new DataTable();
				this.dgvInvoices.DataSource = dataTable2;
			}
			try
			{
				foreach (object obj in ((IEnumerable)this.dgvInvoices.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					bool flag2 = !dataGridViewRow.IsNewRow;
					if (flag2)
					{
						bool flag3 = (Operators.CompareString(dataGridViewRow.Cells["Collection_Delivery"].Value.ToString(), "NONE", false) == 0) | (Operators.CompareString(dataGridViewRow.Cells["Collection_Delivery"].Value.ToString(), "", false) == 0);
						if (flag3)
						{
							dataGridViewRow.Cells["view"].ReadOnly = true;
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
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x00049C28 File Offset: 0x00047E28
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				Cursor.Current = Cursors.WaitCursor;
				this.LoadSales();
				Cursor.Current = Cursors.Default;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading sales for period. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x00049C8C File Offset: 0x00047E8C
		private void dgvInvoices_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					bool flag2 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "view", false) == 0;
					if (flag2)
					{
						bool flag3 = (Operators.CompareString(dataGridView.Rows[e.RowIndex].Cells["Collection_Delivery"].Value.ToString(), "NONE", false) == 0) | (Operators.CompareString(dataGridView.Rows[e.RowIndex].Cells["Collection_Delivery"].Value.ToString(), "", false) == 0);
						if (flag3)
						{
							MessageBox.Show("Invoice was not marked for Collection or Delivery");
						}
						else
						{
							this.invnumber = Conversions.ToInteger(dataGridView.Rows[e.RowIndex].Cells["Invoice_Number"].Value);
							this.col_del = Conversions.ToString(dataGridView.Rows[e.RowIndex].Cells["Collection_Delivery"].Value);
							this.LoadInvoiceDetails(this.invnumber, MyProject.Forms.Form1.coid, this.col_del);
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error processing dgv button. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x00049E50 File Offset: 0x00048050
		private void LoadInvoiceDetails(int invoicenum, int coid, string col_or_delivery)
		{
			this.dgvInvDetails.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchCollectionStatus";
			sqlCommand.Parameters.AddWithValue("invoicenum", invoicenum);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				this.dgvInvDetails.DataSource = dataTable;
				DataGridViewTextBoxColumn dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
				dataGridViewTextBoxColumn.HeaderText = "Qty";
				dataGridViewTextBoxColumn.Name = "qty";
				this.dgvInvDetails.Columns.Add(dataGridViewTextBoxColumn);
				bool flag2 = Operators.CompareString(col_or_delivery, "DELIVERY", false) == 0;
				string text;
				if (flag2)
				{
					text = "DELIVERED";
				}
				else
				{
					text = "COLLECTED";
				}
				this.dgvInvDetails.Columns["CollectedQty"].HeaderText = text + " Qty so far";
				this.dgvInvDetails.Columns["Quantity"].HeaderText = "Inv " + col_or_delivery + " Qty expected";
				this.dgvInvDetails.Columns["entryno"].Visible = false;
				this.dgvInvDetails.Columns["CollectedQty"].ReadOnly = true;
				this.dgvInvDetails.Columns["Invoice_Number"].ReadOnly = true;
				this.dgvInvDetails.Columns["Product_ID"].ReadOnly = true;
				this.dgvInvDetails.Columns["Product_Code"].ReadOnly = true;
				this.dgvInvDetails.Columns["Product_Description"].ReadOnly = true;
				this.dgvInvDetails.Columns["Quantity"].ReadOnly = true;
				this.dgvInvDetails.Columns["CollectedQty"].DefaultCellStyle.BackColor = Color.LightGray;
				this.dgvInvDetails.Columns["Invoice_Number"].DefaultCellStyle.BackColor = Color.LightGray;
				this.dgvInvDetails.Columns["Product_ID"].DefaultCellStyle.BackColor = Color.LightGray;
				this.dgvInvDetails.Columns["Product_Code"].DefaultCellStyle.BackColor = Color.LightGray;
				this.dgvInvDetails.Columns["Product_Description"].DefaultCellStyle.BackColor = Color.LightGray;
				this.dgvInvDetails.Columns["Quantity"].DefaultCellStyle.BackColor = Color.LightGray;
				this.dgvInvDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				this.GroupBox3.Text = "Invoice Details for Invoice: " + Conversions.ToString(this.invnumber);
			}
			try
			{
				foreach (object obj in ((IEnumerable)this.dgvInvDetails.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					bool flag3 = Operators.CompareString(dataGridViewRow.Cells["Quantity"].Value.ToString(), dataGridViewRow.Cells["CollectedQty"].Value.ToString(), false) == 0;
					if (flag3)
					{
						dataGridViewRow.Cells["qty"].ReadOnly = true;
						dataGridViewRow.Cells["qty"].Style.BackColor = Color.LightGray;
					}
					else
					{
						dataGridViewRow.Cells["qty"].ReadOnly = false;
						dataGridViewRow.Cells["qty"].Style.BackColor = Color.White;
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

		// Token: 0x06000763 RID: 1891 RVA: 0x0004A298 File Offset: 0x00048498
		private void Button2_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.txtCollectedBy.Text, "", false) == 0;
			if (flag)
			{
				MessageBox.Show("Please enter the person who received the goods in good order.");
			}
			else
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.Connection = sqlConnection;
				sqlConnection.Open();
				SqlTransaction sqlTransaction = sqlConnection.BeginTransaction("RunCollectionsUpdate");
				try
				{
					sqlCommand.Transaction = sqlTransaction;
					sqlCommand.CommandType = CommandType.StoredProcedure;
					bool flag2 = true;
					try
					{
						foreach (object obj in ((IEnumerable)this.dgvInvDetails.Rows))
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							bool flag3 = Operators.ConditionalCompareObjectGreater(Operators.AddObject(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["qty"].Value)), 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["qty"].Value)), Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["CollectedQty"].Value)), 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["CollectedQty"].Value))), dataGridViewRow.Cells["Quantity"].Value, false);
							if (flag3)
							{
								MessageBox.Show("Total quantity collected/delivered cannot be greater than the invoice quantity. Kindly rectify. ");
								dataGridViewRow.Selected = true;
								sqlTransaction.Rollback();
								sqlConnection.Close();
								return;
							}
							sqlCommand.Parameters.Clear();
							sqlCommand.CommandText = "UpdateCollections";
							sqlCommand.Parameters.AddWithValue("invoicenum", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Invoice_Number"].Value));
							sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
							sqlCommand.Parameters.AddWithValue("entryno", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["EntryNo"].Value));
							sqlCommand.Parameters.AddWithValue("collectedqty", Operators.AddObject(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["qty"].Value)), 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["qty"].Value)), Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["CollectedQty"].Value)), 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["CollectedQty"].Value))));
							sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
							sqlCommand.Parameters.AddWithValue("enteredby", MyProject.Forms.Form1.username);
							sqlCommand.Parameters.AddWithValue("collectedby", this.txtCollectedBy.Text);
							sqlCommand.ExecuteNonQuery();
							bool flag4 = Operators.ConditionalCompareObjectNotEqual(dataGridViewRow.Cells["Quantity"].Value, Operators.AddObject(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["qty"].Value)), 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["qty"].Value)), Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["CollectedQty"].Value)), 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["CollectedQty"].Value))), false);
							if (flag4)
							{
								flag2 = false;
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
					bool flag5 = flag2;
					if (flag5)
					{
						sqlCommand.Parameters.Clear();
						sqlCommand.CommandText = "UpdateCollectionsDone";
						sqlCommand.Parameters.AddWithValue("invoicenum", this.invnumber);
						sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
						sqlCommand.Parameters.AddWithValue("enteredby", MyProject.Forms.Form1.username);
						sqlCommand.ExecuteNonQuery();
					}
					sqlTransaction.Commit();
					sqlConnection.Close();
					this.LoadInvoiceDetails(this.invnumber, MyProject.Forms.Form1.coid, this.col_del);
					this.LoadSales();
					this.txtCollectedBy.Text = "";
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error saving details. Detail: " + ex.Message);
					try
					{
						sqlTransaction.Rollback();
						sqlConnection.Close();
					}
					catch (Exception ex2)
					{
					}
				}
			}
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x0004A7F8 File Offset: 0x000489F8
		private void dgvInvDetails_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			bool flag = e.Control is TextBox;
			if (flag)
			{
				TextBox textBox = e.Control as TextBox;
				textBox.KeyPress -= this.tb_KeyPress;
				bool flag2 = this.dgvInvDetails.CurrentCell.ColumnIndex == 7;
				if (flag2)
				{
					textBox.KeyPress += this.tb_KeyPress;
				}
			}
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x0004A868 File Offset: 0x00048A68
		private void tb_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = !char.IsControl(e.KeyChar) & !char.IsDigit(e.KeyChar) & (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) != 0);
			if (flag)
			{
				e.Handled = true;
			}
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x00002A30 File Offset: 0x00000C30
		private void dgvInvDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x04000378 RID: 888
		private string _cnn;

		// Token: 0x04000379 RID: 889
		private int invnumber;

		// Token: 0x0400037A RID: 890
		private string col_del;
	}
}
