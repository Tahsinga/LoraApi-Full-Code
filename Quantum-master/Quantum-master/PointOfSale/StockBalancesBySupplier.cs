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
	// Token: 0x020001E6 RID: 486
	[DesignerGenerated]
	public partial class StockBalancesBySupplier : UserControl
	{
		// Token: 0x06005560 RID: 21856 RVA: 0x00315D38 File Offset: 0x00313F38
		public StockBalancesBySupplier()
		{
			base.Load += this.StockBalancesByCategory_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pfunctions = new PublicFunctions();
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x17001EA9 RID: 7849
		// (get) Token: 0x06005563 RID: 21859 RVA: 0x00316FF4 File Offset: 0x003151F4
		// (set) Token: 0x06005564 RID: 21860 RVA: 0x00316FFE File Offset: 0x003151FE
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001EAA RID: 7850
		// (get) Token: 0x06005565 RID: 21861 RVA: 0x00317007 File Offset: 0x00315207
		// (set) Token: 0x06005566 RID: 21862 RVA: 0x00317014 File Offset: 0x00315214
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

		// Token: 0x17001EAB RID: 7851
		// (get) Token: 0x06005567 RID: 21863 RVA: 0x00317057 File Offset: 0x00315257
		// (set) Token: 0x06005568 RID: 21864 RVA: 0x00317061 File Offset: 0x00315261
		internal virtual Label lblprodcount
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001EAC RID: 7852
		// (get) Token: 0x06005569 RID: 21865 RVA: 0x0031706A File Offset: 0x0031526A
		// (set) Token: 0x0600556A RID: 21866 RVA: 0x00317074 File Offset: 0x00315274
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001EAD RID: 7853
		// (get) Token: 0x0600556B RID: 21867 RVA: 0x0031707D File Offset: 0x0031527D
		// (set) Token: 0x0600556C RID: 21868 RVA: 0x00317088 File Offset: 0x00315288
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

		// Token: 0x17001EAE RID: 7854
		// (get) Token: 0x0600556D RID: 21869 RVA: 0x003170CB File Offset: 0x003152CB
		// (set) Token: 0x0600556E RID: 21870 RVA: 0x003170D5 File Offset: 0x003152D5
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001EAF RID: 7855
		// (get) Token: 0x0600556F RID: 21871 RVA: 0x003170DE File Offset: 0x003152DE
		// (set) Token: 0x06005570 RID: 21872 RVA: 0x003170E8 File Offset: 0x003152E8
		internal virtual ComboBox cboSupplier
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001EB0 RID: 7856
		// (get) Token: 0x06005571 RID: 21873 RVA: 0x003170F1 File Offset: 0x003152F1
		// (set) Token: 0x06005572 RID: 21874 RVA: 0x003170FB File Offset: 0x003152FB
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001EB1 RID: 7857
		// (get) Token: 0x06005573 RID: 21875 RVA: 0x00317104 File Offset: 0x00315304
		// (set) Token: 0x06005574 RID: 21876 RVA: 0x00317110 File Offset: 0x00315310
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

		// Token: 0x17001EB2 RID: 7858
		// (get) Token: 0x06005575 RID: 21877 RVA: 0x00317153 File Offset: 0x00315353
		// (set) Token: 0x06005576 RID: 21878 RVA: 0x0031715D File Offset: 0x0031535D
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001EB3 RID: 7859
		// (get) Token: 0x06005577 RID: 21879 RVA: 0x00317166 File Offset: 0x00315366
		// (set) Token: 0x06005578 RID: 21880 RVA: 0x00317170 File Offset: 0x00315370
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

		// Token: 0x17001EB4 RID: 7860
		// (get) Token: 0x06005579 RID: 21881 RVA: 0x003171CE File Offset: 0x003153CE
		// (set) Token: 0x0600557A RID: 21882 RVA: 0x003171D8 File Offset: 0x003153D8
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001EB5 RID: 7861
		// (get) Token: 0x0600557B RID: 21883 RVA: 0x003171E1 File Offset: 0x003153E1
		// (set) Token: 0x0600557C RID: 21884 RVA: 0x003171EC File Offset: 0x003153EC
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

		// Token: 0x17001EB6 RID: 7862
		// (get) Token: 0x0600557D RID: 21885 RVA: 0x0031722F File Offset: 0x0031542F
		// (set) Token: 0x0600557E RID: 21886 RVA: 0x00317239 File Offset: 0x00315439
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001EB7 RID: 7863
		// (get) Token: 0x0600557F RID: 21887 RVA: 0x00317242 File Offset: 0x00315442
		// (set) Token: 0x06005580 RID: 21888 RVA: 0x0031724C File Offset: 0x0031544C
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

		// Token: 0x17001EB8 RID: 7864
		// (get) Token: 0x06005581 RID: 21889 RVA: 0x0031728F File Offset: 0x0031548F
		// (set) Token: 0x06005582 RID: 21890 RVA: 0x00317299 File Offset: 0x00315499
		internal virtual Label lblValue
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001EB9 RID: 7865
		// (get) Token: 0x06005583 RID: 21891 RVA: 0x003172A2 File Offset: 0x003154A2
		// (set) Token: 0x06005584 RID: 21892 RVA: 0x003172AC File Offset: 0x003154AC
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001EBA RID: 7866
		// (get) Token: 0x06005585 RID: 21893 RVA: 0x003172B5 File Offset: 0x003154B5
		// (set) Token: 0x06005586 RID: 21894 RVA: 0x003172BF File Offset: 0x003154BF
		internal virtual Label lblCost
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001EBB RID: 7867
		// (get) Token: 0x06005587 RID: 21895 RVA: 0x003172C8 File Offset: 0x003154C8
		// (set) Token: 0x06005588 RID: 21896 RVA: 0x003172D2 File Offset: 0x003154D2
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001EBC RID: 7868
		// (get) Token: 0x06005589 RID: 21897 RVA: 0x003172DB File Offset: 0x003154DB
		// (set) Token: 0x0600558A RID: 21898 RVA: 0x003172E5 File Offset: 0x003154E5
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001EBD RID: 7869
		// (get) Token: 0x0600558B RID: 21899 RVA: 0x003172EE File Offset: 0x003154EE
		// (set) Token: 0x0600558C RID: 21900 RVA: 0x003172F8 File Offset: 0x003154F8
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001EBE RID: 7870
		// (get) Token: 0x0600558D RID: 21901 RVA: 0x00317301 File Offset: 0x00315501
		// (set) Token: 0x0600558E RID: 21902 RVA: 0x0031730C File Offset: 0x0031550C
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

		// Token: 0x17001EBF RID: 7871
		// (get) Token: 0x0600558F RID: 21903 RVA: 0x0031734F File Offset: 0x0031554F
		// (set) Token: 0x06005590 RID: 21904 RVA: 0x00317359 File Offset: 0x00315559
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001EC0 RID: 7872
		// (get) Token: 0x06005591 RID: 21905 RVA: 0x00317362 File Offset: 0x00315562
		// (set) Token: 0x06005592 RID: 21906 RVA: 0x0031736C File Offset: 0x0031556C
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

		// Token: 0x17001EC1 RID: 7873
		// (get) Token: 0x06005593 RID: 21907 RVA: 0x003173AF File Offset: 0x003155AF
		// (set) Token: 0x06005594 RID: 21908 RVA: 0x003173B9 File Offset: 0x003155B9
		internal virtual SaveFileDialog SaveFileDialog1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06005595 RID: 21909 RVA: 0x003173C4 File Offset: 0x003155C4
		private void LoadLevels(int supplierID)
		{
			this.dgvproducts.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "CurrentStockLevelsBySupplier";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			sqlCommand.Parameters.AddWithValue("supplierid", supplierID);
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

		// Token: 0x06005596 RID: 21910 RVA: 0x003175F8 File Offset: 0x003157F8
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

		// Token: 0x06005597 RID: 21911 RVA: 0x0031773C File Offset: 0x0031593C
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.LoadLevels(Convert.ToInt32(RuntimeHelpers.GetObjectValue(this.cboSupplier.SelectedValue)));
				this.CalcStockValue();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading stock balances. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005598 RID: 21912 RVA: 0x003177A8 File Offset: 0x003159A8
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

		// Token: 0x06005599 RID: 21913 RVA: 0x00317870 File Offset: 0x00315A70
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

		// Token: 0x0600559A RID: 21914 RVA: 0x00317954 File Offset: 0x00315B54
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

		// Token: 0x0600559B RID: 21915 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label3_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x0600559C RID: 21916 RVA: 0x00317A48 File Offset: 0x00315C48
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

		// Token: 0x0600559D RID: 21917 RVA: 0x00317AA8 File Offset: 0x00315CA8
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

		// Token: 0x0600559E RID: 21918 RVA: 0x00317B98 File Offset: 0x00315D98
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

		// Token: 0x0600559F RID: 21919 RVA: 0x00317C58 File Offset: 0x00315E58
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

		// Token: 0x060055A0 RID: 21920 RVA: 0x00317DF8 File Offset: 0x00315FF8
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

		// Token: 0x060055A1 RID: 21921 RVA: 0x00317E58 File Offset: 0x00316058
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

		// Token: 0x060055A2 RID: 21922 RVA: 0x00317F50 File Offset: 0x00316150
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

		// Token: 0x060055A3 RID: 21923 RVA: 0x00317FBC File Offset: 0x003161BC
		private void StockBalancesByCategory_Load(object sender, EventArgs e)
		{
			try
			{
				this.cboSupplier.DataSource = this.pf.GetSuppliersList(this._cnn);
				this.cboSupplier.ValueMember = "supplierid";
				this.cboSupplier.DisplayMember = "SupplierName";
				this.cboSupplier.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
				this.cboSupplier.AutoCompleteSource = AutoCompleteSource.ListItems;
				this.cboSupplier.SelectedIndex = -1;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x060055A4 RID: 21924 RVA: 0x00318070 File Offset: 0x00316270
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

		// Token: 0x04002560 RID: 9568
		private string _cnn;

		// Token: 0x04002561 RID: 9569
		private PublicFunctions pfunctions;

		// Token: 0x04002562 RID: 9570
		private PublicFunctions pf;
	}
}
