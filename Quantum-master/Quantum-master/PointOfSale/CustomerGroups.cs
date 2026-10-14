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
	// Token: 0x02000037 RID: 55
	[DesignerGenerated]
	public partial class CustomerGroups : Form
	{
		// Token: 0x06000C24 RID: 3108 RVA: 0x00079648 File Offset: 0x00077848
		public CustomerGroups()
		{
			base.Load += this.CustomerGroups_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.dat = new DataTable();
			this.InitializeComponent();
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06000C27 RID: 3111 RVA: 0x00079A58 File Offset: 0x00077C58
		// (set) Token: 0x06000C28 RID: 3112 RVA: 0x00079A62 File Offset: 0x00077C62
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06000C29 RID: 3113 RVA: 0x00079A6B File Offset: 0x00077C6B
		// (set) Token: 0x06000C2A RID: 3114 RVA: 0x00079A78 File Offset: 0x00077C78
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

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06000C2B RID: 3115 RVA: 0x00079ABB File Offset: 0x00077CBB
		// (set) Token: 0x06000C2C RID: 3116 RVA: 0x00079AC5 File Offset: 0x00077CC5
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06000C2D RID: 3117 RVA: 0x00079ACE File Offset: 0x00077CCE
		// (set) Token: 0x06000C2E RID: 3118 RVA: 0x00079AD8 File Offset: 0x00077CD8
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

		// Token: 0x06000C2F RID: 3119 RVA: 0x00079B1C File Offset: 0x00077D1C
		private void CustomerGroups_Load(object sender, EventArgs e)
		{
			try
			{
				base.MaximizeBox = false;
				base.MinimizeBox = false;
				base.StartPosition = FormStartPosition.CenterParent;
				this.LoadCustomerGroups();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading Expense Category Form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000C30 RID: 3120 RVA: 0x00079B84 File Offset: 0x00077D84
		private void LoadCustomerGroups()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = "Select * from CustomerCategoryNames where coid=" + Conversions.ToString(MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(this.dat);
			this.DataGridView1.DataSource = this.dat;
			this.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.DataGridView1.Columns["ID"].Visible = false;
			this.DataGridView1.Columns["Active"].Visible = false;
			this.DataGridView1.Columns["coid"].Visible = false;
		}

		// Token: 0x06000C31 RID: 3121 RVA: 0x00079C5C File Offset: 0x00077E5C
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.SaveChanges();
				MessageBox.Show("Changes saved successfully.");
				base.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving changes. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000C32 RID: 3122 RVA: 0x00079CBC File Offset: 0x00077EBC
		private void SaveChanges()
		{
			bool flag = this.dat.Rows.Count > 0;
			if (flag)
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.Text;
				sqlCommand.CommandText = "Select * from CustomerCategoryNames where coid=" + Conversions.ToString(MyProject.Forms.Form1.coid);
				DataTable dataTable = new DataTable();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
				sqlDataAdapter.Fill(dataTable);
				sqlDataAdapter.Update(this.dat);
			}
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x00079D54 File Offset: 0x00077F54
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

		// Token: 0x040005C4 RID: 1476
		private string _cnn;

		// Token: 0x040005C5 RID: 1477
		private DataTable dat;
	}
}
