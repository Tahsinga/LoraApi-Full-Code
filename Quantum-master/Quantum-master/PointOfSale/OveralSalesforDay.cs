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
	// Token: 0x02000082 RID: 130
	[DesignerGenerated]
	public partial class OveralSalesforDay : UserControl
	{
		// Token: 0x06001E02 RID: 7682 RVA: 0x0010C130 File Offset: 0x0010A330
		public OveralSalesforDay()
		{
			this.InitializeComponent();
		}

		// Token: 0x17000B03 RID: 2819
		// (get) Token: 0x06001E05 RID: 7685 RVA: 0x0010C8D0 File Offset: 0x0010AAD0
		// (set) Token: 0x06001E06 RID: 7686 RVA: 0x0010C8DA File Offset: 0x0010AADA
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B04 RID: 2820
		// (get) Token: 0x06001E07 RID: 7687 RVA: 0x0010C8E3 File Offset: 0x0010AAE3
		// (set) Token: 0x06001E08 RID: 7688 RVA: 0x0010C8ED File Offset: 0x0010AAED
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B05 RID: 2821
		// (get) Token: 0x06001E09 RID: 7689 RVA: 0x0010C8F6 File Offset: 0x0010AAF6
		// (set) Token: 0x06001E0A RID: 7690 RVA: 0x0010C900 File Offset: 0x0010AB00
		internal virtual BindingSource OveralSalesSummaryForDayBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B06 RID: 2822
		// (get) Token: 0x06001E0B RID: 7691 RVA: 0x0010C909 File Offset: 0x0010AB09
		// (set) Token: 0x06001E0C RID: 7692 RVA: 0x0010C913 File Offset: 0x0010AB13
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B07 RID: 2823
		// (get) Token: 0x06001E0D RID: 7693 RVA: 0x0010C91C File Offset: 0x0010AB1C
		// (set) Token: 0x06001E0E RID: 7694 RVA: 0x0010C926 File Offset: 0x0010AB26
		internal virtual BindingSource OveralPaymentSummaryForDayBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B08 RID: 2824
		// (get) Token: 0x06001E0F RID: 7695 RVA: 0x0010C92F File Offset: 0x0010AB2F
		// (set) Token: 0x06001E10 RID: 7696 RVA: 0x0010C939 File Offset: 0x0010AB39
		internal virtual BindingSource OveralSalesDetailForDayBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B09 RID: 2825
		// (get) Token: 0x06001E11 RID: 7697 RVA: 0x0010C942 File Offset: 0x0010AB42
		// (set) Token: 0x06001E12 RID: 7698 RVA: 0x0010C94C File Offset: 0x0010AB4C
		internal virtual OveralSalesSummaryForDayTableAdapter OveralSalesSummaryForDayTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B0A RID: 2826
		// (get) Token: 0x06001E13 RID: 7699 RVA: 0x0010C955 File Offset: 0x0010AB55
		// (set) Token: 0x06001E14 RID: 7700 RVA: 0x0010C95F File Offset: 0x0010AB5F
		internal virtual OveralPaymentSummaryForDayTableAdapter OveralPaymentSummaryForDayTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x06001E15 RID: 7701 RVA: 0x0010C968 File Offset: 0x0010AB68
		// (set) Token: 0x06001E16 RID: 7702 RVA: 0x0010C972 File Offset: 0x0010AB72
		internal virtual OveralSalesDetailForDayTableAdapter OveralSalesDetailForDayTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B0C RID: 2828
		// (get) Token: 0x06001E17 RID: 7703 RVA: 0x0010C97B File Offset: 0x0010AB7B
		// (set) Token: 0x06001E18 RID: 7704 RVA: 0x0010C985 File Offset: 0x0010AB85
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B0D RID: 2829
		// (get) Token: 0x06001E19 RID: 7705 RVA: 0x0010C98E File Offset: 0x0010AB8E
		// (set) Token: 0x06001E1A RID: 7706 RVA: 0x0010C998 File Offset: 0x0010AB98
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

		// Token: 0x17000B0E RID: 2830
		// (get) Token: 0x06001E1B RID: 7707 RVA: 0x0010C9DB File Offset: 0x0010ABDB
		// (set) Token: 0x06001E1C RID: 7708 RVA: 0x0010C9E5 File Offset: 0x0010ABE5
		internal virtual DateTimePicker DTdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B0F RID: 2831
		// (get) Token: 0x06001E1D RID: 7709 RVA: 0x0010C9EE File Offset: 0x0010ABEE
		// (set) Token: 0x06001E1E RID: 7710 RVA: 0x0010C9F8 File Offset: 0x0010ABF8
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B10 RID: 2832
		// (get) Token: 0x06001E1F RID: 7711 RVA: 0x0010CA01 File Offset: 0x0010AC01
		// (set) Token: 0x06001E20 RID: 7712 RVA: 0x0010CA0B File Offset: 0x0010AC0B
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B11 RID: 2833
		// (get) Token: 0x06001E21 RID: 7713 RVA: 0x0010CA14 File Offset: 0x0010AC14
		// (set) Token: 0x06001E22 RID: 7714 RVA: 0x0010CA1E File Offset: 0x0010AC1E
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B12 RID: 2834
		// (get) Token: 0x06001E23 RID: 7715 RVA: 0x0010CA27 File Offset: 0x0010AC27
		// (set) Token: 0x06001E24 RID: 7716 RVA: 0x0010CA34 File Offset: 0x0010AC34
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

		// Token: 0x06001E25 RID: 7717 RVA: 0x0010CA78 File Offset: 0x0010AC78
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
				this.GetCompanyDetailsTableAdapter.Connection = sqlConnection;
				this.OveralPaymentSummaryForDayTableAdapter.Connection = sqlConnection;
				this.OveralSalesDetailForDayTableAdapter.Connection = sqlConnection;
				this.OveralSalesSummaryForDayTableAdapter.Connection = sqlConnection;
				ReportParameter reportParameter = new ReportParameter("theday", Conversions.ToString(Conversions.ToInteger(this.DTdate.Value.ToString("yyyyMMdd"))));
				ReportParameter reportParameter2 = new ReportParameter("TranDateDesc", this.DTdate.Value.ToShortDateString());
				ReportParameter reportParameter3 = new ReportParameter("coid", Conversions.ToString(MyProject.Forms.Form1.coid));
				ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter2, reportParameter3 };
				this.ReportViewer1.LocalReport.SetParameters(array);
				this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
				this.OveralPaymentSummaryForDayTableAdapter.Fill(this.POSDataSet.OveralPaymentSummaryForDay, new int?(Conversions.ToInteger(this.DTdate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid));
				this.OveralSalesDetailForDayTableAdapter.Fill(this.POSDataSet.OveralSalesDetailForDay, new int?(Conversions.ToInteger(this.DTdate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid));
				this.OveralSalesSummaryForDayTableAdapter.Fill(this.POSDataSet.OveralSalesSummaryForDay, new int?(Conversions.ToInteger(this.DTdate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid));
				this.ReportViewer1.RefreshReport();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying report. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001E26 RID: 7718 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label2_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}
	}
}
