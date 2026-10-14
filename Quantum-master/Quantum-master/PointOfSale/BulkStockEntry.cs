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
	// Token: 0x0200001B RID: 27
	[DesignerGenerated]
	public partial class BulkStockEntry : Form
	{
		// Token: 0x060004E7 RID: 1255 RVA: 0x0002FC70 File Offset: 0x0002DE70
		public BulkStockEntry()
		{
			base.Load += this.EnterpriseBulkStockEntry_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.pf2 = new PublicFunctions2();
			this.InitializeComponent();
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x060004EA RID: 1258 RVA: 0x00030C55 File Offset: 0x0002EE55
		// (set) Token: 0x060004EB RID: 1259 RVA: 0x00030C5F File Offset: 0x0002EE5F
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x060004EC RID: 1260 RVA: 0x00030C68 File Offset: 0x0002EE68
		// (set) Token: 0x060004ED RID: 1261 RVA: 0x00030C74 File Offset: 0x0002EE74
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

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x060004EE RID: 1262 RVA: 0x00030CB7 File Offset: 0x0002EEB7
		// (set) Token: 0x060004EF RID: 1263 RVA: 0x00030CC1 File Offset: 0x0002EEC1
		internal virtual CheckBox chkAutoGenCode
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x060004F0 RID: 1264 RVA: 0x00030CCA File Offset: 0x0002EECA
		// (set) Token: 0x060004F1 RID: 1265 RVA: 0x00030CD4 File Offset: 0x0002EED4
		internal virtual CheckBox chkIsCatID_A_NAME
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x060004F2 RID: 1266 RVA: 0x00030CDD File Offset: 0x0002EEDD
		// (set) Token: 0x060004F3 RID: 1267 RVA: 0x00030CE7 File Offset: 0x0002EEE7
		internal virtual ComboBox cboSuppliers
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x060004F4 RID: 1268 RVA: 0x00030CF0 File Offset: 0x0002EEF0
		// (set) Token: 0x060004F5 RID: 1269 RVA: 0x00030CFC File Offset: 0x0002EEFC
		internal virtual CheckBox CheckBox1
		{
			[CompilerGenerated]
			get
			{
				return this._CheckBox1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CheckBox1_CheckedChanged);
				CheckBox checkBox = this._CheckBox1;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= eventHandler;
				}
				this._CheckBox1 = value;
				checkBox = this._CheckBox1;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060004F6 RID: 1270 RVA: 0x00030D3F File Offset: 0x0002EF3F
		// (set) Token: 0x060004F7 RID: 1271 RVA: 0x00030D4C File Offset: 0x0002EF4C
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

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060004F8 RID: 1272 RVA: 0x00030D8F File Offset: 0x0002EF8F
		// (set) Token: 0x060004F9 RID: 1273 RVA: 0x00030D99 File Offset: 0x0002EF99
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060004FA RID: 1274 RVA: 0x00030DA2 File Offset: 0x0002EFA2
		// (set) Token: 0x060004FB RID: 1275 RVA: 0x00030DAC File Offset: 0x0002EFAC
		internal virtual CheckBox ChkWarehouse
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060004FC RID: 1276 RVA: 0x00030DB5 File Offset: 0x0002EFB5
		// (set) Token: 0x060004FD RID: 1277 RVA: 0x00030DC0 File Offset: 0x0002EFC0
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

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060004FE RID: 1278 RVA: 0x00030E03 File Offset: 0x0002F003
		// (set) Token: 0x060004FF RID: 1279 RVA: 0x00030E0D File Offset: 0x0002F00D
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000500 RID: 1280 RVA: 0x00030E16 File Offset: 0x0002F016
		// (set) Token: 0x06000501 RID: 1281 RVA: 0x00030E20 File Offset: 0x0002F020
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000502 RID: 1282 RVA: 0x00030E29 File Offset: 0x0002F029
		// (set) Token: 0x06000503 RID: 1283 RVA: 0x00030E33 File Offset: 0x0002F033
		internal virtual ComboBox CBOBranches
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000504 RID: 1284 RVA: 0x00030E3C File Offset: 0x0002F03C
		// (set) Token: 0x06000505 RID: 1285 RVA: 0x00030E46 File Offset: 0x0002F046
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000506 RID: 1286 RVA: 0x00030E4F File Offset: 0x0002F04F
		// (set) Token: 0x06000507 RID: 1287 RVA: 0x00030E59 File Offset: 0x0002F059
		internal virtual TextBox txtRef
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000508 RID: 1288 RVA: 0x00030E62 File Offset: 0x0002F062
		// (set) Token: 0x06000509 RID: 1289 RVA: 0x00030E6C File Offset: 0x0002F06C
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x0600050A RID: 1290 RVA: 0x00030E75 File Offset: 0x0002F075
		// (set) Token: 0x0600050B RID: 1291 RVA: 0x00030E80 File Offset: 0x0002F080
		internal virtual TextBox txtCompanyID
		{
			[CompilerGenerated]
			get
			{
				return this._txtCompanyID;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.txtCompanyID_TextChanged);
				TextBox textBox = this._txtCompanyID;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
				}
				this._txtCompanyID = value;
				textBox = this._txtCompanyID;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x0600050C RID: 1292 RVA: 0x00030EC3 File Offset: 0x0002F0C3
		// (set) Token: 0x0600050D RID: 1293 RVA: 0x00030ECD File Offset: 0x0002F0CD
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x0600050E RID: 1294 RVA: 0x00030ED6 File Offset: 0x0002F0D6
		// (set) Token: 0x0600050F RID: 1295 RVA: 0x00030EE0 File Offset: 0x0002F0E0
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

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000510 RID: 1296 RVA: 0x00030F23 File Offset: 0x0002F123
		// (set) Token: 0x06000511 RID: 1297 RVA: 0x00030F30 File Offset: 0x0002F130
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
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.DataGridView1_KeyDown);
				DataGridView dataGridView = this._DataGridView1;
				if (dataGridView != null)
				{
					dataGridView.KeyDown -= keyEventHandler;
				}
				this._DataGridView1 = value;
				dataGridView = this._DataGridView1;
				if (dataGridView != null)
				{
					dataGridView.KeyDown += keyEventHandler;
				}
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000512 RID: 1298 RVA: 0x00030F73 File Offset: 0x0002F173
		// (set) Token: 0x06000513 RID: 1299 RVA: 0x00030F7D File Offset: 0x0002F17D
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000514 RID: 1300 RVA: 0x00030F86 File Offset: 0x0002F186
		// (set) Token: 0x06000515 RID: 1301 RVA: 0x00030F90 File Offset: 0x0002F190
		internal virtual CheckBox chkIdentical
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x00030F99 File Offset: 0x0002F199
		// (set) Token: 0x06000517 RID: 1303 RVA: 0x00030FA3 File Offset: 0x0002F1A3
		internal virtual CheckBox chkGridSupplier
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00030FAC File Offset: 0x0002F1AC
		private void EnterpriseBulkStockEntry_Load(object sender, EventArgs e)
		{
			this.LoadBranches();
			base.WindowState = FormWindowState.Maximized;
			this.txtRef.Text = DateTime.Now.ToString("yyyyMMdd HH:mm:ss");
			this.txtCompanyID.Text = MyProject.Forms.Form1.coid.ToString();
			this.LoadBranches();
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x00031010 File Offset: 0x0002F210
		private int GetCategoryID(bool catid_is_name, string catname = "", int catid = 0)
		{
			int num = 0;
			if (catid_is_name)
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.Text;
				sqlCommand.CommandText = string.Concat(new string[]
				{
					"select catid from categories where coid=",
					Conversions.ToString(Conversions.ToInteger(this.txtCompanyID.Text)),
					" and catdesc='",
					catname,
					"'"
				});
				DataTable dataTable = new DataTable();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				int num2 = sqlDataAdapter.Fill(dataTable);
				bool flag = num2 > 0;
				if (flag)
				{
					DataRow dataRow = dataTable.Rows[0];
					int num3 = Conversions.ToInteger(dataRow["catid"]);
					num = num3;
				}
				else
				{
					SqlConnection sqlConnection2 = new SqlConnection(this._cnn);
					SqlCommand sqlCommand2 = sqlConnection2.CreateCommand();
					sqlCommand2.CommandType = CommandType.StoredProcedure;
					sqlCommand2.CommandText = "InsertCategory";
					sqlCommand2.Parameters.AddWithValue("catdesc", catname);
					sqlCommand2.Parameters.AddWithValue("coid", Conversions.ToInteger(this.txtCompanyID.Text));
					sqlCommand2.Parameters.AddWithValue("new_catid", num);
					using (sqlConnection2)
					{
						sqlConnection2.Open();
						num = Conversions.ToInteger(sqlCommand2.ExecuteScalar());
						sqlConnection2.Close();
					}
				}
			}
			else
			{
				SqlConnection sqlConnection4 = new SqlConnection(this._cnn);
				SqlCommand sqlCommand3 = sqlConnection4.CreateCommand();
				sqlCommand3.CommandType = CommandType.Text;
				sqlCommand3.CommandText = "select count(*) as thecount from categories where coid=" + Conversions.ToString(Conversions.ToInteger(this.txtCompanyID.Text));
				DataTable dataTable2 = new DataTable();
				SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter(sqlCommand3);
				int num4 = sqlDataAdapter2.Fill(dataTable2);
				bool flag2 = num4 > 0;
				if (flag2)
				{
					num = catid;
				}
				else
				{
					SqlConnection sqlConnection5 = new SqlConnection(this._cnn);
					SqlCommand sqlCommand4 = sqlConnection4.CreateCommand();
					sqlCommand4.CommandType = CommandType.StoredProcedure;
					sqlCommand4.CommandText = "InsertCategory";
					sqlCommand4.Parameters.AddWithValue("catdesc", catname);
					sqlCommand4.Parameters.AddWithValue("coid", Conversions.ToInteger(this.txtCompanyID.Text));
					sqlCommand4.Parameters.AddWithValue("new_catid", num);
					using (sqlConnection5)
					{
						sqlConnection5.Open();
						num = Conversions.ToInteger(sqlCommand4.ExecuteScalar());
						sqlConnection5.Close();
					}
				}
			}
			return num;
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x000312E0 File Offset: 0x0002F4E0
		public int CheckifProductID(string productcode)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = string.Concat(new string[]
			{
				"select productid from products where coid=",
				Conversions.ToString(Conversions.ToInteger(this.txtCompanyID.Text)),
				" and productcode='",
				productcode,
				"'"
			});
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			int num2;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				num2 = Conversions.ToInteger(dataRow["productid"]);
			}
			else
			{
				num2 = 0;
			}
			return num2;
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x0003139C File Offset: 0x0002F59C
		public string GetNextProductCode(string con, int coid)
		{
			SqlConnection sqlConnection = new SqlConnection(con);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchNextProductCode";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			DataRow dataRow = dataTable.Rows[0];
			return this.CalculateEan13(dataRow["NextProductCode"].ToString());
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x00031424 File Offset: 0x0002F624
		public string CalculateEan13(string twelve_dig_prodcode)
		{
			int num = 0;
			int length = twelve_dig_prodcode.Length;
			checked
			{
				for (int i = 1; i <= length; i++)
				{
					int num2 = Convert.ToInt32(twelve_dig_prodcode.Substring(i - 1, 1));
					bool flag = i % 2 == 0;
					if (flag)
					{
						num += num2 * 3;
					}
					else
					{
						num += num2 * 1;
					}
				}
				int num3 = (10 - num % 10) % 10;
				return twelve_dig_prodcode + Conversions.ToString(num3);
			}
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x000314A0 File Offset: 0x0002F6A0
		private void Button1_Click(object sender, EventArgs e)
		{
			bool @checked = this.chkIdentical.Checked;
			checked
			{
				if (@checked)
				{
					this.EnterStockDescDeterminesProductID();
				}
				else
				{
					int num = 0;
					int invoiceNum = this.GetInvoiceNum();
					SqlConnection sqlConnection = new SqlConnection(this._cnn);
					SqlCommand sqlCommand = sqlConnection.CreateCommand();
					sqlCommand.Connection = sqlConnection;
					sqlConnection.Open();
					SqlTransaction sqlTransaction = sqlConnection.BeginTransaction("RunConfirmedSale");
					sqlCommand.Transaction = sqlTransaction;
					try
					{
						try
						{
							foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
							{
								DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
								bool isNewRow = dataGridViewRow.IsNewRow;
								if (!isNewRow)
								{
									string text = dataGridViewRow.Cells[3].Value.ToString();
									bool flag = Operators.CompareString(text, "", false) == 0;
									if (flag)
									{
										break;
									}
									string text2 = dataGridViewRow.Cells[4].Value.ToString();
									double num2 = Conversions.ToDouble(Interaction.IIf(Operators.CompareString(dataGridViewRow.Cells[5].Value.ToString(), "", false) == 0, 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[5].Value)));
									double num3 = Conversions.ToDouble(Interaction.IIf(Operators.CompareString(dataGridViewRow.Cells[6].Value.ToString(), "", false) == 0, 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[6].Value)));
									decimal num4 = Conversions.ToDecimal(Interaction.IIf(Operators.CompareString(dataGridViewRow.Cells[12].Value.ToString(), "", false) == 0, 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[12].Value)));
									bool checked2 = this.chkAutoGenCode.Checked;
									string text3;
									if (checked2)
									{
										text3 = this.GetNextProductCode(this._cnn, Conversions.ToInteger(this.txtCompanyID.Text));
									}
									else
									{
										text3 = dataGridViewRow.Cells[1].Value.ToString();
									}
									decimal num5 = Conversions.ToDecimal(Interaction.IIf(Operators.CompareString(dataGridViewRow.Cells[8].Value.ToString(), "", false) == 0, 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[8].Value)));
									string text4 = this.CBOBranches.Text;
									string text5 = Conversions.ToString(dataGridViewRow.Cells[2].Value);
									int num6 = 1;
									string text6 = Conversions.ToString(Interaction.IIf(Operators.CompareString(dataGridViewRow.Cells[9].Value.ToString(), "", false) == 0, "0", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[9].Value)));
									int num7 = Conversions.ToInteger(Interaction.IIf(Operators.CompareString(dataGridViewRow.Cells[7].Value.ToString(), "", false) == 0, 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[7].Value)));
									string text7 = dataGridViewRow.Cells[10].Value.ToString();
									int num8 = Conversions.ToInteger(Interaction.IIf(Operators.CompareString(dataGridViewRow.Cells[11].Value.ToString(), "", false) == 0, 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[11].Value)));
									bool checked3 = this.chkGridSupplier.Checked;
									int num9;
									if (checked3)
									{
										string text8 = dataGridViewRow.Cells[13].Value.ToString();
										num9 = this.pf2.GetExistingSupplierIDorCreate(text8, (int)Math.Round(Conversion.Val(this.txtCompanyID.Text)));
									}
									else
									{
										num9 = Conversions.ToInteger(this.cboSuppliers.SelectedValue);
									}
									bool checked4 = this.chkIsCatID_A_NAME.Checked;
									int num10;
									if (checked4)
									{
										num10 = this.GetCategoryID(true, text5, 0);
									}
									else
									{
										num10 = this.GetCategoryID(false, "", Conversions.ToInteger(text5));
									}
									int num11 = this.CheckifProductID(text3);
									bool flag2 = num11 == 0;
									if (flag2)
									{
										sqlCommand.Parameters.Clear();
										sqlCommand.CommandType = CommandType.StoredProcedure;
										sqlCommand.CommandText = "InsertNewProduct5";
										sqlCommand.Parameters.AddWithValue("catid", num10);
										sqlCommand.Parameters.AddWithValue("productdesc", text);
										sqlCommand.Parameters.AddWithValue("productdesc2", text2);
										sqlCommand.Parameters.AddWithValue("cost", num2);
										sqlCommand.Parameters.AddWithValue("sellingprice", num3);
										sqlCommand.Parameters.AddWithValue("reorderlevel", num7);
										sqlCommand.Parameters.AddWithValue("doneby", "POSAdmin");
										sqlCommand.Parameters.AddWithValue("donewhen", DateTime.Today.ToString("yyyyMMdd"));
										sqlCommand.Parameters.AddWithValue("productcode", text3);
										sqlCommand.Parameters.AddWithValue("barcode", "");
										sqlCommand.Parameters.AddWithValue("taxrate", 0);
										sqlCommand.Parameters.AddWithValue("imported", num6);
										sqlCommand.Parameters.AddWithValue("new_prodtid", this.newID);
										sqlCommand.Parameters.AddWithValue("uom", "EA");
										sqlCommand.Parameters.AddWithValue("binloc", text6);
										sqlCommand.Parameters.AddWithValue("coid", Convert.ToInt32(this.txtCompanyID.Text));
										sqlCommand.Parameters.AddWithValue("differentpriceperbranch", 0);
										sqlCommand.Parameters.AddWithValue("wholesaleqty", 0);
										bool flag3 = num8 != 0;
										if (flag3)
										{
											sqlCommand.Parameters.AddWithValue("productexpires", 1);
										}
										else
										{
											sqlCommand.Parameters.AddWithValue("productexpires", 0);
										}
										sqlCommand.Parameters.AddWithValue("supplierid", num9);
										sqlCommand.Parameters.AddWithValue("specialprice", num4);
										this.newID = Conversions.ToInteger(sqlCommand.ExecuteScalar());
										num11 = this.newID;
									}
									sqlCommand.Parameters.Clear();
									sqlCommand.CommandType = CommandType.StoredProcedure;
									sqlCommand.CommandText = "InsertNewStock2";
									sqlCommand.Parameters.AddWithValue("trandate", DateTime.Today.ToString("yyyyMMdd"));
									sqlCommand.Parameters.AddWithValue("invoicenum", invoiceNum);
									sqlCommand.Parameters.AddWithValue("productid", num11);
									sqlCommand.Parameters.AddWithValue("isstockin", 1);
									sqlCommand.Parameters.AddWithValue("ref", this.txtRef.Text);
									sqlCommand.Parameters.AddWithValue("quantity", num5);
									sqlCommand.Parameters.AddWithValue("cost", num2);
									sqlCommand.Parameters.AddWithValue("doneby", "POSAdmin");
									sqlCommand.Parameters.AddWithValue("donewhen", Conversion.Val(DateAndTime.Today.Date.ToString("yyyyMMdd")));
									sqlCommand.Parameters.AddWithValue("trancode", 1);
									sqlCommand.Parameters.AddWithValue("productcode", text3);
									sqlCommand.Parameters.AddWithValue("coid", Conversion.Val(this.txtCompanyID.Text));
									sqlCommand.Parameters.AddWithValue("branch", text4);
									sqlCommand.Parameters.AddWithValue("suppliername", this.cboSuppliers.Text);
									sqlCommand.Parameters.AddWithValue("batchnumber", text7);
									sqlCommand.Parameters.AddWithValue("ExpiryDate", RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(num8), 0, num8)));
									bool checked5 = this.ChkWarehouse.Checked;
									if (checked5)
									{
										sqlCommand.Parameters.AddWithValue("iswarehouse", 1);
									}
									else
									{
										sqlCommand.Parameters.AddWithValue("iswarehouse", 0);
									}
									sqlCommand.ExecuteNonQuery();
									bool checked6 = this.chkAutoGenCode.Checked;
									if (checked6)
									{
										sqlCommand.Parameters.Clear();
										sqlCommand.CommandText = "UpdateProductCodeBase";
										sqlCommand.Parameters.AddWithValue("coid", Conversions.ToInteger(this.txtCompanyID.Text));
										string text9 = text3.ToString().Substring(3, 9);
										sqlCommand.Parameters.AddWithValue("code", Conversions.ToDecimal(text9));
										sqlCommand.ExecuteNonQuery();
									}
									num++;
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
						sqlConnection.Close();
						MessageBox.Show("Successfully entered " + num.ToString() + " rows into the database.");
						this.txtRef.Text = DateTime.Now.ToString("yyyyMMdd HH:mm:ss");
					}
					catch (SqlException ex)
					{
						MessageBox.Show("Truncate Tables to Clear any saved products then redo. Unforseen SQL error at row: " + num.ToString() + ", Detail: " + ex.Message);
						sqlTransaction.Rollback();
						sqlConnection.Close();
					}
					catch (Exception ex2)
					{
						MessageBox.Show("Truncate Tables to Clear any saved products then redo. Unforseen error at row: " + num.ToString() + ", Detail: " + ex2.Message);
						sqlTransaction.Rollback();
						sqlConnection.Close();
					}
				}
			}
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x00031FA8 File Offset: 0x000301A8
		private int GetInvoiceNum()
		{
			int num = 0;
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetNewInvoiceNumber";
			sqlCommand.Parameters.AddWithValue("desc", DateTime.Today.ToString("yyyyMMdd") + DateAndTime.Now.TimeOfDay.ToString());
			sqlCommand.Parameters.AddWithValue("newinvoicenum", 0);
			using (sqlConnection)
			{
				sqlConnection.Open();
				num = Conversions.ToInteger(sqlCommand.ExecuteScalar());
				sqlConnection.Close();
			}
			return num;
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00032080 File Offset: 0x00030280
		private int SaveProduct(int categoryid, int imported, string desc, string desc2, double cost, double sellingprice, double reorderlevel, string productcode, string UOM, string BINLOC)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchProductByCode2";
			sqlCommand.Parameters.AddWithValue("productcode", productcode);
			sqlCommand.Parameters.AddWithValue("coid", Convert.ToInt32(this.txtCompanyID.Text));
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			int num3;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				int num2 = Conversions.ToInteger(dataRow["productid"]);
				num3 = num2;
			}
			else
			{
				SqlConnection sqlConnection2 = new SqlConnection(this._cnn);
				SqlCommand sqlCommand2 = sqlConnection2.CreateCommand();
				sqlCommand2.CommandType = CommandType.StoredProcedure;
				sqlCommand2.CommandText = "InsertNewProduct5";
				sqlCommand2.Parameters.AddWithValue("catid", categoryid);
				sqlCommand2.Parameters.AddWithValue("productdesc", desc);
				sqlCommand2.Parameters.AddWithValue("productdesc2", desc2);
				sqlCommand2.Parameters.AddWithValue("cost", cost);
				sqlCommand2.Parameters.AddWithValue("sellingprice", sellingprice);
				sqlCommand2.Parameters.AddWithValue("reorderlevel", reorderlevel);
				sqlCommand2.Parameters.AddWithValue("doneby", "POSAdmin");
				sqlCommand2.Parameters.AddWithValue("donewhen", DateTime.Today.ToString("yyyyMMdd"));
				sqlCommand2.Parameters.AddWithValue("productcode", productcode);
				sqlCommand2.Parameters.AddWithValue("barcode", "");
				sqlCommand2.Parameters.AddWithValue("taxrate", 0);
				sqlCommand2.Parameters.AddWithValue("imported", imported);
				sqlCommand2.Parameters.AddWithValue("new_prodtid", this.newID);
				sqlCommand2.Parameters.AddWithValue("uom", UOM);
				sqlCommand2.Parameters.AddWithValue("binloc", BINLOC);
				sqlCommand2.Parameters.AddWithValue("coid", Convert.ToInt32(this.txtCompanyID.Text));
				sqlCommand2.Parameters.AddWithValue("differentpriceperbranch", 0);
				sqlCommand2.Parameters.AddWithValue("wholesaleqty", 0);
				sqlCommand2.Parameters.AddWithValue("productexpires", 0);
				sqlCommand2.Parameters.AddWithValue("supplierid", 0);
				using (sqlConnection2)
				{
					sqlConnection2.Open();
					this.newID = Conversions.ToInteger(sqlCommand2.ExecuteScalar());
					sqlConnection2.Close();
				}
				num3 = this.newID;
			}
			return num3;
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x000323A8 File Offset: 0x000305A8
		private void InsertStockWarehouse(int invoicenum, int productid, decimal quantity, double cost, string productcode, string branchname, string batchnumber, int expdate, string suppliername)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "InsertNewStock2Warehouse";
			sqlCommand.Parameters.AddWithValue("trandate", DateTime.Today.ToString("yyyyMMdd"));
			sqlCommand.Parameters.AddWithValue("invoicenum", invoicenum);
			sqlCommand.Parameters.AddWithValue("productid", productid);
			sqlCommand.Parameters.AddWithValue("isstockin", 1);
			sqlCommand.Parameters.AddWithValue("ref", this.txtRef.Text);
			sqlCommand.Parameters.AddWithValue("quantity", quantity);
			sqlCommand.Parameters.AddWithValue("cost", cost);
			sqlCommand.Parameters.AddWithValue("doneby", "POSAdmin");
			sqlCommand.Parameters.AddWithValue("donewhen", Conversion.Val(DateAndTime.Today.Date.ToString("yyyyMMdd")));
			sqlCommand.Parameters.AddWithValue("trancode", 1);
			sqlCommand.Parameters.AddWithValue("productcode", productcode);
			sqlCommand.Parameters.AddWithValue("coid", Conversion.Val(this.txtCompanyID.Text));
			sqlCommand.Parameters.AddWithValue("branch", branchname);
			sqlCommand.Parameters.AddWithValue("batchnumber", batchnumber);
			sqlCommand.Parameters.AddWithValue("ExpiryDate", expdate);
			sqlCommand.Parameters.AddWithValue("suppliername", suppliername);
			sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
			sqlCommand.Parameters.AddWithValue("trantime", DateTime.Now.ToString("HHmm"));
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x000325EC File Offset: 0x000307EC
		private void InsertStockProdCode(int invoicenum, decimal quantity, double cost, string productcode, string branchname, decimal sellingprice)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "InsertNewStock2ProdCode";
			sqlCommand.Parameters.AddWithValue("trandate", DateTime.Today.ToString("yyyyMMdd"));
			sqlCommand.Parameters.AddWithValue("invoicenum", invoicenum);
			sqlCommand.Parameters.AddWithValue("isstockin", 1);
			sqlCommand.Parameters.AddWithValue("ref", this.txtRef.Text);
			sqlCommand.Parameters.AddWithValue("quantity", quantity);
			sqlCommand.Parameters.AddWithValue("cost", cost);
			sqlCommand.Parameters.AddWithValue("doneby", "POSAdmin");
			sqlCommand.Parameters.AddWithValue("donewhen", Conversion.Val(DateAndTime.Today.Date.ToString("yyyyMMdd")));
			sqlCommand.Parameters.AddWithValue("trancode", 1);
			sqlCommand.Parameters.AddWithValue("productcode", productcode);
			sqlCommand.Parameters.AddWithValue("coid", Conversion.Val(this.txtCompanyID.Text));
			sqlCommand.Parameters.AddWithValue("branch", branchname);
			sqlCommand.Parameters.AddWithValue("sellingprice", sellingprice);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x000327B8 File Offset: 0x000309B8
		private void DataGridView1_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.Control && e.KeyCode == Keys.V;
			checked
			{
				if (flag)
				{
					int num = 0;
					int num2 = 0;
					string text = Clipboard.GetText();
					DataTable dataTable = new DataTable();
					bool flag2 = true;
					int i = 0;
					int num3 = 0;
					int num4 = 0;
					DataRow dataRow = null;
					dataTable.BeginLoadData();
					while (i < text.Length)
					{
						switch (text[i])
						{
						case '\t':
						case '\r':
						{
							bool flag3 = flag2;
							if (flag3)
							{
								dataTable.Columns.Add(string.Format("C{0}", num4), typeof(string)).Caption = num4.ToString();
							}
							bool flag4 = num4 == 0;
							if (flag4)
							{
								dataRow = dataTable.NewRow();
							}
							dataRow[num4] = text.Substring(num3, i - num3);
							num2++;
							num4++;
							i++;
							num3 = i;
							continue;
						}
						case '\n':
						{
							bool flag5 = dataRow != null;
							if (flag5)
							{
								dataTable.Rows.Add(dataRow);
								num++;
								dataRow = null;
							}
							num4 = 0;
							i++;
							num3 = i;
							flag2 = false;
							continue;
						}
						}
						i++;
					}
					dataTable.EndLoadData();
					this.DataGridView1.DataSource = dataTable;
				}
			}
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x0003292C File Offset: 0x00030B2C
		private void LoadBranches()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchBranches";
			sqlCommand.Parameters.AddWithValue("coid", Conversion.Val(this.txtCompanyID.Text));
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			this.CBOBranches.DataSource = dataTable;
			this.CBOBranches.ValueMember = "branch";
			this.CBOBranches.DisplayMember = "branch";
			this.LoadSuppliers();
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x000329D4 File Offset: 0x00030BD4
		private void LoadSuppliers()
		{
			bool flag = (Operators.CompareString(this.txtCompanyID.Text, "", false) != 0) & Versioned.IsNumeric(this.txtCompanyID.Text);
			if (flag)
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.Text;
				sqlCommand.CommandText = "Select suppliername, supplierid from suppliers where coid=" + Conversions.ToString(Conversions.ToInteger(this.txtCompanyID.Text));
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				DataTable dataTable = new DataTable();
				sqlDataAdapter.Fill(dataTable);
				this.cboSuppliers.DataSource = dataTable;
				this.cboSuppliers.ValueMember = "supplierid";
				this.cboSuppliers.DisplayMember = "suppliername";
			}
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x00032A9D File Offset: 0x00030C9D
		private void Button2_Click(object sender, EventArgs e)
		{
			this.LoadBranches();
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x00002A30 File Offset: 0x00000C30
		private void txtCompanyID_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x00032AA8 File Offset: 0x00030CA8
		private void CheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.CheckBox1.Checked;
			if (@checked)
			{
				this.Button3.Visible = true;
				this.Label7.Visible = true;
				this.Label4.Visible = false;
			}
			else
			{
				this.Button3.Visible = false;
				this.Label7.Visible = false;
				this.Label4.Visible = true;
			}
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x00032B18 File Offset: 0x00030D18
		private void Button3_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					int invoiceNum = this.GetInvoiceNum();
					int num = 0;
					this.DataGridView1.Columns.Add("ProductExists", "Product Exits");
					SqlConnection sqlConnection = new SqlConnection(this._cnn);
					SqlCommand sqlCommand = sqlConnection.CreateCommand();
					sqlConnection.Open();
					SqlTransaction sqlTransaction = sqlConnection.BeginTransaction("RunStockTake");
					sqlCommand.Connection = sqlConnection;
					sqlCommand.Transaction = sqlTransaction;
					try
					{
						try
						{
							foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
							{
								DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
								bool isNewRow = dataGridViewRow.IsNewRow;
								if (!isNewRow)
								{
									bool flag = this.pf.CheckIfProductExists((int)Math.Round(Conversion.Val(this.txtCompanyID.Text)), Conversions.ToInteger(dataGridViewRow.Cells[0].Value), this._cnn);
									if (flag)
									{
										dataGridViewRow.Cells[2].Value = 1;
										sqlCommand.Parameters.Clear();
										sqlCommand.CommandType = CommandType.StoredProcedure;
										sqlCommand.CommandText = "StockBalForProduct";
										sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[0].Value));
										sqlCommand.Parameters.AddWithValue("coid", Conversion.Val(this.txtCompanyID.Text));
										sqlCommand.Parameters.AddWithValue("branch", this.CBOBranches.Text);
										sqlCommand.Parameters.AddWithValue("trandate", DateTime.Today.ToString("yyyyMMdd"));
										DataTable dataTable = new DataTable();
										SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
										int num2 = sqlDataAdapter.Fill(dataTable);
										bool flag2 = num2 > 0;
										decimal num3;
										if (flag2)
										{
											DataRow dataRow = dataTable.Rows[0];
											num3 = Conversions.ToDecimal(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["stockbal"])), 0, RuntimeHelpers.GetObjectValue(dataRow["stockbal"])));
										}
										else
										{
											num3 = 0m;
										}
										decimal num4 = Conversions.ToDecimal(dataGridViewRow.Cells[1].Value);
										bool flag3 = decimal.Compare(num3, num4) == 0;
										if (!flag3)
										{
											bool flag4 = decimal.Compare(num3, num4) > 0;
											if (flag4)
											{
												sqlCommand.Parameters.Clear();
												sqlCommand.CommandType = CommandType.StoredProcedure;
												sqlCommand.CommandText = "InsertNewSaleStockTake";
												sqlCommand.Parameters.AddWithValue("trandate", Conversions.ToInteger(DateTime.Today.ToString("yyyyMMdd")));
												sqlCommand.Parameters.AddWithValue("invoicenum", 0);
												sqlCommand.Parameters.AddWithValue("productid", Conversions.ToInteger(dataGridViewRow.Cells[0].Value));
												sqlCommand.Parameters.AddWithValue("isstockin", 0);
												sqlCommand.Parameters.AddWithValue("ref", "STOCK REDUCED");
												sqlCommand.Parameters.AddWithValue("quantity", decimal.Subtract(num3, num4));
												sqlCommand.Parameters.AddWithValue("unitcost", 0);
												sqlCommand.Parameters.AddWithValue("salesprice", 0);
												sqlCommand.Parameters.AddWithValue("paymentmethod", 0);
												sqlCommand.Parameters.AddWithValue("doneby", "bulkentryapp");
												sqlCommand.Parameters.AddWithValue("donewhen", Conversions.ToInteger(DateTime.Today.ToString("yyyyMMdd")));
												sqlCommand.Parameters.AddWithValue("trancode", 2);
												sqlCommand.Parameters.AddWithValue("TranTime", DateTime.Now.ToString("HHmm"));
												sqlCommand.Parameters.AddWithValue("coid", Conversion.Val(this.txtCompanyID.Text));
												sqlCommand.Parameters.AddWithValue("branch", this.CBOBranches.Text);
												string text = "bulk stock adj";
												sqlCommand.Parameters.AddWithValue("details", text);
												sqlCommand.Parameters.AddWithValue("stockbal", num3);
												sqlCommand.ExecuteNonQuery();
												num++;
											}
											else
											{
												bool flag5 = decimal.Compare(num3, num4) < 0;
												if (flag5)
												{
													sqlCommand.Parameters.Clear();
													sqlCommand.CommandType = CommandType.StoredProcedure;
													sqlCommand.CommandText = "InsertNewStockStockTake";
													sqlCommand.Parameters.AddWithValue("trandate", Conversions.ToInteger(DateTime.Today.ToString("yyyyMMdd")));
													sqlCommand.Parameters.AddWithValue("invoicenum", 0);
													sqlCommand.Parameters.AddWithValue("productid", Conversions.ToInteger(dataGridViewRow.Cells[0].Value));
													sqlCommand.Parameters.AddWithValue("isstockin", 1);
													sqlCommand.Parameters.AddWithValue("ref", "STOCK INCREASED");
													sqlCommand.Parameters.AddWithValue("quantity", decimal.Subtract(num4, num3));
													sqlCommand.Parameters.AddWithValue("cost", 0);
													sqlCommand.Parameters.AddWithValue("doneby", "bulkentryapp");
													sqlCommand.Parameters.AddWithValue("donewhen", Conversions.ToInteger(DateTime.Today.ToString("yyyyMMdd")));
													sqlCommand.Parameters.AddWithValue("trancode", 2);
													sqlCommand.Parameters.AddWithValue("coid", Conversion.Val(this.txtCompanyID.Text));
													sqlCommand.Parameters.AddWithValue("branch", this.CBOBranches.Text);
													string text2 = "Bulk Stock Adj";
													sqlCommand.Parameters.AddWithValue("details", text2);
													sqlCommand.Parameters.AddWithValue("stockbal", num3);
													sqlCommand.ExecuteNonQuery();
													num++;
												}
											}
										}
									}
									else
									{
										dataGridViewRow.Cells[2].Value = 0;
									}
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
						MessageBox.Show("Stock balances adjusted for " + num.ToString() + " products. Check stock adjustment report from QuantumPOS");
					}
					catch (Exception ex)
					{
						MessageBox.Show("Error adjusting stock. Detail: " + ex.Message);
					}
				}
				catch (Exception ex2)
				{
					MessageBox.Show("Error. Detail: " + ex2.Message);
				}
			}
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x000332B0 File Offset: 0x000314B0
		private void Button4_Click(object sender, EventArgs e)
		{
			try
			{
				this.DataGridView1.Rows.Clear();
				this.DataGridView1.Columns.Clear();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x00033304 File Offset: 0x00031504
		private void EnterStock(int invnum, int newproductid, decimal qty, decimal cost, string branch, string batchnum, int expdate)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "InsertNewStock2";
				sqlCommand.Parameters.AddWithValue("trandate", DateTime.Today.ToString("yyyyMMdd"));
				sqlCommand.Parameters.AddWithValue("invoicenum", invnum);
				sqlCommand.Parameters.AddWithValue("productid", newproductid);
				sqlCommand.Parameters.AddWithValue("isstockin", 1);
				sqlCommand.Parameters.AddWithValue("ref", this.txtRef.Text);
				sqlCommand.Parameters.AddWithValue("quantity", qty);
				sqlCommand.Parameters.AddWithValue("cost", cost);
				sqlCommand.Parameters.AddWithValue("doneby", "POSAdmin");
				sqlCommand.Parameters.AddWithValue("donewhen", Conversion.Val(DateAndTime.Today.Date.ToString("yyyyMMdd")));
				sqlCommand.Parameters.AddWithValue("trancode", 1);
				sqlCommand.Parameters.AddWithValue("productcode", "");
				sqlCommand.Parameters.AddWithValue("coid", Conversion.Val(this.txtCompanyID.Text));
				sqlCommand.Parameters.AddWithValue("branch", branch);
				sqlCommand.Parameters.AddWithValue("suppliername", this.cboSuppliers.Text);
				sqlCommand.Parameters.AddWithValue("batchnumber", batchnum);
				sqlCommand.Parameters.AddWithValue("ExpiryDate", RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(expdate), 0, expdate)));
				bool @checked = this.ChkWarehouse.Checked;
				if (@checked)
				{
					sqlCommand.Parameters.AddWithValue("iswarehouse", 1);
				}
				else
				{
					sqlCommand.Parameters.AddWithValue("iswarehouse", 0);
				}
				using (sqlConnection)
				{
					sqlConnection.Open();
					sqlCommand.ExecuteNonQuery();
					sqlConnection.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x000335CC File Offset: 0x000317CC
		private void EnterStockDescDeterminesProductID()
		{
			checked
			{
				try
				{
					int invoiceNum = this.GetInvoiceNum();
					int num = 0;
					int num2 = 0;
					try
					{
						foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							bool isNewRow = dataGridViewRow.IsNewRow;
							if (!isNewRow)
							{
								string text = dataGridViewRow.Cells[3].Value.ToString();
								bool flag = Operators.CompareString(text, "", false) == 0;
								if (flag)
								{
									break;
								}
								string text2 = dataGridViewRow.Cells[4].Value.ToString();
								double num3 = Conversions.ToDouble(Interaction.IIf(Operators.CompareString(dataGridViewRow.Cells[5].Value.ToString(), "", false) == 0, 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[5].Value)));
								double num4 = Conversions.ToDouble(Interaction.IIf(Operators.CompareString(dataGridViewRow.Cells[6].Value.ToString(), "", false) == 0, 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[6].Value)));
								decimal num5 = Conversions.ToDecimal(Interaction.IIf(Operators.CompareString(dataGridViewRow.Cells[8].Value.ToString(), "", false) == 0, 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[8].Value)));
								string text3 = this.CBOBranches.Text;
								string text4 = Conversions.ToString(dataGridViewRow.Cells[2].Value);
								int num6 = 1;
								string text5 = Conversions.ToString(Interaction.IIf(Operators.CompareString(dataGridViewRow.Cells[9].Value.ToString(), "", false) == 0, "0", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[9].Value)));
								int num7 = Conversions.ToInteger(Interaction.IIf(Operators.CompareString(dataGridViewRow.Cells[7].Value.ToString(), "", false) == 0, 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[7].Value)));
								string text6 = dataGridViewRow.Cells[10].Value.ToString();
								int num8 = Conversions.ToInteger(Interaction.IIf(Operators.CompareString(dataGridViewRow.Cells[11].Value.ToString(), "", false) == 0, 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[11].Value)));
								bool @checked = this.chkIsCatID_A_NAME.Checked;
								int num9;
								if (@checked)
								{
									num9 = this.GetCategoryID(true, text4, 0);
								}
								else
								{
									num9 = this.GetCategoryID(false, "", Conversions.ToInteger(text4));
								}
								int num10 = this.CheckProductByDesc(text);
								bool flag2 = num10 == 0;
								if (flag2)
								{
									string nextProductCode = this.GetNextProductCode(this._cnn, Conversions.ToInteger(this.txtCompanyID.Text));
									num10 = this.CreateNewProduct(num9, text, text2, new decimal(num3), new decimal(num4), new decimal(num7), text5, nextProductCode, num6, num10);
									this.UpdateAutoProductCode(nextProductCode);
									num++;
								}
								bool flag3 = num10 == 0;
								if (flag3)
								{
									MessageBox.Show("0 id");
								}
								this.EnterStock(invoiceNum, num10, num5, new decimal(num3), this.CBOBranches.Text, text6, num8);
								num2++;
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
					MessageBox.Show("Products entered " + num.ToString() + ", rows processed: " + num2.ToString());
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error occurred. Detail: " + ex.Message);
				}
			}
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x00033A18 File Offset: 0x00031C18
		private void UpdateAutoProductCode(string code)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.Parameters.Clear();
				sqlCommand.CommandText = "UpdateProductCodeBase";
				sqlCommand.Parameters.AddWithValue("coid", Conversions.ToInteger(this.txtCompanyID.Text));
				string text = code.ToString().Substring(3, 9);
				sqlCommand.Parameters.AddWithValue("code", Conversions.ToDecimal(text));
				using (sqlConnection)
				{
					sqlConnection.Open();
					sqlCommand.ExecuteNonQuery();
					sqlConnection.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x00033B18 File Offset: 0x00031D18
		private int CheckProductByDesc(string proddesc)
		{
			int num2;
			try
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.Text;
				sqlCommand.CommandText = string.Concat(new string[]
				{
					"select productid from products where coid=",
					Conversions.ToString(Conversions.ToInteger(this.txtCompanyID.Text)),
					" and productdesc='",
					proddesc,
					"'"
				});
				DataTable dataTable = new DataTable();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				int num = sqlDataAdapter.Fill(dataTable);
				bool flag = num > 0;
				if (flag)
				{
					DataRow dataRow = dataTable.Rows[0];
					num2 = Conversions.ToInteger(dataRow["productid"]);
				}
				else
				{
					num2 = 0;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error occured. Detail: " + ex.Message);
				num2 = 0;
			}
			return num2;
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x00033C0C File Offset: 0x00031E0C
		private int CreateNewProduct(int thecatid, string desc, string desc2, decimal cost, decimal sellingprice, decimal reorderlevel, string binloc, string code, int imported, int newproductid)
		{
			int num;
			try
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "InsertNewProduct5";
				sqlCommand.Parameters.AddWithValue("catid", thecatid);
				sqlCommand.Parameters.AddWithValue("productdesc", desc);
				sqlCommand.Parameters.AddWithValue("productdesc2", desc2);
				sqlCommand.Parameters.AddWithValue("cost", cost);
				sqlCommand.Parameters.AddWithValue("sellingprice", sellingprice);
				sqlCommand.Parameters.AddWithValue("reorderlevel", reorderlevel);
				sqlCommand.Parameters.AddWithValue("doneby", "POSAdmin");
				sqlCommand.Parameters.AddWithValue("donewhen", DateTime.Today.ToString("yyyyMMdd"));
				sqlCommand.Parameters.AddWithValue("productcode", code);
				sqlCommand.Parameters.AddWithValue("barcode", "");
				sqlCommand.Parameters.AddWithValue("taxrate", 0);
				sqlCommand.Parameters.AddWithValue("imported", imported);
				sqlCommand.Parameters.AddWithValue("new_prodtid", this.newID);
				sqlCommand.Parameters.AddWithValue("uom", "EA");
				sqlCommand.Parameters.AddWithValue("binloc", binloc);
				sqlCommand.Parameters.AddWithValue("coid", Convert.ToInt32(this.txtCompanyID.Text));
				sqlCommand.Parameters.AddWithValue("differentpriceperbranch", 0);
				sqlCommand.Parameters.AddWithValue("wholesaleqty", 0);
				bool @checked = this.ChkWarehouse.Checked;
				if (@checked)
				{
					sqlCommand.Parameters.AddWithValue("productexpires", 1);
				}
				else
				{
					sqlCommand.Parameters.AddWithValue("productexpires", 0);
				}
				sqlCommand.Parameters.AddWithValue("supplierid", RuntimeHelpers.GetObjectValue(this.cboSuppliers.SelectedValue));
				using (sqlConnection)
				{
					sqlConnection.Open();
					this.newID = Conversions.ToInteger(sqlCommand.ExecuteScalar());
					newproductid = this.newID;
					sqlConnection.Close();
				}
				num = newproductid;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error. Detail: " + ex.Message);
				num = 0;
			}
			return num;
		}

		// Token: 0x04000256 RID: 598
		private string _cnn;

		// Token: 0x04000257 RID: 599
		private int newID;

		// Token: 0x04000258 RID: 600
		private PublicFunctions pf;

		// Token: 0x04000259 RID: 601
		private PublicFunctions2 pf2;
	}
}
