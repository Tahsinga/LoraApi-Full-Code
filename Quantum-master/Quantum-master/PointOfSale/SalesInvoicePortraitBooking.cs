using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.POSDataSetTableAdapters;

namespace PointOfSale
{
	// Token: 0x020001A6 RID: 422
	[DesignerGenerated]
	internal partial class SalesInvoicePortraitBooking : Form
	{
		// Token: 0x06004B86 RID: 19334 RVA: 0x002D2F9F File Offset: 0x002D119F
		public SalesInvoicePortraitBooking()
		{
			this.InitializeComponent();
		}

		// Token: 0x17001BA2 RID: 7074
		// (get) Token: 0x06004B89 RID: 19337 RVA: 0x002D36D3 File Offset: 0x002D18D3
		// (set) Token: 0x06004B8A RID: 19338 RVA: 0x002D36DD File Offset: 0x002D18DD
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BA3 RID: 7075
		// (get) Token: 0x06004B8B RID: 19339 RVA: 0x002D36E6 File Offset: 0x002D18E6
		// (set) Token: 0x06004B8C RID: 19340 RVA: 0x002D36F0 File Offset: 0x002D18F0
		internal virtual BindingSource GetPaymentMethodsForInvoiceBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BA4 RID: 7076
		// (get) Token: 0x06004B8D RID: 19341 RVA: 0x002D36F9 File Offset: 0x002D18F9
		// (set) Token: 0x06004B8E RID: 19342 RVA: 0x002D3703 File Offset: 0x002D1903
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BA5 RID: 7077
		// (get) Token: 0x06004B8F RID: 19343 RVA: 0x002D370C File Offset: 0x002D190C
		// (set) Token: 0x06004B90 RID: 19344 RVA: 0x002D3716 File Offset: 0x002D1916
		internal virtual BindingSource GetUserForInvoiceBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BA6 RID: 7078
		// (get) Token: 0x06004B91 RID: 19345 RVA: 0x002D371F File Offset: 0x002D191F
		// (set) Token: 0x06004B92 RID: 19346 RVA: 0x002D3729 File Offset: 0x002D1929
		internal virtual BindingSource FetchCustomerDetailsFromInvBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BA7 RID: 7079
		// (get) Token: 0x06004B93 RID: 19347 RVA: 0x002D3732 File Offset: 0x002D1932
		// (set) Token: 0x06004B94 RID: 19348 RVA: 0x002D373C File Offset: 0x002D193C
		internal virtual BindingSource SalesByInvoiceNumberBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BA8 RID: 7080
		// (get) Token: 0x06004B95 RID: 19349 RVA: 0x002D3745 File Offset: 0x002D1945
		// (set) Token: 0x06004B96 RID: 19350 RVA: 0x002D374F File Offset: 0x002D194F
		internal virtual GetPaymentMethodsForInvoiceTableAdapter GetPaymentMethodsForInvoiceTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BA9 RID: 7081
		// (get) Token: 0x06004B97 RID: 19351 RVA: 0x002D3758 File Offset: 0x002D1958
		// (set) Token: 0x06004B98 RID: 19352 RVA: 0x002D3762 File Offset: 0x002D1962
		internal virtual GetUserForInvoiceTableAdapter GetUserForInvoiceTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BAA RID: 7082
		// (get) Token: 0x06004B99 RID: 19353 RVA: 0x002D376B File Offset: 0x002D196B
		// (set) Token: 0x06004B9A RID: 19354 RVA: 0x002D3775 File Offset: 0x002D1975
		internal virtual FetchCustomerDetailsFromInvTableAdapter FetchCustomerDetailsFromInvTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BAB RID: 7083
		// (get) Token: 0x06004B9B RID: 19355 RVA: 0x002D377E File Offset: 0x002D197E
		// (set) Token: 0x06004B9C RID: 19356 RVA: 0x002D3788 File Offset: 0x002D1988
		internal virtual SalesByInvoiceNumberTableAdapter SalesByInvoiceNumberTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BAC RID: 7084
		// (get) Token: 0x06004B9D RID: 19357 RVA: 0x002D3791 File Offset: 0x002D1991
		// (set) Token: 0x06004B9E RID: 19358 RVA: 0x002D379B File Offset: 0x002D199B
		internal virtual BindingSource GetBranchDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BAD RID: 7085
		// (get) Token: 0x06004B9F RID: 19359 RVA: 0x002D37A4 File Offset: 0x002D19A4
		// (set) Token: 0x06004BA0 RID: 19360 RVA: 0x002D37AE File Offset: 0x002D19AE
		internal virtual GetBranchDetailsTableAdapter GetBranchDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BAE RID: 7086
		// (get) Token: 0x06004BA1 RID: 19361 RVA: 0x002D37B7 File Offset: 0x002D19B7
		// (set) Token: 0x06004BA2 RID: 19362 RVA: 0x002D37C1 File Offset: 0x002D19C1
		internal virtual BindingSource GetBankingDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BAF RID: 7087
		// (get) Token: 0x06004BA3 RID: 19363 RVA: 0x002D37CA File Offset: 0x002D19CA
		// (set) Token: 0x06004BA4 RID: 19364 RVA: 0x002D37D4 File Offset: 0x002D19D4
		internal virtual GetBankingDetailsTableAdapter GetBankingDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BB0 RID: 7088
		// (get) Token: 0x06004BA5 RID: 19365 RVA: 0x002D37DD File Offset: 0x002D19DD
		// (set) Token: 0x06004BA6 RID: 19366 RVA: 0x002D37E7 File Offset: 0x002D19E7
		internal virtual BindingSource BankingDetails2BindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BB1 RID: 7089
		// (get) Token: 0x06004BA7 RID: 19367 RVA: 0x002D37F0 File Offset: 0x002D19F0
		// (set) Token: 0x06004BA8 RID: 19368 RVA: 0x002D37FA File Offset: 0x002D19FA
		internal virtual BankingDetails2TableAdapter BankingDetails2TableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BB2 RID: 7090
		// (get) Token: 0x06004BA9 RID: 19369 RVA: 0x002D3803 File Offset: 0x002D1A03
		// (set) Token: 0x06004BAA RID: 19370 RVA: 0x002D380D File Offset: 0x002D1A0D
		internal virtual BindingSource SalesByInvoiceNumberTotalsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BB3 RID: 7091
		// (get) Token: 0x06004BAB RID: 19371 RVA: 0x002D3816 File Offset: 0x002D1A16
		// (set) Token: 0x06004BAC RID: 19372 RVA: 0x002D3820 File Offset: 0x002D1A20
		internal virtual SalesByInvoiceNumberTotalsTableAdapter SalesByInvoiceNumberTotalsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BB4 RID: 7092
		// (get) Token: 0x06004BAD RID: 19373 RVA: 0x002D3829 File Offset: 0x002D1A29
		// (set) Token: 0x06004BAE RID: 19374 RVA: 0x002D3833 File Offset: 0x002D1A33
		internal virtual BindingSource GetCompanyDetailsForCoidBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001BB5 RID: 7093
		// (get) Token: 0x06004BAF RID: 19375 RVA: 0x002D383C File Offset: 0x002D1A3C
		// (set) Token: 0x06004BB0 RID: 19376 RVA: 0x002D3846 File Offset: 0x002D1A46
		internal virtual GetCompanyDetailsForCoidTableAdapter GetCompanyDetailsForCoidTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}
	}
}
