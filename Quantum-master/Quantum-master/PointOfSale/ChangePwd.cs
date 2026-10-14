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
	// Token: 0x02000020 RID: 32
	[DesignerGenerated]
	public partial class ChangePwd : Form
	{
		// Token: 0x0600067B RID: 1659 RVA: 0x00042CC9 File Offset: 0x00040EC9
		public ChangePwd()
		{
			base.Load += this.ChangePwd_Load;
			this.publicfunction = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x0600067E RID: 1662 RVA: 0x000431F4 File Offset: 0x000413F4
		// (set) Token: 0x0600067F RID: 1663 RVA: 0x000431FE File Offset: 0x000413FE
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000680 RID: 1664 RVA: 0x00043207 File Offset: 0x00041407
		// (set) Token: 0x06000681 RID: 1665 RVA: 0x00043211 File Offset: 0x00041411
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000682 RID: 1666 RVA: 0x0004321A File Offset: 0x0004141A
		// (set) Token: 0x06000683 RID: 1667 RVA: 0x00043224 File Offset: 0x00041424
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

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000684 RID: 1668 RVA: 0x00043267 File Offset: 0x00041467
		// (set) Token: 0x06000685 RID: 1669 RVA: 0x00043271 File Offset: 0x00041471
		internal virtual TextBox txtTeacherPwd2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000686 RID: 1670 RVA: 0x0004327A File Offset: 0x0004147A
		// (set) Token: 0x06000687 RID: 1671 RVA: 0x00043284 File Offset: 0x00041484
		internal virtual TextBox txtNewPwd
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000688 RID: 1672 RVA: 0x0004328D File Offset: 0x0004148D
		// (set) Token: 0x06000689 RID: 1673 RVA: 0x00043297 File Offset: 0x00041497
		internal virtual TextBox txtUsername
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x0600068A RID: 1674 RVA: 0x000432A0 File Offset: 0x000414A0
		// (set) Token: 0x0600068B RID: 1675 RVA: 0x000432AA File Offset: 0x000414AA
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x0600068C RID: 1676 RVA: 0x000432B3 File Offset: 0x000414B3
		// (set) Token: 0x0600068D RID: 1677 RVA: 0x000432BD File Offset: 0x000414BD
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x000432C6 File Offset: 0x000414C6
		private void ChangePwd_Load(object sender, EventArgs e)
		{
			this.txtUsername.Text = MyProject.Forms.Form1.username;
			base.AcceptButton = this.Button1;
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x000432F4 File Offset: 0x000414F4
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

		// Token: 0x06000690 RID: 1680 RVA: 0x00043344 File Offset: 0x00041544
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

		// Token: 0x06000691 RID: 1681 RVA: 0x000433D5 File Offset: 0x000415D5
		private void clearform()
		{
			this.txtUsername.Text = "";
			this.txtNewPwd.Text = "";
			this.txtTeacherPwd2.Text = "";
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x0004340C File Offset: 0x0004160C
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

		// Token: 0x06000693 RID: 1683 RVA: 0x00043540 File Offset: 0x00041740
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

		// Token: 0x0400030E RID: 782
		private PublicFunctions publicfunction;
	}
}
