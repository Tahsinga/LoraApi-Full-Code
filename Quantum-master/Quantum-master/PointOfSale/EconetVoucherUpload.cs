using System;
using System.Collections;
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
	// Token: 0x02000048 RID: 72
	[DesignerGenerated]
	public partial class EconetVoucherUpload : Form
	{
		// Token: 0x06000F73 RID: 3955 RVA: 0x00091890 File Offset: 0x0008FA90
		public EconetVoucherUpload()
		{
			base.Load += this.EconetVoucherUpload_Load;
			this.pf = new PublicFunctions();
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06000F76 RID: 3958 RVA: 0x000921EF File Offset: 0x000903EF
		// (set) Token: 0x06000F77 RID: 3959 RVA: 0x000921F9 File Offset: 0x000903F9
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06000F78 RID: 3960 RVA: 0x00092202 File Offset: 0x00090402
		// (set) Token: 0x06000F79 RID: 3961 RVA: 0x0009220C File Offset: 0x0009040C
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

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06000F7A RID: 3962 RVA: 0x0009224F File Offset: 0x0009044F
		// (set) Token: 0x06000F7B RID: 3963 RVA: 0x00092259 File Offset: 0x00090459
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06000F7C RID: 3964 RVA: 0x00092262 File Offset: 0x00090462
		// (set) Token: 0x06000F7D RID: 3965 RVA: 0x0009226C File Offset: 0x0009046C
		internal virtual ComboBox cboBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06000F7E RID: 3966 RVA: 0x00092275 File Offset: 0x00090475
		// (set) Token: 0x06000F7F RID: 3967 RVA: 0x00092280 File Offset: 0x00090480
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

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06000F80 RID: 3968 RVA: 0x000922C3 File Offset: 0x000904C3
		// (set) Token: 0x06000F81 RID: 3969 RVA: 0x000922CD File Offset: 0x000904CD
		internal virtual TextBox txtpath
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06000F82 RID: 3970 RVA: 0x000922D6 File Offset: 0x000904D6
		// (set) Token: 0x06000F83 RID: 3971 RVA: 0x000922E0 File Offset: 0x000904E0
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06000F84 RID: 3972 RVA: 0x000922E9 File Offset: 0x000904E9
		// (set) Token: 0x06000F85 RID: 3973 RVA: 0x000922F3 File Offset: 0x000904F3
		internal virtual TextBox txtRef
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06000F86 RID: 3974 RVA: 0x000922FC File Offset: 0x000904FC
		// (set) Token: 0x06000F87 RID: 3975 RVA: 0x00092306 File Offset: 0x00090506
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06000F88 RID: 3976 RVA: 0x0009230F File Offset: 0x0009050F
		// (set) Token: 0x06000F89 RID: 3977 RVA: 0x00092319 File Offset: 0x00090519
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06000F8A RID: 3978 RVA: 0x00092322 File Offset: 0x00090522
		// (set) Token: 0x06000F8B RID: 3979 RVA: 0x0009232C File Offset: 0x0009052C
		internal virtual Label lblUpdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06000F8C RID: 3980 RVA: 0x00092335 File Offset: 0x00090535
		// (set) Token: 0x06000F8D RID: 3981 RVA: 0x0009233F File Offset: 0x0009053F
		internal virtual OpenFileDialog OpenFileDialog1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06000F8E RID: 3982 RVA: 0x00092348 File Offset: 0x00090548
		// (set) Token: 0x06000F8F RID: 3983 RVA: 0x00092352 File Offset: 0x00090552
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06000F90 RID: 3984 RVA: 0x0009235B File Offset: 0x0009055B
		// (set) Token: 0x06000F91 RID: 3985 RVA: 0x00092365 File Offset: 0x00090565
		internal virtual ComboBox cboCategories
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06000F92 RID: 3986 RVA: 0x0009236E File Offset: 0x0009056E
		// (set) Token: 0x06000F93 RID: 3987 RVA: 0x00092378 File Offset: 0x00090578
		internal virtual TextBox txtRate
		{
			[CompilerGenerated]
			get
			{
				return this._txtRate;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtRate_KeyPress);
				TextBox textBox = this._txtRate;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtRate = value;
				textBox = this._txtRate;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06000F94 RID: 3988 RVA: 0x000923BB File Offset: 0x000905BB
		// (set) Token: 0x06000F95 RID: 3989 RVA: 0x000923C5 File Offset: 0x000905C5
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06000F96 RID: 3990 RVA: 0x000923D0 File Offset: 0x000905D0
		private void EconetVoucherUpload_Load(object sender, EventArgs e)
		{
			try
			{
				base.MaximizeBox = false;
				this.cboBranch.DataSource = this.pf.GetBranches(this._cnn);
				this.cboBranch.DisplayMember = "Branch";
				this.cboBranch.ValueMember = "Branch";
				this.cboBranch.SelectedIndex = -1;
				this.cboCategories.DataSource = this.pf.LoadCategories(this._cnn);
				this.cboCategories.DisplayMember = "CatDesc";
				this.cboCategories.ValueMember = "CatID";
				this.cboCategories.SelectedIndex = -1;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Details: " + ex.Message);
			}
		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x000924B8 File Offset: 0x000906B8
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.OpenFileDialog1.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					this.txtpath.Text = this.OpenFileDialog1.FileName;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading file. Error detail: " + ex.Message);
			}
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x0009252C File Offset: 0x0009072C
		private void Button2_Click(object sender, EventArgs e)
		{
			DataTable dataFromFile = this.pf.GetDataFromFile(this._cnn, this.txtpath.Text, "|");
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.Connection = sqlConnection;
			sqlConnection.Open();
			SqlTransaction sqlTransaction = sqlConnection.BeginTransaction("RunConfirmedSale");
			try
			{
				sqlCommand.Transaction = sqlTransaction;
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.Parameters.Clear();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "GetNewInvoiceNumber";
				sqlCommand.Parameters.AddWithValue("desc", DateTime.Today.ToString("yyyyMMdd") + DateAndTime.Now.TimeOfDay.ToString());
				sqlCommand.Parameters.AddWithValue("newinvoicenum", 0);
				int num = Conversions.ToInteger(sqlCommand.ExecuteScalar());
				try
				{
					foreach (object obj in dataFromFile.Rows)
					{
						DataRow dataRow = (DataRow)obj;
						string text = "Econet Airtime " + dataRow[3].ToString();
						sqlCommand.Parameters.Clear();
						sqlCommand.CommandType = CommandType.Text;
						sqlCommand.CommandText = "select * from products where productdesc='" + text + "' and coid=" + MyProject.Forms.Form1.coid.ToString();
						DataTable dataTable = new DataTable();
						SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
						int num2 = sqlDataAdapter.Fill(dataTable);
						bool flag = num2 == 1;
						if (flag)
						{
							DataRow dataRow2 = dataTable.Rows[0];
							this.newID = Conversions.ToInteger(dataRow2["productid"]);
							this.newProductCode = Conversions.ToString(dataRow2["productcode"]);
						}
						else
						{
							this.newID = 0;
						}
						bool flag2 = this.newID == 0;
						if (flag2)
						{
							sqlCommand.Parameters.Clear();
							sqlCommand.CommandType = CommandType.StoredProcedure;
							sqlCommand.CommandText = "FetchNextProductCode";
							sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
							SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter(sqlCommand);
							DataTable dataTable2 = new DataTable();
							sqlDataAdapter2.Fill(dataTable2);
							DataRow dataRow3 = dataTable2.Rows[0];
							this.newProductCode = dataRow3["NextProductCode"].ToString();
							sqlCommand.Parameters.Clear();
							sqlCommand.CommandType = CommandType.StoredProcedure;
							sqlCommand.CommandText = "InsertNewProduct5";
							sqlCommand.Parameters.AddWithValue("catid", RuntimeHelpers.GetObjectValue(this.cboCategories.SelectedValue));
							sqlCommand.Parameters.AddWithValue("productdesc", text);
							sqlCommand.Parameters.AddWithValue("cost", 0);
							sqlCommand.Parameters.AddWithValue("sellingprice", decimal.Divide(Conversions.ToDecimal(dataRow[3]), Conversions.ToDecimal(this.txtRate.Text)));
							sqlCommand.Parameters.AddWithValue("reorderlevel", 0);
							sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
							sqlCommand.Parameters.AddWithValue("donewhen", DateTime.Today.ToString("yyyyMMdd"));
							sqlCommand.Parameters.AddWithValue("productcode", this.newProductCode);
							sqlCommand.Parameters.AddWithValue("barcode", "");
							sqlCommand.Parameters.AddWithValue("taxrate", 0);
							sqlCommand.Parameters.AddWithValue("imported", 0);
							sqlCommand.Parameters.AddWithValue("uom", "EA");
							sqlCommand.Parameters.AddWithValue("binloc", 0);
							sqlCommand.Parameters.AddWithValue("productdesc2", "");
							sqlCommand.Parameters.AddWithValue("new_prodtid", this.newID);
							sqlCommand.Parameters.AddWithValue("wholesaleqty", 0);
							sqlCommand.Parameters.AddWithValue("ProductExpires", 0);
							sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
							sqlCommand.Parameters.AddWithValue("differentpriceperbranch", 0);
							sqlCommand.Parameters.AddWithValue("isunlimitedstockitem", 0);
							sqlCommand.Parameters.AddWithValue("isingridientonly", 0);
							sqlCommand.Parameters.AddWithValue("isvoucher", 1);
							this.newID = Conversions.ToInteger(sqlCommand.ExecuteScalar());
						}
						sqlCommand.Parameters.Clear();
						sqlCommand.CommandType = CommandType.StoredProcedure;
						sqlCommand.CommandText = "EconetVoucherInsert";
						string text2 = this.pf.Encrypt(dataRow[0].ToString(), Conversions.ToString(MyProject.Forms.Form1.coid));
						sqlCommand.Parameters.AddWithValue("voucher", text2);
						sqlCommand.Parameters.AddWithValue("serialnumber", dataRow[1].ToString());
						sqlCommand.Parameters.AddWithValue("batchnumber", dataRow[2].ToString());
						sqlCommand.Parameters.AddWithValue("denomination", Conversions.ToDecimal(dataRow[3]));
						sqlCommand.Parameters.AddWithValue("expirydate", dataRow[4].ToString());
						sqlCommand.Parameters.AddWithValue("voucheridcode", dataRow[5].ToString());
						sqlCommand.Parameters.AddWithValue("uploadedby", MyProject.Forms.Form1.username);
						sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
						sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
						sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
						sqlCommand.Parameters.AddWithValue("productid", this.newID);
						sqlCommand.Parameters.AddWithValue("rateused", Conversion.Val(this.txtRate.Text));
						sqlCommand.Parameters.AddWithValue("reference", this.txtRef.Text);
						sqlCommand.ExecuteNonQuery();
						sqlCommand.Parameters.Clear();
						sqlCommand.CommandType = CommandType.StoredProcedure;
						sqlCommand.CommandText = "InsertNewStock2Warehouse";
						sqlCommand.Parameters.AddWithValue("trandate", DateTime.Today.ToString("yyyyMMdd"));
						sqlCommand.Parameters.AddWithValue("invoicenum", num);
						sqlCommand.Parameters.AddWithValue("productid", this.newID);
						sqlCommand.Parameters.AddWithValue("isstockin", 1);
						sqlCommand.Parameters.AddWithValue("ref", this.txtRef.Text);
						sqlCommand.Parameters.AddWithValue("quantity", 1);
						sqlCommand.Parameters.AddWithValue("cost", 0);
						sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
						sqlCommand.Parameters.AddWithValue("donewhen", Conversion.Val(DateAndTime.Today.Date.ToString("yyyyMMdd")));
						sqlCommand.Parameters.AddWithValue("trancode", 1);
						sqlCommand.Parameters.AddWithValue("productcode", this.newProductCode);
						sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
						sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
						sqlCommand.Parameters.AddWithValue("suppliername", "Econet");
						sqlCommand.Parameters.AddWithValue("BatchNumber", "");
						sqlCommand.Parameters.AddWithValue("ExpiryDate", 0);
						sqlCommand.Parameters.AddWithValue("paymentmethod", 0);
						sqlCommand.Parameters.AddWithValue("paymentmethodrate", Conversions.ToDecimal(this.txtRate.Text));
						sqlCommand.Parameters.AddWithValue("usereceiptdisplay", 1);
						sqlCommand.Parameters.AddWithValue("Sellingprice", 0);
						sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
						sqlCommand.Parameters.AddWithValue("trantime", DateTime.Now.ToString("HH:mm"));
						sqlCommand.ExecuteNonQuery();
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
				sqlConnection.Close();
				MessageBox.Show("Airtime Vouchers loaded successfully");
				this.ClearForm();
			}
			catch (SqlException ex)
			{
				bool flag3 = ex.Number == 2627;
				if (flag3)
				{
					MessageBox.Show("Voucher number has been entered before and therefore cannot be loaded again.");
					sqlTransaction.Rollback();
					sqlConnection.Close();
				}
				else
				{
					MessageBox.Show("SQL Error loading voucher. Detail: " + ex.Message);
					sqlTransaction.Rollback();
					sqlConnection.Close();
				}
			}
			catch (Exception ex2)
			{
				MessageBox.Show("Error saving vouchers. Detail: " + ex2.Message);
				sqlTransaction.Rollback();
				sqlConnection.Close();
			}
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x00092FC8 File Offset: 0x000911C8
		private void ClearForm()
		{
			this.txtRef.Text = "";
			this.txtRate.Text = "";
			this.OpenFileDialog1.FileName = "";
		}

		// Token: 0x06000F9A RID: 3994 RVA: 0x00093000 File Offset: 0x00091200
		private int getProductIDFromDesc(string productdesc)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = "select * from products where productdesc='" + productdesc + "' and coid=" + MyProject.Forms.Form1.coid.ToString();
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num == 1;
			int num2;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				this.newID = Conversions.ToInteger(dataRow["productid"]);
				num2 = Conversions.ToInteger(dataRow["productid"]);
			}
			else
			{
				num2 = 0;
			}
			return num2;
		}

		// Token: 0x06000F9B RID: 3995 RVA: 0x000930B8 File Offset: 0x000912B8
		private void txtRate_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x04000775 RID: 1909
		private PublicFunctions pf;

		// Token: 0x04000776 RID: 1910
		private string _cnn;

		// Token: 0x04000777 RID: 1911
		private int newID;

		// Token: 0x04000778 RID: 1912
		private string newProductCode;
	}
}
