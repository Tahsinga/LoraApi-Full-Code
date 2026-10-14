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
	// Token: 0x0200000D RID: 13
	[DesignerGenerated]
	public partial class ApprovalForm : Form
	{
		// Token: 0x0600025F RID: 607 RVA: 0x00015150 File Offset: 0x00013350
		public ApprovalForm()
		{
			base.Load += this.ApprovalForm_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000262 RID: 610 RVA: 0x0001564D File Offset: 0x0001384D
		// (set) Token: 0x06000263 RID: 611 RVA: 0x00015657 File Offset: 0x00013857
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000264 RID: 612 RVA: 0x00015660 File Offset: 0x00013860
		// (set) Token: 0x06000265 RID: 613 RVA: 0x0001566A File Offset: 0x0001386A
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000266 RID: 614 RVA: 0x00015673 File Offset: 0x00013873
		// (set) Token: 0x06000267 RID: 615 RVA: 0x0001567D File Offset: 0x0001387D
		internal virtual TextBox txtPassword
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000268 RID: 616 RVA: 0x00015686 File Offset: 0x00013886
		// (set) Token: 0x06000269 RID: 617 RVA: 0x00015690 File Offset: 0x00013890
		internal virtual ComboBox cboUsernames
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x0600026A RID: 618 RVA: 0x00015699 File Offset: 0x00013899
		// (set) Token: 0x0600026B RID: 619 RVA: 0x000156A4 File Offset: 0x000138A4
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

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600026C RID: 620 RVA: 0x000156E7 File Offset: 0x000138E7
		// (set) Token: 0x0600026D RID: 621 RVA: 0x000156F1 File Offset: 0x000138F1
		internal virtual Label lblHeader
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x0600026E RID: 622 RVA: 0x000156FC File Offset: 0x000138FC
		private void ApprovalForm_Load(object sender, EventArgs e)
		{
			try
			{
				MyProject.Forms.Form1.approved = false;
				this.LoadUsers();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600026F RID: 623 RVA: 0x0001575C File Offset: 0x0001395C
		private void LoadUsers()
		{
			this.cboUsernames.DataSource = this.pf.GetUsers(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.Constring);
			this.cboUsernames.ValueMember = "Username";
			this.cboUsernames.DisplayMember = "Username";
			this.cboUsernames.SelectedIndex = -1;
		}

		// Token: 0x06000270 RID: 624 RVA: 0x000157D0 File Offset: 0x000139D0
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.ValidateCredentials(this.cboUsernames.Text, this.txtPassword.Text, MyProject.Forms.Form1.branch);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00015844 File Offset: 0x00013A44
		private void ValidateCredentials(string uname, string pwd, string branch)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			DataTable dataTable = new DataTable();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "CheckUsername";
			sqlCommand.Parameters.AddWithValue("username", uname);
			sqlCommand.Parameters.AddWithValue("pwd", this.pf.Encrypt(pwd, Conversions.ToString(MyProject.Forms.Form1.coid)));
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			bool flag = dataTable.Rows.Count > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				bool flag2 = Conversions.ToBoolean(dataRow["IsActive"]);
				if (flag2)
				{
					bool flag3 = Operators.CompareString(uname, dataRow["username"].ToString(), false) == 0;
					if (flag3)
					{
						bool flag4 = Conversions.ToBoolean(dataRow["IsAllBranches"]);
						if (flag4)
						{
							bool flag5 = Conversions.ToBoolean(dataRow["isadmin"]);
							if (flag5)
							{
								MyProject.Forms.Form1.approved = true;
							}
							bool flag6 = Conversions.ToBoolean(dataRow["issup"]);
							if (flag6)
							{
								MyProject.Forms.Form1.approved = true;
							}
							MessageBox.Show("APPROVED.");
							base.Dispose();
						}
						else
						{
							bool flag7 = Operators.CompareString(dataRow["branch"].ToString(), MyProject.Forms.Form1.branch, false) == 0;
							if (flag7)
							{
								bool flag8 = Conversions.ToBoolean(dataRow["isadmin"]) | Conversions.ToBoolean(dataRow["issup"]);
								if (flag8)
								{
									MyProject.Forms.Form1.approved = true;
								}
								MessageBox.Show("APPROVED.");
								base.Dispose();
							}
							else
							{
								MessageBox.Show("Invalid username or branch");
								MyProject.Forms.Form1.approved = false;
							}
						}
					}
					else
					{
						MessageBox.Show("Invalid username.");
						MyProject.Forms.Form1.approved = false;
					}
				}
				else
				{
					MessageBox.Show("User is deactivated.");
					MyProject.Forms.Form1.approved = false;
				}
			}
			else
			{
				MessageBox.Show("Invalid username and password.");
				MyProject.Forms.Form1.approved = false;
			}
		}

		// Token: 0x0400010E RID: 270
		private string _cnn;

		// Token: 0x0400010F RID: 271
		private PublicFunctions pf;
	}
}
