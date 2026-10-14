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
	// Token: 0x02000067 RID: 103
	[DesignerGenerated]
	public partial class KDUs : Form
	{
		// Token: 0x060015F1 RID: 5617 RVA: 0x000CCCD0 File Offset: 0x000CAED0
		public KDUs()
		{
			base.Load += this.KDUs_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.dat = new DataTable();
			this.InitializeComponent();
		}

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x060015F4 RID: 5620 RVA: 0x000CD0ED File Offset: 0x000CB2ED
		// (set) Token: 0x060015F5 RID: 5621 RVA: 0x000CD0F7 File Offset: 0x000CB2F7
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x060015F6 RID: 5622 RVA: 0x000CD100 File Offset: 0x000CB300
		// (set) Token: 0x060015F7 RID: 5623 RVA: 0x000CD10C File Offset: 0x000CB30C
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

		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x060015F8 RID: 5624 RVA: 0x000CD14F File Offset: 0x000CB34F
		// (set) Token: 0x060015F9 RID: 5625 RVA: 0x000CD159 File Offset: 0x000CB359
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x060015FA RID: 5626 RVA: 0x000CD162 File Offset: 0x000CB362
		// (set) Token: 0x060015FB RID: 5627 RVA: 0x000CD16C File Offset: 0x000CB36C
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x060015FC RID: 5628 RVA: 0x000CD175 File Offset: 0x000CB375
		// (set) Token: 0x060015FD RID: 5629 RVA: 0x000CD17F File Offset: 0x000CB37F
		internal virtual DataGridView dgvKDUs
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060015FE RID: 5630 RVA: 0x000CD188 File Offset: 0x000CB388
		private void KDUs_Load(object sender, EventArgs e)
		{
			try
			{
				base.StartPosition = FormStartPosition.CenterParent;
				this.LoadKDUs();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x060015FF RID: 5631 RVA: 0x000CD1E0 File Offset: 0x000CB3E0
		private void LoadKDUs()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = "Select * from KitchenDisplayUnits";
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(this.dat);
			this.dgvKDUs.DataSource = this.dat;
			this.dgvKDUs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvKDUs.Columns["Entryno"].Visible = false;
		}

		// Token: 0x06001600 RID: 5632 RVA: 0x000CD268 File Offset: 0x000CB468
		private void saveChanges()
		{
			bool flag = this.dat.Rows.Count > 0;
			if (flag)
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.Text;
				sqlCommand.CommandText = "Select * from KitchenDisplayUnits";
				DataTable dataTable = new DataTable();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
				sqlDataAdapter.Fill(dataTable);
				sqlDataAdapter.Update(this.dat);
			}
		}

		// Token: 0x06001601 RID: 5633 RVA: 0x000CD2E4 File Offset: 0x000CB4E4
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.saveChanges();
				MessageBox.Show("Changes saved successfully.");
				base.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving changes. Detail: " + ex.Message);
			}
		}

		// Token: 0x04000AFF RID: 2815
		private string _cnn;

		// Token: 0x04000B00 RID: 2816
		private DataTable dat;
	}
}
