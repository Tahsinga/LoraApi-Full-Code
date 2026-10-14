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
	// Token: 0x02000047 RID: 71
	[DesignerGenerated]
	public partial class EcocashReceipts : Form
	{
		// Token: 0x06000F53 RID: 3923 RVA: 0x00090DC0 File Offset: 0x0008EFC0
		public EcocashReceipts()
		{
			base.Load += this.EcocashReceipts_Load;
			this.InitializeComponent();
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06000F56 RID: 3926 RVA: 0x0009148A File Offset: 0x0008F68A
		// (set) Token: 0x06000F57 RID: 3927 RVA: 0x00091494 File Offset: 0x0008F694
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06000F58 RID: 3928 RVA: 0x0009149D File Offset: 0x0008F69D
		// (set) Token: 0x06000F59 RID: 3929 RVA: 0x000914A7 File Offset: 0x0008F6A7
		internal virtual DateTimePicker DTEnddate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06000F5A RID: 3930 RVA: 0x000914B0 File Offset: 0x0008F6B0
		// (set) Token: 0x06000F5B RID: 3931 RVA: 0x000914BA File Offset: 0x0008F6BA
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06000F5C RID: 3932 RVA: 0x000914C3 File Offset: 0x0008F6C3
		// (set) Token: 0x06000F5D RID: 3933 RVA: 0x000914CD File Offset: 0x0008F6CD
		internal virtual DateTimePicker DTStartdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06000F5E RID: 3934 RVA: 0x000914D6 File Offset: 0x0008F6D6
		// (set) Token: 0x06000F5F RID: 3935 RVA: 0x000914E0 File Offset: 0x0008F6E0
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06000F60 RID: 3936 RVA: 0x000914E9 File Offset: 0x0008F6E9
		// (set) Token: 0x06000F61 RID: 3937 RVA: 0x000914F4 File Offset: 0x0008F6F4
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

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06000F62 RID: 3938 RVA: 0x00091537 File Offset: 0x0008F737
		// (set) Token: 0x06000F63 RID: 3939 RVA: 0x00091541 File Offset: 0x0008F741
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06000F64 RID: 3940 RVA: 0x0009154A File Offset: 0x0008F74A
		// (set) Token: 0x06000F65 RID: 3941 RVA: 0x00091554 File Offset: 0x0008F754
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06000F66 RID: 3942 RVA: 0x0009155D File Offset: 0x0008F75D
		// (set) Token: 0x06000F67 RID: 3943 RVA: 0x00091567 File Offset: 0x0008F767
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06000F68 RID: 3944 RVA: 0x00091570 File Offset: 0x0008F770
		// (set) Token: 0x06000F69 RID: 3945 RVA: 0x0009157A File Offset: 0x0008F77A
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06000F6A RID: 3946 RVA: 0x00091583 File Offset: 0x0008F783
		// (set) Token: 0x06000F6B RID: 3947 RVA: 0x0009158D File Offset: 0x0008F78D
		internal virtual BindingSource GetEcocashDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06000F6C RID: 3948 RVA: 0x00091596 File Offset: 0x0008F796
		// (set) Token: 0x06000F6D RID: 3949 RVA: 0x000915A0 File Offset: 0x0008F7A0
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06000F6E RID: 3950 RVA: 0x000915A9 File Offset: 0x0008F7A9
		// (set) Token: 0x06000F6F RID: 3951 RVA: 0x000915B3 File Offset: 0x0008F7B3
		internal virtual GetEcocashDetailsTableAdapter GetEcocashDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06000F70 RID: 3952 RVA: 0x000915BC File Offset: 0x0008F7BC
		private void EcocashReceipts_Load(object sender, EventArgs e)
		{
			try
			{
				base.WindowState = FormWindowState.Maximized;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error opening form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000F71 RID: 3953 RVA: 0x0009160C File Offset: 0x0008F80C
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.RunReport();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying report. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000F72 RID: 3954 RVA: 0x0009165C File Offset: 0x0008F85C
		private void RunReport()
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
				this.GetCompanyDetailsTableAdapter.Connection = sqlConnection;
				this.GetEcocashDetailsTableAdapter.Connection = sqlConnection;
				ReportParameter reportParameter = new ReportParameter("TranDate", Conversions.ToString(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))));
				ReportParameter reportParameter2 = new ReportParameter("TranDateEnd", Conversions.ToString(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))));
				ReportParameter reportParameter3 = new ReportParameter("TranDateDesc", this.DTStartdate.Value.ToShortDateString());
				ReportParameter reportParameter4 = new ReportParameter("TranDateDescEnd", this.DTEnddate.Value.ToShortDateString());
				ReportParameter reportParameter5 = new ReportParameter("coid", Conversions.ToString(MyProject.Forms.Form1.coid));
				ReportParameter reportParameter6 = new ReportParameter("branch", MyProject.Forms.Form1.branch);
				ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter2, reportParameter3, reportParameter4, reportParameter5, reportParameter6 };
				this.ReportViewer1.LocalReport.SetParameters(array);
				this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
				this.GetEcocashDetailsTableAdapter.Fill(this.POSDataSet.GetEcocashDetails, new int?(MyProject.Forms.Form1.coid), MyProject.Forms.Form1.branch, new int?(Convert.ToInt32(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Convert.ToInt32(this.DTEnddate.Value.ToString("yyyyMMdd"))));
				this.ReportViewer1.RefreshReport();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying report. Detail: " + ex.Message);
			}
		}
	}
}
