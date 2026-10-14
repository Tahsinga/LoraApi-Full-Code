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
	// Token: 0x020001E5 RID: 485
	[DesignerGenerated]
	public partial class StockBalancesByCategory : UserControl
	{
		// Token: 0x0600551B RID: 21787 RVA: 0x00313BA4 File Offset: 0x00311DA4
		public StockBalancesByCategory()
		{
			base.Load += this.StockBalancesByCategory_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pfunctions = new PublicFunctions();
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x17001E90 RID: 7824
		// (get) Token: 0x0600551E RID: 21790 RVA: 0x00314C28 File Offset: 0x00312E28
		// (set) Token: 0x0600551F RID: 21791 RVA: 0x00314C32 File Offset: 0x00312E32
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E91 RID: 7825
		// (get) Token: 0x06005520 RID: 21792 RVA: 0x00314C3B File Offset: 0x00312E3B
		// (set) Token: 0x06005521 RID: 21793 RVA: 0x00314C45 File Offset: 0x00312E45
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E92 RID: 7826
		// (get) Token: 0x06005522 RID: 21794 RVA: 0x00314C4E File Offset: 0x00312E4E
		// (set) Token: 0x06005523 RID: 21795 RVA: 0x00314C58 File Offset: 0x00312E58
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

		// Token: 0x17001E93 RID: 7827
		// (get) Token: 0x06005524 RID: 21796 RVA: 0x00314C9B File Offset: 0x00312E9B
		// (set) Token: 0x06005525 RID: 21797 RVA: 0x00314CA5 File Offset: 0x00312EA5
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E94 RID: 7828
		// (get) Token: 0x06005526 RID: 21798 RVA: 0x00314CAE File Offset: 0x00312EAE
		// (set) Token: 0x06005527 RID: 21799 RVA: 0x00314CB8 File Offset: 0x00312EB8
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

		// Token: 0x17001E95 RID: 7829
		// (get) Token: 0x06005528 RID: 21800 RVA: 0x00314D16 File Offset: 0x00312F16
		// (set) Token: 0x06005529 RID: 21801 RVA: 0x00314D20 File Offset: 0x00312F20
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E96 RID: 7830
		// (get) Token: 0x0600552A RID: 21802 RVA: 0x00314D29 File Offset: 0x00312F29
		// (set) Token: 0x0600552B RID: 21803 RVA: 0x00314D34 File Offset: 0x00312F34
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

		// Token: 0x17001E97 RID: 7831
		// (get) Token: 0x0600552C RID: 21804 RVA: 0x00314D77 File Offset: 0x00312F77
		// (set) Token: 0x0600552D RID: 21805 RVA: 0x00314D81 File Offset: 0x00312F81
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E98 RID: 7832
		// (get) Token: 0x0600552E RID: 21806 RVA: 0x00314D8A File Offset: 0x00312F8A
		// (set) Token: 0x0600552F RID: 21807 RVA: 0x00314D94 File Offset: 0x00312F94
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

		// Token: 0x17001E99 RID: 7833
		// (get) Token: 0x06005530 RID: 21808 RVA: 0x00314DD7 File Offset: 0x00312FD7
		// (set) Token: 0x06005531 RID: 21809 RVA: 0x00314DE1 File Offset: 0x00312FE1
		internal virtual Label lblValue
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E9A RID: 7834
		// (get) Token: 0x06005532 RID: 21810 RVA: 0x00314DEA File Offset: 0x00312FEA
		// (set) Token: 0x06005533 RID: 21811 RVA: 0x00314DF4 File Offset: 0x00312FF4
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E9B RID: 7835
		// (get) Token: 0x06005534 RID: 21812 RVA: 0x00314DFD File Offset: 0x00312FFD
		// (set) Token: 0x06005535 RID: 21813 RVA: 0x00314E07 File Offset: 0x00313007
		internal virtual Label lblCost
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E9C RID: 7836
		// (get) Token: 0x06005536 RID: 21814 RVA: 0x00314E10 File Offset: 0x00313010
		// (set) Token: 0x06005537 RID: 21815 RVA: 0x00314E1A File Offset: 0x0031301A
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E9D RID: 7837
		// (get) Token: 0x06005538 RID: 21816 RVA: 0x00314E23 File Offset: 0x00313023
		// (set) Token: 0x06005539 RID: 21817 RVA: 0x00314E2D File Offset: 0x0031302D
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E9E RID: 7838
		// (get) Token: 0x0600553A RID: 21818 RVA: 0x00314E36 File Offset: 0x00313036
		// (set) Token: 0x0600553B RID: 21819 RVA: 0x00314E40 File Offset: 0x00313040
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E9F RID: 7839
		// (get) Token: 0x0600553C RID: 21820 RVA: 0x00314E49 File Offset: 0x00313049
		// (set) Token: 0x0600553D RID: 21821 RVA: 0x00314E54 File Offset: 0x00313054
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

		// Token: 0x17001EA0 RID: 7840
		// (get) Token: 0x0600553E RID: 21822 RVA: 0x00314E97 File Offset: 0x00313097
		// (set) Token: 0x0600553F RID: 21823 RVA: 0x00314EA1 File Offset: 0x003130A1
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001EA1 RID: 7841
		// (get) Token: 0x06005540 RID: 21824 RVA: 0x00314EAA File Offset: 0x003130AA
		// (set) Token: 0x06005541 RID: 21825 RVA: 0x00314EB4 File Offset: 0x003130B4
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

		// Token: 0x17001EA2 RID: 7842
		// (get) Token: 0x06005542 RID: 21826 RVA: 0x00314EF7 File Offset: 0x003130F7
		// (set) Token: 0x06005543 RID: 21827 RVA: 0x00314F01 File Offset: 0x00313101
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001EA3 RID: 7843
		// (get) Token: 0x06005544 RID: 21828 RVA: 0x00314F0A File Offset: 0x0031310A
		// (set) Token: 0x06005545 RID: 21829 RVA: 0x00314F14 File Offset: 0x00313114
		internal virtual ComboBox cboCategory
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001EA4 RID: 7844
		// (get) Token: 0x06005546 RID: 21830 RVA: 0x00314F1D File Offset: 0x0031311D
		// (set) Token: 0x06005547 RID: 21831 RVA: 0x00314F28 File Offset: 0x00313128
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

		// Token: 0x17001EA5 RID: 7845
		// (get) Token: 0x06005548 RID: 21832 RVA: 0x00314F6B File Offset: 0x0031316B
		// (set) Token: 0x06005549 RID: 21833 RVA: 0x00314F75 File Offset: 0x00313175
		internal virtual Label lblprodcount
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001EA6 RID: 7846
		// (get) Token: 0x0600554A RID: 21834 RVA: 0x00314F7E File Offset: 0x0031317E
		// (set) Token: 0x0600554B RID: 21835 RVA: 0x00314F88 File Offset: 0x00313188
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001EA7 RID: 7847
		// (get) Token: 0x0600554C RID: 21836 RVA: 0x00314F91 File Offset: 0x00313191
		// (set) Token: 0x0600554D RID: 21837 RVA: 0x00314F9C File Offset: 0x0031319C
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

		// Token: 0x17001EA8 RID: 7848
		// (get) Token: 0x0600554E RID: 21838 RVA: 0x00314FDF File Offset: 0x003131DF
		// (set) Token: 0x0600554F RID: 21839 RVA: 0x00314FE9 File Offset: 0x003131E9
		internal virtual SaveFileDialog SaveFileDialog1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06005550 RID: 21840 RVA: 0x00314FF4 File Offset: 0x003131F4
		private void LoadLevels(int catid)
		{
			this.dgvproducts.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "CurrentStockLevelsCategory";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			sqlCommand.Parameters.AddWithValue("catid", catid);
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
			this.dgvproducts.Columns["ProductDesc2"].HeaderText = "Description";
			this.dgvproducts.Columns["ReorderLevel"].HeaderText = "Reorder Level";
			this.dgvproducts.Columns["StockBalance"].HeaderText = "Current Balance";
			this.lblprodcount.Text = this.dgvproducts.RowCount.ToString();
		}

		// Token: 0x06005551 RID: 21841 RVA: 0x00315228 File Offset: 0x00313428
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

		// Token: 0x06005552 RID: 21842 RVA: 0x0031536C File Offset: 0x0031356C
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.LoadLevels(Convert.ToInt32(RuntimeHelpers.GetObjectValue(this.cboCategory.SelectedValue)));
				this.CalcStockValue();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading stock balances. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005553 RID: 21843 RVA: 0x003153D8 File Offset: 0x003135D8
		private void dgvproducts_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
		{
			checked
			{
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvproducts.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						int num = (int)Math.Round(unchecked(Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["StockBalance"].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ReorderLevel"].Value))));
						bool flag = num <= 0;
						if (flag)
						{
							dataGridViewRow.DefaultCellStyle.BackColor = Color.Yellow;
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
		}

		// Token: 0x06005554 RID: 21844 RVA: 0x003154A0 File Offset: 0x003136A0
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

		// Token: 0x06005555 RID: 21845 RVA: 0x00315584 File Offset: 0x00313784
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

		// Token: 0x06005556 RID: 21846 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label3_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06005557 RID: 21847 RVA: 0x00315678 File Offset: 0x00313878
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

		// Token: 0x06005558 RID: 21848 RVA: 0x003156D8 File Offset: 0x003138D8
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

		// Token: 0x06005559 RID: 21849 RVA: 0x003157D4 File Offset: 0x003139D4
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

		// Token: 0x0600555A RID: 21850 RVA: 0x00315894 File Offset: 0x00313A94
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

		// Token: 0x0600555B RID: 21851 RVA: 0x00315A34 File Offset: 0x00313C34
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

		// Token: 0x0600555C RID: 21852 RVA: 0x00315A94 File Offset: 0x00313C94
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

		// Token: 0x0600555D RID: 21853 RVA: 0x00315B8C File Offset: 0x00313D8C
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

		// Token: 0x0600555E RID: 21854 RVA: 0x00315BF8 File Offset: 0x00313DF8
		private void StockBalancesByCategory_Load(object sender, EventArgs e)
		{
			try
			{
				this.cboCategory.DataSource = this.pfunctions.LoadCategories(this._cnn);
				this.cboCategory.DisplayMember = "CatDesc";
				this.cboCategory.ValueMember = "CatID";
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600555F RID: 21855 RVA: 0x00315C80 File Offset: 0x00313E80
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

		// Token: 0x04002543 RID: 9539
		private string _cnn;

		// Token: 0x04002544 RID: 9540
		private PublicFunctions pfunctions;

		// Token: 0x04002545 RID: 9541
		private PublicFunctions pf;
	}
}
