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
	// Token: 0x020001A2 RID: 418
	[DesignerGenerated]
	public partial class SalesForPeriodGroupedByDay : UserControl
	{
		// Token: 0x06004ABA RID: 19130 RVA: 0x002CDF14 File Offset: 0x002CC114
		public SalesForPeriodGroupedByDay()
		{
			base.Load += this.SalesForPeriodGroupedByDay_Load;
			this.InitializeComponent();
		}

		// Token: 0x17001B52 RID: 6994
		// (get) Token: 0x06004ABD RID: 19133 RVA: 0x002CE857 File Offset: 0x002CCA57
		// (set) Token: 0x06004ABE RID: 19134 RVA: 0x002CE861 File Offset: 0x002CCA61
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B53 RID: 6995
		// (get) Token: 0x06004ABF RID: 19135 RVA: 0x002CE86A File Offset: 0x002CCA6A
		// (set) Token: 0x06004AC0 RID: 19136 RVA: 0x002CE874 File Offset: 0x002CCA74
		internal virtual Label Label2
		{
			[CompilerGenerated]
			get
			{
				return this._Label2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label2_Click);
				Label label = this._Label2;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label2 = value;
				label = this._Label2;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x17001B54 RID: 6996
		// (get) Token: 0x06004AC1 RID: 19137 RVA: 0x002CE8B7 File Offset: 0x002CCAB7
		// (set) Token: 0x06004AC2 RID: 19138 RVA: 0x002CE8C1 File Offset: 0x002CCAC1
		internal virtual DateTimePicker DTEnddate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B55 RID: 6997
		// (get) Token: 0x06004AC3 RID: 19139 RVA: 0x002CE8CA File Offset: 0x002CCACA
		// (set) Token: 0x06004AC4 RID: 19140 RVA: 0x002CE8D4 File Offset: 0x002CCAD4
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B56 RID: 6998
		// (get) Token: 0x06004AC5 RID: 19141 RVA: 0x002CE8DD File Offset: 0x002CCADD
		// (set) Token: 0x06004AC6 RID: 19142 RVA: 0x002CE8E7 File Offset: 0x002CCAE7
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B57 RID: 6999
		// (get) Token: 0x06004AC7 RID: 19143 RVA: 0x002CE8F0 File Offset: 0x002CCAF0
		// (set) Token: 0x06004AC8 RID: 19144 RVA: 0x002CE8FA File Offset: 0x002CCAFA
		internal virtual ComboBox cboBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B58 RID: 7000
		// (get) Token: 0x06004AC9 RID: 19145 RVA: 0x002CE903 File Offset: 0x002CCB03
		// (set) Token: 0x06004ACA RID: 19146 RVA: 0x002CE90D File Offset: 0x002CCB0D
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B59 RID: 7001
		// (get) Token: 0x06004ACB RID: 19147 RVA: 0x002CE916 File Offset: 0x002CCB16
		// (set) Token: 0x06004ACC RID: 19148 RVA: 0x002CE920 File Offset: 0x002CCB20
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

		// Token: 0x17001B5A RID: 7002
		// (get) Token: 0x06004ACD RID: 19149 RVA: 0x002CE963 File Offset: 0x002CCB63
		// (set) Token: 0x06004ACE RID: 19150 RVA: 0x002CE96D File Offset: 0x002CCB6D
		internal virtual DateTimePicker DTStartdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B5B RID: 7003
		// (get) Token: 0x06004ACF RID: 19151 RVA: 0x002CE976 File Offset: 0x002CCB76
		// (set) Token: 0x06004AD0 RID: 19152 RVA: 0x002CE980 File Offset: 0x002CCB80
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B5C RID: 7004
		// (get) Token: 0x06004AD1 RID: 19153 RVA: 0x002CE989 File Offset: 0x002CCB89
		// (set) Token: 0x06004AD2 RID: 19154 RVA: 0x002CE993 File Offset: 0x002CCB93
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B5D RID: 7005
		// (get) Token: 0x06004AD3 RID: 19155 RVA: 0x002CE99C File Offset: 0x002CCB9C
		// (set) Token: 0x06004AD4 RID: 19156 RVA: 0x002CE9A6 File Offset: 0x002CCBA6
		internal virtual BindingSource SalesForPeriodGroupedByDayBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B5E RID: 7006
		// (get) Token: 0x06004AD5 RID: 19157 RVA: 0x002CE9AF File Offset: 0x002CCBAF
		// (set) Token: 0x06004AD6 RID: 19158 RVA: 0x002CE9B9 File Offset: 0x002CCBB9
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B5F RID: 7007
		// (get) Token: 0x06004AD7 RID: 19159 RVA: 0x002CE9C2 File Offset: 0x002CCBC2
		// (set) Token: 0x06004AD8 RID: 19160 RVA: 0x002CE9CC File Offset: 0x002CCBCC
		internal virtual SalesForPeriodGroupedByDayTableAdapter SalesForPeriodGroupedByDayTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B60 RID: 7008
		// (get) Token: 0x06004AD9 RID: 19161 RVA: 0x002CE9D5 File Offset: 0x002CCBD5
		// (set) Token: 0x06004ADA RID: 19162 RVA: 0x002CE9DF File Offset: 0x002CCBDF
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B61 RID: 7009
		// (get) Token: 0x06004ADB RID: 19163 RVA: 0x002CE9E8 File Offset: 0x002CCBE8
		// (set) Token: 0x06004ADC RID: 19164 RVA: 0x002CE9F2 File Offset: 0x002CCBF2
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06004ADD RID: 19165 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label2_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06004ADE RID: 19166 RVA: 0x002CE9FC File Offset: 0x002CCBFC
		private void LoadBranches()
		{
			SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
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

		// Token: 0x06004ADF RID: 19167 RVA: 0x002CEACC File Offset: 0x002CCCCC
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
				this.SalesForPeriodGroupedByDayTableAdapter.Connection = sqlConnection;
				this.GetCompanyDetailsTableAdapter.Connection = sqlConnection;
				ReportParameter reportParameter = new ReportParameter("startdatedesc", this.DTStartdate.Value.ToShortDateString());
				ReportParameter reportParameter2 = new ReportParameter("enddatedesc", this.DTEnddate.Value.ToShortDateString());
				ReportParameter reportParameter3 = new ReportParameter("branch", this.cboBranch.Text);
				ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter2, reportParameter3 };
				this.ReportViewer1.LocalReport.SetParameters(array);
				this.SalesForPeriodGroupedByDayTableAdapter.Fill(this.POSDataSet.SalesForPeriodGroupedByDay, new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text, new int?(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))));
				this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
				this.ReportViewer1.RefreshReport();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying report. Detail: " + ex.Message);
			}
		}

		// Token: 0x06004AE0 RID: 19168 RVA: 0x002CEC6C File Offset: 0x002CCE6C
		private void SalesForPeriodGroupedByDay_Load(object sender, EventArgs e)
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
	}
}
