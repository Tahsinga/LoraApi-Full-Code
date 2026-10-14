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
	// Token: 0x0200003C RID: 60
	[DesignerGenerated]
	public partial class DeliveryNoteWarehouse : Form
	{
		// Token: 0x06000D26 RID: 3366 RVA: 0x00080910 File Offset: 0x0007EB10
		public DeliveryNoteWarehouse()
		{
			base.Load += this.DeliveryNoteWarehouse_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06000D29 RID: 3369 RVA: 0x00080FE3 File Offset: 0x0007F1E3
		// (set) Token: 0x06000D2A RID: 3370 RVA: 0x00080FED File Offset: 0x0007F1ED
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06000D2B RID: 3371 RVA: 0x00080FF6 File Offset: 0x0007F1F6
		// (set) Token: 0x06000D2C RID: 3372 RVA: 0x00081000 File Offset: 0x0007F200
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06000D2D RID: 3373 RVA: 0x00081009 File Offset: 0x0007F209
		// (set) Token: 0x06000D2E RID: 3374 RVA: 0x00081013 File Offset: 0x0007F213
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06000D2F RID: 3375 RVA: 0x0008101C File Offset: 0x0007F21C
		// (set) Token: 0x06000D30 RID: 3376 RVA: 0x00081026 File Offset: 0x0007F226
		internal virtual BindingSource GetPaymentMethodsForInvoiceBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06000D31 RID: 3377 RVA: 0x0008102F File Offset: 0x0007F22F
		// (set) Token: 0x06000D32 RID: 3378 RVA: 0x00081039 File Offset: 0x0007F239
		internal virtual BindingSource GetUserForInvoiceBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06000D33 RID: 3379 RVA: 0x00081042 File Offset: 0x0007F242
		// (set) Token: 0x06000D34 RID: 3380 RVA: 0x0008104C File Offset: 0x0007F24C
		internal virtual BindingSource FetchCustomerDetailsFromInvBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06000D35 RID: 3381 RVA: 0x00081055 File Offset: 0x0007F255
		// (set) Token: 0x06000D36 RID: 3382 RVA: 0x0008105F File Offset: 0x0007F25F
		internal virtual BindingSource GetBranchDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06000D37 RID: 3383 RVA: 0x00081068 File Offset: 0x0007F268
		// (set) Token: 0x06000D38 RID: 3384 RVA: 0x00081072 File Offset: 0x0007F272
		internal virtual BindingSource SalesByInvoiceNumberBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06000D39 RID: 3385 RVA: 0x0008107B File Offset: 0x0007F27B
		// (set) Token: 0x06000D3A RID: 3386 RVA: 0x00081085 File Offset: 0x0007F285
		internal virtual BindingSource GetBankingDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06000D3B RID: 3387 RVA: 0x0008108E File Offset: 0x0007F28E
		// (set) Token: 0x06000D3C RID: 3388 RVA: 0x00081098 File Offset: 0x0007F298
		internal virtual BindingSource BankingDetails2BindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06000D3D RID: 3389 RVA: 0x000810A1 File Offset: 0x0007F2A1
		// (set) Token: 0x06000D3E RID: 3390 RVA: 0x000810AB File Offset: 0x0007F2AB
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06000D3F RID: 3391 RVA: 0x000810B4 File Offset: 0x0007F2B4
		// (set) Token: 0x06000D40 RID: 3392 RVA: 0x000810BE File Offset: 0x0007F2BE
		internal virtual GetPaymentMethodsForInvoiceTableAdapter GetPaymentMethodsForInvoiceTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06000D41 RID: 3393 RVA: 0x000810C7 File Offset: 0x0007F2C7
		// (set) Token: 0x06000D42 RID: 3394 RVA: 0x000810D1 File Offset: 0x0007F2D1
		internal virtual GetUserForInvoiceTableAdapter GetUserForInvoiceTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06000D43 RID: 3395 RVA: 0x000810DA File Offset: 0x0007F2DA
		// (set) Token: 0x06000D44 RID: 3396 RVA: 0x000810E4 File Offset: 0x0007F2E4
		internal virtual FetchCustomerDetailsFromInvTableAdapter FetchCustomerDetailsFromInvTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06000D45 RID: 3397 RVA: 0x000810ED File Offset: 0x0007F2ED
		// (set) Token: 0x06000D46 RID: 3398 RVA: 0x000810F7 File Offset: 0x0007F2F7
		internal virtual GetBranchDetailsTableAdapter GetBranchDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06000D47 RID: 3399 RVA: 0x00081100 File Offset: 0x0007F300
		// (set) Token: 0x06000D48 RID: 3400 RVA: 0x0008110A File Offset: 0x0007F30A
		internal virtual SalesByInvoiceNumberTableAdapter SalesByInvoiceNumberTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06000D49 RID: 3401 RVA: 0x00081113 File Offset: 0x0007F313
		// (set) Token: 0x06000D4A RID: 3402 RVA: 0x0008111D File Offset: 0x0007F31D
		internal virtual GetBankingDetailsTableAdapter GetBankingDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06000D4B RID: 3403 RVA: 0x00081126 File Offset: 0x0007F326
		// (set) Token: 0x06000D4C RID: 3404 RVA: 0x00081130 File Offset: 0x0007F330
		internal virtual BankingDetails2TableAdapter BankingDetails2TableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x0008113C File Offset: 0x0007F33C
		private void DeliveryNoteWarehouse_Load(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
				this.GetCompanyDetailsTableAdapter.Connection = sqlConnection;
				this.SalesByInvoiceNumberTableAdapter.Connection = sqlConnection;
				this.GetPaymentMethodsForInvoiceTableAdapter.Connection = sqlConnection;
				this.GetUserForInvoiceTableAdapter.Connection = sqlConnection;
				this.FetchCustomerDetailsFromInvTableAdapter.Connection = sqlConnection;
				this.GetBranchDetailsTableAdapter.Connection = sqlConnection;
				this.GetBankingDetailsTableAdapter.Connection = sqlConnection;
				this.BankingDetails2TableAdapter.Connection = sqlConnection;
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
				bool flag2 = MyProject.Forms.Form1.IsWarehouse == 1;
				bool flag3 = flag2;
				ReportParameter reportParameter = new ReportParameter("BranchNetwork", text);
				ReportParameter reportParameter2 = new ReportParameter("IsWarehouse", Conversions.ToString(flag3));
				ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter2 };
				this.ReportViewer1.LocalReport.SetParameters(array);
				this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
				this.SalesByInvoiceNumberTableAdapter.Fill(this.POSDataSet.SalesByInvoiceNumber, new int?(this.invnum), new int?(MyProject.Forms.Form1.coid), MyProject.Forms.Form1.branch);
				this.GetPaymentMethodsForInvoiceTableAdapter.Fill(this.POSDataSet.GetPaymentMethodsForInvoice, new long?((long)this.invnum), new int?(MyProject.Forms.Form1.coid), MyProject.Forms.Form1.branch);
				this.GetUserForInvoiceTableAdapter.Fill(this.POSDataSet.GetUserForInvoice, new int?(this.invnum), new int?(MyProject.Forms.Form1.coid), MyProject.Forms.Form1.branch);
				this.FetchCustomerDetailsFromInvTableAdapter.Fill(this.POSDataSet.FetchCustomerDetailsFromInv, new int?(this.invnum), new int?(MyProject.Forms.Form1.coid), MyProject.Forms.Form1.branch);
				this.GetBranchDetailsTableAdapter.Fill(this.POSDataSet.GetBranchDetails, MyProject.Forms.Form1.branch, new int?(MyProject.Forms.Form1.coid));
				this.GetBankingDetailsTableAdapter.Fill(this.POSDataSet.GetBankingDetails, new int?(MyProject.Forms.Form1.coid));
				this.BankingDetails2TableAdapter.Fill(this.POSDataSet.BankingDetails2, new int?(MyProject.Forms.Form1.coid));
				this.ReportViewer1.RefreshReport();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading report. Detail: " + ex.Message);
			}
		}

		// Token: 0x0400063A RID: 1594
		public int invnum;

		// Token: 0x0400063B RID: 1595
		private string _cnn;

		// Token: 0x0400063C RID: 1596
		private PublicFunctions pf;
	}
}
