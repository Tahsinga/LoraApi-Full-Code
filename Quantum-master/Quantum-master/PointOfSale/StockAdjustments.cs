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
	// Token: 0x020001E0 RID: 480
	[DesignerGenerated]
	public partial class StockAdjustments : UserControl
	{
		// Token: 0x06005446 RID: 21574 RVA: 0x0030CE88 File Offset: 0x0030B088
		public StockAdjustments()
		{
			base.Load += this.StockAdjustments_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x17001E3A RID: 7738
		// (get) Token: 0x06005449 RID: 21577 RVA: 0x0030D72E File Offset: 0x0030B92E
		// (set) Token: 0x0600544A RID: 21578 RVA: 0x0030D738 File Offset: 0x0030B938
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E3B RID: 7739
		// (get) Token: 0x0600544B RID: 21579 RVA: 0x0030D741 File Offset: 0x0030B941
		// (set) Token: 0x0600544C RID: 21580 RVA: 0x0030D74B File Offset: 0x0030B94B
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E3C RID: 7740
		// (get) Token: 0x0600544D RID: 21581 RVA: 0x0030D754 File Offset: 0x0030B954
		// (set) Token: 0x0600544E RID: 21582 RVA: 0x0030D760 File Offset: 0x0030B960
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

		// Token: 0x17001E3D RID: 7741
		// (get) Token: 0x0600544F RID: 21583 RVA: 0x0030D7A3 File Offset: 0x0030B9A3
		// (set) Token: 0x06005450 RID: 21584 RVA: 0x0030D7AD File Offset: 0x0030B9AD
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E3E RID: 7742
		// (get) Token: 0x06005451 RID: 21585 RVA: 0x0030D7B6 File Offset: 0x0030B9B6
		// (set) Token: 0x06005452 RID: 21586 RVA: 0x0030D7C0 File Offset: 0x0030B9C0
		internal virtual DateTimePicker DTEnddate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E3F RID: 7743
		// (get) Token: 0x06005453 RID: 21587 RVA: 0x0030D7C9 File Offset: 0x0030B9C9
		// (set) Token: 0x06005454 RID: 21588 RVA: 0x0030D7D4 File Offset: 0x0030B9D4
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

		// Token: 0x17001E40 RID: 7744
		// (get) Token: 0x06005455 RID: 21589 RVA: 0x0030D817 File Offset: 0x0030BA17
		// (set) Token: 0x06005456 RID: 21590 RVA: 0x0030D821 File Offset: 0x0030BA21
		internal virtual DateTimePicker DTStartdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E41 RID: 7745
		// (get) Token: 0x06005457 RID: 21591 RVA: 0x0030D82A File Offset: 0x0030BA2A
		// (set) Token: 0x06005458 RID: 21592 RVA: 0x0030D834 File Offset: 0x0030BA34
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E42 RID: 7746
		// (get) Token: 0x06005459 RID: 21593 RVA: 0x0030D83D File Offset: 0x0030BA3D
		// (set) Token: 0x0600545A RID: 21594 RVA: 0x0030D847 File Offset: 0x0030BA47
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E43 RID: 7747
		// (get) Token: 0x0600545B RID: 21595 RVA: 0x0030D850 File Offset: 0x0030BA50
		// (set) Token: 0x0600545C RID: 21596 RVA: 0x0030D85A File Offset: 0x0030BA5A
		internal virtual BindingSource StockAdjustmentsForPeriodBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E44 RID: 7748
		// (get) Token: 0x0600545D RID: 21597 RVA: 0x0030D863 File Offset: 0x0030BA63
		// (set) Token: 0x0600545E RID: 21598 RVA: 0x0030D86D File Offset: 0x0030BA6D
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E45 RID: 7749
		// (get) Token: 0x0600545F RID: 21599 RVA: 0x0030D876 File Offset: 0x0030BA76
		// (set) Token: 0x06005460 RID: 21600 RVA: 0x0030D880 File Offset: 0x0030BA80
		internal virtual StockAdjustmentsForPeriodTableAdapter StockAdjustmentsForPeriodTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E46 RID: 7750
		// (get) Token: 0x06005461 RID: 21601 RVA: 0x0030D889 File Offset: 0x0030BA89
		// (set) Token: 0x06005462 RID: 21602 RVA: 0x0030D893 File Offset: 0x0030BA93
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E47 RID: 7751
		// (get) Token: 0x06005463 RID: 21603 RVA: 0x0030D89C File Offset: 0x0030BA9C
		// (set) Token: 0x06005464 RID: 21604 RVA: 0x0030D8A6 File Offset: 0x0030BAA6
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E48 RID: 7752
		// (get) Token: 0x06005465 RID: 21605 RVA: 0x0030D8AF File Offset: 0x0030BAAF
		// (set) Token: 0x06005466 RID: 21606 RVA: 0x0030D8B9 File Offset: 0x0030BAB9
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E49 RID: 7753
		// (get) Token: 0x06005467 RID: 21607 RVA: 0x0030D8C2 File Offset: 0x0030BAC2
		// (set) Token: 0x06005468 RID: 21608 RVA: 0x0030D8CC File Offset: 0x0030BACC
		internal virtual ComboBox cboBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06005469 RID: 21609 RVA: 0x0030D8D8 File Offset: 0x0030BAD8
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

		// Token: 0x0600546A RID: 21610 RVA: 0x0030D99C File Offset: 0x0030BB9C
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
				this.GetCompanyDetailsTableAdapter.Connection = sqlConnection;
				this.StockAdjustmentsForPeriodTableAdapter.Connection = sqlConnection;
				ReportParameter reportParameter = new ReportParameter("startdate", Conversions.ToString(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))));
				ReportParameter reportParameter2 = new ReportParameter("StartDateDesc", this.DTStartdate.Value.ToShortDateString());
				ReportParameter reportParameter3 = new ReportParameter("enddate", Conversions.ToString(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))));
				ReportParameter reportParameter4 = new ReportParameter("EndDateDesc", this.DTEnddate.Value.ToShortDateString());
				ReportParameter reportParameter5 = new ReportParameter("coid", Conversions.ToString(MyProject.Forms.Form1.coid));
				ReportParameter reportParameter6 = new ReportParameter("branch", this.cboBranch.Text);
				ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter2, reportParameter3, reportParameter4, reportParameter5, reportParameter6 };
				this.ReportViewer1.LocalReport.SetParameters(array);
				this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
				this.StockAdjustmentsForPeriodTableAdapter.Fill(this.POSDataSet.StockAdjustmentsForPeriod, new int?(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text);
				this.ReportViewer1.RefreshReport();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying report. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600546B RID: 21611 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label3_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x0600546C RID: 21612 RVA: 0x0030DBC8 File Offset: 0x0030BDC8
		private void StockAdjustments_Load(object sender, EventArgs e)
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

		// Token: 0x040024D7 RID: 9431
		private string _cnn;
	}
}
