using System;
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
	// Token: 0x02000088 RID: 136
	[DesignerGenerated]
	public partial class PaymentMethodDiscount : UserControl
	{
		// Token: 0x06001F15 RID: 7957 RVA: 0x0011538C File Offset: 0x0011358C
		public PaymentMethodDiscount()
		{
			base.Load += this.PaymentMethodDiscount_Load;
			this.CurrentID = 0;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.priceb4tax = 0m;
			this.priceb4taxWholesale = 0m;
			this.InitializeComponent();
		}

		// Token: 0x17000B61 RID: 2913
		// (get) Token: 0x06001F18 RID: 7960 RVA: 0x00116335 File Offset: 0x00114535
		// (set) Token: 0x06001F19 RID: 7961 RVA: 0x0011633F File Offset: 0x0011453F
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B62 RID: 2914
		// (get) Token: 0x06001F1A RID: 7962 RVA: 0x00116348 File Offset: 0x00114548
		// (set) Token: 0x06001F1B RID: 7963 RVA: 0x00116354 File Offset: 0x00114554
		internal virtual DataGridView dgvDiscounts
		{
			[CompilerGenerated]
			get
			{
				return this._dgvDiscounts;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgvDiscounts_CellContentClick);
				DataGridView dataGridView = this._dgvDiscounts;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick -= dataGridViewCellEventHandler;
				}
				this._dgvDiscounts = value;
				dataGridView = this._dgvDiscounts;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x17000B63 RID: 2915
		// (get) Token: 0x06001F1C RID: 7964 RVA: 0x00116397 File Offset: 0x00114597
		// (set) Token: 0x06001F1D RID: 7965 RVA: 0x001163A1 File Offset: 0x001145A1
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B64 RID: 2916
		// (get) Token: 0x06001F1E RID: 7966 RVA: 0x001163AA File Offset: 0x001145AA
		// (set) Token: 0x06001F1F RID: 7967 RVA: 0x001163B4 File Offset: 0x001145B4
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

		// Token: 0x17000B65 RID: 2917
		// (get) Token: 0x06001F20 RID: 7968 RVA: 0x001163F7 File Offset: 0x001145F7
		// (set) Token: 0x06001F21 RID: 7969 RVA: 0x00116401 File Offset: 0x00114601
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B66 RID: 2918
		// (get) Token: 0x06001F22 RID: 7970 RVA: 0x0011640A File Offset: 0x0011460A
		// (set) Token: 0x06001F23 RID: 7971 RVA: 0x00116414 File Offset: 0x00114614
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

		// Token: 0x17000B67 RID: 2919
		// (get) Token: 0x06001F24 RID: 7972 RVA: 0x00116457 File Offset: 0x00114657
		// (set) Token: 0x06001F25 RID: 7973 RVA: 0x00116461 File Offset: 0x00114661
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B68 RID: 2920
		// (get) Token: 0x06001F26 RID: 7974 RVA: 0x0011646A File Offset: 0x0011466A
		// (set) Token: 0x06001F27 RID: 7975 RVA: 0x00116474 File Offset: 0x00114674
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

		// Token: 0x17000B69 RID: 2921
		// (get) Token: 0x06001F28 RID: 7976 RVA: 0x001164B7 File Offset: 0x001146B7
		// (set) Token: 0x06001F29 RID: 7977 RVA: 0x001164C1 File Offset: 0x001146C1
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B6A RID: 2922
		// (get) Token: 0x06001F2A RID: 7978 RVA: 0x001164CA File Offset: 0x001146CA
		// (set) Token: 0x06001F2B RID: 7979 RVA: 0x001164D4 File Offset: 0x001146D4
		internal virtual ComboBox cboPaymentMethods
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B6B RID: 2923
		// (get) Token: 0x06001F2C RID: 7980 RVA: 0x001164DD File Offset: 0x001146DD
		// (set) Token: 0x06001F2D RID: 7981 RVA: 0x001164E7 File Offset: 0x001146E7
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B6C RID: 2924
		// (get) Token: 0x06001F2E RID: 7982 RVA: 0x001164F0 File Offset: 0x001146F0
		// (set) Token: 0x06001F2F RID: 7983 RVA: 0x001164FA File Offset: 0x001146FA
		internal virtual TextBox lblDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B6D RID: 2925
		// (get) Token: 0x06001F30 RID: 7984 RVA: 0x00116503 File Offset: 0x00114703
		// (set) Token: 0x06001F31 RID: 7985 RVA: 0x00116510 File Offset: 0x00114710
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

		// Token: 0x17000B6E RID: 2926
		// (get) Token: 0x06001F32 RID: 7986 RVA: 0x00116553 File Offset: 0x00114753
		// (set) Token: 0x06001F33 RID: 7987 RVA: 0x00116560 File Offset: 0x00114760
		internal virtual TextBox txtDiscount
		{
			[CompilerGenerated]
			get
			{
				return this._txtDiscount;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtDiscount_KeyPress);
				TextBox textBox = this._txtDiscount;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtDiscount = value;
				textBox = this._txtDiscount;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x17000B6F RID: 2927
		// (get) Token: 0x06001F34 RID: 7988 RVA: 0x001165A3 File Offset: 0x001147A3
		// (set) Token: 0x06001F35 RID: 7989 RVA: 0x001165AD File Offset: 0x001147AD
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B70 RID: 2928
		// (get) Token: 0x06001F36 RID: 7990 RVA: 0x001165B6 File Offset: 0x001147B6
		// (set) Token: 0x06001F37 RID: 7991 RVA: 0x001165C0 File Offset: 0x001147C0
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B71 RID: 2929
		// (get) Token: 0x06001F38 RID: 7992 RVA: 0x001165C9 File Offset: 0x001147C9
		// (set) Token: 0x06001F39 RID: 7993 RVA: 0x001165D4 File Offset: 0x001147D4
		internal virtual ComboBox cboBranch
		{
			[CompilerGenerated]
			get
			{
				return this._cboBranch;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cboBranch_SelectedIndexChanged);
				ComboBox comboBox = this._cboBranch;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= eventHandler;
				}
				this._cboBranch = value;
				comboBox = this._cboBranch;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B72 RID: 2930
		// (get) Token: 0x06001F3A RID: 7994 RVA: 0x00116617 File Offset: 0x00114817
		// (set) Token: 0x06001F3B RID: 7995 RVA: 0x00116624 File Offset: 0x00114824
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

		// Token: 0x17000B73 RID: 2931
		// (get) Token: 0x06001F3C RID: 7996 RVA: 0x00116667 File Offset: 0x00114867
		// (set) Token: 0x06001F3D RID: 7997 RVA: 0x00116671 File Offset: 0x00114871
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B74 RID: 2932
		// (get) Token: 0x06001F3E RID: 7998 RVA: 0x0011667A File Offset: 0x0011487A
		// (set) Token: 0x06001F3F RID: 7999 RVA: 0x00116684 File Offset: 0x00114884
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B75 RID: 2933
		// (get) Token: 0x06001F40 RID: 8000 RVA: 0x0011668D File Offset: 0x0011488D
		// (set) Token: 0x06001F41 RID: 8001 RVA: 0x00116697 File Offset: 0x00114897
		internal virtual TextBox txtPrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B76 RID: 2934
		// (get) Token: 0x06001F42 RID: 8002 RVA: 0x001166A0 File Offset: 0x001148A0
		// (set) Token: 0x06001F43 RID: 8003 RVA: 0x001166AA File Offset: 0x001148AA
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B77 RID: 2935
		// (get) Token: 0x06001F44 RID: 8004 RVA: 0x001166B3 File Offset: 0x001148B3
		// (set) Token: 0x06001F45 RID: 8005 RVA: 0x001166BD File Offset: 0x001148BD
		internal virtual CheckBox chkIsPercentage
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06001F46 RID: 8006 RVA: 0x001166C8 File Offset: 0x001148C8
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = (this.CurrentID != 0) & (Operators.CompareString(this.cboBranch.Text, "", false) != 0) & (Operators.CompareString(this.cboPaymentMethods.Text, "", false) != 0) & (Operators.CompareString(this.txtDiscount.Text, "", false) != 0);
				if (flag)
				{
					this.InsertpayMethDiscount();
					MessageBox.Show("Discount Details saved.");
					this.clearform();
				}
				else
				{
					MessageBox.Show("Please check if a product, branch, payment method or discount is selected.");
				}
			}
			catch (SqlException ex)
			{
				bool flag2 = ex.Number == 2627;
				if (flag2)
				{
					MessageBox.Show("Discount for this product and this payment method already exists. Delete the existing discount setting one first.");
				}
				else
				{
					MessageBox.Show("Error saving discount details. Detail: " + ex.Message);
				}
			}
			catch (Exception ex2)
			{
				MessageBox.Show("Error saving discount detail. " + ex2.Message);
			}
		}

		// Token: 0x06001F47 RID: 8007 RVA: 0x001167E8 File Offset: 0x001149E8
		private void clearform()
		{
			this.CurrentID = 0;
			this.lblDesc.Text = "";
			this.txtPrice.Text = "";
			this.cboBranch.SelectedIndex = -1;
			this.cboPaymentMethods.SelectedIndex = -1;
			this.txtDiscount.Text = "";
			this.txtsearch.Focus();
		}

		// Token: 0x06001F48 RID: 8008 RVA: 0x00116858 File Offset: 0x00114A58
		private void InsertpayMethDiscount()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "PaymentMethodDiscountInsert";
			sqlCommand.Parameters.AddWithValue("productid", this.CurrentID);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", this.cboBranch.Text);
			sqlCommand.Parameters.AddWithValue("paymethodid", RuntimeHelpers.GetObjectValue(this.cboPaymentMethods.SelectedValue));
			sqlCommand.Parameters.AddWithValue("discount", Convert.ToDecimal(this.txtDiscount.Text));
			sqlCommand.Parameters.AddWithValue("baseprice", Convert.ToDecimal(this.txtPrice.Text));
			sqlCommand.Parameters.AddWithValue("createdby", MyProject.Forms.Form1.username);
			sqlCommand.Parameters.AddWithValue("datecreated", DateTime.Now);
			sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
			bool @checked = this.chkIsPercentage.Checked;
			int num;
			if (@checked)
			{
				num = 1;
			}
			else
			{
				num = 0;
			}
			sqlCommand.Parameters.AddWithValue("ispercentage", num);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06001F49 RID: 8009 RVA: 0x00116A10 File Offset: 0x00114C10
		private void LoadPayMethodsDiscounts()
		{
			this.dgvDiscounts.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "PaymentMethodDiscountSelect";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", this.cboBranch.Text);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			this.dgvDiscounts.DataSource = dataTable;
			this.dgvDiscounts.Columns["paymethid"].Visible = false;
			this.dgvDiscounts.Columns["branch"].Visible = false;
			this.dgvDiscounts.Columns["productid"].HeaderText = "Product ID";
			this.dgvDiscounts.Columns["ProductDesc"].HeaderText = "Product Description";
			this.dgvDiscounts.Columns["baseprice"].HeaderText = "Base Selling Price";
			this.dgvDiscounts.Columns["PaymentMethodDesc"].HeaderText = "Payment Method Description";
			this.dgvDiscounts.Columns["discount"].HeaderText = "Discount Amount";
			this.dgvDiscounts.Columns["ispercentage"].HeaderText = "Disc Is Percentage?";
			DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
			dataGridViewButtonColumn.HeaderText = "Delete Product";
			dataGridViewButtonColumn.Text = "Delete";
			dataGridViewButtonColumn.Name = "Delete";
			dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
			this.dgvDiscounts.Columns.Add(dataGridViewButtonColumn);
			this.dgvDiscounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		}

		// Token: 0x06001F4A RID: 8010 RVA: 0x00116C0C File Offset: 0x00114E0C
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
			this.cboBranch.SelectedIndex = -1;
		}

		// Token: 0x06001F4B RID: 8011 RVA: 0x00116CB8 File Offset: 0x00114EB8
		private void LoadPaymentMethods()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectPaymentMethods";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			this.cboPaymentMethods.DataSource = dataTable;
			this.cboPaymentMethods.ValueMember = "PaymentMethodID";
			this.cboPaymentMethods.DisplayMember = "PaymentMethodDesc";
			this.cboPaymentMethods.SelectedIndex = -1;
		}

		// Token: 0x06001F4C RID: 8012 RVA: 0x00116D64 File Offset: 0x00114F64
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

		// Token: 0x06001F4D RID: 8013 RVA: 0x00116DC4 File Offset: 0x00114FC4
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
			}
			else
			{
				this.lblerror.Text = "No products match your search.";
			}
		}

		// Token: 0x06001F4E RID: 8014 RVA: 0x00117044 File Offset: 0x00115244
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

		// Token: 0x06001F4F RID: 8015 RVA: 0x001170B0 File Offset: 0x001152B0
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
					this.DGVSearch.Columns["Bin_Location"].Visible = false;
					this.DGVSearch.Columns["Product_Desc2"].Visible = false;
					this.DGVSearch.Columns["Reorder_level"].Visible = false;
					this.DGVSearch.Columns["Unit_Cost"].Visible = false;
					this.DGVSearch.Columns["Wholesale_Selling_Price"].Visible = false;
					this.DGVSearch.Columns["Wholesale_Qty"].Visible = false;
					this.DGVSearch.Columns["Unit_Selling_Price"].Visible = false;
					this.DGVSearch.Columns["Unit_of_Measure"].Visible = false;
					this.DGVSearch.Columns["Is_Active"].Visible = false;
					this.DGVSearch.Columns["Special_Price"].Visible = false;
					this.DGVSearch.Columns["PRODUCTEXPIRES"].Visible = false;
					this.DGVSearch.Columns["DifferentPricesPerBranch"].Visible = false;
					this.DGVSearch.Columns["Tax_percentage"].Visible = false;
					this.DGVSearch.Columns["ProductDesc"].Visible = false;
					this.DGVSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				}
				else
				{
					this.lblerror.Text = "No products match your search.";
				}
			}
		}

		// Token: 0x06001F50 RID: 8016 RVA: 0x00117344 File Offset: 0x00115544
		private object searchDat(DataTable dt, string column, string value)
		{
			PaymentMethodDiscount._Closure$__115-0 CS$<>8__locals1 = new PaymentMethodDiscount._Closure$__115-0(CS$<>8__locals1);
			CS$<>8__locals1.$VB$Local_column = column;
			CS$<>8__locals1.$VB$Local_value = value;
			DataTable dataTable = dt.Clone();
			dt.CaseSensitive = false;
			try
			{
				foreach (DataRow dataRow in dt.Rows.Cast<object>().Select<object, DataRow>((PaymentMethodDiscount._Closure$__.$I115-0 == null) ? (PaymentMethodDiscount._Closure$__.$I115-0 = (object row1) => (DataRow)row1) : PaymentMethodDiscount._Closure$__.$I115-0).Where<DataRow>((CS$<>8__locals1.$I1 == null) ? (CS$<>8__locals1.$I1 = (DataRow row1) => Conversions.ToBoolean(NewLateBinding.LateGet(row1[CS$<>8__locals1.$VB$Local_column], null, "Contains", new object[] { CS$<>8__locals1.$VB$Local_value.ToUpper() }, null, null, null))) : CS$<>8__locals1.$I1))
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

		// Token: 0x06001F51 RID: 8017 RVA: 0x00117420 File Offset: 0x00115620
		private DataTable searchDB(string searchtext)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SearchProduct4";
			sqlCommand.Parameters.AddWithValue("search", searchtext);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x06001F52 RID: 8018 RVA: 0x001174A8 File Offset: 0x001156A8
		private void DGVSearch_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					string text = Conversions.ToString(this.DGVSearch.Rows[e.RowIndex].Cells["ProductCode"].Value);
					this.lblDesc.Text = Conversions.ToString(this.DGVSearch.Rows[e.RowIndex].Cells["Product_Description"].Value);
					this.CurrentID = Conversions.ToInteger(this.DGVSearch.Rows[e.RowIndex].Cells["ProductID"].Value);
					int num = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DGVSearch.Rows[e.RowIndex].Cells["DifferentPricesPerBranch"].Value)), 0, RuntimeHelpers.GetObjectValue(this.DGVSearch.Rows[e.RowIndex].Cells["DifferentPricesPerBranch"].Value)));
					bool flag2 = num == 0;
					decimal num2;
					decimal num3;
					if (flag2)
					{
						num2 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(this.DGVSearch.Rows[e.RowIndex].Cells["Unit_Selling_Price"].Value));
						num3 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DGVSearch.Rows[e.RowIndex].Cells["Wholesale_Selling_Price"].Value)), 0, RuntimeHelpers.GetObjectValue(this.DGVSearch.Rows[e.RowIndex].Cells["Wholesale_Selling_Price"].Value))));
					}
					else
					{
						DataRow branchPrices = this.pf.GetBranchPrices(this._cnn, Conversions.ToInteger(this.DGVSearch.Rows[e.RowIndex].Cells["productid"].Value));
						num2 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(branchPrices["Unit_Selling_Price"])), 0, RuntimeHelpers.GetObjectValue(branchPrices["Unit_Selling_Price"]))));
						num3 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(branchPrices["Wholesale_Selling_Price"])), 0, RuntimeHelpers.GetObjectValue(branchPrices["Wholesale_Selling_Price"]))));
					}
					this.priceb4tax = num2;
					this.priceb4tax = this.priceb4tax;
					decimal num4 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DGVSearch.Rows[e.RowIndex].Cells["Tax_Percentage"].Value)), 0, RuntimeHelpers.GetObjectValue(this.DGVSearch.Rows[e.RowIndex].Cells["Tax_Percentage"].Value))));
					decimal num5 = decimal.Add(num2, decimal.Multiply(decimal.Divide(num4, 100m), num2));
					num5 = num5;
					this.priceb4taxWholesale = num3;
					this.priceb4taxWholesale = this.priceb4taxWholesale;
					this.taxdueWholesale = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DGVSearch.Rows[e.RowIndex].Cells["Tax_Percentage"].Value)), 0, RuntimeHelpers.GetObjectValue(this.DGVSearch.Rows[e.RowIndex].Cells["Tax_Percentage"].Value))));
					this.totpriceWholesale = decimal.Add(num3, decimal.Multiply(decimal.Divide(this.taxdueWholesale, 100m), num3));
					this.totpriceWholesale = this.totpriceWholesale;
					bool flag3 = MyProject.Forms.Form1.IsWholesaleShop == 1;
					if (flag3)
					{
						this.txtPrice.Text = this.totpriceWholesale.ToString();
					}
					else
					{
						this.txtPrice.Text = num5.ToString();
					}
				}
			}
			catch (Exception ex)
			{
				this.lblerror.Text = "Error: " + ex.Message;
			}
		}

		// Token: 0x06001F53 RID: 8019 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label5_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06001F54 RID: 8020 RVA: 0x00117990 File Offset: 0x00115B90
		private void dgvDiscounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					bool flag2 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "Delete", false) == 0;
					if (flag2)
					{
						DialogResult dialogResult = (DialogResult)Interaction.MsgBox("Are you sure you want to delete this product payment method based discount? " + dataGridView.Rows[e.RowIndex].Cells["ProductDesc"].Value.ToString(), MsgBoxStyle.YesNo, null);
						bool flag3 = dialogResult == DialogResult.Yes;
						if (flag3)
						{
							this.DeleteDiscount(Conversions.ToInteger(this.dgvDiscounts.Rows[e.RowIndex].Cells["productid"].Value), MyProject.Forms.Form1.coid, Conversions.ToString(this.dgvDiscounts.Rows[e.RowIndex].Cells["branch"].Value), Conversions.ToInteger(this.dgvDiscounts.Rows[e.RowIndex].Cells["paymethid"].Value));
							this.clearform();
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error deleting product. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001F55 RID: 8021 RVA: 0x00117B40 File Offset: 0x00115D40
		private void DeleteDiscount(int productid, int coid, string branch, int paymethid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "PaymentMethodDiscountDelete";
			sqlCommand.Parameters.AddWithValue("productid", productid);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("paymethid", paymethid);
			sqlCommand.Parameters.AddWithValue("deletedby", MyProject.Forms.Form1.username);
			sqlCommand.Parameters.AddWithValue("datedeleted", DateTime.Now);
			sqlCommand.Parameters.AddWithValue("machinenamedeleted", Environment.MachineName);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06001F56 RID: 8022 RVA: 0x00117C54 File Offset: 0x00115E54
		private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Strings.Asc(e.KeyChar) == 8) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Operators.CompareString(Conversions.ToString(e.KeyChar), "+", false) == 0) | (Operators.CompareString(Conversions.ToString(e.KeyChar), "-", false) == 0));
		}

		// Token: 0x06001F57 RID: 8023 RVA: 0x00117CD4 File Offset: 0x00115ED4
		private void PaymentMethodDiscount_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadPaymentMethods();
				this.LoadBranches();
				this.txtsearch.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001F58 RID: 8024 RVA: 0x00117D38 File Offset: 0x00115F38
		private void cboBranch_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.LoadPayMethodsDiscounts();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x04000EDD RID: 3805
		private int CurrentID;

		// Token: 0x04000EDE RID: 3806
		private string _cnn;

		// Token: 0x04000EDF RID: 3807
		private PublicFunctions pf;

		// Token: 0x04000EE0 RID: 3808
		private decimal priceb4tax;

		// Token: 0x04000EE1 RID: 3809
		private decimal priceb4taxWholesale;

		// Token: 0x04000EE2 RID: 3810
		private decimal currentWholesaleQty;

		// Token: 0x04000EE3 RID: 3811
		private decimal taxdueWholesale;

		// Token: 0x04000EE4 RID: 3812
		private decimal totpriceWholesale;

		// Token: 0x04000EE5 RID: 3813
		private int WholesalePriceByQty;
	}
}
