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
	// Token: 0x02000045 RID: 69
	[DesignerGenerated]
	public partial class DiscountsGiven : UserControl
	{
		// Token: 0x06000EFA RID: 3834 RVA: 0x0008ECE0 File Offset: 0x0008CEE0
		public DiscountsGiven()
		{
			base.Load += this.DiscountsGiven_Load;
			this.pf = new PublicFunctions();
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06000EFD RID: 3837 RVA: 0x0008F58E File Offset: 0x0008D78E
		// (set) Token: 0x06000EFE RID: 3838 RVA: 0x0008F598 File Offset: 0x0008D798
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06000EFF RID: 3839 RVA: 0x0008F5A1 File Offset: 0x0008D7A1
		// (set) Token: 0x06000F00 RID: 3840 RVA: 0x0008F5AB File Offset: 0x0008D7AB
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06000F01 RID: 3841 RVA: 0x0008F5B4 File Offset: 0x0008D7B4
		// (set) Token: 0x06000F02 RID: 3842 RVA: 0x0008F5BE File Offset: 0x0008D7BE
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06000F03 RID: 3843 RVA: 0x0008F5C7 File Offset: 0x0008D7C7
		// (set) Token: 0x06000F04 RID: 3844 RVA: 0x0008F5D4 File Offset: 0x0008D7D4
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

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06000F05 RID: 3845 RVA: 0x0008F617 File Offset: 0x0008D817
		// (set) Token: 0x06000F06 RID: 3846 RVA: 0x0008F621 File Offset: 0x0008D821
		internal virtual ComboBox cboBranches
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06000F07 RID: 3847 RVA: 0x0008F62A File Offset: 0x0008D82A
		// (set) Token: 0x06000F08 RID: 3848 RVA: 0x0008F634 File Offset: 0x0008D834
		internal virtual DateTimePicker DTEnddate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06000F09 RID: 3849 RVA: 0x0008F63D File Offset: 0x0008D83D
		// (set) Token: 0x06000F0A RID: 3850 RVA: 0x0008F647 File Offset: 0x0008D847
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06000F0B RID: 3851 RVA: 0x0008F650 File Offset: 0x0008D850
		// (set) Token: 0x06000F0C RID: 3852 RVA: 0x0008F65A File Offset: 0x0008D85A
		internal virtual DateTimePicker DTStartDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06000F0D RID: 3853 RVA: 0x0008F663 File Offset: 0x0008D863
		// (set) Token: 0x06000F0E RID: 3854 RVA: 0x0008F66D File Offset: 0x0008D86D
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06000F0F RID: 3855 RVA: 0x0008F676 File Offset: 0x0008D876
		// (set) Token: 0x06000F10 RID: 3856 RVA: 0x0008F680 File Offset: 0x0008D880
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06000F11 RID: 3857 RVA: 0x0008F689 File Offset: 0x0008D889
		// (set) Token: 0x06000F12 RID: 3858 RVA: 0x0008F694 File Offset: 0x0008D894
		internal virtual Label Label5
		{
			[CompilerGenerated]
			get
			{
				return this._Label5;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label5_Click);
				Label label = this._Label5;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label5 = value;
				label = this._Label5;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x06000F13 RID: 3859 RVA: 0x0008F6D7 File Offset: 0x0008D8D7
		// (set) Token: 0x06000F14 RID: 3860 RVA: 0x0008F6E1 File Offset: 0x0008D8E1
		internal virtual BindingSource InvDiscountsGivenBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06000F15 RID: 3861 RVA: 0x0008F6EA File Offset: 0x0008D8EA
		// (set) Token: 0x06000F16 RID: 3862 RVA: 0x0008F6F4 File Offset: 0x0008D8F4
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06000F17 RID: 3863 RVA: 0x0008F6FD File Offset: 0x0008D8FD
		// (set) Token: 0x06000F18 RID: 3864 RVA: 0x0008F707 File Offset: 0x0008D907
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06000F19 RID: 3865 RVA: 0x0008F710 File Offset: 0x0008D910
		// (set) Token: 0x06000F1A RID: 3866 RVA: 0x0008F71A File Offset: 0x0008D91A
		internal virtual InvDiscountsGivenTableAdapter InvDiscountsGivenTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06000F1B RID: 3867 RVA: 0x0008F723 File Offset: 0x0008D923
		// (set) Token: 0x06000F1C RID: 3868 RVA: 0x0008F72D File Offset: 0x0008D92D
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06000F1D RID: 3869 RVA: 0x0008F738 File Offset: 0x0008D938
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				this.GetCompanyDetailsTableAdapter.Connection = sqlConnection;
				this.InvDiscountsGivenTableAdapter.Connection = sqlConnection;
				ReportParameter reportParameter = new ReportParameter("startdatedesc", this.DTStartDate.Value.ToShortDateString());
				ReportParameter reportParameter2 = new ReportParameter("enddatedesc", this.DTEnddate.Value.ToShortDateString());
				ReportParameter reportParameter3 = new ReportParameter("branch", this.cboBranches.Text);
				ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter2, reportParameter3 };
				this.ReportViewer1.LocalReport.SetParameters(array);
				this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
				this.InvDiscountsGivenTableAdapter.Fill(this.POSDataSet.InvDiscountsGiven, this.cboBranches.Text, new int?(MyProject.Forms.Form1.coid), new int?(Convert.ToInt32(this.DTStartDate.Value.ToString("yyyyMMdd"))), new int?(Convert.ToInt32(this.DTEnddate.Value.ToString("yyyyMMdd"))));
				this.ReportViewer1.RefreshReport();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying report. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000F1E RID: 3870 RVA: 0x0008F8D0 File Offset: 0x0008DAD0
		private void DiscountsGiven_Load(object sender, EventArgs e)
		{
			try
			{
				this.cboBranches.DataSource = this.pf.LoadBranches(this._cnn);
				this.cboBranches.DisplayMember = "branch";
				this.cboBranches.ValueMember = "branch";
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000F1F RID: 3871 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label5_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x0400073B RID: 1851
		private PublicFunctions pf;

		// Token: 0x0400073C RID: 1852
		private string _cnn;
	}
}
