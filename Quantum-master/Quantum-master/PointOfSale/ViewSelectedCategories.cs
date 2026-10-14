using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;

namespace PointOfSale
{
	// Token: 0x02000216 RID: 534
	[DesignerGenerated]
	public partial class ViewSelectedCategories : Form
	{
		// Token: 0x06006002 RID: 24578 RVA: 0x0036E110 File Offset: 0x0036C310
		public ViewSelectedCategories()
		{
			base.Load += this.ViewSelectedCategories_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x170022BB RID: 8891
		// (get) Token: 0x06006005 RID: 24581 RVA: 0x0036E836 File Offset: 0x0036CA36
		// (set) Token: 0x06006006 RID: 24582 RVA: 0x0036E840 File Offset: 0x0036CA40
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022BC RID: 8892
		// (get) Token: 0x06006007 RID: 24583 RVA: 0x0036E849 File Offset: 0x0036CA49
		// (set) Token: 0x06006008 RID: 24584 RVA: 0x0036E853 File Offset: 0x0036CA53
		internal virtual TextBox txtDisplayEntryNo
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022BD RID: 8893
		// (get) Token: 0x06006009 RID: 24585 RVA: 0x0036E85C File Offset: 0x0036CA5C
		// (set) Token: 0x0600600A RID: 24586 RVA: 0x0036E866 File Offset: 0x0036CA66
		internal virtual Label Label14
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022BE RID: 8894
		// (get) Token: 0x0600600B RID: 24587 RVA: 0x0036E86F File Offset: 0x0036CA6F
		// (set) Token: 0x0600600C RID: 24588 RVA: 0x0036E879 File Offset: 0x0036CA79
		internal virtual Label lblDisplayNotEnteredTreatedAs
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022BF RID: 8895
		// (get) Token: 0x0600600D RID: 24589 RVA: 0x0036E882 File Offset: 0x0036CA82
		// (set) Token: 0x0600600E RID: 24590 RVA: 0x0036E88C File Offset: 0x0036CA8C
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022C0 RID: 8896
		// (get) Token: 0x0600600F RID: 24591 RVA: 0x0036E895 File Offset: 0x0036CA95
		// (set) Token: 0x06006010 RID: 24592 RVA: 0x0036E89F File Offset: 0x0036CA9F
		internal virtual TextBox txtDisplayCreatedBy
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022C1 RID: 8897
		// (get) Token: 0x06006011 RID: 24593 RVA: 0x0036E8A8 File Offset: 0x0036CAA8
		// (set) Token: 0x06006012 RID: 24594 RVA: 0x0036E8B2 File Offset: 0x0036CAB2
		internal virtual TextBox txtDisplayDateCreated
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022C2 RID: 8898
		// (get) Token: 0x06006013 RID: 24595 RVA: 0x0036E8BB File Offset: 0x0036CABB
		// (set) Token: 0x06006014 RID: 24596 RVA: 0x0036E8C5 File Offset: 0x0036CAC5
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022C3 RID: 8899
		// (get) Token: 0x06006015 RID: 24597 RVA: 0x0036E8CE File Offset: 0x0036CACE
		// (set) Token: 0x06006016 RID: 24598 RVA: 0x0036E8D8 File Offset: 0x0036CAD8
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022C4 RID: 8900
		// (get) Token: 0x06006017 RID: 24599 RVA: 0x0036E8E1 File Offset: 0x0036CAE1
		// (set) Token: 0x06006018 RID: 24600 RVA: 0x0036E8EB File Offset: 0x0036CAEB
		internal virtual TextBox txtDisplayRef
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170022C5 RID: 8901
		// (get) Token: 0x06006019 RID: 24601 RVA: 0x0036E8F4 File Offset: 0x0036CAF4
		// (set) Token: 0x0600601A RID: 24602 RVA: 0x0036E8FE File Offset: 0x0036CAFE
		internal virtual DataGridView DataGridView1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x0600601B RID: 24603 RVA: 0x0036E908 File Offset: 0x0036CB08
		private void ViewSelectedCategories_Load(object sender, EventArgs e)
		{
			try
			{
				this.txtDisplayCreatedBy.Text = this.createdby;
				this.txtDisplayDateCreated.Text = this.createddate.ToShortDateString();
				this.txtDisplayEntryNo.Text = this.refentryno.ToString();
				this.txtDisplayRef.Text = this.refdesc;
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.Text;
				sqlCommand.CommandText = string.Concat(new string[]
				{
					"select sc.catid,c.catdesc from stocktakecategories sc INNER JOIN CATEGORIES c on sc.catid=c.catid where sc.coid=",
					Conversions.ToString(MyProject.Forms.Form1.coid),
					"and refentryno=",
					this.txtDisplayEntryNo.Text,
					"and refdesc='",
					this.txtDisplayRef.Text,
					"' and branch='",
					MyProject.Forms.Form1.branch,
					"'"
				});
				DataTable dataTable = new DataTable();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				int num = sqlDataAdapter.Fill(dataTable);
				this.DataGridView1.DataSource = dataTable;
				this.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form, detail: " + ex.Message);
			}
		}

		// Token: 0x04002A39 RID: 10809
		public string refdesc;

		// Token: 0x04002A3A RID: 10810
		public int refentryno;

		// Token: 0x04002A3B RID: 10811
		public string createdby;

		// Token: 0x04002A3C RID: 10812
		public string display_note;

		// Token: 0x04002A3D RID: 10813
		public DateTime createddate;

		// Token: 0x04002A3E RID: 10814
		private string _cnn;
	}
}
