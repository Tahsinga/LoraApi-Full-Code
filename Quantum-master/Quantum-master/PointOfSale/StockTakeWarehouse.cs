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
	// Token: 0x020001F6 RID: 502
	[DesignerGenerated]
	public partial class StockTakeWarehouse : Form
	{
		// Token: 0x0600597D RID: 22909 RVA: 0x0033A0B4 File Offset: 0x003382B4
		public StockTakeWarehouse()
		{
			base.Load += this.StockTakeWarehouse_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.dat = new DataTable();
			this.firstbalrun = false;
			this.InitializeComponent();
		}

		// Token: 0x17002035 RID: 8245
		// (get) Token: 0x06005980 RID: 22912 RVA: 0x0033B1EB File Offset: 0x003393EB
		// (set) Token: 0x06005981 RID: 22913 RVA: 0x0033B1F5 File Offset: 0x003393F5
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002036 RID: 8246
		// (get) Token: 0x06005982 RID: 22914 RVA: 0x0033B1FE File Offset: 0x003393FE
		// (set) Token: 0x06005983 RID: 22915 RVA: 0x0033B208 File Offset: 0x00339408
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002037 RID: 8247
		// (get) Token: 0x06005984 RID: 22916 RVA: 0x0033B211 File Offset: 0x00339411
		// (set) Token: 0x06005985 RID: 22917 RVA: 0x0033B21C File Offset: 0x0033941C
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
				DataGridView dataGridView = this._DGVSearch;
				if (dataGridView != null)
				{
					dataGridView.CellEnter -= dataGridViewCellEventHandler;
				}
				this._DGVSearch = value;
				dataGridView = this._DGVSearch;
				if (dataGridView != null)
				{
					dataGridView.CellEnter += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x17002038 RID: 8248
		// (get) Token: 0x06005986 RID: 22918 RVA: 0x0033B25F File Offset: 0x0033945F
		// (set) Token: 0x06005987 RID: 22919 RVA: 0x0033B269 File Offset: 0x00339469
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002039 RID: 8249
		// (get) Token: 0x06005988 RID: 22920 RVA: 0x0033B272 File Offset: 0x00339472
		// (set) Token: 0x06005989 RID: 22921 RVA: 0x0033B27C File Offset: 0x0033947C
		internal virtual Button Button3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700203A RID: 8250
		// (get) Token: 0x0600598A RID: 22922 RVA: 0x0033B285 File Offset: 0x00339485
		// (set) Token: 0x0600598B RID: 22923 RVA: 0x0033B28F File Offset: 0x0033948F
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700203B RID: 8251
		// (get) Token: 0x0600598C RID: 22924 RVA: 0x0033B298 File Offset: 0x00339498
		// (set) Token: 0x0600598D RID: 22925 RVA: 0x0033B2A4 File Offset: 0x003394A4
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

		// Token: 0x1700203C RID: 8252
		// (get) Token: 0x0600598E RID: 22926 RVA: 0x0033B2E7 File Offset: 0x003394E7
		// (set) Token: 0x0600598F RID: 22927 RVA: 0x0033B2F4 File Offset: 0x003394F4
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
				EventHandler eventHandler = new EventHandler(this.txtProductCode_TextChanged);
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

		// Token: 0x1700203D RID: 8253
		// (get) Token: 0x06005990 RID: 22928 RVA: 0x0033B337 File Offset: 0x00339537
		// (set) Token: 0x06005991 RID: 22929 RVA: 0x0033B341 File Offset: 0x00339541
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700203E RID: 8254
		// (get) Token: 0x06005992 RID: 22930 RVA: 0x0033B34A File Offset: 0x0033954A
		// (set) Token: 0x06005993 RID: 22931 RVA: 0x0033B354 File Offset: 0x00339554
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700203F RID: 8255
		// (get) Token: 0x06005994 RID: 22932 RVA: 0x0033B35D File Offset: 0x0033955D
		// (set) Token: 0x06005995 RID: 22933 RVA: 0x0033B367 File Offset: 0x00339567
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002040 RID: 8256
		// (get) Token: 0x06005996 RID: 22934 RVA: 0x0033B370 File Offset: 0x00339570
		// (set) Token: 0x06005997 RID: 22935 RVA: 0x0033B37A File Offset: 0x0033957A
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002041 RID: 8257
		// (get) Token: 0x06005998 RID: 22936 RVA: 0x0033B383 File Offset: 0x00339583
		// (set) Token: 0x06005999 RID: 22937 RVA: 0x0033B38D File Offset: 0x0033958D
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002042 RID: 8258
		// (get) Token: 0x0600599A RID: 22938 RVA: 0x0033B396 File Offset: 0x00339596
		// (set) Token: 0x0600599B RID: 22939 RVA: 0x0033B3A0 File Offset: 0x003395A0
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

		// Token: 0x17002043 RID: 8259
		// (get) Token: 0x0600599C RID: 22940 RVA: 0x0033B3E3 File Offset: 0x003395E3
		// (set) Token: 0x0600599D RID: 22941 RVA: 0x0033B3ED File Offset: 0x003395ED
		internal virtual DateTimePicker DTdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002044 RID: 8260
		// (get) Token: 0x0600599E RID: 22942 RVA: 0x0033B3F6 File Offset: 0x003395F6
		// (set) Token: 0x0600599F RID: 22943 RVA: 0x0033B400 File Offset: 0x00339600
		internal virtual DataGridView dgvProducts
		{
			[CompilerGenerated]
			get
			{
				return this._dgvProducts;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
				DataGridView dataGridView = this._dgvProducts;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick -= dataGridViewCellEventHandler;
				}
				this._dgvProducts = value;
				dataGridView = this._dgvProducts;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x17002045 RID: 8261
		// (get) Token: 0x060059A0 RID: 22944 RVA: 0x0033B443 File Offset: 0x00339643
		// (set) Token: 0x060059A1 RID: 22945 RVA: 0x0033B44D File Offset: 0x0033964D
		internal virtual Label lblproductcount
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002046 RID: 8262
		// (get) Token: 0x060059A2 RID: 22946 RVA: 0x0033B456 File Offset: 0x00339656
		// (set) Token: 0x060059A3 RID: 22947 RVA: 0x0033B460 File Offset: 0x00339660
		internal virtual ProgressBar ProgressBar1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002047 RID: 8263
		// (get) Token: 0x060059A4 RID: 22948 RVA: 0x0033B469 File Offset: 0x00339669
		// (set) Token: 0x060059A5 RID: 22949 RVA: 0x0033B474 File Offset: 0x00339674
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

		// Token: 0x17002048 RID: 8264
		// (get) Token: 0x060059A6 RID: 22950 RVA: 0x0033B4B7 File Offset: 0x003396B7
		// (set) Token: 0x060059A7 RID: 22951 RVA: 0x0033B4C4 File Offset: 0x003396C4
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

		// Token: 0x17002049 RID: 8265
		// (get) Token: 0x060059A8 RID: 22952 RVA: 0x0033B507 File Offset: 0x00339707
		// (set) Token: 0x060059A9 RID: 22953 RVA: 0x0033B514 File Offset: 0x00339714
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

		// Token: 0x1700204A RID: 8266
		// (get) Token: 0x060059AA RID: 22954 RVA: 0x0033B557 File Offset: 0x00339757
		// (set) Token: 0x060059AB RID: 22955 RVA: 0x0033B564 File Offset: 0x00339764
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

		// Token: 0x1700204B RID: 8267
		// (get) Token: 0x060059AC RID: 22956 RVA: 0x0033B5A7 File Offset: 0x003397A7
		// (set) Token: 0x060059AD RID: 22957 RVA: 0x0033B5B4 File Offset: 0x003397B4
		internal virtual Button Button7
		{
			[CompilerGenerated]
			get
			{
				return this._Button7;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button7_Click);
				Button button = this._Button7;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button7 = value;
				button = this._Button7;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x060059AE RID: 22958 RVA: 0x0033B5F8 File Offset: 0x003397F8
		private void StockTakeWarehouse_Load(object sender, EventArgs e)
		{
			try
			{
				this.firstbalrun = this.pf.CheckIfFirstBalRun(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, this._cnn);
				this.LoadLevels(this.firstbalrun, 0);
				try
				{
					foreach (object obj in this.dgvProducts.Columns)
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
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x060059AF RID: 22959 RVA: 0x0033B6D8 File Offset: 0x003398D8
		private void LoadLevels(bool firstbalran, int showall)
		{
			DataTable dataTable = new DataTable();
			this.dat = dataTable;
			this.dgvProducts.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			bool flag = this.firstbalrun;
			if (flag)
			{
				sqlCommand.CommandText = "CurrentStockLevelsWarehouseCurrent";
				sqlCommand.Parameters.AddWithValue("allbalances", showall);
			}
			else
			{
				sqlCommand.CommandText = "CurrentStockLevelsWarehouse";
			}
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(this.dat);
			this.dgvProducts.DataSource = this.dat;
			this.dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvProducts.Columns["ProductID"].HeaderText = "Product ID";
			this.dgvProducts.Columns["ProductDesc"].HeaderText = "Description";
			this.dgvProducts.Columns["BatchNumber"].HeaderText = "Batch Number";
			this.dgvProducts.Columns["ExpiryDate"].HeaderText = "Expiry Date";
			this.dgvProducts.Columns["bal"].HeaderText = "Current Balance";
			this.lblproductcount.Text = this.dgvProducts.RowCount.ToString();
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn.Name = "physicalbal";
			dataGridViewTextBoxColumn.HeaderText = "Physical Bal";
			this.dgvProducts.Columns.Add(dataGridViewTextBoxColumn);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn2.Name = "colvar";
			dataGridViewTextBoxColumn2.HeaderText = "Reason for Variance";
			this.dgvProducts.Columns.Add(dataGridViewTextBoxColumn2);
			DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
			dataGridViewButtonColumn.Name = "SPLIT";
			dataGridViewButtonColumn.HeaderText = "Insert New Line of same product";
			dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
			dataGridViewButtonColumn.Text = "SPLIT";
			this.dgvProducts.Columns.Add(dataGridViewButtonColumn);
			DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
			dataGridViewCheckBoxColumn.HeaderText = "Select?";
			dataGridViewCheckBoxColumn.Name = "Select";
			this.dgvProducts.Columns.Add(dataGridViewCheckBoxColumn);
			this.CopyBals();
		}

		// Token: 0x060059B0 RID: 22960 RVA: 0x0033B988 File Offset: 0x00339B88
		private void CopyBals()
		{
			try
			{
				foreach (object obj in ((IEnumerable)this.dgvProducts.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					dataGridViewRow.Cells["physicalbal"].Value = RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["bal"].Value);
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

		// Token: 0x060059B1 RID: 22961 RVA: 0x0033BA18 File Offset: 0x00339C18
		private void Button1_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = (DialogResult)Interaction.MsgBox("Are you sure you have entered the correct Physical Stock count figures and want to adjust stock?", MsgBoxStyle.YesNo, null);
			bool flag = dialogResult == DialogResult.Yes;
			if (flag)
			{
				this.AdjustStock();
			}
		}

		// Token: 0x060059B2 RID: 22962 RVA: 0x0033BA44 File Offset: 0x00339C44
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
			try
			{
				this.ProgressBar1.PerformStep();
				int num = checked((int)Math.Round(Conversion.Val(DateAndTime.TimeOfDay.ToString("HHmm"))));
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvProducts.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						decimal num2 = new decimal(Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["bal"].Value)));
						decimal num3 = new decimal(Conversion.Val(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["physicalbal"].Value)), 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["physicalbal"].Value)))));
						bool flag = decimal.Compare(num2, num3) == 0;
						if (flag)
						{
							bool flag2 = !this.firstbalrun;
							if (flag2)
							{
								sqlCommand.Parameters.Clear();
								sqlCommand.CommandType = CommandType.StoredProcedure;
								sqlCommand.CommandText = "InsertNewStockStockTakeWarehouse";
								sqlCommand.Parameters.AddWithValue("trandate", this.DTdate.Value.ToString("yyyyMMdd"));
								sqlCommand.Parameters.AddWithValue("invoicenum", 0);
								sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ProductID"].Value));
								sqlCommand.Parameters.AddWithValue("isstockin", 1);
								sqlCommand.Parameters.AddWithValue("ref", "STOCK MAINTAINED");
								sqlCommand.Parameters.AddWithValue("quantity", 0);
								sqlCommand.Parameters.AddWithValue("cost", RuntimeHelpers.GetObjectValue(this.pf.GetProdCost(Conversions.ToInteger(dataGridViewRow.Cells["ProductID"].Value), this._cnn)));
								sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
								sqlCommand.Parameters.AddWithValue("donewhen", DateTime.Today.ToString("yyyyMMdd"));
								sqlCommand.Parameters.AddWithValue("trancode", 2);
								sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
								sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
								sqlCommand.Parameters.AddWithValue("batchnumber", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["BatchNumber"].Value));
								sqlCommand.Parameters.AddWithValue("expdate", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ExpiryDate"].Value));
								bool flag3 = dataGridViewRow.Cells[8].Value == null;
								string text;
								if (flag3)
								{
									text = "";
								}
								else
								{
									text = dataGridViewRow.Cells[8].Value.ToString();
								}
								sqlCommand.Parameters.AddWithValue("details", text);
								sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
								sqlCommand.Parameters.AddWithValue("trantime", DateTime.Now.ToString("HH:mm"));
								sqlCommand.ExecuteNonQuery();
							}
						}
						else
						{
							bool flag4 = decimal.Compare(num2, num3) > 0;
							if (flag4)
							{
								sqlCommand.Parameters.Clear();
								sqlCommand.CommandType = CommandType.StoredProcedure;
								sqlCommand.CommandText = "InsertNewSaleStockTakeWarehouse";
								sqlCommand.Parameters.AddWithValue("trandate", this.DTdate.Value.ToString("yyyyMMdd"));
								sqlCommand.Parameters.AddWithValue("invoicenum", 0);
								sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ProductID"].Value));
								sqlCommand.Parameters.AddWithValue("isstockin", 0);
								sqlCommand.Parameters.AddWithValue("ref", "STOCK REDUCED");
								sqlCommand.Parameters.AddWithValue("quantity", decimal.Subtract(num2, num3));
								sqlCommand.Parameters.AddWithValue("unitcost", RuntimeHelpers.GetObjectValue(this.pf.GetProdCost(Conversions.ToInteger(dataGridViewRow.Cells["ProductID"].Value), this._cnn)));
								sqlCommand.Parameters.AddWithValue("salesprice", 0);
								sqlCommand.Parameters.AddWithValue("paymentmethod", 0);
								sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
								sqlCommand.Parameters.AddWithValue("donewhen", DateTime.Today.ToString("yyyyMMdd"));
								sqlCommand.Parameters.AddWithValue("trancode", 2);
								sqlCommand.Parameters.AddWithValue("TranTime", num);
								sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
								sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
								sqlCommand.Parameters.AddWithValue("batchnumber", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["BatchNumber"].Value));
								sqlCommand.Parameters.AddWithValue("expdate", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ExpiryDate"].Value));
								bool flag5 = dataGridViewRow.Cells[8].Value == null;
								string text2;
								if (flag5)
								{
									text2 = "";
								}
								else
								{
									text2 = dataGridViewRow.Cells[8].Value.ToString();
								}
								sqlCommand.Parameters.AddWithValue("details", text2);
								sqlCommand.Parameters.AddWithValue("Stockbal", num2);
								sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
								sqlCommand.ExecuteNonQuery();
							}
							else
							{
								bool flag6 = decimal.Compare(num2, num3) < 0;
								if (flag6)
								{
									sqlCommand.Parameters.Clear();
									sqlCommand.CommandType = CommandType.StoredProcedure;
									sqlCommand.CommandText = "InsertNewStockStockTakeWarehouse";
									sqlCommand.Parameters.AddWithValue("trandate", this.DTdate.Value.ToString("yyyyMMdd"));
									sqlCommand.Parameters.AddWithValue("invoicenum", 0);
									sqlCommand.Parameters.AddWithValue("productid", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ProductID"].Value));
									sqlCommand.Parameters.AddWithValue("isstockin", 1);
									sqlCommand.Parameters.AddWithValue("ref", "STOCK INCREASED");
									decimal num4 = decimal.Subtract(num3, num2);
									sqlCommand.Parameters.AddWithValue("quantity", decimal.Subtract(num3, num2));
									sqlCommand.Parameters.AddWithValue("cost", RuntimeHelpers.GetObjectValue(this.pf.GetProdCost(Conversions.ToInteger(dataGridViewRow.Cells["ProductID"].Value), this._cnn)));
									sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
									sqlCommand.Parameters.AddWithValue("donewhen", DateTime.Today.ToString("yyyyMMdd"));
									sqlCommand.Parameters.AddWithValue("trancode", 2);
									sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
									sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
									sqlCommand.Parameters.AddWithValue("batchnumber", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["BatchNumber"].Value));
									sqlCommand.Parameters.AddWithValue("expdate", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ExpiryDate"].Value));
									bool flag7 = dataGridViewRow.Cells[8].Value == null;
									string text3;
									if (flag7)
									{
										text3 = "";
									}
									else
									{
										text3 = dataGridViewRow.Cells[8].Value.ToString();
									}
									sqlCommand.Parameters.AddWithValue("details", text3);
									sqlCommand.Parameters.AddWithValue("Stockbal", num2);
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
				bool flag8 = !this.firstbalrun;
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
				this.LoadLevels(this.firstbalrun, 0);
			}
			catch (Exception ex)
			{
				sqlTransaction.Rollback();
				sqlCommand.Connection.Close();
				this.ProgressBar1.Visible = false;
				MessageBox.Show("Error occured adjusting stock. Detail: " + ex.Message);
			}
		}

		// Token: 0x060059B3 RID: 22963 RVA: 0x0033C5B8 File Offset: 0x0033A7B8
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

		// Token: 0x060059B4 RID: 22964 RVA: 0x0033C624 File Offset: 0x0033A824
		private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridView dataGridView = (DataGridView)sender;
			bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn) & (e.RowIndex >= 0);
			if (flag)
			{
				bool flag2 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "SPLIT", false) == 0;
				if (flag2)
				{
					DataRow dataRow = this.dat.NewRow();
					DataRow dataRow2 = dataRow;
					dataRow2["productid"] = RuntimeHelpers.GetObjectValue(this.dgvProducts.Rows[e.RowIndex].Cells["ProductID"].Value);
					dataRow2["productdesc"] = RuntimeHelpers.GetObjectValue(this.dgvProducts.Rows[e.RowIndex].Cells["ProductDesc"].Value);
					dataRow2["batchnumber"] = RuntimeHelpers.GetObjectValue(this.dgvProducts.Rows[e.RowIndex].Cells["batchnumber"].Value);
					dataRow2["expirydate"] = RuntimeHelpers.GetObjectValue(this.dgvProducts.Rows[e.RowIndex].Cells["expirydate"].Value);
					dataRow2["bal"] = 0;
					this.dat.Rows.Add(dataRow);
					this.dat.DefaultView.Sort = "ProductID";
					this.dat.AcceptChanges();
					this.CopyBals();
				}
			}
		}

		// Token: 0x060059B5 RID: 22965 RVA: 0x0033C7E8 File Offset: 0x0033A9E8
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

		// Token: 0x060059B6 RID: 22966 RVA: 0x0033C8E0 File Offset: 0x0033AAE0
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

		// Token: 0x060059B7 RID: 22967 RVA: 0x0033C9A0 File Offset: 0x0033ABA0
		private void txtProductCode_TextChanged(object sender, EventArgs e)
		{
			try
			{
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvProducts.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						bool flag = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["ProductCode"].Value, this.txtProductCode.Text, false);
						if (flag)
						{
							this.dgvProducts.ClearSelection();
							dataGridViewRow.Cells["ProductCode"].Selected = true;
							this.dgvProducts.CurrentCell = dataGridViewRow.Cells["ProductCode"];
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

		// Token: 0x060059B8 RID: 22968 RVA: 0x0033CA90 File Offset: 0x0033AC90
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvProducts.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						dataGridViewRow.Cells["physicalbal"].Value = 0;
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
				MessageBox.Show("Error occurred. Detail: " + ex.Message);
			}
		}

		// Token: 0x060059B9 RID: 22969 RVA: 0x0033CB40 File Offset: 0x0033AD40
		private void Button4_Click(object sender, EventArgs e)
		{
			try
			{
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvProducts.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						bool flag = Conversions.ToBoolean(dataGridViewRow.Cells["Select"].Value);
						bool flag2 = flag;
						if (flag2)
						{
							dataGridViewRow.Cells["physicalbal"].Value = 0;
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
				MessageBox.Show("Done. Click Adjust Stock to confirm.");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error putting zeros. Detail: " + ex.Message);
			}
		}

		// Token: 0x060059BA RID: 22970 RVA: 0x00002A30 File Offset: 0x00000C30
		private void deleteProdtLine()
		{
		}

		// Token: 0x060059BB RID: 22971 RVA: 0x0033CC24 File Offset: 0x0033AE24
		private void Button5_Click(object sender, EventArgs e)
		{
			try
			{
				DialogResult dialogResult = (DialogResult)Interaction.MsgBox("If you had entered any physical stock balance they will be deleted. Do you want to proceed?", MsgBoxStyle.YesNo, null);
				bool flag = dialogResult == DialogResult.Yes;
				if (flag)
				{
					this.LoadLevels(this.firstbalrun, 1);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying stock with zero balances. Detail: " + ex.Message);
			}
		}

		// Token: 0x060059BC RID: 22972 RVA: 0x0033CC90 File Offset: 0x0033AE90
		private void Button6_Click(object sender, EventArgs e)
		{
			try
			{
				DialogResult dialogResult = (DialogResult)Interaction.MsgBox("If you had entered any physical stock balance they will be deleted. Do you want to proceed?", MsgBoxStyle.YesNo, null);
				bool flag = dialogResult == DialogResult.Yes;
				if (flag)
				{
					this.LoadLevels(this.firstbalrun, 0);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying stock with zero balances. Detail: " + ex.Message);
			}
		}

		// Token: 0x060059BD RID: 22973 RVA: 0x0033CCFC File Offset: 0x0033AEFC
		private void Button7_Click(object sender, EventArgs e)
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

		// Token: 0x04002727 RID: 10023
		private string _cnn;

		// Token: 0x04002728 RID: 10024
		private PublicFunctions pf;

		// Token: 0x04002729 RID: 10025
		private DataTable dat;

		// Token: 0x0400272A RID: 10026
		private bool firstbalrun;
	}
}
