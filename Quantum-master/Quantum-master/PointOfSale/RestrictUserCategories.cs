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
	// Token: 0x02000185 RID: 389
	[DesignerGenerated]
	public partial class RestrictUserCategories : Form
	{
		// Token: 0x060039CE RID: 14798 RVA: 0x001F6832 File Offset: 0x001F4A32
		public RestrictUserCategories()
		{
			base.Load += this.RestrictUserCategories_Load;
			this.InitializeComponent();
		}

		// Token: 0x17001558 RID: 5464
		// (get) Token: 0x060039D1 RID: 14801 RVA: 0x001F6EB2 File Offset: 0x001F50B2
		// (set) Token: 0x060039D2 RID: 14802 RVA: 0x001F6EBC File Offset: 0x001F50BC
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001559 RID: 5465
		// (get) Token: 0x060039D3 RID: 14803 RVA: 0x001F6EC5 File Offset: 0x001F50C5
		// (set) Token: 0x060039D4 RID: 14804 RVA: 0x001F6ECF File Offset: 0x001F50CF
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700155A RID: 5466
		// (get) Token: 0x060039D5 RID: 14805 RVA: 0x001F6ED8 File Offset: 0x001F50D8
		// (set) Token: 0x060039D6 RID: 14806 RVA: 0x001F6EE2 File Offset: 0x001F50E2
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700155B RID: 5467
		// (get) Token: 0x060039D7 RID: 14807 RVA: 0x001F6EEB File Offset: 0x001F50EB
		// (set) Token: 0x060039D8 RID: 14808 RVA: 0x001F6EF5 File Offset: 0x001F50F5
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700155C RID: 5468
		// (get) Token: 0x060039D9 RID: 14809 RVA: 0x001F6EFE File Offset: 0x001F50FE
		// (set) Token: 0x060039DA RID: 14810 RVA: 0x001F6F08 File Offset: 0x001F5108
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

		// Token: 0x1700155D RID: 5469
		// (get) Token: 0x060039DB RID: 14811 RVA: 0x001F6F4B File Offset: 0x001F514B
		// (set) Token: 0x060039DC RID: 14812 RVA: 0x001F6F58 File Offset: 0x001F5158
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

		// Token: 0x1700155E RID: 5470
		// (get) Token: 0x060039DD RID: 14813 RVA: 0x001F6F9B File Offset: 0x001F519B
		// (set) Token: 0x060039DE RID: 14814 RVA: 0x001F6FA5 File Offset: 0x001F51A5
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700155F RID: 5471
		// (get) Token: 0x060039DF RID: 14815 RVA: 0x001F6FAE File Offset: 0x001F51AE
		// (set) Token: 0x060039E0 RID: 14816 RVA: 0x001F6FB8 File Offset: 0x001F51B8
		internal virtual DataGridView dgvCats
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001560 RID: 5472
		// (get) Token: 0x060039E1 RID: 14817 RVA: 0x001F6FC1 File Offset: 0x001F51C1
		// (set) Token: 0x060039E2 RID: 14818 RVA: 0x001F6FCB File Offset: 0x001F51CB
		internal virtual Label lblCurrent
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060039E3 RID: 14819 RVA: 0x001F6FD4 File Offset: 0x001F51D4
		private void RestrictUserCategories_Load(object sender, EventArgs e)
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

		// Token: 0x060039E4 RID: 14820 RVA: 0x001F7024 File Offset: 0x001F5224
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

		// Token: 0x060039E5 RID: 14821 RVA: 0x001F70CC File Offset: 0x001F52CC
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				DataTable dataTable = new DataTable();
				MyProject.Forms.Form1.datSelectedCategories = dataTable;
				SelectCategories selectCategories = new SelectCategories();
				selectCategories.ShowDialog(this);
				selectCategories.Dispose();
				this.DeleteCatForUser(this.cboUsers.Text, MyProject.Forms.Form1.coid);
				bool flag = MyProject.Forms.Form1.datSelectedCategories.Rows.Count > 0;
				if (flag)
				{
					try
					{
						foreach (object obj in MyProject.Forms.Form1.datSelectedCategories.Rows)
						{
							DataRow dataRow = (DataRow)obj;
							this.InsertCatForUser(this.cboUsers.Text, Conversions.ToInteger(dataRow["Category"]), MyProject.Forms.Form1.coid);
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
				else
				{
					MessageBox.Show("no categories selected. User will have access to all categories.");
				}
				this.LoadCategoriesForUser(this.cboUsers.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error processing. Detail: " + ex.Message);
			}
		}

		// Token: 0x060039E6 RID: 14822 RVA: 0x001F724C File Offset: 0x001F544C
		private void LoadCategoriesForUser(string username)
		{
			SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			DataTable dataTable = new DataTable();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchUserCatIDs2";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("username", username);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			this.dgvCats.DataSource = dataTable;
			this.lblCurrent.Text = "Viewing allowed Categories for user " + username;
		}

		// Token: 0x060039E7 RID: 14823 RVA: 0x001F72FC File Offset: 0x001F54FC
		private void InsertCatForUser(string username, int catid, int coid)
		{
			SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "InsertCatIDForUser";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("username", username);
			sqlCommand.Parameters.AddWithValue("catid", catid);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x060039E8 RID: 14824 RVA: 0x001F73C0 File Offset: 0x001F55C0
		private void DeleteCatForUser(string username, int coid)
		{
			SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "DeleteCatIDForUser";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("username", username);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x060039E9 RID: 14825 RVA: 0x001F746C File Offset: 0x001F566C
		private void cboUsers_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.LoadCategoriesForUser(this.cboUsers.Text);
			}
			catch (Exception ex)
			{
			}
		}
	}
}
