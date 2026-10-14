using System;
using System.Collections;
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
	// Token: 0x0200001D RID: 29
	[DesignerGenerated]
	public partial class Categories : Form
	{
		// Token: 0x0600054C RID: 1356 RVA: 0x000349E0 File Offset: 0x00032BE0
		public Categories()
		{
			base.Load += this.Categories_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.dat = new DataTable();
			this.InitializeComponent();
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x0600054F RID: 1359 RVA: 0x00034DF5 File Offset: 0x00032FF5
		// (set) Token: 0x06000550 RID: 1360 RVA: 0x00034DFF File Offset: 0x00032FFF
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000551 RID: 1361 RVA: 0x00034E08 File Offset: 0x00033008
		// (set) Token: 0x06000552 RID: 1362 RVA: 0x00034E14 File Offset: 0x00033014
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

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000553 RID: 1363 RVA: 0x00034E57 File Offset: 0x00033057
		// (set) Token: 0x06000554 RID: 1364 RVA: 0x00034E61 File Offset: 0x00033061
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000555 RID: 1365 RVA: 0x00034E6A File Offset: 0x0003306A
		// (set) Token: 0x06000556 RID: 1366 RVA: 0x00034E74 File Offset: 0x00033074
		internal virtual DataGridView DataGridView1
		{
			[CompilerGenerated]
			get
			{
				return this._DataGridView1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DataGridView1_CellEndEdit);
				DataGridView dataGridView = this._DataGridView1;
				if (dataGridView != null)
				{
					dataGridView.CellEndEdit -= dataGridViewCellEventHandler;
				}
				this._DataGridView1 = value;
				dataGridView = this._DataGridView1;
				if (dataGridView != null)
				{
					dataGridView.CellEndEdit += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000557 RID: 1367 RVA: 0x00034EB7 File Offset: 0x000330B7
		// (set) Token: 0x06000558 RID: 1368 RVA: 0x00034EC1 File Offset: 0x000330C1
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x00034ECC File Offset: 0x000330CC
		private void LoadCategories()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchCategories";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(this.dat);
			this.DataGridView1.DataSource = this.dat;
			this.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.DataGridView1.Columns["CatID"].ReadOnly = true;
			this.DataGridView1.Columns["CatID"].DefaultCellStyle.BackColor = Color.LightGray;
			this.DataGridView1.Columns["CatID"].HeaderText = "ID";
			this.DataGridView1.Columns["CatDesc"].HeaderText = "Category Name";
			this.DataGridView1.Columns["Uploaded"].Visible = false;
			this.DataGridView1.Columns["coid"].DefaultCellStyle.BackColor = Color.LightGray;
			this.DataGridView1.Columns["coid"].ReadOnly = true;
			this.DataGridView1.Columns["pic"].Visible = false;
			this.DataGridView1.Columns["KDU"].Visible = false;
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x00035070 File Offset: 0x00033270
		private void savechanges()
		{
			try
			{
				foreach (object obj in this.dat.Rows)
				{
					DataRow dataRow = (DataRow)obj;
					dataRow["Uploaded"] = 0;
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
			bool flag = this.dat.Rows.Count > 0;
			if (flag)
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "FetchCategories";
				sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
				DataTable dataTable = new DataTable();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
				sqlDataAdapter.Fill(dataTable);
				sqlDataAdapter.Update(this.dat);
			}
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x00035180 File Offset: 0x00033380
		private void Categories_Load(object sender, EventArgs e)
		{
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.StartPosition = FormStartPosition.CenterParent;
			bool isbranch = MyProject.Forms.Form1.isbranch;
			if (isbranch)
			{
				MessageBox.Show("You are logged into a branch and cannot create new categories from there.");
				base.Dispose();
			}
			this.LoadCategories();
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x000351D4 File Offset: 0x000333D4
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.savechanges();
				MessageBox.Show("Categories saved.");
				base.Dispose();
			}
			catch (SqlException ex)
			{
				bool flag = ex.Number == 2627;
				if (flag)
				{
					MessageBox.Show("Please enter different categories.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
			catch (Exception ex2)
			{
				MessageBox.Show("Error updating categories data. Retry. Detailed error: " + ex2.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x00035280 File Offset: 0x00033480
		private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				dataGridView.Rows[e.RowIndex].Cells["coid"].Value = MyProject.Forms.Form1.coid;
				dataGridView.Rows[e.RowIndex].Cells["uploaded"].Value = 0;
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0400026B RID: 619
		private string _cnn;

		// Token: 0x0400026C RID: 620
		private DataTable dat;
	}
}
