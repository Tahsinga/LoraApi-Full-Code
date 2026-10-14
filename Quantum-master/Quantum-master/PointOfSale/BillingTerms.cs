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
	// Token: 0x02000015 RID: 21
	[DesignerGenerated]
	public partial class BillingTerms : Form
	{
		// Token: 0x06000354 RID: 852 RVA: 0x0001DCCC File Offset: 0x0001BECC
		public BillingTerms()
		{
			base.Load += this.BillingTerms_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.dat = new DataTable();
			this.InitializeComponent();
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000357 RID: 855 RVA: 0x0001E1AC File Offset: 0x0001C3AC
		// (set) Token: 0x06000358 RID: 856 RVA: 0x0001E1B6 File Offset: 0x0001C3B6
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000359 RID: 857 RVA: 0x0001E1BF File Offset: 0x0001C3BF
		// (set) Token: 0x0600035A RID: 858 RVA: 0x0001E1C9 File Offset: 0x0001C3C9
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x0600035B RID: 859 RVA: 0x0001E1D2 File Offset: 0x0001C3D2
		// (set) Token: 0x0600035C RID: 860 RVA: 0x0001E1DC File Offset: 0x0001C3DC
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
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.DataGridView1_CellValidating);
				DataGridView dataGridView = this._DataGridView1;
				if (dataGridView != null)
				{
					dataGridView.CellEndEdit -= dataGridViewCellEventHandler;
					dataGridView.CellValidating -= dataGridViewCellValidatingEventHandler;
				}
				this._DataGridView1 = value;
				dataGridView = this._DataGridView1;
				if (dataGridView != null)
				{
					dataGridView.CellEndEdit += dataGridViewCellEventHandler;
					dataGridView.CellValidating += dataGridViewCellValidatingEventHandler;
				}
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x0600035D RID: 861 RVA: 0x0001E23A File Offset: 0x0001C43A
		// (set) Token: 0x0600035E RID: 862 RVA: 0x0001E244 File Offset: 0x0001C444
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

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x0600035F RID: 863 RVA: 0x0001E287 File Offset: 0x0001C487
		// (set) Token: 0x06000360 RID: 864 RVA: 0x0001E291 File Offset: 0x0001C491
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000361 RID: 865 RVA: 0x0001E29A File Offset: 0x0001C49A
		// (set) Token: 0x06000362 RID: 866 RVA: 0x0001E2A4 File Offset: 0x0001C4A4
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06000363 RID: 867 RVA: 0x0001E2B0 File Offset: 0x0001C4B0
		private void BillingTerms_Load(object sender, EventArgs e)
		{
			try
			{
				base.MaximizeBox = false;
				base.MinimizeBox = false;
				base.StartPosition = FormStartPosition.CenterParent;
				this.LoadTerms();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000364 RID: 868 RVA: 0x0001E318 File Offset: 0x0001C518
		private void LoadTerms()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectPaymentTerms";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(this.dat);
			this.DataGridView1.DataSource = this.dat;
			this.DataGridView1.Columns["Uploaded"].Visible = false;
			this.DataGridView1.Columns["coid"].Visible = false;
			this.DataGridView1.Columns["EntryNo"].Visible = false;
			this.DataGridView1.Columns["EntryNo"].DefaultCellStyle.BackColor = Color.Gray;
			this.DataGridView1.Columns["TermsDays"].HeaderText = "Terms in Days";
			this.DataGridView1.Columns["Description"].HeaderText = "Description";
			this.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		}

		// Token: 0x06000365 RID: 869 RVA: 0x0001E460 File Offset: 0x0001C660
		private void savechanges()
		{
			bool flag = this.dat.Rows.Count > 0;
			if (flag)
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "SelectPaymentTerms";
				sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
				DataTable dataTable = new DataTable();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
				sqlDataAdapter.Fill(dataTable);
				sqlDataAdapter.Update(this.dat);
			}
		}

		// Token: 0x06000366 RID: 870 RVA: 0x0001E504 File Offset: 0x0001C704
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.savechanges();
				MessageBox.Show("Changes saved succesfully.");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000367 RID: 871 RVA: 0x0001E560 File Offset: 0x0001C760
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

		// Token: 0x06000368 RID: 872 RVA: 0x0001E600 File Offset: 0x0001C800
		private void DataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			try
			{
				this.DataGridView1.Rows[e.RowIndex].ErrorText = "";
				bool flag = Operators.CompareString(this.DataGridView1.Columns[e.ColumnIndex].Name, "TermsDays", false) == 0;
				if (flag)
				{
					bool isNewRow = this.DataGridView1.Rows[e.RowIndex].IsNewRow;
					if (!isNewRow)
					{
						decimal num;
						bool flag2 = !decimal.TryParse(e.FormattedValue.ToString(), out num) || decimal.Compare(num, 0m) < 0;
						if (flag2)
						{
							e.Cancel = true;
							this.DataGridView1.Rows[e.RowIndex].ErrorText = "the value must be a decimal";
						}
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0400017E RID: 382
		private string _cnn;

		// Token: 0x0400017F RID: 383
		private DataTable dat;
	}
}
