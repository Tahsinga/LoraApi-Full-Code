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
	// Token: 0x02000029 RID: 41
	[DesignerGenerated]
	public partial class CollectionsProductBalByCustomer : Form
	{
		// Token: 0x060007B1 RID: 1969 RVA: 0x0004D5A7 File Offset: 0x0004B7A7
		public CollectionsProductBalByCustomer()
		{
			base.Load += this.CollectionsProductBalByCustomer_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x060007B4 RID: 1972 RVA: 0x0004DD7B File Offset: 0x0004BF7B
		// (set) Token: 0x060007B5 RID: 1973 RVA: 0x0004DD85 File Offset: 0x0004BF85
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x060007B6 RID: 1974 RVA: 0x0004DD8E File Offset: 0x0004BF8E
		// (set) Token: 0x060007B7 RID: 1975 RVA: 0x0004DD98 File Offset: 0x0004BF98
		internal virtual TextBox txtProductBal
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x060007B8 RID: 1976 RVA: 0x0004DDA1 File Offset: 0x0004BFA1
		// (set) Token: 0x060007B9 RID: 1977 RVA: 0x0004DDAB File Offset: 0x0004BFAB
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x060007BA RID: 1978 RVA: 0x0004DDB4 File Offset: 0x0004BFB4
		// (set) Token: 0x060007BB RID: 1979 RVA: 0x0004DDBE File Offset: 0x0004BFBE
		internal virtual TextBox txtProductID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x060007BC RID: 1980 RVA: 0x0004DDC7 File Offset: 0x0004BFC7
		// (set) Token: 0x060007BD RID: 1981 RVA: 0x0004DDD1 File Offset: 0x0004BFD1
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x060007BE RID: 1982 RVA: 0x0004DDDA File Offset: 0x0004BFDA
		// (set) Token: 0x060007BF RID: 1983 RVA: 0x0004DDE4 File Offset: 0x0004BFE4
		internal virtual TextBox txtProductName
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x060007C0 RID: 1984 RVA: 0x0004DDED File Offset: 0x0004BFED
		// (set) Token: 0x060007C1 RID: 1985 RVA: 0x0004DDF7 File Offset: 0x0004BFF7
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x060007C2 RID: 1986 RVA: 0x0004DE00 File Offset: 0x0004C000
		// (set) Token: 0x060007C3 RID: 1987 RVA: 0x0004DE0A File Offset: 0x0004C00A
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x060007C4 RID: 1988 RVA: 0x0004DE13 File Offset: 0x0004C013
		// (set) Token: 0x060007C5 RID: 1989 RVA: 0x0004DE1D File Offset: 0x0004C01D
		internal virtual DataGridView dgvDetail
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x060007C6 RID: 1990 RVA: 0x0004DE26 File Offset: 0x0004C026
		// (set) Token: 0x060007C7 RID: 1991 RVA: 0x0004DE30 File Offset: 0x0004C030
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

		// Token: 0x060007C8 RID: 1992 RVA: 0x0004DE74 File Offset: 0x0004C074
		private void CollectionsProductBalByCustomer_Load(object sender, EventArgs e)
		{
			try
			{
				this.txtProductBal.Text = this.productbal.ToString();
				this.txtProductID.Text = this.productid.ToString();
				this.txtProductName.Text = this.productname;
				this.LoadProductDetails();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading page. Detail: " + ex.Message);
			}
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x0004DF04 File Offset: 0x0004C104
		private void LoadProductDetails()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "CollectionStatusForProduct";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("productid", this.productid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			this.dgvDetail.DataSource = dataTable;
			this.dgvDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x00002A30 File Offset: 0x00000C30
		private void Button1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x040003A6 RID: 934
		public string productname;

		// Token: 0x040003A7 RID: 935
		public int productid;

		// Token: 0x040003A8 RID: 936
		public decimal productbal;

		// Token: 0x040003A9 RID: 937
		private string _cnn;
	}
}
