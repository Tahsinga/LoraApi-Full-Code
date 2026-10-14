using System;
using System.Collections;
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
	// Token: 0x0200017D RID: 381
	[DesignerGenerated]
	public partial class Quotation : Form
	{
		// Token: 0x0600380B RID: 14347 RVA: 0x001E8D00 File Offset: 0x001E6F00
		public Quotation()
		{
			base.Load += this.Quotation_Load;
			this.quotationHeader = "QUOTATION";
			this.pf = new PublicFunctions();
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x170014A1 RID: 5281
		// (get) Token: 0x0600380E RID: 14350 RVA: 0x001E93DF File Offset: 0x001E75DF
		// (set) Token: 0x0600380F RID: 14351 RVA: 0x001E93E9 File Offset: 0x001E75E9
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014A2 RID: 5282
		// (get) Token: 0x06003810 RID: 14352 RVA: 0x001E93F2 File Offset: 0x001E75F2
		// (set) Token: 0x06003811 RID: 14353 RVA: 0x001E93FC File Offset: 0x001E75FC
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014A3 RID: 5283
		// (get) Token: 0x06003812 RID: 14354 RVA: 0x001E9405 File Offset: 0x001E7605
		// (set) Token: 0x06003813 RID: 14355 RVA: 0x001E940F File Offset: 0x001E760F
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014A4 RID: 5284
		// (get) Token: 0x06003814 RID: 14356 RVA: 0x001E9418 File Offset: 0x001E7618
		// (set) Token: 0x06003815 RID: 14357 RVA: 0x001E9422 File Offset: 0x001E7622
		internal virtual BindingSource FetchCustomerDetailsFromQuotationBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014A5 RID: 5285
		// (get) Token: 0x06003816 RID: 14358 RVA: 0x001E942B File Offset: 0x001E762B
		// (set) Token: 0x06003817 RID: 14359 RVA: 0x001E9435 File Offset: 0x001E7635
		internal virtual BindingSource GetQuotationDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014A6 RID: 5286
		// (get) Token: 0x06003818 RID: 14360 RVA: 0x001E943E File Offset: 0x001E763E
		// (set) Token: 0x06003819 RID: 14361 RVA: 0x001E9448 File Offset: 0x001E7648
		internal virtual BindingSource GetUserForQuotationBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014A7 RID: 5287
		// (get) Token: 0x0600381A RID: 14362 RVA: 0x001E9451 File Offset: 0x001E7651
		// (set) Token: 0x0600381B RID: 14363 RVA: 0x001E945B File Offset: 0x001E765B
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014A8 RID: 5288
		// (get) Token: 0x0600381C RID: 14364 RVA: 0x001E9464 File Offset: 0x001E7664
		// (set) Token: 0x0600381D RID: 14365 RVA: 0x001E946E File Offset: 0x001E766E
		internal virtual FetchCustomerDetailsFromQuotationTableAdapter FetchCustomerDetailsFromQuotationTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014A9 RID: 5289
		// (get) Token: 0x0600381E RID: 14366 RVA: 0x001E9477 File Offset: 0x001E7677
		// (set) Token: 0x0600381F RID: 14367 RVA: 0x001E9481 File Offset: 0x001E7681
		internal virtual GetQuotationDetailsTableAdapter GetQuotationDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014AA RID: 5290
		// (get) Token: 0x06003820 RID: 14368 RVA: 0x001E948A File Offset: 0x001E768A
		// (set) Token: 0x06003821 RID: 14369 RVA: 0x001E9494 File Offset: 0x001E7694
		internal virtual GetUserForQuotationTableAdapter GetUserForQuotationTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014AB RID: 5291
		// (get) Token: 0x06003822 RID: 14370 RVA: 0x001E949D File Offset: 0x001E769D
		// (set) Token: 0x06003823 RID: 14371 RVA: 0x001E94A7 File Offset: 0x001E76A7
		internal virtual BindingSource GetBranchDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014AC RID: 5292
		// (get) Token: 0x06003824 RID: 14372 RVA: 0x001E94B0 File Offset: 0x001E76B0
		// (set) Token: 0x06003825 RID: 14373 RVA: 0x001E94BA File Offset: 0x001E76BA
		internal virtual GetBranchDetailsTableAdapter GetBranchDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014AD RID: 5293
		// (get) Token: 0x06003826 RID: 14374 RVA: 0x001E94C3 File Offset: 0x001E76C3
		// (set) Token: 0x06003827 RID: 14375 RVA: 0x001E94CD File Offset: 0x001E76CD
		internal virtual BindingSource GetBankingDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014AE RID: 5294
		// (get) Token: 0x06003828 RID: 14376 RVA: 0x001E94D6 File Offset: 0x001E76D6
		// (set) Token: 0x06003829 RID: 14377 RVA: 0x001E94E0 File Offset: 0x001E76E0
		internal virtual GetBankingDetailsTableAdapter GetBankingDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014AF RID: 5295
		// (get) Token: 0x0600382A RID: 14378 RVA: 0x001E94E9 File Offset: 0x001E76E9
		// (set) Token: 0x0600382B RID: 14379 RVA: 0x001E94F3 File Offset: 0x001E76F3
		internal virtual BindingSource BankingDetails2BindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014B0 RID: 5296
		// (get) Token: 0x0600382C RID: 14380 RVA: 0x001E94FC File Offset: 0x001E76FC
		// (set) Token: 0x0600382D RID: 14381 RVA: 0x001E9506 File Offset: 0x001E7706
		internal virtual BankingDetails2TableAdapter BankingDetails2TableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014B1 RID: 5297
		// (get) Token: 0x0600382E RID: 14382 RVA: 0x001E950F File Offset: 0x001E770F
		// (set) Token: 0x0600382F RID: 14383 RVA: 0x001E9519 File Offset: 0x001E7719
		internal virtual BindingSource GetQuotationHeaderBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170014B2 RID: 5298
		// (get) Token: 0x06003830 RID: 14384 RVA: 0x001E9522 File Offset: 0x001E7722
		// (set) Token: 0x06003831 RID: 14385 RVA: 0x001E952C File Offset: 0x001E772C
		internal virtual GetQuotationHeaderTableAdapter GetQuotationHeaderTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06003832 RID: 14386 RVA: 0x001E9538 File Offset: 0x001E7738
		private void Quotation_Load(object sender, EventArgs e)
		{
			SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
			this.GetCompanyDetailsTableAdapter.Connection = sqlConnection;
			this.FetchCustomerDetailsFromQuotationTableAdapter.Connection = sqlConnection;
			this.GetQuotationDetailsTableAdapter.Connection = sqlConnection;
			this.GetUserForQuotationTableAdapter.Connection = sqlConnection;
			this.GetBranchDetailsTableAdapter.Connection = sqlConnection;
			this.GetBankingDetailsTableAdapter.Connection = sqlConnection;
			this.BankingDetails2TableAdapter.Connection = sqlConnection;
			this.GetQuotationHeaderTableAdapter.Connection = sqlConnection;
			string text = " ";
			DataTable branches = this.pf.GetBranches(this._cnn);
			bool flag = branches.Rows.Count > 0;
			if (flag)
			{
				text = "Branch Network" + Environment.NewLine + Environment.NewLine;
				try
				{
					foreach (object obj in branches.Rows)
					{
						DataRow dataRow = (DataRow)obj;
						text = string.Concat(new string[]
						{
							text,
							dataRow["Branch"].ToString(),
							" ",
							dataRow["Tel"].ToString(),
							Environment.NewLine,
							dataRow["Address"].ToString(),
							", ",
							dataRow["Address2"].ToString(),
							Environment.NewLine,
							Environment.NewLine
						});
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
			ReportParameter reportParameter = new ReportParameter("QuotationHeader", this.quotationHeader);
			ReportParameter reportParameter2 = new ReportParameter("BranchNetwork", text);
			ReportParameter[] array = new ReportParameter[] { reportParameter2, reportParameter };
			this.ReportViewer1.LocalReport.SetParameters(array);
			this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
			this.FetchCustomerDetailsFromQuotationTableAdapter.Fill(this.POSDataSet.FetchCustomerDetailsFromQuotation, new int?(this.quotationnumber), new int?(MyProject.Forms.Form1.coid), MyProject.Forms.Form1.branch);
			this.GetQuotationDetailsTableAdapter.Fill(this.POSDataSet.GetQuotationDetails, new int?(this.quotationnumber), new int?(MyProject.Forms.Form1.coid));
			this.GetUserForQuotationTableAdapter.Fill(this.POSDataSet.GetUserForQuotation, new int?(this.quotationnumber), new int?(MyProject.Forms.Form1.coid));
			this.GetBranchDetailsTableAdapter.Fill(this.POSDataSet.GetBranchDetails, this.branch, new int?(MyProject.Forms.Form1.coid));
			this.GetBankingDetailsTableAdapter.Fill(this.POSDataSet.GetBankingDetails, new int?(MyProject.Forms.Form1.coid));
			this.BankingDetails2TableAdapter.Fill(this.POSDataSet.BankingDetails2, new int?(MyProject.Forms.Form1.coid));
			this.GetQuotationHeaderTableAdapter.Fill(this.POSDataSet.GetQuotationHeader, new int?(this.quotationnumber), new int?(MyProject.Forms.Form1.coid));
			this.ReportViewer1.RefreshReport();
		}

		// Token: 0x040017D4 RID: 6100
		public int quotationnumber;

		// Token: 0x040017D5 RID: 6101
		public string branch;

		// Token: 0x040017D6 RID: 6102
		public int coid;

		// Token: 0x040017D7 RID: 6103
		public string quotationHeader;

		// Token: 0x040017D8 RID: 6104
		private PublicFunctions pf;

		// Token: 0x040017D9 RID: 6105
		private string _cnn;
	}
}
