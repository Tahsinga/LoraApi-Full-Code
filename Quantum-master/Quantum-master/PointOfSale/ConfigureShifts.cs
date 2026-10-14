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
	// Token: 0x0200002D RID: 45
	[DesignerGenerated]
	public partial class ConfigureShifts : Form
	{
		// Token: 0x060008A2 RID: 2210 RVA: 0x00053B24 File Offset: 0x00051D24
		public ConfigureShifts()
		{
			base.Load += this.ConfigureShifts_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.dat = new DataTable();
			this.InitializeComponent();
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x060008A5 RID: 2213 RVA: 0x00053EB9 File Offset: 0x000520B9
		// (set) Token: 0x060008A6 RID: 2214 RVA: 0x00053EC3 File Offset: 0x000520C3
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x060008A7 RID: 2215 RVA: 0x00053ECC File Offset: 0x000520CC
		// (set) Token: 0x060008A8 RID: 2216 RVA: 0x00053ED6 File Offset: 0x000520D6
		internal virtual DataGridView DataGridView1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x060008A9 RID: 2217 RVA: 0x00053EDF File Offset: 0x000520DF
		// (set) Token: 0x060008AA RID: 2218 RVA: 0x00053EEC File Offset: 0x000520EC
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

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x060008AB RID: 2219 RVA: 0x00053F2F File Offset: 0x0005212F
		// (set) Token: 0x060008AC RID: 2220 RVA: 0x00053F39 File Offset: 0x00052139
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x00053F42 File Offset: 0x00052142
		private void ConfigureShifts_Load(object sender, EventArgs e)
		{
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.StartPosition = FormStartPosition.CenterParent;
			this.LoadShifts();
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x00053F64 File Offset: 0x00052164
		private void LoadShifts()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectAllShifts";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(this.dat);
			this.DataGridView1.DataSource = this.dat;
			this.DataGridView1.Columns["Entryno"].Visible = false;
			this.DataGridView1.Columns["coid"].Visible = false;
			this.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x0005402C File Offset: 0x0005222C
		private void SaveChanges()
		{
			bool flag = this.dat.Rows.Count > 0;
			if (flag)
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "SelectAllShifts";
				sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
				DataTable dataTable = new DataTable();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
				sqlDataAdapter.Fill(dataTable);
				sqlDataAdapter.Update(this.dat);
			}
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x000540D0 File Offset: 0x000522D0
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.SaveChanges();
				MessageBox.Show("Changes saved succesfully.");
			}
			catch (SqlException ex)
			{
				bool flag = ex.Number == 2627;
				if (flag)
				{
					MessageBox.Show("Shift already entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
			catch (Exception ex2)
			{
				MessageBox.Show("Error updating data. Retry. Detailed error: " + ex2.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x04000411 RID: 1041
		private string _cnn;

		// Token: 0x04000412 RID: 1042
		private DataTable dat;
	}
}
