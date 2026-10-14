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
	// Token: 0x02000081 RID: 129
	[DesignerGenerated]
	public partial class OveralRevenueReport : UserControl
	{
		// Token: 0x06001DD0 RID: 7632 RVA: 0x0010B128 File Offset: 0x00109328
		public OveralRevenueReport()
		{
			base.Load += this.OveralRevenueReport_Load;
			this.InitializeComponent();
		}

		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x06001DD3 RID: 7635 RVA: 0x0010BB19 File Offset: 0x00109D19
		// (set) Token: 0x06001DD4 RID: 7636 RVA: 0x0010BB23 File Offset: 0x00109D23
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x06001DD5 RID: 7637 RVA: 0x0010BB2C File Offset: 0x00109D2C
		// (set) Token: 0x06001DD6 RID: 7638 RVA: 0x0010BB38 File Offset: 0x00109D38
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

		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x06001DD7 RID: 7639 RVA: 0x0010BB7B File Offset: 0x00109D7B
		// (set) Token: 0x06001DD8 RID: 7640 RVA: 0x0010BB85 File Offset: 0x00109D85
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AF0 RID: 2800
		// (get) Token: 0x06001DD9 RID: 7641 RVA: 0x0010BB8E File Offset: 0x00109D8E
		// (set) Token: 0x06001DDA RID: 7642 RVA: 0x0010BB98 File Offset: 0x00109D98
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

		// Token: 0x17000AF1 RID: 2801
		// (get) Token: 0x06001DDB RID: 7643 RVA: 0x0010BBDB File Offset: 0x00109DDB
		// (set) Token: 0x06001DDC RID: 7644 RVA: 0x0010BBE5 File Offset: 0x00109DE5
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AF2 RID: 2802
		// (get) Token: 0x06001DDD RID: 7645 RVA: 0x0010BBEE File Offset: 0x00109DEE
		// (set) Token: 0x06001DDE RID: 7646 RVA: 0x0010BBF8 File Offset: 0x00109DF8
		internal virtual DateTimePicker DTEnddate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AF3 RID: 2803
		// (get) Token: 0x06001DDF RID: 7647 RVA: 0x0010BC01 File Offset: 0x00109E01
		// (set) Token: 0x06001DE0 RID: 7648 RVA: 0x0010BC0B File Offset: 0x00109E0B
		internal virtual DateTimePicker DTStartdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x06001DE1 RID: 7649 RVA: 0x0010BC14 File Offset: 0x00109E14
		// (set) Token: 0x06001DE2 RID: 7650 RVA: 0x0010BC1E File Offset: 0x00109E1E
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x06001DE3 RID: 7651 RVA: 0x0010BC27 File Offset: 0x00109E27
		// (set) Token: 0x06001DE4 RID: 7652 RVA: 0x0010BC31 File Offset: 0x00109E31
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AF6 RID: 2806
		// (get) Token: 0x06001DE5 RID: 7653 RVA: 0x0010BC3A File Offset: 0x00109E3A
		// (set) Token: 0x06001DE6 RID: 7654 RVA: 0x0010BC44 File Offset: 0x00109E44
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AF7 RID: 2807
		// (get) Token: 0x06001DE7 RID: 7655 RVA: 0x0010BC4D File Offset: 0x00109E4D
		// (set) Token: 0x06001DE8 RID: 7656 RVA: 0x0010BC57 File Offset: 0x00109E57
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AF8 RID: 2808
		// (get) Token: 0x06001DE9 RID: 7657 RVA: 0x0010BC60 File Offset: 0x00109E60
		// (set) Token: 0x06001DEA RID: 7658 RVA: 0x0010BC6A File Offset: 0x00109E6A
		internal virtual BindingSource OveralSalesForPeriodBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AF9 RID: 2809
		// (get) Token: 0x06001DEB RID: 7659 RVA: 0x0010BC73 File Offset: 0x00109E73
		// (set) Token: 0x06001DEC RID: 7660 RVA: 0x0010BC7D File Offset: 0x00109E7D
		internal virtual BindingSource OveralCostofSalesForPeriodBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AFA RID: 2810
		// (get) Token: 0x06001DED RID: 7661 RVA: 0x0010BC86 File Offset: 0x00109E86
		// (set) Token: 0x06001DEE RID: 7662 RVA: 0x0010BC90 File Offset: 0x00109E90
		internal virtual BindingSource OveralCostofAdjustmentsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AFB RID: 2811
		// (get) Token: 0x06001DEF RID: 7663 RVA: 0x0010BC99 File Offset: 0x00109E99
		// (set) Token: 0x06001DF0 RID: 7664 RVA: 0x0010BCA3 File Offset: 0x00109EA3
		internal virtual BindingSource OveralTaxReturnsForPeriodSummaryBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AFC RID: 2812
		// (get) Token: 0x06001DF1 RID: 7665 RVA: 0x0010BCAC File Offset: 0x00109EAC
		// (set) Token: 0x06001DF2 RID: 7666 RVA: 0x0010BCB6 File Offset: 0x00109EB6
		internal virtual BindingSource OveralExpensesForPeriodBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AFD RID: 2813
		// (get) Token: 0x06001DF3 RID: 7667 RVA: 0x0010BCBF File Offset: 0x00109EBF
		// (set) Token: 0x06001DF4 RID: 7668 RVA: 0x0010BCC9 File Offset: 0x00109EC9
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AFE RID: 2814
		// (get) Token: 0x06001DF5 RID: 7669 RVA: 0x0010BCD2 File Offset: 0x00109ED2
		// (set) Token: 0x06001DF6 RID: 7670 RVA: 0x0010BCDC File Offset: 0x00109EDC
		internal virtual OveralSalesForPeriodTableAdapter OveralSalesForPeriodTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000AFF RID: 2815
		// (get) Token: 0x06001DF7 RID: 7671 RVA: 0x0010BCE5 File Offset: 0x00109EE5
		// (set) Token: 0x06001DF8 RID: 7672 RVA: 0x0010BCEF File Offset: 0x00109EEF
		internal virtual OveralCostofSalesForPeriodTableAdapter OveralCostofSalesForPeriodTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B00 RID: 2816
		// (get) Token: 0x06001DF9 RID: 7673 RVA: 0x0010BCF8 File Offset: 0x00109EF8
		// (set) Token: 0x06001DFA RID: 7674 RVA: 0x0010BD02 File Offset: 0x00109F02
		internal virtual OveralCostofAdjustmentsTableAdapter OveralCostofAdjustmentsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B01 RID: 2817
		// (get) Token: 0x06001DFB RID: 7675 RVA: 0x0010BD0B File Offset: 0x00109F0B
		// (set) Token: 0x06001DFC RID: 7676 RVA: 0x0010BD15 File Offset: 0x00109F15
		internal virtual OveralTaxReturnsForPeriodSummaryTableAdapter OveralTaxReturnsForPeriodSummaryTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B02 RID: 2818
		// (get) Token: 0x06001DFD RID: 7677 RVA: 0x0010BD1E File Offset: 0x00109F1E
		// (set) Token: 0x06001DFE RID: 7678 RVA: 0x0010BD28 File Offset: 0x00109F28
		internal virtual OveralExpensesForPeriodTableAdapter OveralExpensesForPeriodTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06001DFF RID: 7679 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label2_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06001E00 RID: 7680 RVA: 0x0010BD34 File Offset: 0x00109F34
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
				this.GetCompanyDetailsTableAdapter.Connection = sqlConnection;
				this.OveralSalesForPeriodTableAdapter.Connection = sqlConnection;
				this.OveralExpensesForPeriodTableAdapter.Connection = sqlConnection;
				this.OveralCostofAdjustmentsTableAdapter.Connection = sqlConnection;
				this.OveralCostofSalesForPeriodTableAdapter.Connection = sqlConnection;
				this.OveralTaxReturnsForPeriodSummaryTableAdapter.Connection = sqlConnection;
				ReportParameter reportParameter = new ReportParameter("startdate", Conversions.ToString(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))));
				ReportParameter reportParameter2 = new ReportParameter("StartDateDesc", this.DTStartdate.Value.ToShortDateString());
				ReportParameter reportParameter3 = new ReportParameter("enddate", Conversions.ToString(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))));
				ReportParameter reportParameter4 = new ReportParameter("EndDateDesc", this.DTEnddate.Value.ToShortDateString());
				ReportParameter reportParameter5 = new ReportParameter("coid", Conversions.ToString(MyProject.Forms.Form1.coid));
				ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter2, reportParameter3, reportParameter4, reportParameter5 };
				this.ReportViewer1.LocalReport.SetParameters(array);
				this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
				this.OveralSalesForPeriodTableAdapter.Fill(this.POSDataSet.OveralSalesForPeriod, new int?(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid));
				this.OveralExpensesForPeriodTableAdapter.Fill(this.POSDataSet.OveralExpensesForPeriod, new int?(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid));
				this.OveralCostofAdjustmentsTableAdapter.Fill(this.POSDataSet.OveralCostofAdjustments, new int?(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid));
				this.OveralCostofSalesForPeriodTableAdapter.Fill(this.POSDataSet.OveralCostofSalesForPeriod, new int?(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid));
				this.OveralTaxReturnsForPeriodSummaryTableAdapter.Fill(this.POSDataSet.OveralTaxReturnsForPeriodSummary, new int?(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid));
				this.ReportViewer1.RefreshReport();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying report. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001E01 RID: 7681 RVA: 0x00002A30 File Offset: 0x00000C30
		private void OveralRevenueReport_Load(object sender, EventArgs e)
		{
		}
	}
}
