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
	// Token: 0x02000027 RID: 39
	[DesignerGenerated]
	public partial class CollectionsByCustomer : Form
	{
		// Token: 0x06000767 RID: 1895 RVA: 0x0004A8BB File Offset: 0x00048ABB
		public CollectionsByCustomer()
		{
			base.Load += this.CollectionsByCustomer_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x0600076A RID: 1898 RVA: 0x0004B45B File Offset: 0x0004965B
		// (set) Token: 0x0600076B RID: 1899 RVA: 0x0004B465 File Offset: 0x00049665
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x0600076C RID: 1900 RVA: 0x0004B46E File Offset: 0x0004966E
		// (set) Token: 0x0600076D RID: 1901 RVA: 0x0004B478 File Offset: 0x00049678
		internal virtual Label Label18
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x0600076E RID: 1902 RVA: 0x0004B481 File Offset: 0x00049681
		// (set) Token: 0x0600076F RID: 1903 RVA: 0x0004B48C File Offset: 0x0004968C
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

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000770 RID: 1904 RVA: 0x0004B4CF File Offset: 0x000496CF
		// (set) Token: 0x06000771 RID: 1905 RVA: 0x0004B4DC File Offset: 0x000496DC
		internal virtual ComboBox cboCustomers
		{
			[CompilerGenerated]
			get
			{
				return this._cboCustomers;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.cboCustomers_KeyUp);
				ComboBox comboBox = this._cboCustomers;
				if (comboBox != null)
				{
					comboBox.KeyUp -= keyEventHandler;
				}
				this._cboCustomers = value;
				comboBox = this._cboCustomers;
				if (comboBox != null)
				{
					comboBox.KeyUp += keyEventHandler;
				}
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000772 RID: 1906 RVA: 0x0004B51F File Offset: 0x0004971F
		// (set) Token: 0x06000773 RID: 1907 RVA: 0x0004B52C File Offset: 0x0004972C
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

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000774 RID: 1908 RVA: 0x0004B56F File Offset: 0x0004976F
		// (set) Token: 0x06000775 RID: 1909 RVA: 0x0004B579 File Offset: 0x00049779
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000776 RID: 1910 RVA: 0x0004B582 File Offset: 0x00049782
		// (set) Token: 0x06000777 RID: 1911 RVA: 0x0004B58C File Offset: 0x0004978C
		internal virtual CheckBox chkall
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000778 RID: 1912 RVA: 0x0004B595 File Offset: 0x00049795
		// (set) Token: 0x06000779 RID: 1913 RVA: 0x0004B59F File Offset: 0x0004979F
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x0600077A RID: 1914 RVA: 0x0004B5A8 File Offset: 0x000497A8
		// (set) Token: 0x0600077B RID: 1915 RVA: 0x0004B5B2 File Offset: 0x000497B2
		internal virtual GroupBox GroupBox3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x0600077C RID: 1916 RVA: 0x0004B5BB File Offset: 0x000497BB
		// (set) Token: 0x0600077D RID: 1917 RVA: 0x0004B5C5 File Offset: 0x000497C5
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x0600077E RID: 1918 RVA: 0x0004B5CE File Offset: 0x000497CE
		// (set) Token: 0x0600077F RID: 1919 RVA: 0x0004B5D8 File Offset: 0x000497D8
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

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000780 RID: 1920 RVA: 0x0004B61B File Offset: 0x0004981B
		// (set) Token: 0x06000781 RID: 1921 RVA: 0x0004B625 File Offset: 0x00049825
		internal virtual DataGridView dgvInvDetails
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000782 RID: 1922 RVA: 0x0004B62E File Offset: 0x0004982E
		// (set) Token: 0x06000783 RID: 1923 RVA: 0x0004B638 File Offset: 0x00049838
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000784 RID: 1924 RVA: 0x0004B641 File Offset: 0x00049841
		// (set) Token: 0x06000785 RID: 1925 RVA: 0x0004B64B File Offset: 0x0004984B
		internal virtual TextBox txtCollectedBy
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000786 RID: 1926 RVA: 0x0004B654 File Offset: 0x00049854
		// (set) Token: 0x06000787 RID: 1927 RVA: 0x0004B660 File Offset: 0x00049860
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

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000788 RID: 1928 RVA: 0x0004B6A3 File Offset: 0x000498A3
		// (set) Token: 0x06000789 RID: 1929 RVA: 0x0004B6AD File Offset: 0x000498AD
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x0600078A RID: 1930 RVA: 0x0004B6B6 File Offset: 0x000498B6
		// (set) Token: 0x0600078B RID: 1931 RVA: 0x0004B6C0 File Offset: 0x000498C0
		internal virtual TextBox txtComment
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x0004B6CC File Offset: 0x000498CC
		private void Button4_Click(object sender, EventArgs e)
		{
			try
			{
				FRMSearchCustomer frmsearchCustomer = new FRMSearchCustomer();
				frmsearchCustomer.txtSearch.Text = this.cboCustomers.Text;
				frmsearchCustomer.ShowDialog(this);
				frmsearchCustomer.Dispose();
				int searchCustomerEntryno = MyProject.Forms.Form1.SearchCustomerEntryno;
				this.cboCustomers.SelectedIndex = this.cboCustomers.FindString(MyProject.Forms.Form1.SearchCustomer);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying advanced search. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x0004B778 File Offset: 0x00049978
		private void LoadCustomers()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchAllCustomers";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			this.cboCustomers.DataSource = dataTable;
			this.cboCustomers.DisplayMember = "CustomerName";
			this.cboCustomers.ValueMember = "CustomerName";
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x0004B838 File Offset: 0x00049A38
		private void LoadSales()
		{
			this.dgvInvoices.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SalesForCollection";
			sqlCommand.Parameters.AddWithValue("customername", this.cboCustomers.Text);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			bool @checked = this.chkall.Checked;
			if (@checked)
			{
				sqlCommand.Parameters.AddWithValue("allcollections", 1);
			}
			else
			{
				sqlCommand.Parameters.AddWithValue("allcollections", 0);
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
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x0004B9F4 File Offset: 0x00049BF4
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.LoadSales();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x0004BA2C File Offset: 0x00049C2C
		private void CollectionsByCustomer_Load(object sender, EventArgs e)
		{
			try
			{
				base.WindowState = FormWindowState.Maximized;
				this.LoadCustomers();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x0004BA84 File Offset: 0x00049C84
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

		// Token: 0x06000792 RID: 1938 RVA: 0x0004BC48 File Offset: 0x00049E48
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

		// Token: 0x06000793 RID: 1939 RVA: 0x0004C090 File Offset: 0x0004A290
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
							sqlCommand.Parameters.AddWithValue("comments", this.txtComment.Text);
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

		// Token: 0x06000794 RID: 1940 RVA: 0x0004C60C File Offset: 0x0004A80C
		private void cboCustomers_KeyUp(object sender, KeyEventArgs e)
		{
			try
			{
				Keys keyCode = e.KeyCode;
				if (keyCode != Keys.Back)
				{
					switch (keyCode)
					{
					case Keys.Left:
					case Keys.Up:
					case Keys.Right:
					case Keys.Down:
						break;
					default:
						if (keyCode != Keys.Delete)
						{
							string text = this.cboCustomers.Text;
							int num = this.cboCustomers.FindString(text);
							bool flag = num >= 0;
							if (flag)
							{
								object objectValue = RuntimeHelpers.GetObjectValue(this.cboCustomers.Items[num]);
								string itemText = this.cboCustomers.GetItemText(RuntimeHelpers.GetObjectValue(objectValue));
								string text2 = itemText.Substring(text.Length);
								this.cboCustomers.Text = text + text2;
								this.cboCustomers.SelectionStart = text.Length;
								this.cboCustomers.SelectionLength = text2.Length;
							}
						}
						break;
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0400038D RID: 909
		private string _cnn;

		// Token: 0x0400038E RID: 910
		private int invnumber;

		// Token: 0x0400038F RID: 911
		private string col_del;
	}
}
