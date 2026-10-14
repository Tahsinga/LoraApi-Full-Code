using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;
using PointOfSale.POSDataSetTableAdapters;

namespace PointOfSale
{
	// Token: 0x02000160 RID: 352
	[DesignerGenerated]
	public partial class PriceList : Form
	{
		// Token: 0x06002ED5 RID: 11989 RVA: 0x00196F88 File Offset: 0x00195188
		public PriceList()
		{
			base.Load += this.PriceList_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x17001168 RID: 4456
		// (get) Token: 0x06002ED8 RID: 11992 RVA: 0x00197DEE File Offset: 0x00195FEE
		// (set) Token: 0x06002ED9 RID: 11993 RVA: 0x00197DF8 File Offset: 0x00195FF8
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001169 RID: 4457
		// (get) Token: 0x06002EDA RID: 11994 RVA: 0x00197E01 File Offset: 0x00196001
		// (set) Token: 0x06002EDB RID: 11995 RVA: 0x00197E0B File Offset: 0x0019600B
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700116A RID: 4458
		// (get) Token: 0x06002EDC RID: 11996 RVA: 0x00197E14 File Offset: 0x00196014
		// (set) Token: 0x06002EDD RID: 11997 RVA: 0x00197E20 File Offset: 0x00196020
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

		// Token: 0x1700116B RID: 4459
		// (get) Token: 0x06002EDE RID: 11998 RVA: 0x00197E63 File Offset: 0x00196063
		// (set) Token: 0x06002EDF RID: 11999 RVA: 0x00197E6D File Offset: 0x0019606D
		internal virtual ComboBox cmbFontSize
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700116C RID: 4460
		// (get) Token: 0x06002EE0 RID: 12000 RVA: 0x00197E76 File Offset: 0x00196076
		// (set) Token: 0x06002EE1 RID: 12001 RVA: 0x00197E80 File Offset: 0x00196080
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700116D RID: 4461
		// (get) Token: 0x06002EE2 RID: 12002 RVA: 0x00197E89 File Offset: 0x00196089
		// (set) Token: 0x06002EE3 RID: 12003 RVA: 0x00197E93 File Offset: 0x00196093
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700116E RID: 4462
		// (get) Token: 0x06002EE4 RID: 12004 RVA: 0x00197E9C File Offset: 0x0019609C
		// (set) Token: 0x06002EE5 RID: 12005 RVA: 0x00197EA6 File Offset: 0x001960A6
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700116F RID: 4463
		// (get) Token: 0x06002EE6 RID: 12006 RVA: 0x00197EAF File Offset: 0x001960AF
		// (set) Token: 0x06002EE7 RID: 12007 RVA: 0x00197EB9 File Offset: 0x001960B9
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001170 RID: 4464
		// (get) Token: 0x06002EE8 RID: 12008 RVA: 0x00197EC2 File Offset: 0x001960C2
		// (set) Token: 0x06002EE9 RID: 12009 RVA: 0x00197ECC File Offset: 0x001960CC
		internal virtual BindingSource GetProductPricesBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001171 RID: 4465
		// (get) Token: 0x06002EEA RID: 12010 RVA: 0x00197ED5 File Offset: 0x001960D5
		// (set) Token: 0x06002EEB RID: 12011 RVA: 0x00197EDF File Offset: 0x001960DF
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001172 RID: 4466
		// (get) Token: 0x06002EEC RID: 12012 RVA: 0x00197EE8 File Offset: 0x001960E8
		// (set) Token: 0x06002EED RID: 12013 RVA: 0x00197EF2 File Offset: 0x001960F2
		internal virtual GetProductPricesTableAdapter GetProductPricesTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001173 RID: 4467
		// (get) Token: 0x06002EEE RID: 12014 RVA: 0x00197EFB File Offset: 0x001960FB
		// (set) Token: 0x06002EEF RID: 12015 RVA: 0x00197F05 File Offset: 0x00196105
		internal virtual ComboBox cmbPayMethods
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001174 RID: 4468
		// (get) Token: 0x06002EF0 RID: 12016 RVA: 0x00197F0E File Offset: 0x0019610E
		// (set) Token: 0x06002EF1 RID: 12017 RVA: 0x00197F18 File Offset: 0x00196118
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001175 RID: 4469
		// (get) Token: 0x06002EF2 RID: 12018 RVA: 0x00197F21 File Offset: 0x00196121
		// (set) Token: 0x06002EF3 RID: 12019 RVA: 0x00197F2B File Offset: 0x0019612B
		internal virtual CheckBox chkCategories
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001176 RID: 4470
		// (get) Token: 0x06002EF4 RID: 12020 RVA: 0x00197F34 File Offset: 0x00196134
		// (set) Token: 0x06002EF5 RID: 12021 RVA: 0x00197F3E File Offset: 0x0019613E
		internal virtual ComboBox cboCategories
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001177 RID: 4471
		// (get) Token: 0x06002EF6 RID: 12022 RVA: 0x00197F47 File Offset: 0x00196147
		// (set) Token: 0x06002EF7 RID: 12023 RVA: 0x00197F51 File Offset: 0x00196151
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001178 RID: 4472
		// (get) Token: 0x06002EF8 RID: 12024 RVA: 0x00197F5A File Offset: 0x0019615A
		// (set) Token: 0x06002EF9 RID: 12025 RVA: 0x00197F64 File Offset: 0x00196164
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001179 RID: 4473
		// (get) Token: 0x06002EFA RID: 12026 RVA: 0x00197F6D File Offset: 0x0019616D
		// (set) Token: 0x06002EFB RID: 12027 RVA: 0x00197F77 File Offset: 0x00196177
		internal virtual ComboBox cboBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700117A RID: 4474
		// (get) Token: 0x06002EFC RID: 12028 RVA: 0x00197F80 File Offset: 0x00196180
		// (set) Token: 0x06002EFD RID: 12029 RVA: 0x00197F8A File Offset: 0x0019618A
		internal virtual ComboBox cboPriceType
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700117B RID: 4475
		// (get) Token: 0x06002EFE RID: 12030 RVA: 0x00197F93 File Offset: 0x00196193
		// (set) Token: 0x06002EFF RID: 12031 RVA: 0x00197F9D File Offset: 0x0019619D
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06002F00 RID: 12032 RVA: 0x00197FA8 File Offset: 0x001961A8
		private void PriceList_Load(object sender, EventArgs e)
		{
			try
			{
				this.cmbFontSize.SelectedIndex = 10;
				this.LoadCategories();
				this.LoadPaymentMethods();
				this.LoadBranches();
				base.WindowState = FormWindowState.Maximized;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06002F01 RID: 12033 RVA: 0x0019801C File Offset: 0x0019621C
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

		// Token: 0x06002F02 RID: 12034 RVA: 0x001980C8 File Offset: 0x001962C8
		private void LoadCategories()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchCategories";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			this.cboCategories.DataSource = dataTable;
			this.cboCategories.ValueMember = "CatID";
			this.cboCategories.DisplayMember = "CatDesc";
		}

		// Token: 0x06002F03 RID: 12035 RVA: 0x00198168 File Offset: 0x00196368
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
			this.cmbPayMethods.DataSource = dataTable;
			this.cmbPayMethods.ValueMember = "PaymentMethodID";
			this.cmbPayMethods.DisplayMember = "PaymentMethodDesc";
			this.cmbPayMethods.SelectedIndex = -1;
		}

		// Token: 0x06002F04 RID: 12036 RVA: 0x00198214 File Offset: 0x00196414
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.cmbFontSize.Text, "", false) != 0;
				if (flag)
				{
					bool flag2 = Operators.CompareString(this.cboPriceType.Text, "", false) != 0;
					if (flag2)
					{
						bool flag3 = Operators.CompareString(this.cboBranch.Text, "", false) != 0;
						if (flag3)
						{
							SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
							this.GetCompanyDetailsTableAdapter.Connection = sqlConnection;
							this.GetProductPricesTableAdapter.Connection = sqlConnection;
							bool flag4 = !this.chkCategories.Checked;
							int? num;
							string text;
							if (flag4)
							{
								num = (int?)this.cboCategories.SelectedValue;
								text = this.cboCategories.Text;
							}
							else
							{
								text = "All Categories";
							}
							ReportParameter reportParameter = new ReportParameter("fontsize", this.cmbFontSize.Text);
							ReportParameter reportParameter2 = new ReportParameter("paymeth", this.cmbPayMethods.Text);
							ReportParameter reportParameter3 = new ReportParameter("Category", text);
							ReportParameter reportParameter4 = new ReportParameter("pricetype", this.cboPriceType.Text);
							ReportParameter reportParameter5 = new ReportParameter("branch", this.cboBranch.Text);
							ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter2, reportParameter3, reportParameter4, reportParameter5 };
							this.ReportViewer1.LocalReport.SetParameters(array);
							this.GetProductPricesTableAdapter.Fill(this.POSDataSet.GetProductPrices, new int?(MyProject.Forms.Form1.coid), (int?)this.cmbPayMethods.SelectedValue, num, this.cboBranch.Text);
							this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
							this.ReportViewer1.RefreshReport();
						}
						else
						{
							MessageBox.Show("Please select branch first.");
						}
					}
					else
					{
						MessageBox.Show("Please select Price Type first");
					}
				}
				else
				{
					MessageBox.Show("Please select the font size first.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error running report. Detail: " + ex.Message);
			}
		}

		// Token: 0x04001429 RID: 5161
		private string _cnn;
	}
}
