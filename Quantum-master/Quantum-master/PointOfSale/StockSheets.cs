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
	// Token: 0x020001F0 RID: 496
	[DesignerGenerated]
	public partial class StockSheets : UserControl
	{
		// Token: 0x06005793 RID: 22419 RVA: 0x00325D14 File Offset: 0x00323F14
		public StockSheets()
		{
			base.Load += this.StockBalances_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x17001F7D RID: 8061
		// (get) Token: 0x06005796 RID: 22422 RVA: 0x00326864 File Offset: 0x00324A64
		// (set) Token: 0x06005797 RID: 22423 RVA: 0x0032686E File Offset: 0x00324A6E
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F7E RID: 8062
		// (get) Token: 0x06005798 RID: 22424 RVA: 0x00326877 File Offset: 0x00324A77
		// (set) Token: 0x06005799 RID: 22425 RVA: 0x00326881 File Offset: 0x00324A81
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F7F RID: 8063
		// (get) Token: 0x0600579A RID: 22426 RVA: 0x0032688A File Offset: 0x00324A8A
		// (set) Token: 0x0600579B RID: 22427 RVA: 0x00326894 File Offset: 0x00324A94
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F80 RID: 8064
		// (get) Token: 0x0600579C RID: 22428 RVA: 0x0032689D File Offset: 0x00324A9D
		// (set) Token: 0x0600579D RID: 22429 RVA: 0x003268A7 File Offset: 0x00324AA7
		internal virtual ComboBox cboBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F81 RID: 8065
		// (get) Token: 0x0600579E RID: 22430 RVA: 0x003268B0 File Offset: 0x00324AB0
		// (set) Token: 0x0600579F RID: 22431 RVA: 0x003268BA File Offset: 0x00324ABA
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F82 RID: 8066
		// (get) Token: 0x060057A0 RID: 22432 RVA: 0x003268C3 File Offset: 0x00324AC3
		// (set) Token: 0x060057A1 RID: 22433 RVA: 0x003268D0 File Offset: 0x00324AD0
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

		// Token: 0x17001F83 RID: 8067
		// (get) Token: 0x060057A2 RID: 22434 RVA: 0x00326913 File Offset: 0x00324B13
		// (set) Token: 0x060057A3 RID: 22435 RVA: 0x00326920 File Offset: 0x00324B20
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

		// Token: 0x17001F84 RID: 8068
		// (get) Token: 0x060057A4 RID: 22436 RVA: 0x00326963 File Offset: 0x00324B63
		// (set) Token: 0x060057A5 RID: 22437 RVA: 0x0032696D File Offset: 0x00324B6D
		internal virtual DateTimePicker DTStartdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F85 RID: 8069
		// (get) Token: 0x060057A6 RID: 22438 RVA: 0x00326976 File Offset: 0x00324B76
		// (set) Token: 0x060057A7 RID: 22439 RVA: 0x00326980 File Offset: 0x00324B80
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F86 RID: 8070
		// (get) Token: 0x060057A8 RID: 22440 RVA: 0x00326989 File Offset: 0x00324B89
		// (set) Token: 0x060057A9 RID: 22441 RVA: 0x00326993 File Offset: 0x00324B93
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F87 RID: 8071
		// (get) Token: 0x060057AA RID: 22442 RVA: 0x0032699C File Offset: 0x00324B9C
		// (set) Token: 0x060057AB RID: 22443 RVA: 0x003269A6 File Offset: 0x00324BA6
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F88 RID: 8072
		// (get) Token: 0x060057AC RID: 22444 RVA: 0x003269AF File Offset: 0x00324BAF
		// (set) Token: 0x060057AD RID: 22445 RVA: 0x003269B9 File Offset: 0x00324BB9
		internal virtual CheckBox chkBins
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F89 RID: 8073
		// (get) Token: 0x060057AE RID: 22446 RVA: 0x003269C2 File Offset: 0x00324BC2
		// (set) Token: 0x060057AF RID: 22447 RVA: 0x003269CC File Offset: 0x00324BCC
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F8A RID: 8074
		// (get) Token: 0x060057B0 RID: 22448 RVA: 0x003269D5 File Offset: 0x00324BD5
		// (set) Token: 0x060057B1 RID: 22449 RVA: 0x003269DF File Offset: 0x00324BDF
		internal virtual ComboBox cbobins
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F8B RID: 8075
		// (get) Token: 0x060057B2 RID: 22450 RVA: 0x003269E8 File Offset: 0x00324BE8
		// (set) Token: 0x060057B3 RID: 22451 RVA: 0x003269F2 File Offset: 0x00324BF2
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F8C RID: 8076
		// (get) Token: 0x060057B4 RID: 22452 RVA: 0x003269FB File Offset: 0x00324BFB
		// (set) Token: 0x060057B5 RID: 22453 RVA: 0x00326A05 File Offset: 0x00324C05
		internal virtual CheckBox chkWithFigures
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F8D RID: 8077
		// (get) Token: 0x060057B6 RID: 22454 RVA: 0x00326A0E File Offset: 0x00324C0E
		// (set) Token: 0x060057B7 RID: 22455 RVA: 0x00326A18 File Offset: 0x00324C18
		internal virtual BindingSource ReportFetchAllProductBalsAsAt21BindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001F8E RID: 8078
		// (get) Token: 0x060057B8 RID: 22456 RVA: 0x00326A21 File Offset: 0x00324C21
		// (set) Token: 0x060057B9 RID: 22457 RVA: 0x00326A2B File Offset: 0x00324C2B
		internal virtual ReportFetchAllProductBalsAsAt21TableAdapter ReportFetchAllProductBalsAsAt21TableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060057BA RID: 22458 RVA: 0x00326A34 File Offset: 0x00324C34
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

		// Token: 0x060057BB RID: 22459 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label3_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x060057BC RID: 22460 RVA: 0x00326AD4 File Offset: 0x00324CD4
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
				this.GetCompanyDetailsTableAdapter.Connection = sqlConnection;
				this.ReportFetchAllProductBalsAsAt21TableAdapter.Connection = sqlConnection;
				ReportParameter reportParameter = new ReportParameter("StartDateDesc", this.DTStartdate.Value.ToShortDateString());
				ReportParameter reportParameter2 = new ReportParameter("coid", Conversions.ToString(MyProject.Forms.Form1.coid));
				ReportParameter reportParameter3 = new ReportParameter("branch", this.cboBranch.Text);
				ReportParameter reportParameter4 = new ReportParameter("theday", Conversions.ToString(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))));
				bool @checked = this.chkWithFigures.Checked;
				int num;
				if (@checked)
				{
					num = 1;
				}
				else
				{
					num = 0;
				}
				ReportParameter reportParameter5 = new ReportParameter("WithFigures", Conversions.ToString(num));
				bool checked2 = this.chkBins.Checked;
				string text2;
				if (checked2)
				{
					string text = "All Bin Locations";
					ReportParameter reportParameter6 = new ReportParameter("binlocdesc", text);
					ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter2, reportParameter3, reportParameter4, reportParameter6, reportParameter5 };
					this.ReportViewer1.LocalReport.SetParameters(array);
				}
				else
				{
					text2 = this.cbobins.SelectedValue.ToString();
					ReportParameter reportParameter7 = new ReportParameter("binloc", text2);
					string text = this.cbobins.SelectedValue.ToString();
					ReportParameter reportParameter8 = new ReportParameter("binlocdesc", text);
					ReportParameter[] array2 = new ReportParameter[] { reportParameter, reportParameter2, reportParameter3, reportParameter4, reportParameter7, reportParameter8, reportParameter5 };
					this.ReportViewer1.LocalReport.SetParameters(array2);
				}
				this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
				this.ReportFetchAllProductBalsAsAt21TableAdapter.Fill(this.POSDataSet.ReportFetchAllProductBalsAsAt21, new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text, new int?(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))), text2, MyProject.Forms.Form1.username);
				this.ReportViewer1.RefreshReport();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying report. Detail: " + ex.Message);
			}
		}

		// Token: 0x060057BD RID: 22461 RVA: 0x00326D7C File Offset: 0x00324F7C
		private void StockBalances_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadBranches();
				this.cbobins.DataSource = this.pf.GetBinLocs(this._cnn);
				this.cbobins.DisplayMember = "BinLocation";
				this.cbobins.ValueMember = "BinLocation";
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x0400264A RID: 9802
		private string _cnn;

		// Token: 0x0400264B RID: 9803
		private PublicFunctions pf;
	}
}
