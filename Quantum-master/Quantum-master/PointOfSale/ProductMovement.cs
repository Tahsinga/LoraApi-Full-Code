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
	// Token: 0x02000170 RID: 368
	[DesignerGenerated]
	public partial class ProductMovement : UserControl
	{
		// Token: 0x060033C0 RID: 13248 RVA: 0x001BEA14 File Offset: 0x001BCC14
		public ProductMovement()
		{
			base.Load += this.ProductMovement_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x1700133B RID: 4923
		// (get) Token: 0x060033C3 RID: 13251 RVA: 0x001C0015 File Offset: 0x001BE215
		// (set) Token: 0x060033C4 RID: 13252 RVA: 0x001C001F File Offset: 0x001BE21F
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700133C RID: 4924
		// (get) Token: 0x060033C5 RID: 13253 RVA: 0x001C0028 File Offset: 0x001BE228
		// (set) Token: 0x060033C6 RID: 13254 RVA: 0x001C0032 File Offset: 0x001BE232
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700133D RID: 4925
		// (get) Token: 0x060033C7 RID: 13255 RVA: 0x001C003B File Offset: 0x001BE23B
		// (set) Token: 0x060033C8 RID: 13256 RVA: 0x001C0045 File Offset: 0x001BE245
		internal virtual DateTimePicker DTend
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700133E RID: 4926
		// (get) Token: 0x060033C9 RID: 13257 RVA: 0x001C004E File Offset: 0x001BE24E
		// (set) Token: 0x060033CA RID: 13258 RVA: 0x001C0058 File Offset: 0x001BE258
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700133F RID: 4927
		// (get) Token: 0x060033CB RID: 13259 RVA: 0x001C0061 File Offset: 0x001BE261
		// (set) Token: 0x060033CC RID: 13260 RVA: 0x001C006C File Offset: 0x001BE26C
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

		// Token: 0x17001340 RID: 4928
		// (get) Token: 0x060033CD RID: 13261 RVA: 0x001C00AF File Offset: 0x001BE2AF
		// (set) Token: 0x060033CE RID: 13262 RVA: 0x001C00B9 File Offset: 0x001BE2B9
		internal virtual DateTimePicker DTstart
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001341 RID: 4929
		// (get) Token: 0x060033CF RID: 13263 RVA: 0x001C00C2 File Offset: 0x001BE2C2
		// (set) Token: 0x060033D0 RID: 13264 RVA: 0x001C00CC File Offset: 0x001BE2CC
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001342 RID: 4930
		// (get) Token: 0x060033D1 RID: 13265 RVA: 0x001C00D5 File Offset: 0x001BE2D5
		// (set) Token: 0x060033D2 RID: 13266 RVA: 0x001C00E0 File Offset: 0x001BE2E0
		internal virtual DataGridView dgvMovement
		{
			[CompilerGenerated]
			get
			{
				return this._dgvMovement;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgvMovement_CellContentClick);
				DataGridView dataGridView = this._dgvMovement;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick -= dataGridViewCellEventHandler;
				}
				this._dgvMovement = value;
				dataGridView = this._dgvMovement;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x17001343 RID: 4931
		// (get) Token: 0x060033D3 RID: 13267 RVA: 0x001C0123 File Offset: 0x001BE323
		// (set) Token: 0x060033D4 RID: 13268 RVA: 0x001C0130 File Offset: 0x001BE330
		internal virtual TextBox txtSearchProductID
		{
			[CompilerGenerated]
			get
			{
				return this._txtSearchProductID;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtSearchProductID_KeyPress);
				EventHandler eventHandler = new EventHandler(this.txtSearchProductID_TextChanged);
				TextBox textBox = this._txtSearchProductID;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
					textBox.TextChanged -= eventHandler;
				}
				this._txtSearchProductID = value;
				textBox = this._txtSearchProductID;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17001344 RID: 4932
		// (get) Token: 0x060033D5 RID: 13269 RVA: 0x001C018E File Offset: 0x001BE38E
		// (set) Token: 0x060033D6 RID: 13270 RVA: 0x001C0198 File Offset: 0x001BE398
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001345 RID: 4933
		// (get) Token: 0x060033D7 RID: 13271 RVA: 0x001C01A1 File Offset: 0x001BE3A1
		// (set) Token: 0x060033D8 RID: 13272 RVA: 0x001C01AB File Offset: 0x001BE3AB
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001346 RID: 4934
		// (get) Token: 0x060033D9 RID: 13273 RVA: 0x001C01B4 File Offset: 0x001BE3B4
		// (set) Token: 0x060033DA RID: 13274 RVA: 0x001C01BE File Offset: 0x001BE3BE
		internal virtual TextBox lblDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001347 RID: 4935
		// (get) Token: 0x060033DB RID: 13275 RVA: 0x001C01C7 File Offset: 0x001BE3C7
		// (set) Token: 0x060033DC RID: 13276 RVA: 0x001C01D4 File Offset: 0x001BE3D4
		internal virtual Label Label5
		{
			[CompilerGenerated]
			get
			{
				return this._Label5;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label5_Click);
				Label label = this._Label5;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label5 = value;
				label = this._Label5;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x17001348 RID: 4936
		// (get) Token: 0x060033DD RID: 13277 RVA: 0x001C0217 File Offset: 0x001BE417
		// (set) Token: 0x060033DE RID: 13278 RVA: 0x001C0224 File Offset: 0x001BE424
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

		// Token: 0x17001349 RID: 4937
		// (get) Token: 0x060033DF RID: 13279 RVA: 0x001C0267 File Offset: 0x001BE467
		// (set) Token: 0x060033E0 RID: 13280 RVA: 0x001C0271 File Offset: 0x001BE471
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700134A RID: 4938
		// (get) Token: 0x060033E1 RID: 13281 RVA: 0x001C027A File Offset: 0x001BE47A
		// (set) Token: 0x060033E2 RID: 13282 RVA: 0x001C0284 File Offset: 0x001BE484
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700134B RID: 4939
		// (get) Token: 0x060033E3 RID: 13283 RVA: 0x001C028D File Offset: 0x001BE48D
		// (set) Token: 0x060033E4 RID: 13284 RVA: 0x001C0298 File Offset: 0x001BE498
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
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.DGVSearch_KeyDown);
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DGVSearch_CellEnter);
				DataGridView dataGridView = this._DGVSearch;
				if (dataGridView != null)
				{
					dataGridView.KeyDown -= keyEventHandler;
					dataGridView.CellEnter -= dataGridViewCellEventHandler;
				}
				this._DGVSearch = value;
				dataGridView = this._DGVSearch;
				if (dataGridView != null)
				{
					dataGridView.KeyDown += keyEventHandler;
					dataGridView.CellEnter += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x1700134C RID: 4940
		// (get) Token: 0x060033E5 RID: 13285 RVA: 0x001C02F6 File Offset: 0x001BE4F6
		// (set) Token: 0x060033E6 RID: 13286 RVA: 0x001C0300 File Offset: 0x001BE500
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700134D RID: 4941
		// (get) Token: 0x060033E7 RID: 13287 RVA: 0x001C0309 File Offset: 0x001BE509
		// (set) Token: 0x060033E8 RID: 13288 RVA: 0x001C0314 File Offset: 0x001BE514
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

		// Token: 0x1700134E RID: 4942
		// (get) Token: 0x060033E9 RID: 13289 RVA: 0x001C0357 File Offset: 0x001BE557
		// (set) Token: 0x060033EA RID: 13290 RVA: 0x001C0361 File Offset: 0x001BE561
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700134F RID: 4943
		// (get) Token: 0x060033EB RID: 13291 RVA: 0x001C036A File Offset: 0x001BE56A
		// (set) Token: 0x060033EC RID: 13292 RVA: 0x001C0374 File Offset: 0x001BE574
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

		// Token: 0x17001350 RID: 4944
		// (get) Token: 0x060033ED RID: 13293 RVA: 0x001C03B7 File Offset: 0x001BE5B7
		// (set) Token: 0x060033EE RID: 13294 RVA: 0x001C03C1 File Offset: 0x001BE5C1
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001351 RID: 4945
		// (get) Token: 0x060033EF RID: 13295 RVA: 0x001C03CA File Offset: 0x001BE5CA
		// (set) Token: 0x060033F0 RID: 13296 RVA: 0x001C03D4 File Offset: 0x001BE5D4
		internal virtual ComboBox cboBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001352 RID: 4946
		// (get) Token: 0x060033F1 RID: 13297 RVA: 0x001C03DD File Offset: 0x001BE5DD
		// (set) Token: 0x060033F2 RID: 13298 RVA: 0x001C03E7 File Offset: 0x001BE5E7
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001353 RID: 4947
		// (get) Token: 0x060033F3 RID: 13299 RVA: 0x001C03F0 File Offset: 0x001BE5F0
		// (set) Token: 0x060033F4 RID: 13300 RVA: 0x001C03FA File Offset: 0x001BE5FA
		internal virtual CheckBox chkAllBranches
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001354 RID: 4948
		// (get) Token: 0x060033F5 RID: 13301 RVA: 0x001C0403 File Offset: 0x001BE603
		// (set) Token: 0x060033F6 RID: 13302 RVA: 0x001C0410 File Offset: 0x001BE610
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

		// Token: 0x17001355 RID: 4949
		// (get) Token: 0x060033F7 RID: 13303 RVA: 0x001C0453 File Offset: 0x001BE653
		// (set) Token: 0x060033F8 RID: 13304 RVA: 0x001C045D File Offset: 0x001BE65D
		internal virtual SaveFileDialog SaveFileDialog1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001356 RID: 4950
		// (get) Token: 0x060033F9 RID: 13305 RVA: 0x001C0466 File Offset: 0x001BE666
		// (set) Token: 0x060033FA RID: 13306 RVA: 0x001C0470 File Offset: 0x001BE670
		internal virtual OpenFileDialog OpenFileDialog1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001357 RID: 4951
		// (get) Token: 0x060033FB RID: 13307 RVA: 0x001C0479 File Offset: 0x001BE679
		// (set) Token: 0x060033FC RID: 13308 RVA: 0x001C0484 File Offset: 0x001BE684
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

		// Token: 0x17001358 RID: 4952
		// (get) Token: 0x060033FD RID: 13309 RVA: 0x001C04C7 File Offset: 0x001BE6C7
		// (set) Token: 0x060033FE RID: 13310 RVA: 0x001C04D4 File Offset: 0x001BE6D4
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

		// Token: 0x17001359 RID: 4953
		// (get) Token: 0x060033FF RID: 13311 RVA: 0x001C0517 File Offset: 0x001BE717
		// (set) Token: 0x06003400 RID: 13312 RVA: 0x001C0524 File Offset: 0x001BE724
		internal virtual Button Button6
		{
			[CompilerGenerated]
			get
			{
				return this._Button6;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button6_Click);
				Button button = this._Button6;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button6 = value;
				button = this._Button6;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700135A RID: 4954
		// (get) Token: 0x06003401 RID: 13313 RVA: 0x001C0567 File Offset: 0x001BE767
		// (set) Token: 0x06003402 RID: 13314 RVA: 0x001C0571 File Offset: 0x001BE771
		internal virtual CheckBox chkNoBal
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700135B RID: 4955
		// (get) Token: 0x06003403 RID: 13315 RVA: 0x001C057A File Offset: 0x001BE77A
		// (set) Token: 0x06003404 RID: 13316 RVA: 0x001C0584 File Offset: 0x001BE784
		internal virtual CheckBox chkShowAuditInfo
		{
			[CompilerGenerated]
			get
			{
				return this._chkShowAuditInfo;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.chkShowAuditInfo_CheckedChanged);
				CheckBox checkBox = this._chkShowAuditInfo;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= eventHandler;
				}
				this._chkShowAuditInfo = value;
				checkBox = this._chkShowAuditInfo;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x06003405 RID: 13317 RVA: 0x001C05C8 File Offset: 0x001BE7C8
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.txtSearchProductID.Text, "", false) != 0;
				if (flag)
				{
					Cursor.Current = Cursors.WaitCursor;
					this.LoadMove();
					Cursor.Current = Cursors.Default;
				}
				else
				{
					MessageBox.Show("Enter the Product first.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error display infor. Detail: " + ex.Message, "Error");
			}
		}

		// Token: 0x06003406 RID: 13318 RVA: 0x001C0660 File Offset: 0x001BE860
		private void LoadBranches()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchBranches";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			this.cboBranch.DataSource = dataTable;
			this.cboBranch.ValueMember = "branch";
			this.cboBranch.DisplayMember = "branch";
			this.cboBranch.SelectedIndex = this.cboBranch.FindStringExact(MyProject.Forms.Form1.branch);
		}

		// Token: 0x06003407 RID: 13319 RVA: 0x001C0724 File Offset: 0x001BE924
		private void LoadMove()
		{
			this.dgvMovement.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "ProductMovement";
			sqlCommand.Parameters.AddWithValue("startdate", Conversion.Val(this.DTstart.Value.ToString("yyyyMMdd")));
			sqlCommand.Parameters.AddWithValue("enddate", Conversion.Val(this.DTend.Value.ToString("yyyyMMdd")));
			sqlCommand.Parameters.AddWithValue("productid", Conversion.Val(this.txtSearchProductID.Text));
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			bool flag = MyProject.Forms.Form1.IsWarehouse == 1;
			if (flag)
			{
				sqlCommand.Parameters.AddWithValue("isbatch", 1);
			}
			else
			{
				sqlCommand.Parameters.AddWithValue("isbatch", 0);
			}
			bool @checked = this.chkAllBranches.Checked;
			if (!@checked)
			{
				sqlCommand.Parameters.AddWithValue("branch", this.cboBranch.Text);
			}
			bool checked2 = this.chkNoBal.Checked;
			if (checked2)
			{
				sqlCommand.Parameters.AddWithValue("nobal", 1);
			}
			else
			{
				sqlCommand.Parameters.AddWithValue("nobal", 0);
			}
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag2 = num > 0;
			if (flag2)
			{
				this.dgvMovement.DataSource = dataTable;
				this.dgvMovement.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				bool checked3 = this.chkShowAuditInfo.Checked;
				if (checked3)
				{
					this.dgvMovement.Columns["Tran_Time"].Visible = true;
					this.dgvMovement.Columns["Computer_Used"].Visible = true;
					this.dgvMovement.Columns["Done_By"].Visible = true;
					this.dgvMovement.Columns["Computer_Used"].ReadOnly = true;
					this.dgvMovement.Columns["Done_By"].ReadOnly = true;
					this.dgvMovement.Columns["Tran_Time"].ReadOnly = true;
					this.dgvMovement.Columns["Computer_Used"].DefaultCellStyle.BackColor = Color.LightYellow;
					this.dgvMovement.Columns["Done_By"].DefaultCellStyle.BackColor = Color.LightYellow;
					this.dgvMovement.Columns["Tran_Time"].DefaultCellStyle.BackColor = Color.LightYellow;
				}
				else
				{
					this.dgvMovement.Columns["Computer_Used"].Visible = false;
					this.dgvMovement.Columns["Done_By"].Visible = false;
					this.dgvMovement.Columns["Tran_Time"].Visible = false;
				}
				bool flag3 = Operators.CompareString(MyProject.Forms.Form1.BusType, "Tuckshop", false) == 0;
				if (flag3)
				{
					this.dgvMovement.Columns["Product_Code"].Visible = false;
				}
				else
				{
					bool flag4 = Operators.CompareString(MyProject.Forms.Form1.BusType, "Parts", false) == 0;
					if (flag4)
					{
						this.dgvMovement.Columns["Product_ID"].Visible = false;
					}
				}
				bool flag5 = MyProject.Forms.Form1.IsWarehouse == 0;
				if (flag5)
				{
					this.dgvMovement.Columns["BatchNumber"].Visible = false;
					this.dgvMovement.Columns["ExpiryDate"].Visible = false;
				}
				else
				{
					DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
					dataGridViewButtonColumn.HeaderText = "Change Batch Number";
					dataGridViewButtonColumn.Text = "Change";
					dataGridViewButtonColumn.Name = "Change";
					dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
					this.dgvMovement.Columns.Add(dataGridViewButtonColumn);
				}
				DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
				dataGridViewCheckBoxColumn.HeaderText = "Select?";
				dataGridViewCheckBoxColumn.Name = "select";
				bool flag6 = MyProject.Forms.Form1.IsWarehouse == 0;
				if (flag6)
				{
					dataGridViewCheckBoxColumn.Visible = false;
				}
				this.dgvMovement.Columns.Add(dataGridViewCheckBoxColumn);
				this.dgvMovement.Columns["Entry_No"].DefaultCellStyle.BackColor = Color.LightGray;
				this.dgvMovement.Columns["Transaction_Date"].DefaultCellStyle.BackColor = Color.LightGray;
				this.dgvMovement.Columns["Invoice_Number"].DefaultCellStyle.BackColor = Color.LightGray;
				this.dgvMovement.Columns["Product_ID"].DefaultCellStyle.BackColor = Color.LightGray;
				this.dgvMovement.Columns["Product_Code"].DefaultCellStyle.BackColor = Color.LightGray;
				this.dgvMovement.Columns["BatchNumber"].DefaultCellStyle.BackColor = Color.LightGray;
				this.dgvMovement.Columns["ExpiryDate"].DefaultCellStyle.BackColor = Color.LightGray;
				this.dgvMovement.Columns["Description"].DefaultCellStyle.BackColor = Color.LightGray;
				this.dgvMovement.Columns["Transaction_Code"].DefaultCellStyle.BackColor = Color.LightGray;
				this.dgvMovement.Columns["Transaction_Description"].DefaultCellStyle.BackColor = Color.LightGray;
				this.dgvMovement.Columns["Reference"].DefaultCellStyle.BackColor = Color.LightGray;
				this.dgvMovement.Columns["OtherDetail"].DefaultCellStyle.BackColor = Color.LightGray;
				this.dgvMovement.Columns["Shop"].DefaultCellStyle.BackColor = Color.LightGray;
				this.dgvMovement.Columns["Quantity"].DefaultCellStyle.BackColor = Color.LightGray;
				this.dgvMovement.Columns["Cost"].DefaultCellStyle.BackColor = Color.LightGray;
				this.dgvMovement.Columns["Unit_Selling_Price"].DefaultCellStyle.BackColor = Color.LightGray;
				this.dgvMovement.Columns["Stock_Balance"].DefaultCellStyle.BackColor = Color.LightGray;
				this.dgvMovement.Columns["Entry_No"].ReadOnly = true;
				this.dgvMovement.Columns["Transaction_Date"].ReadOnly = true;
				this.dgvMovement.Columns["Invoice_Number"].ReadOnly = true;
				this.dgvMovement.Columns["Product_ID"].ReadOnly = true;
				this.dgvMovement.Columns["Product_Code"].ReadOnly = true;
				this.dgvMovement.Columns["BatchNumber"].ReadOnly = true;
				this.dgvMovement.Columns["ExpiryDate"].ReadOnly = true;
				this.dgvMovement.Columns["Description"].ReadOnly = true;
				this.dgvMovement.Columns["Transaction_Code"].ReadOnly = true;
				this.dgvMovement.Columns["Transaction_Description"].ReadOnly = true;
				this.dgvMovement.Columns["Reference"].ReadOnly = true;
				this.dgvMovement.Columns["OtherDetail"].ReadOnly = true;
				this.dgvMovement.Columns["Shop"].ReadOnly = true;
				this.dgvMovement.Columns["Quantity"].ReadOnly = true;
				this.dgvMovement.Columns["Cost"].ReadOnly = true;
				this.dgvMovement.Columns["Unit_Selling_Price"].ReadOnly = true;
				this.dgvMovement.Columns["Stock_Balance"].ReadOnly = true;
				bool checked4 = this.chkNoBal.Checked;
				if (checked4)
				{
					DataGridViewButtonColumn dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
					dataGridViewButtonColumn2.HeaderText = "View Stock Bal";
					dataGridViewButtonColumn2.Text = "View Stock Bal";
					dataGridViewButtonColumn2.Name = "View";
					dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
					this.dgvMovement.Columns.Add(dataGridViewButtonColumn2);
				}
			}
			else
			{
				MessageBox.Show("There is no movement data for the selected product for the selected time period.");
			}
			try
			{
				foreach (object obj in ((IEnumerable)this.dgvMovement.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					switch (Conversions.ToInteger(dataGridViewRow.Cells["Transaction_Code"].Value))
					{
					case 1:
						dataGridViewRow.Cells["Transaction_Description"].Value = "New Stock In";
						break;
					case 2:
						dataGridViewRow.Cells["Transaction_Description"].Value = "Stock Take Adjustment";
						break;
					case 3:
						dataGridViewRow.Cells["Transaction_Description"].Value = "Sale";
						break;
					case 4:
						dataGridViewRow.Cells["Transaction_Description"].Value = "Cancelled Sale";
						break;
					case 5:
						dataGridViewRow.Cells["Transaction_Description"].Value = "Stock Transfer In";
						break;
					case 6:
						dataGridViewRow.Cells["Transaction_Description"].Value = "Stock Transfer Out";
						break;
					case 7:
						dataGridViewRow.Cells["Transaction_Description"].Value = "Stock Return";
						break;
					case 8:
						dataGridViewRow.Cells["Transaction_Description"].Value = "Stock Refund";
						break;
					case 9:
						dataGridViewRow.Cells["Transaction_Description"].Value = "Product Converted";
						break;
					case 10:
						dataGridViewRow.Cells["Transaction_Description"].Value = "Stock Desptach Out";
						break;
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

		// Token: 0x06003408 RID: 13320 RVA: 0x001C12E0 File Offset: 0x001BF4E0
		private void FetchProdtDetails(int prodtid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchProductByID";
			sqlCommand.Parameters.AddWithValue("prodtID", prodtid);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				this.lblDesc.Text = Conversions.ToString(dataRow["ProductDesc"]);
			}
			else
			{
				this.lblDesc.Text = "Nothing found matching that product ID";
			}
		}

		// Token: 0x06003409 RID: 13321 RVA: 0x001C13B4 File Offset: 0x001BF5B4
		private void FetchProdtDetailsBYCode(string prodtcode)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchProductByCode";
			sqlCommand.Parameters.AddWithValue("productcode", prodtcode);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				this.lblDesc.Text = Conversions.ToString(dataRow["ProductDesc"]);
				this.txtSearchProductID.Text = Conversions.ToString(dataRow["ProductID"]);
			}
			else
			{
				this.lblDesc.Text = "Nothing found matching that product ID";
			}
		}

		// Token: 0x0600340A RID: 13322 RVA: 0x00012800 File Offset: 0x00010A00
		private void txtSearchProductID_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x0600340B RID: 13323 RVA: 0x001C14A0 File Offset: 0x001BF6A0
		private void txtSearchProductID_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.FetchProdtDetails(checked((int)Math.Round(Conversion.Val(this.txtSearchProductID.Text))));
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching by ID. Detail: " + ex.Message, "Error");
			}
		}

		// Token: 0x0600340C RID: 13324 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label5_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x0600340D RID: 13325 RVA: 0x001C150C File Offset: 0x001BF70C
		private void txtSearchProductCode_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.FetchProdtDetailsBYCode(this.txtSearchProductCode.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error occurred searching by code. Detail: " + ex.Message, "Error");
			}
		}

		// Token: 0x0600340E RID: 13326 RVA: 0x001C156C File Offset: 0x001BF76C
		private void ProductMovement_Load(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(MyProject.Forms.Form1.BusType, "Tuckshop", false) == 0;
				if (flag)
				{
					this.txtSearchProductCode.Visible = false;
					this.Label7.Visible = false;
				}
				else
				{
					bool flag2 = Operators.CompareString(MyProject.Forms.Form1.BusType, "Parts", false) == 0;
					if (flag2)
					{
						this.txtSearchProductID.Visible = false;
						this.Label4.Visible = false;
					}
				}
				this.LoadBranches();
				bool flag3 = MyProject.Forms.Form1.IsWarehouse == 1;
				if (flag3)
				{
					this.Button4.Visible = true;
					this.Button5.Visible = true;
				}
				else
				{
					this.Button4.Visible = false;
					this.Button5.Visible = false;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message, "Error");
			}
		}

		// Token: 0x0600340F RID: 13327 RVA: 0x001C1688 File Offset: 0x001BF888
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

		// Token: 0x06003410 RID: 13328 RVA: 0x001C16E8 File Offset: 0x001BF8E8
		private void FetchAllProducts()
		{
			this.lblerror.Text = "...";
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectAllProducts3";
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
				this.DGVSearch.Columns["Unit_of_Measure"].Visible = false;
				this.DGVSearch.Columns["Bin_Location"].Visible = false;
				this.DGVSearch.Columns["Product_Desc2"].Visible = false;
				this.DGVSearch.Columns["Wholesale_Selling_Price"].Visible = false;
				this.DGVSearch.Columns["Wholesale_Qty"].Visible = false;
				this.DGVSearch.Columns["Tax_Percentage"].Visible = false;
				this.DGVSearch.Columns["Is_Active"].Visible = false;
				this.DGVSearch.Columns["Special_Price"].Visible = false;
				this.DGVSearch.Columns["PRODUCTEXPIRES"].Visible = false;
				this.DGVSearch.Columns["DifferentPricesPerBranch"].Visible = false;
				this.DGVSearch.Columns["Is_Ingridient"].Visible = false;
				this.DGVSearch.Columns["Unlimited_Stock_Item"].Visible = false;
			}
			else
			{
				this.lblerror.Text = "No products match your search.";
			}
		}

		// Token: 0x06003411 RID: 13329 RVA: 0x001C19A0 File Offset: 0x001BFBA0
		private void SearchByDesc(string searchtext)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SearchProduct3";
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
				this.DGVSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			}
			else
			{
				this.lblerror.Text = "No products match your search.";
			}
		}

		// Token: 0x06003412 RID: 13330 RVA: 0x001C1A7C File Offset: 0x001BFC7C
		private void DGVSearch_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				bool flag = e.KeyCode == Keys.Return;
				if (flag)
				{
					e.Handled = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Key down error. Ignore");
			}
		}

		// Token: 0x06003413 RID: 13331 RVA: 0x001C1AD0 File Offset: 0x001BFCD0
		private void DGVSearch_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					string text = Conversions.ToString(this.DGVSearch.Rows[e.RowIndex].Cells["ProductCode"].Value);
					this.txtSearchProductCode.Text = text;
				}
			}
			catch (Exception ex)
			{
				this.lblerror.Text = "Error: " + ex.Message;
			}
		}

		// Token: 0x06003414 RID: 13332 RVA: 0x001C1B90 File Offset: 0x001BFD90
		private void txtsearch_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.lblerror.Text = "...";
				this.SearchByDescAdvanced(this.txtsearch.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Detail: " + ex.Message);
			}
		}

		// Token: 0x06003415 RID: 13333 RVA: 0x001C1BFC File Offset: 0x001BFDFC
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

		// Token: 0x06003416 RID: 13334 RVA: 0x001C1D08 File Offset: 0x001BFF08
		private object searchDat(DataTable dt, string column, string value)
		{
			ProductMovement._Closure$__155-0 CS$<>8__locals1 = new ProductMovement._Closure$__155-0(CS$<>8__locals1);
			CS$<>8__locals1.$VB$Local_column = column;
			CS$<>8__locals1.$VB$Local_value = value;
			DataTable dataTable = dt.Clone();
			dt.CaseSensitive = false;
			try
			{
				foreach (DataRow dataRow in dt.Rows.Cast<object>().Select<object, DataRow>((ProductMovement._Closure$__.$I155-0 == null) ? (ProductMovement._Closure$__.$I155-0 = (object row1) => (DataRow)row1) : ProductMovement._Closure$__.$I155-0).Where<DataRow>((CS$<>8__locals1.$I1 == null) ? (CS$<>8__locals1.$I1 = (DataRow row1) => Conversions.ToBoolean(NewLateBinding.LateGet(row1[CS$<>8__locals1.$VB$Local_column], null, "Contains", new object[] { CS$<>8__locals1.$VB$Local_value.ToUpper() }, null, null, null))) : CS$<>8__locals1.$I1))
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

		// Token: 0x06003417 RID: 13335 RVA: 0x001C1DE4 File Offset: 0x001BFFE4
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

		// Token: 0x06003418 RID: 13336 RVA: 0x001C1E6C File Offset: 0x001C006C
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
				this.lblDesc.Text = Conversions.ToString(Operators.AddObject(Operators.AddObject(dataRow["ProductDesc"], " "), dataRow["ProductDesc2"]));
				this.txtSearchProductID.Text = Conversions.ToString(dataRow["ProductID"]);
			}
			else
			{
				this.txtSearchProductCode.Text = "";
			}
		}

		// Token: 0x06003419 RID: 13337 RVA: 0x001C1F78 File Offset: 0x001C0178
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.dgvMovement.RowCount > 0;
				if (flag)
				{
					this.SaveFileDialog1.Filter = "EXCEL Files (*.csv*)|*.csv";
					bool flag2 = this.SaveFileDialog1.ShowDialog() == DialogResult.OK;
					if (flag2)
					{
						this.pf.DATAGRIDVIEW_TO_CSV(this.dgvMovement, this.SaveFileDialog1.FileName);
						MessageBox.Show("File saved.");
					}
				}
				else
				{
					MessageBox.Show("There are no rows to export.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error exporting to excel. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600341A RID: 13338 RVA: 0x001C2030 File Offset: 0x001C0230
		private void dgvMovement_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					bool flag2 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "Change", false) == 0;
					if (flag2)
					{
						EditBatchNumber editBatchNumber = new EditBatchNumber();
						editBatchNumber.entryno = Conversions.ToInteger(this.dgvMovement.Rows[e.RowIndex].Cells["entry_no"].Value);
						editBatchNumber.coid = MyProject.Forms.Form1.coid;
						editBatchNumber.branch = MyProject.Forms.Form1.branch;
						editBatchNumber.ShowDialog(this);
						editBatchNumber.Dispose();
						this.ReloadProductStockBalance(checked((int)Math.Round(Conversion.Val(this.txtSearchProductID.Text))));
						this.LoadMove();
					}
					bool flag3 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "View", false) == 0;
					if (flag3)
					{
						decimal stockBalEntryNo = this.pf.GetStockBalEntryNo(MyProject.Forms.Form1.coid, this.cboBranch.Text, Conversions.ToInteger(this.dgvMovement.Rows[e.RowIndex].Cells["Product_ID"].Value), Conversions.ToInteger(this.dgvMovement.Rows[e.RowIndex].Cells["entry_no"].Value), this._cnn);
						this.dgvMovement.Rows[e.RowIndex].Cells["stock_balance"].Value = stockBalEntryNo;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600341B RID: 13339 RVA: 0x001C226C File Offset: 0x001C046C
		private void Button4_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					bool flag = this.dgvMovement.RowCount == 0;
					if (flag)
					{
						MessageBox.Show("No rows present. Click View Product Mvt.");
					}
					else
					{
						GetNewBatchNumber getNewBatchNumber = new GetNewBatchNumber();
						getNewBatchNumber.ShowDialog(this);
						getNewBatchNumber.Dispose();
						Cursor.Current = Cursors.WaitCursor;
						DialogResult dialogResult = (DialogResult)Interaction.MsgBox("Are you sure you want to change the Batch Numbers and Expiry Dates for the selected transactions?", MsgBoxStyle.YesNo, null);
						bool flag2 = dialogResult == DialogResult.Yes;
						if (flag2)
						{
							int num = 0;
							try
							{
								foreach (object obj in ((IEnumerable)this.dgvMovement.Rows))
								{
									DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
									bool flag3 = Conversions.ToBoolean(dataGridViewRow.Cells["select"].Value);
									bool flag4 = flag3;
									if (flag4)
									{
										this.ChangeBatchNum(MyProject.Forms.Form1.selectedbactchnum, MyProject.Forms.Form1.selectedexpirydate, MyProject.Forms.Form1.coid, dataGridViewRow.Cells["Shop"].Value.ToString(), Conversions.ToInteger(dataGridViewRow.Cells["Entry_No"].Value));
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
							this.ReloadProductStockBalance((int)Math.Round(Conversion.Val(this.txtSearchProductID.Text)));
							this.LoadMove();
							bool flag5 = num > 0;
							if (flag5)
							{
								MessageBox.Show("Changes successfully done." + num.ToString() + " transactions.");
							}
							else
							{
								MessageBox.Show("There are no changes made.");
							}
						}
						else
						{
							MessageBox.Show("Process cancelled. No changes made.");
						}
						Cursor.Current = Cursors.Default;
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error changing details. " + ex.Message);
				}
			}
		}

		// Token: 0x0600341C RID: 13340 RVA: 0x001C2494 File Offset: 0x001C0694
		private void ChangeBatchNum(string newbatchnum, int newexpdate, int coid, string branch, int entryno)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = string.Concat(new string[]
			{
				"update movement set batchnumber='",
				newbatchnum,
				"', expirydate=",
				Conversions.ToString(newexpdate),
				" where coid=",
				Conversions.ToString(coid),
				" And branch='",
				branch,
				"' and entryno=",
				Conversions.ToString(entryno)
			});
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x0600341D RID: 13341 RVA: 0x001C2554 File Offset: 0x001C0754
		private void ReloadProductStockBalance(int productid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SetQuickStockBalForOne";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			sqlCommand.Parameters.AddWithValue("iswarehouse", MyProject.Forms.Form1.IsWarehouse);
			sqlCommand.Parameters.AddWithValue("productid", productid);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x0600341E RID: 13342 RVA: 0x001C2640 File Offset: 0x001C0840
		private void Button5_Click(object sender, EventArgs e)
		{
			try
			{
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvMovement.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						dataGridViewRow.Cells["select"].Value = true;
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
				MessageBox.Show("All rows selected.");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error selecting transactions. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600341F RID: 13343 RVA: 0x001C26FC File Offset: 0x001C08FC
		private void Button6_Click(object sender, EventArgs e)
		{
			try
			{
				Cursor.Current = Cursors.WaitCursor;
				this.ReloadProductStockBalance(checked((int)Math.Round(Conversion.Val(this.txtSearchProductID.Text))));
				Cursor.Current = Cursors.Default;
				MessageBox.Show("Redo done.");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error. Details: " + ex.Message);
			}
		}

		// Token: 0x06003420 RID: 13344 RVA: 0x001C2784 File Offset: 0x001C0984
		private void chkShowAuditInfo_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.txtSearchProductID.Text, "", false) != 0;
				if (flag)
				{
					Cursor.Current = Cursors.WaitCursor;
					this.LoadMove();
					Cursor.Current = Cursors.Default;
				}
				else
				{
					MessageBox.Show("Enter the Product first.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error display infor. Detail: " + ex.Message, "Error");
			}
		}

		// Token: 0x0400164B RID: 5707
		private string _cnn;

		// Token: 0x0400164C RID: 5708
		private PublicFunctions pf;
	}
}
