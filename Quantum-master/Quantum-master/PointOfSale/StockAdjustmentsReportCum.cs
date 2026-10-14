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
	// Token: 0x020001E1 RID: 481
	[DesignerGenerated]
	public partial class StockAdjustmentsReportCum : Form
	{
		// Token: 0x0600546D RID: 21613 RVA: 0x0030DC18 File Offset: 0x0030BE18
		public StockAdjustmentsReportCum()
		{
			base.Load += this.StockAdjustmentsReportCum_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x17001E4A RID: 7754
		// (get) Token: 0x06005470 RID: 21616 RVA: 0x0030E660 File Offset: 0x0030C860
		// (set) Token: 0x06005471 RID: 21617 RVA: 0x0030E66A File Offset: 0x0030C86A
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E4B RID: 7755
		// (get) Token: 0x06005472 RID: 21618 RVA: 0x0030E673 File Offset: 0x0030C873
		// (set) Token: 0x06005473 RID: 21619 RVA: 0x0030E67D File Offset: 0x0030C87D
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E4C RID: 7756
		// (get) Token: 0x06005474 RID: 21620 RVA: 0x0030E686 File Offset: 0x0030C886
		// (set) Token: 0x06005475 RID: 21621 RVA: 0x0030E690 File Offset: 0x0030C890
		internal virtual ComboBox cboBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E4D RID: 7757
		// (get) Token: 0x06005476 RID: 21622 RVA: 0x0030E699 File Offset: 0x0030C899
		// (set) Token: 0x06005477 RID: 21623 RVA: 0x0030E6A3 File Offset: 0x0030C8A3
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E4E RID: 7758
		// (get) Token: 0x06005478 RID: 21624 RVA: 0x0030E6AC File Offset: 0x0030C8AC
		// (set) Token: 0x06005479 RID: 21625 RVA: 0x0030E6B8 File Offset: 0x0030C8B8
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

		// Token: 0x17001E4F RID: 7759
		// (get) Token: 0x0600547A RID: 21626 RVA: 0x0030E6FB File Offset: 0x0030C8FB
		// (set) Token: 0x0600547B RID: 21627 RVA: 0x0030E705 File Offset: 0x0030C905
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E50 RID: 7760
		// (get) Token: 0x0600547C RID: 21628 RVA: 0x0030E70E File Offset: 0x0030C90E
		// (set) Token: 0x0600547D RID: 21629 RVA: 0x0030E718 File Offset: 0x0030C918
		internal virtual DateTimePicker DTEnddate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E51 RID: 7761
		// (get) Token: 0x0600547E RID: 21630 RVA: 0x0030E721 File Offset: 0x0030C921
		// (set) Token: 0x0600547F RID: 21631 RVA: 0x0030E72C File Offset: 0x0030C92C
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

		// Token: 0x17001E52 RID: 7762
		// (get) Token: 0x06005480 RID: 21632 RVA: 0x0030E76F File Offset: 0x0030C96F
		// (set) Token: 0x06005481 RID: 21633 RVA: 0x0030E779 File Offset: 0x0030C979
		internal virtual DateTimePicker DTStartdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E53 RID: 7763
		// (get) Token: 0x06005482 RID: 21634 RVA: 0x0030E782 File Offset: 0x0030C982
		// (set) Token: 0x06005483 RID: 21635 RVA: 0x0030E78C File Offset: 0x0030C98C
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E54 RID: 7764
		// (get) Token: 0x06005484 RID: 21636 RVA: 0x0030E795 File Offset: 0x0030C995
		// (set) Token: 0x06005485 RID: 21637 RVA: 0x0030E79F File Offset: 0x0030C99F
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E55 RID: 7765
		// (get) Token: 0x06005486 RID: 21638 RVA: 0x0030E7A8 File Offset: 0x0030C9A8
		// (set) Token: 0x06005487 RID: 21639 RVA: 0x0030E7B2 File Offset: 0x0030C9B2
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E56 RID: 7766
		// (get) Token: 0x06005488 RID: 21640 RVA: 0x0030E7BB File Offset: 0x0030C9BB
		// (set) Token: 0x06005489 RID: 21641 RVA: 0x0030E7C5 File Offset: 0x0030C9C5
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E57 RID: 7767
		// (get) Token: 0x0600548A RID: 21642 RVA: 0x0030E7CE File Offset: 0x0030C9CE
		// (set) Token: 0x0600548B RID: 21643 RVA: 0x0030E7D8 File Offset: 0x0030C9D8
		internal virtual BindingSource StockAdjustmentsForPeriodCumulativeBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E58 RID: 7768
		// (get) Token: 0x0600548C RID: 21644 RVA: 0x0030E7E1 File Offset: 0x0030C9E1
		// (set) Token: 0x0600548D RID: 21645 RVA: 0x0030E7EB File Offset: 0x0030C9EB
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E59 RID: 7769
		// (get) Token: 0x0600548E RID: 21646 RVA: 0x0030E7F4 File Offset: 0x0030C9F4
		// (set) Token: 0x0600548F RID: 21647 RVA: 0x0030E7FE File Offset: 0x0030C9FE
		internal virtual StockAdjustmentsForPeriodCumulativeTableAdapter StockAdjustmentsForPeriodCumulativeTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E5A RID: 7770
		// (get) Token: 0x06005490 RID: 21648 RVA: 0x0030E807 File Offset: 0x0030CA07
		// (set) Token: 0x06005491 RID: 21649 RVA: 0x0030E811 File Offset: 0x0030CA11
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E5B RID: 7771
		// (get) Token: 0x06005492 RID: 21650 RVA: 0x0030E81A File Offset: 0x0030CA1A
		// (set) Token: 0x06005493 RID: 21651 RVA: 0x0030E824 File Offset: 0x0030CA24
		internal virtual ComboBox cboRefs
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001E5C RID: 7772
		// (get) Token: 0x06005494 RID: 21652 RVA: 0x0030E82D File Offset: 0x0030CA2D
		// (set) Token: 0x06005495 RID: 21653 RVA: 0x0030E838 File Offset: 0x0030CA38
		internal virtual Button Button2
		{
			[CompilerGenerated]
			get
			{
				return this._Button2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button2_Click);
				Button button = this._Button2;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button2 = value;
				button = this._Button2;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x06005496 RID: 21654 RVA: 0x0030E87C File Offset: 0x0030CA7C
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

		// Token: 0x06005497 RID: 21655 RVA: 0x0030E940 File Offset: 0x0030CB40
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.cboRefs.Text, "", false) != 0;
				if (flag)
				{
					SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
					this.GetCompanyDetailsTableAdapter.Connection = sqlConnection;
					this.StockAdjustmentsForPeriodCumulativeTableAdapter.Connection = sqlConnection;
					ReportParameter reportParameter = new ReportParameter("startdate", Conversions.ToString(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))));
					ReportParameter reportParameter2 = new ReportParameter("StartDateDesc", this.DTStartdate.Value.ToShortDateString());
					ReportParameter reportParameter3 = new ReportParameter("enddate", Conversions.ToString(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))));
					ReportParameter reportParameter4 = new ReportParameter("EndDateDesc", this.DTEnddate.Value.ToShortDateString());
					ReportParameter reportParameter5 = new ReportParameter("coid", Conversions.ToString(MyProject.Forms.Form1.coid));
					ReportParameter reportParameter6 = new ReportParameter("branch", this.cboBranch.Text);
					ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter2, reportParameter3, reportParameter4, reportParameter5, reportParameter6 };
					this.ReportViewer1.LocalReport.SetParameters(array);
					this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
					this.StockAdjustmentsForPeriodCumulativeTableAdapter.Fill(this.POSDataSet.StockAdjustmentsForPeriodCumulative, new int?(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text, this.cboRefs.Text);
					this.ReportViewer1.RefreshReport();
				}
				else
				{
					MessageBox.Show("Please load and select the reference first.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying report. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005498 RID: 21656 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label3_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06005499 RID: 21657 RVA: 0x0030EBA8 File Offset: 0x0030CDA8
		private void StockAdjustmentsReportCum_Load(object sender, EventArgs e)
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

		// Token: 0x0600549A RID: 21658 RVA: 0x0030EBF8 File Offset: 0x0030CDF8
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.Text;
				sqlCommand.CommandText = "select distinct trandescription from movement where trancode=2 and trandate>=" + Conversion.Val(this.DTStartdate.Value.ToString("yyyyMMdd")).ToString() + " and  trandate<=" + Conversion.Val(this.DTEnddate.Value.ToString("yyyyMMdd")).ToString();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				DataTable dataTable = new DataTable();
				sqlDataAdapter.Fill(dataTable);
				this.cboRefs.DataSource = dataTable;
				this.cboRefs.ValueMember = "trandescription";
				this.cboRefs.DisplayMember = "trandescription";
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error showing refs. Details: " + ex.Message);
			}
		}

		// Token: 0x040024EC RID: 9452
		private string _cnn;
	}
}
