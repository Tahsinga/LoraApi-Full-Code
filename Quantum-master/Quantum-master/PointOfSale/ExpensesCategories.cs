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
	// Token: 0x02000059 RID: 89
	[DesignerGenerated]
	public partial class ExpensesCategories : Form
	{
		// Token: 0x060012A1 RID: 4769 RVA: 0x000B2AFC File Offset: 0x000B0CFC
		public ExpensesCategories()
		{
			base.Load += this.ExpensesCategories_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.dat = new DataTable();
			this.InitializeComponent();
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x060012A4 RID: 4772 RVA: 0x000B2E9C File Offset: 0x000B109C
		// (set) Token: 0x060012A5 RID: 4773 RVA: 0x000B2EA6 File Offset: 0x000B10A6
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x060012A6 RID: 4774 RVA: 0x000B2EAF File Offset: 0x000B10AF
		// (set) Token: 0x060012A7 RID: 4775 RVA: 0x000B2EBC File Offset: 0x000B10BC
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

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x060012A8 RID: 4776 RVA: 0x000B2EFF File Offset: 0x000B10FF
		// (set) Token: 0x060012A9 RID: 4777 RVA: 0x000B2F0C File Offset: 0x000B110C
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

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x060012AA RID: 4778 RVA: 0x000B2F4F File Offset: 0x000B114F
		// (set) Token: 0x060012AB RID: 4779 RVA: 0x000B2F59 File Offset: 0x000B1159
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060012AC RID: 4780 RVA: 0x000B2F64 File Offset: 0x000B1164
		private void LoadExpenseCategories()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetExpensesCategories";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(this.dat);
			this.DataGridView1.DataSource = this.dat;
			this.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.DataGridView1.Columns["ExpenseCategoryID"].Visible = false;
			this.DataGridView1.Columns["Uploaded"].Visible = false;
			this.DataGridView1.Columns["ExpenseCategoryDesc"].HeaderText = "Expense Category Name";
			this.DataGridView1.Columns["coid"].DefaultCellStyle.BackColor = Color.LightGray;
			this.DataGridView1.Columns["coid"].Visible = false;
		}

		// Token: 0x060012AD RID: 4781 RVA: 0x000B308C File Offset: 0x000B128C
		private void savechanges()
		{
			bool flag = this.dat.Rows.Count > 0;
			if (flag)
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "GetExpensesCategories";
				sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
				DataTable dataTable = new DataTable();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
				sqlDataAdapter.Fill(dataTable);
				sqlDataAdapter.Update(this.dat);
			}
		}

		// Token: 0x060012AE RID: 4782 RVA: 0x000B3130 File Offset: 0x000B1330
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

		// Token: 0x060012AF RID: 4783 RVA: 0x000B31A4 File Offset: 0x000B13A4
		private void ExpensesCategories_Load(object sender, EventArgs e)
		{
			try
			{
				base.MaximizeBox = false;
				base.MinimizeBox = false;
				base.StartPosition = FormStartPosition.CenterParent;
				this.LoadExpenseCategories();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading Expense Category Form. Detail: " + ex.Message);
			}
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x000B320C File Offset: 0x000B140C
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.savechanges();
				MessageBox.Show("Changes saved successfully.");
				base.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving changes. Detail: " + ex.Message);
			}
		}

		// Token: 0x040008C0 RID: 2240
		private string _cnn;

		// Token: 0x040008C1 RID: 2241
		private DataTable dat;
	}
}
