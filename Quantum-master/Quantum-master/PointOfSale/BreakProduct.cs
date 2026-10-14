using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;

namespace PointOfSale
{
	// Token: 0x0200001A RID: 26
	[DesignerGenerated]
	public partial class BreakProduct : Form
	{
		// Token: 0x0600048A RID: 1162 RVA: 0x0002BE44 File Offset: 0x0002A044
		public BreakProduct()
		{
			base.Load += this.BreakProduct_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x0600048D RID: 1165 RVA: 0x0002D41E File Offset: 0x0002B61E
		// (set) Token: 0x0600048E RID: 1166 RVA: 0x0002D428 File Offset: 0x0002B628
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x0600048F RID: 1167 RVA: 0x0002D431 File Offset: 0x0002B631
		// (set) Token: 0x06000490 RID: 1168 RVA: 0x0002D43B File Offset: 0x0002B63B
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000491 RID: 1169 RVA: 0x0002D444 File Offset: 0x0002B644
		// (set) Token: 0x06000492 RID: 1170 RVA: 0x0002D44E File Offset: 0x0002B64E
		internal virtual TextBox txtRef
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000493 RID: 1171 RVA: 0x0002D457 File Offset: 0x0002B657
		// (set) Token: 0x06000494 RID: 1172 RVA: 0x0002D461 File Offset: 0x0002B661
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x0002D46A File Offset: 0x0002B66A
		// (set) Token: 0x06000496 RID: 1174 RVA: 0x0002D474 File Offset: 0x0002B674
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

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x0002D4B7 File Offset: 0x0002B6B7
		// (set) Token: 0x06000498 RID: 1176 RVA: 0x0002D4C1 File Offset: 0x0002B6C1
		internal virtual TextBox txtQty
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000499 RID: 1177 RVA: 0x0002D4CA File Offset: 0x0002B6CA
		// (set) Token: 0x0600049A RID: 1178 RVA: 0x0002D4D4 File Offset: 0x0002B6D4
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x0600049B RID: 1179 RVA: 0x0002D4DD File Offset: 0x0002B6DD
		// (set) Token: 0x0600049C RID: 1180 RVA: 0x0002D4E7 File Offset: 0x0002B6E7
		internal virtual ComboBox cboFormualas
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x0600049D RID: 1181 RVA: 0x0002D4F0 File Offset: 0x0002B6F0
		// (set) Token: 0x0600049E RID: 1182 RVA: 0x0002D4FA File Offset: 0x0002B6FA
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x0002D503 File Offset: 0x0002B703
		// (set) Token: 0x060004A0 RID: 1184 RVA: 0x0002D50D File Offset: 0x0002B70D
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x0002D516 File Offset: 0x0002B716
		// (set) Token: 0x060004A2 RID: 1186 RVA: 0x0002D520 File Offset: 0x0002B720
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

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x060004A3 RID: 1187 RVA: 0x0002D563 File Offset: 0x0002B763
		// (set) Token: 0x060004A4 RID: 1188 RVA: 0x0002D570 File Offset: 0x0002B770
		internal virtual TextBox txtSearchProductCode
		{
			[CompilerGenerated]
			get
			{
				return this._txtSearchProductCode;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.txtSearchProductCode_TextChanged);
				TextBox textBox = this._txtSearchProductCode;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
				}
				this._txtSearchProductCode = value;
				textBox = this._txtSearchProductCode;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x060004A5 RID: 1189 RVA: 0x0002D5B3 File Offset: 0x0002B7B3
		// (set) Token: 0x060004A6 RID: 1190 RVA: 0x0002D5BD File Offset: 0x0002B7BD
		internal virtual Label Label24
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x060004A7 RID: 1191 RVA: 0x0002D5C6 File Offset: 0x0002B7C6
		// (set) Token: 0x060004A8 RID: 1192 RVA: 0x0002D5D0 File Offset: 0x0002B7D0
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x060004A9 RID: 1193 RVA: 0x0002D5D9 File Offset: 0x0002B7D9
		// (set) Token: 0x060004AA RID: 1194 RVA: 0x0002D5E4 File Offset: 0x0002B7E4
		internal virtual TextBox txtBarCode
		{
			[CompilerGenerated]
			get
			{
				return this._txtBarCode;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.txtBarCode_TextChanged);
				TextBox textBox = this._txtBarCode;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
				}
				this._txtBarCode = value;
				textBox = this._txtBarCode;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x060004AB RID: 1195 RVA: 0x0002D627 File Offset: 0x0002B827
		// (set) Token: 0x060004AC RID: 1196 RVA: 0x0002D631 File Offset: 0x0002B831
		internal virtual Label Label20
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x060004AD RID: 1197 RVA: 0x0002D63A File Offset: 0x0002B83A
		// (set) Token: 0x060004AE RID: 1198 RVA: 0x0002D644 File Offset: 0x0002B844
		internal virtual TextBox txtStockAvail
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x060004AF RID: 1199 RVA: 0x0002D64D File Offset: 0x0002B84D
		// (set) Token: 0x060004B0 RID: 1200 RVA: 0x0002D657 File Offset: 0x0002B857
		internal virtual Label lblcode
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x060004B1 RID: 1201 RVA: 0x0002D660 File Offset: 0x0002B860
		// (set) Token: 0x060004B2 RID: 1202 RVA: 0x0002D66A File Offset: 0x0002B86A
		internal virtual TextBox txtDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x060004B3 RID: 1203 RVA: 0x0002D673 File Offset: 0x0002B873
		// (set) Token: 0x060004B4 RID: 1204 RVA: 0x0002D67D File Offset: 0x0002B87D
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x060004B5 RID: 1205 RVA: 0x0002D686 File Offset: 0x0002B886
		// (set) Token: 0x060004B6 RID: 1206 RVA: 0x0002D690 File Offset: 0x0002B890
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x060004B7 RID: 1207 RVA: 0x0002D699 File Offset: 0x0002B899
		// (set) Token: 0x060004B8 RID: 1208 RVA: 0x0002D6A4 File Offset: 0x0002B8A4
		internal virtual DataGridView DGVSearch
		{
			[CompilerGenerated]
			get
			{
				return this._DGVSearch;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DGVSearch_CellEnter);
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.DGVSearch_KeyDown);
				DataGridView dataGridView = this._DGVSearch;
				if (dataGridView != null)
				{
					dataGridView.CellEnter -= dataGridViewCellEventHandler;
					dataGridView.KeyDown -= keyEventHandler;
				}
				this._DGVSearch = value;
				dataGridView = this._DGVSearch;
				if (dataGridView != null)
				{
					dataGridView.CellEnter += dataGridViewCellEventHandler;
					dataGridView.KeyDown += keyEventHandler;
				}
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x060004B9 RID: 1209 RVA: 0x0002D702 File Offset: 0x0002B902
		// (set) Token: 0x060004BA RID: 1210 RVA: 0x0002D70C File Offset: 0x0002B90C
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x060004BB RID: 1211 RVA: 0x0002D715 File Offset: 0x0002B915
		// (set) Token: 0x060004BC RID: 1212 RVA: 0x0002D720 File Offset: 0x0002B920
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

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x060004BD RID: 1213 RVA: 0x0002D763 File Offset: 0x0002B963
		// (set) Token: 0x060004BE RID: 1214 RVA: 0x0002D76D File Offset: 0x0002B96D
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x060004BF RID: 1215 RVA: 0x0002D776 File Offset: 0x0002B976
		// (set) Token: 0x060004C0 RID: 1216 RVA: 0x0002D780 File Offset: 0x0002B980
		internal virtual TextBox txtsearch
		{
			[CompilerGenerated]
			get
			{
				return this._txtsearch;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.txtsearch_TextChanged);
				TextBox textBox = this._txtsearch;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
				}
				this._txtsearch = value;
				textBox = this._txtsearch;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x060004C1 RID: 1217 RVA: 0x0002D7C3 File Offset: 0x0002B9C3
		// (set) Token: 0x060004C2 RID: 1218 RVA: 0x0002D7CD File Offset: 0x0002B9CD
		internal virtual GroupBox GroupBox3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x060004C3 RID: 1219 RVA: 0x0002D7D6 File Offset: 0x0002B9D6
		// (set) Token: 0x060004C4 RID: 1220 RVA: 0x0002D7E0 File Offset: 0x0002B9E0
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

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x060004C5 RID: 1221 RVA: 0x0002D823 File Offset: 0x0002BA23
		// (set) Token: 0x060004C6 RID: 1222 RVA: 0x0002D82D File Offset: 0x0002BA2D
		internal virtual DataGridView dgvIngridients
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x060004C7 RID: 1223 RVA: 0x0002D836 File Offset: 0x0002BA36
		// (set) Token: 0x060004C8 RID: 1224 RVA: 0x0002D840 File Offset: 0x0002BA40
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x060004C9 RID: 1225 RVA: 0x0002D849 File Offset: 0x0002BA49
		// (set) Token: 0x060004CA RID: 1226 RVA: 0x0002D853 File Offset: 0x0002BA53
		internal virtual DateTimePicker DTDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x060004CB RID: 1227 RVA: 0x0002D85C File Offset: 0x0002BA5C
		// (set) Token: 0x060004CC RID: 1228 RVA: 0x0002D866 File Offset: 0x0002BA66
		internal virtual ComboBox cboBatches
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x060004CD RID: 1229 RVA: 0x0002D86F File Offset: 0x0002BA6F
		// (set) Token: 0x060004CE RID: 1230 RVA: 0x0002D879 File Offset: 0x0002BA79
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x0002D884 File Offset: 0x0002BA84
		private void BreakProduct_Load(object sender, EventArgs e)
		{
			try
			{
				bool flag = MyProject.Forms.Form1.DateChange == 1;
				if (flag)
				{
					this.DTDate.Enabled = true;
				}
				else
				{
					this.DTDate.Enabled = false;
				}
				bool flag2 = MyProject.Forms.Form1.IsWarehouse == 0;
				if (flag2)
				{
					this.Label7.Visible = false;
					this.cboBatches.Visible = false;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x0002D934 File Offset: 0x0002BB34
		private void LoadBatches(int productid, int coid, string branch)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "StockBalanceWarehouse2";
			sqlCommand.Parameters.AddWithValue("productid", productid);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			this.cboBatches.DataSource = dataTable;
			this.cboBatches.ValueMember = "bal";
			this.cboBatches.DisplayMember = "batch";
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x0002D9F0 File Offset: 0x0002BBF0
		private void txtsearch_TextChanged(object sender, EventArgs e)
		{
			try
			{
				bool flag = MyProject.Forms.Form1.OnlineSearchOptimised == 0;
				if (flag)
				{
					this.lblerror.Text = "...";
					this.SearchByDescAdvanced(this.txtsearch.Text);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Detail: " + ex.Message);
			}
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x0002DA78 File Offset: 0x0002BC78
		private void SearchByDesc(string searchtext)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SearchProduct2";
			sqlCommand.Parameters.AddWithValue("search", searchtext);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				this.DGVSearch.DataSource = dataTable;
				this.DGVSearch.Columns["ProductCode"].Visible = false;
				this.DGVSearch.Columns["ProductID"].Visible = false;
				this.DGVSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			}
			else
			{
				this.lblerror.Text = "No products match your search.";
			}
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x0002DB70 File Offset: 0x0002BD70
		private void SearchByDescAdvanced(string searchtext)
		{
			string[] array = searchtext.Split(new char[] { ' ' });
			int num = 1;
			DataTable dataTable = new DataTable();
			checked
			{
				foreach (string text in array)
				{
					bool flag = num == 1;
					if (flag)
					{
						dataTable = this.searchDB(text);
					}
					else
					{
						DataTable dataTable2 = new DataTable();
						dataTable2 = (DataTable)this.searchDat(dataTable, "ProductDesc", text);
						dataTable = dataTable2;
					}
					num++;
				}
				bool flag2 = dataTable.Rows.Count > 0;
				if (flag2)
				{
					this.DGVSearch.DataSource = dataTable;
					this.DGVSearch.Columns["ProductCode"].Visible = false;
					this.DGVSearch.Columns["ProductID"].Visible = false;
					this.DGVSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				}
				else
				{
					this.lblerror.Text = "No products match your search.";
				}
			}
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x0002DC7C File Offset: 0x0002BE7C
		private object searchDat(DataTable dt, string column, string value)
		{
			BreakProduct._Closure$__146-0 CS$<>8__locals1 = new BreakProduct._Closure$__146-0(CS$<>8__locals1);
			CS$<>8__locals1.$VB$Local_column = column;
			CS$<>8__locals1.$VB$Local_value = value;
			DataTable dataTable = dt.Clone();
			dt.CaseSensitive = false;
			try
			{
				foreach (DataRow dataRow in dt.Rows.Cast<object>().Select<object, DataRow>((BreakProduct._Closure$__.$I146-0 == null) ? (BreakProduct._Closure$__.$I146-0 = (object row1) => (DataRow)row1) : BreakProduct._Closure$__.$I146-0).Where<DataRow>((CS$<>8__locals1.$I1 == null) ? (CS$<>8__locals1.$I1 = (DataRow row1) => Conversions.ToBoolean(NewLateBinding.LateGet(row1[CS$<>8__locals1.$VB$Local_column], null, "Contains", new object[] { CS$<>8__locals1.$VB$Local_value.ToUpper() }, null, null, null))) : CS$<>8__locals1.$I1))
				{
					dataTable.ImportRow(dataRow);
				}
			}
			finally
			{
				IEnumerator<DataRow> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			return dataTable;
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x0002DD58 File Offset: 0x0002BF58
		private DataTable searchDB(string searchtext)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SearchProduct2";
			sqlCommand.Parameters.AddWithValue("search", searchtext);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x0002DDE0 File Offset: 0x0002BFE0
		private void FetchAllProducts()
		{
			this.lblerror.Text = "...";
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectAllProducts2";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				this.DGVSearch.DataSource = dataTable;
				this.DGVSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				this.DGVSearch.Columns["CatDesc"].Visible = false;
				this.DGVSearch.Columns["Reorder_Level"].Visible = false;
				this.DGVSearch.Columns["Unit_Selling_Price"].Visible = false;
				this.DGVSearch.Columns["Unit_Cost"].Visible = false;
				this.DGVSearch.Columns["ProductID"].Visible = false;
				this.DGVSearch.Columns["ProductCode"].Visible = false;
				this.DGVSearch.Columns["Tax_Percentage"].Visible = false;
				this.DGVSearch.Columns["Bin_Location"].Visible = false;
				this.DGVSearch.Columns["Unit_of_Measure"].Visible = false;
				this.DGVSearch.Columns["SpecialPrice"].Visible = false;
			}
			else
			{
				this.lblerror.Text = "No products match your search.";
			}
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x0002DFB8 File Offset: 0x0002C1B8
		private void Button3_Click(object sender, EventArgs e)
		{
			try
			{
				this.lblerror.Text = "...";
				this.FetchAllProducts();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Detail: " + ex.Message);
			}
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x0002E018 File Offset: 0x0002C218
		private void DGVSearch_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					int num = Conversions.ToInteger(this.DGVSearch.Rows[e.RowIndex].Cells["ProductID"].Value);
					this.txtSearchProductCode.Text = Conversions.ToString(num);
				}
			}
			catch (Exception ex)
			{
				this.lblerror.Text = "Error: " + ex.Message;
			}
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x0002E0DC File Offset: 0x0002C2DC
		private void DGVSearch_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				bool flag = e.KeyCode == Keys.Return;
				if (flag)
				{
					this.txtQty.Focus();
					e.Handled = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Key down error. Ignore");
			}
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x0002E13C File Offset: 0x0002C33C
		private void txtBarCode_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.txtStockAvail.Text = Conversions.ToString(0);
				this.txtDesc.Text = "No product matches your search.";
				this.SearchProductCode(Conversions.ToString(Interaction.IIf(Operators.CompareString(this.txtBarCode.Text, "", false) == 0, 0, this.txtBarCode.Text)));
			}
			catch (Exception ex)
			{
				MessageBox.Show("Bar code error. Detail: " + ex.Message);
			}
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x0002E1E4 File Offset: 0x0002C3E4
		private void SearchBarCode(int prodtID)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchProductByID2";
			sqlCommand.Parameters.AddWithValue("prodtID", prodtID);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				this.txtDesc.Text = Conversions.ToString(dataRow["ProductDesc"]);
				this.lblcode.Text = Conversions.ToString(dataRow["ProductCode"]);
				this.CurrentID = Conversions.ToInteger(dataRow["ProductID"]);
				this.CurrentCode = Conversions.ToString(dataRow["ProductCode"]);
				this.CurrentDesc = Conversions.ToString(dataRow["ProductDesc"]);
				this.txtStockAvail.Text = Conversions.ToString(this.GetStockAvailable(this.CurrentID));
			}
			else
			{
				this.txtSearchProductCode.Text = "";
			}
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x0002E33C File Offset: 0x0002C53C
		private void SearchProductCode(string prodtcode)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchProductByCode2";
			sqlCommand.Parameters.AddWithValue("productcode", prodtcode);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				this.txtDesc.Text = Conversions.ToString(dataRow["ProductDesc"]);
				this.lblcode.Text = Conversions.ToString(dataRow["ProductCode"]);
				this.CurrentID = Conversions.ToInteger(dataRow["ProductID"]);
				this.CurrentCode = Conversions.ToString(dataRow["ProductCode"]);
				this.CurrentDesc = Conversions.ToString(dataRow["ProductDesc"]);
				this.txtStockAvail.Text = Conversions.ToString(this.GetStockAvailable(this.CurrentID));
			}
			else
			{
				this.txtSearchProductCode.Text = "";
			}
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x0002E48C File Offset: 0x0002C68C
		private decimal GetStockAvailable(int productid)
		{
			int num = 0;
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "TotalStockIn";
			sqlCommand.Parameters.AddWithValue("productid", productid);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			using (sqlConnection)
			{
				sqlConnection.Open();
				int num2 = sqlDataAdapter.Fill(dataTable);
				bool flag = num2 > 0;
				if (flag)
				{
					DataRow dataRow = dataTable.Rows[0];
					num = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow[0])), 0, RuntimeHelpers.GetObjectValue(dataRow[0])));
				}
				else
				{
					num = 0;
				}
				sqlConnection.Close();
			}
			int num3 = 0;
			SqlConnection sqlConnection3 = new SqlConnection(this._cnn);
			SqlCommand sqlCommand2 = sqlConnection3.CreateCommand();
			sqlCommand2.CommandType = CommandType.StoredProcedure;
			sqlCommand2.CommandText = "TotalStockOut";
			sqlCommand2.Parameters.AddWithValue("productid", productid);
			sqlCommand2.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand2.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			DataTable dataTable2 = new DataTable();
			SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter(sqlCommand2);
			using (sqlConnection3)
			{
				sqlConnection3.Open();
				int num4 = sqlDataAdapter2.Fill(dataTable2);
				bool flag2 = num4 > 0;
				if (flag2)
				{
					DataRow dataRow2 = dataTable2.Rows[0];
					num3 = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2[0])), 0, RuntimeHelpers.GetObjectValue(dataRow2[0])));
				}
				else
				{
					num3 = 0;
				}
				sqlConnection3.Close();
			}
			decimal num5 = new decimal(checked(num - num3));
			return num5;
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x0002E6F8 File Offset: 0x0002C8F8
		private void LoadFormulas(int coid, int productid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectFormulas";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("productid", productid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			this.cboFormualas.DataSource = dataTable;
			this.cboFormualas.ValueMember = "FormulaName";
			this.cboFormualas.DisplayMember = "FormulaName";
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x0002E7A0 File Offset: 0x0002C9A0
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.CurrentID != 0;
				if (flag)
				{
					this.LoadFormulas(MyProject.Forms.Form1.coid, this.CurrentID);
				}
				else
				{
					MessageBox.Show("Select the product first.");
				}
				bool flag2 = MyProject.Forms.Form1.IsWarehouse == 1;
				if (flag2)
				{
					this.LoadBatches(this.CurrentID, MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading formulas. Detail: " + ex.Message);
			}
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x0002E864 File Offset: 0x0002CA64
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = (Operators.CompareString(this.txtQty.Text, "", false) != 0) & (this.CurrentID != 0);
				if (flag)
				{
					bool flag2 = MyProject.Forms.Form1.NegativeStock == 0;
					if (flag2)
					{
						bool flag3 = Conversion.Val(this.txtStockAvail.Text) >= Convert.ToDouble(Convert.ToDecimal(this.txtQty.Text));
						if (flag3)
						{
							this.LoadIngridients(MyProject.Forms.Form1.coid, this.cboFormualas.Text);
							this.PopulateGrid();
						}
						else
						{
							MessageBox.Show("Qty required is greater than stock available.");
						}
					}
					else
					{
						this.LoadIngridients(MyProject.Forms.Form1.coid, this.cboFormualas.Text);
						this.PopulateGrid();
					}
				}
				else
				{
					MessageBox.Show("Please check quantity and if the product is selected.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error calculating product conversion details. Detail: " + ex.Message);
			}
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x0002E990 File Offset: 0x0002CB90
		private void LoadIngridients(int coid, string formulaname)
		{
			this.dgvIngridients.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectFormulaIngridients";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("formulaname", formulaname);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			this.dgvIngridients.DataSource = dataTable;
			this.dgvIngridients.Columns["ProductID"].HeaderText = "Product ID";
			this.dgvIngridients.Columns["ProductDesc"].HeaderText = "Product Description";
			this.dgvIngridients.Columns["qty"].HeaderText = "Qty for Formula";
			this.dgvIngridients.Columns.Add("Stock_Available", "Stock Available");
			this.dgvIngridients.Columns.Add("CalculatedQty", "Calculated Qty");
			this.dgvIngridients.Columns.Add("ActualQty", "Actual Qty to be Made");
			this.dgvIngridients.Columns["Stock_Available"].ReadOnly = true;
			this.dgvIngridients.Columns["CalculatedQty"].ReadOnly = true;
			this.dgvIngridients.Columns["productid"].ReadOnly = true;
			this.dgvIngridients.Columns["qty"].ReadOnly = true;
			this.dgvIngridients.Columns["Stock_Available"].DefaultCellStyle.BackColor = Color.LightGray;
			this.dgvIngridients.Columns["CalculatedQty"].DefaultCellStyle.BackColor = Color.LightGray;
			this.dgvIngridients.Columns["productid"].DefaultCellStyle.BackColor = Color.LightGray;
			this.dgvIngridients.Columns["qty"].DefaultCellStyle.BackColor = Color.LightGray;
			this.dgvIngridients.Columns["ProductDesc"].DefaultCellStyle.BackColor = Color.LightGray;
			this.dgvIngridients.Columns["entryno"].Visible = false;
			this.dgvIngridients.Columns["qty"].HeaderText = "Formula Qty";
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x0002EC38 File Offset: 0x0002CE38
		private void PopulateGrid()
		{
			try
			{
				foreach (object obj in ((IEnumerable)this.dgvIngridients.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					dataGridViewRow.Cells["Stock_Available"].Value = this.GetStockAvailable(Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["productid"].Value)));
					dataGridViewRow.Cells["CalculatedQty"].Value = decimal.Multiply(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["qty"].Value)), Convert.ToDecimal(this.txtQty.Text));
					dataGridViewRow.Cells["ActualQty"].Value = RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["CalculatedQty"].Value);
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

		// Token: 0x060004E3 RID: 1251 RVA: 0x0002ED5C File Offset: 0x0002CF5C
		private void Button4_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					bool flag = this.dgvIngridients.Rows.Count <= 0;
					if (flag)
					{
						MessageBox.Show("Please calculate firt before making the product.");
						this.Button1.Focus();
					}
					else
					{
						DialogResult dialogResult = (DialogResult)Interaction.MsgBox("Are you sure you want to BREAK this product using the selected formula?", MsgBoxStyle.YesNo, null);
						bool flag2 = dialogResult == DialogResult.Yes;
						if (flag2)
						{
							bool flag3 = this.CurrentID != 0;
							if (flag3)
							{
								SqlConnection sqlConnection = new SqlConnection(this._cnn);
								SqlCommand sqlCommand = sqlConnection.CreateCommand();
								sqlCommand.Connection = sqlConnection;
								sqlConnection.Open();
								SqlTransaction sqlTransaction = sqlConnection.BeginTransaction("RunProductBreak");
								sqlCommand.Transaction = sqlTransaction;
								try
								{
									sqlCommand.Parameters.Clear();
									sqlCommand.CommandText = "GetProductConvertedNumber";
									sqlCommand.CommandType = CommandType.StoredProcedure;
									sqlCommand.Parameters.AddWithValue("desc", DateTime.Today.ToString("yyyyMMdd") + DateAndTime.Now.TimeOfDay.ToString());
									int coid = MyProject.Forms.Form1.coid;
									sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
									sqlCommand.Parameters.AddWithValue("newconvertednum", 0);
									int num = Conversions.ToInteger(sqlCommand.ExecuteScalar());
									try
									{
										foreach (object obj in ((IEnumerable)this.dgvIngridients.Rows))
										{
											DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
											sqlCommand.Parameters.Clear();
											sqlCommand.CommandType = CommandType.StoredProcedure;
											sqlCommand.CommandText = "InsertProductsConverted";
											sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
											sqlCommand.Parameters.AddWithValue("trandate", this.DTDate.Value);
											sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
											sqlCommand.Parameters.AddWithValue("formulaname", this.cboFormualas.Text);
											sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
											sqlCommand.Parameters.AddWithValue("ref", this.txtRef.Text);
											sqlCommand.Parameters.AddWithValue("QTYCalculated", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["CalculatedQty"].Value));
											sqlCommand.Parameters.AddWithValue("QTYActual", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ActualQty"].Value));
											sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["productid"].Value));
											sqlCommand.Parameters.AddWithValue("type", "BREAK");
											sqlCommand.Parameters.AddWithValue("convertedproductid", this.CurrentID);
											sqlCommand.Parameters.AddWithValue("invnumber", num);
											sqlCommand.ExecuteNonQuery();
											sqlCommand.Parameters.Clear();
											sqlCommand.CommandText = "InsertNewStock2Warehouse";
											sqlCommand.Parameters.AddWithValue("trandate", this.DTDate.Value.ToString("yyyyMMdd"));
											sqlCommand.Parameters.AddWithValue("invoicenum", num);
											sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["productid"].Value));
											sqlCommand.Parameters.AddWithValue("isstockin", 1);
											sqlCommand.Parameters.AddWithValue("ref", this.txtRef.Text);
											sqlCommand.Parameters.AddWithValue("quantity", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ActualQty"].Value));
											sqlCommand.Parameters.AddWithValue("cost", 0);
											sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
											sqlCommand.Parameters.AddWithValue("donewhen", Convert.ToInt32(this.DTDate.Value.ToString("yyyyMMdd")));
											sqlCommand.Parameters.AddWithValue("trancode", 9);
											sqlCommand.Parameters.AddWithValue("productcode", this.pf.GetProductCodeFromID(MyProject.Forms.Form1.coid, Conversions.ToInteger(dataGridViewRow.Cells["productid"].Value), this._cnn));
											sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
											sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
											bool flag4 = MyProject.Forms.Form1.IsWarehouse == 1;
											if (flag4)
											{
												string text = this.cboBatches.Text;
												string text2 = Strings.Trim(text.Substring(text.IndexOf(": ") + 1));
												int num2 = text2.IndexOf("Expiry:") + 1;
												string text3 = Strings.Trim(text2.Substring(0, num2 - 1));
												string text4 = Strings.Trim(text.Substring(text.IndexOf("Expiry: ")));
												text4 = Strings.Trim(text4.Substring(text4.IndexOf(": ") + 1));
												sqlCommand.Parameters.AddWithValue("BatchNumber", text3);
												sqlCommand.Parameters.AddWithValue("ExpiryDate", Convert.ToInt32(text4));
											}
											else
											{
												sqlCommand.Parameters.AddWithValue("BatchNumber", "");
												sqlCommand.Parameters.AddWithValue("ExpiryDate", 0);
											}
											sqlCommand.Parameters.AddWithValue("suppliername", "");
											sqlCommand.Parameters.AddWithValue("sellingprice", 0);
											sqlCommand.Parameters.AddWithValue("iswarehouse", MyProject.Forms.Form1.IsWarehouse);
											sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
											sqlCommand.Parameters.AddWithValue("trantime", DateTime.Now.ToString("HHmm"));
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
									sqlCommand.Parameters.Clear();
									sqlCommand.CommandText = "InsertNewStock2Warehouse";
									sqlCommand.Parameters.AddWithValue("trandate", this.DTDate.Value.ToString("yyyyMMdd"));
									sqlCommand.Parameters.AddWithValue("invoicenum", num);
									sqlCommand.Parameters.AddWithValue("productid", this.CurrentID);
									sqlCommand.Parameters.AddWithValue("isstockin", 0);
									sqlCommand.Parameters.AddWithValue("ref", this.txtRef.Text);
									sqlCommand.Parameters.AddWithValue("quantity", Convert.ToDecimal(this.txtQty.Text));
									sqlCommand.Parameters.AddWithValue("cost", 0);
									sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
									sqlCommand.Parameters.AddWithValue("donewhen", Convert.ToInt32(this.DTDate.Value.ToString("yyyyMMdd")));
									sqlCommand.Parameters.AddWithValue("trancode", 9);
									sqlCommand.Parameters.AddWithValue("productcode", this.pf.GetProductCodeFromID(MyProject.Forms.Form1.coid, this.CurrentID, this._cnn));
									sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
									sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
									bool flag5 = MyProject.Forms.Form1.IsWarehouse == 1;
									if (flag5)
									{
										string text5 = this.cboBatches.Text;
										string text6 = Strings.Trim(text5.Substring(text5.IndexOf(": ") + 1));
										int num3 = text6.IndexOf("Expiry:") + 1;
										string text7 = Strings.Trim(text6.Substring(0, num3 - 1));
										string text8 = Strings.Trim(text5.Substring(text5.IndexOf("Expiry: ")));
										text8 = Strings.Trim(text8.Substring(text8.IndexOf(": ") + 1));
										sqlCommand.Parameters.AddWithValue("BatchNumber", text7);
										sqlCommand.Parameters.AddWithValue("ExpiryDate", Convert.ToInt32(text8));
									}
									else
									{
										sqlCommand.Parameters.AddWithValue("BatchNumber", "");
										sqlCommand.Parameters.AddWithValue("ExpiryDate", 0);
									}
									sqlCommand.Parameters.AddWithValue("suppliername", "");
									sqlCommand.Parameters.AddWithValue("Sellingprice", 0);
									sqlCommand.Parameters.AddWithValue("iswarehouse", MyProject.Forms.Form1.IsWarehouse);
									sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
									sqlCommand.Parameters.AddWithValue("trantime", DateTime.Now.ToString("HHmm"));
									sqlCommand.ExecuteNonQuery();
									sqlCommand.Parameters.Clear();
									sqlCommand.CommandType = CommandType.StoredProcedure;
									sqlCommand.CommandText = "InsertProductsConverted";
									sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
									sqlCommand.Parameters.AddWithValue("trandate", this.DTDate.Value);
									sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
									sqlCommand.Parameters.AddWithValue("formulaname", this.cboFormualas.Text);
									sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
									sqlCommand.Parameters.AddWithValue("ref", this.txtRef.Text);
									sqlCommand.Parameters.AddWithValue("QTYCalculated", Convert.ToDecimal(this.txtQty.Text));
									sqlCommand.Parameters.AddWithValue("QTYActual", Convert.ToDecimal(this.txtQty.Text));
									sqlCommand.Parameters.AddWithValue("productid", this.CurrentID);
									sqlCommand.Parameters.AddWithValue("type", "BREAK");
									sqlCommand.Parameters.AddWithValue("convertedproductid", this.CurrentID);
									sqlCommand.Parameters.AddWithValue("invnumber", num);
									sqlCommand.ExecuteNonQuery();
									sqlTransaction.Commit();
									sqlCommand.Connection.Close();
									MessageBox.Show("Product have been successfully BROKEN.");
									this.CurrentID = 0;
									this.CurrentDesc = "";
									this.CurrentCode = "";
								}
								catch (Exception ex)
								{
									MessageBox.Show("Error breaking product. Detail:  " + ex.Message);
								}
							}
							else
							{
								MessageBox.Show("Select product first.");
							}
						}
					}
				}
				catch (Exception ex2)
				{
					MessageBox.Show("Error making product. Detail: " + ex2.Message);
				}
			}
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x0002FA98 File Offset: 0x0002DC98
		private void txtSearchProductCode_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.txtStockAvail.Text = Conversions.ToString(0);
				this.txtDesc.Text = "No product matches your search.";
				this.SearchBarCode(Conversions.ToInteger(Interaction.IIf(Operators.CompareString(this.txtSearchProductCode.Text, "", false) == 0, 0, Conversion.Val(this.txtSearchProductCode.Text))));
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Details: " + ex.Message, "Error");
			}
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x0002FB4C File Offset: 0x0002DD4C
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			bool flag2;
			try
			{
				bool flag = msg.WParam.ToInt32() == 112;
				if (flag)
				{
					this.txtBarCode.Focus();
				}
				flag2 = base.ProcessCmdKey(ref msg, keyData);
			}
			catch (Exception ex)
			{
			}
			return flag2;
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x0002FBAC File Offset: 0x0002DDAC
		private void Button5_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					string text = this.cboBatches.Text;
					string text2 = Strings.Trim(text.Substring(text.IndexOf(": ") + 1));
					int num = text2.IndexOf("Expiry:") + 1;
					string text3 = Strings.Trim(text2.Substring(0, num - 1));
					string text4 = Strings.Trim(text.Substring(text.IndexOf("Expiry: ")));
					text4 = Strings.Trim(text4.Substring(text4.IndexOf(": ") + 1));
					MessageBox.Show("Batch: " + text3 + "Expiry: " + text4);
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x04000239 RID: 569
		private string _cnn;

		// Token: 0x0400023A RID: 570
		private int CurrentID;

		// Token: 0x0400023B RID: 571
		private string CurrentCode;

		// Token: 0x0400023C RID: 572
		private string CurrentDesc;

		// Token: 0x0400023D RID: 573
		private PublicFunctions pf;
	}
}
