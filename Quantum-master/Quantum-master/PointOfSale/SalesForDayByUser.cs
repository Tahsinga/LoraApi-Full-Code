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
	// Token: 0x0200019C RID: 412
	[DesignerGenerated]
	public partial class SalesForDayByUser : UserControl
	{
		// Token: 0x0600494A RID: 18762 RVA: 0x002C5EDC File Offset: 0x002C40DC
		public SalesForDayByUser()
		{
			base.Load += this.SalesForDayByUser_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x17001AB1 RID: 6833
		// (get) Token: 0x0600494D RID: 18765 RVA: 0x002C708B File Offset: 0x002C528B
		// (set) Token: 0x0600494E RID: 18766 RVA: 0x002C7098 File Offset: 0x002C5298
		internal virtual GroupBox GroupBox1
		{
			[CompilerGenerated]
			get
			{
				return this._GroupBox1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.GroupBox1_Enter);
				GroupBox groupBox = this._GroupBox1;
				if (groupBox != null)
				{
					groupBox.Enter -= eventHandler;
				}
				this._GroupBox1 = value;
				groupBox = this._GroupBox1;
				if (groupBox != null)
				{
					groupBox.Enter += eventHandler;
				}
			}
		}

		// Token: 0x17001AB2 RID: 6834
		// (get) Token: 0x0600494F RID: 18767 RVA: 0x002C70DB File Offset: 0x002C52DB
		// (set) Token: 0x06004950 RID: 18768 RVA: 0x002C70E5 File Offset: 0x002C52E5
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AB3 RID: 6835
		// (get) Token: 0x06004951 RID: 18769 RVA: 0x002C70EE File Offset: 0x002C52EE
		// (set) Token: 0x06004952 RID: 18770 RVA: 0x002C70F8 File Offset: 0x002C52F8
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

		// Token: 0x17001AB4 RID: 6836
		// (get) Token: 0x06004953 RID: 18771 RVA: 0x002C713B File Offset: 0x002C533B
		// (set) Token: 0x06004954 RID: 18772 RVA: 0x002C7148 File Offset: 0x002C5348
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

		// Token: 0x17001AB5 RID: 6837
		// (get) Token: 0x06004955 RID: 18773 RVA: 0x002C718B File Offset: 0x002C538B
		// (set) Token: 0x06004956 RID: 18774 RVA: 0x002C7195 File Offset: 0x002C5395
		internal virtual DateTimePicker DTStartDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AB6 RID: 6838
		// (get) Token: 0x06004957 RID: 18775 RVA: 0x002C719E File Offset: 0x002C539E
		// (set) Token: 0x06004958 RID: 18776 RVA: 0x002C71A8 File Offset: 0x002C53A8
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AB7 RID: 6839
		// (get) Token: 0x06004959 RID: 18777 RVA: 0x002C71B1 File Offset: 0x002C53B1
		// (set) Token: 0x0600495A RID: 18778 RVA: 0x002C71BB File Offset: 0x002C53BB
		internal virtual ComboBox cboUsers
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AB8 RID: 6840
		// (get) Token: 0x0600495B RID: 18779 RVA: 0x002C71C4 File Offset: 0x002C53C4
		// (set) Token: 0x0600495C RID: 18780 RVA: 0x002C71CE File Offset: 0x002C53CE
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AB9 RID: 6841
		// (get) Token: 0x0600495D RID: 18781 RVA: 0x002C71D7 File Offset: 0x002C53D7
		// (set) Token: 0x0600495E RID: 18782 RVA: 0x002C71E1 File Offset: 0x002C53E1
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001ABA RID: 6842
		// (get) Token: 0x0600495F RID: 18783 RVA: 0x002C71EA File Offset: 0x002C53EA
		// (set) Token: 0x06004960 RID: 18784 RVA: 0x002C71F4 File Offset: 0x002C53F4
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001ABB RID: 6843
		// (get) Token: 0x06004961 RID: 18785 RVA: 0x002C71FD File Offset: 0x002C53FD
		// (set) Token: 0x06004962 RID: 18786 RVA: 0x002C7207 File Offset: 0x002C5407
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001ABC RID: 6844
		// (get) Token: 0x06004963 RID: 18787 RVA: 0x002C7210 File Offset: 0x002C5410
		// (set) Token: 0x06004964 RID: 18788 RVA: 0x002C721A File Offset: 0x002C541A
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001ABD RID: 6845
		// (get) Token: 0x06004965 RID: 18789 RVA: 0x002C7223 File Offset: 0x002C5423
		// (set) Token: 0x06004966 RID: 18790 RVA: 0x002C722D File Offset: 0x002C542D
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001ABE RID: 6846
		// (get) Token: 0x06004967 RID: 18791 RVA: 0x002C7236 File Offset: 0x002C5436
		// (set) Token: 0x06004968 RID: 18792 RVA: 0x002C7240 File Offset: 0x002C5440
		internal virtual ComboBox cboBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001ABF RID: 6847
		// (get) Token: 0x06004969 RID: 18793 RVA: 0x002C7249 File Offset: 0x002C5449
		// (set) Token: 0x0600496A RID: 18794 RVA: 0x002C7253 File Offset: 0x002C5453
		internal virtual BindingSource USERSalesDayDetailBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AC0 RID: 6848
		// (get) Token: 0x0600496B RID: 18795 RVA: 0x002C725C File Offset: 0x002C545C
		// (set) Token: 0x0600496C RID: 18796 RVA: 0x002C7266 File Offset: 0x002C5466
		internal virtual BindingSource USERSalesPaymentSummaryBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AC1 RID: 6849
		// (get) Token: 0x0600496D RID: 18797 RVA: 0x002C726F File Offset: 0x002C546F
		// (set) Token: 0x0600496E RID: 18798 RVA: 0x002C7279 File Offset: 0x002C5479
		internal virtual BindingSource UserSalesCategorySummaryPERIODBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AC2 RID: 6850
		// (get) Token: 0x0600496F RID: 18799 RVA: 0x002C7282 File Offset: 0x002C5482
		// (set) Token: 0x06004970 RID: 18800 RVA: 0x002C728C File Offset: 0x002C548C
		internal virtual USERSalesDayDetailTableAdapter USERSalesDayDetailTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AC3 RID: 6851
		// (get) Token: 0x06004971 RID: 18801 RVA: 0x002C7295 File Offset: 0x002C5495
		// (set) Token: 0x06004972 RID: 18802 RVA: 0x002C729F File Offset: 0x002C549F
		internal virtual USERSalesPaymentSummaryTableAdapter USERSalesPaymentSummaryTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AC4 RID: 6852
		// (get) Token: 0x06004973 RID: 18803 RVA: 0x002C72A8 File Offset: 0x002C54A8
		// (set) Token: 0x06004974 RID: 18804 RVA: 0x002C72B2 File Offset: 0x002C54B2
		internal virtual UserSalesCategorySummaryPERIODTableAdapter UserSalesCategorySummaryPERIODTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AC5 RID: 6853
		// (get) Token: 0x06004975 RID: 18805 RVA: 0x002C72BB File Offset: 0x002C54BB
		// (set) Token: 0x06004976 RID: 18806 RVA: 0x002C72C5 File Offset: 0x002C54C5
		internal virtual BindingSource SalesSummaryForDayBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AC6 RID: 6854
		// (get) Token: 0x06004977 RID: 18807 RVA: 0x002C72CE File Offset: 0x002C54CE
		// (set) Token: 0x06004978 RID: 18808 RVA: 0x002C72D8 File Offset: 0x002C54D8
		internal virtual BindingSource SalesDetailForDayBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AC7 RID: 6855
		// (get) Token: 0x06004979 RID: 18809 RVA: 0x002C72E1 File Offset: 0x002C54E1
		// (set) Token: 0x0600497A RID: 18810 RVA: 0x002C72EB File Offset: 0x002C54EB
		internal virtual BindingSource PaymentSummaryForDayBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AC8 RID: 6856
		// (get) Token: 0x0600497B RID: 18811 RVA: 0x002C72F4 File Offset: 0x002C54F4
		// (set) Token: 0x0600497C RID: 18812 RVA: 0x002C72FE File Offset: 0x002C54FE
		internal virtual SalesSummaryForDayTableAdapter SalesSummaryForDayTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AC9 RID: 6857
		// (get) Token: 0x0600497D RID: 18813 RVA: 0x002C7307 File Offset: 0x002C5507
		// (set) Token: 0x0600497E RID: 18814 RVA: 0x002C7311 File Offset: 0x002C5511
		internal virtual SalesDetailForDayTableAdapter SalesDetailForDayTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001ACA RID: 6858
		// (get) Token: 0x0600497F RID: 18815 RVA: 0x002C731A File Offset: 0x002C551A
		// (set) Token: 0x06004980 RID: 18816 RVA: 0x002C7324 File Offset: 0x002C5524
		internal virtual PaymentSummaryForDayTableAdapter PaymentSummaryForDayTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001ACB RID: 6859
		// (get) Token: 0x06004981 RID: 18817 RVA: 0x002C732D File Offset: 0x002C552D
		// (set) Token: 0x06004982 RID: 18818 RVA: 0x002C7337 File Offset: 0x002C5537
		internal virtual BindingSource ShiftSalesSummaryByUserBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001ACC RID: 6860
		// (get) Token: 0x06004983 RID: 18819 RVA: 0x002C7340 File Offset: 0x002C5540
		// (set) Token: 0x06004984 RID: 18820 RVA: 0x002C734A File Offset: 0x002C554A
		internal virtual ShiftSalesSummaryByUserTableAdapter ShiftSalesSummaryByUserTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001ACD RID: 6861
		// (get) Token: 0x06004985 RID: 18821 RVA: 0x002C7353 File Offset: 0x002C5553
		// (set) Token: 0x06004986 RID: 18822 RVA: 0x002C735D File Offset: 0x002C555D
		internal virtual BindingSource UserAccSalesSummaryBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001ACE RID: 6862
		// (get) Token: 0x06004987 RID: 18823 RVA: 0x002C7366 File Offset: 0x002C5566
		// (set) Token: 0x06004988 RID: 18824 RVA: 0x002C7370 File Offset: 0x002C5570
		internal virtual BindingSource BillingSalesBreakdownForUserBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001ACF RID: 6863
		// (get) Token: 0x06004989 RID: 18825 RVA: 0x002C7379 File Offset: 0x002C5579
		// (set) Token: 0x0600498A RID: 18826 RVA: 0x002C7383 File Offset: 0x002C5583
		internal virtual BindingSource BillingPaymentSummaryUserBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AD0 RID: 6864
		// (get) Token: 0x0600498B RID: 18827 RVA: 0x002C738C File Offset: 0x002C558C
		// (set) Token: 0x0600498C RID: 18828 RVA: 0x002C7396 File Offset: 0x002C5596
		internal virtual BillingSalesBreakdownForUserTableAdapter BillingSalesBreakdownForUserTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AD1 RID: 6865
		// (get) Token: 0x0600498D RID: 18829 RVA: 0x002C739F File Offset: 0x002C559F
		// (set) Token: 0x0600498E RID: 18830 RVA: 0x002C73A9 File Offset: 0x002C55A9
		internal virtual BillingPaymentSummaryUserTableAdapter BillingPaymentSummaryUserTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AD2 RID: 6866
		// (get) Token: 0x0600498F RID: 18831 RVA: 0x002C73B2 File Offset: 0x002C55B2
		// (set) Token: 0x06004990 RID: 18832 RVA: 0x002C73BC File Offset: 0x002C55BC
		internal virtual BindingSource DiscountsForUserForDayBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AD3 RID: 6867
		// (get) Token: 0x06004991 RID: 18833 RVA: 0x002C73C5 File Offset: 0x002C55C5
		// (set) Token: 0x06004992 RID: 18834 RVA: 0x002C73CF File Offset: 0x002C55CF
		internal virtual DiscountsForUserForDayTableAdapter DiscountsForUserForDayTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AD4 RID: 6868
		// (get) Token: 0x06004993 RID: 18835 RVA: 0x002C73D8 File Offset: 0x002C55D8
		// (set) Token: 0x06004994 RID: 18836 RVA: 0x002C73E2 File Offset: 0x002C55E2
		internal virtual BindingSource DiscountsForDayBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AD5 RID: 6869
		// (get) Token: 0x06004995 RID: 18837 RVA: 0x002C73EB File Offset: 0x002C55EB
		// (set) Token: 0x06004996 RID: 18838 RVA: 0x002C73F5 File Offset: 0x002C55F5
		internal virtual DiscountsForDayTableAdapter DiscountsForDayTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AD6 RID: 6870
		// (get) Token: 0x06004997 RID: 18839 RVA: 0x002C73FE File Offset: 0x002C55FE
		// (set) Token: 0x06004998 RID: 18840 RVA: 0x002C7408 File Offset: 0x002C5608
		internal virtual CheckBox chkShowAll
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AD7 RID: 6871
		// (get) Token: 0x06004999 RID: 18841 RVA: 0x002C7411 File Offset: 0x002C5611
		// (set) Token: 0x0600499A RID: 18842 RVA: 0x002C741B File Offset: 0x002C561B
		internal virtual CheckBox chkHideCats
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AD8 RID: 6872
		// (get) Token: 0x0600499B RID: 18843 RVA: 0x002C7424 File Offset: 0x002C5624
		// (set) Token: 0x0600499C RID: 18844 RVA: 0x002C742E File Offset: 0x002C562E
		internal virtual BindingSource ShiftDetailBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001AD9 RID: 6873
		// (get) Token: 0x0600499D RID: 18845 RVA: 0x002C7437 File Offset: 0x002C5637
		// (set) Token: 0x0600499E RID: 18846 RVA: 0x002C7441 File Offset: 0x002C5641
		internal virtual ShiftDetailTableAdapter ShiftDetailTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x0600499F RID: 18847 RVA: 0x002C744C File Offset: 0x002C564C
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

		// Token: 0x060049A0 RID: 18848 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label2_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x060049A1 RID: 18849 RVA: 0x002C7510 File Offset: 0x002C5710
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.runreport();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying report. Detail: " + ex.Message);
			}
		}

		// Token: 0x060049A2 RID: 18850 RVA: 0x002C7560 File Offset: 0x002C5760
		private void runreport()
		{
			SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
			this.GetCompanyDetailsTableAdapter.Connection = sqlConnection;
			this.USERSalesPaymentSummaryTableAdapter.Connection = sqlConnection;
			this.UserSalesCategorySummaryPERIODTableAdapter.Connection = sqlConnection;
			this.USERSalesDayDetailTableAdapter.Connection = sqlConnection;
			this.ShiftSalesSummaryByUserTableAdapter.Connection = sqlConnection;
			this.BillingPaymentSummaryUserTableAdapter.Connection = sqlConnection;
			this.BillingSalesBreakdownForUserTableAdapter.Connection = sqlConnection;
			this.DiscountsForUserForDayTableAdapter.Connection = sqlConnection;
			this.DiscountsForDayTableAdapter.Connection = sqlConnection;
			this.ShiftDetailTableAdapter.Connection = sqlConnection;
			ReportParameter reportParameter = new ReportParameter("shiftdate", Conversions.ToString(Conversions.ToInteger(this.DTStartDate.Value.ToString("yyyyMMdd"))));
			ReportParameter reportParameter2 = new ReportParameter("shiftdateDesc", this.DTStartDate.Value.ToShortDateString());
			ReportParameter reportParameter3 = new ReportParameter("coid", Conversions.ToString(MyProject.Forms.Form1.coid));
			ReportParameter reportParameter4 = new ReportParameter("branch", this.cboBranch.Text);
			ReportParameter reportParameter5 = new ReportParameter("theuser", this.cboUsers.Text);
			ReportParameter reportParameter6 = new ReportParameter("showall", Conversions.ToString(Conversions.ToInteger(Interaction.IIf(this.chkShowAll.Checked, 1, 0))));
			ReportParameter reportParameter7 = new ReportParameter("hidecats", Conversions.ToString(Conversions.ToInteger(Interaction.IIf(this.chkHideCats.Checked, 1, 0))));
			ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter2, reportParameter3, reportParameter4, reportParameter5, reportParameter6, reportParameter7 };
			this.ReportViewer1.LocalReport.SetParameters(array);
			this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
			this.USERSalesPaymentSummaryTableAdapter.Fill(this.POSDataSet.USERSalesPaymentSummary, new int?(Conversions.ToInteger(this.DTStartDate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text, this.cboUsers.Text);
			checked
			{
				this.USERSalesDayDetailTableAdapter.Fill(this.POSDataSet.USERSalesDayDetail, new int?((int)Math.Round(Conversion.Val(this.DTStartDate.Value.ToString("yyyyMMdd")))), new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text, this.cboUsers.Text);
				this.UserSalesCategorySummaryPERIODTableAdapter.Fill(this.POSDataSet.UserSalesCategorySummaryPERIOD, new int?((int)Math.Round(Conversion.Val(this.DTStartDate.Value.ToString("yyyyMMdd")))), new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text, this.cboUsers.Text);
				this.ShiftSalesSummaryByUserTableAdapter.Fill(this.POSDataSet.ShiftSalesSummaryByUser, new int?((int)Math.Round(Conversion.Val(this.DTStartDate.Value.ToString("yyyyMMdd")))), new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text);
				this.BillingPaymentSummaryUserTableAdapter.Fill(this.POSDataSet.BillingPaymentSummaryUser, new int?(Convert.ToInt32(this.DTStartDate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text, this.cboUsers.Text);
				this.BillingSalesBreakdownForUserTableAdapter.Fill(this.POSDataSet.BillingSalesBreakdownForUser, new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text, this.cboUsers.Text, new int?(Convert.ToInt32(this.DTStartDate.Value.ToString("yyyyMMdd"))));
				this.DiscountsForUserForDayTableAdapter.Fill(this.POSDataSet.DiscountsForUserForDay, new int?(Convert.ToInt32(this.DTStartDate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text, this.cboUsers.Text);
				this.DiscountsForDayTableAdapter.Fill(this.POSDataSet.DiscountsForDay, new int?(Convert.ToInt32(this.DTStartDate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text);
				this.ShiftDetailTableAdapter.Fill(this.POSDataSet.ShiftDetail, Convert.ToInt32(this.DTStartDate.Value.ToString("yyyyMMdd")), MyProject.Forms.Form1.coid, this.cboBranch.Text, this.cboUsers.Text);
				this.ReportViewer1.RefreshReport();
			}
		}

		// Token: 0x060049A3 RID: 18851 RVA: 0x002C7AD8 File Offset: 0x002C5CD8
		private void SalesForDayByUser_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadUsers(MyProject.Forms.Form1.coid);
				this.LoadBranches();
				bool isAdmin = MyProject.Forms.Form1.IsAdmin;
				if (isAdmin)
				{
					this.chkShowAll.Enabled = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading users. Detail: " + ex.Message);
			}
		}

		// Token: 0x060049A4 RID: 18852 RVA: 0x002C7B60 File Offset: 0x002C5D60
		private void LoadUsers(int coid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchUsers";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				this.cboUsers.DataSource = dataTable;
				this.cboUsers.DisplayMember = "Username";
				this.cboUsers.ValueMember = "Username";
			}
		}

		// Token: 0x060049A5 RID: 18853 RVA: 0x00002A30 File Offset: 0x00000C30
		private void GroupBox1_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x04002044 RID: 8260
		private string _cnn;
	}
}
