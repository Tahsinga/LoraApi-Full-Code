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
	// Token: 0x02000213 RID: 531
	[DesignerGenerated]
	public partial class ViewProducts2 : Form
	{
		// Token: 0x06005F26 RID: 24358 RVA: 0x003681D4 File Offset: 0x003663D4
		public ViewProducts2()
		{
			base.Load += this.ViewProducts_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x17002260 RID: 8800
		// (get) Token: 0x06005F29 RID: 24361 RVA: 0x003686F0 File Offset: 0x003668F0
		// (set) Token: 0x06005F2A RID: 24362 RVA: 0x003686FA File Offset: 0x003668FA
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002261 RID: 8801
		// (get) Token: 0x06005F2B RID: 24363 RVA: 0x00368703 File Offset: 0x00366903
		// (set) Token: 0x06005F2C RID: 24364 RVA: 0x00368710 File Offset: 0x00366910
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

		// Token: 0x17002262 RID: 8802
		// (get) Token: 0x06005F2D RID: 24365 RVA: 0x00368753 File Offset: 0x00366953
		// (set) Token: 0x06005F2E RID: 24366 RVA: 0x0036875D File Offset: 0x0036695D
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002263 RID: 8803
		// (get) Token: 0x06005F2F RID: 24367 RVA: 0x00368766 File Offset: 0x00366966
		// (set) Token: 0x06005F30 RID: 24368 RVA: 0x00368770 File Offset: 0x00366970
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002264 RID: 8804
		// (get) Token: 0x06005F31 RID: 24369 RVA: 0x00368779 File Offset: 0x00366979
		// (set) Token: 0x06005F32 RID: 24370 RVA: 0x00368783 File Offset: 0x00366983
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002265 RID: 8805
		// (get) Token: 0x06005F33 RID: 24371 RVA: 0x0036878C File Offset: 0x0036698C
		// (set) Token: 0x06005F34 RID: 24372 RVA: 0x00368798 File Offset: 0x00366998
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

		// Token: 0x17002266 RID: 8806
		// (get) Token: 0x06005F35 RID: 24373 RVA: 0x003687DB File Offset: 0x003669DB
		// (set) Token: 0x06005F36 RID: 24374 RVA: 0x003687E5 File Offset: 0x003669E5
		internal virtual DataGridView DataGridView1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06005F37 RID: 24375 RVA: 0x003687F0 File Offset: 0x003669F0
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

		// Token: 0x06005F38 RID: 24376 RVA: 0x0036885C File Offset: 0x00366A5C
		private void SearchByDesc(string searchtext)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SearchProduct2";
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

		// Token: 0x06005F39 RID: 24377 RVA: 0x0036891C File Offset: 0x00366B1C
		private void FetchAllProducts()
		{
			this.lblerror.Text = "...";
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectAllProducts2";
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
				this.DataGridView1.Columns["ProductID"].Visible = false;
				this.DataGridView1.Columns["Unit_Cost"].Visible = false;
			}
			else
			{
				this.lblerror.Text = "No products match your search.";
			}
		}

		// Token: 0x06005F3A RID: 24378 RVA: 0x00368A4C File Offset: 0x00366C4C
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

		// Token: 0x06005F3B RID: 24379 RVA: 0x00368A90 File Offset: 0x00366C90
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

		// Token: 0x040029CF RID: 10703
		private string _cnn;
	}
}
