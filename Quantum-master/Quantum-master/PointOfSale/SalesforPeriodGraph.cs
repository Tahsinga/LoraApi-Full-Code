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
	// Token: 0x020001A0 RID: 416
	[DesignerGenerated]
	public partial class SalesforPeriodGraph : UserControl
	{
		// Token: 0x06004A68 RID: 19048 RVA: 0x002CC018 File Offset: 0x002CA218
		public SalesforPeriodGraph()
		{
			base.Load += this.SalesforPeriodGraph_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x17001B31 RID: 6961
		// (get) Token: 0x06004A6B RID: 19051 RVA: 0x002CC8AC File Offset: 0x002CAAAC
		// (set) Token: 0x06004A6C RID: 19052 RVA: 0x002CC8B6 File Offset: 0x002CAAB6
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B32 RID: 6962
		// (get) Token: 0x06004A6D RID: 19053 RVA: 0x002CC8BF File Offset: 0x002CAABF
		// (set) Token: 0x06004A6E RID: 19054 RVA: 0x002CC8C9 File Offset: 0x002CAAC9
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B33 RID: 6963
		// (get) Token: 0x06004A6F RID: 19055 RVA: 0x002CC8D2 File Offset: 0x002CAAD2
		// (set) Token: 0x06004A70 RID: 19056 RVA: 0x002CC8DC File Offset: 0x002CAADC
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

		// Token: 0x17001B34 RID: 6964
		// (get) Token: 0x06004A71 RID: 19057 RVA: 0x002CC91F File Offset: 0x002CAB1F
		// (set) Token: 0x06004A72 RID: 19058 RVA: 0x002CC929 File Offset: 0x002CAB29
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B35 RID: 6965
		// (get) Token: 0x06004A73 RID: 19059 RVA: 0x002CC932 File Offset: 0x002CAB32
		// (set) Token: 0x06004A74 RID: 19060 RVA: 0x002CC93C File Offset: 0x002CAB3C
		internal virtual DateTimePicker DTEnddate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B36 RID: 6966
		// (get) Token: 0x06004A75 RID: 19061 RVA: 0x002CC945 File Offset: 0x002CAB45
		// (set) Token: 0x06004A76 RID: 19062 RVA: 0x002CC950 File Offset: 0x002CAB50
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

		// Token: 0x17001B37 RID: 6967
		// (get) Token: 0x06004A77 RID: 19063 RVA: 0x002CC993 File Offset: 0x002CAB93
		// (set) Token: 0x06004A78 RID: 19064 RVA: 0x002CC99D File Offset: 0x002CAB9D
		internal virtual DateTimePicker DTStartdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B38 RID: 6968
		// (get) Token: 0x06004A79 RID: 19065 RVA: 0x002CC9A6 File Offset: 0x002CABA6
		// (set) Token: 0x06004A7A RID: 19066 RVA: 0x002CC9B0 File Offset: 0x002CABB0
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B39 RID: 6969
		// (get) Token: 0x06004A7B RID: 19067 RVA: 0x002CC9B9 File Offset: 0x002CABB9
		// (set) Token: 0x06004A7C RID: 19068 RVA: 0x002CC9C3 File Offset: 0x002CABC3
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B3A RID: 6970
		// (get) Token: 0x06004A7D RID: 19069 RVA: 0x002CC9CC File Offset: 0x002CABCC
		// (set) Token: 0x06004A7E RID: 19070 RVA: 0x002CC9D6 File Offset: 0x002CABD6
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B3B RID: 6971
		// (get) Token: 0x06004A7F RID: 19071 RVA: 0x002CC9DF File Offset: 0x002CABDF
		// (set) Token: 0x06004A80 RID: 19072 RVA: 0x002CC9E9 File Offset: 0x002CABE9
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B3C RID: 6972
		// (get) Token: 0x06004A81 RID: 19073 RVA: 0x002CC9F2 File Offset: 0x002CABF2
		// (set) Token: 0x06004A82 RID: 19074 RVA: 0x002CC9FC File Offset: 0x002CABFC
		internal virtual BindingSource SalesForPeriodByDayBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B3D RID: 6973
		// (get) Token: 0x06004A83 RID: 19075 RVA: 0x002CCA05 File Offset: 0x002CAC05
		// (set) Token: 0x06004A84 RID: 19076 RVA: 0x002CCA0F File Offset: 0x002CAC0F
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B3E RID: 6974
		// (get) Token: 0x06004A85 RID: 19077 RVA: 0x002CCA18 File Offset: 0x002CAC18
		// (set) Token: 0x06004A86 RID: 19078 RVA: 0x002CCA22 File Offset: 0x002CAC22
		internal virtual SalesForPeriodByDayTableAdapter SalesForPeriodByDayTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B3F RID: 6975
		// (get) Token: 0x06004A87 RID: 19079 RVA: 0x002CCA2B File Offset: 0x002CAC2B
		// (set) Token: 0x06004A88 RID: 19080 RVA: 0x002CCA35 File Offset: 0x002CAC35
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B40 RID: 6976
		// (get) Token: 0x06004A89 RID: 19081 RVA: 0x002CCA3E File Offset: 0x002CAC3E
		// (set) Token: 0x06004A8A RID: 19082 RVA: 0x002CCA48 File Offset: 0x002CAC48
		internal virtual ComboBox cboBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06004A8B RID: 19083 RVA: 0x002CCA54 File Offset: 0x002CAC54
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

		// Token: 0x06004A8C RID: 19084 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label3_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06004A8D RID: 19085 RVA: 0x002CCAF4 File Offset: 0x002CACF4
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
				this.GetCompanyDetailsTableAdapter.Connection = sqlConnection;
				this.SalesForPeriodByDayTableAdapter.Connection = sqlConnection;
				ReportParameter reportParameter = new ReportParameter("startdate", Conversions.ToString(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))));
				ReportParameter reportParameter2 = new ReportParameter("StartDateDesc", this.DTStartdate.Value.ToShortDateString());
				ReportParameter reportParameter3 = new ReportParameter("enddate", Conversions.ToString(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))));
				ReportParameter reportParameter4 = new ReportParameter("EndDateDesc", this.DTEnddate.Value.ToShortDateString());
				ReportParameter reportParameter5 = new ReportParameter("coid", Conversions.ToString(MyProject.Forms.Form1.coid));
				ReportParameter reportParameter6 = new ReportParameter("branch", this.cboBranch.Text);
				ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter2, reportParameter3, reportParameter4, reportParameter5, reportParameter6 };
				this.ReportViewer1.LocalReport.SetParameters(array);
				this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
				this.SalesForPeriodByDayTableAdapter.Fill(this.POSDataSet.SalesForPeriodByDay, new int?(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text);
				this.ReportViewer1.RefreshReport();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying report. Detail: " + ex.Message);
			}
		}

		// Token: 0x06004A8E RID: 19086 RVA: 0x002CCD20 File Offset: 0x002CAF20
		private void SalesforPeriodGraph_Load(object sender, EventArgs e)
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

		// Token: 0x040020B3 RID: 8371
		private string _cnn;
	}
}
