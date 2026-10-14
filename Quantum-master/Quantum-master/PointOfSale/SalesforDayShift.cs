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
	// Token: 0x0200019D RID: 413
	[DesignerGenerated]
	public partial class SalesforDayShift : UserControl
	{
		// Token: 0x060049A6 RID: 18854 RVA: 0x002C7BFE File Offset: 0x002C5DFE
		public SalesforDayShift()
		{
			base.Load += this.SalesforDayShift_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x17001ADA RID: 6874
		// (get) Token: 0x060049A9 RID: 18857 RVA: 0x002C857F File Offset: 0x002C677F
		// (set) Token: 0x060049AA RID: 18858 RVA: 0x002C8589 File Offset: 0x002C6789
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001ADB RID: 6875
		// (get) Token: 0x060049AB RID: 18859 RVA: 0x002C8592 File Offset: 0x002C6792
		// (set) Token: 0x060049AC RID: 18860 RVA: 0x002C859C File Offset: 0x002C679C
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001ADC RID: 6876
		// (get) Token: 0x060049AD RID: 18861 RVA: 0x002C85A5 File Offset: 0x002C67A5
		// (set) Token: 0x060049AE RID: 18862 RVA: 0x002C85AF File Offset: 0x002C67AF
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001ADD RID: 6877
		// (get) Token: 0x060049AF RID: 18863 RVA: 0x002C85B8 File Offset: 0x002C67B8
		// (set) Token: 0x060049B0 RID: 18864 RVA: 0x002C85C4 File Offset: 0x002C67C4
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

		// Token: 0x17001ADE RID: 6878
		// (get) Token: 0x060049B1 RID: 18865 RVA: 0x002C8607 File Offset: 0x002C6807
		// (set) Token: 0x060049B2 RID: 18866 RVA: 0x002C8614 File Offset: 0x002C6814
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

		// Token: 0x17001ADF RID: 6879
		// (get) Token: 0x060049B3 RID: 18867 RVA: 0x002C8657 File Offset: 0x002C6857
		// (set) Token: 0x060049B4 RID: 18868 RVA: 0x002C8661 File Offset: 0x002C6861
		internal virtual DateTimePicker DTdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AE0 RID: 6880
		// (get) Token: 0x060049B5 RID: 18869 RVA: 0x002C866A File Offset: 0x002C686A
		// (set) Token: 0x060049B6 RID: 18870 RVA: 0x002C8674 File Offset: 0x002C6874
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AE1 RID: 6881
		// (get) Token: 0x060049B7 RID: 18871 RVA: 0x002C867D File Offset: 0x002C687D
		// (set) Token: 0x060049B8 RID: 18872 RVA: 0x002C8687 File Offset: 0x002C6887
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AE2 RID: 6882
		// (get) Token: 0x060049B9 RID: 18873 RVA: 0x002C8690 File Offset: 0x002C6890
		// (set) Token: 0x060049BA RID: 18874 RVA: 0x002C869A File Offset: 0x002C689A
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AE3 RID: 6883
		// (get) Token: 0x060049BB RID: 18875 RVA: 0x002C86A3 File Offset: 0x002C68A3
		// (set) Token: 0x060049BC RID: 18876 RVA: 0x002C86AD File Offset: 0x002C68AD
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AE4 RID: 6884
		// (get) Token: 0x060049BD RID: 18877 RVA: 0x002C86B6 File Offset: 0x002C68B6
		// (set) Token: 0x060049BE RID: 18878 RVA: 0x002C86C0 File Offset: 0x002C68C0
		internal virtual BindingSource ShiftSalesCategorySummaryBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AE5 RID: 6885
		// (get) Token: 0x060049BF RID: 18879 RVA: 0x002C86C9 File Offset: 0x002C68C9
		// (set) Token: 0x060049C0 RID: 18880 RVA: 0x002C86D3 File Offset: 0x002C68D3
		internal virtual BindingSource ShiftSalesPaymentSummaryBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AE6 RID: 6886
		// (get) Token: 0x060049C1 RID: 18881 RVA: 0x002C86DC File Offset: 0x002C68DC
		// (set) Token: 0x060049C2 RID: 18882 RVA: 0x002C86E6 File Offset: 0x002C68E6
		internal virtual BindingSource ShiftSalesDayDetailBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AE7 RID: 6887
		// (get) Token: 0x060049C3 RID: 18883 RVA: 0x002C86EF File Offset: 0x002C68EF
		// (set) Token: 0x060049C4 RID: 18884 RVA: 0x002C86F9 File Offset: 0x002C68F9
		internal virtual BindingSource ShiftSalesNightDetailBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AE8 RID: 6888
		// (get) Token: 0x060049C5 RID: 18885 RVA: 0x002C8702 File Offset: 0x002C6902
		// (set) Token: 0x060049C6 RID: 18886 RVA: 0x002C870C File Offset: 0x002C690C
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AE9 RID: 6889
		// (get) Token: 0x060049C7 RID: 18887 RVA: 0x002C8715 File Offset: 0x002C6915
		// (set) Token: 0x060049C8 RID: 18888 RVA: 0x002C871F File Offset: 0x002C691F
		internal virtual ShiftSalesCategorySummaryTableAdapter ShiftSalesCategorySummaryTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AEA RID: 6890
		// (get) Token: 0x060049C9 RID: 18889 RVA: 0x002C8728 File Offset: 0x002C6928
		// (set) Token: 0x060049CA RID: 18890 RVA: 0x002C8732 File Offset: 0x002C6932
		internal virtual ShiftSalesPaymentSummaryTableAdapter ShiftSalesPaymentSummaryTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AEB RID: 6891
		// (get) Token: 0x060049CB RID: 18891 RVA: 0x002C873B File Offset: 0x002C693B
		// (set) Token: 0x060049CC RID: 18892 RVA: 0x002C8745 File Offset: 0x002C6945
		internal virtual ShiftSalesDayDetailTableAdapter ShiftSalesDayDetailTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AEC RID: 6892
		// (get) Token: 0x060049CD RID: 18893 RVA: 0x002C874E File Offset: 0x002C694E
		// (set) Token: 0x060049CE RID: 18894 RVA: 0x002C8758 File Offset: 0x002C6958
		internal virtual ShiftSalesNightDetailTableAdapter ShiftSalesNightDetailTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AED RID: 6893
		// (get) Token: 0x060049CF RID: 18895 RVA: 0x002C8761 File Offset: 0x002C6961
		// (set) Token: 0x060049D0 RID: 18896 RVA: 0x002C876B File Offset: 0x002C696B
		internal virtual Label cboBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060049D1 RID: 18897 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label2_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x060049D2 RID: 18898 RVA: 0x002C8774 File Offset: 0x002C6974
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
				this.GetCompanyDetailsTableAdapter.Connection = sqlConnection;
				this.ShiftSalesCategorySummaryTableAdapter.Connection = sqlConnection;
				this.ShiftSalesDayDetailTableAdapter.Connection = sqlConnection;
				this.ShiftSalesNightDetailTableAdapter.Connection = sqlConnection;
				this.ShiftSalesPaymentSummaryTableAdapter.Connection = sqlConnection;
				ReportParameter reportParameter = new ReportParameter("theday", Conversions.ToString(Conversions.ToInteger(this.DTdate.Value.ToString("yyyyMMdd"))));
				ReportParameter reportParameter2 = new ReportParameter("TranDateDesc", this.DTdate.Value.ToShortDateString());
				ReportParameter reportParameter3 = new ReportParameter("coid", Conversions.ToString(MyProject.Forms.Form1.coid));
				ReportParameter reportParameter4 = new ReportParameter("branch", this.cboBranch.Text);
				ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter2, reportParameter3, reportParameter4 };
				this.ReportViewer1.LocalReport.SetParameters(array);
				this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
				this.ShiftSalesCategorySummaryTableAdapter.Fill(this.POSDataSet.ShiftSalesCategorySummary, new int?(Conversions.ToInteger(this.DTdate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text);
				this.ShiftSalesDayDetailTableAdapter.Fill(this.POSDataSet.ShiftSalesDayDetail, new int?(Conversions.ToInteger(this.DTdate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text);
				this.ShiftSalesNightDetailTableAdapter.Fill(this.POSDataSet.ShiftSalesNightDetail, new int?(Conversions.ToInteger(this.DTdate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text);
				this.ShiftSalesPaymentSummaryTableAdapter.Fill(this.POSDataSet.ShiftSalesPaymentSummary, new int?(Conversions.ToInteger(this.DTdate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text);
				this.ReportViewer1.RefreshReport();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying report. Detail: " + ex.Message);
			}
		}

		// Token: 0x060049D3 RID: 18899 RVA: 0x002C8A58 File Offset: 0x002C6C58
		private void SalesforDayShift_Load(object sender, EventArgs e)
		{
			try
			{
				this.cboBranch.Text = MyProject.Forms.Form1.branch;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading page. Detail: " + ex.Message);
			}
		}

		// Token: 0x0400205A RID: 8282
		private string _cnn;
	}
}
