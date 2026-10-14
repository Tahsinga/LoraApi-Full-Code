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
	// Token: 0x0200002A RID: 42
	[DesignerGenerated]
	public partial class CollectionsProductBals : UserControl
	{
		// Token: 0x060007CB RID: 1995 RVA: 0x0004DFAB File Offset: 0x0004C1AB
		public CollectionsProductBals()
		{
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x060007CE RID: 1998 RVA: 0x0004E27B File Offset: 0x0004C47B
		// (set) Token: 0x060007CF RID: 1999 RVA: 0x0004E285 File Offset: 0x0004C485
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x060007D0 RID: 2000 RVA: 0x0004E28E File Offset: 0x0004C48E
		// (set) Token: 0x060007D1 RID: 2001 RVA: 0x0004E298 File Offset: 0x0004C498
		internal virtual DataGridView dgvProducts
		{
			[CompilerGenerated]
			get
			{
				return this._dgvProducts;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
				DataGridView dataGridView = this._dgvProducts;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick -= dataGridViewCellEventHandler;
				}
				this._dgvProducts = value;
				dataGridView = this._dgvProducts;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x060007D2 RID: 2002 RVA: 0x0004E2DB File Offset: 0x0004C4DB
		// (set) Token: 0x060007D3 RID: 2003 RVA: 0x0004E2E8 File Offset: 0x0004C4E8
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

		// Token: 0x060007D4 RID: 2004 RVA: 0x0004E32C File Offset: 0x0004C52C
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "CollectionStatusAllProducts";
				sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
				DataTable dataTable = new DataTable();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				int num = sqlDataAdapter.Fill(dataTable);
				this.dgvProducts.DataSource = dataTable;
				this.dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
				dataGridViewButtonColumn.HeaderText = "View Details";
				dataGridViewButtonColumn.Text = "View";
				dataGridViewButtonColumn.Name = "view";
				dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
				this.dgvProducts.Columns.Add(dataGridViewButtonColumn);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying report. Detail: " + ex.Message);
			}
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x0004E43C File Offset: 0x0004C63C
		private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					bool flag2 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "view", false) == 0;
					if (flag2)
					{
						new CollectionsProductBalByCustomer
						{
							productid = Conversions.ToInteger(dataGridView.Rows[e.RowIndex].Cells["Product_ID"].Value),
							productname = Conversions.ToString(dataGridView.Rows[e.RowIndex].Cells["Product_Description"].Value),
							productbal = Conversions.ToDecimal(dataGridView.Rows[e.RowIndex].Cells["bal"].Value)
						}.ShowDialog();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading details page. Detail: " + ex.Message);
			}
		}

		// Token: 0x040003AE RID: 942
		private string _cnn;
	}
}
