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
	// Token: 0x020001E4 RID: 484
	[DesignerGenerated]
	public partial class StockBalances : UserControl
	{
		// Token: 0x060054F1 RID: 21745 RVA: 0x00312B90 File Offset: 0x00310D90
		public StockBalances()
		{
			base.Load += this.StockBalances_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x17001E7F RID: 7807
		// (get) Token: 0x060054F4 RID: 21748 RVA: 0x00313616 File Offset: 0x00311816
		// (set) Token: 0x060054F5 RID: 21749 RVA: 0x00313620 File Offset: 0x00311820
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E80 RID: 7808
		// (get) Token: 0x060054F6 RID: 21750 RVA: 0x00313629 File Offset: 0x00311829
		// (set) Token: 0x060054F7 RID: 21751 RVA: 0x00313633 File Offset: 0x00311833
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E81 RID: 7809
		// (get) Token: 0x060054F8 RID: 21752 RVA: 0x0031363C File Offset: 0x0031183C
		// (set) Token: 0x060054F9 RID: 21753 RVA: 0x00313648 File Offset: 0x00311848
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

		// Token: 0x17001E82 RID: 7810
		// (get) Token: 0x060054FA RID: 21754 RVA: 0x0031368B File Offset: 0x0031188B
		// (set) Token: 0x060054FB RID: 21755 RVA: 0x00313698 File Offset: 0x00311898
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

		// Token: 0x17001E83 RID: 7811
		// (get) Token: 0x060054FC RID: 21756 RVA: 0x003136DB File Offset: 0x003118DB
		// (set) Token: 0x060054FD RID: 21757 RVA: 0x003136E5 File Offset: 0x003118E5
		internal virtual DateTimePicker DTStartdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E84 RID: 7812
		// (get) Token: 0x060054FE RID: 21758 RVA: 0x003136EE File Offset: 0x003118EE
		// (set) Token: 0x060054FF RID: 21759 RVA: 0x003136F8 File Offset: 0x003118F8
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E85 RID: 7813
		// (get) Token: 0x06005500 RID: 21760 RVA: 0x00313701 File Offset: 0x00311901
		// (set) Token: 0x06005501 RID: 21761 RVA: 0x0031370B File Offset: 0x0031190B
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E86 RID: 7814
		// (get) Token: 0x06005502 RID: 21762 RVA: 0x00313714 File Offset: 0x00311914
		// (set) Token: 0x06005503 RID: 21763 RVA: 0x0031371E File Offset: 0x0031191E
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E87 RID: 7815
		// (get) Token: 0x06005504 RID: 21764 RVA: 0x00313727 File Offset: 0x00311927
		// (set) Token: 0x06005505 RID: 21765 RVA: 0x00313731 File Offset: 0x00311931
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E88 RID: 7816
		// (get) Token: 0x06005506 RID: 21766 RVA: 0x0031373A File Offset: 0x0031193A
		// (set) Token: 0x06005507 RID: 21767 RVA: 0x00313744 File Offset: 0x00311944
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E89 RID: 7817
		// (get) Token: 0x06005508 RID: 21768 RVA: 0x0031374D File Offset: 0x0031194D
		// (set) Token: 0x06005509 RID: 21769 RVA: 0x00313757 File Offset: 0x00311957
		internal virtual ComboBox cboBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E8A RID: 7818
		// (get) Token: 0x0600550A RID: 21770 RVA: 0x00313760 File Offset: 0x00311960
		// (set) Token: 0x0600550B RID: 21771 RVA: 0x0031376A File Offset: 0x0031196A
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E8B RID: 7819
		// (get) Token: 0x0600550C RID: 21772 RVA: 0x00313773 File Offset: 0x00311973
		// (set) Token: 0x0600550D RID: 21773 RVA: 0x0031377D File Offset: 0x0031197D
		internal virtual BindingSource ReportFetchAllProductBalsAsAtBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E8C RID: 7820
		// (get) Token: 0x0600550E RID: 21774 RVA: 0x00313786 File Offset: 0x00311986
		// (set) Token: 0x0600550F RID: 21775 RVA: 0x00313790 File Offset: 0x00311990
		internal virtual ReportFetchAllProductBalsAsAtTableAdapter ReportFetchAllProductBalsAsAtTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E8D RID: 7821
		// (get) Token: 0x06005510 RID: 21776 RVA: 0x00313799 File Offset: 0x00311999
		// (set) Token: 0x06005511 RID: 21777 RVA: 0x003137A3 File Offset: 0x003119A3
		internal virtual CheckBox chkShowWithBal
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E8E RID: 7822
		// (get) Token: 0x06005512 RID: 21778 RVA: 0x003137AC File Offset: 0x003119AC
		// (set) Token: 0x06005513 RID: 21779 RVA: 0x003137B6 File Offset: 0x003119B6
		internal virtual CheckBox chkActive
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E8F RID: 7823
		// (get) Token: 0x06005514 RID: 21780 RVA: 0x003137BF File Offset: 0x003119BF
		// (set) Token: 0x06005515 RID: 21781 RVA: 0x003137CC File Offset: 0x003119CC
		internal virtual CheckBox chkUseActual
		{
			[CompilerGenerated]
			get
			{
				return this._chkUseActual;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CheckBox1_CheckedChanged);
				CheckBox checkBox = this._chkUseActual;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= eventHandler;
				}
				this._chkUseActual = value;
				checkBox = this._chkUseActual;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x06005516 RID: 21782 RVA: 0x00313810 File Offset: 0x00311A10
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
			this.cboBranch.SelectedIndex = this.cboBranch.FindStringExact(MyProject.Forms.Form1.branch);
		}

		// Token: 0x06005517 RID: 21783 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label3_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06005518 RID: 21784 RVA: 0x003138D4 File Offset: 0x00311AD4
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
				this.GetCompanyDetailsTableAdapter.Connection = sqlConnection;
				this.ReportFetchAllProductBalsAsAtTableAdapter.Connection = sqlConnection;
				ReportParameter reportParameter = new ReportParameter("StartDateDesc", this.DTStartdate.Value.ToShortDateString());
				ReportParameter reportParameter2 = new ReportParameter("coid", Conversions.ToString(MyProject.Forms.Form1.coid));
				ReportParameter reportParameter3 = new ReportParameter("branch", this.cboBranch.Text);
				ReportParameter reportParameter4 = new ReportParameter("theday", Conversions.ToString(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))));
				ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter2, reportParameter3, reportParameter4 };
				this.ReportViewer1.LocalReport.SetParameters(array);
				this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
				this.ReportFetchAllProductBalsAsAtTableAdapter.Fill(this.POSDataSet.ReportFetchAllProductBalsAsAt, new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text, new int?(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))), (int?)Interaction.IIf(this.chkShowWithBal.Checked, 0, 1), (int?)Interaction.IIf(this.chkActive.Checked, 0, 1), (int?)Interaction.IIf(this.chkUseActual.Checked, 1, 0));
				this.ReportViewer1.RefreshReport();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying report. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005519 RID: 21785 RVA: 0x00313AE8 File Offset: 0x00311CE8
		private void StockBalances_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadBranches();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600551A RID: 21786 RVA: 0x00313B38 File Offset: 0x00311D38
		private void CheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				bool @checked = this.chkUseActual.Checked;
				if (@checked)
				{
					this.DTStartdate.Enabled = false;
				}
				else
				{
					this.DTStartdate.Enabled = true;
					MessageBox.Show("Please note that Stock Balance report for a certain date is a slower process.");
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x04002528 RID: 9512
		private string _cnn;
	}
}
