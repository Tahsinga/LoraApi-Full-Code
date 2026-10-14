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
	// Token: 0x02000194 RID: 404
	[DesignerGenerated]
	public partial class SalesByCategoryAndUser : UserControl
	{
		// Token: 0x060047A0 RID: 18336 RVA: 0x002BC04C File Offset: 0x002BA24C
		public SalesByCategoryAndUser()
		{
			base.Load += this.SalesByCategoryAndUser_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x170019FD RID: 6653
		// (get) Token: 0x060047A3 RID: 18339 RVA: 0x002BCAF1 File Offset: 0x002BACF1
		// (set) Token: 0x060047A4 RID: 18340 RVA: 0x002BCAFB File Offset: 0x002BACFB
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170019FE RID: 6654
		// (get) Token: 0x060047A5 RID: 18341 RVA: 0x002BCB04 File Offset: 0x002BAD04
		// (set) Token: 0x060047A6 RID: 18342 RVA: 0x002BCB10 File Offset: 0x002BAD10
		internal virtual Label Label1
		{
			[CompilerGenerated]
			get
			{
				return this._Label1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label1_Click);
				Label label = this._Label1;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label1 = value;
				label = this._Label1;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x170019FF RID: 6655
		// (get) Token: 0x060047A7 RID: 18343 RVA: 0x002BCB53 File Offset: 0x002BAD53
		// (set) Token: 0x060047A8 RID: 18344 RVA: 0x002BCB5D File Offset: 0x002BAD5D
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A00 RID: 6656
		// (get) Token: 0x060047A9 RID: 18345 RVA: 0x002BCB66 File Offset: 0x002BAD66
		// (set) Token: 0x060047AA RID: 18346 RVA: 0x002BCB70 File Offset: 0x002BAD70
		internal virtual DataGridView DataGridView1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A01 RID: 6657
		// (get) Token: 0x060047AB RID: 18347 RVA: 0x002BCB79 File Offset: 0x002BAD79
		// (set) Token: 0x060047AC RID: 18348 RVA: 0x002BCB84 File Offset: 0x002BAD84
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

		// Token: 0x17001A02 RID: 6658
		// (get) Token: 0x060047AD RID: 18349 RVA: 0x002BCBC7 File Offset: 0x002BADC7
		// (set) Token: 0x060047AE RID: 18350 RVA: 0x002BCBD4 File Offset: 0x002BADD4
		internal virtual ComboBox cboUsers
		{
			[CompilerGenerated]
			get
			{
				return this._cboUsers;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cboUsers_SelectedIndexChanged);
				ComboBox comboBox = this._cboUsers;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= eventHandler;
				}
				this._cboUsers = value;
				comboBox = this._cboUsers;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17001A03 RID: 6659
		// (get) Token: 0x060047AF RID: 18351 RVA: 0x002BCC17 File Offset: 0x002BAE17
		// (set) Token: 0x060047B0 RID: 18352 RVA: 0x002BCC24 File Offset: 0x002BAE24
		internal virtual Label Label2
		{
			[CompilerGenerated]
			get
			{
				return this._Label2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label2_Click);
				Label label = this._Label2;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label2 = value;
				label = this._Label2;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x17001A04 RID: 6660
		// (get) Token: 0x060047B1 RID: 18353 RVA: 0x002BCC67 File Offset: 0x002BAE67
		// (set) Token: 0x060047B2 RID: 18354 RVA: 0x002BCC74 File Offset: 0x002BAE74
		internal virtual Button Button2
		{
			[CompilerGenerated]
			get
			{
				return this._Button2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button2_Click);
				Button button = this._Button2;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button2 = value;
				button = this._Button2;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17001A05 RID: 6661
		// (get) Token: 0x060047B3 RID: 18355 RVA: 0x002BCCB7 File Offset: 0x002BAEB7
		// (set) Token: 0x060047B4 RID: 18356 RVA: 0x002BCCC1 File Offset: 0x002BAEC1
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A06 RID: 6662
		// (get) Token: 0x060047B5 RID: 18357 RVA: 0x002BCCCA File Offset: 0x002BAECA
		// (set) Token: 0x060047B6 RID: 18358 RVA: 0x002BCCD4 File Offset: 0x002BAED4
		internal virtual DateTimePicker DTEnddate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A07 RID: 6663
		// (get) Token: 0x060047B7 RID: 18359 RVA: 0x002BCCDD File Offset: 0x002BAEDD
		// (set) Token: 0x060047B8 RID: 18360 RVA: 0x002BCCE7 File Offset: 0x002BAEE7
		internal virtual DateTimePicker DTStartdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A08 RID: 6664
		// (get) Token: 0x060047B9 RID: 18361 RVA: 0x002BCCF0 File Offset: 0x002BAEF0
		// (set) Token: 0x060047BA RID: 18362 RVA: 0x002BCCFA File Offset: 0x002BAEFA
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A09 RID: 6665
		// (get) Token: 0x060047BB RID: 18363 RVA: 0x002BCD03 File Offset: 0x002BAF03
		// (set) Token: 0x060047BC RID: 18364 RVA: 0x002BCD0D File Offset: 0x002BAF0D
		internal virtual CheckBox chkAllUsers
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A0A RID: 6666
		// (get) Token: 0x060047BD RID: 18365 RVA: 0x002BCD16 File Offset: 0x002BAF16
		// (set) Token: 0x060047BE RID: 18366 RVA: 0x002BCD20 File Offset: 0x002BAF20
		internal virtual Button Button3
		{
			[CompilerGenerated]
			get
			{
				return this._Button3;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button3_Click);
				Button button = this._Button3;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button3 = value;
				button = this._Button3;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17001A0B RID: 6667
		// (get) Token: 0x060047BF RID: 18367 RVA: 0x002BCD63 File Offset: 0x002BAF63
		// (set) Token: 0x060047C0 RID: 18368 RVA: 0x002BCD6D File Offset: 0x002BAF6D
		internal virtual SaveFileDialog SaveFileDialog1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A0C RID: 6668
		// (get) Token: 0x060047C1 RID: 18369 RVA: 0x002BCD76 File Offset: 0x002BAF76
		// (set) Token: 0x060047C2 RID: 18370 RVA: 0x002BCD80 File Offset: 0x002BAF80
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060047C3 RID: 18371 RVA: 0x002BCD8C File Offset: 0x002BAF8C
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				DataTable dataTable = new DataTable();
				MyProject.Forms.Form1.datSelectedCategories = dataTable;
				SelectCategories selectCategories = new SelectCategories();
				selectCategories.ShowDialog(this);
				selectCategories.Dispose();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060047C4 RID: 18372 RVA: 0x002BCDE8 File Offset: 0x002BAFE8
		private void LoadUsers()
		{
			SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			DataTable dataTable = new DataTable();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchUsers";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			this.cboUsers.DataSource = dataTable;
			this.cboUsers.ValueMember = "Username";
			this.cboUsers.DisplayMember = "Username";
		}

		// Token: 0x060047C5 RID: 18373 RVA: 0x00002A30 File Offset: 0x00000C30
		private void cboUsers_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060047C6 RID: 18374 RVA: 0x00002A30 File Offset: 0x00000C30
		private void Label2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060047C7 RID: 18375 RVA: 0x002BCE90 File Offset: 0x002BB090
		private void SalesByCategoryAndUser_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadUsers();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x060047C8 RID: 18376 RVA: 0x002BCEE0 File Offset: 0x002BB0E0
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = MyProject.Forms.Form1.datSelectedCategoriesStockTake.Rows.Count > 0;
				if (flag)
				{
					SqlConnection sqlConnection = new SqlConnection(this._cnn);
					using (sqlConnection)
					{
						SqlCommand sqlCommand = new SqlCommand("SalesByCategoryAndUser", sqlConnection);
						sqlCommand.CommandType = CommandType.StoredProcedure;
						sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
						sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
						sqlCommand.Parameters.AddWithValue("startdate", this.DTStartdate.Value.ToString("yyyyMMdd"));
						sqlCommand.Parameters.AddWithValue("enddate", this.DTEnddate.Value.ToString("yyyyMMdd"));
						bool flag2 = !this.chkAllUsers.Checked;
						if (flag2)
						{
							bool flag3 = Operators.CompareString(this.cboUsers.Text, "", false) == 0;
							if (flag3)
							{
								MessageBox.Show("Please select a user first.");
								return;
							}
							sqlCommand.Parameters.AddWithValue("user", this.cboUsers.Text);
						}
						SqlParameter sqlParameter = sqlCommand.Parameters.AddWithValue("@tvpSelectedCategories", MyProject.Forms.Form1.datSelectedCategoriesStockTake);
						sqlParameter.SqlDbType = SqlDbType.Structured;
						DataTable dataTable = new DataTable();
						SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
						sqlDataAdapter.Fill(dataTable);
						this.DataGridView1.DataSource = dataTable;
					}
				}
				else
				{
					MessageBox.Show("Please select the categories first.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading data. Detail: " + ex.Message);
			}
		}

		// Token: 0x060047C9 RID: 18377 RVA: 0x002BD100 File Offset: 0x002BB300
		private void Button3_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.DataGridView1.RowCount > 0;
				if (flag)
				{
					this.SaveFileDialog1.Filter = "CSV Files (*.csv*)|*.csv";
					bool flag2 = this.SaveFileDialog1.ShowDialog() == DialogResult.OK;
					if (flag2)
					{
						this.pf.DATAGRIDVIEW_TO_CSV(this.DataGridView1, this.SaveFileDialog1.FileName);
					}
					MessageBox.Show("Data exported to excel.");
				}
				else
				{
					MessageBox.Show("There are no items to export.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error exporting. Detail: " + ex.Message);
			}
		}

		// Token: 0x060047CA RID: 18378 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label1_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x04001F64 RID: 8036
		private string _cnn;

		// Token: 0x04001F65 RID: 8037
		private PublicFunctions pf;
	}
}
