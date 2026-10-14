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
	// Token: 0x02000021 RID: 33
	[DesignerGenerated]
	public partial class ChangeUserPassword : Form
	{
		// Token: 0x06000694 RID: 1684 RVA: 0x000435E8 File Offset: 0x000417E8
		public ChangeUserPassword()
		{
			base.Load += this.ChangeUserPassword_Load;
			base.Load += this.ChangePwd_Load;
			this.publicfunction = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000697 RID: 1687 RVA: 0x00043B3F File Offset: 0x00041D3F
		// (set) Token: 0x06000698 RID: 1688 RVA: 0x00043B49 File Offset: 0x00041D49
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000699 RID: 1689 RVA: 0x00043B52 File Offset: 0x00041D52
		// (set) Token: 0x0600069A RID: 1690 RVA: 0x00043B5C File Offset: 0x00041D5C
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x0600069B RID: 1691 RVA: 0x00043B65 File Offset: 0x00041D65
		// (set) Token: 0x0600069C RID: 1692 RVA: 0x00043B70 File Offset: 0x00041D70
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

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x0600069D RID: 1693 RVA: 0x00043BB3 File Offset: 0x00041DB3
		// (set) Token: 0x0600069E RID: 1694 RVA: 0x00043BBD File Offset: 0x00041DBD
		internal virtual TextBox txtTeacherPwd2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x0600069F RID: 1695 RVA: 0x00043BC6 File Offset: 0x00041DC6
		// (set) Token: 0x060006A0 RID: 1696 RVA: 0x00043BD0 File Offset: 0x00041DD0
		internal virtual TextBox txtNewPwd
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x060006A1 RID: 1697 RVA: 0x00043BD9 File Offset: 0x00041DD9
		// (set) Token: 0x060006A2 RID: 1698 RVA: 0x00043BE3 File Offset: 0x00041DE3
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x060006A3 RID: 1699 RVA: 0x00043BEC File Offset: 0x00041DEC
		// (set) Token: 0x060006A4 RID: 1700 RVA: 0x00043BF6 File Offset: 0x00041DF6
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x060006A5 RID: 1701 RVA: 0x00043BFF File Offset: 0x00041DFF
		// (set) Token: 0x060006A6 RID: 1702 RVA: 0x00043C09 File Offset: 0x00041E09
		internal virtual ComboBox txtUsername
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x00043C12 File Offset: 0x00041E12
		private void ChangeUserPassword_Load(object sender, EventArgs e)
		{
			this.LoadUsers();
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x00043C1C File Offset: 0x00041E1C
		private void LoadUsers()
		{
			this.txtUsername.DataSource = this.publicfunction.GetUsers(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.Constring);
			this.txtUsername.ValueMember = "Username";
			this.txtUsername.DisplayMember = "Username";
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x00043C81 File Offset: 0x00041E81
		private void ChangePwd_Load(object sender, EventArgs e)
		{
			this.txtUsername.Text = MyProject.Forms.Form1.username;
			base.AcceptButton = this.Button1;
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x00043CAC File Offset: 0x00041EAC
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.ChangePwd();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error changing password. Detail: " + ex.Message);
			}
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x00043CFC File Offset: 0x00041EFC
		private void ChangePwd()
		{
			bool flag = this.CheckID(this.txtUsername.Text);
			if (flag)
			{
				string text = this.publicfunction.Encrypt(this.txtNewPwd.Text, Conversions.ToString(MyProject.Forms.Form1.coid));
				this.UpdateCredentials(this.txtUsername.Text, text);
				MessageBox.Show("Password successfully saved.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				this.clearform();
			}
			else
			{
				MessageBox.Show("The username supplied was not found. Retry.", "Error", MessageBoxButtons.OK);
			}
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x00043D8D File Offset: 0x00041F8D
		private void clearform()
		{
			this.txtUsername.Text = "";
			this.txtNewPwd.Text = "";
			this.txtTeacherPwd2.Text = "";
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x00043DC4 File Offset: 0x00041FC4
		private bool CheckID(string username)
		{
			bool flag = false;
			bool flag2 = Operators.CompareString(username, "POSAdmin", false) != 0;
			if (flag2)
			{
				try
				{
					SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
					SqlCommand sqlCommand = sqlConnection.CreateCommand();
					DataTable dataTable = new DataTable();
					sqlCommand.CommandType = CommandType.StoredProcedure;
					sqlCommand.CommandText = "VerifyUsername";
					sqlCommand.Parameters.AddWithValue("username", username);
					sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
					SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
					int num = sqlDataAdapter.Fill(dataTable);
					DataRow dataRow = dataTable.Rows[0];
					int num2 = checked((int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow["usercount"]))));
					bool flag3 = num2 == 1;
					flag = flag3;
				}
				catch (Exception ex)
				{
					flag = false;
					MessageBox.Show("Cannot change this users pasword.");
					return flag;
				}
			}
			else
			{
				flag = false;
				MessageBox.Show("Cannot reset the default Administrator password- Contact your system administrator.", "Error", MessageBoxButtons.OK);
			}
			return flag;
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x00043F04 File Offset: 0x00042104
		private void UpdateCredentials(string uname, string pwd)
		{
			SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			DataTable dataTable = new DataTable();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "UpdateCredentials";
			sqlCommand.Parameters.AddWithValue("username", uname);
			sqlCommand.Parameters.AddWithValue("pwd", pwd);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			SqlConnection sqlConnection2 = sqlConnection;
			sqlConnection2.Open();
			sqlCommand.ExecuteNonQuery();
			sqlConnection2.Close();
		}

		// Token: 0x04000318 RID: 792
		private PublicFunctions publicfunction;
	}
}
