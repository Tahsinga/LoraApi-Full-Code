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
	// Token: 0x0200015E RID: 350
	[DesignerGenerated]
	public partial class PriceChangesReport : Form
	{
		// Token: 0x06002E92 RID: 11922 RVA: 0x001959F5 File Offset: 0x00193BF5
		public PriceChangesReport()
		{
			base.Load += this.PriceChangesReport_Load;
			this.InitializeComponent();
		}

		// Token: 0x1700114C RID: 4428
		// (get) Token: 0x06002E95 RID: 11925 RVA: 0x001960C5 File Offset: 0x001942C5
		// (set) Token: 0x06002E96 RID: 11926 RVA: 0x001960CF File Offset: 0x001942CF
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700114D RID: 4429
		// (get) Token: 0x06002E97 RID: 11927 RVA: 0x001960D8 File Offset: 0x001942D8
		// (set) Token: 0x06002E98 RID: 11928 RVA: 0x001960E2 File Offset: 0x001942E2
		internal virtual DateTimePicker DTEndDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700114E RID: 4430
		// (get) Token: 0x06002E99 RID: 11929 RVA: 0x001960EB File Offset: 0x001942EB
		// (set) Token: 0x06002E9A RID: 11930 RVA: 0x001960F5 File Offset: 0x001942F5
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700114F RID: 4431
		// (get) Token: 0x06002E9B RID: 11931 RVA: 0x001960FE File Offset: 0x001942FE
		// (set) Token: 0x06002E9C RID: 11932 RVA: 0x00196108 File Offset: 0x00194308
		internal virtual DateTimePicker DTStartDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001150 RID: 4432
		// (get) Token: 0x06002E9D RID: 11933 RVA: 0x00196111 File Offset: 0x00194311
		// (set) Token: 0x06002E9E RID: 11934 RVA: 0x0019611B File Offset: 0x0019431B
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001151 RID: 4433
		// (get) Token: 0x06002E9F RID: 11935 RVA: 0x00196124 File Offset: 0x00194324
		// (set) Token: 0x06002EA0 RID: 11936 RVA: 0x00196130 File Offset: 0x00194330
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

		// Token: 0x17001152 RID: 4434
		// (get) Token: 0x06002EA1 RID: 11937 RVA: 0x00196173 File Offset: 0x00194373
		// (set) Token: 0x06002EA2 RID: 11938 RVA: 0x0019617D File Offset: 0x0019437D
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001153 RID: 4435
		// (get) Token: 0x06002EA3 RID: 11939 RVA: 0x00196186 File Offset: 0x00194386
		// (set) Token: 0x06002EA4 RID: 11940 RVA: 0x00196190 File Offset: 0x00194390
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001154 RID: 4436
		// (get) Token: 0x06002EA5 RID: 11941 RVA: 0x00196199 File Offset: 0x00194399
		// (set) Token: 0x06002EA6 RID: 11942 RVA: 0x001961A3 File Offset: 0x001943A3
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001155 RID: 4437
		// (get) Token: 0x06002EA7 RID: 11943 RVA: 0x001961AC File Offset: 0x001943AC
		// (set) Token: 0x06002EA8 RID: 11944 RVA: 0x001961B6 File Offset: 0x001943B6
		internal virtual BindingSource PCSelectPriceChangesBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001156 RID: 4438
		// (get) Token: 0x06002EA9 RID: 11945 RVA: 0x001961BF File Offset: 0x001943BF
		// (set) Token: 0x06002EAA RID: 11946 RVA: 0x001961C9 File Offset: 0x001943C9
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001157 RID: 4439
		// (get) Token: 0x06002EAB RID: 11947 RVA: 0x001961D2 File Offset: 0x001943D2
		// (set) Token: 0x06002EAC RID: 11948 RVA: 0x001961DC File Offset: 0x001943DC
		internal virtual PCSelectPriceChangesTableAdapter PCSelectPriceChangesTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001158 RID: 4440
		// (get) Token: 0x06002EAD RID: 11949 RVA: 0x001961E5 File Offset: 0x001943E5
		// (set) Token: 0x06002EAE RID: 11950 RVA: 0x001961EF File Offset: 0x001943EF
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06002EAF RID: 11951 RVA: 0x001961F8 File Offset: 0x001943F8
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
				this.GetCompanyDetailsTableAdapter.Connection = sqlConnection;
				this.PCSelectPriceChangesTableAdapter.Connection = sqlConnection;
				ReportParameter reportParameter = new ReportParameter("startdate", Conversions.ToString(Conversions.ToInteger(this.DTStartDate.Value.ToString("yyyyMMdd"))));
				ReportParameter reportParameter2 = new ReportParameter("startdatedesc", this.DTStartDate.Value.ToShortDateString());
				ReportParameter reportParameter3 = new ReportParameter("enddate", Conversions.ToString(Conversions.ToInteger(this.DTEndDate.Value.ToString("yyyyMMdd"))));
				ReportParameter reportParameter4 = new ReportParameter("enddatedesc", this.DTEndDate.Value.ToShortDateString());
				ReportParameter reportParameter5 = new ReportParameter("coid", Conversions.ToString(MyProject.Forms.Form1.coid));
				ReportParameter reportParameter6 = new ReportParameter("branch", MyProject.Forms.Form1.branch);
				ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter2, reportParameter3, reportParameter4, reportParameter5, reportParameter6 };
				this.ReportViewer1.LocalReport.SetParameters(array);
				this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
				this.PCSelectPriceChangesTableAdapter.Fill(this.POSDataSet.PCSelectPriceChanges, new int?(Convert.ToInt32(this.DTStartDate.Value.ToString("yyyyMMdd"))), new int?(Convert.ToInt32(this.DTEndDate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid), MyProject.Forms.Form1.branch);
				this.ReportViewer1.RefreshReport();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying report. Detail: " + ex.Message);
			}
		}

		// Token: 0x06002EB0 RID: 11952 RVA: 0x00002A30 File Offset: 0x00000C30
		private void PriceChangesReport_Load(object sender, EventArgs e)
		{
		}
	}
}
