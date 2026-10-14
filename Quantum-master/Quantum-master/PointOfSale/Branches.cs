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
	// Token: 0x02000017 RID: 23
	[DesignerGenerated]
	public partial class Branches : Form
	{
		// Token: 0x06000426 RID: 1062 RVA: 0x00026C0C File Offset: 0x00024E0C
		public Branches()
		{
			base.Load += this.Branches_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.branches_header = "";
			this.InitializeComponent();
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000429 RID: 1065 RVA: 0x00027092 File Offset: 0x00025292
		// (set) Token: 0x0600042A RID: 1066 RVA: 0x0002709C File Offset: 0x0002529C
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x0600042B RID: 1067 RVA: 0x000270A5 File Offset: 0x000252A5
		// (set) Token: 0x0600042C RID: 1068 RVA: 0x000270B0 File Offset: 0x000252B0
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

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x0600042D RID: 1069 RVA: 0x000270F3 File Offset: 0x000252F3
		// (set) Token: 0x0600042E RID: 1070 RVA: 0x000270FD File Offset: 0x000252FD
		internal virtual DataGridView dgvBranches
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x0600042F RID: 1071 RVA: 0x00027106 File Offset: 0x00025306
		// (set) Token: 0x06000430 RID: 1072 RVA: 0x00027110 File Offset: 0x00025310
		internal virtual Label lblheader
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000431 RID: 1073 RVA: 0x00027119 File Offset: 0x00025319
		// (set) Token: 0x06000432 RID: 1074 RVA: 0x00027124 File Offset: 0x00025324
		internal virtual CheckBox chkSelectAll
		{
			[CompilerGenerated]
			get
			{
				return this._chkSelectAll;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.chkSelectAll_CheckedChanged);
				CheckBox checkBox = this._chkSelectAll;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= eventHandler;
				}
				this._chkSelectAll = value;
				checkBox = this._chkSelectAll;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00027168 File Offset: 0x00025368
		private void Branches_Load(object sender, EventArgs e)
		{
			try
			{
				this.lblheader.Text = this.branches_header;
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "FetchBranches";
				sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				DataTable dataTable = new DataTable();
				sqlDataAdapter.Fill(dataTable);
				this.dgvBranches.DataSource = dataTable;
				DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
				dataGridViewCheckBoxColumn.HeaderText = "Save Changes";
				dataGridViewCheckBoxColumn.Name = "save";
				this.dgvBranches.Columns.Add(dataGridViewCheckBoxColumn);
				this.dgvBranches.Columns["Branch"].DefaultCellStyle.BackColor = Color.Gray;
				this.dgvBranches.Columns["Branch"].ReadOnly = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error laoding branches. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x000272A8 File Offset: 0x000254A8
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				DataTable dataTable = new DataTable();
				dataTable.Columns.Add("branch", typeof(string));
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvBranches.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						bool flag = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["save"].Value, true, false);
						if (flag)
						{
							dataTable.Rows.Add(new object[] { dataGridViewRow.Cells["branch"].Value });
						}
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
				MyProject.Forms.Form1.datPriceBranches = dataTable;
				base.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error selecting branches. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x000273CC File Offset: 0x000255CC
		private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvBranches.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						dataGridViewRow.Cells["save"].Value = true;
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
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x040001F1 RID: 497
		private string _cnn;

		// Token: 0x040001F2 RID: 498
		public string branches_header;
	}
}
