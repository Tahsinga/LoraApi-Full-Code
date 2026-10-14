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
	// Token: 0x020001E2 RID: 482
	[DesignerGenerated]
	public partial class StockAging : Form
	{
		// Token: 0x0600549B RID: 21659 RVA: 0x0030ED04 File Offset: 0x0030CF04
		public StockAging()
		{
			base.Load += this.StockAging_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.datStockAging = new DataTable();
			this.dat = new DataTable();
			this.InitializeComponent();
		}

		// Token: 0x17001E5D RID: 7773
		// (get) Token: 0x0600549E RID: 21662 RVA: 0x0030F42E File Offset: 0x0030D62E
		// (set) Token: 0x0600549F RID: 21663 RVA: 0x0030F438 File Offset: 0x0030D638
		internal virtual DataGridView dgvStocks
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E5E RID: 7774
		// (get) Token: 0x060054A0 RID: 21664 RVA: 0x0030F441 File Offset: 0x0030D641
		// (set) Token: 0x060054A1 RID: 21665 RVA: 0x0030F44B File Offset: 0x0030D64B
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E5F RID: 7775
		// (get) Token: 0x060054A2 RID: 21666 RVA: 0x0030F454 File Offset: 0x0030D654
		// (set) Token: 0x060054A3 RID: 21667 RVA: 0x0030F45E File Offset: 0x0030D65E
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E60 RID: 7776
		// (get) Token: 0x060054A4 RID: 21668 RVA: 0x0030F467 File Offset: 0x0030D667
		// (set) Token: 0x060054A5 RID: 21669 RVA: 0x0030F474 File Offset: 0x0030D674
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

		// Token: 0x17001E61 RID: 7777
		// (get) Token: 0x060054A6 RID: 21670 RVA: 0x0030F4B7 File Offset: 0x0030D6B7
		// (set) Token: 0x060054A7 RID: 21671 RVA: 0x0030F4C1 File Offset: 0x0030D6C1
		internal virtual CheckBox chkAll
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E62 RID: 7778
		// (get) Token: 0x060054A8 RID: 21672 RVA: 0x0030F4CA File Offset: 0x0030D6CA
		// (set) Token: 0x060054A9 RID: 21673 RVA: 0x0030F4D4 File Offset: 0x0030D6D4
		internal virtual ComboBox cboBranches
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E63 RID: 7779
		// (get) Token: 0x060054AA RID: 21674 RVA: 0x0030F4DD File Offset: 0x0030D6DD
		// (set) Token: 0x060054AB RID: 21675 RVA: 0x0030F4E7 File Offset: 0x0030D6E7
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E64 RID: 7780
		// (get) Token: 0x060054AC RID: 21676 RVA: 0x0030F4F0 File Offset: 0x0030D6F0
		// (set) Token: 0x060054AD RID: 21677 RVA: 0x0030F4FA File Offset: 0x0030D6FA
		internal virtual DateTimePicker DateTimePicker1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E65 RID: 7781
		// (get) Token: 0x060054AE RID: 21678 RVA: 0x0030F503 File Offset: 0x0030D703
		// (set) Token: 0x060054AF RID: 21679 RVA: 0x0030F510 File Offset: 0x0030D710
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

		// Token: 0x17001E66 RID: 7782
		// (get) Token: 0x060054B0 RID: 21680 RVA: 0x0030F553 File Offset: 0x0030D753
		// (set) Token: 0x060054B1 RID: 21681 RVA: 0x0030F55D File Offset: 0x0030D75D
		internal virtual SaveFileDialog SaveFileDialog1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E67 RID: 7783
		// (get) Token: 0x060054B2 RID: 21682 RVA: 0x0030F566 File Offset: 0x0030D766
		// (set) Token: 0x060054B3 RID: 21683 RVA: 0x0030F570 File Offset: 0x0030D770
		internal virtual ProgressBar ProgressBar1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060054B4 RID: 21684 RVA: 0x0030F57C File Offset: 0x0030D77C
		private void StockAging_Load(object sender, EventArgs e)
		{
			try
			{
				base.WindowState = FormWindowState.Maximized;
				this.LoadBranches();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x060054B5 RID: 21685 RVA: 0x0030F5D4 File Offset: 0x0030D7D4
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
			this.cboBranches.DataSource = dataTable;
			this.cboBranches.ValueMember = "branch";
			this.cboBranches.DisplayMember = "branch";
		}

		// Token: 0x060054B6 RID: 21686 RVA: 0x0030F674 File Offset: 0x0030D874
		private void LoadTempStockAge()
		{
			DataTable dataTable = new DataTable();
			this.datStockAging = dataTable;
			string text = null;
			bool flag = !this.chkAll.Checked;
			if (flag)
			{
				text = this.cboBranches.Text;
			}
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "CalcStockAging";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", text);
			sqlCommand.Parameters.AddWithValue("currentdate", Convert.ToInt32(this.DateTimePicker1.Value.ToString("yyyyMMdd")));
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(this.datStockAging);
		}

		// Token: 0x060054B7 RID: 21687 RVA: 0x0030F75C File Offset: 0x0030D95C
		private void LoadGrid()
		{
			this.dgvStocks.Columns.Clear();
			this.dat.Clear();
			this.dat.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectCategorisedProducts";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("trandate", this.DateTimePicker1.Value.ToString("yyyyMMdd"));
			sqlCommand.Parameters.AddWithValue("branch", this.cboBranches.Text);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(this.dat);
			this.dat.Columns.Add("col0_30");
			this.dat.Columns.Add("col0_30_costvalue");
			this.dat.Columns.Add("col31_60");
			this.dat.Columns.Add("col31_60_costvalue");
			this.dat.Columns.Add("col61_90");
			this.dat.Columns.Add("col61_90_costvalue");
			this.dat.Columns.Add("col91_120");
			this.dat.Columns.Add("col91_120_costvalue");
			this.dat.Columns.Add("col120");
			this.dat.Columns.Add("col120_costvalue");
			this.dgvStocks.DataSource = this.dat;
			this.dgvStocks.Columns["col0_30"].HeaderText = "0-30 Days Stock Count";
			this.dgvStocks.Columns["col0_30_costvalue"].HeaderText = "0-30 Days Cost Value";
			this.dgvStocks.Columns["col0_30_costvalue"].DefaultCellStyle.BackColor = Color.LightGray;
			this.dgvStocks.Columns["col31_60"].HeaderText = "31-60 Days Stock Count";
			this.dgvStocks.Columns["col31_60_costvalue"].HeaderText = "31-60 Days Cost Value";
			this.dgvStocks.Columns["col31_60_costvalue"].DefaultCellStyle.BackColor = Color.LightGray;
			this.dgvStocks.Columns["col61_90"].HeaderText = "61-90 Days Stock Count";
			this.dgvStocks.Columns["col61_90_costvalue"].HeaderText = "61-90 Days Cost Value";
			this.dgvStocks.Columns["col61_90_costvalue"].DefaultCellStyle.BackColor = Color.LightGray;
			this.dgvStocks.Columns["col91_120"].HeaderText = "91-120 Days Stock Count";
			this.dgvStocks.Columns["col91_120_costvalue"].HeaderText = "91-120 Days Cost Value";
			this.dgvStocks.Columns["col91_120_costvalue"].DefaultCellStyle.BackColor = Color.LightGray;
			this.dgvStocks.Columns["col120"].HeaderText = ">120 Days Stock Count";
			this.dgvStocks.Columns["col120_costvalue"].HeaderText = ">120 Days Cost Value";
			this.dgvStocks.Columns["col120_costvalue"].DefaultCellStyle.BackColor = Color.LightGray;
			this.dgvStocks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		}

		// Token: 0x060054B8 RID: 21688 RVA: 0x0030FB34 File Offset: 0x0030DD34
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
				this.ProgressBar1.Visible = true;
				this.ProgressBar1.Minimum = 0;
				this.ProgressBar1.Maximum = 100;
				this.ProgressBar1.Increment(1);
				this.ProgressBar1.Step = 1;
				this.LoadTempStockAge();
				this.ProgressBar1.PerformStep();
				this.LoadGrid();
				this.ProgressBar1.PerformStep();
				this.ProgressBar1.Maximum = checked(this.dgvStocks.Rows.Count + 1);
				decimal num4;
				decimal num8;
				decimal num12;
				decimal num16;
				decimal num20;
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvStocks.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						this.ProgressBar1.PerformStep();
						bool flag = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["Total_Stock_Bal"].Value, 0, false);
						if (flag)
						{
							dataGridViewRow.Cells["col0_30"].Value = 0;
							dataGridViewRow.Cells["col0_30_costvalue"].Value = 0;
							dataGridViewRow.Cells["col31_60"].Value = 0;
							dataGridViewRow.Cells["col31_60_costvalue"].Value = 0;
							dataGridViewRow.Cells["col61_90"].Value = 0;
							dataGridViewRow.Cells["col61_90_costvalue"].Value = 0;
							dataGridViewRow.Cells["col91_120"].Value = 0;
							dataGridViewRow.Cells["col91_120_costvalue"].Value = 0;
							dataGridViewRow.Cells["col120"].Value = 0;
							dataGridViewRow.Cells["col120_costvalue"].Value = 0;
						}
						else
						{
							dataGridViewRow.Cells["col0_30"].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.datStockAging.Compute("SUM(qty)", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("productid= ", dataGridViewRow.Cells["productid"].Value), " And age <31"))))), 0, RuntimeHelpers.GetObjectValue(this.datStockAging.Compute("SUM(qty)", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("productid=", dataGridViewRow.Cells["productid"].Value), " And age <31"))))));
							decimal num = Conversions.ToDecimal(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.datStockAging.Compute("SUM(calc_cost)", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("productid=", dataGridViewRow.Cells["productid"].Value), " And age <31"))))), 0, RuntimeHelpers.GetObjectValue(this.datStockAging.Compute("SUM(calc_cost)", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("productid=", dataGridViewRow.Cells["productid"].Value), " And age <31"))))));
							decimal num2 = Conversions.ToDecimal(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.datStockAging.Compute("SUM(qty)", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("productid=", dataGridViewRow.Cells["productid"].Value), " And age <31"))))), 0, RuntimeHelpers.GetObjectValue(this.datStockAging.Compute("SUM(qty)", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("productid=", dataGridViewRow.Cells["productid"].Value), " And age <31"))))));
							bool flag2 = (decimal.Compare(num, 0m) == 0) | (decimal.Compare(num2, 0m) == 0);
							decimal num3;
							if (flag2)
							{
								num3 = 0m;
							}
							else
							{
								num3 = decimal.Divide(num, num2);
							}
							dataGridViewRow.Cells["col0_30_costvalue"].Value = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(null, typeof(Math), "Round", new object[]
							{
								Operators.MultiplyObject(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["col0_30"].Value)), 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["col0_30"].Value)), num3),
								0,
								MidpointRounding.AwayFromZero
							}, null, null, null));
							num4 = Conversions.ToDecimal(Operators.AddObject(num4, dataGridViewRow.Cells["col0_30_costvalue"].Value));
							dataGridViewRow.Cells["col31_60"].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.datStockAging.Compute("SUM(qty)", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("productid=", dataGridViewRow.Cells["productid"].Value), " And age > 30 And age <61"))))), 0, RuntimeHelpers.GetObjectValue(this.datStockAging.Compute("SUM(qty)", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("productid=", dataGridViewRow.Cells["productid"].Value), " And age > 30 And age <61"))))));
							decimal num5 = Conversions.ToDecimal(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.datStockAging.Compute("SUM(calc_cost)", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("productid=", dataGridViewRow.Cells["productid"].Value), " And age > 30 And age <61"))))), 0, RuntimeHelpers.GetObjectValue(this.datStockAging.Compute("SUM(calc_cost)", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("productid=", dataGridViewRow.Cells["productid"].Value), " And age > 30 And age <61"))))));
							decimal num6 = Conversions.ToDecimal(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.datStockAging.Compute("SUM(qty)", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("productid=", dataGridViewRow.Cells["productid"].Value), " And age > 30 And age <61"))))), 0, RuntimeHelpers.GetObjectValue(this.datStockAging.Compute("SUM(qty)", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("productid=", dataGridViewRow.Cells["productid"].Value), " And age > 30 And age <61"))))));
							bool flag3 = (decimal.Compare(num5, 0m) == 0) | (decimal.Compare(num6, 0m) == 0);
							decimal num7;
							if (flag3)
							{
								num7 = 0m;
							}
							else
							{
								num7 = decimal.Divide(num5, num6);
							}
							dataGridViewRow.Cells["col31_60_costvalue"].Value = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(null, typeof(Math), "Round", new object[]
							{
								Operators.MultiplyObject(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["col31_60"].Value)), 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["col31_60"].Value)), num7),
								2,
								MidpointRounding.AwayFromZero
							}, null, null, null));
							num8 = Conversions.ToDecimal(Operators.AddObject(num8, dataGridViewRow.Cells["col31_60_costvalue"].Value));
							dataGridViewRow.Cells["col61_90"].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.datStockAging.Compute("SUM(qty)", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("productid=", dataGridViewRow.Cells["productid"].Value), " And age >60 And age < 91"))))), 0, RuntimeHelpers.GetObjectValue(this.datStockAging.Compute("SUM(qty)", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("productid=", dataGridViewRow.Cells["productid"].Value), " And age >60 And age < 91"))))));
							decimal num9 = Conversions.ToDecimal(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.datStockAging.Compute("SUM(calc_cost)", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("productid=", dataGridViewRow.Cells["productid"].Value), " And age >60 And age < 91"))))), 0, RuntimeHelpers.GetObjectValue(this.datStockAging.Compute("SUM(calc_cost)", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("productid=", dataGridViewRow.Cells["productid"].Value), " And age >60 And age < 91"))))));
							decimal num10 = Conversions.ToDecimal(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.datStockAging.Compute("SUM(qty)", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("productid=", dataGridViewRow.Cells["productid"].Value), " And age >60 And age < 91"))))), 0, RuntimeHelpers.GetObjectValue(this.datStockAging.Compute("SUM(qty)", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("productid=", dataGridViewRow.Cells["productid"].Value), " And age >60 And age < 91"))))));
							bool flag4 = (decimal.Compare(num9, 0m) == 0) | (decimal.Compare(num10, 0m) == 0);
							decimal num11;
							if (flag4)
							{
								num11 = 0m;
							}
							else
							{
								num11 = decimal.Divide(num9, num10);
							}
							dataGridViewRow.Cells["col61_90_costvalue"].Value = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(null, typeof(Math), "Round", new object[]
							{
								Operators.MultiplyObject(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["col61_90"].Value)), 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["col61_90"].Value)), num11),
								2,
								MidpointRounding.AwayFromZero
							}, null, null, null));
							num12 = Conversions.ToDecimal(Operators.AddObject(num12, dataGridViewRow.Cells["col61_90_costvalue"].Value));
							dataGridViewRow.Cells["col91_120"].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.datStockAging.Compute("SUM(qty)", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("productid=", dataGridViewRow.Cells["productid"].Value), " And age >90 And age < 121"))))), 0, RuntimeHelpers.GetObjectValue(this.datStockAging.Compute("SUM(qty)", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("productid=", dataGridViewRow.Cells["productid"].Value), " And age >90 And age < 121"))))));
							decimal num13 = Conversions.ToDecimal(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.datStockAging.Compute("SUM(calc_cost)", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("productid=", dataGridViewRow.Cells["productid"].Value), " And age >90 And age < 121"))))), 0, RuntimeHelpers.GetObjectValue(this.datStockAging.Compute("SUM(calc_cost)", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("productid=", dataGridViewRow.Cells["productid"].Value), " And age >90 And age < 121"))))));
							decimal num14 = Conversions.ToDecimal(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.datStockAging.Compute("SUM(qty)", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("productid=", dataGridViewRow.Cells["productid"].Value), " And age >90 And age < 121"))))), 0, RuntimeHelpers.GetObjectValue(this.datStockAging.Compute("SUM(qty)", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("productid=", dataGridViewRow.Cells["productid"].Value), " And age >90 And age < 121"))))));
							bool flag5 = (decimal.Compare(num13, 0m) == 0) | (decimal.Compare(num14, 0m) == 0);
							decimal num15;
							if (flag5)
							{
								num15 = 0m;
							}
							else
							{
								num15 = decimal.Divide(num13, num14);
							}
							dataGridViewRow.Cells["col91_120_costvalue"].Value = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(null, typeof(Math), "Round", new object[]
							{
								Operators.MultiplyObject(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["col91_120"].Value)), 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["col91_120"].Value)), num15),
								2,
								MidpointRounding.AwayFromZero
							}, null, null, null));
							num16 = Conversions.ToDecimal(Operators.AddObject(num16, dataGridViewRow.Cells["col91_120_costvalue"].Value));
							dataGridViewRow.Cells["col120"].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.datStockAging.Compute("SUM(qty)", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("productid=", dataGridViewRow.Cells["productid"].Value), " And age > 120"))))), 0, RuntimeHelpers.GetObjectValue(this.datStockAging.Compute("SUM(qty)", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("productid=", dataGridViewRow.Cells["productid"].Value), " And age > 120"))))));
							decimal num17 = Conversions.ToDecimal(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.datStockAging.Compute("SUM(calc_cost)", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("productid=", dataGridViewRow.Cells["productid"].Value), " And age > 120"))))), 0, RuntimeHelpers.GetObjectValue(this.datStockAging.Compute("SUM(calc_cost)", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("productid=", dataGridViewRow.Cells["productid"].Value), " And age > 120"))))));
							decimal num18 = Conversions.ToDecimal(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.datStockAging.Compute("SUM(qty)", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("productid=", dataGridViewRow.Cells["productid"].Value), " And age > 120"))))), 0, RuntimeHelpers.GetObjectValue(this.datStockAging.Compute("SUM(qty)", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("productid=", dataGridViewRow.Cells["productid"].Value), " And age > 120"))))));
							bool flag6 = (decimal.Compare(num17, 0m) == 0) | (decimal.Compare(num18, 0m) == 0);
							decimal num19;
							if (flag6)
							{
								num19 = 0m;
							}
							else
							{
								num19 = decimal.Divide(num17, num18);
							}
							dataGridViewRow.Cells["col120_costvalue"].Value = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(null, typeof(Math), "Round", new object[]
							{
								Operators.MultiplyObject(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["col120"].Value)), 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["col120"].Value)), num19),
								2,
								MidpointRounding.AwayFromZero
							}, null, null, null));
							num20 = Conversions.ToDecimal(Operators.AddObject(num20, dataGridViewRow.Cells["col120_costvalue"].Value));
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
				DataRow dataRow = this.dat.NewRow();
				DataRow dataRow2 = dataRow;
				dataRow2["col0_30_costvalue"] = num4;
				dataRow2["col31_60_costvalue"] = num8;
				dataRow2["col61_90_costvalue"] = num12;
				dataRow2["col91_120_costvalue"] = num16;
				dataRow2["col120_costvalue"] = num20;
				this.dat.Rows.Add(dataRow);
				this.dat.AcceptChanges();
				this.ProgressBar1.PerformStep();
				MessageBox.Show("Stock Aging successfully loaded.");
				this.ProgressBar1.Visible = false;
				this.Cursor = Cursors.Default;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error calculating. Detail: " + ex.Message);
				this.Cursor = Cursors.Default;
			}
		}

		// Token: 0x060054B9 RID: 21689 RVA: 0x00310D80 File Offset: 0x0030EF80
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.dgvStocks.Rows.Count > 0;
				if (flag)
				{
					this.SaveFileDialog1.Filter = "EXCEL FILES (*.xls*) | *.xls";
					bool flag2 = this.SaveFileDialog1.ShowDialog() == DialogResult.OK;
					if (flag2)
					{
						this.Cursor = Cursors.WaitCursor;
						this.DATAGRIDVIEW_TO_EXCEL(this.dgvStocks, this.SaveFileDialog1.FileName);
						MessageBox.Show("Data exported to excel and saved to: " + this.SaveFileDialog1.FileName);
						this.Cursor = Cursors.Default;
					}
					else
					{
						MessageBox.Show("No file name chosen.");
					}
				}
				else
				{
					MessageBox.Show("There are no rows to export.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error exporting. Detail: " + ex.Message);
			}
		}

		// Token: 0x060054BA RID: 21690 RVA: 0x00310E70 File Offset: 0x0030F070
		private void DATAGRIDVIEW_TO_EXCEL(DataGridView DGV, string filesavepath)
		{
			checked
			{
				try
				{
					this.ProgressBar1.Visible = true;
					this.ProgressBar1.Minimum = 0;
					this.ProgressBar1.Maximum = DGV.RowCount + DGV.ColumnCount;
					this.ProgressBar1.Increment(1);
					this.ProgressBar1.Step = 1;
					DataTable dataTable = new DataTable();
					int num = DGV.ColumnCount - 1;
					for (int i = 0; i <= num; i++)
					{
						dataTable.Columns.Add(DGV.Columns[i].Name.ToString());
					}
					int num2 = DGV.Rows.Count - 1;
					for (int j = 0; j <= num2; j++)
					{
						DataRow dataRow = dataTable.NewRow();
						this.ProgressBar1.PerformStep();
						int num3 = DGV.ColumnCount - 1;
						for (int i = 0; i <= num3; i++)
						{
							try
							{
								dataRow[dataTable.Columns[i].ColumnName.ToString()] = DGV.Rows[j].Cells[i].Value.ToString();
								this.ProgressBar1.PerformStep();
							}
							catch (Exception ex)
							{
							}
						}
						dataTable.Rows.Add(dataRow);
					}
					dataTable.AcceptChanges();
					DataSet dataSet = new DataSet();
					dataSet.Tables.Add(dataTable);
					dataTable.WriteXml(filesavepath);
					this.ProgressBar1.PerformStep();
					this.ProgressBar1.Visible = false;
				}
				catch (Exception ex2)
				{
					Interaction.MsgBox(ex2.ToString(), MsgBoxStyle.OkOnly, null);
				}
			}
		}

		// Token: 0x040024F9 RID: 9465
		private string _cnn;

		// Token: 0x040024FA RID: 9466
		private DataTable datStockAging;

		// Token: 0x040024FB RID: 9467
		private DataTable dat;
	}
}
