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
	// Token: 0x020001FF RID: 511
	[DesignerGenerated]
	public partial class TaxReturns : UserControl
	{
		// Token: 0x06005BD9 RID: 23513 RVA: 0x0034DAE0 File Offset: 0x0034BCE0
		public TaxReturns()
		{
			base.Load += this.TaxReturns_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x1700211F RID: 8479
		// (get) Token: 0x06005BDC RID: 23516 RVA: 0x0034E675 File Offset: 0x0034C875
		// (set) Token: 0x06005BDD RID: 23517 RVA: 0x0034E67F File Offset: 0x0034C87F
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002120 RID: 8480
		// (get) Token: 0x06005BDE RID: 23518 RVA: 0x0034E688 File Offset: 0x0034C888
		// (set) Token: 0x06005BDF RID: 23519 RVA: 0x0034E692 File Offset: 0x0034C892
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002121 RID: 8481
		// (get) Token: 0x06005BE0 RID: 23520 RVA: 0x0034E69B File Offset: 0x0034C89B
		// (set) Token: 0x06005BE1 RID: 23521 RVA: 0x0034E6A5 File Offset: 0x0034C8A5
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002122 RID: 8482
		// (get) Token: 0x06005BE2 RID: 23522 RVA: 0x0034E6AE File Offset: 0x0034C8AE
		// (set) Token: 0x06005BE3 RID: 23523 RVA: 0x0034E6B8 File Offset: 0x0034C8B8
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

		// Token: 0x17002123 RID: 8483
		// (get) Token: 0x06005BE4 RID: 23524 RVA: 0x0034E6FB File Offset: 0x0034C8FB
		// (set) Token: 0x06005BE5 RID: 23525 RVA: 0x0034E705 File Offset: 0x0034C905
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002124 RID: 8484
		// (get) Token: 0x06005BE6 RID: 23526 RVA: 0x0034E70E File Offset: 0x0034C90E
		// (set) Token: 0x06005BE7 RID: 23527 RVA: 0x0034E718 File Offset: 0x0034C918
		internal virtual DateTimePicker DTend
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002125 RID: 8485
		// (get) Token: 0x06005BE8 RID: 23528 RVA: 0x0034E721 File Offset: 0x0034C921
		// (set) Token: 0x06005BE9 RID: 23529 RVA: 0x0034E72B File Offset: 0x0034C92B
		internal virtual DateTimePicker DTstart
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002126 RID: 8486
		// (get) Token: 0x06005BEA RID: 23530 RVA: 0x0034E734 File Offset: 0x0034C934
		// (set) Token: 0x06005BEB RID: 23531 RVA: 0x0034E740 File Offset: 0x0034C940
		internal virtual Label Label4
		{
			[CompilerGenerated]
			get
			{
				return this._Label4;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label4_Click);
				Label label = this._Label4;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label4 = value;
				label = this._Label4;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x17002127 RID: 8487
		// (get) Token: 0x06005BEC RID: 23532 RVA: 0x0034E783 File Offset: 0x0034C983
		// (set) Token: 0x06005BED RID: 23533 RVA: 0x0034E78D File Offset: 0x0034C98D
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002128 RID: 8488
		// (get) Token: 0x06005BEE RID: 23534 RVA: 0x0034E796 File Offset: 0x0034C996
		// (set) Token: 0x06005BEF RID: 23535 RVA: 0x0034E7A0 File Offset: 0x0034C9A0
		internal virtual BindingSource TaxReturnsForPeriodSummary1BindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002129 RID: 8489
		// (get) Token: 0x06005BF0 RID: 23536 RVA: 0x0034E7A9 File Offset: 0x0034C9A9
		// (set) Token: 0x06005BF1 RID: 23537 RVA: 0x0034E7B3 File Offset: 0x0034C9B3
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700212A RID: 8490
		// (get) Token: 0x06005BF2 RID: 23538 RVA: 0x0034E7BC File Offset: 0x0034C9BC
		// (set) Token: 0x06005BF3 RID: 23539 RVA: 0x0034E7C6 File Offset: 0x0034C9C6
		internal virtual BindingSource TaxReturnsForPeriod1BindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700212B RID: 8491
		// (get) Token: 0x06005BF4 RID: 23540 RVA: 0x0034E7CF File Offset: 0x0034C9CF
		// (set) Token: 0x06005BF5 RID: 23541 RVA: 0x0034E7D9 File Offset: 0x0034C9D9
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700212C RID: 8492
		// (get) Token: 0x06005BF6 RID: 23542 RVA: 0x0034E7E2 File Offset: 0x0034C9E2
		// (set) Token: 0x06005BF7 RID: 23543 RVA: 0x0034E7EC File Offset: 0x0034C9EC
		internal virtual TaxReturnsForPeriodSummary1TableAdapter TaxReturnsForPeriodSummary1TableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700212D RID: 8493
		// (get) Token: 0x06005BF8 RID: 23544 RVA: 0x0034E7F5 File Offset: 0x0034C9F5
		// (set) Token: 0x06005BF9 RID: 23545 RVA: 0x0034E7FF File Offset: 0x0034C9FF
		internal virtual TaxReturnsForPeriod1TableAdapter TaxReturnsForPeriod1TableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700212E RID: 8494
		// (get) Token: 0x06005BFA RID: 23546 RVA: 0x0034E808 File Offset: 0x0034CA08
		// (set) Token: 0x06005BFB RID: 23547 RVA: 0x0034E812 File Offset: 0x0034CA12
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700212F RID: 8495
		// (get) Token: 0x06005BFC RID: 23548 RVA: 0x0034E81B File Offset: 0x0034CA1B
		// (set) Token: 0x06005BFD RID: 23549 RVA: 0x0034E825 File Offset: 0x0034CA25
		internal virtual ComboBox cboBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002130 RID: 8496
		// (get) Token: 0x06005BFE RID: 23550 RVA: 0x0034E82E File Offset: 0x0034CA2E
		// (set) Token: 0x06005BFF RID: 23551 RVA: 0x0034E838 File Offset: 0x0034CA38
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002131 RID: 8497
		// (get) Token: 0x06005C00 RID: 23552 RVA: 0x0034E841 File Offset: 0x0034CA41
		// (set) Token: 0x06005C01 RID: 23553 RVA: 0x0034E84B File Offset: 0x0034CA4B
		internal virtual BindingSource VATInputBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002132 RID: 8498
		// (get) Token: 0x06005C02 RID: 23554 RVA: 0x0034E854 File Offset: 0x0034CA54
		// (set) Token: 0x06005C03 RID: 23555 RVA: 0x0034E85E File Offset: 0x0034CA5E
		internal virtual BindingSource VATOutputBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002133 RID: 8499
		// (get) Token: 0x06005C04 RID: 23556 RVA: 0x0034E867 File Offset: 0x0034CA67
		// (set) Token: 0x06005C05 RID: 23557 RVA: 0x0034E871 File Offset: 0x0034CA71
		internal virtual VATInputTableAdapter VATInputTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002134 RID: 8500
		// (get) Token: 0x06005C06 RID: 23558 RVA: 0x0034E87A File Offset: 0x0034CA7A
		// (set) Token: 0x06005C07 RID: 23559 RVA: 0x0034E884 File Offset: 0x0034CA84
		internal virtual VATOutputTableAdapter VATOutputTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06005C08 RID: 23560 RVA: 0x0034E890 File Offset: 0x0034CA90
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.cboBranch.Text, "", false) != 0;
				if (flag)
				{
					SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
					this.GetCompanyDetailsTableAdapter.Connection = sqlConnection;
					this.TaxReturnsForPeriod1TableAdapter.Connection = sqlConnection;
					this.TaxReturnsForPeriodSummary1TableAdapter.Connection = sqlConnection;
					this.VATInputTableAdapter.Connection = sqlConnection;
					this.VATOutputTableAdapter.Connection = sqlConnection;
					ReportParameter reportParameter = new ReportParameter("startdatedesc", this.DTstart.Value.ToShortDateString());
					string text = this.cboBranch.Text;
					ReportParameter reportParameter2 = new ReportParameter("branch", text);
					ReportParameter reportParameter3 = new ReportParameter("enddatedesc", this.DTstart.Value.ToShortDateString());
					ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter2, reportParameter3 };
					this.ReportViewer1.LocalReport.SetParameters(array);
					this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
					this.TaxReturnsForPeriod1TableAdapter.Fill(this.POSDataSet.TaxReturnsForPeriod1, new int?(Convert.ToInt32(this.DTstart.Value.ToString("yyyyMMdd"))), new int?(Convert.ToInt32(this.DTend.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text);
					this.TaxReturnsForPeriodSummary1TableAdapter.Fill(this.POSDataSet.TaxReturnsForPeriodSummary1, new int?(Convert.ToInt32(this.DTstart.Value.ToString("yyyyMMdd"))), new int?(Convert.ToInt32(this.DTend.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text);
					this.VATInputTableAdapter.Fill(this.POSDataSet.VATInput, new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text, new int?(Convert.ToInt32(this.DTstart.Value.ToString("yyyyMMdd"))), new int?(Convert.ToInt32(this.DTend.Value.ToString("yyyyMMdd"))));
					this.VATOutputTableAdapter.Fill(this.POSDataSet.VATOutput, new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text, new int?(Convert.ToInt32(this.DTstart.Value.ToString("yyyyMMdd"))), new int?(Convert.ToInt32(this.DTend.Value.ToString("yyyyMMdd"))));
					this.ReportViewer1.RefreshReport();
				}
				else
				{
					MessageBox.Show("Please select a branch first.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying report. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005C09 RID: 23561 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label4_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06005C0A RID: 23562 RVA: 0x0034EC08 File Offset: 0x0034CE08
		private void TaxReturns_Load(object sender, EventArgs e)
		{
			try
			{
				DataTable branches = this.pf.GetBranches(this._cnn);
				this.cboBranch.DataSource = branches;
				this.cboBranch.DisplayMember = "branch";
				this.cboBranch.ValueMember = "branch";
				bool flag = branches.Rows.Count == 1;
				if (flag)
				{
					this.cboBranch.SelectedIndex = 0;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x04002844 RID: 10308
		private string _cnn;

		// Token: 0x04002845 RID: 10309
		private PublicFunctions pf;
	}
}
