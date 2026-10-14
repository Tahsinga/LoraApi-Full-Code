using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;

namespace PointOfSale
{
	// Token: 0x0200004A RID: 74
	[DesignerGenerated]
	public partial class EditBatchNumber : Form
	{
		// Token: 0x06000FBD RID: 4029 RVA: 0x000950C4 File Offset: 0x000932C4
		public EditBatchNumber()
		{
			base.Load += this.EditBatchNumber_Load;
			this.entryno = 0;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06000FC0 RID: 4032 RVA: 0x00095821 File Offset: 0x00093A21
		// (set) Token: 0x06000FC1 RID: 4033 RVA: 0x0009582B File Offset: 0x00093A2B
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06000FC2 RID: 4034 RVA: 0x00095834 File Offset: 0x00093A34
		// (set) Token: 0x06000FC3 RID: 4035 RVA: 0x0009583E File Offset: 0x00093A3E
		internal virtual Label lbloldexpirydate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06000FC4 RID: 4036 RVA: 0x00095847 File Offset: 0x00093A47
		// (set) Token: 0x06000FC5 RID: 4037 RVA: 0x00095851 File Offset: 0x00093A51
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06000FC6 RID: 4038 RVA: 0x0009585A File Offset: 0x00093A5A
		// (set) Token: 0x06000FC7 RID: 4039 RVA: 0x00095864 File Offset: 0x00093A64
		internal virtual Label lbloldbatchnumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06000FC8 RID: 4040 RVA: 0x0009586D File Offset: 0x00093A6D
		// (set) Token: 0x06000FC9 RID: 4041 RVA: 0x00095877 File Offset: 0x00093A77
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06000FCA RID: 4042 RVA: 0x00095880 File Offset: 0x00093A80
		// (set) Token: 0x06000FCB RID: 4043 RVA: 0x0009588A File Offset: 0x00093A8A
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06000FCC RID: 4044 RVA: 0x00095893 File Offset: 0x00093A93
		// (set) Token: 0x06000FCD RID: 4045 RVA: 0x000958A0 File Offset: 0x00093AA0
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

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06000FCE RID: 4046 RVA: 0x000958E3 File Offset: 0x00093AE3
		// (set) Token: 0x06000FCF RID: 4047 RVA: 0x000958ED File Offset: 0x00093AED
		internal virtual DateTimePicker DTNewExpDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06000FD0 RID: 4048 RVA: 0x000958F6 File Offset: 0x00093AF6
		// (set) Token: 0x06000FD1 RID: 4049 RVA: 0x00095900 File Offset: 0x00093B00
		internal virtual TextBox txtNewBatchNum
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06000FD2 RID: 4050 RVA: 0x00095909 File Offset: 0x00093B09
		// (set) Token: 0x06000FD3 RID: 4051 RVA: 0x00095913 File Offset: 0x00093B13
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06000FD4 RID: 4052 RVA: 0x0009591C File Offset: 0x00093B1C
		// (set) Token: 0x06000FD5 RID: 4053 RVA: 0x00095926 File Offset: 0x00093B26
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06000FD6 RID: 4054 RVA: 0x00095930 File Offset: 0x00093B30
		private void EditBatchNumber_Load(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.Text;
				sqlCommand.CommandText = string.Concat(new string[]
				{
					"select batchnumber, expirydate from movement where coid=",
					Conversions.ToString(this.coid),
					" and branch='",
					this.branch,
					"' and entryno=",
					Conversions.ToString(this.entryno)
				});
				DataTable dataTable = new DataTable();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				int num = sqlDataAdapter.Fill(dataTable);
				bool flag = num > 0;
				if (flag)
				{
					DataRow dataRow = dataTable.Rows[0];
					this.lbloldbatchnumber.Text = Conversions.ToString(dataRow["batchnumber"]);
					this.lbloldexpirydate.Text = Conversions.ToString(dataRow["expirydate"]);
					this.txtNewBatchNum.Text = Conversions.ToString(dataRow["batchnumber"]);
					string text = dataRow["expirydate"].ToString();
					DateTime dateTime = DateTime.ParseExact(text, "yyyyMMdd", DateTimeFormatInfo.InvariantInfo);
					this.DTNewExpDate.Value = dateTime;
				}
				else
				{
					MessageBox.Show("No valid entry number provided. Error.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000FD7 RID: 4055 RVA: 0x00095ABC File Offset: 0x00093CBC
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = (Operators.CompareString(this.lbloldbatchnumber.Text, "...", false) == 0) | (this.entryno == 0);
				if (flag)
				{
					MessageBox.Show("Please restart. Invalid entryno provided, invalid batch number");
				}
				else
				{
					SqlConnection sqlConnection = new SqlConnection(this._cnn);
					SqlCommand sqlCommand = sqlConnection.CreateCommand();
					sqlCommand.CommandType = CommandType.StoredProcedure;
					sqlCommand.CommandText = "UpdateBatchNumbers";
					sqlCommand.Parameters.AddWithValue("coid", this.coid);
					sqlCommand.Parameters.AddWithValue("branch", this.branch);
					sqlCommand.Parameters.AddWithValue("entryno", this.entryno);
					sqlCommand.Parameters.AddWithValue("batchnum", this.txtNewBatchNum.Text);
					sqlCommand.Parameters.AddWithValue("expdate", Conversions.ToInteger(this.DTNewExpDate.Value.ToString("yyyyMMdd")));
					using (sqlConnection)
					{
						sqlConnection.Open();
						sqlCommand.ExecuteNonQuery();
						sqlConnection.Close();
					}
					MessageBox.Show("Record successfully updated.");
					base.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error processing. Detail: " + ex.Message);
			}
		}

		// Token: 0x04000793 RID: 1939
		public int entryno;

		// Token: 0x04000794 RID: 1940
		public int coid;

		// Token: 0x04000795 RID: 1941
		public string branch;

		// Token: 0x04000796 RID: 1942
		private string _cnn;
	}
}
