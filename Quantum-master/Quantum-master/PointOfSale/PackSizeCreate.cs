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
	// Token: 0x02000085 RID: 133
	[DesignerGenerated]
	public partial class PackSizeCreate : Form
	{
		// Token: 0x06001EB5 RID: 7861 RVA: 0x00112140 File Offset: 0x00110340
		public PackSizeCreate()
		{
			base.Load += this.PackSizeCreate_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.dat = new DataTable();
			this.InitializeComponent();
		}

		// Token: 0x17000B43 RID: 2883
		// (get) Token: 0x06001EB8 RID: 7864 RVA: 0x001124E6 File Offset: 0x001106E6
		// (set) Token: 0x06001EB9 RID: 7865 RVA: 0x001124F0 File Offset: 0x001106F0
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B44 RID: 2884
		// (get) Token: 0x06001EBA RID: 7866 RVA: 0x001124F9 File Offset: 0x001106F9
		// (set) Token: 0x06001EBB RID: 7867 RVA: 0x00112504 File Offset: 0x00110704
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

		// Token: 0x17000B45 RID: 2885
		// (get) Token: 0x06001EBC RID: 7868 RVA: 0x00112547 File Offset: 0x00110747
		// (set) Token: 0x06001EBD RID: 7869 RVA: 0x00112554 File Offset: 0x00110754
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

		// Token: 0x17000B46 RID: 2886
		// (get) Token: 0x06001EBE RID: 7870 RVA: 0x00112597 File Offset: 0x00110797
		// (set) Token: 0x06001EBF RID: 7871 RVA: 0x001125A1 File Offset: 0x001107A1
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06001EC0 RID: 7872 RVA: 0x001125AC File Offset: 0x001107AC
		private void PackSizeCreate_Load(object sender, EventArgs e)
		{
			try
			{
				base.MaximizeBox = false;
				base.MinimizeBox = false;
				base.StartPosition = FormStartPosition.CenterParent;
				this.LoadPackSizes();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001EC1 RID: 7873 RVA: 0x00112614 File Offset: 0x00110814
		private void LoadPackSizes()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "PackSizesFetch";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(this.dat);
			this.DataGridView1.DataSource = this.dat;
			this.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.DataGridView1.Columns["entryno"].Visible = false;
			this.DataGridView1.Columns["coid"].Visible = false;
		}

		// Token: 0x06001EC2 RID: 7874 RVA: 0x001126DC File Offset: 0x001108DC
		private void SaveChanges()
		{
			bool flag = this.dat.Rows.Count > 0;
			if (flag)
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "PackSizesFetch";
				sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
				DataTable dataTable = new DataTable();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
				sqlDataAdapter.Fill(dataTable);
				sqlDataAdapter.Update(this.dat);
			}
		}

		// Token: 0x06001EC3 RID: 7875 RVA: 0x00112780 File Offset: 0x00110980
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.SaveChanges();
				MessageBox.Show("Pack Sizes saved.");
				base.Dispose();
			}
			catch (SqlException ex)
			{
				bool flag = ex.Number == 2627;
				if (flag)
				{
					MessageBox.Show("Please enter different pack sizes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
			catch (Exception ex2)
			{
				MessageBox.Show("Error updating pack size data. Retry. Detailed error: " + ex2.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x06001EC4 RID: 7876 RVA: 0x0011282C File Offset: 0x00110A2C
		private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				dataGridView.Rows[e.RowIndex].Cells["coid"].Value = MyProject.Forms.Form1.coid;
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x04000E98 RID: 3736
		private string _cnn;

		// Token: 0x04000E99 RID: 3737
		private DataTable dat;
	}
}
