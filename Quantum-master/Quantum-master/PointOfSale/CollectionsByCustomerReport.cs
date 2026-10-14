using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;

namespace PointOfSale
{
	// Token: 0x02000028 RID: 40
	[DesignerGenerated]
	public partial class CollectionsByCustomerReport : Form
	{
		// Token: 0x06000795 RID: 1941 RVA: 0x0004C714 File Offset: 0x0004A914
		public CollectionsByCustomerReport()
		{
			base.Load += this.CollectionsByCustomerReport_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000798 RID: 1944 RVA: 0x0004CE24 File Offset: 0x0004B024
		// (set) Token: 0x06000799 RID: 1945 RVA: 0x0004CE2E File Offset: 0x0004B02E
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x0600079A RID: 1946 RVA: 0x0004CE37 File Offset: 0x0004B037
		// (set) Token: 0x0600079B RID: 1947 RVA: 0x0004CE41 File Offset: 0x0004B041
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x0600079C RID: 1948 RVA: 0x0004CE4A File Offset: 0x0004B04A
		// (set) Token: 0x0600079D RID: 1949 RVA: 0x0004CE54 File Offset: 0x0004B054
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

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x0600079E RID: 1950 RVA: 0x0004CE97 File Offset: 0x0004B097
		// (set) Token: 0x0600079F RID: 1951 RVA: 0x0004CEA1 File Offset: 0x0004B0A1
		internal virtual Label Label18
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x060007A0 RID: 1952 RVA: 0x0004CEAA File Offset: 0x0004B0AA
		// (set) Token: 0x060007A1 RID: 1953 RVA: 0x0004CEB4 File Offset: 0x0004B0B4
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

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x060007A2 RID: 1954 RVA: 0x0004CEF7 File Offset: 0x0004B0F7
		// (set) Token: 0x060007A3 RID: 1955 RVA: 0x0004CF04 File Offset: 0x0004B104
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

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x060007A4 RID: 1956 RVA: 0x0004CF47 File Offset: 0x0004B147
		// (set) Token: 0x060007A5 RID: 1957 RVA: 0x0004CF54 File Offset: 0x0004B154
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

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x060007A6 RID: 1958 RVA: 0x0004CF97 File Offset: 0x0004B197
		// (set) Token: 0x060007A7 RID: 1959 RVA: 0x0004CFA1 File Offset: 0x0004B1A1
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x060007A8 RID: 1960 RVA: 0x0004CFAA File Offset: 0x0004B1AA
		// (set) Token: 0x060007A9 RID: 1961 RVA: 0x0004CFB4 File Offset: 0x0004B1B4
		internal virtual DataGridView dgvProductAudit
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x0004CFC0 File Offset: 0x0004B1C0
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

		// Token: 0x060007AB RID: 1963 RVA: 0x0004D06C File Offset: 0x0004B26C
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

		// Token: 0x060007AC RID: 1964 RVA: 0x0004D174 File Offset: 0x0004B374
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "CollectionStatusAllProductsForCustomer";
				sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
				sqlCommand.Parameters.AddWithValue("customername", this.cboCustomers.Text);
				DataTable dataTable = new DataTable();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				int num = sqlDataAdapter.Fill(dataTable);
				this.dgvProducts.DataSource = dataTable;
				this.dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
				dataGridViewButtonColumn.HeaderText = "View Details";
				dataGridViewButtonColumn.Text = "View";
				dataGridViewButtonColumn.Name = "view";
				dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
				this.dgvProducts.Columns.Add(dataGridViewButtonColumn);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying report. Detail: " + ex.Message);
			}
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x0004D2A0 File Offset: 0x0004B4A0
		private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
						this.LoadProductAudit(Conversions.ToInteger(dataGridView.Rows[e.RowIndex].Cells["Product_ID"].Value), this.cboCustomers.Text, MyProject.Forms.Form1.coid);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error showing audit. Detail:" + ex.Message);
			}
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x0004D390 File Offset: 0x0004B590
		private void LoadProductAudit(int productid, string customername, int coid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "CollectionsMovementForProductForCustomer";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("customername", customername);
			sqlCommand.Parameters.AddWithValue("productid", productid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			this.dgvProductAudit.DataSource = dataTable;
			this.dgvProductAudit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvProductAudit.Columns["entryno"].Visible = false;
			this.dgvProductAudit.Columns["coid"].Visible = false;
			this.dgvProductAudit.Columns["branch"].Visible = false;
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x0004D498 File Offset: 0x0004B698
		private void CollectionsByCustomerReport_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadCustomers();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x0004D4E8 File Offset: 0x0004B6E8
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

		// Token: 0x0400039A RID: 922
		private string _cnn;
	}
}
