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
using Microsoft.Reporting.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;
using PointOfSale.POSDataSetTableAdapters;

namespace PointOfSale
{
	// Token: 0x0200005D RID: 93
	[DesignerGenerated]
	public partial class FormulaReport : Form
	{
		// Token: 0x06001390 RID: 5008 RVA: 0x000BA84B File Offset: 0x000B8A4B
		public FormulaReport()
		{
			base.Load += this.FormulaReport_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.CurrentID = 0;
			this.InitializeComponent();
		}

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x06001393 RID: 5011 RVA: 0x000BB5CB File Offset: 0x000B97CB
		// (set) Token: 0x06001394 RID: 5012 RVA: 0x000BB5D5 File Offset: 0x000B97D5
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x06001395 RID: 5013 RVA: 0x000BB5DE File Offset: 0x000B97DE
		// (set) Token: 0x06001396 RID: 5014 RVA: 0x000BB5E8 File Offset: 0x000B97E8
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x06001397 RID: 5015 RVA: 0x000BB5F1 File Offset: 0x000B97F1
		// (set) Token: 0x06001398 RID: 5016 RVA: 0x000BB5FB File Offset: 0x000B97FB
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x06001399 RID: 5017 RVA: 0x000BB604 File Offset: 0x000B9804
		// (set) Token: 0x0600139A RID: 5018 RVA: 0x000BB60E File Offset: 0x000B980E
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x0600139B RID: 5019 RVA: 0x000BB617 File Offset: 0x000B9817
		// (set) Token: 0x0600139C RID: 5020 RVA: 0x000BB621 File Offset: 0x000B9821
		internal virtual BindingSource SelectFormulaIngridientsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x0600139D RID: 5021 RVA: 0x000BB62A File Offset: 0x000B982A
		// (set) Token: 0x0600139E RID: 5022 RVA: 0x000BB634 File Offset: 0x000B9834
		internal virtual BindingSource SelectFormulasByNameBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x0600139F RID: 5023 RVA: 0x000BB63D File Offset: 0x000B983D
		// (set) Token: 0x060013A0 RID: 5024 RVA: 0x000BB647 File Offset: 0x000B9847
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x060013A1 RID: 5025 RVA: 0x000BB650 File Offset: 0x000B9850
		// (set) Token: 0x060013A2 RID: 5026 RVA: 0x000BB65A File Offset: 0x000B985A
		internal virtual SelectFormulaIngridientsTableAdapter SelectFormulaIngridientsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x060013A3 RID: 5027 RVA: 0x000BB663 File Offset: 0x000B9863
		// (set) Token: 0x060013A4 RID: 5028 RVA: 0x000BB66D File Offset: 0x000B986D
		internal virtual SelectFormulasByNameTableAdapter SelectFormulasByNameTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x060013A5 RID: 5029 RVA: 0x000BB676 File Offset: 0x000B9876
		// (set) Token: 0x060013A6 RID: 5030 RVA: 0x000BB680 File Offset: 0x000B9880
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x060013A7 RID: 5031 RVA: 0x000BB689 File Offset: 0x000B9889
		// (set) Token: 0x060013A8 RID: 5032 RVA: 0x000BB694 File Offset: 0x000B9894
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

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x060013A9 RID: 5033 RVA: 0x000BB6D7 File Offset: 0x000B98D7
		// (set) Token: 0x060013AA RID: 5034 RVA: 0x000BB6E1 File Offset: 0x000B98E1
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x060013AB RID: 5035 RVA: 0x000BB6EA File Offset: 0x000B98EA
		// (set) Token: 0x060013AC RID: 5036 RVA: 0x000BB6F4 File Offset: 0x000B98F4
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

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x060013AD RID: 5037 RVA: 0x000BB737 File Offset: 0x000B9937
		// (set) Token: 0x060013AE RID: 5038 RVA: 0x000BB741 File Offset: 0x000B9941
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x060013AF RID: 5039 RVA: 0x000BB74A File Offset: 0x000B994A
		// (set) Token: 0x060013B0 RID: 5040 RVA: 0x000BB754 File Offset: 0x000B9954
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

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x060013B1 RID: 5041 RVA: 0x000BB797 File Offset: 0x000B9997
		// (set) Token: 0x060013B2 RID: 5042 RVA: 0x000BB7A1 File Offset: 0x000B99A1
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x060013B3 RID: 5043 RVA: 0x000BB7AA File Offset: 0x000B99AA
		// (set) Token: 0x060013B4 RID: 5044 RVA: 0x000BB7B4 File Offset: 0x000B99B4
		internal virtual TextBox txtDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x060013B5 RID: 5045 RVA: 0x000BB7BD File Offset: 0x000B99BD
		// (set) Token: 0x060013B6 RID: 5046 RVA: 0x000BB7C7 File Offset: 0x000B99C7
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x060013B7 RID: 5047 RVA: 0x000BB7D0 File Offset: 0x000B99D0
		// (set) Token: 0x060013B8 RID: 5048 RVA: 0x000BB7DC File Offset: 0x000B99DC
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

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x060013B9 RID: 5049 RVA: 0x000BB81F File Offset: 0x000B9A1F
		// (set) Token: 0x060013BA RID: 5050 RVA: 0x000BB829 File Offset: 0x000B9A29
		internal virtual ComboBox cboFormualas
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x060013BB RID: 5051 RVA: 0x000BB832 File Offset: 0x000B9A32
		// (set) Token: 0x060013BC RID: 5052 RVA: 0x000BB83C File Offset: 0x000B9A3C
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x060013BD RID: 5053 RVA: 0x000BB845 File Offset: 0x000B9A45
		// (set) Token: 0x060013BE RID: 5054 RVA: 0x000BB850 File Offset: 0x000B9A50
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

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x060013BF RID: 5055 RVA: 0x000BB893 File Offset: 0x000B9A93
		// (set) Token: 0x060013C0 RID: 5056 RVA: 0x000BB8A0 File Offset: 0x000B9AA0
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

