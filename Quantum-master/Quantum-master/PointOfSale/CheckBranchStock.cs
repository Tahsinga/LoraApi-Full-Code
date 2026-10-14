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
	// Token: 0x02000022 RID: 34
	[DesignerGenerated]
	public partial class CheckBranchStock : Form
	{
		// Token: 0x060006AF RID: 1711 RVA: 0x00043FAC File Offset: 0x000421AC
		public CheckBranchStock()
		{
			base.Load += this.CheckBranchStock_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x060006B2 RID: 1714 RVA: 0x000443F6 File Offset: 0x000425F6
		// (set) Token: 0x060006B3 RID: 1715 RVA: 0x00044400 File Offset: 0x00042600
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x060006B4 RID: 1716 RVA: 0x00044409 File Offset: 0x00042609
		// (set) Token: 0x060006B5 RID: 1717 RVA: 0x00044413 File Offset: 0x00042613
		internal virtual Label lblProductCode
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x060006B6 RID: 1718 RVA: 0x0004441C File Offset: 0x0004261C
		// (set) Token: 0x060006B7 RID: 1719 RVA: 0x00044426 File Offset: 0x00042626
		internal virtual Label lblProductDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x060006B8 RID: 1720 RVA: 0x0004442F File Offset: 0x0004262F
		// (set) Token: 0x060006B9 RID: 1721 RVA: 0x00044439 File Offset: 0x00042639
		internal virtual DataGridView dgvPrices
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x060006BA RID: 1722 RVA: 0x00044442 File Offset: 0x00042642
		// (set) Token: 0x060006BB RID: 1723 RVA: 0x0004444C File Offset: 0x0004264C
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x00044458 File Offset: 0x00042658
		private void CheckBranchStock_Load(object sender, EventArgs e)
		{
			try
			{
				base.MaximizeBox = false;
				this.lblProductDesc.Text = this.proddesc;
				this.lblProductCode.Text = this.prodcode;
				this.GetStockPriceForAllBranches();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading product search details. " + ex.Message);
			}
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x000444D4 File Offset: 0x000426D4
		private void GetStockPriceForAllBranches()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "ProductStockAndPrice";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("productid", this.productid);
			sqlCommand.Parameters.AddWithValue("trandate", this.trandate);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			this.dgvPrices.DataSource = dataTable;
		}

		// Token: 0x0400031F RID: 799
		public int productid;

		// Token: 0x04000320 RID: 800
		private string _cnn;

		// Token: 0x04000321 RID: 801
		public string branchname;

		// Token: 0x04000322 RID: 802
		public int trandate;

		// Token: 0x04000323 RID: 803
		public string proddesc;

		// Token: 0x04000324 RID: 804
		public string prodcode;
	}
}
