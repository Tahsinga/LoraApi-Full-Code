using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;

namespace PointOfSale
{
	// Token: 0x02000009 RID: 9
	[DesignerGenerated]
	public partial class AddNewProdt : Form
	{
		// Token: 0x06000164 RID: 356 RVA: 0x0000D858 File Offset: 0x0000BA58
		public AddNewProdt()
		{
			base.Load += this.AddNewProdt_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.publicfunction = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000167 RID: 359 RVA: 0x0000DFAA File Offset: 0x0000C1AA
		// (set) Token: 0x06000168 RID: 360 RVA: 0x0000DFB4 File Offset: 0x0000C1B4
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000169 RID: 361 RVA: 0x0000DFBD File Offset: 0x0000C1BD
		// (set) Token: 0x0600016A RID: 362 RVA: 0x0000DFC7 File Offset: 0x0000C1C7
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600016B RID: 363 RVA: 0x0000DFD0 File Offset: 0x0000C1D0
		// (set) Token: 0x0600016C RID: 364 RVA: 0x0000DFDC File Offset: 0x0000C1DC
		internal virtual TextBox txtReorder
		{
			[CompilerGenerated]
			get
			{
				return this._txtReorder;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtReorder_KeyPress);
				TextBox textBox = this._txtReorder;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtReorder = value;
				textBox = this._txtReorder;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600016D RID: 365 RVA: 0x0000E01F File Offset: 0x0000C21F
		// (set) Token: 0x0600016E RID: 366 RVA: 0x0000E029 File Offset: 0x0000C229
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600016F RID: 367 RVA: 0x0000E032 File Offset: 0x0000C232
		// (set) Token: 0x06000170 RID: 368 RVA: 0x0000E03C File Offset: 0x0000C23C
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000171 RID: 369 RVA: 0x0000E045 File Offset: 0x0000C245
		// (set) Token: 0x06000172 RID: 370 RVA: 0x0000E04F File Offset: 0x0000C24F
		internal virtual ComboBox cboCategory
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000173 RID: 371 RVA: 0x0000E058 File Offset: 0x0000C258
		// (set) Token: 0x06000174 RID: 372 RVA: 0x0000E062 File Offset: 0x0000C262
		internal virtual TextBox txtdesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000175 RID: 373 RVA: 0x0000E06B File Offset: 0x0000C26B
		// (set) Token: 0x06000176 RID: 374 RVA: 0x0000E078 File Offset: 0x0000C278
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

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000177 RID: 375 RVA: 0x0000E0BB File Offset: 0x0000C2BB
		// (set) Token: 0x06000178 RID: 376 RVA: 0x0000E0C5 File Offset: 0x0000C2C5
		internal virtual DataGridView dgvproducts
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000179 RID: 377 RVA: 0x0000E0CE File Offset: 0x0000C2CE
		// (set) Token: 0x0600017A RID: 378 RVA: 0x0000E0D8 File Offset: 0x0000C2D8
		internal virtual Label lblinfo
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600017B RID: 379 RVA: 0x0000E0E1 File Offset: 0x0000C2E1
		// (set) Token: 0x0600017C RID: 380 RVA: 0x0000E0EB File Offset: 0x0000C2EB
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x0600017D RID: 381 RVA: 0x0000E0F4 File Offset: 0x0000C2F4
		private void AddNewProdt_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadCategories();
				this.LoadProducts();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading New Product Form. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600017E RID: 382 RVA: 0x0000E14C File Offset: 0x0000C34C
		private void LoadCategories()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchCategories";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			this.cboCategory.DataSource = dataTable;
			this.cboCategory.ValueMember = "CatID";
			this.cboCategory.DisplayMember = "CatDesc";
		}

		// Token: 0x0600017F RID: 383 RVA: 0x0000E1EC File Offset: 0x0000C3EC
		private void SaveProduct()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "InsertNewProduct";
			sqlCommand.Parameters.AddWithValue("catid", RuntimeHelpers.GetObjectValue(this.cboCategory.SelectedValue));
			sqlCommand.Parameters.AddWithValue("productdesc", this.txtdesc.Text);
			sqlCommand.Parameters.AddWithValue("cost", 0);
			sqlCommand.Parameters.AddWithValue("sellingprice", 0);
			sqlCommand.Parameters.AddWithValue("reorderlevel", RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(this.txtReorder.Text, "", false) == 0, 0, Conversion.Val(this.txtReorder.Text))));
			sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
			sqlCommand.Parameters.AddWithValue("donewhen", DateTime.Today.ToString("yyyyMMdd"));
			sqlCommand.Parameters.AddWithValue("new_prodtid", this.newID);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			using (sqlConnection)
			{
				sqlConnection.Open();
				this.newID = Conversions.ToInteger(sqlCommand.ExecuteScalar());
				sqlConnection.Close();
			}
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0000E3A0 File Offset: 0x0000C5A0
		private void txtReorder_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06000181 RID: 385 RVA: 0x0000E3EC File Offset: 0x0000C5EC
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.txtdesc.Text, "", false) != 0;
				if (flag)
				{
					this.lblinfo.Text = "...";
					this.SaveProduct();
					this.lblinfo.Text = "Product saved with product ID: " + Conversions.ToString(this.newID);
					this.txtdesc.Text = "";
					this.txtReorder.Text = Conversions.ToString(0);
					this.LoadProducts();
				}
				else
				{
					MessageBox.Show("Cannot proceed without a Product description.", "Error");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving product. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000182 RID: 386 RVA: 0x0000E4C8 File Offset: 0x0000C6C8
		private void LoadProducts()
		{
			this.dgvproducts.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectAllProducts";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			this.dgvproducts.DataSource = dataTable;
			this.dgvproducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvproducts.Columns["ProductID"].HeaderText = "Product ID";
			this.dgvproducts.Columns["Product_Description"].HeaderText = "Description";
		}

		// Token: 0x040000A2 RID: 162
		private string _cnn;

		// Token: 0x040000A3 RID: 163
		private int newID;

		// Token: 0x040000A4 RID: 164
		private PublicFunctions publicfunction;
	}
}
