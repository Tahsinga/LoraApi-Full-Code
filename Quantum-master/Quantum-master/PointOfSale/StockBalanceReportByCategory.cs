using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;
using PointOfSale.POSDataSetTableAdapters;

namespace PointOfSale
{
	// Token: 0x020001E3 RID: 483
	[DesignerGenerated]
	public partial class StockBalanceReportByCategory : UserControl
	{
		// Token: 0x060054BB RID: 21691 RVA: 0x0031105C File Offset: 0x0030F25C
		public StockBalanceReportByCategory()
		{
			base.Load += this.StockBalanceReportByCategory_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x17001E68 RID: 7784
		// (get) Token: 0x060054BE RID: 21694 RVA: 0x00311F88 File Offset: 0x00310188
		// (set) Token: 0x060054BF RID: 21695 RVA: 0x00311F92 File Offset: 0x00310192
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E69 RID: 7785
		// (get) Token: 0x060054C0 RID: 21696 RVA: 0x00311F9B File Offset: 0x0031019B
		// (set) Token: 0x060054C1 RID: 21697 RVA: 0x00311FA5 File Offset: 0x003101A5
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E6A RID: 7786
		// (get) Token: 0x060054C2 RID: 21698 RVA: 0x00311FAE File Offset: 0x003101AE
		// (set) Token: 0x060054C3 RID: 21699 RVA: 0x00311FB8 File Offset: 0x003101B8
		internal virtual CheckBox chkWithFigures
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E6B RID: 7787
		// (get) Token: 0x060054C4 RID: 21700 RVA: 0x00311FC1 File Offset: 0x003101C1
		// (set) Token: 0x060054C5 RID: 21701 RVA: 0x00311FCB File Offset: 0x003101CB
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E6C RID: 7788
		// (get) Token: 0x060054C6 RID: 21702 RVA: 0x00311FD4 File Offset: 0x003101D4
		// (set) Token: 0x060054C7 RID: 21703 RVA: 0x00311FDE File Offset: 0x003101DE
		internal virtual CheckBox chkBins
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E6D RID: 7789
		// (get) Token: 0x060054C8 RID: 21704 RVA: 0x00311FE7 File Offset: 0x003101E7
		// (set) Token: 0x060054C9 RID: 21705 RVA: 0x00311FF1 File Offset: 0x003101F1
		internal virtual DateTimePicker DTStartdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E6E RID: 7790
		// (get) Token: 0x060054CA RID: 21706 RVA: 0x00311FFA File Offset: 0x003101FA
		// (set) Token: 0x060054CB RID: 21707 RVA: 0x00312004 File Offset: 0x00310204
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E6F RID: 7791
		// (get) Token: 0x060054CC RID: 21708 RVA: 0x0031200D File Offset: 0x0031020D
		// (set) Token: 0x060054CD RID: 21709 RVA: 0x00312018 File Offset: 0x00310218
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

		// Token: 0x17001E70 RID: 7792
		// (get) Token: 0x060054CE RID: 21710 RVA: 0x0031205B File Offset: 0x0031025B
		// (set) Token: 0x060054CF RID: 21711 RVA: 0x00312065 File Offset: 0x00310265
		internal virtual ComboBox cbobins
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E71 RID: 7793
		// (get) Token: 0x060054D0 RID: 21712 RVA: 0x0031206E File Offset: 0x0031026E
		// (set) Token: 0x060054D1 RID: 21713 RVA: 0x00312078 File Offset: 0x00310278
		internal virtual ComboBox cboBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E72 RID: 7794
		// (get) Token: 0x060054D2 RID: 21714 RVA: 0x00312081 File Offset: 0x00310281
		// (set) Token: 0x060054D3 RID: 21715 RVA: 0x0031208B File Offset: 0x0031028B
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E73 RID: 7795
		// (get) Token: 0x060054D4 RID: 21716 RVA: 0x00312094 File Offset: 0x00310294
		// (set) Token: 0x060054D5 RID: 21717 RVA: 0x0031209E File Offset: 0x0031029E
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E74 RID: 7796
		// (get) Token: 0x060054D6 RID: 21718 RVA: 0x003120A7 File Offset: 0x003102A7
		// (set) Token: 0x060054D7 RID: 21719 RVA: 0x003120B1 File Offset: 0x003102B1
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E75 RID: 7797
		// (get) Token: 0x060054D8 RID: 21720 RVA: 0x003120BA File Offset: 0x003102BA
		// (set) Token: 0x060054D9 RID: 21721 RVA: 0x003120C4 File Offset: 0x003102C4
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E76 RID: 7798
		// (get) Token: 0x060054DA RID: 21722 RVA: 0x003120CD File Offset: 0x003102CD
		// (set) Token: 0x060054DB RID: 21723 RVA: 0x003120D7 File Offset: 0x003102D7
		internal virtual BindingSource StockBalancesReportBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E77 RID: 7799
		// (get) Token: 0x060054DC RID: 21724 RVA: 0x003120E0 File Offset: 0x003102E0
		// (set) Token: 0x060054DD RID: 21725 RVA: 0x003120EA File Offset: 0x003102EA
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E78 RID: 7800
		// (get) Token: 0x060054DE RID: 21726 RVA: 0x003120F3 File Offset: 0x003102F3
		// (set) Token: 0x060054DF RID: 21727 RVA: 0x003120FD File Offset: 0x003102FD
		internal virtual StockBalancesReportTableAdapter StockBalancesReportTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E79 RID: 7801
		// (get) Token: 0x060054E0 RID: 21728 RVA: 0x00312106 File Offset: 0x00310306
		// (set) Token: 0x060054E1 RID: 21729 RVA: 0x00312110 File Offset: 0x00310310
		internal virtual CheckBox chkCat
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E7A RID: 7802
		// (get) Token: 0x060054E2 RID: 21730 RVA: 0x00312119 File Offset: 0x00310319
		// (set) Token: 0x060054E3 RID: 21731 RVA: 0x00312123 File Offset: 0x00310323
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E7B RID: 7803
		// (get) Token: 0x060054E4 RID: 21732 RVA: 0x0031212C File Offset: 0x0031032C
		// (set) Token: 0x060054E5 RID: 21733 RVA: 0x00312136 File Offset: 0x00310336
		internal virtual ComboBox cboCategories
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E7C RID: 7804
		// (get) Token: 0x060054E6 RID: 21734 RVA: 0x0031213F File Offset: 0x0031033F
		// (set) Token: 0x060054E7 RID: 21735 RVA: 0x0031214C File Offset: 0x0031034C
		internal virtual Label Label4
		{
			[CompilerGenerated]
			get
			{
				return this._Label4;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label4_Click);
				Label label = this._Label4;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label4 = value;
				label = this._Label4;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x17001E7D RID: 7805
		// (get) Token: 0x060054E8 RID: 21736 RVA: 0x0031218F File Offset: 0x0031038F
		// (set) Token: 0x060054E9 RID: 21737 RVA: 0x00312199 File Offset: 0x00310399
		internal virtual CheckBox chkBranches
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E7E RID: 7806
		// (get) Token: 0x060054EA RID: 21738 RVA: 0x003121A2 File Offset: 0x003103A2
		// (set) Token: 0x060054EB RID: 21739 RVA: 0x003121AC File Offset: 0x003103AC
		internal virtual CheckBox cboWithStockBalOnly
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060054EC RID: 21740 RVA: 0x003121B8 File Offset: 0x003103B8
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

		// Token: 0x060054ED RID: 21741 RVA: 0x00312258 File Offset: 0x00310458
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
				this.GetCompanyDetailsTableAdapter.Connection = sqlConnection;
				this.StockBalancesReportTableAdapter.Connection = sqlConnection;
				ReportParameter reportParameter = new ReportParameter("datedesc", this.DTStartdate.Value.ToShortDateString());
				int? num = null;
				int num2 = Conversions.ToInteger(Interaction.IIf(this.cboWithStockBalOnly.Checked, 1, 0));
				bool @checked = this.chkBins.Checked;
				string text4;
				string text5;
				if (@checked)
				{
					bool checked2 = this.chkCat.Checked;
					if (checked2)
					{
						bool checked3 = this.chkBranches.Checked;
						if (checked3)
						{
							string text = "All Branches";
							string text2 = "All Bin Locations";
							string text3 = "All Categories";
							ReportParameter reportParameter2 = new ReportParameter("branchdesc", text);
							ReportParameter reportParameter3 = new ReportParameter("catiddesc", text3);
							ReportParameter reportParameter4 = new ReportParameter("binlocdesc", text2);
							ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter4, reportParameter3, reportParameter2 };
							this.ReportViewer1.LocalReport.SetParameters(array);
						}
						else
						{
							string text = this.cboBranch.Text;
							text4 = this.cboBranch.Text;
							string text2 = "All Bin Locations";
							string text3 = "All Categories";
							ReportParameter reportParameter5 = new ReportParameter("branch", text4);
							ReportParameter reportParameter6 = new ReportParameter("branchdesc", text);
							ReportParameter reportParameter7 = new ReportParameter("catiddesc", text3);
							ReportParameter reportParameter8 = new ReportParameter("binlocdesc", text2);
							ReportParameter[] array2 = new ReportParameter[] { reportParameter, reportParameter5, reportParameter8, reportParameter7, reportParameter6 };
							this.ReportViewer1.LocalReport.SetParameters(array2);
						}
					}
					else
					{
						bool checked4 = this.chkBranches.Checked;
						if (checked4)
						{
							string text = "All Branches";
							ReportParameter reportParameter9 = new ReportParameter("branchdesc", text);
							string text2 = "All Bin Locations";
							string text3 = this.cboCategories.Text;
							num = (int?)this.cboCategories.SelectedValue;
							ReportParameter reportParameter10 = new ReportParameter("catid", Conversions.ToString(num.Value));
							ReportParameter reportParameter11 = new ReportParameter("catiddesc", text3);
							ReportParameter reportParameter12 = new ReportParameter("binlocdesc", text2);
							ReportParameter[] array3 = new ReportParameter[] { reportParameter, reportParameter12, reportParameter10, reportParameter11, reportParameter9 };
							this.ReportViewer1.LocalReport.SetParameters(array3);
						}
						else
						{
							string text = this.cboBranch.Text;
							text4 = this.cboBranch.Text;
							ReportParameter reportParameter13 = new ReportParameter("branchdesc", text);
							ReportParameter reportParameter14 = new ReportParameter("branch", text4);
							string text2 = "All Bin Locations";
							string text3 = this.cboCategories.Text;
							num = (int?)this.cboCategories.SelectedValue;
							ReportParameter reportParameter15 = new ReportParameter("catid", Conversions.ToString(num.Value));
							ReportParameter reportParameter16 = new ReportParameter("catiddesc", text3);
							ReportParameter reportParameter17 = new ReportParameter("binlocdesc", text2);
							ReportParameter[] array4 = new ReportParameter[] { reportParameter, reportParameter17, reportParameter15, reportParameter16, reportParameter13, reportParameter14 };
							this.ReportViewer1.LocalReport.SetParameters(array4);
						}
					}
				}
				else
				{
					bool checked5 = this.chkCat.Checked;
					if (checked5)
					{
						bool checked6 = this.chkBranches.Checked;
						if (checked6)
						{
							string text = "All Branches";
							ReportParameter reportParameter18 = new ReportParameter("branchdesc", text);
							string text3 = "All Categories";
							ReportParameter reportParameter19 = new ReportParameter("catiddesc", text3);
							text5 = this.cbobins.SelectedValue.ToString();
							ReportParameter reportParameter20 = new ReportParameter("binloc", text5);
							string text2 = this.cbobins.SelectedValue.ToString();
							ReportParameter reportParameter21 = new ReportParameter("binlocdesc", text2);
							ReportParameter[] array5 = new ReportParameter[] { reportParameter, reportParameter20, reportParameter21, reportParameter19, reportParameter18 };
							this.ReportViewer1.LocalReport.SetParameters(array5);
						}
						else
						{
							string text = this.cboBranch.Text;
							text4 = this.cboBranch.Text;
							ReportParameter reportParameter22 = new ReportParameter("branch", text4);
							ReportParameter reportParameter23 = new ReportParameter("branchdesc", text);
							string text3 = "All Categories";
							ReportParameter reportParameter24 = new ReportParameter("catiddesc", text3);
							text5 = this.cbobins.SelectedValue.ToString();
							ReportParameter reportParameter25 = new ReportParameter("binloc", text5);
							string text2 = this.cbobins.SelectedValue.ToString();
							ReportParameter reportParameter26 = new ReportParameter("binlocdesc", text2);
							ReportParameter[] array6 = new ReportParameter[] { reportParameter, reportParameter25, reportParameter26, reportParameter24, reportParameter23, reportParameter22 };
							this.ReportViewer1.LocalReport.SetParameters(array6);
						}
					}
					else
					{
						bool checked7 = this.chkBranches.Checked;
						if (checked7)
						{
							string text = "All Branches";
							ReportParameter reportParameter27 = new ReportParameter("branchdesc", text);
							num = new int?(Conversions.ToInteger(this.cboCategories.SelectedValue.ToString()));
							ReportParameter reportParameter28 = new ReportParameter("catid", Conversions.ToString(num.Value));
							string text3 = this.cboCategories.SelectedValue.ToString();
							ReportParameter reportParameter29 = new ReportParameter("catiddesc", text3);
							text5 = this.cbobins.SelectedValue.ToString();
							ReportParameter reportParameter30 = new ReportParameter("binloc", text5);
							string text2 = this.cbobins.SelectedValue.ToString();
							ReportParameter reportParameter31 = new ReportParameter("binlocdesc", text2);
							ReportParameter[] array7 = new ReportParameter[] { reportParameter, reportParameter30, reportParameter31, reportParameter29, reportParameter28, reportParameter27 };
							this.ReportViewer1.LocalReport.SetParameters(array7);
						}
						else
						{
							string text = this.cboBranch.Text;
							text4 = this.cboBranch.Text;
							ReportParameter reportParameter32 = new ReportParameter("branch", text4);
							ReportParameter reportParameter33 = new ReportParameter("branchdesc", text);
							num = new int?(Conversions.ToInteger(this.cboCategories.SelectedValue.ToString()));
							ReportParameter reportParameter34 = new ReportParameter("catid", Conversions.ToString(num.Value));
							string text3 = this.cboCategories.SelectedValue.ToString();
							ReportParameter reportParameter35 = new ReportParameter("catiddesc", text3);
							text5 = this.cbobins.SelectedValue.ToString();
							ReportParameter reportParameter36 = new ReportParameter("binloc", text5);
							string text2 = this.cbobins.SelectedValue.ToString();
							ReportParameter reportParameter37 = new ReportParameter("binlocdesc", text2);
							ReportParameter[] array8 = new ReportParameter[] { reportParameter, reportParameter36, reportParameter37, reportParameter35, reportParameter34, reportParameter33, reportParameter32 };
							this.ReportViewer1.LocalReport.SetParameters(array8);
						}
					}
				}
				this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
				this.StockBalancesReportTableAdapter.Fill(this.POSDataSet.StockBalancesReport, new int?(MyProject.Forms.Form1.coid), text4, new int?(Convert.ToInt32(DateTime.Today.ToString("yyyyMMdd"))), text5, num, new int?(num2));
				this.ReportViewer1.RefreshReport();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying report. Detail: " + ex.Message);
			}
		}

		// Token: 0x060054EE RID: 21742 RVA: 0x00312A0C File Offset: 0x00310C0C
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

		// Token: 0x060054EF RID: 21743 RVA: 0x00312AAC File Offset: 0x00310CAC
		private void StockBalanceReportByCategory_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadBranches();
				this.LoadCategories();
				this.cbobins.DataSource = this.pf.GetBinLocs(this._cnn);
				this.cbobins.DisplayMember = "BinLocation";
				this.cbobins.ValueMember = "BinLocation";
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x060054F0 RID: 21744 RVA: 0x00312B40 File Offset: 0x00310D40
		private void Label4_Click(object sender, EventArgs e)
		{
			try
			{
				base.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error closing form. Detail: " + ex.Message);
			}
		}

		// Token: 0x04002514 RID: 9492
		private string _cnn;

		// Token: 0x04002515 RID: 9493
		private PublicFunctions pf;
	}
}
