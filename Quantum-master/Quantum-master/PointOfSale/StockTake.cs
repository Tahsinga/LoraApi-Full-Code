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
	// Token: 0x020001F2 RID: 498
	[DesignerGenerated]
	public partial class StockTake : Form
	{
		// Token: 0x060057E9 RID: 22505 RVA: 0x00327F98 File Offset: 0x00326198
		public StockTake()
		{
			base.Load += this.StockTake_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.dat = new DataTable();
			this.firstbalrun = false;
			this.InitializeComponent();
		}

		// Token: 0x17001FA1 RID: 8097
		// (get) Token: 0x060057EC RID: 22508 RVA: 0x00329064 File Offset: 0x00327264
		// (set) Token: 0x060057ED RID: 22509 RVA: 0x0032906E File Offset: 0x0032726E
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FA2 RID: 8098
		// (get) Token: 0x060057EE RID: 22510 RVA: 0x00329077 File Offset: 0x00327277
		// (set) Token: 0x060057EF RID: 22511 RVA: 0x00329084 File Offset: 0x00327284
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
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.datagridview_CellValidating);
				DataGridView dataGridView = this._DataGridView1;
				if (dataGridView != null)
				{
					dataGridView.CellValidating -= dataGridViewCellValidatingEventHandler;
				}
				this._DataGridView1 = value;
				dataGridView = this._DataGridView1;
				if (dataGridView != null)
				{
					dataGridView.CellValidating += dataGridViewCellValidatingEventHandler;
				}
			}
		}

		// Token: 0x17001FA3 RID: 8099
		// (get) Token: 0x060057F0 RID: 22512 RVA: 0x003290C7 File Offset: 0x003272C7
		// (set) Token: 0x060057F1 RID: 22513 RVA: 0x003290D1 File Offset: 0x003272D1
		internal virtual DateTimePicker DTdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FA4 RID: 8100
		// (get) Token: 0x060057F2 RID: 22514 RVA: 0x003290DA File Offset: 0x003272DA
		// (set) Token: 0x060057F3 RID: 22515 RVA: 0x003290E4 File Offset: 0x003272E4
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FA5 RID: 8101
		// (get) Token: 0x060057F4 RID: 22516 RVA: 0x003290ED File Offset: 0x003272ED
		// (set) Token: 0x060057F5 RID: 22517 RVA: 0x003290F7 File Offset: 0x003272F7
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FA6 RID: 8102
		// (get) Token: 0x060057F6 RID: 22518 RVA: 0x00329100 File Offset: 0x00327300
		// (set) Token: 0x060057F7 RID: 22519 RVA: 0x0032910C File Offset: 0x0032730C
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

		// Token: 0x17001FA7 RID: 8103
		// (get) Token: 0x060057F8 RID: 22520 RVA: 0x0032914F File Offset: 0x0032734F
		// (set) Token: 0x060057F9 RID: 22521 RVA: 0x00329159 File Offset: 0x00327359
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FA8 RID: 8104
		// (get) Token: 0x060057FA RID: 22522 RVA: 0x00329162 File Offset: 0x00327362
		// (set) Token: 0x060057FB RID: 22523 RVA: 0x0032916C File Offset: 0x0032736C
		internal virtual ProgressBar ProgressBar1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FA9 RID: 8105
		// (get) Token: 0x060057FC RID: 22524 RVA: 0x00329175 File Offset: 0x00327375
		// (set) Token: 0x060057FD RID: 22525 RVA: 0x0032917F File Offset: 0x0032737F
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FAA RID: 8106
		// (get) Token: 0x060057FE RID: 22526 RVA: 0x00329188 File Offset: 0x00327388
		// (set) Token: 0x060057FF RID: 22527 RVA: 0x00329192 File Offset: 0x00327392
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FAB RID: 8107
		// (get) Token: 0x06005800 RID: 22528 RVA: 0x0032919B File Offset: 0x0032739B
		// (set) Token: 0x06005801 RID: 22529 RVA: 0x003291A8 File Offset: 0x003273A8
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

		// Token: 0x17001FAC RID: 8108
		// (get) Token: 0x06005802 RID: 22530 RVA: 0x00329206 File Offset: 0x00327406
		// (set) Token: 0x06005803 RID: 22531 RVA: 0x00329210 File Offset: 0x00327410
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FAD RID: 8109
		// (get) Token: 0x06005804 RID: 22532 RVA: 0x00329219 File Offset: 0x00327419
		// (set) Token: 0x06005805 RID: 22533 RVA: 0x00329224 File Offset: 0x00327424
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

		// Token: 0x17001FAE RID: 8110
		// (get) Token: 0x06005806 RID: 22534 RVA: 0x00329267 File Offset: 0x00327467
		// (set) Token: 0x06005807 RID: 22535 RVA: 0x00329271 File Offset: 0x00327471
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FAF RID: 8111
		// (get) Token: 0x06005808 RID: 22536 RVA: 0x0032927A File Offset: 0x0032747A
		// (set) Token: 0x06005809 RID: 22537 RVA: 0x00329284 File Offset: 0x00327484
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

		// Token: 0x17001FB0 RID: 8112
		// (get) Token: 0x0600580A RID: 22538 RVA: 0x003292C7 File Offset: 0x003274C7
		// (set) Token: 0x0600580B RID: 22539 RVA: 0x003292D1 File Offset: 0x003274D1
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FB1 RID: 8113
		// (get) Token: 0x0600580C RID: 22540 RVA: 0x003292DA File Offset: 0x003274DA
		// (set) Token: 0x0600580D RID: 22541 RVA: 0x003292E4 File Offset: 0x003274E4
		internal virtual TextBox txtProductCode
		{
			[CompilerGenerated]
			get
			{
				return this._txtProductCode;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.txtProductCode_TextChanged_1);
				TextBox textBox = this._txtProductCode;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
				}
				this._txtProductCode = value;
				textBox = this._txtProductCode;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17001FB2 RID: 8114
		// (get) Token: 0x0600580E RID: 22542 RVA: 0x00329327 File Offset: 0x00327527
		// (set) Token: 0x0600580F RID: 22543 RVA: 0x00329331 File Offset: 0x00327531
		internal virtual Label lblinfor
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FB3 RID: 8115
		// (get) Token: 0x06005810 RID: 22544 RVA: 0x0032933A File Offset: 0x0032753A
		// (set) Token: 0x06005811 RID: 22545 RVA: 0x00329344 File Offset: 0x00327544
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FB4 RID: 8116
		// (get) Token: 0x06005812 RID: 22546 RVA: 0x0032934D File Offset: 0x0032754D
		// (set) Token: 0x06005813 RID: 22547 RVA: 0x00329357 File Offset: 0x00327557
		internal virtual CheckBox chkRecordAll
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001FB5 RID: 8117
		// (get) Token: 0x06005814 RID: 22548 RVA: 0x00329360 File Offset: 0x00327560
		// (set) Token: 0x06005815 RID: 22549 RVA: 0x0032936C File Offset: 0x0032756C
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

		// Token: 0x17001FB6 RID: 8118
		// (get) Token: 0x06005816 RID: 22550 RVA: 0x003293AF File Offset: 0x003275AF
		// (set) Token: 0x06005817 RID: 22551 RVA: 0x003293BC File Offset: 0x003275BC
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

		// Token: 0x06005818 RID: 22552 RVA: 0x00329400 File Offset: 0x00327600
		private void StockTake_Load(object sender, EventArgs e)
		{
			try
			{
				this.firstbalrun = this.pf.CheckIfFirstBalRun(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, this._cnn);
				bool flag = this.firstbalrun;
				if (flag)
				{
					this.LoadStock2(1);
				}
				else
				{
					this.chkRecordAll.Checked = true;
					this.LoadStock2(0);
				}
				this.Label1.Text = "Conduct Stock Take for Branch " + MyProject.Forms.Form1.branch;
				bool flag2 = MyProject.Forms.Form1.DateChange == 0;
				if (flag2)
				{
					this.DTdate.Enabled = false;
				}
				else
				{
					this.DTdate.Enabled = true;
				}
				bool flag3 = MyProject.Forms.Form1.isRestaurant == 0;
				if (flag3)
				{
					this.lblinfor.Text = "All stock items shown";
				}
				else
				{
					this.lblinfor.Text = "Stock Items marked as 'unlimited stock items' are not included.";
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005819 RID: 22553 RVA: 0x00329540 File Offset: 0x00327740
		private void LoadStock2(int useprodbal)
		{
			this.DataGridView1.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchAllProductBals3";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			sqlCommand.Parameters.AddWithValue("isrestaurant", MyProject.Forms.Form1.isRestaurant);
			sqlCommand.Parameters.AddWithValue("username", MyProject.Forms.Form1.username);
			sqlCommand.Parameters.AddWithValue("useprodbal", useprodbal);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(this.dat);
			bool flag = num > 0;
			if (flag)
			{
				this.DataGridView1.DataSource = this.dat;
				this.DataGridView1.Columns["IsVoucher"].Visible = false;
				this.DataGridView1.Columns["ProductID"].Visible = false;
				this.DataGridView1.Columns["cost"].Visible = false;
				this.DataGridView1.Columns["ProductCode"].ReadOnly = true;
				this.DataGridView1.Columns["ProductDesc"].ReadOnly = true;
				this.DataGridView1.Columns["StockBalance"].ReadOnly = true;
				this.DataGridView1.Columns.Add("PhysicalCount", "Physical Stock Count");
				this.DataGridView1.Columns.Add("Detail", "Reason for Variance");
				this.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				this.DataGridView1.Columns["ProductCode"].HeaderText = "Product Code";
				this.DataGridView1.Columns["ProductCode"].DefaultCellStyle.BackColor = Color.LightGray;
				this.DataGridView1.Columns["ProductDesc"].HeaderText = "Description";
				this.DataGridView1.Columns["ProductDesc"].DefaultCellStyle.BackColor = Color.LightGray;
				this.DataGridView1.Columns["StockBalance"].HeaderText = "Stock Balance";
				this.DataGridView1.Columns["StockBalance"].DefaultCellStyle.BackColor = Color.LightGray;
				this.DataGridView1.Columns["StockBalance"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
				try
				{
					foreach (object obj in this.DataGridView1.Columns)
					{
						DataGridViewColumn dataGridViewColumn = (DataGridViewColumn)obj;
						dataGridViewColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
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
				this.CopyBals();
			}
			else
			{
				MessageBox.Show("There are no products.");
			}
		}

		// Token: 0x0600581A RID: 22554 RVA: 0x003298B0 File Offset: 0x00327AB0
		private void CopyBals()
		{
			try
			{
				foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					dataGridViewRow.Cells["PhysicalCount"].Value = RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["StockBalance"].Value);
					bool flag = Operators.ConditionalCompareObjectEqual(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["IsVoucher"].Value)), false, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["IsVoucher"].Value)), true, false);
					if (flag)
					{
						dataGridViewRow.ReadOnly = true;
						dataGridViewRow.DefaultCellStyle.BackColor = Color.LightBlue;
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

		// Token: 0x0600581B RID: 22555 RVA: 0x003299B4 File Offset: 0x00327BB4
		private void AdjustStock()
		{
			this.ProgressBar1.Visible = true;
			this.ProgressBar1.BringToFront();
			this.ProgressBar1.Minimum = 1;
			this.ProgressBar1.Maximum = 3;
			this.ProgressBar1.Step = 1;
			this.ProgressBar1.PerformStep();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlConnection.Open();
			SqlTransaction sqlTransaction = sqlConnection.BeginTransaction("RunStockTake");
			sqlCommand.Connection = sqlConnection;
			sqlCommand.Transaction = sqlTransaction;
			sqlCommand.CommandTimeout = 0;
			try
			{
				int nextInvNumStockTake = this.pf.GetNextInvNumStockTake(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, this._cnn);
				this.ProgressBar1.PerformStep();
				int num = checked((int)Math.Round(Conversion.Val(DateAndTime.TimeOfDay.ToString("HHmm"))));
				try
				{
					foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						bool flag = Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["StockBalance"].Value));
						if (flag)
						{
							MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject("stock bal is null. productcode ", dataGridViewRow.Cells["ProductDesc"].Value)));
						}
						decimal num2 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["StockBalance"].Value));
						decimal num3 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["PhysicalCount"].Value)), 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["PhysicalCount"].Value))));
						bool flag2 = decimal.Compare(num2, num3) > 0;
						if (flag2)
						{
							sqlCommand.Parameters.Clear();
							sqlCommand.CommandType = CommandType.StoredProcedure;
							sqlCommand.CommandText = "InsertNewSaleStockTake";
							sqlCommand.Parameters.AddWithValue("trandate", this.DTdate.Value.ToString("yyyyMMdd"));
							sqlCommand.Parameters.AddWithValue("invoicenum", nextInvNumStockTake);
							sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ProductID"].Value));
							sqlCommand.Parameters.AddWithValue("isstockin", 0);
							sqlCommand.Parameters.AddWithValue("ref", "STOCK REDUCED");
							sqlCommand.Parameters.AddWithValue("quantity", decimal.Subtract(num2, num3));
							sqlCommand.Parameters.AddWithValue("unitcost", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Cost"].Value));
							sqlCommand.Parameters.AddWithValue("salesprice", 0);
							sqlCommand.Parameters.AddWithValue("paymentmethod", 0);
							sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
							sqlCommand.Parameters.AddWithValue("donewhen", DateTime.Today.ToString("yyyyMMdd"));
							sqlCommand.Parameters.AddWithValue("trancode", 2);
							sqlCommand.Parameters.AddWithValue("TranTime", num);
							sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
							sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
							bool flag3 = dataGridViewRow.Cells["Detail"].Value == null;
							string text;
							if (flag3)
							{
								text = "";
							}
							else
							{
								text = dataGridViewRow.Cells["Detail"].Value.ToString();
							}
							sqlCommand.Parameters.AddWithValue("details", text);
							sqlCommand.Parameters.AddWithValue("stockbal", num2);
							sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
							sqlCommand.ExecuteNonQuery();
						}
						else
						{
							bool flag4 = decimal.Compare(num2, num3) < 0;
							if (flag4)
							{
								sqlCommand.Parameters.Clear();
								sqlCommand.CommandType = CommandType.StoredProcedure;
								sqlCommand.CommandText = "InsertNewStockStockTake";
								sqlCommand.Parameters.AddWithValue("trandate", this.DTdate.Value.ToString("yyyyMMdd"));
								sqlCommand.Parameters.AddWithValue("invoicenum", nextInvNumStockTake);
								sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ProductID"].Value));
								sqlCommand.Parameters.AddWithValue("isstockin", 1);
								sqlCommand.Parameters.AddWithValue("ref", "STOCK INCREASED");
								sqlCommand.Parameters.AddWithValue("quantity", decimal.Subtract(num3, num2));
								sqlCommand.Parameters.AddWithValue("cost", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Cost"].Value));
								sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
								sqlCommand.Parameters.AddWithValue("donewhen", DateTime.Today.ToString("yyyyMMdd"));
								sqlCommand.Parameters.AddWithValue("trancode", 2);
								sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
								sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
								bool flag5 = dataGridViewRow.Cells["Detail"].Value == null;
								string text2;
								if (flag5)
								{
									text2 = "";
								}
								else
								{
									text2 = dataGridViewRow.Cells["Detail"].Value.ToString();
								}
								sqlCommand.Parameters.AddWithValue("details", text2);
								sqlCommand.Parameters.AddWithValue("stockbal", num2);
								sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
								sqlCommand.Parameters.AddWithValue("trantime", DateTime.Now.ToString("HH:mm"));
								sqlCommand.ExecuteNonQuery();
							}
							else
							{
								num2 = num3;
								bool flag6 = this.chkRecordAll.Checked | !this.firstbalrun;
								if (flag6)
								{
									sqlCommand.Parameters.Clear();
									sqlCommand.CommandType = CommandType.StoredProcedure;
									sqlCommand.CommandText = "InsertNewStockStockTake";
									sqlCommand.Parameters.AddWithValue("trandate", this.DTdate.Value.ToString("yyyyMMdd"));
									sqlCommand.Parameters.AddWithValue("invoicenum", nextInvNumStockTake);
									sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ProductID"].Value));
									sqlCommand.Parameters.AddWithValue("isstockin", 1);
									sqlCommand.Parameters.AddWithValue("ref", "STOCK MAINTAINED");
									sqlCommand.Parameters.AddWithValue("quantity", 0);
									sqlCommand.Parameters.AddWithValue("cost", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Cost"].Value));
									sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
									sqlCommand.Parameters.AddWithValue("donewhen", DateTime.Today.ToString("yyyyMMdd"));
									sqlCommand.Parameters.AddWithValue("trancode", 2);
									sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
									sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
									bool flag7 = dataGridViewRow.Cells["Detail"].Value == null;
									string text3;
									if (flag7)
									{
										text3 = "";
									}
									else
									{
										text3 = dataGridViewRow.Cells["Detail"].Value.ToString();
									}
									sqlCommand.Parameters.AddWithValue("details", text3);
									sqlCommand.Parameters.AddWithValue("stockbal", num2);
									sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
									sqlCommand.Parameters.AddWithValue("trantime", DateTime.Now.ToString("HH:mm"));
									sqlCommand.ExecuteNonQuery();
								}
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
				bool flag8 = this.chkRecordAll.Checked & !this.firstbalrun;
				if (flag8)
				{
					sqlCommand.Parameters.Clear();
					sqlCommand.CommandType = CommandType.Text;
					sqlCommand.CommandText = string.Concat(new string[]
					{
						"update branches set FirstStockBalRun=1 where coid=",
						Conversions.ToString(MyProject.Forms.Form1.coid),
						" and branch='",
						MyProject.Forms.Form1.branch,
						"'"
					});
					sqlCommand.ExecuteNonQuery();
				}
				sqlTransaction.Commit();
				sqlCommand.Connection.Close();
				this.ProgressBar1.PerformStep();
				this.ProgressBar1.Visible = false;
				MessageBox.Show("Stock adjusted successfully. To view adjustments made please go to the reports.");
				base.Close();
			}
			catch (Exception ex)
			{
				try
				{
					this.ProgressBar1.Visible = false;
					MessageBox.Show("Error occured adjusting stock. Detail: " + ex.Message);
					sqlTransaction.Rollback();
					sqlCommand.Connection.Close();
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x0600581C RID: 22556 RVA: 0x0032A4B4 File Offset: 0x003286B4
		private void Button1_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = (DialogResult)Interaction.MsgBox("Are you sure you have entered the correct Physical Stock count figures and want to adjust stock?", MsgBoxStyle.YesNo, null);
			bool flag = dialogResult == DialogResult.Yes;
			if (flag)
			{
				this.AdjustStock();
			}
		}

		// Token: 0x0600581D RID: 22557 RVA: 0x0032A4E0 File Offset: 0x003286E0
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

		// Token: 0x0600581E RID: 22558 RVA: 0x0032A540 File Offset: 0x00328740
		private void DGVSearch_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					string text = Conversions.ToString(this.DGVSearch.Rows[e.RowIndex].Cells["ProductCode"].Value);
					this.txtProductCode.Text = text;
				}
			}
			catch (Exception ex)
			{
				this.lblerror.Text = "Error: " + ex.Message;
			}
		}

		// Token: 0x0600581F RID: 22559 RVA: 0x0032A600 File Offset: 0x00328800
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
				this.DGVSearch.Columns["SpecialPrice"].Visible = false;
			}
			else
			{
				this.lblerror.Text = "No products match your search.";
			}
		}

		// Token: 0x06005820 RID: 22560 RVA: 0x0032A7A0 File Offset: 0x003289A0
		private void DGVSearch_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				bool flag = e.KeyCode == Keys.Return;
				if (flag)
				{
					this.txtsearch.Focus();
					e.Handled = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Key down error. Ignore");
			}
		}

		// Token: 0x06005821 RID: 22561 RVA: 0x0032A800 File Offset: 0x00328A00
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

		// Token: 0x06005822 RID: 22562 RVA: 0x0032A8F8 File Offset: 0x00328AF8
		private void txtsearch_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.lblerror.Text = "...";
				this.SearchByDesc(this.txtsearch.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005823 RID: 22563 RVA: 0x0032A964 File Offset: 0x00328B64
		private void txtProductCode_TextChanged_1(object sender, EventArgs e)
		{
			try
			{
				try
				{
					foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						bool flag = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["ProductCode"].Value, this.txtProductCode.Text, false);
						if (flag)
						{
							this.DataGridView1.ClearSelection();
							dataGridViewRow.Cells["ProductCode"].Selected = true;
							this.DataGridView1.CurrentCell = dataGridViewRow.Cells["ProductCode"];
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
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06005824 RID: 22564 RVA: 0x0032AA54 File Offset: 0x00328C54
		private void datagridview_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			try
			{
				this.DataGridView1.Rows[e.RowIndex].ErrorText = "";
				bool flag = Operators.CompareString(this.DataGridView1.Columns[e.ColumnIndex].Name, "PhysicalCount", false) == 0;
				if (flag)
				{
					bool isNewRow = this.DataGridView1.Rows[e.RowIndex].IsNewRow;
					if (!isNewRow)
					{
						decimal num;
						bool flag2 = !decimal.TryParse(e.FormattedValue.ToString(), out num) || decimal.Compare(num, 0m) < 0;
						if (flag2)
						{
							e.Cancel = true;
							this.DataGridView1.Rows[e.RowIndex].ErrorText = "the value must be a non-negative integer";
						}
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06005825 RID: 22565 RVA: 0x0032AB4C File Offset: 0x00328D4C
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				DataTable dataTable = new DataTable();
				this.dat = dataTable;
				this.DataGridView1.DataSource = dataTable;
				this.LoadStock2(0);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading stock. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005826 RID: 22566 RVA: 0x0032ABB8 File Offset: 0x00328DB8
		private void Button4_Click(object sender, EventArgs e)
		{
			try
			{
				DialogResult dialogResult = (DialogResult)Interaction.MsgBox("Do you want to redo quick stock bal intialisation? This may take a long time depending.", MsgBoxStyle.YesNo, null);
				bool flag = dialogResult == DialogResult.Yes;
				if (flag)
				{
					Cursor.Current = Cursors.WaitCursor;
					SqlConnection sqlConnection = new SqlConnection(this._cnn);
					SqlCommand sqlCommand = sqlConnection.CreateCommand();
					sqlCommand.CommandType = CommandType.StoredProcedure;
					sqlCommand.CommandText = "SetQuickStockBal";
					sqlCommand.CommandTimeout = 0;
					sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
					sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
					sqlCommand.Parameters.AddWithValue("iswarehouse", MyProject.Forms.Form1.IsWarehouse);
					using (sqlConnection)
					{
						sqlConnection.Open();
						sqlCommand.ExecuteNonQuery();
						sqlConnection.Close();
					}
					Cursor.Current = Cursors.Default;
					MessageBox.Show("Quick stock balance run successfully.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error redoing quick stock bal initialisation. Details: " + ex.Message);
			}
		}

		// Token: 0x04002677 RID: 9847
		private string _cnn;

		// Token: 0x04002678 RID: 9848
		private PublicFunctions pf;

		// Token: 0x04002679 RID: 9849
		private DataTable dat;

		// Token: 0x0400267A RID: 9850
		private bool firstbalrun;
	}
}
