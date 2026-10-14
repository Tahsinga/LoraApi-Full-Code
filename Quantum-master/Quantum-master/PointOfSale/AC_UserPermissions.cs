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
	// Token: 0x02000007 RID: 7
	[DesignerGenerated]
	public partial class AC_UserPermissions : Form
	{
		// Token: 0x0600011E RID: 286 RVA: 0x0000B1D0 File Offset: 0x000093D0
		public AC_UserPermissions()
		{
			base.Load += this.AC_UserPermissions_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.selected_user = "";
			this.InitializeComponent();
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000121 RID: 289 RVA: 0x0000C0AA File Offset: 0x0000A2AA
		// (set) Token: 0x06000122 RID: 290 RVA: 0x0000C0B4 File Offset: 0x0000A2B4
		internal virtual Panel Panel3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000123 RID: 291 RVA: 0x0000C0BD File Offset: 0x0000A2BD
		// (set) Token: 0x06000124 RID: 292 RVA: 0x0000C0C7 File Offset: 0x0000A2C7
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000125 RID: 293 RVA: 0x0000C0D0 File Offset: 0x0000A2D0
		// (set) Token: 0x06000126 RID: 294 RVA: 0x0000C0DA File Offset: 0x0000A2DA
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000127 RID: 295 RVA: 0x0000C0E3 File Offset: 0x0000A2E3
		// (set) Token: 0x06000128 RID: 296 RVA: 0x0000C0ED File Offset: 0x0000A2ED
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000129 RID: 297 RVA: 0x0000C0F6 File Offset: 0x0000A2F6
		// (set) Token: 0x0600012A RID: 298 RVA: 0x0000C100 File Offset: 0x0000A300
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600012B RID: 299 RVA: 0x0000C109 File Offset: 0x0000A309
		// (set) Token: 0x0600012C RID: 300 RVA: 0x0000C113 File Offset: 0x0000A313
		internal virtual GroupBox GroupBox3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600012D RID: 301 RVA: 0x0000C11C File Offset: 0x0000A31C
		// (set) Token: 0x0600012E RID: 302 RVA: 0x0000C126 File Offset: 0x0000A326
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600012F RID: 303 RVA: 0x0000C12F File Offset: 0x0000A32F
		// (set) Token: 0x06000130 RID: 304 RVA: 0x0000C13C File Offset: 0x0000A33C
		internal virtual Button Button5
		{
			[CompilerGenerated]
			get
			{
				return this._Button5;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button5_Click);
				Button button = this._Button5;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button5 = value;
				button = this._Button5;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000131 RID: 305 RVA: 0x0000C17F File Offset: 0x0000A37F
		// (set) Token: 0x06000132 RID: 306 RVA: 0x0000C18C File Offset: 0x0000A38C
		internal virtual Button Button4
		{
			[CompilerGenerated]
			get
			{
				return this._Button4;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button4_Click);
				Button button = this._Button4;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button4 = value;
				button = this._Button4;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000133 RID: 307 RVA: 0x0000C1CF File Offset: 0x0000A3CF
		// (set) Token: 0x06000134 RID: 308 RVA: 0x0000C1DC File Offset: 0x0000A3DC
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

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000135 RID: 309 RVA: 0x0000C21F File Offset: 0x0000A41F
		// (set) Token: 0x06000136 RID: 310 RVA: 0x0000C22C File Offset: 0x0000A42C
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

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000137 RID: 311 RVA: 0x0000C26F File Offset: 0x0000A46F
		// (set) Token: 0x06000138 RID: 312 RVA: 0x0000C27C File Offset: 0x0000A47C
		internal virtual DataGridView dgvAssignedRoles
		{
			[CompilerGenerated]
			get
			{
				return this._dgvAssignedRoles;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgvAssignedRoles_CellClick);
				DataGridView dataGridView = this._dgvAssignedRoles;
				if (dataGridView != null)
				{
					dataGridView.CellClick -= dataGridViewCellEventHandler;
				}
				this._dgvAssignedRoles = value;
				dataGridView = this._dgvAssignedRoles;
				if (dataGridView != null)
				{
					dataGridView.CellClick += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000139 RID: 313 RVA: 0x0000C2BF File Offset: 0x0000A4BF
		// (set) Token: 0x0600013A RID: 314 RVA: 0x0000C2C9 File Offset: 0x0000A4C9
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600013B RID: 315 RVA: 0x0000C2D2 File Offset: 0x0000A4D2
		// (set) Token: 0x0600013C RID: 316 RVA: 0x0000C2DC File Offset: 0x0000A4DC
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600013D RID: 317 RVA: 0x0000C2E5 File Offset: 0x0000A4E5
		// (set) Token: 0x0600013E RID: 318 RVA: 0x0000C2EF File Offset: 0x0000A4EF
		internal virtual ComboBox cboRoles
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600013F RID: 319 RVA: 0x0000C2F8 File Offset: 0x0000A4F8
		// (set) Token: 0x06000140 RID: 320 RVA: 0x0000C302 File Offset: 0x0000A502
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000141 RID: 321 RVA: 0x0000C30B File Offset: 0x0000A50B
		// (set) Token: 0x06000142 RID: 322 RVA: 0x0000C315 File Offset: 0x0000A515
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000143 RID: 323 RVA: 0x0000C31E File Offset: 0x0000A51E
		// (set) Token: 0x06000144 RID: 324 RVA: 0x0000C328 File Offset: 0x0000A528
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

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000145 RID: 325 RVA: 0x0000C36B File Offset: 0x0000A56B
		// (set) Token: 0x06000146 RID: 326 RVA: 0x0000C378 File Offset: 0x0000A578
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

		// Token: 0x06000147 RID: 327 RVA: 0x0000C3BC File Offset: 0x0000A5BC
		private void AC_UserPermissions_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadUsers();
				this.LoadRoles();
				bool flag = Operators.CompareString(this.selected_user, "", false) != 0;
				if (flag)
				{
					this.cboUsers.SelectedIndex = this.cboUsers.FindStringExact(this.selected_user);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000148 RID: 328 RVA: 0x0000C448 File Offset: 0x0000A648
		private void LoadUsers()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchUsers";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			this.cboUsers.DataSource = dataTable;
			this.cboUsers.ValueMember = "Username";
			this.cboUsers.DisplayMember = "UserName";
		}

		// Token: 0x06000149 RID: 329 RVA: 0x0000C4E8 File Offset: 0x0000A6E8
		private void loadUserPermissions(string username)
		{
			DataTable allowedPagesForUsername = this.pf.GetAllowedPagesForUsername(username, this._cnn);
			DataTable menuDAT = MyProject.Forms.MainMenu.menuDAT;
			this.dgvAssignedRoles.DataSource = menuDAT;
			this.dgvAssignedRoles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvAssignedRoles.Columns["MenuLevel"].Visible = false;
			try
			{
				foreach (object obj in ((IEnumerable)this.dgvAssignedRoles.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					dataGridViewRow.DefaultCellStyle.BackColor = Color.Red;
					bool flag = dataGridViewRow.Index > 0;
					if (flag)
					{
						DataGridViewRow dataGridViewRow2 = dataGridViewRow;
						bool flag2 = Operators.ConditionalCompareObjectNotEqual(dataGridViewRow2.Cells[1].Value, 1, false);
						DataGridViewRow dataGridViewRow3;
						if (flag2)
						{
							bool flag3 = Operators.ConditionalCompareObjectGreater(dataGridViewRow2.Cells[1].Value, dataGridViewRow3.Cells[1].Value, false);
							if (flag3)
							{
								dataGridViewRow3.Cells[1].Style.BackColor = Color.LightGray;
								dataGridViewRow3.DefaultCellStyle.BackColor = Color.Gray;
							}
							else
							{
								try
								{
									foreach (object obj2 in allowedPagesForUsername.Rows)
									{
										DataRow dataRow = (DataRow)obj2;
										bool flag4 = Operators.CompareString(dataRow["AllowedPage"].ToString(), dataGridViewRow3.Cells[0].Value.ToString(), false) == 0;
										if (flag4)
										{
											dataGridViewRow3.Cells[0].Style.BackColor = Color.Green;
										}
									}
								}
								finally
								{
									IEnumerator enumerator2;
									if (enumerator2 is IDisposable)
									{
										(enumerator2 as IDisposable).Dispose();
									}
								}
							}
						}
						dataGridViewRow3 = dataGridViewRow2;
					}
					else
					{
						DataGridViewRow dataGridViewRow3 = dataGridViewRow;
					}
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

		// Token: 0x0600014A RID: 330 RVA: 0x0000C728 File Offset: 0x0000A928
		private void loadRolePermissions(string rolename)
		{
			DataTable dataTable = new DataTable();
			this.dgvAssignedRoles.DataSource = dataTable;
			DataTable allowedPagesForRole = this.GetAllowedPagesForRole(rolename);
			DataTable menuDAT = MyProject.Forms.MainMenu.menuDAT;
			this.dgvAssignedRoles.DataSource = menuDAT;
			this.dgvAssignedRoles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvAssignedRoles.Columns["MenuLevel"].Visible = false;
			try
			{
				foreach (object obj in ((IEnumerable)this.dgvAssignedRoles.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					dataGridViewRow.DefaultCellStyle.BackColor = Color.Red;
					bool flag = dataGridViewRow.Index > 0;
					if (flag)
					{
						DataGridViewRow dataGridViewRow2 = dataGridViewRow;
						bool flag2 = Operators.ConditionalCompareObjectNotEqual(dataGridViewRow2.Cells[1].Value, 1, false);
						DataGridViewRow dataGridViewRow3;
						if (flag2)
						{
							bool flag3 = Operators.ConditionalCompareObjectGreater(dataGridViewRow2.Cells[1].Value, dataGridViewRow3.Cells[1].Value, false);
							if (flag3)
							{
								dataGridViewRow3.Cells[1].Style.BackColor = Color.LightGray;
								dataGridViewRow3.DefaultCellStyle.BackColor = Color.Gray;
							}
							else
							{
								try
								{
									foreach (object obj2 in allowedPagesForRole.Rows)
									{
										DataRow dataRow = (DataRow)obj2;
										bool flag4 = Operators.CompareString(dataRow["AllowedPages"].ToString(), dataGridViewRow3.Cells[0].Value.ToString(), false) == 0;
										if (flag4)
										{
											dataGridViewRow3.Cells[0].Style.BackColor = Color.Green;
										}
									}
								}
								finally
								{
									IEnumerator enumerator2;
									if (enumerator2 is IDisposable)
									{
										(enumerator2 as IDisposable).Dispose();
									}
								}
							}
						}
						dataGridViewRow3 = dataGridViewRow2;
					}
					else
					{
						DataGridViewRow dataGridViewRow3 = dataGridViewRow;
					}
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

		// Token: 0x0600014B RID: 331 RVA: 0x0000C974 File Offset: 0x0000AB74
		private DataTable GetAllowedPagesForRole(string rolename)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "AC_SelectAllowedPagesForRole";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("rolename", rolename);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0000C9FC File Offset: 0x0000ABFC
		private void SelectAll()
		{
			try
			{
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvAssignedRoles.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						bool flag = dataGridViewRow.Cells[0].Style.BackColor != Color.Gray;
						if (flag)
						{
							dataGridViewRow.Cells[0].Style.BackColor = Color.Green;
						}
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
			catch (Exception ex)
			{
				MessageBox.Show("Error deselecting. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0000CAD4 File Offset: 0x0000ACD4
		private void Deselect()
		{
			try
			{
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvAssignedRoles.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						bool flag = dataGridViewRow.Cells[0].Style.BackColor != Color.Gray;
						if (flag)
						{
							dataGridViewRow.Cells[0].Style.BackColor = Color.Red;
						}
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
			catch (Exception ex)
			{
				MessageBox.Show("Error deselecting. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600014E RID: 334 RVA: 0x0000CBAC File Offset: 0x0000ADAC
		private void Button3_Click(object sender, EventArgs e)
		{
			try
			{
				this.SelectAll();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Select All Error. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600014F RID: 335 RVA: 0x0000CBFC File Offset: 0x0000ADFC
		private void Button4_Click(object sender, EventArgs e)
		{
			try
			{
				this.Deselect();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error deselecting. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0000CC4C File Offset: 0x0000AE4C
		private void LoadRoles()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "AC_SelectRoleNames";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			this.cboRoles.DataSource = dataTable;
			this.cboRoles.ValueMember = "RoleName";
			this.cboRoles.DisplayMember = "RoleName";
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0000CCEC File Offset: 0x0000AEEC
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.cboRoles.Text, "", false) != 0;
				if (flag)
				{
					this.loadRolePermissions(this.cboRoles.Text);
				}
				else
				{
					MessageBox.Show("Please select a role first.");
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0000CD5C File Offset: 0x0000AF5C
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.cboUsers.Text, "", false) != 0;
				if (flag)
				{
					this.loadUserPermissions(this.cboUsers.Text);
				}
				else
				{
					MessageBox.Show("Please select a user first.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading permissions: " + ex.Message);
			}
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0000CDE4 File Offset: 0x0000AFE4
		private void cboUsers_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.cboUsers.Text, "", false) != 0;
				if (flag)
				{
					this.Deselect();
					this.loadUserPermissions(this.cboUsers.Text);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0000CE50 File Offset: 0x0000B050
		private void Button5_Click(object sender, EventArgs e)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.Connection = sqlConnection;
			sqlConnection.Open();
			SqlTransaction sqlTransaction = sqlConnection.BeginTransaction("RunProductDetailsSaveAll");
			sqlCommand.Transaction = sqlTransaction;
			try
			{
				sqlCommand.Parameters.Clear();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "AC_DeleteAllowedPagesForUser";
				sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
				sqlCommand.Parameters.AddWithValue("username", this.cboUsers.Text);
				sqlCommand.ExecuteNonQuery();
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvAssignedRoles.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						bool flag = dataGridViewRow.Cells[0].Style.BackColor == Color.Green;
						if (flag)
						{
							sqlCommand.Parameters.Clear();
							sqlCommand.CommandType = CommandType.StoredProcedure;
							sqlCommand.CommandText = "AC_InsertAllowedPagesForUser";
							sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
							sqlCommand.Parameters.AddWithValue("username", this.cboUsers.Text);
							sqlCommand.Parameters.AddWithValue("allowedpage", dataGridViewRow.Cells[0].Value.ToString());
							sqlCommand.ExecuteNonQuery();
						}
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
				sqlTransaction.Commit();
				sqlCommand.Connection.Close();
				MessageBox.Show("Permissions have been successfully set.");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving permission settings. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000155 RID: 341 RVA: 0x0000D080 File Offset: 0x0000B280
		private void dgvAssignedRoles_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = e.ColumnIndex != -1;
				if (flag)
				{
					bool flag2 = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor != Color.Gray;
					if (flag2)
					{
						bool flag3 = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor != Color.Green;
						if (flag3)
						{
							dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Green;
						}
						else
						{
							dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Red;
						}
						dataGridView.ClearSelection();
					}
					else
					{
						MessageBox.Show("Grayed out items are menu items. IGNORE when assigning permissions.");
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error detail: " + ex.Message);
			}
		}

		// Token: 0x0400008D RID: 141
		private string _cnn;

		// Token: 0x0400008E RID: 142
		private PublicFunctions pf;

		// Token: 0x0400008F RID: 143
		public string selected_user;
	}
}
