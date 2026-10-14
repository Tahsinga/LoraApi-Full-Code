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
	// Token: 0x0200000C RID: 12
	[DesignerGenerated]
	public partial class ADF_Sales_Purchases2 : UserControl
	{
		// Token: 0x06000238 RID: 568 RVA: 0x000142FC File Offset: 0x000124FC
		public ADF_Sales_Purchases2()
		{
			base.Load += this.ADF_Sales_Purchases_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x0600023B RID: 571 RVA: 0x00014C8D File Offset: 0x00012E8D
		// (set) Token: 0x0600023C RID: 572 RVA: 0x00014C97 File Offset: 0x00012E97
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x0600023D RID: 573 RVA: 0x00014CA0 File Offset: 0x00012EA0
		// (set) Token: 0x0600023E RID: 574 RVA: 0x00014CAA File Offset: 0x00012EAA
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x0600023F RID: 575 RVA: 0x00014CB3 File Offset: 0x00012EB3
		// (set) Token: 0x06000240 RID: 576 RVA: 0x00014CBD File Offset: 0x00012EBD
		internal virtual BindingSource ADF_Purchases_StockValueBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000241 RID: 577 RVA: 0x00014CC6 File Offset: 0x00012EC6
		// (set) Token: 0x06000242 RID: 578 RVA: 0x00014CD0 File Offset: 0x00012ED0
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000243 RID: 579 RVA: 0x00014CD9 File Offset: 0x00012ED9
		// (set) Token: 0x06000244 RID: 580 RVA: 0x00014CE3 File Offset: 0x00012EE3
		internal virtual ADF_Purchases_StockValueTableAdapter ADF_Purchases_StockValueTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000245 RID: 581 RVA: 0x00014CEC File Offset: 0x00012EEC
		// (set) Token: 0x06000246 RID: 582 RVA: 0x00014CF6 File Offset: 0x00012EF6
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000247 RID: 583 RVA: 0x00014CFF File Offset: 0x00012EFF
		// (set) Token: 0x06000248 RID: 584 RVA: 0x00014D09 File Offset: 0x00012F09
		internal virtual DateTimePicker DTEndDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000249 RID: 585 RVA: 0x00014D12 File Offset: 0x00012F12
		// (set) Token: 0x0600024A RID: 586 RVA: 0x00014D1C File Offset: 0x00012F1C
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x0600024B RID: 587 RVA: 0x00014D25 File Offset: 0x00012F25
		// (set) Token: 0x0600024C RID: 588 RVA: 0x00014D2F File Offset: 0x00012F2F
		internal virtual DateTimePicker DTStartdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x0600024D RID: 589 RVA: 0x00014D38 File Offset: 0x00012F38
		// (set) Token: 0x0600024E RID: 590 RVA: 0x00014D42 File Offset: 0x00012F42
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x0600024F RID: 591 RVA: 0x00014D4B File Offset: 0x00012F4B
		// (set) Token: 0x06000250 RID: 592 RVA: 0x00014D55 File Offset: 0x00012F55
		internal virtual ComboBox cboBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000251 RID: 593 RVA: 0x00014D5E File Offset: 0x00012F5E
		// (set) Token: 0x06000252 RID: 594 RVA: 0x00014D68 File Offset: 0x00012F68
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000253 RID: 595 RVA: 0x00014D71 File Offset: 0x00012F71
		// (set) Token: 0x06000254 RID: 596 RVA: 0x00014D7C File Offset: 0x00012F7C
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

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000255 RID: 597 RVA: 0x00014DBF File Offset: 0x00012FBF
		// (set) Token: 0x06000256 RID: 598 RVA: 0x00014DC9 File Offset: 0x00012FC9
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000257 RID: 599 RVA: 0x00014DD2 File Offset: 0x00012FD2
		// (set) Token: 0x06000258 RID: 600 RVA: 0x00014DDC File Offset: 0x00012FDC
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000259 RID: 601 RVA: 0x00014DE5 File Offset: 0x00012FE5
		// (set) Token: 0x0600025A RID: 602 RVA: 0x00014DF0 File Offset: 0x00012FF0
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

		// Token: 0x0600025B RID: 603 RVA: 0x00014E34 File Offset: 0x00013034
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
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00014ED4 File Offset: 0x000130D4
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
				this.GetCompanyDetailsTableAdapter.Connection = sqlConnection;
				this.ADF_Purchases_StockValueTableAdapter.Connection = sqlConnection;
				ReportParameter reportParameter = new ReportParameter("startdatedesc", this.DTStartdate.Value.ToShortDateString());
				ReportParameter reportParameter2 = new ReportParameter("enddatedesc", this.DTEndDate.Value.ToShortDateString());
				ReportParameter reportParameter3 = new ReportParameter("coid", Conversions.ToString(MyProject.Forms.Form1.coid));
				ReportParameter reportParameter4 = new ReportParameter("startdate", Conversions.ToString(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))));
				ReportParameter reportParameter5 = new ReportParameter("enddate", Conversions.ToString(Conversions.ToInteger(this.DTEndDate.Value.ToString("yyyyMMdd"))));
				ReportParameter reportParameter6 = new ReportParameter("branch", this.cboBranch.Text);
				ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter3, reportParameter2, reportParameter5, reportParameter4, reportParameter6 };
				this.ReportViewer1.LocalReport.SetParameters(array);
				this.ADF_Purchases_StockValueTableAdapter.Fill(this.POSDataSet.ADF_Purchases_StockValue, new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text, new int?(Convert.ToInt32(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Convert.ToInt32(this.DTEndDate.Value.ToString("yyyyMMdd"))));
				this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
				this.ReportViewer1.RefreshReport();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying report. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00015100 File Offset: 0x00013300
		private void ADF_Sales_Purchases_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadBranches();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying report. Details: " + ex.Message);
			}
		}

		// Token: 0x0600025E RID: 606 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label4_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x04000106 RID: 262
		private string _cnn;
	}
}
