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
	// Token: 0x02000212 RID: 530
	[DesignerGenerated]
	public partial class ViewProducts : Form
	{
		// Token: 0x06005F10 RID: 24336 RVA: 0x003678BC File Offset: 0x00365ABC
		public ViewProducts()
		{
			base.Load += this.ViewProducts_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x17002259 RID: 8793
		// (get) Token: 0x06005F13 RID: 24339 RVA: 0x00367DD8 File Offset: 0x00365FD8
		// (set) Token: 0x06005F14 RID: 24340 RVA: 0x00367DE2 File Offset: 0x00365FE2
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700225A RID: 8794
		// (get) Token: 0x06005F15 RID: 24341 RVA: 0x00367DEB File Offset: 0x00365FEB
		// (set) Token: 0x06005F16 RID: 24342 RVA: 0x00367DF5 File Offset: 0x00365FF5
		internal virtual DataGridView DataGridView1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700225B RID: 8795
		// (get) Token: 0x06005F17 RID: 24343 RVA: 0x00367DFE File Offset: 0x00365FFE
		// (set) Token: 0x06005F18 RID: 24344 RVA: 0x00367E08 File Offset: 0x00366008
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700225C RID: 8796
		// (get) Token: 0x06005F19 RID: 24345 RVA: 0x00367E11 File Offset: 0x00366011
		// (set) Token: 0x06005F1A RID: 24346 RVA: 0x00367E1C File Offset: 0x0036601C
		internal virtual TextBox txtsearch
		{
			[CompilerGenerated]
			get
			{
				return this._txtsearch;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.TextBox1_TextChanged);
				TextBox textBox = this._txtsearch;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
				}
				this._txtsearch = value;
				textBox = this._txtsearch;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700225D RID: 8797
		// (get) Token: 0x06005F1B RID: 24347 RVA: 0x00367E5F File Offset: 0x0036605F
		// (set) Token: 0x06005F1C RID: 24348 RVA: 0x00367E69 File Offset: 0x00366069
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700225E RID: 8798
		// (get) Token: 0x06005F1D RID: 24349 RVA: 0x00367E72 File Offset: 0x00366072
		// (set) Token: 0x06005F1E RID: 24350 RVA: 0x00367E7C File Offset: 0x0036607C
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700225F RID: 8799
		// (get) Token: 0x06005F1F RID: 24351 RVA: 0x00367E85 File Offset: 0x00366085
		// (set) Token: 0x06005F20 RID: 24352 RVA: 0x00367E90 File Offset: 0x00366090
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

		// Token: 0x06005F21 RID: 24353 RVA: 0x00367ED4 File Offset: 0x003660D4
		private void TextBox1_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.lblerror.Text = "...";
				this.SearchByDesc(this.txtsearch.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005F22 RID: 24354 RVA: 0x00367F40 File Offset: 0x00366140
		private void SearchByDesc(string searchtext)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SearchProduct";
			sqlCommand.Parameters.AddWithValue("search", searchtext);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				this.DataGridView1.DataSource = dataTable;
				this.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			}
			else
			{
				this.lblerror.Text = "No products match your search.";
			}
		}

		// Token: 0x06005F23 RID: 24355 RVA: 0x00368000 File Offset: 0x00366200
		private void FetchAllProducts()
		{
			this.lblerror.Text = "...";
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectAllProducts";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				this.DataGridView1.DataSource = dataTable;
				this.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				this.DataGridView1.Columns["CatDesc"].Visible = false;
				this.DataGridView1.Columns["Reorder_Level"].Visible = false;
				this.DataGridView1.Columns["Unit_Selling_Price"].Visible = false;
				this.DataGridView1.Columns["Unit_Cost"].Visible = false;
			}
			else
			{
				this.lblerror.Text = "No products match your search.";
			}
		}

		// Token: 0x06005F24 RID: 24356 RVA: 0x00368130 File Offset: 0x00366330
		private void ViewProducts_Load(object sender, EventArgs e)
		{
			try
			{
				this.FetchAllProducts();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading. ");
			}
		}

		// Token: 0x06005F25 RID: 24357 RVA: 0x00368174 File Offset: 0x00366374
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.lblerror.Text = "...";
				this.FetchAllProducts();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Detail: " + ex.Message);
			}
		}

		// Token: 0x040029C6 RID: 10694
		private string _cnn;
	}
}
