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
	// Token: 0x0200008B RID: 139
	[DesignerGenerated]
	public partial class PendingInvoices : Form
	{
		// Token: 0x06001F8F RID: 8079 RVA: 0x001199AC File Offset: 0x00117BAC
		public PendingInvoices()
		{
			base.Load += this.PendingInvoices_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.dat1 = new DataTable();
			this.InitializeComponent();
		}

		// Token: 0x17000B8A RID: 2954
		// (get) Token: 0x06001F92 RID: 8082 RVA: 0x00119FD4 File Offset: 0x001181D4
		// (set) Token: 0x06001F93 RID: 8083 RVA: 0x00119FDE File Offset: 0x001181DE
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B8B RID: 2955
		// (get) Token: 0x06001F94 RID: 8084 RVA: 0x00119FE7 File Offset: 0x001181E7
		// (set) Token: 0x06001F95 RID: 8085 RVA: 0x00119FF4 File Offset: 0x001181F4
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

		// Token: 0x17000B8C RID: 2956
		// (get) Token: 0x06001F96 RID: 8086 RVA: 0x0011A037 File Offset: 0x00118237
		// (set) Token: 0x06001F97 RID: 8087 RVA: 0x0011A041 File Offset: 0x00118241
		internal virtual DateTimePicker dtDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B8D RID: 2957
		// (get) Token: 0x06001F98 RID: 8088 RVA: 0x0011A04A File Offset: 0x0011824A
		// (set) Token: 0x06001F99 RID: 8089 RVA: 0x0011A054 File Offset: 0x00118254
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B8E RID: 2958
		// (get) Token: 0x06001F9A RID: 8090 RVA: 0x0011A05D File Offset: 0x0011825D
		// (set) Token: 0x06001F9B RID: 8091 RVA: 0x0011A068 File Offset: 0x00118268
		internal virtual DataGridView dgvPending
		{
			[CompilerGenerated]
			get
			{
				return this._dgvPending;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgvPending_CellContentClick);
				DataGridView dataGridView = this._dgvPending;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick -= dataGridViewCellEventHandler;
				}
				this._dgvPending = value;
				dataGridView = this._dgvPending;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x17000B8F RID: 2959
		// (get) Token: 0x06001F9C RID: 8092 RVA: 0x0011A0AB File Offset: 0x001182AB
		// (set) Token: 0x06001F9D RID: 8093 RVA: 0x0011A0B8 File Offset: 0x001182B8
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

		// Token: 0x17000B90 RID: 2960
		// (get) Token: 0x06001F9E RID: 8094 RVA: 0x0011A0FB File Offset: 0x001182FB
		// (set) Token: 0x06001F9F RID: 8095 RVA: 0x0011A108 File Offset: 0x00118308
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

		// Token: 0x06001FA0 RID: 8096 RVA: 0x0011A14C File Offset: 0x0011834C
		private void PendingInvoices_Load(object sender, EventArgs e)
		{
			try
			{
				this.GetPending(Convert.ToInt32(this.dtDate.Value.ToString("yyyyMMdd")));
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001FA1 RID: 8097 RVA: 0x0011A1B8 File Offset: 0x001183B8
		private void GetPending(int datesaved)
		{
			this.dgvPending.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "PendingInvoicesGetList";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			sqlCommand.Parameters.AddWithValue("datesaved", datesaved);
			sqlCommand.Parameters.AddWithValue("savedby", MyProject.Forms.Form1.username);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			DataView dataView = new DataView(dataTable, "isreopened = 'false' ", "Entryno Desc", DataViewRowState.CurrentRows);
			bool flag = dataView.Table.Rows.Count > 0;
			if (flag)
			{
				this.dgvPending.DataSource = dataView;
				this.dgvPending.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				this.dgvPending.Columns["coid"].Visible = false;
				this.dgvPending.Columns["branch"].Visible = false;
				this.dgvPending.Columns["EntryNo"].Visible = false;
				this.dgvPending.Columns["ReopenedDate"].Visible = false;
				this.dgvPending.Columns["consultant"].Visible = false;
				this.dgvPending.Columns["paymethodid"].Visible = false;
				this.dgvPending.Columns["hscode"].Visible = false;
				this.dgvPending.Columns["isreopened"].Visible = false;
				this.dgvPending.Columns["reopenedby"].Visible = false;
				DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
				dataGridViewButtonColumn.HeaderText = "Open Invoice";
				dataGridViewButtonColumn.Text = "OPEN";
				dataGridViewButtonColumn.Name = "OPEN";
				dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
				this.dgvPending.Columns.Insert(6, dataGridViewButtonColumn);
			}
			else
			{
				this.dgvPending.DataSource = dataTable;
			}
		}

		// Token: 0x06001FA2 RID: 8098 RVA: 0x0011A438 File Offset: 0x00118638
		private void dgvPending_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					bool flag2 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "OPEN", false) == 0;
					if (flag2)
					{
						MyProject.Forms.Form1.custid = Conversions.ToString(dataGridView.Rows[e.RowIndex].Cells["CustomerID"].Value);
						MyProject.Forms.Form1.PendingItemsDAT = this.GetPendingItems(Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataGridView.Rows[e.RowIndex].Cells["entryno"].Value)), MyProject.Forms.Form1.branch, MyProject.Forms.Form1.coid, dataGridView.Rows[e.RowIndex].Cells["ref"].Value.ToString());
						MyProject.Forms.Form1.pendinginv_paymethodid = Conversions.ToString(dataGridView.Rows[e.RowIndex].Cells["paymethodid"].Value);
						MyProject.Forms.Form1.ref2 = Conversions.ToString(dataGridView.Rows[e.RowIndex].Cells["ref2"].Value);
						MyProject.Forms.Form1.pendinginvoice_entryno = Conversions.ToInteger(dataGridView.Rows[e.RowIndex].Cells["entryno"].Value);
						MyProject.Forms.Form1.pendinginvoice_ref = Conversions.ToInteger(dataGridView.Rows[e.RowIndex].Cells["ref"].Value);
						base.Dispose();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error opening sales form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001FA3 RID: 8099 RVA: 0x0011A6A0 File Offset: 0x001188A0
		private DataTable GetPendingItems(int entryno, string branch, int coid, string @ref)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "PendingInvoicesGetDetails";
			sqlCommand.Parameters.AddWithValue("entryno", entryno);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("ref", @ref);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x06001FA4 RID: 8100 RVA: 0x0011A748 File Offset: 0x00118948
		private void UpdatePending(int entryno, int reopeneddate, string reopenedby, string branch, int coid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "PendingInvoicesUpdate";
			sqlCommand.Parameters.AddWithValue("entryno", entryno);
			sqlCommand.Parameters.AddWithValue("reopeneddate", reopeneddate);
			sqlCommand.Parameters.AddWithValue("reopenedby", reopenedby);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06001FA5 RID: 8101 RVA: 0x0011A820 File Offset: 0x00118A20
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.GetPending(Convert.ToInt32(this.dtDate.Value.ToString("yyyyMMdd")));
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying pending quotations. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001FA6 RID: 8102 RVA: 0x0011A88C File Offset: 0x00118A8C
		private void Button2_Click(object sender, EventArgs e)
		{
			this.dgvPending.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "PendingInvoicesGetList";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			sqlCommand.Parameters.AddWithValue("datesaved", Conversions.ToInteger(this.dtDate.Value.ToString("yyyyMMdd")));
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			this.dgvPending.DataSource = dataTable;
			this.dgvPending.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvPending.Columns["coid"].Visible = false;
			this.dgvPending.Columns["branch"].Visible = false;
			this.dgvPending.Columns["EntryNo"].Visible = false;
			this.dgvPending.Columns["ReopenedDate"].Visible = false;
			this.dgvPending.Columns["consultant"].Visible = false;
			this.dgvPending.Columns["paymethodid"].Visible = false;
			this.dgvPending.Columns["hscode"].Visible = false;
			this.dgvPending.Columns["isreopened"].Visible = false;
			this.dgvPending.Columns["reopenedby"].Visible = false;
			DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
			dataGridViewButtonColumn.HeaderText = "Open Invoice";
			dataGridViewButtonColumn.Text = "OPEN";
			dataGridViewButtonColumn.Name = "OPEN";
			dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
			this.dgvPending.Columns.Add(dataGridViewButtonColumn);
		}

		// Token: 0x06001FA7 RID: 8103 RVA: 0x0011AAC4 File Offset: 0x00118CC4
		private void Button3_Click(object sender, EventArgs e)
		{
			try
			{
				this.dgvPending.Columns.Clear();
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "PendingInvoicesGetList";
				sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
				sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
				sqlCommand.Parameters.AddWithValue("datesaved", Conversions.ToInteger(this.dtDate.Value.ToString("yyyyMMdd")));
				DataTable dataTable = new DataTable();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				int num = sqlDataAdapter.Fill(dataTable);
				DataView dataView = new DataView(dataTable, "isreopened = 'false' ", "Entryno Desc", DataViewRowState.CurrentRows);
				bool flag = dataView.Table.Rows.Count > 0;
				if (flag)
				{
					this.dgvPending.DataSource = dataView;
					this.dgvPending.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
					this.dgvPending.Columns["coid"].Visible = false;
					this.dgvPending.Columns["branch"].Visible = false;
					this.dgvPending.Columns["EntryNo"].Visible = false;
					this.dgvPending.Columns["ReopenedDate"].Visible = false;
					this.dgvPending.Columns["consultant"].Visible = false;
					this.dgvPending.Columns["paymethodid"].Visible = false;
					this.dgvPending.Columns["hscode"].Visible = false;
					this.dgvPending.Columns["isreopened"].Visible = false;
					this.dgvPending.Columns["reopenedby"].Visible = false;
					DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
					dataGridViewButtonColumn.HeaderText = "Open Invoice";
					dataGridViewButtonColumn.Text = "OPEN";
					dataGridViewButtonColumn.Name = "OPEN";
					dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
					this.dgvPending.Columns.Insert(6, dataGridViewButtonColumn);
				}
				else
				{
					this.dgvPending.DataSource = dataTable;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x04000F06 RID: 3846
		private string _cnn;

		// Token: 0x04000F07 RID: 3847
		private DataTable dat1;
	}
}
