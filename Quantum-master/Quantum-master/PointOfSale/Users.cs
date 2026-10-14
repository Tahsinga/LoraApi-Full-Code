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
	// Token: 0x02000207 RID: 519
	[DesignerGenerated]
	public partial class Users : Form
	{
		// Token: 0x06005D53 RID: 23891 RVA: 0x00358838 File Offset: 0x00356A38
		public Users()
		{
			base.Load += this.Users_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.publicfunction = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x170021AC RID: 8620
		// (get) Token: 0x06005D56 RID: 23894 RVA: 0x00359D4A File Offset: 0x00357F4A
		// (set) Token: 0x06005D57 RID: 23895 RVA: 0x00359D54 File Offset: 0x00357F54
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021AD RID: 8621
		// (get) Token: 0x06005D58 RID: 23896 RVA: 0x00359D5D File Offset: 0x00357F5D
		// (set) Token: 0x06005D59 RID: 23897 RVA: 0x00359D67 File Offset: 0x00357F67
		internal virtual Label lblerrmsg
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021AE RID: 8622
		// (get) Token: 0x06005D5A RID: 23898 RVA: 0x00359D70 File Offset: 0x00357F70
		// (set) Token: 0x06005D5B RID: 23899 RVA: 0x00359D7A File Offset: 0x00357F7A
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021AF RID: 8623
		// (get) Token: 0x06005D5C RID: 23900 RVA: 0x00359D83 File Offset: 0x00357F83
		// (set) Token: 0x06005D5D RID: 23901 RVA: 0x00359D90 File Offset: 0x00357F90
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

		// Token: 0x170021B0 RID: 8624
		// (get) Token: 0x06005D5E RID: 23902 RVA: 0x00359DD3 File Offset: 0x00357FD3
		// (set) Token: 0x06005D5F RID: 23903 RVA: 0x00359DE0 File Offset: 0x00357FE0
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

		// Token: 0x170021B1 RID: 8625
		// (get) Token: 0x06005D60 RID: 23904 RVA: 0x00359E23 File Offset: 0x00358023
		// (set) Token: 0x06005D61 RID: 23905 RVA: 0x00359E30 File Offset: 0x00358030
		internal virtual TextBox txtPwd2
		{
			[CompilerGenerated]
			get
			{
				return this._txtPwd2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.txtPwd2_TextChanged);
				TextBox textBox = this._txtPwd2;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
				}
				this._txtPwd2 = value;
				textBox = this._txtPwd2;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x170021B2 RID: 8626
		// (get) Token: 0x06005D62 RID: 23906 RVA: 0x00359E73 File Offset: 0x00358073
		// (set) Token: 0x06005D63 RID: 23907 RVA: 0x00359E7D File Offset: 0x0035807D
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021B3 RID: 8627
		// (get) Token: 0x06005D64 RID: 23908 RVA: 0x00359E86 File Offset: 0x00358086
		// (set) Token: 0x06005D65 RID: 23909 RVA: 0x00359E90 File Offset: 0x00358090
		internal virtual TextBox txtPwd
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021B4 RID: 8628
		// (get) Token: 0x06005D66 RID: 23910 RVA: 0x00359E99 File Offset: 0x00358099
		// (set) Token: 0x06005D67 RID: 23911 RVA: 0x00359EA3 File Offset: 0x003580A3
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021B5 RID: 8629
		// (get) Token: 0x06005D68 RID: 23912 RVA: 0x00359EAC File Offset: 0x003580AC
		// (set) Token: 0x06005D69 RID: 23913 RVA: 0x00359EB6 File Offset: 0x003580B6
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021B6 RID: 8630
		// (get) Token: 0x06005D6A RID: 23914 RVA: 0x00359EBF File Offset: 0x003580BF
		// (set) Token: 0x06005D6B RID: 23915 RVA: 0x00359ECC File Offset: 0x003580CC
		internal virtual TextBox txtUsername
		{
			[CompilerGenerated]
			get
			{
				return this._txtUsername;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.txtUsername_Leave);
				TextBox textBox = this._txtUsername;
				if (textBox != null)
				{
					textBox.Leave -= eventHandler;
				}
				this._txtUsername = value;
				textBox = this._txtUsername;
				if (textBox != null)
				{
					textBox.Leave += eventHandler;
				}
			}
		}

		// Token: 0x170021B7 RID: 8631
		// (get) Token: 0x06005D6C RID: 23916 RVA: 0x00359F0F File Offset: 0x0035810F
		// (set) Token: 0x06005D6D RID: 23917 RVA: 0x00359F1C File Offset: 0x0035811C
		internal virtual DataGridView DataGridView1
		{
			[CompilerGenerated]
			get
			{
				return this._DataGridView1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
				DataGridView dataGridView = this._DataGridView1;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick -= dataGridViewCellEventHandler;
				}
				this._DataGridView1 = value;
				dataGridView = this._DataGridView1;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x170021B8 RID: 8632
		// (get) Token: 0x06005D6E RID: 23918 RVA: 0x00359F5F File Offset: 0x0035815F
		// (set) Token: 0x06005D6F RID: 23919 RVA: 0x00359F69 File Offset: 0x00358169
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021B9 RID: 8633
		// (get) Token: 0x06005D70 RID: 23920 RVA: 0x00359F72 File Offset: 0x00358172
		// (set) Token: 0x06005D71 RID: 23921 RVA: 0x00359F7C File Offset: 0x0035817C
		internal virtual RadioButton rbTeller
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021BA RID: 8634
		// (get) Token: 0x06005D72 RID: 23922 RVA: 0x00359F85 File Offset: 0x00358185
		// (set) Token: 0x06005D73 RID: 23923 RVA: 0x00359F8F File Offset: 0x0035818F
		internal virtual RadioButton rbSup
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021BB RID: 8635
		// (get) Token: 0x06005D74 RID: 23924 RVA: 0x00359F98 File Offset: 0x00358198
		// (set) Token: 0x06005D75 RID: 23925 RVA: 0x00359FA2 File Offset: 0x003581A2
		internal virtual ComboBox cboBranches
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021BC RID: 8636
		// (get) Token: 0x06005D76 RID: 23926 RVA: 0x00359FAB File Offset: 0x003581AB
		// (set) Token: 0x06005D77 RID: 23927 RVA: 0x00359FB5 File Offset: 0x003581B5
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021BD RID: 8637
		// (get) Token: 0x06005D78 RID: 23928 RVA: 0x00359FBE File Offset: 0x003581BE
		// (set) Token: 0x06005D79 RID: 23929 RVA: 0x00359FC8 File Offset: 0x003581C8
		internal virtual CheckBox chkAllBranches
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021BE RID: 8638
		// (get) Token: 0x06005D7A RID: 23930 RVA: 0x00359FD1 File Offset: 0x003581D1
		// (set) Token: 0x06005D7B RID: 23931 RVA: 0x00359FDB File Offset: 0x003581DB
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021BF RID: 8639
		// (get) Token: 0x06005D7C RID: 23932 RVA: 0x00359FE4 File Offset: 0x003581E4
		// (set) Token: 0x06005D7D RID: 23933 RVA: 0x00359FEE File Offset: 0x003581EE
		internal virtual TextBox txtRealName
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021C0 RID: 8640
		// (get) Token: 0x06005D7E RID: 23934 RVA: 0x00359FF7 File Offset: 0x003581F7
		// (set) Token: 0x06005D7F RID: 23935 RVA: 0x0035A001 File Offset: 0x00358201
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021C1 RID: 8641
		// (get) Token: 0x06005D80 RID: 23936 RVA: 0x0035A00A File Offset: 0x0035820A
		// (set) Token: 0x06005D81 RID: 23937 RVA: 0x0035A014 File Offset: 0x00358214
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021C2 RID: 8642
		// (get) Token: 0x06005D82 RID: 23938 RVA: 0x0035A01D File Offset: 0x0035821D
		// (set) Token: 0x06005D83 RID: 23939 RVA: 0x0035A027 File Offset: 0x00358227
		internal virtual Label Label9
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021C3 RID: 8643
		// (get) Token: 0x06005D84 RID: 23940 RVA: 0x0035A030 File Offset: 0x00358230
		// (set) Token: 0x06005D85 RID: 23941 RVA: 0x0035A03A File Offset: 0x0035823A
		internal virtual CheckBox chkAdmin
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021C4 RID: 8644
		// (get) Token: 0x06005D86 RID: 23942 RVA: 0x0035A043 File Offset: 0x00358243
		// (set) Token: 0x06005D87 RID: 23943 RVA: 0x0035A04D File Offset: 0x0035824D
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021C5 RID: 8645
		// (get) Token: 0x06005D88 RID: 23944 RVA: 0x0035A056 File Offset: 0x00358256
		// (set) Token: 0x06005D89 RID: 23945 RVA: 0x0035A060 File Offset: 0x00358260
		internal virtual Label Label10
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021C6 RID: 8646
		// (get) Token: 0x06005D8A RID: 23946 RVA: 0x0035A069 File Offset: 0x00358269
		// (set) Token: 0x06005D8B RID: 23947 RVA: 0x0035A073 File Offset: 0x00358273
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021C7 RID: 8647
		// (get) Token: 0x06005D8C RID: 23948 RVA: 0x0035A07C File Offset: 0x0035827C
		// (set) Token: 0x06005D8D RID: 23949 RVA: 0x0035A088 File Offset: 0x00358288
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

		// Token: 0x170021C8 RID: 8648
		// (get) Token: 0x06005D8E RID: 23950 RVA: 0x0035A0CB File Offset: 0x003582CB
		// (set) Token: 0x06005D8F RID: 23951 RVA: 0x0035A0D5 File Offset: 0x003582D5
		internal virtual Label lblinfor
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06005D90 RID: 23952 RVA: 0x000140EE File Offset: 0x000122EE
		private void Button2_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06005D91 RID: 23953 RVA: 0x0035A0E0 File Offset: 0x003582E0
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = false;
				bool @checked = this.rbSup.Checked;
				if (@checked)
				{
					flag = true;
				}
				else
				{
					bool checked2 = this.rbTeller.Checked;
					if (checked2)
					{
					}
				}
				bool checked3 = this.chkAllBranches.Checked;
				bool flag2;
				if (checked3)
				{
					flag2 = true;
				}
				else
				{
					flag2 = false;
					bool flag3 = Operators.CompareString(this.cboBranches.Text, "", false) == 0;
					if (flag3)
					{
						MessageBox.Show("Please select a branch for this user. ");
						this.cboBranches.Focus();
						return;
					}
				}
				bool checked4 = this.chkAdmin.Checked;
				bool flag4 = checked4;
				this.publicfunction.SaveCredentials(Strings.Trim(this.txtUsername.Text), this.publicfunction.Encrypt(this.txtPwd2.Text, Conversions.ToString(MyProject.Forms.Form1.coid)), flag4, flag, this.cboBranches.Text, flag2, this.txtRealName.Text, Convert.ToInt32(DateTime.Today.ToString("yyyyMMdd")), MyProject.Forms.Form1.username, this._cnn, MyProject.Forms.Form1.coid);
				this.LoadUsers();
				this.ClearForm();
				this.Button1.Enabled = false;
			}
			catch (SqlException ex)
			{
				bool flag5 = ex.Number == 2601;
				if (flag5)
				{
					MessageBox.Show("Please ensure that the user ID does not already exist in the system", "User ID error", MessageBoxButtons.OK);
				}
				else
				{
					MessageBox.Show("An error has occured. Contact your system administrator. Detailed error: " + ex.Message, "Error", MessageBoxButtons.OK);
				}
			}
			catch (Exception ex2)
			{
				MessageBox.Show("An error has occured. Contact your system administrator. Detailed error: " + ex2.Message, "Error", MessageBoxButtons.OK);
			}
		}

		// Token: 0x06005D92 RID: 23954 RVA: 0x0035A304 File Offset: 0x00358504
		private void ClearForm()
		{
			this.txtPwd.Text = "";
			this.txtPwd2.Text = "";
			this.txtUsername.Text = "";
			this.txtUsername.Focus();
			this.txtRealName.Text = "";
		}

		// Token: 0x06005D93 RID: 23955 RVA: 0x0035A364 File Offset: 0x00358564
		private void txtPwd2_TextChanged(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.txtPwd2.Text, this.txtPwd.Text, false) != 0;
			if (flag)
			{
				this.lblerrmsg.Text = "Passwords do not match";
				this.lblerrmsg.ForeColor = Color.Red;
				this.Button1.Enabled = false;
			}
			else
			{
				this.lblerrmsg.Text = "Passwords match";
				this.lblerrmsg.ForeColor = Color.Green;
				this.Button1.Enabled = true;
			}
		}

		// Token: 0x06005D94 RID: 23956 RVA: 0x0035A3F8 File Offset: 0x003585F8
		private void LoadUsers()
		{
			try
			{
				this.DataGridView1.Columns.Clear();
				this.lblinfor.Text = "Viewing Active Users";
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				DataTable dataTable = new DataTable();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "FetchUsers";
				sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				sqlDataAdapter.Fill(dataTable);
				this.DataGridView1.DataSource = dataTable;
				this.DataGridView1.Columns["Password"].Visible = false;
				this.DataGridView1.Columns["EntryNo"].Visible = false;
				this.DataGridView1.Columns["DeactivatedBy"].Visible = false;
				this.DataGridView1.Columns["DeactivatedDate"].Visible = false;
				this.DataGridView1.Columns["Uploaded"].Visible = false;
				this.DataGridView1.Columns["coid"].Visible = false;
				this.DataGridView1.Columns["DateCreated"].HeaderText = "Date Created (DD/MM/YYYY)";
				this.DataGridView1.Columns["IsSup"].HeaderText = "Is Supervisor?";
				this.DataGridView1.Columns["IsAdmin"].HeaderText = "Is Administrator?";
				DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
				dataGridViewButtonColumn.HeaderText = "Deactivate";
				dataGridViewButtonColumn.Text = "Deactivate";
				dataGridViewButtonColumn.Name = "Deactivate";
				dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
				this.DataGridView1.Columns.Add(dataGridViewButtonColumn);
				DataGridViewButtonColumn dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
				dataGridViewButtonColumn2.HeaderText = "Change Supervisor Status";
				dataGridViewButtonColumn2.Text = "Change Supervisor Status";
				dataGridViewButtonColumn2.Name = "Change Supervisor Status";
				dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
				this.DataGridView1.Columns.Add(dataGridViewButtonColumn2);
				DataGridViewButtonColumn dataGridViewButtonColumn3 = new DataGridViewButtonColumn();
				dataGridViewButtonColumn3.HeaderText = "Change Admin Status";
				dataGridViewButtonColumn3.Text = "Change Admin Status";
				dataGridViewButtonColumn3.Name = "Change Admin Status";
				dataGridViewButtonColumn3.UseColumnTextForButtonValue = true;
				this.DataGridView1.Columns.Add(dataGridViewButtonColumn3);
				DataGridViewButtonColumn dataGridViewButtonColumn4 = new DataGridViewButtonColumn();
				dataGridViewButtonColumn4.HeaderText = "Set User Permissions";
				dataGridViewButtonColumn4.Text = "Set User Permissions";
				dataGridViewButtonColumn4.Name = "UserPermissions";
				dataGridViewButtonColumn4.UseColumnTextForButtonValue = true;
				this.DataGridView1.Columns.Add(dataGridViewButtonColumn4);
				DataGridViewButtonColumn dataGridViewButtonColumn5 = new DataGridViewButtonColumn();
				dataGridViewButtonColumn5.HeaderText = "Activate";
				dataGridViewButtonColumn5.Text = "Activate";
				dataGridViewButtonColumn5.Name = "Activate";
				dataGridViewButtonColumn5.UseColumnTextForButtonValue = true;
				this.DataGridView1.Columns.Add(dataGridViewButtonColumn5);
				this.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error has occured. Detailed error: " + ex.Message, "Error", MessageBoxButtons.OK);
			}
		}

		// Token: 0x06005D95 RID: 23957 RVA: 0x0035A76C File Offset: 0x0035896C
		private void LoadUsersAll()
		{
			try
			{
				this.DataGridView1.Columns.Clear();
				this.lblinfor.Text = "Viewing Active and Deactivated Users";
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				DataTable dataTable = new DataTable();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "FetchUsersAll";
				sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				sqlDataAdapter.Fill(dataTable);
				this.DataGridView1.DataSource = dataTable;
				this.DataGridView1.Columns["Password"].Visible = false;
				this.DataGridView1.Columns["EntryNo"].Visible = false;
				this.DataGridView1.Columns["DeactivatedBy"].Visible = false;
				this.DataGridView1.Columns["DeactivatedDate"].Visible = false;
				this.DataGridView1.Columns["Uploaded"].Visible = false;
				this.DataGridView1.Columns["coid"].Visible = false;
				this.DataGridView1.Columns["DateCreated"].HeaderText = "Date Created (DD/MM/YYYY)";
				this.DataGridView1.Columns["IsSup"].HeaderText = "Is Supervisor?";
				this.DataGridView1.Columns["IsAdmin"].HeaderText = "Is Administrator?";
				DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
				dataGridViewButtonColumn.HeaderText = "Deactivate";
				dataGridViewButtonColumn.Text = "Deactivate";
				dataGridViewButtonColumn.Name = "Deactivate";
				dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
				this.DataGridView1.Columns.Add(dataGridViewButtonColumn);
				DataGridViewButtonColumn dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
				dataGridViewButtonColumn2.HeaderText = "Change Supervisor Status";
				dataGridViewButtonColumn2.Text = "Change Supervisor Status";
				dataGridViewButtonColumn2.Name = "Change Supervisor Status";
				dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
				this.DataGridView1.Columns.Add(dataGridViewButtonColumn2);
				DataGridViewButtonColumn dataGridViewButtonColumn3 = new DataGridViewButtonColumn();
				dataGridViewButtonColumn3.HeaderText = "Change Admin Status";
				dataGridViewButtonColumn3.Text = "Change Admin Status";
				dataGridViewButtonColumn3.Name = "Change Admin Status";
				dataGridViewButtonColumn3.UseColumnTextForButtonValue = true;
				this.DataGridView1.Columns.Add(dataGridViewButtonColumn3);
				DataGridViewButtonColumn dataGridViewButtonColumn4 = new DataGridViewButtonColumn();
				dataGridViewButtonColumn4.HeaderText = "Activate";
				dataGridViewButtonColumn4.Text = "Activate";
				dataGridViewButtonColumn4.Name = "Activate";
				dataGridViewButtonColumn4.UseColumnTextForButtonValue = true;
				this.DataGridView1.Columns.Add(dataGridViewButtonColumn4);
				this.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error has occured. Detailed error: " + ex.Message, "Error", MessageBoxButtons.OK);
			}
		}

		// Token: 0x06005D96 RID: 23958 RVA: 0x0035AA98 File Offset: 0x00358C98
		private void Users_Load(object sender, EventArgs e)
		{
			try
			{
				base.WindowState = FormWindowState.Maximized;
				this.LoadUsers();
				this.LoadBranches();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying form. Details: " + ex.Message);
			}
		}

		// Token: 0x06005D97 RID: 23959 RVA: 0x0035AAF8 File Offset: 0x00358CF8
		private void LoadBranches()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchBranches";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			this.cboBranches.DataSource = dataTable;
			this.cboBranches.ValueMember = "branch";
			this.cboBranches.DisplayMember = "branch";
			this.cboBranches.SelectedIndex = -1;
		}

		// Token: 0x06005D98 RID: 23960 RVA: 0x0035ABA4 File Offset: 0x00358DA4
		private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					bool flag2 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "Deactivate", false) == 0;
					if (flag2)
					{
						DialogResult dialogResult = (DialogResult)Interaction.MsgBox("Are you sure you want to deactivate this user?" + dataGridView.Rows[e.RowIndex].Cells["RealName"].Value.ToString(), MsgBoxStyle.YesNo, null);
						bool flag3 = dialogResult == DialogResult.Yes;
						if (flag3)
						{
							SqlConnection sqlConnection = new SqlConnection(this._cnn);
							SqlCommand sqlCommand = sqlConnection.CreateCommand();
							sqlCommand.CommandType = CommandType.StoredProcedure;
							sqlCommand.CommandText = "UserDeactivate";
							sqlCommand.Parameters.AddWithValue("username", dataGridView.Rows[e.RowIndex].Cells["username"].Value.ToString());
							sqlCommand.Parameters.AddWithValue("datedeactivated", Convert.ToInt32(DateTime.Today.ToString("yyyyMMdd")));
							sqlCommand.Parameters.AddWithValue("deactivatedby", MyProject.Forms.Form1.username);
							sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
							using (sqlConnection)
							{
								sqlConnection.Open();
								sqlCommand.ExecuteNonQuery();
								sqlConnection.Close();
							}
							MessageBox.Show("User Deactivated.");
							this.LoadUsers();
						}
					}
					else
					{
						bool flag4 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "Change Supervisor Status", false) == 0;
						if (flag4)
						{
							SqlConnection sqlConnection3 = new SqlConnection(this._cnn);
							SqlCommand sqlCommand2 = sqlConnection3.CreateCommand();
							sqlCommand2.CommandType = CommandType.StoredProcedure;
							sqlCommand2.CommandText = "UserSupervisorChange";
							sqlCommand2.Parameters.AddWithValue("username", dataGridView.Rows[e.RowIndex].Cells["username"].Value.ToString());
							sqlCommand2.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
							using (sqlConnection3)
							{
								sqlConnection3.Open();
								sqlCommand2.ExecuteNonQuery();
								sqlConnection3.Close();
							}
							MessageBox.Show("User Supervisor Status changed.");
							this.LoadUsers();
						}
						else
						{
							bool flag5 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "Change Admin Status", false) == 0;
							if (flag5)
							{
								SqlConnection sqlConnection5 = new SqlConnection(this._cnn);
								SqlCommand sqlCommand3 = sqlConnection5.CreateCommand();
								sqlCommand3.CommandType = CommandType.StoredProcedure;
								sqlCommand3.CommandText = "UserAdminChange";
								sqlCommand3.Parameters.AddWithValue("username", dataGridView.Rows[e.RowIndex].Cells["username"].Value.ToString());
								sqlCommand3.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
								using (sqlConnection5)
								{
									sqlConnection5.Open();
									sqlCommand3.ExecuteNonQuery();
									sqlConnection5.Close();
								}
								MessageBox.Show("User Admin Status changed.");
								this.LoadUsers();
							}
							else
							{
								bool flag6 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "UserPermissions", false) == 0;
								if (flag6)
								{
									AC_UserPermissions ac_UserPermissions = new AC_UserPermissions();
									ac_UserPermissions.selected_user = dataGridView.Rows[e.RowIndex].Cells["username"].Value.ToString();
									ac_UserPermissions.ShowDialog(this);
									ac_UserPermissions.Dispose();
								}
								else
								{
									bool flag7 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "Activate", false) == 0;
									if (flag7)
									{
										DialogResult dialogResult2 = (DialogResult)Interaction.MsgBox("Are you sure you want to Activate this user?" + dataGridView.Rows[e.RowIndex].Cells["RealName"].Value.ToString(), MsgBoxStyle.YesNo, null);
										bool flag8 = dialogResult2 == DialogResult.Yes;
										if (flag8)
										{
											SqlConnection sqlConnection7 = new SqlConnection(this._cnn);
											SqlCommand sqlCommand4 = sqlConnection7.CreateCommand();
											sqlCommand4.CommandType = CommandType.Text;
											sqlCommand4.CommandText = string.Concat(new string[]
											{
												"Update users set isactive=1, deactivateddate=0,deactivatedby='",
												MyProject.Forms.Form1.username,
												"' where username='",
												dataGridView.Rows[e.RowIndex].Cells["username"].Value.ToString(),
												"' and coid=",
												Conversions.ToString(MyProject.Forms.Form1.coid)
											});
											using (sqlConnection7)
											{
												sqlConnection7.Open();
												sqlCommand4.ExecuteNonQuery();
												sqlConnection7.Close();
											}
											MessageBox.Show("User Activated.");
											this.LoadUsers();
										}
									}
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error occurred. Details: " + ex.Message);
			}
		}

		// Token: 0x06005D99 RID: 23961 RVA: 0x0035B1FC File Offset: 0x003593FC
		private void Button3_Click(object sender, EventArgs e)
		{
			try
			{
				this.LoadUsersAll();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error showing users. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005D9A RID: 23962 RVA: 0x0035B24C File Offset: 0x0035944C
		private void txtUsername_Leave(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.txtUsername.Text, "Admin", false) == 0;
				if (flag)
				{
					MessageBox.Show("Cannot creat a user named Admin. Please try Admin1 or any other username.");
					this.txtUsername.Focus();
					this.txtUsername.SelectAll();
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x040028ED RID: 10477
		private string _cnn;

		// Token: 0x040028EE RID: 10478
		private PublicFunctions publicfunction;
	}
}
