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
	// Token: 0x020001DB RID: 475
	[DesignerGenerated]
	public partial class SetDiscountPercentage : Form
	{
		// Token: 0x06005343 RID: 21315 RVA: 0x003066C8 File Offset: 0x003048C8
		public SetDiscountPercentage()
		{
			base.Load += this.SetDiscountPercentage_Load;
			this.pf = new PublicFunctions();
			this._cnn = MyProject.Forms.Form1.Constring;
			this.DAT = new DataTable();
			this.InitializeComponent();
		}

		// Token: 0x17001DD0 RID: 7632
		// (get) Token: 0x06005346 RID: 21318 RVA: 0x00306B31 File Offset: 0x00304D31
		// (set) Token: 0x06005347 RID: 21319 RVA: 0x00306B3B File Offset: 0x00304D3B
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001DD1 RID: 7633
		// (get) Token: 0x06005348 RID: 21320 RVA: 0x00306B44 File Offset: 0x00304D44
		// (set) Token: 0x06005349 RID: 21321 RVA: 0x00306B4E File Offset: 0x00304D4E
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001DD2 RID: 7634
		// (get) Token: 0x0600534A RID: 21322 RVA: 0x00306B57 File Offset: 0x00304D57
		// (set) Token: 0x0600534B RID: 21323 RVA: 0x00306B64 File Offset: 0x00304D64
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

		// Token: 0x17001DD3 RID: 7635
		// (get) Token: 0x0600534C RID: 21324 RVA: 0x00306BA7 File Offset: 0x00304DA7
		// (set) Token: 0x0600534D RID: 21325 RVA: 0x00306BB1 File Offset: 0x00304DB1
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001DD4 RID: 7636
		// (get) Token: 0x0600534E RID: 21326 RVA: 0x00306BBA File Offset: 0x00304DBA
		// (set) Token: 0x0600534F RID: 21327 RVA: 0x00306BC4 File Offset: 0x00304DC4
		internal virtual DataGridView dgvDiscounts
		{
			[CompilerGenerated]
			get
			{
				return this._dgvDiscounts;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgvDiscounts_CellEndEdit);
				DataGridView dataGridView = this._dgvDiscounts;
				if (dataGridView != null)
				{
					dataGridView.CellEndEdit -= dataGridViewCellEventHandler;
				}
				this._dgvDiscounts = value;
				dataGridView = this._dgvDiscounts;
				if (dataGridView != null)
				{
					dataGridView.CellEndEdit += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x06005350 RID: 21328 RVA: 0x00306C08 File Offset: 0x00304E08
		private void SetDiscountPercentage_Load(object sender, EventArgs e)
		{
			try
			{
				this.DisplayDisc();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading set disc perc form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005351 RID: 21329 RVA: 0x00306C58 File Offset: 0x00304E58
		private void DisplayDisc()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetDiscountPercentageGen";
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
			sqlDataAdapter.Fill(this.DAT);
			this.dgvDiscounts.DataSource = this.DAT;
			this.dgvDiscounts.Columns["coid"].DefaultCellStyle.BackColor = Color.LightGray;
			this.dgvDiscounts.Columns["branch"].DefaultCellStyle.BackColor = Color.LightGray;
			this.dgvDiscounts.Columns["coid"].ReadOnly = true;
			this.dgvDiscounts.Columns["branch"].ReadOnly = true;
		}

		// Token: 0x06005352 RID: 21330 RVA: 0x00306D3C File Offset: 0x00304F3C
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.DAT.Rows.Count > 0;
				if (flag)
				{
					SqlConnection sqlConnection = new SqlConnection(this._cnn);
					SqlCommand sqlCommand = sqlConnection.CreateCommand();
					sqlCommand.CommandType = CommandType.StoredProcedure;
					sqlCommand.CommandText = "GetDiscountPercentageGen";
					DataTable dataTable = new DataTable();
					SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
					SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
					sqlDataAdapter.Fill(dataTable);
					MessageBox.Show(sqlDataAdapter.Update(this.DAT).ToString() + " rows updated.");
				}
				else
				{
					MessageBox.Show("No row to update.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving discount percentage setting. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005353 RID: 21331 RVA: 0x00306E1C File Offset: 0x0030501C
		private void dgvDiscounts_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				dataGridView.Rows[e.RowIndex].Cells["coid"].Value = MyProject.Forms.Form1.coid;
				dataGridView.Rows[e.RowIndex].Cells["branch"].Value = MyProject.Forms.Form1.branch;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Cell validated error. Detail: " + ex.Message);
			}
		}

		// Token: 0x04002454 RID: 9300
		private PublicFunctions pf;

		// Token: 0x04002455 RID: 9301
		private string _cnn;

		// Token: 0x04002456 RID: 9302
		private DataTable DAT;
	}
}
