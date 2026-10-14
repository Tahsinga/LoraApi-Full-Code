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
	// Token: 0x0200003B RID: 59
	[DesignerGenerated]
	public partial class DeletedProducts : UserControl
	{
		// Token: 0x06000D18 RID: 3352 RVA: 0x000803FC File Offset: 0x0007E5FC
		public DeletedProducts()
		{
			base.Load += this.DeletedProducts_Load;
			this.InitializeComponent();
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06000D1B RID: 3355 RVA: 0x0008079F File Offset: 0x0007E99F
		// (set) Token: 0x06000D1C RID: 3356 RVA: 0x000807A9 File Offset: 0x0007E9A9
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06000D1D RID: 3357 RVA: 0x000807B2 File Offset: 0x0007E9B2
		// (set) Token: 0x06000D1E RID: 3358 RVA: 0x000807BC File Offset: 0x0007E9BC
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06000D1F RID: 3359 RVA: 0x000807C5 File Offset: 0x0007E9C5
		// (set) Token: 0x06000D20 RID: 3360 RVA: 0x000807CF File Offset: 0x0007E9CF
		internal virtual DataGridView dgvDeletedProducts
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06000D21 RID: 3361 RVA: 0x000807D8 File Offset: 0x0007E9D8
		// (set) Token: 0x06000D22 RID: 3362 RVA: 0x000807E2 File Offset: 0x0007E9E2
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x000807EC File Offset: 0x0007E9EC
		private void DeletedProducts_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadDeletedProducts();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading deleted products. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000D24 RID: 3364 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label1_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06000D25 RID: 3365 RVA: 0x0008083C File Offset: 0x0007EA3C
		private void LoadDeletedProducts()
		{
			SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = "Select * from productsdeleted where coid=" + Conversions.ToString(MyProject.Forms.Form1.coid) + " order by DateDeleted";
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			this.dgvDeletedProducts.DataSource = dataTable;
			this.dgvDeletedProducts.Columns["coid"].Visible = false;
			this.dgvDeletedProducts.Columns["DateDeletedServer"].Visible = false;
			this.dgvDeletedProducts.Columns["UOM"].Visible = false;
		}
	}
}
