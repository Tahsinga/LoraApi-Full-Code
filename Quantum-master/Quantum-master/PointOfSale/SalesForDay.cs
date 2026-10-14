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
	// Token: 0x0200019B RID: 411
	[DesignerGenerated]
	public partial class SalesForDay : UserControl
	{
		// Token: 0x0600491F RID: 18719 RVA: 0x002C50D0 File Offset: 0x002C32D0
		public SalesForDay()
		{
			base.Load += this.SalesForDay_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x17001A9F RID: 6815
		// (get) Token: 0x06004922 RID: 18722 RVA: 0x002C59A1 File Offset: 0x002C3BA1
		// (set) Token: 0x06004923 RID: 18723 RVA: 0x002C59AB File Offset: 0x002C3BAB
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AA0 RID: 6816
		// (get) Token: 0x06004924 RID: 18724 RVA: 0x002C59B4 File Offset: 0x002C3BB4
		// (set) Token: 0x06004925 RID: 18725 RVA: 0x002C59C0 File Offset: 0x002C3BC0
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

		// Token: 0x17001AA1 RID: 6817
		// (get) Token: 0x06004926 RID: 18726 RVA: 0x002C5A03 File Offset: 0x002C3C03
		// (set) Token: 0x06004927 RID: 18727 RVA: 0x002C5A0D File Offset: 0x002C3C0D
		internal virtual DateTimePicker DTdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AA2 RID: 6818
		// (get) Token: 0x06004928 RID: 18728 RVA: 0x002C5A16 File Offset: 0x002C3C16
		// (set) Token: 0x06004929 RID: 18729 RVA: 0x002C5A20 File Offset: 0x002C3C20
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AA3 RID: 6819
		// (get) Token: 0x0600492A RID: 18730 RVA: 0x002C5A29 File Offset: 0x002C3C29
		// (set) Token: 0x0600492B RID: 18731 RVA: 0x002C5A33 File Offset: 0x002C3C33
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AA4 RID: 6820
		// (get) Token: 0x0600492C RID: 18732 RVA: 0x002C5A3C File Offset: 0x002C3C3C
		// (set) Token: 0x0600492D RID: 18733 RVA: 0x002C5A46 File Offset: 0x002C3C46
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AA5 RID: 6821
		// (get) Token: 0x0600492E RID: 18734 RVA: 0x002C5A4F File Offset: 0x002C3C4F
		// (set) Token: 0x0600492F RID: 18735 RVA: 0x002C5A59 File Offset: 0x002C3C59
		internal virtual BindingSource SalesSummaryForDayBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AA6 RID: 6822
		// (get) Token: 0x06004930 RID: 18736 RVA: 0x002C5A62 File Offset: 0x002C3C62
		// (set) Token: 0x06004931 RID: 18737 RVA: 0x002C5A6C File Offset: 0x002C3C6C
		internal virtual BindingSource SalesDetailForDayBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AA7 RID: 6823
		// (get) Token: 0x06004932 RID: 18738 RVA: 0x002C5A75 File Offset: 0x002C3C75
		// (set) Token: 0x06004933 RID: 18739 RVA: 0x002C5A7F File Offset: 0x002C3C7F
		internal virtual BindingSource PaymentSummaryForDayBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AA8 RID: 6824
		// (get) Token: 0x06004934 RID: 18740 RVA: 0x002C5A88 File Offset: 0x002C3C88
		// (set) Token: 0x06004935 RID: 18741 RVA: 0x002C5A92 File Offset: 0x002C3C92
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AA9 RID: 6825
		// (get) Token: 0x06004936 RID: 18742 RVA: 0x002C5A9B File Offset: 0x002C3C9B
		// (set) Token: 0x06004937 RID: 18743 RVA: 0x002C5AA5 File Offset: 0x002C3CA5
		internal virtual SalesSummaryForDayTableAdapter SalesSummaryForDayTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AAA RID: 6826
		// (get) Token: 0x06004938 RID: 18744 RVA: 0x002C5AAE File Offset: 0x002C3CAE
		// (set) Token: 0x06004939 RID: 18745 RVA: 0x002C5AB8 File Offset: 0x002C3CB8
		internal virtual SalesDetailForDayTableAdapter SalesDetailForDayTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AAB RID: 6827
		// (get) Token: 0x0600493A RID: 18746 RVA: 0x002C5AC1 File Offset: 0x002C3CC1
		// (set) Token: 0x0600493B RID: 18747 RVA: 0x002C5ACC File Offset: 0x002C3CCC
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

		// Token: 0x17001AAC RID: 6828
		// (get) Token: 0x0600493C RID: 18748 RVA: 0x002C5B0F File Offset: 0x002C3D0F
		// (set) Token: 0x0600493D RID: 18749 RVA: 0x002C5B19 File Offset: 0x002C3D19
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AAD RID: 6829
		// (get) Token: 0x0600493E RID: 18750 RVA: 0x002C5B22 File Offset: 0x002C3D22
		// (set) Token: 0x0600493F RID: 18751 RVA: 0x002C5B2C File Offset: 0x002C3D2C
		internal virtual PaymentSummaryForDayTableAdapter PaymentSummaryForDayTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AAE RID: 6830
		// (get) Token: 0x06004940 RID: 18752 RVA: 0x002C5B35 File Offset: 0x002C3D35
		// (set) Token: 0x06004941 RID: 18753 RVA: 0x002C5B3F File Offset: 0x002C3D3F
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AAF RID: 6831
		// (get) Token: 0x06004942 RID: 18754 RVA: 0x002C5B48 File Offset: 0x002C3D48
		// (set) Token: 0x06004943 RID: 18755 RVA: 0x002C5B52 File Offset: 0x002C3D52
		internal virtual ComboBox cboBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AB0 RID: 6832
		// (get) Token: 0x06004944 RID: 18756 RVA: 0x002C5B5B File Offset: 0x002C3D5B
		// (set) Token: 0x06004945 RID: 18757 RVA: 0x002C5B65 File Offset: 0x002C3D65
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06004946 RID: 18758 RVA: 0x002C5B70 File Offset: 0x002C3D70
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
				this.GetCompanyDetailsTableAdapter.Connection = sqlConnection;
				this.PaymentSummaryForDayTableAdapter.Connection = sqlConnection;
				this.SalesDetailForDayTableAdapter.Connection = sqlConnection;
				this.SalesSummaryForDayTableAdapter.Connection = sqlConnection;
				ReportParameter reportParameter = new ReportParameter("theday", Conversions.ToString(Conversions.ToInteger(this.DTdate.Value.ToString("yyyyMMdd"))));
				ReportParameter reportParameter2 = new ReportParameter("TranDateDesc", this.DTdate.Value.ToShortDateString());
				ReportParameter reportParameter3 = new ReportParameter("coid", Conversions.ToString(MyProject.Forms.Form1.coid));
				ReportParameter reportParameter4 = new ReportParameter("branch", this.cboBranch.Text);
				ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter2, reportParameter3, reportParameter4 };
				this.ReportViewer1.LocalReport.SetParameters(array);
				this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
				this.PaymentSummaryForDayTableAdapter.Fill(this.POSDataSet.PaymentSummaryForDay, new int?(Conversions.ToInteger(this.DTdate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text);
				this.SalesDetailForDayTableAdapter.Fill(this.POSDataSet.SalesDetailForDay, new int?(Conversions.ToInteger(this.DTdate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text);
				this.SalesSummaryForDayTableAdapter.Fill(this.POSDataSet.SalesSummaryForDay, new int?(Conversions.ToInteger(this.DTdate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text);
				this.ReportViewer1.RefreshReport();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying report. Detail: " + ex.Message);
			}
		}

		// Token: 0x06004947 RID: 18759 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label2_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06004948 RID: 18760 RVA: 0x002C5DEC File Offset: 0x002C3FEC
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

		// Token: 0x06004949 RID: 18761 RVA: 0x002C5E8C File Offset: 0x002C408C
		private void SalesForDay_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadBranches();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading page. Detail: " + ex.Message);
			}
		}

		// Token: 0x04002019 RID: 8217
		private string _cnn;
	}
}
