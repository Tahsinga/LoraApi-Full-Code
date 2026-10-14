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
	// Token: 0x02000209 RID: 521
	[DesignerGenerated]
	public partial class VerifyOpenImpReports : Form
	{
		// Token: 0x06005DEA RID: 24042 RVA: 0x0035CF94 File Offset: 0x0035B194
		public VerifyOpenImpReports()
		{
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x170021EC RID: 8684
		// (get) Token: 0x06005DED RID: 24045 RVA: 0x0035D21E File Offset: 0x0035B41E
		// (set) Token: 0x06005DEE RID: 24046 RVA: 0x0035D228 File Offset: 0x0035B428
		internal virtual TextBox TextBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170021ED RID: 8685
		// (get) Token: 0x06005DEF RID: 24047 RVA: 0x0035D231 File Offset: 0x0035B431
		// (set) Token: 0x06005DF0 RID: 24048 RVA: 0x0035D23C File Offset: 0x0035B43C
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

		// Token: 0x170021EE RID: 8686
		// (get) Token: 0x06005DF1 RID: 24049 RVA: 0x0035D27F File Offset: 0x0035B47F
		// (set) Token: 0x06005DF2 RID: 24050 RVA: 0x0035D289 File Offset: 0x0035B489
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06005DF3 RID: 24051 RVA: 0x0035D294 File Offset: 0x0035B494
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				DataTable dataTable = new DataTable();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "GetCompanySP";
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				sqlDataAdapter.Fill(dataTable);
				bool flag = dataTable.Rows.Count > 0;
				if (flag)
				{
					DataRow dataRow = dataTable.Rows[0];
					string text = dataRow["SP"].ToString();
					bool flag2 = Operators.CompareString(this.TextBox1.Text, text, false) == 0;
					if (flag2)
					{
						MyProject.Forms.Form1.OpenImpReports = 1;
					}
					else
					{
						MyProject.Forms.Form1.OpenImpReports = 0;
					}
				}
				base.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error verifying user. Detail: " + ex.Message);
			}
		}

		// Token: 0x04002918 RID: 10520
		private string _cnn;
	}
}
