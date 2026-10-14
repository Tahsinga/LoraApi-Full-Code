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
	// Token: 0x020001A4 RID: 420
	[DesignerGenerated]
	public partial class SalesInvoice : Form
	{
		// Token: 0x06004B33 RID: 19251 RVA: 0x002D1324 File Offset: 0x002CF524
		public SalesInvoice()
		{
			base.Load += this.SalesInvoice_Load;
			this.InitializeComponent();
		}

		// Token: 0x17001B80 RID: 7040
		// (get) Token: 0x06004B36 RID: 19254 RVA: 0x002D17E7 File Offset: 0x002CF9E7
		// (set) Token: 0x06004B37 RID: 19255 RVA: 0x002D17F1 File Offset: 0x002CF9F1
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B81 RID: 7041
		// (get) Token: 0x06004B38 RID: 19256 RVA: 0x002D17FA File Offset: 0x002CF9FA
		// (set) Token: 0x06004B39 RID: 19257 RVA: 0x002D1804 File Offset: 0x002CFA04
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B82 RID: 7042
		// (get) Token: 0x06004B3A RID: 19258 RVA: 0x002D180D File Offset: 0x002CFA0D
		// (set) Token: 0x06004B3B RID: 19259 RVA: 0x002D1817 File Offset: 0x002CFA17
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B83 RID: 7043
		// (get) Token: 0x06004B3C RID: 19260 RVA: 0x002D1820 File Offset: 0x002CFA20
		// (set) Token: 0x06004B3D RID: 19261 RVA: 0x002D182A File Offset: 0x002CFA2A
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B84 RID: 7044
		// (get) Token: 0x06004B3E RID: 19262 RVA: 0x002D1833 File Offset: 0x002CFA33
		// (set) Token: 0x06004B3F RID: 19263 RVA: 0x002D183D File Offset: 0x002CFA3D
		internal virtual BindingSource SalesByInvoiceNumberBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B85 RID: 7045
		// (get) Token: 0x06004B40 RID: 19264 RVA: 0x002D1846 File Offset: 0x002CFA46
		// (set) Token: 0x06004B41 RID: 19265 RVA: 0x002D1850 File Offset: 0x002CFA50
		internal virtual SalesByInvoiceNumberTableAdapter SalesByInvoiceNumberTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B86 RID: 7046
		// (get) Token: 0x06004B42 RID: 19266 RVA: 0x002D1859 File Offset: 0x002CFA59
		// (set) Token: 0x06004B43 RID: 19267 RVA: 0x002D1863 File Offset: 0x002CFA63
		internal virtual BindingSource GetPaymentMethodsForInvoiceBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B87 RID: 7047
		// (get) Token: 0x06004B44 RID: 19268 RVA: 0x002D186C File Offset: 0x002CFA6C
		// (set) Token: 0x06004B45 RID: 19269 RVA: 0x002D1876 File Offset: 0x002CFA76
		internal virtual GetPaymentMethodsForInvoiceTableAdapter GetPaymentMethodsForInvoiceTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B88 RID: 7048
		// (get) Token: 0x06004B46 RID: 19270 RVA: 0x002D187F File Offset: 0x002CFA7F
		// (set) Token: 0x06004B47 RID: 19271 RVA: 0x002D1889 File Offset: 0x002CFA89
		internal virtual BindingSource GetUserForInvoiceBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B89 RID: 7049
		// (get) Token: 0x06004B48 RID: 19272 RVA: 0x002D1892 File Offset: 0x002CFA92
		// (set) Token: 0x06004B49 RID: 19273 RVA: 0x002D189C File Offset: 0x002CFA9C
		internal virtual GetUserForInvoiceTableAdapter GetUserForInvoiceTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B8A RID: 7050
		// (get) Token: 0x06004B4A RID: 19274 RVA: 0x002D18A5 File Offset: 0x002CFAA5
		// (set) Token: 0x06004B4B RID: 19275 RVA: 0x002D18AF File Offset: 0x002CFAAF
		internal virtual BindingSource FetchCustomerDetailsFromInvBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B8B RID: 7051
		// (get) Token: 0x06004B4C RID: 19276 RVA: 0x002D18B8 File Offset: 0x002CFAB8
		// (set) Token: 0x06004B4D RID: 19277 RVA: 0x002D18C2 File Offset: 0x002CFAC2
		internal virtual FetchCustomerDetailsFromInvTableAdapter FetchCustomerDetailsFromInvTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06004B4E RID: 19278 RVA: 0x002D18CC File Offset: 0x002CFACC
		private void SalesInvoice_Load(object sender, EventArgs e)
		{
			SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
			this.GetCompanyDetailsTableAdapter.Connection = sqlConnection;
			this.SalesByInvoiceNumberTableAdapter.Connection = sqlConnection;
			this.GetPaymentMethodsForInvoiceTableAdapter.Connection = sqlConnection;
			this.GetUserForInvoiceTableAdapter.Connection = sqlConnection;
			this.FetchCustomerDetailsFromInvTableAdapter.Connection = sqlConnection;
			this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
			this.SalesByInvoiceNumberTableAdapter.Fill(this.POSDataSet.SalesByInvoiceNumber, new int?(this.invnum), new int?(MyProject.Forms.Form1.coid), MyProject.Forms.Form1.branch);
			this.GetPaymentMethodsForInvoiceTableAdapter.Fill(this.POSDataSet.GetPaymentMethodsForInvoice, new long?((long)this.invnum), new int?(MyProject.Forms.Form1.coid), MyProject.Forms.Form1.branch);
			this.GetUserForInvoiceTableAdapter.Fill(this.POSDataSet.GetUserForInvoice, new int?(this.invnum), new int?(MyProject.Forms.Form1.coid), MyProject.Forms.Form1.branch);
			this.FetchCustomerDetailsFromInvTableAdapter.Fill(this.POSDataSet.FetchCustomerDetailsFromInv, new int?(this.invnum), new int?(MyProject.Forms.Form1.coid), MyProject.Forms.Form1.branch);
			this.ReportViewer1.RefreshReport();
		}

		// Token: 0x04002107 RID: 8455
		public int invnum;
	}
}
