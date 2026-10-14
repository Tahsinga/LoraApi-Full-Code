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
	// Token: 0x02000008 RID: 8
	[DesignerGenerated]
	public partial class AdditionalSettings : Form
	{
		// Token: 0x06000156 RID: 342 RVA: 0x0000D1E4 File Offset: 0x0000B3E4
		public AdditionalSettings()
		{
			base.Load += this.AdditionalSettings_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.dat = new DataTable();
			this.InitializeComponent();
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000159 RID: 345 RVA: 0x0000D4CC File Offset: 0x0000B6CC
		// (set) Token: 0x0600015A RID: 346 RVA: 0x0000D4D6 File Offset: 0x0000B6D6
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600015B RID: 347 RVA: 0x0000D4DF File Offset: 0x0000B6DF
		// (set) Token: 0x0600015C RID: 348 RVA: 0x0000D4EC File Offset: 0x0000B6EC
		internal virtual DataGridView dgvAdd
		{
			[CompilerGenerated]
			get
			{
				return this._dgvAdd;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgvAdd_CellEndEdit);
				DataGridView dataGridView = this._dgvAdd;
				if (dataGridView != null)
				{
					dataGridView.CellEndEdit -= dataGridViewCellEventHandler;
				}
				this._dgvAdd = value;
				dataGridView = this._dgvAdd;
				if (dataGridView != null)
				{
					dataGridView.CellEndEdit += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600015D RID: 349 RVA: 0x0000D52F File Offset: 0x0000B72F
		// (set) Token: 0x0600015E RID: 350 RVA: 0x0000D53C File Offset: 0x0000B73C
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

		// Token: 0x0600015F RID: 351 RVA: 0x0000D580 File Offset: 0x0000B780
		private void LoadAdds()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = "select * from AdditionalSettings where coid=" + Conversions.ToString(MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(this.dat);
			this.dgvAdd.DataSource = this.dat;
			this.dgvAdd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvAdd.Columns["EntryNo"].ReadOnly = true;
			this.dgvAdd.Columns["EntryNo"].DefaultCellStyle.BackColor = Color.LightGray;
			this.dgvAdd.Columns["Branch"].ReadOnly = true;
			this.dgvAdd.Columns["Branch"].DefaultCellStyle.BackColor = Color.LightGray;
			this.dgvAdd.Columns["coid"].ReadOnly = true;
			this.dgvAdd.Columns["coid"].DefaultCellStyle.BackColor = Color.LightGray;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0000D6C8 File Offset: 0x0000B8C8
		private void AdditionalSettings_Load(object sender, EventArgs e)
		{
			try
			{
				base.StartPosition = FormStartPosition.CenterParent;
				this.LoadAdds();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Details: " + ex.Message);
			}
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0000D720 File Offset: 0x0000B920
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.SaveChanges();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving changes. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000162 RID: 354 RVA: 0x0000D770 File Offset: 0x0000B970
		private void SaveChanges()
		{
			bool flag = this.dat.Rows.Count > 0;
			if (flag)
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.Text;
				sqlCommand.CommandText = "Select * from AdditionalSettings where coid=" + Conversions.ToString(MyProject.Forms.Form1.coid);
				DataTable dataTable = new DataTable();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
				sqlDataAdapter.Fill(dataTable);
				sqlDataAdapter.Update(this.dat);
			}
		}

		// Token: 0x06000163 RID: 355 RVA: 0x0000D808 File Offset: 0x0000BA08
		private void dgvAdd_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			DataGridView dataGridView = (DataGridView)sender;
			dataGridView.Rows[e.RowIndex].Cells["coid"].Value = MyProject.Forms.Form1.coid;
		}

		// Token: 0x04000094 RID: 148
		private string _cnn;

		// Token: 0x04000095 RID: 149
		private DataTable dat;
	}
}
