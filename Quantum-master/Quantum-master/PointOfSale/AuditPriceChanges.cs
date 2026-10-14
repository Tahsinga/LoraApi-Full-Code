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
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;
using PointOfSale.POSDataSetTableAdapters;

namespace PointOfSale
{
	// Token: 0x0200000F RID: 15
	[DesignerGenerated]
	public partial class AuditPriceChanges : Form
	{
		// Token: 0x06000295 RID: 661 RVA: 0x00017DF4 File Offset: 0x00015FF4
		public AuditPriceChanges()
		{
			base.Load += this.AuditPriceChanges_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.CurrentID = 0;
			this.InitializeComponent();
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000298 RID: 664 RVA: 0x00018B71 File Offset: 0x00016D71
		// (set) Token: 0x06000299 RID: 665 RVA: 0x00018B7B File Offset: 0x00016D7B
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x0600029A RID: 666 RVA: 0x00018B84 File Offset: 0x00016D84
		// (set) Token: 0x0600029B RID: 667 RVA: 0x00018B8E File Offset: 0x00016D8E
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x0600029C RID: 668 RVA: 0x00018B97 File Offset: 0x00016D97
		// (set) Token: 0x0600029D RID: 669 RVA: 0x00018BA1 File Offset: 0x00016DA1
		internal virtual BindingSource Audit_PriceChangesSelectBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x0600029E RID: 670 RVA: 0x00018BAA File Offset: 0x00016DAA
		// (set) Token: 0x0600029F RID: 671 RVA: 0x00018BB4 File Offset: 0x00016DB4
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060002A0 RID: 672 RVA: 0x00018BBD File Offset: 0x00016DBD
		// (set) Token: 0x060002A1 RID: 673 RVA: 0x00018BC7 File Offset: 0x00016DC7
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x00018BD0 File Offset: 0x00016DD0
		// (set) Token: 0x060002A3 RID: 675 RVA: 0x00018BDA File Offset: 0x00016DDA
		internal virtual Audit_PriceChangesSelectTableAdapter Audit_PriceChangesSelectTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x00018BE3 File Offset: 0x00016DE3
		// (set) Token: 0x060002A5 RID: 677 RVA: 0x00018BED File Offset: 0x00016DED
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060002A6 RID: 678 RVA: 0x00018BF6 File Offset: 0x00016DF6
		// (set) Token: 0x060002A7 RID: 679 RVA: 0x00018C00 File Offset: 0x00016E00
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

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x00018C43 File Offset: 0x00016E43
		// (set) Token: 0x060002A9 RID: 681 RVA: 0x00018C4D File Offset: 0x00016E4D
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060002AA RID: 682 RVA: 0x00018C56 File Offset: 0x00016E56
		// (set) Token: 0x060002AB RID: 683 RVA: 0x00018C60 File Offset: 0x00016E60
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060002AC RID: 684 RVA: 0x00018C69 File Offset: 0x00016E69
		// (set) Token: 0x060002AD RID: 685 RVA: 0x00018C73 File Offset: 0x00016E73
		internal virtual DateTimePicker DTend
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060002AE RID: 686 RVA: 0x00018C7C File Offset: 0x00016E7C
		// (set) Token: 0x060002AF RID: 687 RVA: 0x00018C86 File Offset: 0x00016E86
		internal virtual DateTimePicker DTstart
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x00018C8F File Offset: 0x00016E8F
		// (set) Token: 0x060002B1 RID: 689 RVA: 0x00018C99 File Offset: 0x00016E99
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x00018CA2 File Offset: 0x00016EA2
		// (set) Token: 0x060002B3 RID: 691 RVA: 0x00018CAC File Offset: 0x00016EAC
		internal virtual GroupBox GroupBox4
		{
			[CompilerGenerated]
			get
			{
				return this._GroupBox4;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.GroupBox4_Enter);
				GroupBox groupBox = this._GroupBox4;
				if (groupBox != null)
				{
					groupBox.Enter -= eventHandler;
				}
				this._GroupBox4 = value;
				groupBox = this._GroupBox4;
				if (groupBox != null)
				{
					groupBox.Enter += eventHandler;
				}
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x00018CEF File Offset: 0x00016EEF
		// (set) Token: 0x060002B5 RID: 693 RVA: 0x00018CFC File Offset: 0x00016EFC
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

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060002B6 RID: 694 RVA: 0x00018D3F File Offset: 0x00016F3F
		// (set) Token: 0x060002B7 RID: 695 RVA: 0x00018D49 File Offset: 0x00016F49
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060002B8 RID: 696 RVA: 0x00018D52 File Offset: 0x00016F52
		// (set) Token: 0x060002B9 RID: 697 RVA: 0x00018D5C File Offset: 0x00016F5C
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

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060002BA RID: 698 RVA: 0x00018D9F File Offset: 0x00016F9F
		// (set) Token: 0x060002BB RID: 699 RVA: 0x00018DA9 File Offset: 0x00016FA9
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060002BC RID: 700 RVA: 0x00018DB2 File Offset: 0x00016FB2
		// (set) Token: 0x060002BD RID: 701 RVA: 0x00018DBC File Offset: 0x00016FBC
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

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060002BE RID: 702 RVA: 0x00018DFF File Offset: 0x00016FFF
		// (set) Token: 0x060002BF RID: 703 RVA: 0x00018E09 File Offset: 0x00017009
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x00018E12 File Offset: 0x00017012
		// (set) Token: 0x060002C1 RID: 705 RVA: 0x00018E1C File Offset: 0x0001701C
		internal virtual TextBox lblDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x00018E25 File Offset: 0x00017025
		// (set) Token: 0x060002C3 RID: 707 RVA: 0x00018E2F File Offset: 0x0001702F
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x00018E38 File Offset: 0x00017038
		// (set) Token: 0x060002C5 RID: 709 RVA: 0x00018E42 File Offset: 0x00017042
		internal virtual CheckBox chkAllProducts
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00018E4B File Offset: 0x0001704B
		private void AuditPriceChanges_Load(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Maximized;
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00018E58 File Offset: 0x00017058
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = (this.CurrentID == 0) & !this.chkAllProducts.Checked;
				if (flag)
				{
					MessageBox.Show("Please select the product first.");
				}
				else
				{
					SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
					this.Audit_PriceChangesSelectTableAdapter.Connection = sqlConnection;
					this.GetCompanyDetailsTableAdapter.Connection = sqlConnection;
					ReportParameter reportParameter = new ReportParameter("coid", Conversions.ToString(MyProject.Forms.Form1.coid));
					ReportParameter reportParameter2 = new ReportParameter("branch", MyProject.Forms.Form1.branch);
					ReportParameter reportParameter3 = new ReportParameter("startdate", Conversions.ToString(this.DTstart.Value));
					ReportParameter reportParameter4 = new ReportParameter("enddate", Conversions.ToString(this.DTend.Value));
					ReportParameter reportParameter5 = new ReportParameter("startdateDesc", this.DTstart.Value.ToShortDateString());
					ReportParameter reportParameter6 = new ReportParameter("enddateDesc", this.DTend.Value.ToShortDateString());
					ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter2, reportParameter3, reportParameter4, reportParameter5, reportParameter6 };
					this.ReportViewer1.LocalReport.SetParameters(array);
					this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
					int? num = null;
					bool flag2 = !this.chkAllProducts.Checked;
					if (flag2)
					{
						num = new int?(this.CurrentID);
					}
					this.Audit_PriceChangesSelectTableAdapter.Fill(this.POSDataSet.Audit_PriceChangesSelect, new DateTime?(this.DTstart.Value), new DateTime?(this.DTend.Value), MyProject.Forms.Form1.branch, new int?(MyProject.Forms.Form1.coid), num);
					this.ReportViewer1.RefreshReport();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying report. Detail: " + ex.Message);
			}
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x0001909C File Offset: 0x0001729C
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

		// Token: 0x060002C9 RID: 713 RVA: 0x00019108 File Offset: 0x00017308
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

		// Token: 0x060002CA RID: 714 RVA: 0x0001939C File Offset: 0x0001759C
		private object searchDat(DataTable dt, string column, string value)
		{
			AuditPriceChanges._Closure$__102-0 CS$<>8__locals1 = new AuditPriceChanges._Closure$__102-0(CS$<>8__locals1);
			CS$<>8__locals1.$VB$Local_column = column;
			CS$<>8__locals1.$VB$Local_value = value;
			DataTable dataTable = dt.Clone();
			dt.CaseSensitive = false;
			try
			{
				foreach (DataRow dataRow in dt.Rows.Cast<object>().Select<object, DataRow>((AuditPriceChanges._Closure$__.$I102-0 == null) ? (AuditPriceChanges._Closure$__.$I102-0 = (object row1) => (DataRow)row1) : AuditPriceChanges._Closure$__.$I102-0).Where<DataRow>((CS$<>8__locals1.$I1 == null) ? (CS$<>8__locals1.$I1 = (DataRow row1) => Conversions.ToBoolean(NewLateBinding.LateGet(row1[CS$<>8__locals1.$VB$Local_column], null, "Contains", new object[] { CS$<>8__locals1.$VB$Local_value.ToUpper() }, null, null, null))) : CS$<>8__locals1.$I1))
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

		// Token: 0x060002CB RID: 715 RVA: 0x00019478 File Offset: 0x00017678
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

		// Token: 0x060002CC RID: 716 RVA: 0x00019500 File Offset: 0x00017700
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

		// Token: 0x060002CD RID: 717 RVA: 0x00019560 File Offset: 0x00017760
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

		// Token: 0x060002CE RID: 718 RVA: 0x000197E0 File Offset: 0x000179E0
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
				this.CurrentID = Conversions.ToInteger(dataRow["ProductID"]);
			}
			else
			{
				this.lblDesc.Text = "Nothing found matching that product ID";
			}
		}

		// Token: 0x060002CF RID: 719 RVA: 0x000198C8 File Offset: 0x00017AC8
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
				}
			}
			catch (Exception ex)
			{
				this.lblerror.Text = "Error: " + ex.Message;
			}
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00002A30 File Offset: 0x00000C30
		private void GroupBox4_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x04000136 RID: 310
		private string _cnn;

		// Token: 0x04000137 RID: 311
		private int CurrentID;
	}
}
