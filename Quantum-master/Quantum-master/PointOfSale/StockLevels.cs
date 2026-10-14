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
	// Token: 0x020001E9 RID: 489
	[DesignerGenerated]
	public partial class StockLevels : UserControl
	{
		// Token: 0x0600562E RID: 22062 RVA: 0x0031C434 File Offset: 0x0031A634
		public StockLevels()
		{
			base.Load += this.StockLevels_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x17001EF3 RID: 7923
		// (get) Token: 0x06005631 RID: 22065 RVA: 0x0031D74D File Offset: 0x0031B94D
		// (set) Token: 0x06005632 RID: 22066 RVA: 0x0031D757 File Offset: 0x0031B957
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001EF4 RID: 7924
		// (get) Token: 0x06005633 RID: 22067 RVA: 0x0031D760 File Offset: 0x0031B960
		// (set) Token: 0x06005634 RID: 22068 RVA: 0x0031D76C File Offset: 0x0031B96C
		internal virtual DataGridView dgvproducts
		{
			[CompilerGenerated]
			get
			{
				return this._dgvproducts;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewRowPostPaintEventHandler dataGridViewRowPostPaintEventHandler = new DataGridViewRowPostPaintEventHandler(this.dgvproducts_RowPostPaint);
				DataGridView dataGridView = this._dgvproducts;
				if (dataGridView != null)
				{
					dataGridView.RowPostPaint -= dataGridViewRowPostPaintEventHandler;
				}
				this._dgvproducts = value;
				dataGridView = this._dgvproducts;
				if (dataGridView != null)
				{
					dataGridView.RowPostPaint += dataGridViewRowPostPaintEventHandler;
				}
			}
		}

		// Token: 0x17001EF5 RID: 7925
		// (get) Token: 0x06005635 RID: 22069 RVA: 0x0031D7AF File Offset: 0x0031B9AF
		// (set) Token: 0x06005636 RID: 22070 RVA: 0x0031D7B9 File Offset: 0x0031B9B9
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001EF6 RID: 7926
		// (get) Token: 0x06005637 RID: 22071 RVA: 0x0031D7C2 File Offset: 0x0031B9C2
		// (set) Token: 0x06005638 RID: 22072 RVA: 0x0031D7CC File Offset: 0x0031B9CC
		internal virtual Label Label3
		{
			[CompilerGenerated]
			get
			{
				return this._Label3;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label3_Click);
				Label label = this._Label3;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label3 = value;
				label = this._Label3;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x17001EF7 RID: 7927
		// (get) Token: 0x06005639 RID: 22073 RVA: 0x0031D80F File Offset: 0x0031BA0F
		// (set) Token: 0x0600563A RID: 22074 RVA: 0x0031D819 File Offset: 0x0031BA19
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001EF8 RID: 7928
		// (get) Token: 0x0600563B RID: 22075 RVA: 0x0031D822 File Offset: 0x0031BA22
		// (set) Token: 0x0600563C RID: 22076 RVA: 0x0031D82C File Offset: 0x0031BA2C
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001EF9 RID: 7929
		// (get) Token: 0x0600563D RID: 22077 RVA: 0x0031D835 File Offset: 0x0031BA35
		// (set) Token: 0x0600563E RID: 22078 RVA: 0x0031D83F File Offset: 0x0031BA3F
		internal virtual Label lblValue
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001EFA RID: 7930
		// (get) Token: 0x0600563F RID: 22079 RVA: 0x0031D848 File Offset: 0x0031BA48
		// (set) Token: 0x06005640 RID: 22080 RVA: 0x0031D852 File Offset: 0x0031BA52
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001EFB RID: 7931
		// (get) Token: 0x06005641 RID: 22081 RVA: 0x0031D85B File Offset: 0x0031BA5B
		// (set) Token: 0x06005642 RID: 22082 RVA: 0x0031D865 File Offset: 0x0031BA65
		internal virtual Label lblCost
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001EFC RID: 7932
		// (get) Token: 0x06005643 RID: 22083 RVA: 0x0031D86E File Offset: 0x0031BA6E
		// (set) Token: 0x06005644 RID: 22084 RVA: 0x0031D878 File Offset: 0x0031BA78
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001EFD RID: 7933
		// (get) Token: 0x06005645 RID: 22085 RVA: 0x0031D881 File Offset: 0x0031BA81
		// (set) Token: 0x06005646 RID: 22086 RVA: 0x0031D88B File Offset: 0x0031BA8B
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001EFE RID: 7934
		// (get) Token: 0x06005647 RID: 22087 RVA: 0x0031D894 File Offset: 0x0031BA94
		// (set) Token: 0x06005648 RID: 22088 RVA: 0x0031D8A0 File Offset: 0x0031BAA0
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

		// Token: 0x17001EFF RID: 7935
		// (get) Token: 0x06005649 RID: 22089 RVA: 0x0031D8FE File Offset: 0x0031BAFE
		// (set) Token: 0x0600564A RID: 22090 RVA: 0x0031D908 File Offset: 0x0031BB08
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F00 RID: 7936
		// (get) Token: 0x0600564B RID: 22091 RVA: 0x0031D911 File Offset: 0x0031BB11
		// (set) Token: 0x0600564C RID: 22092 RVA: 0x0031D91C File Offset: 0x0031BB1C
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

		// Token: 0x17001F01 RID: 7937
		// (get) Token: 0x0600564D RID: 22093 RVA: 0x0031D95F File Offset: 0x0031BB5F
		// (set) Token: 0x0600564E RID: 22094 RVA: 0x0031D969 File Offset: 0x0031BB69
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F02 RID: 7938
		// (get) Token: 0x0600564F RID: 22095 RVA: 0x0031D972 File Offset: 0x0031BB72
		// (set) Token: 0x06005650 RID: 22096 RVA: 0x0031D97C File Offset: 0x0031BB7C
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

		// Token: 0x17001F03 RID: 7939
		// (get) Token: 0x06005651 RID: 22097 RVA: 0x0031D9BF File Offset: 0x0031BBBF
		// (set) Token: 0x06005652 RID: 22098 RVA: 0x0031D9CC File Offset: 0x0031BBCC
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

		// Token: 0x17001F04 RID: 7940
		// (get) Token: 0x06005653 RID: 22099 RVA: 0x0031DA0F File Offset: 0x0031BC0F
		// (set) Token: 0x06005654 RID: 22100 RVA: 0x0031DA19 File Offset: 0x0031BC19
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F05 RID: 7941
		// (get) Token: 0x06005655 RID: 22101 RVA: 0x0031DA22 File Offset: 0x0031BC22
		// (set) Token: 0x06005656 RID: 22102 RVA: 0x0031DA2C File Offset: 0x0031BC2C
		internal virtual Label lblprodcount
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F06 RID: 7942
		// (get) Token: 0x06005657 RID: 22103 RVA: 0x0031DA35 File Offset: 0x0031BC35
		// (set) Token: 0x06005658 RID: 22104 RVA: 0x0031DA3F File Offset: 0x0031BC3F
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F07 RID: 7943
		// (get) Token: 0x06005659 RID: 22105 RVA: 0x0031DA48 File Offset: 0x0031BC48
		// (set) Token: 0x0600565A RID: 22106 RVA: 0x0031DA52 File Offset: 0x0031BC52
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F08 RID: 7944
		// (get) Token: 0x0600565B RID: 22107 RVA: 0x0031DA5B File Offset: 0x0031BC5B
		// (set) Token: 0x0600565C RID: 22108 RVA: 0x0031DA65 File Offset: 0x0031BC65
		internal virtual Label Label9
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F09 RID: 7945
		// (get) Token: 0x0600565D RID: 22109 RVA: 0x0031DA6E File Offset: 0x0031BC6E
		// (set) Token: 0x0600565E RID: 22110 RVA: 0x0031DA78 File Offset: 0x0031BC78
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

		// Token: 0x17001F0A RID: 7946
		// (get) Token: 0x0600565F RID: 22111 RVA: 0x0031DABB File Offset: 0x0031BCBB
		// (set) Token: 0x06005660 RID: 22112 RVA: 0x0031DAC5 File Offset: 0x0031BCC5
		internal virtual SaveFileDialog SaveFileDialog1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F0B RID: 7947
		// (get) Token: 0x06005661 RID: 22113 RVA: 0x0031DACE File Offset: 0x0031BCCE
		// (set) Token: 0x06005662 RID: 22114 RVA: 0x0031DAD8 File Offset: 0x0031BCD8
		internal virtual Label Label10
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06005663 RID: 22115 RVA: 0x0031DAE4 File Offset: 0x0031BCE4
		private void LoadLevels()
		{
			this.dgvproducts.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "CurrentStockLevels";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			sqlCommand.Parameters.AddWithValue("username", MyProject.Forms.Form1.username);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			this.dgvproducts.DataSource = dataTable;
			this.dgvproducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			bool flag = Operators.CompareString(MyProject.Forms.Form1.BusType, "Tuckshop", false) == 0;
			if (flag)
			{
				this.dgvproducts.Columns["ProductCode"].Visible = false;
			}
			else
			{
				bool flag2 = Operators.CompareString(MyProject.Forms.Form1.BusType, "Parts", false) == 0;
				if (flag2)
				{
					this.dgvproducts.Columns["ProductID"].Visible = false;
				}
			}
			this.dgvproducts.Columns["ProductID"].HeaderText = "Product ID";
			this.dgvproducts.Columns["ProductCode"].HeaderText = "Product Code";
			this.dgvproducts.Columns["ProductDesc"].HeaderText = "Description";
			this.dgvproducts.Columns["ProductDesc2"].HeaderText = "Alt Description";
			this.dgvproducts.Columns["ReorderLevel"].HeaderText = "Reorder Level";
			this.dgvproducts.Columns["StockBalance"].HeaderText = "Current Balance";
			this.lblprodcount.Text = this.dgvproducts.RowCount.ToString();
		}

		// Token: 0x06005664 RID: 22116 RVA: 0x0031DD24 File Offset: 0x0031BF24
		private void StockLevels_Load(object sender, EventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
				this.LoadLevels();
				this.CalcStockValue();
				this.Cursor = Cursors.Default;
			}
			catch (Exception ex)
			{
				MessageBox.Show("error displaying form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005665 RID: 22117 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label3_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06005666 RID: 22118 RVA: 0x0031DD94 File Offset: 0x0031BF94
		private void dgvproducts_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
		{
			try
			{
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvproducts.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						bool flag = (Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["StockBalance"].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ReorderLevel"].Value)) < 0.0) & (Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["StockBalance"].Value)) >= 0.0);
						if (flag)
						{
							dataGridViewRow.DefaultCellStyle.BackColor = Color.Yellow;
						}
						else
						{
							bool flag2 = Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["StockBalance"].Value)) < 0.0;
							if (flag2)
							{
								dataGridViewRow.DefaultCellStyle.BackColor = Color.Red;
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
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06005667 RID: 22119 RVA: 0x0031DF04 File Offset: 0x0031C104
		private double CostofProduct(int prodid, int coid)
		{
			double num = 0.0;
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "CostofProduct";
			sqlCommand.Parameters.AddWithValue("productid", prodid);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			int num2 = sqlDataAdapter.Fill(dataTable);
			bool flag = num2 > 0;
			double num3;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				num = Conversions.ToDouble(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["cost"])), 0, RuntimeHelpers.GetObjectValue(dataRow["cost"])));
				num3 = num;
			}
			else
			{
				num3 = num;
			}
			return num3;
		}

		// Token: 0x06005668 RID: 22120 RVA: 0x0031DFE8 File Offset: 0x0031C1E8
		private double PriceofProduct(int prodid)
		{
			double num = 0.0;
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SalePriceofProduct";
			sqlCommand.Parameters.AddWithValue("productid", prodid);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			int num2 = sqlDataAdapter.Fill(dataTable);
			bool flag = num2 > 0;
			double num3;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				num = Conversions.ToDouble(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["SellingPrice"])), 0, RuntimeHelpers.GetObjectValue(dataRow["SellingPrice"])));
				num3 = num;
			}
			else
			{
				num3 = num;
			}
			return num3;
		}

		// Token: 0x06005669 RID: 22121 RVA: 0x0031E0DC File Offset: 0x0031C2DC
		private void CalcStockValue()
		{
			double num = 0.0;
			double num2 = 0.0;
			try
			{
				foreach (object obj in ((IEnumerable)this.dgvproducts.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					int num3 = Conversions.ToInteger(dataGridViewRow.Cells["ProductID"].Value);
					int num4 = Conversions.ToInteger(dataGridViewRow.Cells["StockBalance"].Value);
					double num5 = this.CostofProduct(num3, MyProject.Forms.Form1.coid);
					double num6 = this.PriceofProduct(num3);
					num += (double)num4 * num5;
					num2 += (double)num4 * num6;
					bool flag = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["UOM"].Value, "EA", false);
					if (flag)
					{
						dataGridViewRow.Cells["StockBalance"].Value = Conversions.ToInteger(dataGridViewRow.Cells["StockBalance"].Value);
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
			num = Math.Round(num, 2);
			num2 = Math.Round(num2, 2);
			this.lblCost.Text = MyProject.Forms.Form1.basecurrency + num.ToString();
			this.lblValue.Text = MyProject.Forms.Form1.basecurrency + num2.ToString();
		}

		// Token: 0x0600566A RID: 22122 RVA: 0x0031E280 File Offset: 0x0031C480
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

		// Token: 0x0600566B RID: 22123 RVA: 0x0031E2E0 File Offset: 0x0031C4E0
		private void txtProductCode_TextChanged(object sender, EventArgs e)
		{
			try
			{
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvproducts.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						bool flag = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["ProductCode"].Value, this.txtProductCode.Text, false);
						if (flag)
						{
							this.dgvproducts.ClearSelection();
							dataGridViewRow.Cells["ProductCode"].Selected = true;
							this.dgvproducts.CurrentCell = dataGridViewRow.Cells["ProductCode"];
							dataGridViewRow.Selected = true;
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

		// Token: 0x0600566C RID: 22124 RVA: 0x0031E3DC File Offset: 0x0031C5DC
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

		// Token: 0x0600566D RID: 22125 RVA: 0x0031E49C File Offset: 0x0031C69C
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

		// Token: 0x0600566E RID: 22126 RVA: 0x0031E63C File Offset: 0x0031C83C
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

		// Token: 0x0600566F RID: 22127 RVA: 0x0031E69C File Offset: 0x0031C89C
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

		// Token: 0x06005670 RID: 22128 RVA: 0x0031E794 File Offset: 0x0031C994
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

		// Token: 0x06005671 RID: 22129 RVA: 0x0031E800 File Offset: 0x0031CA00
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.dgvproducts.RowCount > 0;
				if (flag)
				{
					this.SaveFileDialog1.Filter = "EXCEL Files (*.csv*)|*.csv";
					bool flag2 = this.SaveFileDialog1.ShowDialog() == DialogResult.OK;
					if (flag2)
					{
						this.pf.DATAGRIDVIEW_TO_CSV(this.dgvproducts, this.SaveFileDialog1.FileName);
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

		// Token: 0x040025B5 RID: 9653
		private string _cnn;

		// Token: 0x040025B6 RID: 9654
		private PublicFunctions pf;
	}
}