		// Token: 0x060013C1 RID: 5057 RVA: 0x00002A30 File Offset: 0x00000C30
		private void FormulaReport_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x060013C2 RID: 5058 RVA: 0x000BB8E4 File Offset: 0x000B9AE4
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

		// Token: 0x060013C3 RID: 5059 RVA: 0x000BB96C File Offset: 0x000B9B6C
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

		// Token: 0x060013C4 RID: 5060 RVA: 0x000BBA14 File Offset: 0x000B9C14
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
						dataTable = this.searchDB(text, new int?(0));
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

		// Token: 0x060013C5 RID: 5061 RVA: 0x000BBB24 File Offset: 0x000B9D24
		private object searchDat(DataTable dt, string column, string value)
		{
			FormulaReport._Closure$__102-0 CS$<>8__locals1 = new FormulaReport._Closure$__102-0(CS$<>8__locals1);
			CS$<>8__locals1.$VB$Local_column = column;
			CS$<>8__locals1.$VB$Local_value = value;
			DataTable dataTable = dt.Clone();
			dt.CaseSensitive = false;
			try
			{
				foreach (DataRow dataRow in dt.Rows.Cast<object>().Select<object, DataRow>((FormulaReport._Closure$__.$I102-0 == null) ? (FormulaReport._Closure$__.$I102-0 = (object row1) => (DataRow)row1) : FormulaReport._Closure$__.$I102-0).Where<DataRow>((CS$<>8__locals1.$I1 == null) ? (CS$<>8__locals1.$I1 = (DataRow row1) => Conversions.ToBoolean(NewLateBinding.LateGet(row1[CS$<>8__locals1.$VB$Local_column], null, "Contains", new object[] { CS$<>8__locals1.$VB$Local_value.ToUpper() }, null, null, null))) : CS$<>8__locals1.$I1))
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

		// Token: 0x060013C6 RID: 5062 RVA: 0x000BBC00 File Offset: 0x000B9E00
		private DataTable searchDB(string searchtext, int? isingridient)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SearchProduct2";
			sqlCommand.Parameters.AddWithValue("search", searchtext);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("isingridient", isingridient);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x060013C7 RID: 5063 RVA: 0x000BBCA0 File Offset: 0x000B9EA0
		private void FetchAllProducts()
		{
			this.lblerror.Text = "...";
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectAllProducts2";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("isingridient", 0);
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

		// Token: 0x060013C8 RID: 5064 RVA: 0x000BBE90 File Offset: 0x000BA090
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

		// Token: 0x060013C9 RID: 5065 RVA: 0x000BBEF0 File Offset: 0x000BA0F0
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

		// Token: 0x060013CA RID: 5066 RVA: 0x000BBFB4 File Offset: 0x000BA1B4
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
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading formulas. Detail: " + ex.Message);
			}
		}

		// Token: 0x060013CB RID: 5067 RVA: 0x000BC034 File Offset: 0x000BA234
		private void txtSearchProductCode_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.txtDesc.Text = "No product matches your search.";
				this.SearchBarCode(Conversions.ToInteger(Interaction.IIf(Operators.CompareString(this.txtSearchProductCode.Text, "", false) == 0, 0, Conversion.Val(this.txtSearchProductCode.Text))));
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Details: " + ex.Message, "Error");
			}
		}

		// Token: 0x060013CC RID: 5068 RVA: 0x000BC0D8 File Offset: 0x000BA2D8
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
				this.CurrentID = Conversions.ToInteger(dataRow["ProductID"]);
			}
			else
			{
				this.txtSearchProductCode.Text = "";
			}
		}

		// Token: 0x060013CD RID: 5069 RVA: 0x000BC1C4 File Offset: 0x000BA3C4
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.cboFormualas.Text, "", false) == 0;
				if (flag)
				{
					MessageBox.Show("Please select the product and then click load formulas first.");
				}
				else
				{
					SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
					this.GetCompanyDetailsTableAdapter.Connection = sqlConnection;
					this.SelectFormulaIngridientsTableAdapter.Connection = sqlConnection;
					this.SelectFormulasByNameTableAdapter.Connection = sqlConnection;
					ReportParameter reportParameter = new ReportParameter("formulaname", this.cboFormualas.Text);
					ReportParameter[] array = new ReportParameter[] { reportParameter };
					this.ReportViewer1.LocalReport.SetParameters(array);
					this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
					this.SelectFormulaIngridientsTableAdapter.Fill(this.POSDataSet.SelectFormulaIngridients, new int?(MyProject.Forms.Form1.coid), this.cboFormualas.Text);
					this.SelectFormulasByNameTableAdapter.Fill(this.POSDataSet.SelectFormulasByName, new int?(MyProject.Forms.Form1.coid), this.cboFormualas.Text);
					this.ReportViewer1.RefreshReport();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying report. Detail: " + ex.Message);
			}
		}

		// Token: 0x04000A0A RID: 2570
		private string _cnn;

		// Token: 0x04000A0B RID: 2571
		private int CurrentID;
	}
}
