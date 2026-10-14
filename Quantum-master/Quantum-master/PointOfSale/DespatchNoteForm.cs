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
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;
using PointOfSale.POSDataSetTableAdapters;

namespace PointOfSale
{
	// Token: 0x0200003F RID: 63
	[DesignerGenerated]
	public partial class DespatchNoteForm : Form
	{
		// Token: 0x06000E40 RID: 3648 RVA: 0x00089BF4 File Offset: 0x00087DF4
		public DespatchNoteForm()
		{
			base.Load += this.DespatchNoteForm_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.reprint = 0;
			this.isEltradeESDfiscal = 0;
			this.branch = "";
			this.showinvdisc = 0;
			this.isfiscal = 0;
			this.showSellingPrice = 0;
			this.InitializeComponent();
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06000E43 RID: 3651 RVA: 0x0008A179 File Offset: 0x00088379
		// (set) Token: 0x06000E44 RID: 3652 RVA: 0x0008A183 File Offset: 0x00088383
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06000E45 RID: 3653 RVA: 0x0008A18C File Offset: 0x0008838C
		// (set) Token: 0x06000E46 RID: 3654 RVA: 0x0008A196 File Offset: 0x00088396
		internal virtual BindingSource GetUserForInvoiceBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06000E47 RID: 3655 RVA: 0x0008A19F File Offset: 0x0008839F
		// (set) Token: 0x06000E48 RID: 3656 RVA: 0x0008A1A9 File Offset: 0x000883A9
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06000E49 RID: 3657 RVA: 0x0008A1B2 File Offset: 0x000883B2
		// (set) Token: 0x06000E4A RID: 3658 RVA: 0x0008A1BC File Offset: 0x000883BC
		internal virtual BindingSource DespatchNoteBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06000E4B RID: 3659 RVA: 0x0008A1C5 File Offset: 0x000883C5
		// (set) Token: 0x06000E4C RID: 3660 RVA: 0x0008A1CF File Offset: 0x000883CF
		internal virtual BindingSource GetBranchDetails1BindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06000E4D RID: 3661 RVA: 0x0008A1D8 File Offset: 0x000883D8
		// (set) Token: 0x06000E4E RID: 3662 RVA: 0x0008A1E2 File Offset: 0x000883E2
		internal virtual BindingSource GetCompanyDetailsForCoidBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06000E4F RID: 3663 RVA: 0x0008A1EB File Offset: 0x000883EB
		// (set) Token: 0x06000E50 RID: 3664 RVA: 0x0008A1F5 File Offset: 0x000883F5
		internal virtual GetUserForInvoiceTableAdapter GetUserForInvoiceTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06000E51 RID: 3665 RVA: 0x0008A1FE File Offset: 0x000883FE
		// (set) Token: 0x06000E52 RID: 3666 RVA: 0x0008A208 File Offset: 0x00088408
		internal virtual DespatchNoteTableAdapter DespatchNoteTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06000E53 RID: 3667 RVA: 0x0008A211 File Offset: 0x00088411
		// (set) Token: 0x06000E54 RID: 3668 RVA: 0x0008A21B File Offset: 0x0008841B
		internal virtual GetBranchDetails1TableAdapter GetBranchDetails1TableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06000E55 RID: 3669 RVA: 0x0008A224 File Offset: 0x00088424
		// (set) Token: 0x06000E56 RID: 3670 RVA: 0x0008A22E File Offset: 0x0008842E
		internal virtual GetCompanyDetailsForCoidTableAdapter GetCompanyDetailsForCoidTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06000E57 RID: 3671 RVA: 0x0008A237 File Offset: 0x00088437
		// (set) Token: 0x06000E58 RID: 3672 RVA: 0x0008A241 File Offset: 0x00088441
		internal virtual BindingSource GetUserForDespatchBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06000E59 RID: 3673 RVA: 0x0008A24A File Offset: 0x0008844A
		// (set) Token: 0x06000E5A RID: 3674 RVA: 0x0008A254 File Offset: 0x00088454
		internal virtual BindingSource FetchCustomerDetailsFromDespatchBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06000E5B RID: 3675 RVA: 0x0008A25D File Offset: 0x0008845D
		// (set) Token: 0x06000E5C RID: 3676 RVA: 0x0008A267 File Offset: 0x00088467
		internal virtual GetUserForDespatchTableAdapter GetUserForDespatchTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06000E5D RID: 3677 RVA: 0x0008A270 File Offset: 0x00088470
		// (set) Token: 0x06000E5E RID: 3678 RVA: 0x0008A27A File Offset: 0x0008847A
		internal virtual FetchCustomerDetailsFromDespatchTableAdapter FetchCustomerDetailsFromDespatchTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06000E5F RID: 3679 RVA: 0x0008A284 File Offset: 0x00088484
		private void DespatchNoteForm_Load(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
				this.GetCompanyDetailsForCoidTableAdapter.Connection = sqlConnection;
				this.GetUserForInvoiceTableAdapter.Connection = sqlConnection;
				this.FetchCustomerDetailsFromDespatchTableAdapter.Connection = sqlConnection;
				this.GetBranchDetails1TableAdapter.Connection = sqlConnection;
				this.DespatchNoteTableAdapter.Connection = sqlConnection;
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
				ReportParameter reportParameter3 = new ReportParameter("digsig", this.revmax_sign);
				ReportParameter reportParameter4 = new ReportParameter("reprint", Conversions.ToString(Conversions.ToInteger(Interaction.IIf(this.reprint == 1, 1, 0))));
				bool flag4 = Operators.CompareString(this.revmax_sign, "", false) != 0;
				if (flag4)
				{
					this.isfiscal = 1;
				}
				bool flag5 = this.isEltradeESDfiscal == 1;
				if (flag5)
				{
					this.isfiscal = 1;
				}
				ReportParameter reportParameter5 = new ReportParameter("isfiscal", Conversions.ToString(this.isfiscal));
				ReportParameter reportParameter6 = new ReportParameter("ShowFooter", Conversions.ToString(MyProject.Forms.Form1.showfooter));
				ReportParameter reportParameter7 = new ReportParameter("invheader", MyProject.Forms.Form1.InvoiceHeaderText);
				ReportParameter reportParameter8 = new ReportParameter("ShowInvDisc", Conversions.ToString(this.showinvdisc));
				ReportParameter reportParameter9 = new ReportParameter("ShowSellingPrice", Conversions.ToString(this.showSellingPrice));
				ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter2, reportParameter3, reportParameter4, reportParameter5, reportParameter6, reportParameter7, reportParameter8, reportParameter9 };
				this.ReportViewer1.LocalReport.SetParameters(array);
				this.GetCompanyDetailsForCoidTableAdapter.Fill(this.POSDataSet.GetCompanyDetailsForCoid, new int?(MyProject.Forms.Form1.coid));
				this.GetUserForInvoiceTableAdapter.Fill(this.POSDataSet.GetUserForInvoice, new int?(this.invnum), new int?(MyProject.Forms.Form1.coid), this.branch);
				this.FetchCustomerDetailsFromDespatchTableAdapter.Fill(this.POSDataSet.FetchCustomerDetailsFromDespatch, new int?(this.invnum), new int?(MyProject.Forms.Form1.coid), this.branch);
				this.GetBranchDetails1TableAdapter.Fill(this.POSDataSet.GetBranchDetails1, this.branch, new int?(MyProject.Forms.Form1.coid), new int?(0));
				this.DespatchNoteTableAdapter.Fill(this.POSDataSet.DespatchNote, new int?(this.invnum), new int?(MyProject.Forms.Form1.coid), MyProject.Forms.Form1.branch);
				this.ReportViewer1.RefreshReport();
				bool flag6 = (Operators.CompareString(MyProject.Forms.Form1.PrintFilePath, "", false) != 0) & (MyProject.Forms.Form1.PrintToFile == 1) & (this.reprint == 0);
				if (flag6)
				{
					this.pf.SaveReportToPDF(this.ReportViewer1, MyProject.Forms.Form1.PrintFilePath, this.invnum);
					base.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading report. Detail: " + ex.Message);
			}
		}

		// Token: 0x040006D2 RID: 1746
		public int invnum;

		// Token: 0x040006D3 RID: 1747
		private string _cnn;

		// Token: 0x040006D4 RID: 1748
		private PublicFunctions pf;

		// Token: 0x040006D5 RID: 1749
		public string revmax_sign;

		// Token: 0x040006D6 RID: 1750
		public int reprint;

		// Token: 0x040006D7 RID: 1751
		public int isEltradeESDfiscal;

		// Token: 0x040006D8 RID: 1752
		public string branch;

		// Token: 0x040006D9 RID: 1753
		public int showinvdisc;

		// Token: 0x040006DA RID: 1754
		public int isfiscal;

		// Token: 0x040006DB RID: 1755
		public int showSellingPrice;
	}
}
