using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;
using PointOfSale.POSDataSetTableAdapters;

namespace PointOfSale
{
	// Token: 0x0200021B RID: 539
	[DesignerGenerated]
	public partial class WarehouseStockTransfer : UserControl
	{
		// Token: 0x06006160 RID: 24928 RVA: 0x00377D90 File Offset: 0x00375F90
		public WarehouseStockTransfer()
		{
			base.Load += this.WarehouseStockTransfer_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x17002344 RID: 9028
		// (get) Token: 0x06006163 RID: 24931 RVA: 0x003789D0 File Offset: 0x00376BD0
		// (set) Token: 0x06006164 RID: 24932 RVA: 0x003789DA File Offset: 0x00376BDA
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002345 RID: 9029
		// (get) Token: 0x06006165 RID: 24933 RVA: 0x003789E3 File Offset: 0x00376BE3
		// (set) Token: 0x06006166 RID: 24934 RVA: 0x003789F0 File Offset: 0x00376BF0
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

		// Token: 0x17002346 RID: 9030
		// (get) Token: 0x06006167 RID: 24935 RVA: 0x00378A33 File Offset: 0x00376C33
		// (set) Token: 0x06006168 RID: 24936 RVA: 0x00378A40 File Offset: 0x00376C40
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

		// Token: 0x17002347 RID: 9031
		// (get) Token: 0x06006169 RID: 24937 RVA: 0x00378A83 File Offset: 0x00376C83
		// (set) Token: 0x0600616A RID: 24938 RVA: 0x00378A8D File Offset: 0x00376C8D
		internal virtual TextBox txtRef
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002348 RID: 9032
		// (get) Token: 0x0600616B RID: 24939 RVA: 0x00378A96 File Offset: 0x00376C96
		// (set) Token: 0x0600616C RID: 24940 RVA: 0x00378AA0 File Offset: 0x00376CA0
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002349 RID: 9033
		// (get) Token: 0x0600616D RID: 24941 RVA: 0x00378AA9 File Offset: 0x00376CA9
		// (set) Token: 0x0600616E RID: 24942 RVA: 0x00378AB3 File Offset: 0x00376CB3
		internal virtual Label lblinfo
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700234A RID: 9034
		// (get) Token: 0x0600616F RID: 24943 RVA: 0x00378ABC File Offset: 0x00376CBC
		// (set) Token: 0x06006170 RID: 24944 RVA: 0x00378AC8 File Offset: 0x00376CC8
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

		// Token: 0x1700234B RID: 9035
		// (get) Token: 0x06006171 RID: 24945 RVA: 0x00378B0B File Offset: 0x00376D0B
		// (set) Token: 0x06006172 RID: 24946 RVA: 0x00378B15 File Offset: 0x00376D15
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700234C RID: 9036
		// (get) Token: 0x06006173 RID: 24947 RVA: 0x00378B1E File Offset: 0x00376D1E
		// (set) Token: 0x06006174 RID: 24948 RVA: 0x00378B28 File Offset: 0x00376D28
		internal virtual DataGridView dgvBranchStock
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700234D RID: 9037
		// (get) Token: 0x06006175 RID: 24949 RVA: 0x00378B31 File Offset: 0x00376D31
		// (set) Token: 0x06006176 RID: 24950 RVA: 0x00378B3B File Offset: 0x00376D3B
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700234E RID: 9038
		// (get) Token: 0x06006177 RID: 24951 RVA: 0x00378B44 File Offset: 0x00376D44
		// (set) Token: 0x06006178 RID: 24952 RVA: 0x00378B4E File Offset: 0x00376D4E
		internal virtual DataGridView dgvWarehouse
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700234F RID: 9039
		// (get) Token: 0x06006179 RID: 24953 RVA: 0x00378B57 File Offset: 0x00376D57
		// (set) Token: 0x0600617A RID: 24954 RVA: 0x00378B61 File Offset: 0x00376D61
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002350 RID: 9040
		// (get) Token: 0x0600617B RID: 24955 RVA: 0x00378B6A File Offset: 0x00376D6A
		// (set) Token: 0x0600617C RID: 24956 RVA: 0x00378B74 File Offset: 0x00376D74
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002351 RID: 9041
		// (get) Token: 0x0600617D RID: 24957 RVA: 0x00378B7D File Offset: 0x00376D7D
		// (set) Token: 0x0600617E RID: 24958 RVA: 0x00378B87 File Offset: 0x00376D87
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002352 RID: 9042
		// (get) Token: 0x0600617F RID: 24959 RVA: 0x00378B90 File Offset: 0x00376D90
		// (set) Token: 0x06006180 RID: 24960 RVA: 0x00378B9A File Offset: 0x00376D9A
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002353 RID: 9043
		// (get) Token: 0x06006181 RID: 24961 RVA: 0x00378BA3 File Offset: 0x00376DA3
		// (set) Token: 0x06006182 RID: 24962 RVA: 0x00378BAD File Offset: 0x00376DAD
		internal virtual BindingSource FetchTransferDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002354 RID: 9044
		// (get) Token: 0x06006183 RID: 24963 RVA: 0x00378BB6 File Offset: 0x00376DB6
		// (set) Token: 0x06006184 RID: 24964 RVA: 0x00378BC0 File Offset: 0x00376DC0
		internal virtual BindingSource FetchBranchToforTransferBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002355 RID: 9045
		// (get) Token: 0x06006185 RID: 24965 RVA: 0x00378BC9 File Offset: 0x00376DC9
		// (set) Token: 0x06006186 RID: 24966 RVA: 0x00378BD3 File Offset: 0x00376DD3
		internal virtual BindingSource FetchBranchFromforTransferBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002356 RID: 9046
		// (get) Token: 0x06006187 RID: 24967 RVA: 0x00378BDC File Offset: 0x00376DDC
		// (set) Token: 0x06006188 RID: 24968 RVA: 0x00378BE6 File Offset: 0x00376DE6
		internal virtual BindingSource FetchTransferDetailsToBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002357 RID: 9047
		// (get) Token: 0x06006189 RID: 24969 RVA: 0x00378BEF File Offset: 0x00376DEF
		// (set) Token: 0x0600618A RID: 24970 RVA: 0x00378BF9 File Offset: 0x00376DF9
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002358 RID: 9048
		// (get) Token: 0x0600618B RID: 24971 RVA: 0x00378C02 File Offset: 0x00376E02
		// (set) Token: 0x0600618C RID: 24972 RVA: 0x00378C0C File Offset: 0x00376E0C
		internal virtual FetchTransferDetailsTableAdapter FetchTransferDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002359 RID: 9049
		// (get) Token: 0x0600618D RID: 24973 RVA: 0x00378C15 File Offset: 0x00376E15
		// (set) Token: 0x0600618E RID: 24974 RVA: 0x00378C1F File Offset: 0x00376E1F
		internal virtual FetchBranchToforTransferTableAdapter FetchBranchToforTransferTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700235A RID: 9050
		// (get) Token: 0x0600618F RID: 24975 RVA: 0x00378C28 File Offset: 0x00376E28
		// (set) Token: 0x06006190 RID: 24976 RVA: 0x00378C32 File Offset: 0x00376E32
		internal virtual FetchBranchFromforTransferTableAdapter FetchBranchFromforTransferTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700235B RID: 9051
		// (get) Token: 0x06006191 RID: 24977 RVA: 0x00378C3B File Offset: 0x00376E3B
		// (set) Token: 0x06006192 RID: 24978 RVA: 0x00378C45 File Offset: 0x00376E45
		internal virtual FetchTransferDetailsToTableAdapter FetchTransferDetailsToTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06006193 RID: 24979 RVA: 0x00378C50 File Offset: 0x00376E50
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

		// Token: 0x06006194 RID: 24980 RVA: 0x00378CF0 File Offset: 0x00376EF0
		private void WarehouseStockTransfer_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadBranches();
				this.LoadBranchStock(this.cboBranch.Text);
				this.LoadWarehouseStock();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06006195 RID: 24981 RVA: 0x00378D58 File Offset: 0x00376F58
		private void LoadWarehouseStock()
		{
			this.dgvWarehouse.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "CurrentStockLevels";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", 0);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			this.dgvWarehouse.DataSource = dataTable;
			this.dgvWarehouse.Columns["ReorderLevel"].Visible = false;
			this.dgvWarehouse.Columns["ProductID"].Visible = false;
			DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
			dataGridViewCheckBoxColumn.HeaderText = "Select";
			dataGridViewCheckBoxColumn.Name = "CHKcol";
			dataGridViewCheckBoxColumn.DataPropertyName = "CHKcol";
			dataGridViewCheckBoxColumn.CellTemplate = new DataGridViewCheckBoxCell();
			this.dgvWarehouse.Columns.Insert(5, dataGridViewCheckBoxColumn);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn.HeaderText = "Enter Quanity to be transfered";
			dataGridViewTextBoxColumn.Name = "QTYcol";
			dataGridViewTextBoxColumn.DataPropertyName = "QTYcol";
			dataGridViewTextBoxColumn.CellTemplate = new DataGridViewTextBoxCell();
			this.dgvWarehouse.Columns.Insert(6, dataGridViewTextBoxColumn);
			this.dgvWarehouse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.GroupBox1.Text = "Warehouse Stock Balances";
		}

		// Token: 0x06006196 RID: 24982 RVA: 0x00378EF4 File Offset: 0x003770F4
		private void LoadBranchStock(string branch)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "CurrentStockLevels";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			this.dgvBranchStock.DataSource = dataTable;
			this.dgvBranchStock.Columns["ReorderLevel"].Visible = false;
			this.dgvBranchStock.Columns["ProductID"].Visible = false;
			this.dgvBranchStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.GroupBox2.Text = "Stock Balances for Branch: " + branch;
		}

