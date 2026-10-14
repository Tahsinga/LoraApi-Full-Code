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
	// Token: 0x0200015F RID: 351
	[DesignerGenerated]
	public partial class PriceChangesReport2 : Form
	{
		// Token: 0x06002EB1 RID: 11953 RVA: 0x0019642C File Offset: 0x0019462C
		public PriceChangesReport2()
		{
			base.Load += this.PriceChangesReport2_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x17001159 RID: 4441
		// (get) Token: 0x06002EB4 RID: 11956 RVA: 0x00196BB3 File Offset: 0x00194DB3
		// (set) Token: 0x06002EB5 RID: 11957 RVA: 0x00196BBD File Offset: 0x00194DBD
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700115A RID: 4442
		// (get) Token: 0x06002EB6 RID: 11958 RVA: 0x00196BC6 File Offset: 0x00194DC6
		// (set) Token: 0x06002EB7 RID: 11959 RVA: 0x00196BD0 File Offset: 0x00194DD0
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700115B RID: 4443
		// (get) Token: 0x06002EB8 RID: 11960 RVA: 0x00196BD9 File Offset: 0x00194DD9
		// (set) Token: 0x06002EB9 RID: 11961 RVA: 0x00196BE3 File Offset: 0x00194DE3
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700115C RID: 4444
		// (get) Token: 0x06002EBA RID: 11962 RVA: 0x00196BEC File Offset: 0x00194DEC
		// (set) Token: 0x06002EBB RID: 11963 RVA: 0x00196BF6 File Offset: 0x00194DF6
		internal virtual DateTimePicker DTEnddate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700115D RID: 4445
		// (get) Token: 0x06002EBC RID: 11964 RVA: 0x00196BFF File Offset: 0x00194DFF
		// (set) Token: 0x06002EBD RID: 11965 RVA: 0x00196C0C File Offset: 0x00194E0C
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

		// Token: 0x1700115E RID: 4446
		// (get) Token: 0x06002EBE RID: 11966 RVA: 0x00196C4F File Offset: 0x00194E4F
		// (set) Token: 0x06002EBF RID: 11967 RVA: 0x00196C59 File Offset: 0x00194E59
		internal virtual DateTimePicker DTStartdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700115F RID: 4447
		// (get) Token: 0x06002EC0 RID: 11968 RVA: 0x00196C62 File Offset: 0x00194E62
		// (set) Token: 0x06002EC1 RID: 11969 RVA: 0x00196C6C File Offset: 0x00194E6C
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001160 RID: 4448
		// (get) Token: 0x06002EC2 RID: 11970 RVA: 0x00196C75 File Offset: 0x00194E75
		// (set) Token: 0x06002EC3 RID: 11971 RVA: 0x00196C7F File Offset: 0x00194E7F
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001161 RID: 4449
		// (get) Token: 0x06002EC4 RID: 11972 RVA: 0x00196C88 File Offset: 0x00194E88
		// (set) Token: 0x06002EC5 RID: 11973 RVA: 0x00196C92 File Offset: 0x00194E92
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001162 RID: 4450
		// (get) Token: 0x06002EC6 RID: 11974 RVA: 0x00196C9B File Offset: 0x00194E9B
		// (set) Token: 0x06002EC7 RID: 11975 RVA: 0x00196CA5 File Offset: 0x00194EA5
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001163 RID: 4451
		// (get) Token: 0x06002EC8 RID: 11976 RVA: 0x00196CAE File Offset: 0x00194EAE
		// (set) Token: 0x06002EC9 RID: 11977 RVA: 0x00196CB8 File Offset: 0x00194EB8
		internal virtual BindingSource PCSelectPriceChanges1BindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001164 RID: 4452
		// (get) Token: 0x06002ECA RID: 11978 RVA: 0x00196CC1 File Offset: 0x00194EC1
		// (set) Token: 0x06002ECB RID: 11979 RVA: 0x00196CCB File Offset: 0x00194ECB
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001165 RID: 4453
		// (get) Token: 0x06002ECC RID: 11980 RVA: 0x00196CD4 File Offset: 0x00194ED4
		// (set) Token: 0x06002ECD RID: 11981 RVA: 0x00196CDE File Offset: 0x00194EDE
		internal virtual PCSelectPriceChanges1TableAdapter PCSelectPriceChanges1TableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001166 RID: 4454
		// (get) Token: 0x06002ECE RID: 11982 RVA: 0x00196CE7 File Offset: 0x00194EE7
		// (set) Token: 0x06002ECF RID: 11983 RVA: 0x00196CF1 File Offset: 0x00194EF1
		internal virtual BindingSource GetProductDiscountsFromMvtBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001167 RID: 4455
		// (get) Token: 0x06002ED0 RID: 11984 RVA: 0x00196CFA File Offset: 0x00194EFA
		// (set) Token: 0x06002ED1 RID: 11985 RVA: 0x00196D04 File Offset: 0x00194F04
		internal virtual GetProductDiscountsFromMvtTableAdapter GetProductDiscountsFromMvtTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06002ED2 RID: 11986 RVA: 0x00196D10 File Offset: 0x00194F10
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.displaychanges();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying report.");
			}
		}

		// Token: 0x06002ED3 RID: 11987 RVA: 0x00196D54 File Offset: 0x00194F54
		private void displaychanges()
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
				this.GetCompanyDetailsTableAdapter.Connection = sqlConnection;
				this.PCSelectPriceChanges1TableAdapter.Connection = sqlConnection;
				this.GetProductDiscountsFromMvtTableAdapter.Connection = sqlConnection;
				ReportParameter reportParameter = new ReportParameter("startdatedesc", this.DTStartdate.Value.ToShortDateString());
				ReportParameter reportParameter2 = new ReportParameter("enddatedesc", this.DTEnddate.Value.ToShortDateString());
				ReportParameter reportParameter3 = new ReportParameter("branch", MyProject.Forms.Form1.branch);
				ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter2, reportParameter3 };
				this.ReportViewer1.LocalReport.SetParameters(array);
				this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
				this.PCSelectPriceChanges1TableAdapter.Fill(this.POSDataSet.PCSelectPriceChanges1, new int?(Convert.ToInt32(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Convert.ToInt32(this.DTEnddate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid), MyProject.Forms.Form1.branch);
				this.GetProductDiscountsFromMvtTableAdapter.Fill(this.POSDataSet.GetProductDiscountsFromMvt, new int?(Convert.ToInt32(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Convert.ToInt32(this.DTEnddate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid), MyProject.Forms.Form1.branch);
				this.ReportViewer1.RefreshReport();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying report. Detail: " + ex.Message);
			}
		}

		// Token: 0x06002ED4 RID: 11988 RVA: 0x00002A30 File Offset: 0x00000C30
		private void PriceChangesReport2_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x04001413 RID: 5139
		private string _cnn;
	}
}
