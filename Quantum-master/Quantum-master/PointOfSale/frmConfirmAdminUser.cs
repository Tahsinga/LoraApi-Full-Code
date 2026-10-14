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
	// Token: 0x02000060 RID: 96
	[DesignerGenerated]
	public partial class frmConfirmAdminUser : Form
	{
		// Token: 0x06001406 RID: 5126 RVA: 0x000BD590 File Offset: 0x000BB790
		public frmConfirmAdminUser()
		{
			base.Load += this.frmConfirmAdminUser_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.publicfunction = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x06001409 RID: 5129 RVA: 0x000BD9D3 File Offset: 0x000BBBD3
		// (set) Token: 0x0600140A RID: 5130 RVA: 0x000BD9DD File Offset: 0x000BBBDD
		internal virtual TextBox txtPwd
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x0600140B RID: 5131 RVA: 0x000BD9E6 File Offset: 0x000BBBE6
		// (set) Token: 0x0600140C RID: 5132 RVA: 0x000BD9F0 File Offset: 0x000BBBF0
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x0600140D RID: 5133 RVA: 0x000BD9F9 File Offset: 0x000BBBF9
		// (set) Token: 0x0600140E RID: 5134 RVA: 0x000BDA03 File Offset: 0x000BBC03
		internal virtual TextBox txtUsername
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x0600140F RID: 5135 RVA: 0x000BDA0C File Offset: 0x000BBC0C
		// (set) Token: 0x06001410 RID: 5136 RVA: 0x000BDA16 File Offset: 0x000BBC16
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x06001411 RID: 5137 RVA: 0x000BDA1F File Offset: 0x000BBC1F
		// (set) Token: 0x06001412 RID: 5138 RVA: 0x000BDA2C File Offset: 0x000BBC2C
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

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x06001413 RID: 5139 RVA: 0x000BDA6F File Offset: 0x000BBC6F
		// (set) Token: 0x06001414 RID: 5140 RVA: 0x000BDA79 File Offset: 0x000BBC79
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06001415 RID: 5141 RVA: 0x00002A30 File Offset: 0x00000C30
		private void frmConfirmAdminUser_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06001416 RID: 5142 RVA: 0x000BDA84 File Offset: 0x000BBC84
		private bool ValidateCredentials(string uname, string pwd)
		{
			bool flag = false;
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			DataTable dataTable = new DataTable();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "CheckUsername";
			sqlCommand.Parameters.AddWithValue("username", uname);
			sqlCommand.Parameters.AddWithValue("pwd", pwd);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			bool flag2 = dataTable.Rows.Count > 0;
			if (flag2)
			{
				DataRow dataRow = dataTable.Rows[0];
				bool flag3 = Operators.CompareString(uname, dataRow["username"].ToString(), false) == 0;
				if (flag3)
				{
					bool flag4 = Conversions.ToBoolean(dataRow["isadmin"]);
					flag = flag4;
				}
				else
				{
					flag = false;
				}
			}
			return flag;
		}

		// Token: 0x06001417 RID: 5143 RVA: 0x000BDB90 File Offset: 0x000BBD90
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.ValidateCredentials(this.txtUsername.Text, this.publicfunction.Encrypt(this.txtPwd.Text, Conversions.ToString(MyProject.Forms.Form1.coid)));
				if (flag)
				{
					MyProject.Forms.Form1.tillchangeprice = 1;
					base.Dispose();
				}
				else
				{
					MyProject.Forms.Form1.tillchangeprice = 0;
					base.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error. Detail: " + ex.Message);
			}
		}

		// Token: 0x04000A31 RID: 2609
		private string _cnn;

		// Token: 0x04000A32 RID: 2610
		private PublicFunctions publicfunction;
	}
}