		// Token: 0x06006197 RID: 24983 RVA: 0x00378FE0 File Offset: 0x003771E0
		private void cboBranch_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.LoadBranchStock(this.cboBranch.Text);
			}
			catch (InvalidCastException ex)
			{
			}
		}

		// Token: 0x06006198 RID: 24984 RVA: 0x00379024 File Offset: 0x00377224
		private void Button1_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					bool flag = Operators.CompareString(this.txtRef.Text, "", false) != 0;
					if (flag)
					{
						int invoiceNum = this.GetInvoiceNum();
						int num = 0;
						int num2 = 0;
						int num3 = this.dgvWarehouse.Rows.Count - 1;
						for (int i = 0; i <= num3; i++)
						{
							object objectValue = RuntimeHelpers.GetObjectValue(this.dgvWarehouse.Rows[i].Cells["StockBalance"].Value);
							object objectValue2 = RuntimeHelpers.GetObjectValue(this.dgvWarehouse.Rows[i].Cells["QTYcol"].Value);
							object objectValue3 = RuntimeHelpers.GetObjectValue(this.dgvWarehouse.Rows[i].Cells["CHKcol"].Value);
							object objectValue4 = RuntimeHelpers.GetObjectValue(this.dgvWarehouse.Rows[i].Cells["ProductCode"].Value);
							object objectValue5 = RuntimeHelpers.GetObjectValue(this.dgvWarehouse.Rows[i].Cells["ProductID"].Value);
							bool flag2 = Operators.ConditionalCompareObjectEqual(objectValue3, true, false);
							if (flag2)
							{
								bool flag3 = Operators.ConditionalCompareObjectGreaterEqual(Operators.SubtractObject(objectValue, objectValue2), 0, false);
								if (flag3)
								{
									this.TransferStock(Conversions.ToString(0), this.cboBranch.Text, (int)Math.Round(Conversion.Val(DateTime.Today.Date.ToString("yyyyMMdd"))), invoiceNum, Conversions.ToInteger(objectValue5), this.txtRef.Text, Conversions.ToDecimal(objectValue2), MyProject.Forms.Form1.username, (int)Math.Round(Conversion.Val(DateTime.Today.Date.ToString("yyyyMMdd"))), Conversions.ToString(objectValue4), MyProject.Forms.Form1.coid);
									num++;
									num2 = Conversions.ToInteger(Operators.AddObject(num2, objectValue2));
								}
								else
								{
									MessageBox.Show("Cannot transfer a quantity greater than the stock balance.");
								}
							}
						}
						bool flag4 = num > 0;
						if (flag4)
						{
							this.RunReport(invoiceNum);
							MessageBox.Show(string.Concat(new string[]
							{
								"Stock successfully transfered. ",
								Conversions.ToString(num),
								" stock products transfered. ",
								Conversions.ToString(num2),
								" total items transfered."
							}));
							this.lblinfo.Text = string.Concat(new string[]
							{
								"Stock successfully transfered. ",
								Conversions.ToString(num),
								" stock products transfered.",
								Conversions.ToString(num2),
								" total items transfered."
							});
							this.lblinfo.ForeColor = Color.Blue;
						}
						else
						{
							MessageBox.Show("NO stock items transfered.");
							this.lblinfo.Text = "NO stock items transfered.";
							this.lblinfo.ForeColor = Color.Red;
						}
						this.LoadWarehouseStock();
						this.LoadBranchStock(this.cboBranch.Text);
					}
					else
					{
						MessageBox.Show("Please enter a reference number first.");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Stock transfer failed. Detail: " + ex.Message);
				}
			}
		}

		// Token: 0x06006199 RID: 24985 RVA: 0x003793B0 File Offset: 0x003775B0
		private void TransferStock(string branchfrom, string branchto, int trandate, int invoicenum, int productid, string @ref, decimal quantity, string doneby, int donewhen, string productcode, int coid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "TransferStock";
			sqlCommand.Parameters.AddWithValue("trandate", trandate);
			sqlCommand.Parameters.AddWithValue("invoicenum", invoicenum);
			sqlCommand.Parameters.AddWithValue("productid", productid);
			sqlCommand.Parameters.AddWithValue("ref", @ref);
			sqlCommand.Parameters.AddWithValue("quantity", quantity);
			sqlCommand.Parameters.AddWithValue("doneby", doneby);
			sqlCommand.Parameters.AddWithValue("donewhen", donewhen);
			sqlCommand.Parameters.AddWithValue("productcode", productcode);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branchfrom", branchfrom);
			sqlCommand.Parameters.AddWithValue("branchto", branchto);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x0600619A RID: 24986 RVA: 0x00379508 File Offset: 0x00377708
		private int GetInvoiceNum()
		{
			int num = 0;
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetNewInvoiceNumber";
			sqlCommand.Parameters.AddWithValue("desc", DateTime.Today.ToString("yyyyMMdd") + DateAndTime.Now.TimeOfDay.ToString());
			sqlCommand.Parameters.AddWithValue("newinvoicenum", 0);
			using (sqlConnection)
			{
				sqlConnection.Open();
				num = Conversions.ToInteger(sqlCommand.ExecuteScalar());
				sqlConnection.Close();
			}
			return num;
		}

		// Token: 0x0600619B RID: 24987 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label3_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x0600619C RID: 24988 RVA: 0x003795E0 File Offset: 0x003777E0
		private void RunReport(int invoicenumber)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
				this.GetCompanyDetailsTableAdapter.Connection = sqlConnection;
				this.FetchBranchFromforTransferTableAdapter.Connection = sqlConnection;
				this.FetchBranchToforTransferTableAdapter.Connection = sqlConnection;
				this.FetchTransferDetailsTableAdapter.Connection = sqlConnection;
				this.FetchTransferDetailsToTableAdapter.Connection = sqlConnection;
				ReportParameter reportParameter = new ReportParameter("invoicenum", Conversions.ToString(invoicenumber));
				ReportParameter reportParameter2 = new ReportParameter("coid", Conversions.ToString(MyProject.Forms.Form1.coid));
				ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter2 };
				this.ReportViewer1.LocalReport.SetParameters(array);
				this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
				this.FetchBranchFromforTransferTableAdapter.Fill(this.POSDataSet.FetchBranchFromforTransfer, new int?(invoicenumber), new int?(MyProject.Forms.Form1.coid));
				this.FetchBranchToforTransferTableAdapter.Fill(this.POSDataSet.FetchBranchToforTransfer, new int?(invoicenumber), new int?(MyProject.Forms.Form1.coid));
				this.FetchTransferDetailsTableAdapter.Fill(this.POSDataSet.FetchTransferDetails, new int?(invoicenumber), new int?(MyProject.Forms.Form1.coid));
				this.FetchTransferDetailsToTableAdapter.Fill(this.POSDataSet.FetchTransferDetailsTo, new int?(invoicenumber), new int?(MyProject.Forms.Form1.coid));
				this.ReportViewer1.RefreshReport();
				this.savepdf(Conversions.ToString(invoicenumber), this.txtRef.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying report. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600619D RID: 24989 RVA: 0x003797DC File Offset: 0x003779DC
		private void savepdf(string invnumString, string @ref)
		{
			byte[] array = this.ReportViewer1.LocalReport.Render("PDF");
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "*PDF files (*.pdf)|*.pdf";
			saveFileDialog.FilterIndex = 2;
			saveFileDialog.RestoreDirectory = true;
			bool flag = !Directory.Exists("C:\\StockTransfers");
			if (flag)
			{
				Directory.CreateDirectory("C:\\StockTransfers");
			}
			FileStream fileStream = new FileStream("C:\\StockTransfers\\StockTransfer_" + invnumString + ".pdf", FileMode.Create);
			fileStream.Write(array, 0, array.Length);
			fileStream.Close();
			MessageBox.Show("Stock Transfer report saved in c:\\StockTransfers.");
		}

		// Token: 0x04002AF0 RID: 10992
		private string _cnn;
	}
}
