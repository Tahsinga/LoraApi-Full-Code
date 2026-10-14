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
	// Token: 0x02000006 RID: 6
	[DesignerGenerated]
	public partial class AC_SetRoles : Form
	{
		// Token: 0x060000E6 RID: 230 RVA: 0x0000961C File Offset: 0x0000781C
		public AC_SetRoles()
		{
			base.Load += this.AC_SetRoles_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x0000A28B File Offset: 0x0000848B
		// (set) Token: 0x060000EA RID: 234 RVA: 0x0000A295 File Offset: 0x00008495
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000EB RID: 235 RVA: 0x0000A29E File Offset: 0x0000849E
		// (set) Token: 0x060000EC RID: 236 RVA: 0x0000A2A8 File Offset: 0x000084A8
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

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000ED RID: 237 RVA: 0x0000A2EB File Offset: 0x000084EB
		// (set) Token: 0x060000EE RID: 238 RVA: 0x0000A2F5 File Offset: 0x000084F5
		internal virtual TextBox txtRoleName
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000EF RID: 239 RVA: 0x0000A2FE File Offset: 0x000084FE
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x0000A308 File Offset: 0x00008508
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x0000A311 File Offset: 0x00008511
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x0000A31B File Offset: 0x0000851B
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x0000A324 File Offset: 0x00008524
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x0000A32E File Offset: 0x0000852E
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x0000A337 File Offset: 0x00008537
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x0000A344 File Offset: 0x00008544
		internal virtual ComboBox cboRoles
		{
			[CompilerGenerated]
			get
			{
				return this._cboRoles;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cboRoles_SelectedIndexChanged);
				ComboBox comboBox = this._cboRoles;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= eventHandler;
				}
				this._cboRoles = value;
				comboBox = this._cboRoles;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x0000A387 File Offset: 0x00008587
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x0000A394 File Offset: 0x00008594
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
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgvAssignedRoles_CellContentClick);
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

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x0000A3D7 File Offset: 0x000085D7
		// (set) Token: 0x060000FA RID: 250 RVA: 0x0000A3E4 File Offset: 0x000085E4
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

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000FB RID: 251 RVA: 0x0000A427 File Offset: 0x00008627
		// (set) Token: 0x060000FC RID: 252 RVA: 0x0000A434 File Offset: 0x00008634
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

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060000FD RID: 253 RVA: 0x0000A477 File Offset: 0x00008677
		// (set) Token: 0x060000FE RID: 254 RVA: 0x0000A484 File Offset: 0x00008684
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

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060000FF RID: 255 RVA: 0x0000A4C7 File Offset: 0x000086C7
		// (set) Token: 0x06000100 RID: 256 RVA: 0x0000A4D4 File Offset: 0x000086D4
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

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000101 RID: 257 RVA: 0x0000A517 File Offset: 0x00008717
		// (set) Token: 0x06000102 RID: 258 RVA: 0x0000A521 File Offset: 0x00008721
		internal virtual GroupBox GroupBox3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000103 RID: 259 RVA: 0x0000A52A File Offset: 0x0000872A
		// (set) Token: 0x06000104 RID: 260 RVA: 0x0000A534 File Offset: 0x00008734
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000105 RID: 261 RVA: 0x0000A53D File Offset: 0x0000873D
		// (set) Token: 0x06000106 RID: 262 RVA: 0x0000A547 File Offset: 0x00008747
		internal virtual Panel Panel3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000107 RID: 263 RVA: 0x0000A550 File Offset: 0x00008750
		// (set) Token: 0x06000108 RID: 264 RVA: 0x0000A55A File Offset: 0x0000875A
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000109 RID: 265 RVA: 0x0000A563 File Offset: 0x00008763
		// (set) Token: 0x0600010A RID: 266 RVA: 0x0000A56D File Offset: 0x0000876D
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600010B RID: 267 RVA: 0x0000A576 File Offset: 0x00008776
		// (set) Token: 0x0600010C RID: 268 RVA: 0x0000A580 File Offset: 0x00008780
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600010D RID: 269 RVA: 0x0000A589 File Offset: 0x00008789
		// (set) Token: 0x0600010E RID: 270 RVA: 0x0000A593 File Offset: 0x00008793
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0000A59C File Offset: 0x0000879C
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.txtRoleName.Text, "", false) != 0;
				if (flag)
				{
					this.InsertRole();
					this.LoadRoles();
					MessageBox.Show("Role added successfully.");
				}
			}
			catch (SqlException ex)
			{
				bool flag2 = ex.Number == 2627;
				if (flag2)
				{
					MessageBox.Show("Role name already exists. Database error.");
				}
				else
				{
					MessageBox.Show("Database error. Detail: " + ex.Message);
				}
			}
			catch (Exception ex2)
			{
				MessageBox.Show("Error saving role. Detail: " + ex2.Message);
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0000A670 File Offset: 0x00008870
		private void InsertRole()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "AC_InsertRoleName";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("rolename", this.txtRoleName.Text);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0000A71C File Offset: 0x0000891C
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

		// Token: 0x06000112 RID: 274 RVA: 0x0000A7BC File Offset: 0x000089BC
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

		// Token: 0x06000113 RID: 275 RVA: 0x0000A844 File Offset: 0x00008A44
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				this.LoadRoleSettings(this.cboRoles.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaing roles. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000114 RID: 276 RVA: 0x0000A8A0 File Offset: 0x00008AA0
		private void AC_SetRoles_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadRoles();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail:" + ex.Message);
			}
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0000A8F0 File Offset: 0x00008AF0
		private void cboRoles_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000116 RID: 278 RVA: 0x0000A924 File Offset: 0x00008B24
		private void LoadRoleSettings(string rolename)
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

		// Token: 0x06000117 RID: 279 RVA: 0x0000AB70 File Offset: 0x00008D70
		private void dgvAssignedRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

		// Token: 0x06000118 RID: 280 RVA: 0x0000ACD4 File Offset: 0x00008ED4
		private void RemoveGrays()
		{
			try
			{
				foreach (object obj in ((IEnumerable)this.dgvAssignedRoles.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					bool flag = dataGridViewRow.Cells[0].Style.BackColor == Color.Gray;
					if (flag)
					{
						this.dgvAssignedRoles.Rows[dataGridViewRow.Index].Visible = false;
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

		// Token: 0x06000119 RID: 281 RVA: 0x0000AD78 File Offset: 0x00008F78
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
				sqlCommand.CommandText = "AC_DeleteAllowedPagesForRole";
				sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
				sqlCommand.Parameters.AddWithValue("rolename", this.cboRoles.Text);
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
							sqlCommand.CommandText = "AC_InsertAllowedPagesForRole";
							sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
							sqlCommand.Parameters.AddWithValue("rolename", this.cboRoles.Text);
							sqlCommand.Parameters.AddWithValue("pagename", dataGridViewRow.Cells[0].Value.ToString());
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

		// Token: 0x0600011A RID: 282 RVA: 0x0000AFA8 File Offset: 0x000091A8
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

		// Token: 0x0600011B RID: 283 RVA: 0x0000AFF8 File Offset: 0x000091F8
		private void Deselect()
		{
			try
			{
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvAssignedRoles.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						bool flag = dataGridViewRow.DefaultCellStyle.BackColor != Color.Gray;
						if (flag)
						{
							dataGridViewRow.DefaultCellStyle.BackColor = Color.Red;
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

		// Token: 0x0600011C RID: 284 RVA: 0x0000B0BC File Offset: 0x000092BC
		private void SelectAll()
		{
			try
			{
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvAssignedRoles.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						bool flag = dataGridViewRow.DefaultCellStyle.BackColor != Color.Gray;
						if (flag)
						{
							dataGridViewRow.DefaultCellStyle.BackColor = Color.Green;
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

		// Token: 0x0600011D RID: 285 RVA: 0x0000B180 File Offset: 0x00009380
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

		// Token: 0x04000077 RID: 119
		private string _cnn;

		// Token: 0x04000078 RID: 120
		private PublicFunctions pf;
	}
}
