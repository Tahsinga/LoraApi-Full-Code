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
	// Token: 0x02000198 RID: 408
	[DesignerGenerated]
	public partial class SalesForCompany : UserControl
	{
		// Token: 0x06004882 RID: 18562 RVA: 0x002C184C File Offset: 0x002BFA4C
		public SalesForCompany()
		{
			this.InitializeComponent();
		}

		// Token: 0x17001A5C RID: 6748
		// (get) Token: 0x06004885 RID: 18565 RVA: 0x002C239C File Offset: 0x002C059C
		// (set) Token: 0x06004886 RID: 18566 RVA: 0x002C23A6 File Offset: 0x002C05A6
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A5D RID: 6749
		// (get) Token: 0x06004887 RID: 18567 RVA: 0x002C23AF File Offset: 0x002C05AF
		// (set) Token: 0x06004888 RID: 18568 RVA: 0x002C23B9 File Offset: 0x002C05B9
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A5E RID: 6750
		// (get) Token: 0x06004889 RID: 18569 RVA: 0x002C23C2 File Offset: 0x002C05C2
		// (set) Token: 0x0600488A RID: 18570 RVA: 0x002C23CC File Offset: 0x002C05CC
		internal virtual BindingSource GetCompanyDetailsForCoidBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A5F RID: 6751
		// (get) Token: 0x0600488B RID: 18571 RVA: 0x002C23D5 File Offset: 0x002C05D5
		// (set) Token: 0x0600488C RID: 18572 RVA: 0x002C23DF File Offset: 0x002C05DF
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A60 RID: 6752
		// (get) Token: 0x0600488D RID: 18573 RVA: 0x002C23E8 File Offset: 0x002C05E8
		// (set) Token: 0x0600488E RID: 18574 RVA: 0x002C23F2 File Offset: 0x002C05F2
		internal virtual BindingSource SalesForCompanyBranchSummaryBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A61 RID: 6753
		// (get) Token: 0x0600488F RID: 18575 RVA: 0x002C23FB File Offset: 0x002C05FB
		// (set) Token: 0x06004890 RID: 18576 RVA: 0x002C2405 File Offset: 0x002C0605
		internal virtual BindingSource SalesForCompanyPaySummaryBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A62 RID: 6754
		// (get) Token: 0x06004891 RID: 18577 RVA: 0x002C240E File Offset: 0x002C060E
		// (set) Token: 0x06004892 RID: 18578 RVA: 0x002C2418 File Offset: 0x002C0618
		internal virtual BindingSource SalesForCompanyCategoriesBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A63 RID: 6755
		// (get) Token: 0x06004893 RID: 18579 RVA: 0x002C2421 File Offset: 0x002C0621
		// (set) Token: 0x06004894 RID: 18580 RVA: 0x002C242B File Offset: 0x002C062B
		internal virtual BindingSource SalesForCompanySaleTypeBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A64 RID: 6756
		// (get) Token: 0x06004895 RID: 18581 RVA: 0x002C2434 File Offset: 0x002C0634
		// (set) Token: 0x06004896 RID: 18582 RVA: 0x002C243E File Offset: 0x002C063E
		internal virtual BindingSource SalesForCompanyDetailBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A65 RID: 6757
		// (get) Token: 0x06004897 RID: 18583 RVA: 0x002C2447 File Offset: 0x002C0647
		// (set) Token: 0x06004898 RID: 18584 RVA: 0x002C2451 File Offset: 0x002C0651
		internal virtual GetCompanyDetailsForCoidTableAdapter GetCompanyDetailsForCoidTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A66 RID: 6758
		// (get) Token: 0x06004899 RID: 18585 RVA: 0x002C245A File Offset: 0x002C065A
		// (set) Token: 0x0600489A RID: 18586 RVA: 0x002C2464 File Offset: 0x002C0664
		internal virtual SalesForCompanyBranchSummaryTableAdapter SalesForCompanyBranchSummaryTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A67 RID: 6759
		// (get) Token: 0x0600489B RID: 18587 RVA: 0x002C246D File Offset: 0x002C066D
		// (set) Token: 0x0600489C RID: 18588 RVA: 0x002C2477 File Offset: 0x002C0677
		internal virtual SalesForCompanyPaySummaryTableAdapter SalesForCompanyPaySummaryTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A68 RID: 6760
		// (get) Token: 0x0600489D RID: 18589 RVA: 0x002C2480 File Offset: 0x002C0680
		// (set) Token: 0x0600489E RID: 18590 RVA: 0x002C248A File Offset: 0x002C068A
		internal virtual SalesForCompanyCategoriesTableAdapter SalesForCompanyCategoriesTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A69 RID: 6761
		// (get) Token: 0x0600489F RID: 18591 RVA: 0x002C2493 File Offset: 0x002C0693
		// (set) Token: 0x060048A0 RID: 18592 RVA: 0x002C249D File Offset: 0x002C069D
		internal virtual SalesForCompanySaleTypeTableAdapter SalesForCompanySaleTypeTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A6A RID: 6762
		// (get) Token: 0x060048A1 RID: 18593 RVA: 0x002C24A6 File Offset: 0x002C06A6
		// (set) Token: 0x060048A2 RID: 18594 RVA: 0x002C24B0 File Offset: 0x002C06B0
		internal virtual SalesForCompanyDetailTableAdapter SalesForCompanyDetailTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A6B RID: 6763
		// (get) Token: 0x060048A3 RID: 18595 RVA: 0x002C24B9 File Offset: 0x002C06B9
		// (set) Token: 0x060048A4 RID: 18596 RVA: 0x002C24C3 File Offset: 0x002C06C3
		internal virtual DateTimePicker DTEnddate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A6C RID: 6764
		// (get) Token: 0x060048A5 RID: 18597 RVA: 0x002C24CC File Offset: 0x002C06CC
		// (set) Token: 0x060048A6 RID: 18598 RVA: 0x002C24D6 File Offset: 0x002C06D6
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A6D RID: 6765
		// (get) Token: 0x060048A7 RID: 18599 RVA: 0x002C24DF File Offset: 0x002C06DF
		// (set) Token: 0x060048A8 RID: 18600 RVA: 0x002C24E9 File Offset: 0x002C06E9
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A6E RID: 6766
		// (get) Token: 0x060048A9 RID: 18601 RVA: 0x002C24F2 File Offset: 0x002C06F2
		// (set) Token: 0x060048AA RID: 18602 RVA: 0x002C24FC File Offset: 0x002C06FC
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

		// Token: 0x17001A6F RID: 6767
		// (get) Token: 0x060048AB RID: 18603 RVA: 0x002C253F File Offset: 0x002C073F
		// (set) Token: 0x060048AC RID: 18604 RVA: 0x002C2549 File Offset: 0x002C0749
		internal virtual DateTimePicker DTStartdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A70 RID: 6768
		// (get) Token: 0x060048AD RID: 18605 RVA: 0x002C2552 File Offset: 0x002C0752
		// (set) Token: 0x060048AE RID: 18606 RVA: 0x002C255C File Offset: 0x002C075C
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A71 RID: 6769
		// (get) Token: 0x060048AF RID: 18607 RVA: 0x002C2565 File Offset: 0x002C0765
		// (set) Token: 0x060048B0 RID: 18608 RVA: 0x002C2570 File Offset: 0x002C0770
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

		// Token: 0x17001A72 RID: 6770
		// (get) Token: 0x060048B1 RID: 18609 RVA: 0x002C25B3 File Offset: 0x002C07B3
		// (set) Token: 0x060048B2 RID: 18610 RVA: 0x002C25BD File Offset: 0x002C07BD
		internal virtual CheckBox chkHideCats
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060048B3 RID: 18611 RVA: 0x002C25C8 File Offset: 0x002C07C8
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
				this.GetCompanyDetailsForCoidTableAdapter.Connection = sqlConnection;
				this.SalesForCompanyBranchSummaryTableAdapter.Connection = sqlConnection;
				this.SalesForCompanyCategoriesTableAdapter.Connection = sqlConnection;
				this.SalesForCompanyDetailTableAdapter.Connection = sqlConnection;
				this.SalesForCompanyPaySummaryTableAdapter.Connection = sqlConnection;
				this.SalesForCompanySaleTypeTableAdapter.Connection = sqlConnection;
				ReportParameter reportParameter = new ReportParameter("startdatedesc", this.DTStartdate.Value.ToShortDateString());
				ReportParameter reportParameter2 = new ReportParameter("enddatedesc", this.DTEnddate.Value.ToShortDateString());
				ReportParameter reportParameter3 = new ReportParameter("companyname", MyProject.Forms.Form1.companyname);
				ReportParameter reportParameter4 = new ReportParameter("hidecats", Conversions.ToString(Conversions.ToInteger(Interaction.IIf(this.chkHideCats.Checked, 1, 0))));
				ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter2, reportParameter3, reportParameter4 };
				this.ReportViewer1.LocalReport.SetParameters(array);
				this.GetCompanyDetailsForCoidTableAdapter.Fill(this.POSDataSet.GetCompanyDetailsForCoid, new int?(MyProject.Forms.Form1.coid));
				this.SalesForCompanyBranchSummaryTableAdapter.Fill(this.POSDataSet.SalesForCompanyBranchSummary, new int?(MyProject.Forms.Form1.coid), new int?(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))));
				this.SalesForCompanyCategoriesTableAdapter.Fill(this.POSDataSet.SalesForCompanyCategories, new int?(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid));
				this.SalesForCompanyDetailTableAdapter.Fill(this.POSDataSet.SalesForCompanyDetail, new int?(MyProject.Forms.Form1.coid), new int?(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))));
				this.SalesForCompanyPaySummaryTableAdapter.Fill(this.POSDataSet.SalesForCompanyPaySummary, new int?(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid));
				this.SalesForCompanySaleTypeTableAdapter.Fill(this.POSDataSet.SalesForCompanySaleType, new int?(MyProject.Forms.Form1.coid), new int?(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))));
				this.ReportViewer1.RefreshReport();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying report. Detail: " + ex.Message);
			}
		}

		// Token: 0x060048B4 RID: 18612 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label2_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}
	}
}
