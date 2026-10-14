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
	// Token: 0x0200006B RID: 107
	[DesignerGenerated]
	public partial class Logins : Form
	{
		// Token: 0x0600166D RID: 5741 RVA: 0x000D0CB2 File Offset: 0x000CEEB2
		public Logins()
		{
			base.Load += this.Logins_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x06001670 RID: 5744 RVA: 0x000D0E68 File Offset: 0x000CF068
		// (set) Token: 0x06001671 RID: 5745 RVA: 0x000D0E74 File Offset: 0x000CF074
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
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
				DataGridView dataGridView = this._DataGridView1;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick -= dataGridViewCellEventHandler;
				}
				this._DataGridView1 = value;
				dataGridView = this._DataGridView1;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x06001672 RID: 5746 RVA: 0x000D0EB8 File Offset: 0x000CF0B8
		private void Logins_Load(object sender, EventArgs e)
		{
			try
			{
				this.Loadlogins();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001673 RID: 5747 RVA: 0x000D0F08 File Offset: 0x000CF108
		private void Loadlogins()
		{
			this.DataGridView1.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectAllLogins";
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			this.DataGridView1.DataSource = dataTable;
			this.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.DataGridView1.Columns["coid"].ReadOnly = true;
			this.DataGridView1.Columns["branch"].ReadOnly = true;
			this.DataGridView1.Columns["username"].ReadOnly = true;
			this.DataGridView1.Columns["coid"].DefaultCellStyle.BackColor = Color.LightGray;
			this.DataGridView1.Columns["branch"].DefaultCellStyle.BackColor = Color.LightGray;
			this.DataGridView1.Columns["username"].DefaultCellStyle.BackColor = Color.LightGray;
			DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
			dataGridViewButtonColumn.HeaderText = "Log Off";
			dataGridViewButtonColumn.Text = "Log Off";
			dataGridViewButtonColumn.Name = "Log Off";
			dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
			this.DataGridView1.Columns.Add(dataGridViewButtonColumn);
		}

		// Token: 0x06001674 RID: 5748 RVA: 0x000D108C File Offset: 0x000CF28C
		private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					bool flag2 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "Log Off", false) == 0;
					if (flag2)
					{
						SqlConnection sqlConnection = new SqlConnection(this._cnn);
						SqlCommand sqlCommand = sqlConnection.CreateCommand();
						sqlCommand.CommandType = CommandType.StoredProcedure;
						sqlCommand.CommandText = "EffectLogoff";
						sqlCommand.Parameters.AddWithValue("coid", RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[e.RowIndex].Cells["coid"].Value));
						sqlCommand.Parameters.AddWithValue("branch", RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[e.RowIndex].Cells["branch"].Value));
						sqlCommand.Parameters.AddWithValue("username", RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[e.RowIndex].Cells["username"].Value));
						using (sqlConnection)
						{
							sqlConnection.Open();
							sqlCommand.ExecuteNonQuery();
							sqlConnection.Close();
						}
						MessageBox.Show("User: " + this.DataGridView1.Rows[e.RowIndex].Cells["username"].Value.ToString() + ", logged off successfully.");
						this.Loadlogins();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error on grid. Detail: " + ex.Message);
			}
		}

		// Token: 0x04000B33 RID: 2867
		private string _cnn;
	}
}
