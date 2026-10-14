using System;
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
	// Token: 0x020001E7 RID: 487
	[DesignerGenerated]
	public partial class StockBreakage : UserControl
	{
		// Token: 0x060055A5 RID: 21925 RVA: 0x00318128 File Offset: 0x00316328
		public StockBreakage()
		{
			base.Load += this.StockBreakage_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.CurrentID = 0;
			this.InitializeComponent();
		}

		// Token: 0x17001EC2 RID: 7874
		// (get) Token: 0x060055A8 RID: 21928 RVA: 0x00319233 File Offset: 0x00317433
		// (set) Token: 0x060055A9 RID: 21929 RVA: 0x0031923D File Offset: 0x0031743D
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001EC3 RID: 7875
		// (get) Token: 0x060055AA RID: 21930 RVA: 0x00319246 File Offset: 0x00317446
		// (set) Token: 0x060055AB RID: 21931 RVA: 0x00319250 File Offset: 0x00317450
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001EC4 RID: 7876
		// (get) Token: 0x060055AC RID: 21932 RVA: 0x00319259 File Offset: 0x00317459
		// (set) Token: 0x060055AD RID: 21933 RVA: 0x00319263 File Offset: 0x00317463
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001EC5 RID: 7877
		// (get) Token: 0x060055AE RID: 21934 RVA: 0x0031926C File Offset: 0x0031746C
		// (set) Token: 0x060055AF RID: 21935 RVA: 0x00319278 File Offset: 0x00317478
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

		// Token: 0x17001EC6 RID: 7878
		// (get) Token: 0x060055B0 RID: 21936 RVA: 0x003192BB File Offset: 0x003174BB
		// (set) Token: 0x060055B1 RID: 21937 RVA: 0x003192C8 File Offset: 0x003174C8
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

		// Token: 0x17001EC7 RID: 7879
		// (get) Token: 0x060055B2 RID: 21938 RVA: 0x0031930B File Offset: 0x0031750B
		// (set) Token: 0x060055B3 RID: 21939 RVA: 0x00319315 File Offset: 0x00317515
		internal virtual DateTimePicker DTdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001EC8 RID: 7880
		// (get) Token: 0x060055B4 RID: 21940 RVA: 0x0031931E File Offset: 0x0031751E
		// (set) Token: 0x060055B5 RID: 21941 RVA: 0x00319328 File Offset: 0x00317528
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001EC9 RID: 7881
		// (get) Token: 0x060055B6 RID: 21942 RVA: 0x00319331 File Offset: 0x00317531
		// (set) Token: 0x060055B7 RID: 21943 RVA: 0x0031933B File Offset: 0x0031753B
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001ECA RID: 7882
		// (get) Token: 0x060055B8 RID: 21944 RVA: 0x00319344 File Offset: 0x00317544
		// (set) Token: 0x060055B9 RID: 21945 RVA: 0x0031934E File Offset: 0x0031754E
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001ECB RID: 7883
		// (get) Token: 0x060055BA RID: 21946 RVA: 0x00319357 File Offset: 0x00317557
		// (set) Token: 0x060055BB RID: 21947 RVA: 0x00319364 File Offset: 0x00317564
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

		// Token: 0x17001ECC RID: 7884
		// (get) Token: 0x060055BC RID: 21948 RVA: 0x003193C2 File Offset: 0x003175C2
		// (set) Token: 0x060055BD RID: 21949 RVA: 0x003193CC File Offset: 0x003175CC
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001ECD RID: 7885
		// (get) Token: 0x060055BE RID: 21950 RVA: 0x003193D5 File Offset: 0x003175D5
		// (set) Token: 0x060055BF RID: 21951 RVA: 0x003193E0 File Offset: 0x003175E0
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

		// Token: 0x17001ECE RID: 7886
		// (get) Token: 0x060055C0 RID: 21952 RVA: 0x00319423 File Offset: 0x00317623
		// (set) Token: 0x060055C1 RID: 21953 RVA: 0x0031942D File Offset: 0x0031762D
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001ECF RID: 7887
		// (get) Token: 0x060055C2 RID: 21954 RVA: 0x00319436 File Offset: 0x00317636
		// (set) Token: 0x060055C3 RID: 21955 RVA: 0x00319440 File Offset: 0x00317640
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

		// Token: 0x17001ED0 RID: 7888
		// (get) Token: 0x060055C4 RID: 21956 RVA: 0x00319483 File Offset: 0x00317683
		// (set) Token: 0x060055C5 RID: 21957 RVA: 0x00319490 File Offset: 0x00317690
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

		// Token: 0x17001ED1 RID: 7889
		// (get) Token: 0x060055C6 RID: 21958 RVA: 0x003194D3 File Offset: 0x003176D3
		// (set) Token: 0x060055C7 RID: 21959 RVA: 0x003194DD File Offset: 0x003176DD
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001ED2 RID: 7890
		// (get) Token: 0x060055C8 RID: 21960 RVA: 0x003194E6 File Offset: 0x003176E6
		// (set) Token: 0x060055C9 RID: 21961 RVA: 0x003194F0 File Offset: 0x003176F0
		internal virtual TextBox txtDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001ED3 RID: 7891
		// (get) Token: 0x060055CA RID: 21962 RVA: 0x003194F9 File Offset: 0x003176F9
		// (set) Token: 0x060055CB RID: 21963 RVA: 0x00319503 File Offset: 0x00317703
		internal virtual ComboBox cboAnomalyTypes
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001ED4 RID: 7892
		// (get) Token: 0x060055CC RID: 21964 RVA: 0x0031950C File Offset: 0x0031770C
		// (set) Token: 0x060055CD RID: 21965 RVA: 0x00319516 File Offset: 0x00317716
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001ED5 RID: 7893
		// (get) Token: 0x060055CE RID: 21966 RVA: 0x0031951F File Offset: 0x0031771F
		// (set) Token: 0x060055CF RID: 21967 RVA: 0x00319529 File Offset: 0x00317729
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001ED6 RID: 7894
		// (get) Token: 0x060055D0 RID: 21968 RVA: 0x00319532 File Offset: 0x00317732
		// (set) Token: 0x060055D1 RID: 21969 RVA: 0x0031953C File Offset: 0x0031773C
		internal virtual TextBox txtStockAvail
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001ED7 RID: 7895
		// (get) Token: 0x060055D2 RID: 21970 RVA: 0x00319545 File Offset: 0x00317745
		// (set) Token: 0x060055D3 RID: 21971 RVA: 0x0031954F File Offset: 0x0031774F
		internal virtual TextBox txtDetail
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001ED8 RID: 7896
		// (get) Token: 0x060055D4 RID: 21972 RVA: 0x00319558 File Offset: 0x00317758
		// (set) Token: 0x060055D5 RID: 21973 RVA: 0x00319562 File Offset: 0x00317762
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001ED9 RID: 7897
		// (get) Token: 0x060055D6 RID: 21974 RVA: 0x0031956B File Offset: 0x0031776B
		// (set) Token: 0x060055D7 RID: 21975 RVA: 0x00319578 File Offset: 0x00317778
		internal virtual TextBox txtQty
		{
			[CompilerGenerated]
			get
			{
				return this._txtQty;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtQty_KeyPress);
				TextBox textBox = this._txtQty;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtQty = value;
				textBox = this._txtQty;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x17001EDA RID: 7898
		// (get) Token: 0x060055D8 RID: 21976 RVA: 0x003195BB File Offset: 0x003177BB
		// (set) Token: 0x060055D9 RID: 21977 RVA: 0x003195C5 File Offset: 0x003177C5
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001EDB RID: 7899
		// (get) Token: 0x060055DA RID: 21978 RVA: 0x003195CE File Offset: 0x003177CE
		// (set) Token: 0x060055DB RID: 21979 RVA: 0x003195D8 File Offset: 0x003177D8
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

		// Token: 0x060055DC RID: 21980 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label3_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x060055DD RID: 21981 RVA: 0x0031961C File Offset: 0x0031781C
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
		}

		// Token: 0x060055DE RID: 21982 RVA: 0x003196BC File Offset: 0x003178BC
		private void GetAnomalyTypes()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetStockAnomalyTypes";
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			this.cboAnomalyTypes.DataSource = dataTable;
			this.cboAnomalyTypes.ValueMember = "StockAnomaly";
			this.cboAnomalyTypes.DisplayMember = "StockAnomaly";
		}

		// Token: 0x060055DF RID: 21983 RVA: 0x00319738 File Offset: 0x00317938
		private void Button2_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					int num = (int)Math.Round(Conversion.Val(this.txtQty.Text));
					bool flag = Conversions.ToDouble(this.txtQty.Text) > 0.0;
					if (flag)
					{
						int num2 = (int)Math.Round(Conversion.Val(DateAndTime.TimeOfDay.ToString("HHmm")));
						SqlConnection sqlConnection = new SqlConnection(this._cnn);
						SqlCommand sqlCommand = sqlConnection.CreateCommand();
						sqlConnection.Open();
						sqlCommand.Connection = sqlConnection;
						sqlCommand.Parameters.Clear();
						sqlCommand.CommandType = CommandType.StoredProcedure;
						sqlCommand.CommandText = "InsertNewSaleStockTake";
						sqlCommand.Parameters.AddWithValue("trandate", this.DTdate.Value.ToString("yyyyMMdd"));
						sqlCommand.Parameters.AddWithValue("invoicenum", 0);
						sqlCommand.Parameters.AddWithValue("productid", this.CurrentID);
						sqlCommand.Parameters.AddWithValue("isstockin", 0);
						sqlCommand.Parameters.AddWithValue("ref", "STOCK REDUCED");
						sqlCommand.Parameters.AddWithValue("quantity", Conversion.Val(this.txtQty.Text));
						sqlCommand.Parameters.AddWithValue("unitcost", RuntimeHelpers.GetObjectValue(this.GetProdCost(this.CurrentID)));
						sqlCommand.Parameters.AddWithValue("salesprice", 0);
						sqlCommand.Parameters.AddWithValue("paymentmethod", 0);
						sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
						sqlCommand.Parameters.AddWithValue("donewhen", DateTime.Today.ToString("yyyyMMdd"));
						sqlCommand.Parameters.AddWithValue("trancode", 2);
						sqlCommand.Parameters.AddWithValue("TranTime", num2);
						sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
						sqlCommand.Parameters.AddWithValue("branch", RuntimeHelpers.GetObjectValue(this.cboBranch.SelectedValue));
						sqlCommand.Parameters.AddWithValue("details", this.cboAnomalyTypes.SelectedValue.ToString() + ": " + this.txtDetail.Text);
						sqlCommand.ExecuteNonQuery();
						MessageBox.Show("Stock Anomaly Recorded.");
						this.txtDesc.Text = "";
						this.txtQty.Text = "";
						this.txtDetail.Text = "";
						this.CurrentID = 0;
						this.CurrentCode = "";
					}
					else
					{
						MessageBox.Show("Please enter a quantity greater than 0.");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error recording anomaly. Detail: " + ex.Message);
				}
			}
		}

		// Token: 0x060055E0 RID: 21984 RVA: 0x00319A94 File Offset: 0x00317C94
		private object GetProdCost(int productid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchProductByID";
			sqlCommand.Parameters.AddWithValue("prodtID", productid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				double num2 = Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow["Cost"]));
				return num2;
			}
			throw new ArgumentException("Exception Occured- cannot find product");
		}

		// Token: 0x060055E1 RID: 21985 RVA: 0x00319B58 File Offset: 0x00317D58
		private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x060055E2 RID: 21986 RVA: 0x00319BA4 File Offset: 0x00317DA4
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

		// Token: 0x060055E3 RID: 21987 RVA: 0x00319C04 File Offset: 0x00317E04
		private void txtProductCode_TextChanged(object sender, EventArgs e)
		{
			try
			{
				try
				{
					this.txtStockAvail.Text = Conversions.ToString(0);
					this.txtQty.Text = Conversions.ToString(0);
					this.txtDesc.Text = "No product matches your search.";
					this.SearchBarCode(this.txtProductCode.Text);
				}
				catch (Exception ex)
				{
					MessageBox.Show("Bar code error. Detail: " + ex.Message);
				}
			}
			catch (Exception ex2)
			{
			}
		}

		// Token: 0x060055E4 RID: 21988 RVA: 0x00319CB4 File Offset: 0x00317EB4
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

		// Token: 0x060055E5 RID: 21989 RVA: 0x00319D74 File Offset: 0x00317F74
		private void FetchAllProducts()
		{
			this.lblerror.Text = "...";
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectAllProducts3";
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
			}
			else
			{
				this.lblerror.Text = "No products match your search.";
			}
		}

		// Token: 0x060055E6 RID: 21990 RVA: 0x00319ED4 File Offset: 0x003180D4
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

		// Token: 0x060055E7 RID: 21991 RVA: 0x00319F34 File Offset: 0x00318134
		private void SearchByDesc(string searchtext)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SearchProduct3";
			sqlCommand.Parameters.AddWithValue("search", searchtext);
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

		// Token: 0x060055E8 RID: 21992 RVA: 0x0031A008 File Offset: 0x00318208
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

		// Token: 0x060055E9 RID: 21993 RVA: 0x0031A074 File Offset: 0x00318274
		private void SearchBarCode(string prodtcode)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchProductByCode";
			sqlCommand.Parameters.AddWithValue("productcode", prodtcode);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				this.txtDesc.Text = Conversions.ToString(dataRow["ProductDesc"]);
				this.CurrentID = Conversions.ToInteger(dataRow["ProductID"]);
				this.CurrentCode = Conversions.ToString(dataRow["ProductCode"]);
				this.txtStockAvail.Text = Conversions.ToString(this.GetStockAvailable(this.CurrentID));
			}
			else
			{
				this.txtProductCode.Text = "";
			}
		}

		// Token: 0x060055EA RID: 21994 RVA: 0x0031A168 File Offset: 0x00318368
		private decimal GetStockAvailable(int productid)
		{
			int num = 0;
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "TotalStockIn";
			sqlCommand.Parameters.AddWithValue("productid", productid);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", this.cboBranch.Text);
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

		// Token: 0x060055EB RID: 21995 RVA: 0x0031A3D0 File Offset: 0x003185D0
		private void StockBreakage_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadBranches();
				this.GetAnomalyTypes();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x060055EC RID: 21996 RVA: 0x00002A30 File Offset: 0x00000C30
		private void cboBranch_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0400257E RID: 9598
		private string _cnn;

		// Token: 0x0400257F RID: 9599
		private string CurrentCode;

		// Token: 0x04002580 RID: 9600
		private int CurrentID;
	}
}
