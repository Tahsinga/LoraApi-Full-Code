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
	// Token: 0x020001B7 RID: 439
	[DesignerGenerated]
	public partial class SelectBranches : Form
	{
		// Token: 0x06004FC4 RID: 20420 RVA: 0x002FA5B4 File Offset: 0x002F87B4
		public SelectBranches()
		{
			base.Load += this.SelectBranches_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x17001D50 RID: 7504
		// (get) Token: 0x06004FC7 RID: 20423 RVA: 0x002FA890 File Offset: 0x002F8A90
		// (set) Token: 0x06004FC8 RID: 20424 RVA: 0x002FA89A File Offset: 0x002F8A9A
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D51 RID: 7505
		// (get) Token: 0x06004FC9 RID: 20425 RVA: 0x002FA8A3 File Offset: 0x002F8AA3
		// (set) Token: 0x06004FCA RID: 20426 RVA: 0x002FA8B0 File Offset: 0x002F8AB0
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

		// Token: 0x17001D52 RID: 7506
		// (get) Token: 0x06004FCB RID: 20427 RVA: 0x002FA8F3 File Offset: 0x002F8AF3
		// (set) Token: 0x06004FCC RID: 20428 RVA: 0x002FA8FD File Offset: 0x002F8AFD
		internal virtual DataGridView DataGridView1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06004FCD RID: 20429 RVA: 0x002FA908 File Offset: 0x002F8B08
		private void SelectBranches_Load(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.Text;
				sqlCommand.CommandText = "select branch from branches";
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				DataTable dataTable = new DataTable();
				sqlDataAdapter.Fill(dataTable);
				this.DataGridView1.DataSource = dataTable;
				DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
				dataGridViewCheckBoxColumn.HeaderText = "Select";
				dataGridViewCheckBoxColumn.Name = "Select";
				this.DataGridView1.Columns.Add(dataGridViewCheckBoxColumn);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06004FCE RID: 20430 RVA: 0x002FA9D0 File Offset: 0x002F8BD0
		private void Button1_Click(object sender, EventArgs e)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.Connection = sqlConnection;
			sqlConnection.Open();
			SqlTransaction sqlTransaction = sqlConnection.BeginTransaction("RunProductDetailsSave");
			sqlCommand.Transaction = sqlTransaction;
			try
			{
				sqlCommand.Parameters.Clear();
				sqlCommand.CommandType = CommandType.Text;
				sqlCommand.CommandText = "truncate table tempSelectedBranches";
				sqlCommand.ExecuteNonQuery();
				try
				{
					foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						bool flag = Conversions.ToBoolean(dataGridViewRow.Cells[1].Value);
						bool flag2 = flag;
						if (flag2)
						{
							sqlCommand.Parameters.Clear();
							sqlCommand.CommandType = CommandType.Text;
							sqlCommand.CommandText = "insert into tempSelectedBranches (branch) values ('" + dataGridViewRow.Cells[0].Value.ToString() + "')";
							sqlCommand.ExecuteNonQuery();
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
				sqlTransaction.Commit();
				sqlConnection.Close();
				base.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving branch names. Detail: " + ex.Message);
				try
				{
					sqlTransaction.Rollback();
					sqlConnection.Close();
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x04002399 RID: 9113
		private string _cnn;
	}
}
