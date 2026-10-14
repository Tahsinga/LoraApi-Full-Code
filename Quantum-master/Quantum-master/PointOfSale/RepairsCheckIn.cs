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
	// Token: 0x02000181 RID: 385
	[DesignerGenerated]
	public partial class RepairsCheckIn : Form
	{
		// Token: 0x06003938 RID: 14648 RVA: 0x001F2AE0 File Offset: 0x001F0CE0
		public RepairsCheckIn()
		{
			base.Load += this.RepairsCheckIn_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x1700151A RID: 5402
		// (get) Token: 0x0600393B RID: 14651 RVA: 0x001F2E7F File Offset: 0x001F107F
		// (set) Token: 0x0600393C RID: 14652 RVA: 0x001F2E89 File Offset: 0x001F1089
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700151B RID: 5403
		// (get) Token: 0x0600393D RID: 14653 RVA: 0x001F2E92 File Offset: 0x001F1092
		// (set) Token: 0x0600393E RID: 14654 RVA: 0x001F2E9C File Offset: 0x001F109C
		internal virtual BindingSource GetCompanyDetailsForCoidBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700151C RID: 5404
		// (get) Token: 0x0600393F RID: 14655 RVA: 0x001F2EA5 File Offset: 0x001F10A5
		// (set) Token: 0x06003940 RID: 14656 RVA: 0x001F2EAF File Offset: 0x001F10AF
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700151D RID: 5405
		// (get) Token: 0x06003941 RID: 14657 RVA: 0x001F2EB8 File Offset: 0x001F10B8
		// (set) Token: 0x06003942 RID: 14658 RVA: 0x001F2EC2 File Offset: 0x001F10C2
		internal virtual BindingSource RepairsViewBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700151E RID: 5406
		// (get) Token: 0x06003943 RID: 14659 RVA: 0x001F2ECB File Offset: 0x001F10CB
		// (set) Token: 0x06003944 RID: 14660 RVA: 0x001F2ED5 File Offset: 0x001F10D5
		internal virtual GetCompanyDetailsForCoidTableAdapter GetCompanyDetailsForCoidTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700151F RID: 5407
		// (get) Token: 0x06003945 RID: 14661 RVA: 0x001F2EDE File Offset: 0x001F10DE
		// (set) Token: 0x06003946 RID: 14662 RVA: 0x001F2EE8 File Offset: 0x001F10E8
		internal virtual RepairsViewTableAdapter RepairsViewTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001520 RID: 5408
		// (get) Token: 0x06003947 RID: 14663 RVA: 0x001F2EF1 File Offset: 0x001F10F1
		// (set) Token: 0x06003948 RID: 14664 RVA: 0x001F2EFB File Offset: 0x001F10FB
		internal virtual BindingSource GetBranchDetails1BindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001521 RID: 5409
		// (get) Token: 0x06003949 RID: 14665 RVA: 0x001F2F04 File Offset: 0x001F1104
		// (set) Token: 0x0600394A RID: 14666 RVA: 0x001F2F0E File Offset: 0x001F110E
		internal virtual GetBranchDetails1TableAdapter GetBranchDetails1TableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x0600394B RID: 14667 RVA: 0x001F2F18 File Offset: 0x001F1118
		private void RepairsCheckIn_Load(object sender, EventArgs e)
		{
			try
			{
				this.RunReport();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading report. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600394C RID: 14668 RVA: 0x001F2F68 File Offset: 0x001F1168
		private void RunReport()
		{
			SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
			this.GetCompanyDetailsForCoidTableAdapter.Connection = sqlConnection;
			this.RepairsViewTableAdapter.Connection = sqlConnection;
			this.GetBranchDetails1TableAdapter.Connection = sqlConnection;
			this.GetCompanyDetailsForCoidTableAdapter.Fill(this.POSDataSet.GetCompanyDetailsForCoid, new int?(MyProject.Forms.Form1.coid));
			this.RepairsViewTableAdapter.Fill(this.POSDataSet.RepairsView, new int?(MyProject.Forms.Form1.coid), MyProject.Forms.Form1.branch, new int?(this.CheckInEntryno));
			this.GetBranchDetails1TableAdapter.Fill(this.POSDataSet.GetBranchDetails1, MyProject.Forms.Form1.branch, new int?(MyProject.Forms.Form1.coid), new int?(0));
			this.ReportViewer1.RefreshReport();
		}

		// Token: 0x04001865 RID: 6245
		public int CheckInEntryno;

		// Token: 0x04001866 RID: 6246
		private string _cnn;
	}
}
