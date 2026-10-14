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
	// Token: 0x02000052 RID: 82
	[DesignerGenerated]
	public partial class EditStockPurchases : UserControl
	{
		// Token: 0x060011A0 RID: 4512 RVA: 0x000A9D70 File Offset: 0x000A7F70
		public EditStockPurchases()
		{
			base.Load += this.EditStockPurchases_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x060011A3 RID: 4515 RVA: 0x000AA4C6 File Offset: 0x000A86C6
		// (set) Token: 0x060011A4 RID: 4516 RVA: 0x000AA4D0 File Offset: 0x000A86D0
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x060011A5 RID: 4517 RVA: 0x000AA4D9 File Offset: 0x000A86D9
		// (set) Token: 0x060011A6 RID: 4518 RVA: 0x000AA4E4 File Offset: 0x000A86E4
		internal virtual Label Label1
		{
			[CompilerGenerated]
			get
			{
				return this._Label1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label1_Click);
				Label label = this._Label1;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label1 = value;
				label = this._Label1;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x060011A7 RID: 4519 RVA: 0x000AA527 File Offset: 0x000A8727
		// (set) Token: 0x060011A8 RID: 4520 RVA: 0x000AA531 File Offset: 0x000A8731
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x060011A9 RID: 4521 RVA: 0x000AA53A File Offset: 0x000A873A
		// (set) Token: 0x060011AA RID: 4522 RVA: 0x000AA544 File Offset: 0x000A8744
		internal virtual DateTimePicker DTday
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x060011AB RID: 4523 RVA: 0x000AA54D File Offset: 0x000A874D
		// (set) Token: 0x060011AC RID: 4524 RVA: 0x000AA558 File Offset: 0x000A8758
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

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x060011AD RID: 4525 RVA: 0x000AA59B File Offset: 0x000A879B
		// (set) Token: 0x060011AE RID: 4526 RVA: 0x000AA5A8 File Offset: 0x000A87A8
		internal virtual DataGridView dgvPurchases
		{
			[CompilerGenerated]
			get
			{
				return this._dgvPurchases;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewRowPostPaintEventHandler dataGridViewRowPostPaintEventHandler = new DataGridViewRowPostPaintEventHandler(this.dgvPurchases_RowPostPaint);
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgvPurchases_CellContentClick);
				DataGridView dataGridView = this._dgvPurchases;
				if (dataGridView != null)
				{
					dataGridView.RowPostPaint -= dataGridViewRowPostPaintEventHandler;
					dataGridView.CellContentClick -= dataGridViewCellEventHandler;
				}
				this._dgvPurchases = value;
				dataGridView = this._dgvPurchases;
				if (dataGridView != null)
				{
					dataGridView.RowPostPaint += dataGridViewRowPostPaintEventHandler;
					dataGridView.CellContentClick += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x060011AF RID: 4527 RVA: 0x000AA606 File Offset: 0x000A8806
		// (set) Token: 0x060011B0 RID: 4528 RVA: 0x000AA610 File Offset: 0x000A8810
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x060011B1 RID: 4529 RVA: 0x000AA619 File Offset: 0x000A8819
		// (set) Token: 0x060011B2 RID: 4530 RVA: 0x000AA623 File Offset: 0x000A8823
		internal virtual Label lblinfo
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x060011B3 RID: 4531 RVA: 0x000AA62C File Offset: 0x000A882C
		// (set) Token: 0x060011B4 RID: 4532 RVA: 0x000AA636 File Offset: 0x000A8836
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x060011B5 RID: 4533 RVA: 0x000AA63F File Offset: 0x000A883F
		// (set) Token: 0x060011B6 RID: 4534 RVA: 0x000AA649 File Offset: 0x000A8849
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x060011B7 RID: 4535 RVA: 0x000AA652 File Offset: 0x000A8852
		// (set) Token: 0x060011B8 RID: 4536 RVA: 0x000AA65C File Offset: 0x000A885C
		internal virtual ComboBox cboBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060011B9 RID: 4537 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label1_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x060011BA RID: 4538 RVA: 0x000AA668 File Offset: 0x000A8868
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.LoadPurchases(Conversions.ToInteger(this.DTday.Value.ToString("yyyyMMdd")));
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying purchases. Detail: " + ex.Message);
			}
		}

		// Token: 0x060011BB RID: 4539 RVA: 0x000AA6D4 File Offset: 0x000A88D4
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

		// Token: 0x060011BC RID: 4540 RVA: 0x000AA774 File Offset: 0x000A8974
		private void LoadPurchases(int theday)
		{
			this.dgvPurchases.Columns.Clear();
			this.lblinfo.Text = "...";
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectPurchasesForDay";
			sqlCommand.Parameters.AddWithValue("theday", theday);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", this.cboBranch.Text);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				this.dgvPurchases.DataSource = dataTable;
				this.dgvPurchases.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				this.dgvPurchases.Columns["Product_ID"].DefaultCellStyle.BackColor = Color.LightGray;
				this.dgvPurchases.Columns["Product_ID"].ReadOnly = true;
				this.dgvPurchases.Columns["EntryNo"].DefaultCellStyle.BackColor = Color.LightGray;
				this.dgvPurchases.Columns["EntryNo"].ReadOnly = true;
				this.dgvPurchases.Columns["Unit_Cost"].ReadOnly = true;
				this.dgvPurchases.Columns["Unit_Cost"].DefaultCellStyle.BackColor = Color.LightGray;
				this.dgvPurchases.Columns["Unit_Selling_Price"].ReadOnly = true;
				this.dgvPurchases.Columns["Unit_Selling_Price"].DefaultCellStyle.BackColor = Color.LightGray;
				DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
				dataGridViewButtonColumn.HeaderText = "Delete Transaction";
				dataGridViewButtonColumn.Text = "Delete";
				dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
				this.dgvPurchases.Columns.Insert(7, dataGridViewButtonColumn);
			}
			else
			{
				this.lblinfo.Text = "No purchases on chosen day.";
				DataTable dataTable2 = new DataTable();
				this.dgvPurchases.DataSource = dataTable2;
			}
		}

		// Token: 0x060011BD RID: 4541 RVA: 0x000AA9D0 File Offset: 0x000A8BD0
		private void SaveChanges(int productid, string desc, string @ref, decimal quantity, double unitcost, double sellingprice, int entryno)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "UpdatePurchasesChanges";
			sqlCommand.Parameters.AddWithValue("productid", productid);
			sqlCommand.Parameters.AddWithValue("productdesc", desc);
			sqlCommand.Parameters.AddWithValue("ref", @ref);
			sqlCommand.Parameters.AddWithValue("quantity", RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(quantity), 0, quantity)));
			sqlCommand.Parameters.AddWithValue("unitcost", RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(unitcost), 0, unitcost)));
			sqlCommand.Parameters.AddWithValue("sellingprice", RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(sellingprice), 0, sellingprice)));
			sqlCommand.Parameters.AddWithValue("EntryNo", entryno);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", this.cboBranch.Text);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x060011BE RID: 4542 RVA: 0x000AAB6C File Offset: 0x000A8D6C
		private void dgvPurchases_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
		{
			try
			{
				foreach (object obj in ((IEnumerable)this.dgvPurchases.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					bool flag = dataGridViewRow.Index % 2 > 0;
					if (flag)
					{
						dataGridViewRow.DefaultCellStyle.BackColor = Color.LightBlue;
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

		// Token: 0x060011BF RID: 4543 RVA: 0x000AABF0 File Offset: 0x000A8DF0
		private void dgvPurchases_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					int num = Conversions.ToInteger(this.dgvPurchases.Rows[e.RowIndex].Cells["EntryNo"].Value);
					this.DeletePurchase(MyProject.Forms.Form1.coid, this.cboBranch.Text, num);
					MessageBox.Show("Transaction Deleted.");
					this.LoadPurchases(Conversions.ToInteger(this.DTday.Value.ToString("yyyyMMdd")));
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving details. Details: " + ex.Message);
			}
		}

		// Token: 0x060011C0 RID: 4544 RVA: 0x000AACF0 File Offset: 0x000A8EF0
		private void EditStockPurchases_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadBranches();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x060011C1 RID: 4545 RVA: 0x000AAD40 File Offset: 0x000A8F40
		private void DeletePurchase(int coid, string branch, int entryno)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "DeletePurchase";
			sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
			sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
			sqlCommand.Parameters.AddWithValue("trandate", Conversions.ToInteger(DateTime.Today.ToString("yyyyMMdd")));
			sqlCommand.Parameters.AddWithValue("EntryNo", entryno);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x04000854 RID: 2132
		private string _cnn;
	}
}
